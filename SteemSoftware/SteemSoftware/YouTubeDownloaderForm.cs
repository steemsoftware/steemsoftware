// <copyright file="YouTubeDownloaderForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    /// <summary>
    /// YouTube downloader form.
    /// </summary>
    public partial class YouTubeDownloaderForm : Form
    {
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

            // Declare id variable
            var id = string.Empty;

            // Set video text
            var videoText = this.videoTextBox.Text;

            // Try to parse URI
            try
            {
                // Set video uri
                var videoUri = new Uri(videoText);

                // Set id according to input format
                if (videoUri.DnsSafeHost.ToLowerInvariant().Contains("youtube.com"))
                {
                    // Trim initial "?"
                    var videoUriQueryString = videoUri.Query.TrimStart('?');

                    // TODO Check for "v" value in query string [Refactor with "ParseQueryString()"]
                    foreach (var queryPart in videoUriQueryString.Split('&'))
                    {
                        // Split to variable
                        var queryKeyValue = queryPart.Split('=');

                        // Check if it's "v", then check for valid length
                        if (queryKeyValue[0] == "v" && queryKeyValue.Length == 2 && !string.IsNullOrWhiteSpace(queryKeyValue[1]))
                        {
                            // Assign id
                            id = queryKeyValue[1];

                            // Halt flow
                            break;
                        }
                    }
                }
                else if (videoUri.DnsSafeHost.ToLowerInvariant().Contains("youtu.be"))
                {
                    // Shortened, check base directory
                    if (videoUri.Segments.Length == 2)
                    {
                        // Set base directory as video id
                        id = videoUri.Segments[1].TrimEnd('/');
                    }
                }
            }
            catch (Exception)
            {
                // Assume video text is ID
                id = videoText;
            }

            // Validate ID ([0-9A-Za-z_-])
            if (!Regex.IsMatch(id, "^[a-zA-Z0-9_-]*$"))
            {
                // Invalid, set id to empty string
                id = string.Empty;
            }

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
            this.mainToolStripStatusLabel.Text = "Processing id \"" + id.ToString() + "\".";

            // Fetch video info

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
