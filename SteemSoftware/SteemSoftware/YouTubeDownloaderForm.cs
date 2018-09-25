// <copyright file="YouTubeDownloaderForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Net;
    using System.Windows.Forms;

    /// <summary>
    /// YouTube downloader form.
    /// </summary>
    public partial class YouTubeDownloaderForm : Form
    {
        /// <summary>
        /// The web client.
        /// </summary>
        private WebClient webClient = new WebClient();

        /// <summary>
        /// The last selected path.
        /// </summary>
        private string lastSelectedPath = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.YouTubeDownloaderForm"/> class.
        /// </summary>
        public YouTubeDownloaderForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Handle download events */

            // Set download file completed event handler
            this.webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.OnDownloadFileCompleted);

            // Set download progress changed event handler
            this.webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.OnDownloadProgressChanged);
        }

        /// <summary>
        /// Handles the download file completed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Inform user
            this.mainToolStripStatusLabel.Text = "Video download complete";

            // Enable download button
            this.downloadButton.Enabled = true;
        }

        /// <summary>
        /// Handles the download progress changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Display progress
            this.mainToolStripStatusLabel.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";

            // Clear status label
            if (e.ProgressPercentage == 100)
            {
                this.mainToolStripStatusLabel.Text = string.Empty;
            }
        }

        /// <summary>
        /// Handles the download button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDownloadButtonClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the cut tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Copy current video text to clipboard
            Clipboard.SetText(this.videoTextBox.Text);

            // Clear video text box
            this.videoTextBox.Clear();
        }

        /// <summary>
        /// Handles the copy tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Copy current video text to clipboard
            Clipboard.SetText(this.videoTextBox.Text);
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
            // About Youtube Downloader
            MessageBox.Show("YouTube Downloader v0.1.0" + Environment.NewLine + Environment.NewLine + "Week #39 @ September 2018", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
