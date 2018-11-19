// <copyright file="YouTubeDownloaderForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using YoutubeExplode;
    using YoutubeExplode.Models.MediaStreams;

    /// <summary>
    /// YouTube downloader form.
    /// </summary>
    public partial class YouTubeDownloaderForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "YouTube Downloader";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.2";

        /// <summary>
        /// The last selected path.
        /// </summary>
        private string lastSelectedPath = string.Empty;

        /// <summary>
        /// The progress.
        /// </summary>
        private double progress;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.YouTubeDownloaderForm"/> class.
        /// </summary>
        public YouTubeDownloaderForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the progress.
        /// </summary>
        /// <value>The progress.</value>
        public double Progress
        {
            // Getter
            get
            {
                // Return progress
                return this.progress;
            }

            // Setter
            private set
            {
                // Set progress
                this.progress = (double)value;

                // Inform user about progress 
                this.mainToolStripStatusLabel.Text = $"Download progress: {(100.0 * this.progress).ToString("N0")}%";
            }
        }

        /// <summary>
        /// Handles the download button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDownloadButtonClick(object sender, EventArgs e)
        {
            // Check for valid video text length
            if (this.videoTextBox.Text.Length == 0)
            {
                // Set status
                this.mainToolStripStatusLabel.Text = "Please enter video to fetch";

                // Halt flow
                return;
            }

            // Set video id
            var id = this.GetVideoId(this.videoTextBox.Text);

            // Check for valid length
            if (id.Length == 0)
            {
                // Set status
                this.mainToolStripStatusLabel.Text = "No valid video ID to fetch";

                // Halt flow
                return;
            }

            // Disable download button
            this.downloadButton.Enabled = false;

            // Set status
            this.mainToolStripStatusLabel.Text = $"Processing id \"{id}\"";

            /* Get video */

            // Download video async
            Task videoDownloadTask = this.DownloadVideoAsync(id);
        }

        /// <summary>
        /// Downloads the video async.
        /// </summary>
        /// <returns>The video async.</returns>
        /// <param name="id">The identifier.</param>
        private async Task DownloadVideoAsync(string id)
        {
            // YouTube Client
            var youTubeClient = new YoutubeClient();

            // Safe title
            var safeTitle = string.Empty;

            // Inform user
            this.mainToolStripStatusLabel.Text = "Obtaining video info...";

            // Get video info
            try
            {
                // Get video info
                var videoInfo = await youTubeClient.GetVideoAsync(id);

                // Set safe tifle
                safeTitle = string.Join(string.Empty, videoInfo.Title.Split(Path.GetInvalidFileNameChars()));
            }
            catch (Exception)
            {
                // Inform user
                this.mainToolStripStatusLabel.Text = "Video info fetch error";

                // Halt flow
                goto ErrorExit;
            }

            // Inform user
            this.mainToolStripStatusLabel.Text = "Obtaining media stream info...";

            // Download video
            try
            {
                // Get media stream info set
                var mediaStreamInfoSet = await youTubeClient.GetVideoMediaStreamInfosAsync(id);

                // Get highest quality muxed stream info
                var muxedStreamInfo = mediaStreamInfoSet.Muxed.WithHighestVideoQuality();

                // Set file name
                var videoFileName = $"{safeTitle}-{id}.{muxedStreamInfo.Container.GetFileExtension()}";

                // New folder browser dialog
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    // Show new folder button
                    folderBrowserDialog.ShowNewFolderButton = true;

                    // Set last selected path
                    folderBrowserDialog.SelectedPath = this.lastSelectedPath;

                    // Set description
                    folderBrowserDialog.Description = "Set download destination";

                    // Inform user
                    this.mainToolStripStatusLabel.Text = "Obtaining destination folder...";

                    // Show the FolderBrowserDialog and check for path
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Disable download button
                        this.downloadButton.Enabled = false;

                        // Inform user
                        this.mainToolStripStatusLabel.Text = "Downloading video to folder...";

                        // Set last selected path
                        this.lastSelectedPath = folderBrowserDialog.SelectedPath;

                        // Set progress handler
                        var progressHandler = new Progress<double>(p => this.Progress = p);

                        // Save the file
                        await youTubeClient.DownloadMediaStreamAsync(muxedStreamInfo, Path.Combine(folderBrowserDialog.SelectedPath, videoFileName), progressHandler);

                        // Inform user
                        this.mainToolStripStatusLabel.Text = "Video download complete";
                    }
                    else
                    {
                        // TODO Back to square one [Implement SetStatus(msgid) where msgid is unique to avoid redundancies, keeping it DRY]
                        this.mainToolStripStatusLabel.Text = "Waiting for video...";
                    }
                }
            }
            catch (Exception)
            {
                // Inform user
                this.mainToolStripStatusLabel.Text = "Video download error";
            }

        // The error exit label
        ErrorExit:

            // Enable download button
            this.downloadButton.Enabled = true;
        }

        /// <summary>
        /// Handles the cut tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check for video text
            if (this.videoTextBox.Text.Length > 0)
            {
                // Copy current video text to clipboard
                Clipboard.SetText(this.videoTextBox.Text);

                // Clear video text box
                this.videoTextBox.Clear();
            }
        }

        /// <summary>
        /// Handles the copy tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check for video text
            if (this.videoTextBox.Text.Length > 0)
            {
                // Copy current video text to clipboard
                Clipboard.SetText(this.videoTextBox.Text);
            }
        }

        /// <summary>
        /// Handles the paste tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPasteToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check for clipboard text
            if (Clipboard.GetText().Length > 0)
            {
                // Clear video text box
                this.videoTextBox.Clear();

                // Paste from clipboard
                this.videoTextBox.Text = Clipboard.GetText();
            }
        }

        /// <summary>
        /// Handles the select all tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Select all text
            this.videoTextBox.SelectAll();
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // License text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Youtube Explode:{Environment.NewLine}https://github.com/Tyrrrz/YoutubeExplode/blob/master/License.txt{Environment.NewLine}{Environment.NewLine}" +
                $"AngleSharp:{Environment.NewLine}https://raw.githubusercontent.com/AngleSharp/AngleSharp/master/LICENSE{Environment.NewLine}{Environment.NewLine}" +
                $"Newtonsoft.Json{Environment.NewLine}https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md";

            // Set about form
            var aboutForm = new AboutForm(
                $"About {this.moduleName}",
                $"{this.moduleName} {this.semanticVersion}",
                "Week #46 @ November 2018",
                licenseText,
                this.Icon.ToBitmap());

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the video text box enter event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnVideoTextBoxEnter(object sender, EventArgs e)
        {
            // Confirm check status
            if (this.pasteOnFocusToolStripMenuItem.Checked)
            {
                // Check for something in the clipboard
                if (Clipboard.GetText().Length > 0)
                {
                    // Check for something different
                    if (Clipboard.GetText() != this.videoTextBox.Text)
                    {
                        // Check video id
                        if (this.GetVideoId(Clipboard.GetText()).Length > 0)
                        {
                            // Paste
                            this.videoTextBox.Text = Clipboard.GetText();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set clicked item
            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle check state
            clickedItem.Checked = !clickedItem.Checked;
        }

        /// <summary>
        /// Gets the video identifier.
        /// </summary>
        /// <returns>The video identifier.</returns>
        /// <param name="videoText">Video text.</param>
        private string GetVideoId(string videoText)
        {
            // Check length for video id
            if (videoText.Length == 11)
            {
                // Assume video
                videoText = $"https://www.youtube.com/watch?v={videoText}";
            }

            // Try to parse
            try
            {
                // Declare video id
                string videoId;

                // Try to set id
                if (YoutubeClient.TryParseVideoId(videoText, out videoId))
                {
                    // Return parsed video id
                    return videoId;
                }
            }
            finally
            {
                // Let it fall through
            }

            // Return empty string
            return string.Empty;
        }
    }
}
