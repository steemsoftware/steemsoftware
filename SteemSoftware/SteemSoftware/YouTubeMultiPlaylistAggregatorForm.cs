// <copyright file="YouTubeMultiPlaylistAggregatorForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;
    using YoutubeExplode;
    using YoutubeExplode.Models;
    using YoutubeExplode.Models.MediaStreams;

    /// <summary>
    /// Description of YouTubeMultiPlaylistAggregatorForm.
    /// </summary>
    public partial class YouTubeMultiPlaylistAggregatorForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "YouTube MultiPlaylist Aggregator";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.0";

        /// <summary>
        /// The playlist max video count. 0 = Fetch all.
        /// </summary>
        private int playlistMaxVideoCount = 0;

        /// <summary>
        /// The video list.
        /// </summary>
        private List<Video> videoList = new List<Video>();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.YouTubeMultiPlaylistAggregatorForm"/> class.
        /// </summary>
        public YouTubeMultiPlaylistAggregatorForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
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
                $"Newtonsoft.Json{Environment.NewLine}https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md{Environment.NewLine}{Environment.NewLine}";

            // Set about form
            var aboutForm = new AboutForm(
                $"About {this.moduleName}",
                $"{this.moduleName} {this.semanticVersion}",
                "Week #47 @ November 2018",
                licenseText,
                this.Icon.ToBitmap());

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the video radio button checked changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnVideoRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            // Make video font bold
            this.videoRadioButton.Font = new Font(videoRadioButton.Font, videoRadioButton.Font.Style | FontStyle.Bold);

            // Make audio font normal
            this.audioRadioButton.Font = new Font(audioRadioButton.Font, audioRadioButton.Font.Style & ~FontStyle.Bold);
        }

        /// <summary>
        /// Handles the audio radio button checked changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAudioRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            // Make audio font bold
            this.audioRadioButton.Font = new Font(audioRadioButton.Font, audioRadioButton.Font.Style | FontStyle.Bold);

            // Make video font normal
            this.videoRadioButton.Font = new Font(videoRadioButton.Font, videoRadioButton.Font.Style & ~FontStyle.Bold);
        }

        /// <summary>
        /// Disables or enables form controls.
        /// </summary>
        /// <param name="enabledState">If set to <c>true</c> enabled state.</param>
        private void DisableEnableControls(bool enabledState)
        {
            // Text box
            this.listTextBox.Enabled = enabledState;

            // Sequential button
            this.sequentialButton.Enabled = enabledState;

            // Alternating button
            this.alternatingButton.Enabled = enabledState;

            // Shuffled button
            this.shuffledButton.Enabled = enabledState;

            // Video radio button
            this.videoRadioButton.Enabled = enabledState;

            // Audio radio button
            this.audioRadioButton.Enabled = enabledState;

            // PLS button
            this.plsButton.Enabled = enabledState;

            // XSPF button
            this.xspfButton.Enabled = enabledState;

            // M3U
            this.m3uButton.Enabled = enabledState;
        }

        /// <summary>
        /// Gets the video lists.
        /// </summary>
        /// <returns>The video lists.</returns>
        /// <param name="sequential">If set to <c>true</c> sequential.</param>
        private async Task<List<List<Video>>> GetVideoLists(bool sequential)
        {
            // Declare video lists list
            var videoListList = new List<List<Video>>();

            // Declare alternating video list
            var alternatingVideoList = new List<Video>();

            // Declare youtube client
            var client = new YoutubeClient();

            // Iterate lines
            for (int l = 0; l < this.listTextBox.Lines.Length; l++)
            {
                // Set line
                var line = this.listTextBox.Lines[l];

                // Check there's something to work with
                if (line.Length < 11)
                {
                    // Skip iteration
                    continue;
                }
                else if (line.Length == 11)
                {
                    // Assume video
                    line = $"https://www.youtube.com/watch?v={line}";
                }
                else
                {
                    // Assume playlist
                    line = $"https://www.youtube.com/playlist?list={line}";
                }

                // Declare id
                var id = string.Empty;

                /* Add playlist */

                // Try to parse playlist id
                if (YoutubeClient.TryParsePlaylistId(line, out id))
                {
                    try
                    {
                        // Fetch playlist
                        var playlist = await client.GetPlaylistAsync(id);

                        // Set (custom) max video count
                        var maxVideoCount = (this.playlistMaxVideoCount == 0 ? playlist.Videos.Count : this.playlistMaxVideoCount);

                        // Declare current video list
                        var videoList = new List<Video>();

                        // Add videos to video list
                        for (int v = 0; v < Math.Min(maxVideoCount, playlist.Videos.Count); v++)
                        {
                            // Add current video
                            videoList.Add(playlist.Videos[v]);
                        }

                        // Add current video list 
                        videoListList.Add(videoList);
                    }
                    finally
                    {
                        // Let it fall through
                    }

                    // Next iteration
                    goto continueNext;
                }

                /* Add video */

                // Try to parse video id
                if (YoutubeClient.TryParseVideoId(line, out id))
                {
                    try
                    {
                        // Set video
                        var video = await client.GetVideoAsync(id);

                        /* Process sequential or alternating */

                        // Check for sequential flag
                        if (sequential)
                        {
                            // Add current video as list
                            videoListList.Add(new List<Video> { video });
                        }
                        else
                        {
                            // Add to alternating video list
                            alternatingVideoList.Add(video);
                        }
                    }
                    finally
                    {
                        // Let it fall through
                    }

                    // Next iteration
                    goto continueNext;
                }

            // Continue next label
            continueNext:

                // Update progress bar
                this.progressToolStripProgressBar.Value = (int)(((l + 1) * 100) / this.listTextBox.Lines.Length);

                // Update status
                this.statusToolStripStatusLabel.Text = $"Fetching video data ({l + 1}/{this.listTextBox.Lines.Length})...";
            }

            /* Append or prepend alternating video list */

            // Check if it's alternating AND there are videos
            if (!sequential && alternatingVideoList.Count > 0)
            {
                // Check for alternate first
                if (this.alternatefirstToolStripMenuItem.Checked)
                {
                    // Prepend
                    videoListList.Insert(0, alternatingVideoList);
                }
                else
                {
                    // Append
                    videoListList.Add(alternatingVideoList);
                }
            }

            // Return video lists list
            return videoListList;
        }

        /// <summary>
        /// Code before fetch.
        /// </summary>
        private void FetchBeforeCode()
        {
            // Disable controls
            this.DisableEnableControls(false);

            // Clear video list
            this.videoList.Clear();

            // Clear play list items
            this.playListView.Items.Clear();

            // Update status
            this.statusToolStripStatusLabel.Text = "Fetching video data...";

            // Reset progress bar
            this.progressToolStripProgressBar.Value = 0;
        }

        /// <summary>
        /// Code after fetch.
        /// </summary>
        private void FetchAfterCode()
        {
            // Enable controls
            this.DisableEnableControls(true);

            // Check there's something 
            if (this.playListView.Items.Count > 0)
            {
                // Set play list selected item to first
                this.playListView.Items[0].Selected = true;
                this.playListView.Items[0].EnsureVisible();

                // Set progress bar value
                this.progressToolStripProgressBar.Value = 100;

                // Update status
                this.statusToolStripStatusLabel.Text = $"Fetched {this.playListView.Items.Count} videos.";
            }
        }

        /// <summary>
        /// Handles the sequential button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private async void OnSequentialButtonClick(object sender, EventArgs e)
        {
            // Check for lines
            if (this.listTextBox.Lines.Length == 0)
            {
                // Halt flow
                return;
            }

            /* Prepare for fetch */

            // Trigger code before fetch
            this.FetchBeforeCode();

            /* Populate video list */

            // Get video lists list (sequentially)
            var videoListList = await this.GetVideoLists(true);

            // Populate sequentially
            for (int i = 0; i < videoListList.Count; i++)
            {
                // Iterate video list items
                for (int v = 0; v < videoListList[i].Count; v++)
                {
                    // Add current video to video list
                    this.videoList.Add(videoListList[i][v]);
                }
            }

            /* Populate play list view */

            // Iterate video list items
            for (int i = 0; i < this.videoList.Count; i++)
            {
                // Set video
                var video = this.videoList[i];

                // Set listview item 
                var videoItem = new ListViewItem(new[] { video.Title, video.Author });

                // Add video as tag
                videoItem.Tag = video;

                // Add to play list view
                this.playListView.Items.Add(videoItem);
            }

            /* Post-fetch */

            // Trigger code before fetch
            this.FetchAfterCode();
        }

        /// <summary>
        /// Handles the alternating button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private async void OnAlternatingButtonClick(object sender, EventArgs e)
        {
            // Check for lines
            if (this.listTextBox.Lines.Length == 0)
            {
                // Halt flow
                return;
            }

            /* Prepare for fetch */

            // Trigger code before fetch
            this.FetchBeforeCode();

            /* Populate video list */

            // Get video lists list (alternating)
            var videoListList = await this.GetVideoLists(false);

            // Declare max video list count
            var maxVideoListCount = 0;

            // Iterate video lists
            foreach (var videoList in videoListList)
            {
                // Check if must set
                if (videoList.Count > maxVideoListCount)
                {
                    // Set max item count
                    maxVideoListCount = videoList.Count;
                }
            }

            // Iterate index to max video count
            for (int index = 0; index < maxVideoListCount; index++)
            {
                // Iterate video lists
                for (int l = 0; l < videoListList.Count; l++)
                {
                    // Check if current list has enough count
                    if (videoListList[l].Count > index)
                    {
                        // Add current video to video list
                        this.videoList.Add(videoListList[l][index]);
                    }
                }
            }

            /* Populate play list view */

            // Iterate video list items
            for (int i = 0; i < this.videoList.Count; i++)
            {
                // Set video
                var video = this.videoList[i];

                // Set listview item 
                var videoItem = new ListViewItem(new[] { video.Title, video.Author });

                // Add video as tag
                videoItem.Tag = video;

                // Add to play list view
                this.playListView.Items.Add(videoItem);
            }

            /* Post-fetch */

            // Trigger code before fetch
            this.FetchAfterCode();
        }

        /// <summary>
        /// Handles the shuffled button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private async void OnShuffledButtonClick(object sender, EventArgs e)
        {
            // Check for lines
            if (this.listTextBox.Lines.Length == 0)
            {
                // Halt flow
                return;
            }

            /* Prepare for fetch */

            // Trigger code before fetch
            this.FetchBeforeCode();

            /* Populate video list */

            // Get video lists list (sequentially)
            var videoListList = await this.GetVideoLists(true);

            // Populate sequentially
            for (int i = 0; i < videoListList.Count; i++)
            {
                // Iterate video list items
                for (int v = 0; v < videoListList[i].Count; v++)
                {
                    // Add current video to video list
                    this.videoList.Add(videoListList[i][v]);
                }
            }

            /* Shuffle video list */

            // Declare random 
            var rnd = new Random();

            // Shuffle with linq
            this.videoList = this.videoList.OrderBy(x => rnd.Next(0, this.videoList.Count)).ToList();

            /* Populate play list view */

            // Iterate video list items
            for (int i = 0; i < this.videoList.Count; i++)
            {
                // Set video
                var video = this.videoList[i];

                // Set listview item 
                var videoItem = new ListViewItem(new[] { video.Title, video.Author });

                // Add video as tag
                videoItem.Tag = video;

                // Add to play list view
                this.playListView.Items.Add(videoItem);
            }

            /* Post-fetch */

            // Trigger code before fetch
            this.FetchAfterCode();
        }

        /// <summary>
        /// Handles the pls button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private async void OnPlsButtonClick(object sender, EventArgs e)
        {
            // Check for no videos in list
            if (this.videoList.Count == 0)
            {
                // Halt flow
                return;
            }

            // Disable controls
            this.DisableEnableControls(false);

            // Reset progress bar
            this.progressToolStripProgressBar.Value = 0;

            // Inform user
            this.statusToolStripStatusLabel.Text = "Fetching media stream info...";

            // Set YouTube Client
            var youTubeClient = new YoutubeClient();

            // Set playlist string builder
            var playlistStringBuilder = new StringBuilder();

            // Add header
            playlistStringBuilder.AppendLine("[playlist]");

            // Fetched count
            var fetchedCount = 0;

            // Iterate video list
            for (int i = 0; i < this.videoList.Count; i++)
            {
                try
                {
                    // Get media stream info set
                    var mediaStreamInfoSet = await youTubeClient.GetVideoMediaStreamInfosAsync(this.videoList[i].Id);

                    // Set stream info url
                    var streamInfoUrl = (this.videoRadioButton.Checked ? mediaStreamInfoSet.Muxed.WithHighestVideoQuality().Url : mediaStreamInfoSet.Audio.WithHighestBitrate().Url);

                    // Append file (url)
                    playlistStringBuilder.AppendLine($"File{fetchedCount + 1}={streamInfoUrl}");

                    // Append title
                    playlistStringBuilder.AppendLine($"Title{fetchedCount + 1}={this.videoList[i].Title}");

                    // Separator
                    playlistStringBuilder.AppendLine();

                    // Rise fetched count
                    fetchedCount++;
                }
                finally
                {
                    //  Let it fall through
                }

                // Update progress bar
                this.progressToolStripProgressBar.Value = (int)(((i + 1) * 100) / this.videoList.Count);

                // Update status
                this.statusToolStripStatusLabel.Text = $"Fetching media stream info ({i + 1}/{this.videoList.Count})...";
            }

            // Append footer
            playlistStringBuilder.AppendLine($"NumberOfEntries = {fetchedCount - 1}");
            playlistStringBuilder.AppendLine("Version = 2");

            /* Save playlist to file */

            // Set default ext
            this.saveFileDialog.DefaultExt = "pls";

            // Set filter
            this.saveFileDialog.Filter = "PLS Files (*.pls)|*.pls|All files (*.*)|*.*";

            // Set file name
            this.saveFileDialog.FileName = $"playlist.pls";

            // Open save file dialog
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
            {
                // Save playlist file
                File.WriteAllText(this.saveFileDialog.FileName, playlistStringBuilder.ToString(), Encoding.UTF8);
            }

            // Update progress bar
            this.progressToolStripProgressBar.Value = 100;

            // Inform user
            this.statusToolStripStatusLabel.Text = "PLS playlist saved!";

            // Enable controls
            this.DisableEnableControls(true);
        }

        /// <summary>
        /// Handles the xspf button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnXspfButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the m3u button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private async void OnM3uButtonClick(object sender, EventArgs e)
        {
            // Check for no videos in list
            if (this.videoList.Count == 0)
            {
                // Halt flow
                return;
            }

            // Disable controls
            this.DisableEnableControls(false);

            // Reset progress bar
            this.progressToolStripProgressBar.Value = 0;

            // Inform user
            this.statusToolStripStatusLabel.Text = "Fetching media stream info...";

            // Set YouTube Client
            var youTubeClient = new YoutubeClient();

            // Set playlist string builder
            var playlistStringBuilder = new StringBuilder();

            // Add header
            playlistStringBuilder.AppendLine("#EXTM3U");

            // Fetched count
            var fetchedCount = 0;

            // Iterate video list
            for (int i = 0; i < this.videoList.Count; i++)
            {
                try
                {
                    // Get media stream info set
                    var mediaStreamInfoSet = await youTubeClient.GetVideoMediaStreamInfosAsync(this.videoList[i].Id);

                    // Set stream info url
                    var streamInfoUrl = (this.videoRadioButton.Checked ? mediaStreamInfoSet.Muxed.WithHighestVideoQuality().Url : mediaStreamInfoSet.Audio.WithHighestBitrate().Url);

                    // Append info
                    playlistStringBuilder.AppendLine($"#EXTINF:-1,{this.videoList[i].Title}");

                    // Append url
                    playlistStringBuilder.AppendLine($"{streamInfoUrl}");

                    // Rise fetched count
                    fetchedCount++;
                }
                finally
                {
                    //  Let it fall through
                }

                // Update progress bar
                this.progressToolStripProgressBar.Value = (int)(((i + 1) * 100) / this.videoList.Count);

                // Update status
                this.statusToolStripStatusLabel.Text = $"Fetching media stream info ({i + 1}/{this.videoList.Count})...";
            }

            /* Save playlist to file */

            // Set default ext
            this.saveFileDialog.DefaultExt = "m3u";

            // Set filter
            this.saveFileDialog.Filter = "M3U Files (*.m3u)|*.m3u|All files (*.*)|*.*";

            // Set file name
            this.saveFileDialog.FileName = $"playlist.m3u";

            // Open save file dialog
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
            {
                // TODO Save playlist file [Consider M3U8 extension since it's UTF8-encoded]
                File.WriteAllText(this.saveFileDialog.FileName, playlistStringBuilder.ToString(), Encoding.UTF8);
            }

            // Update progress bar
            this.progressToolStripProgressBar.Value = 100;

            // Inform user
            this.statusToolStripStatusLabel.Text = "M3U playlist saved!";

            // Enable controls
            this.DisableEnableControls(true);
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear list text box
            this.listTextBox.Clear();

            // Clear play list view
            this.playListView.Items.Clear();

            // Reset progress bar
            this.progressToolStripProgressBar.Value = 0;

            // Reset status
            this.statusToolStripStatusLabel.Text = "Waiting...";

            // Focus list text box
            this.listTextBox.Focus();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close module
            this.Close();
        }

        /// <summary>
        /// Handles the cut tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check text box length
            if (this.listTextBox.Text.Length > 0)
            {
                // Copy current text to clipboard
                Clipboard.SetText(this.listTextBox.Text);

                // Clear text box
                this.listTextBox.Clear();
            }
        }

        /// <summary>
        /// Handles the copy tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check text box length
            if (this.listTextBox.Text.Length > 0)
            {
                // Copy current text to clipboard
                Clipboard.SetText(this.listTextBox.Text);
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
                // Clear text box
                this.listTextBox.Clear();

                // Paste from clipboard
                this.listTextBox.Text = Clipboard.GetText();
            }
        }

        /// <summary>
        /// Handles the select all tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Select all list text
            this.listTextBox.SelectAll();
        }

        /// <summary>
        /// Handles the tool strip menu item drop down item clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Uncheck all drop down items
            foreach (var item in ((ToolStripMenuItem)sender).DropDownItems)
            {
                // Uncheck current item
                ((ToolStripMenuItem)item).Checked = false;
            }

            // Set clicked item
            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle check state
            clickedItem.Checked = true;

            /* Act upon owner item name */

            // Check for added lists
            if (clickedItem.OwnerItem.Name == "addedlistsToolStripMenuItem")
            {
                // Switch clicked item text
                switch (clickedItem.Text.Split('(')[0])
                {
                    // Fetch all
                    case "&Fetch all":

                        // Set to zero
                        this.playlistMaxVideoCount = 0;

                        // Halt flow
                        break;

                    // Custom value
                    case "&Custom value":

                        // Declare custom value
                        int customValue;

                        // Try to parse
                        if (int.TryParse(Interaction.InputBox("Set max video count. 0 = Fetch all.", "Playlist max", this.playlistMaxVideoCount.ToString(), 0, 0), out customValue))
                        {
                            // Set custom value
                            this.playlistMaxVideoCount = customValue;
                        }

                        // Halt flow
                        break;

                    // Numerical
                    default:

                        // Set suggested number
                        this.playlistMaxVideoCount = int.Parse(clickedItem.Text.Split(' ')[0]);

                        // Halt flow
                        break;
                }
            }
        }
    }
}
