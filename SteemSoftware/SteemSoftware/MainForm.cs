﻿// <copyright file="MainForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The module info dictionary.
        /// </summary>
        private Dictionary<string, List<ModuleInfo>> moduleInfoDictionary = new Dictionary<string, List<ModuleInfo>>();

        /// <summary>
        /// The module form list.
        /// </summary>
        private List<Form> moduleFormList = new List<Form>();

        /// <summary>
        /// The index of the last selected category.
        /// </summary>
        private int lastCategorySelectedIndex = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set module info dictionary */

            // Video
            this.moduleInfoDictionary.Add("Video", new List<ModuleInfo>()
            {
                new ModuleInfo("YouTube Downloader", "Download videos from YouTube.com", typeof(YouTubeDownloaderForm)),
            });

            /* Set categories */

            // Iterate categories
            foreach (var category in this.moduleInfoDictionary.Keys)
            {
                // Add current one
                this.categoryListBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the double click launch tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDoubleClickLaunchToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the launch centered tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLaunchCenteredToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the launch button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLaunchButtonClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the github repository tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGithubRepositoryToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the busy.org tag tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBusyorgTagToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the steemit.com tag tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSteemitcomTagToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the remember window location tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRememberWindowLocationToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the remember window size tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRememberWindowSizeToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }

        /// <summary>
        /// Handles the ask on exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAskOnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Add code
        }
    }
}
