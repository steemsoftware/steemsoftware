// <copyright file="YoutubeMultiplaylistJukeboxForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;
    using YoutubeExplode;
    using YoutubeExplode.Models;

    /// <summary>
    /// Description of YoutubeMultiplaylistJukeboxForm.
    /// </summary>
    public partial class YoutubeMultiplaylistJukeboxForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "YouTube MultiPlaylist Jukebox";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.0";

        /// <summary>
        /// The jukebox play list.
        /// </summary>
        private List<Video> jukeboxPlayList = new List<Video>();

        /// <summary>
        /// The playlist max video count. 0 = Fetch all.
        /// </summary>
        private int playlistMaxVideoCount = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.YoutubeMultiplaylistJukeboxForm"/> class.
        /// </summary>
        public YoutubeMultiplaylistJukeboxForm()
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
            // TODO Add code
        }

        /// <summary>
        /// Handles the cut tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the copy tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the save tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the save as tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
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
        /// Handles the paste tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPasteToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the select all tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
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
                // Update progress bar
                this.progressToolStripProgressBar.Value = (int)(l + 1 * 100 / this.listTextBox.Lines.Length);

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

                        // Add videos to jukebox playlist
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
                    continue;
                }

                /* Add video */

                // Try to parse video id
                if (YoutubeClient.TryParseVideoId(line, out id))
                {
                    try
                    {
                        // Set video
                        var video = await client.GetVideoAsync(id);

                        /* Process sequential or alternating*/

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
                    continue;
                }
            }

            /* Append or prepend alternating video list */

            // Check if it's alternating
            if (!sequential)
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

            // Update status
            this.statusToolStripStatusLabel.Text = "Fetching video data...";

            // Reset progress bar
            this.progressToolStripProgressBar.Value = 0;

            // Clear jukebox play list
            this.jukeboxPlayList.Clear();

            // Clear play list items
            this.playListView.Items.Clear();

            // Clear playing now text box
            this.nowPlayingTextBox.Clear();
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
                // Set now playing text box to first video
                this.nowPlayingTextBox.Text = "1";

                // Set play list selected item to first
                this.playListView.Items[0].Selected = true;
                this.playListView.Items[0].EnsureVisible();

                // Set progress bar value
                this.progressToolStripProgressBar.Value = 100;

                // Update status
                this.statusToolStripStatusLabel.Text = $"Fetched {this.playListView.Items.Count} videos.";

                // Focus play button
                this.playPauseButton.Focus();
            }
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

            /* Populate jukebox play list */

            // Get video lists list (sequentially)
            var videoListList = await this.GetVideoLists(true);

            // Populate sequentially
            for (int i = 0; i < videoListList.Count; i++)
            {
                // Iterate video lists
                for (int v = 0; v < videoListList[i].Count; v++)
                {
                    // Add current video to jukebox playlist
                    this.jukeboxPlayList.Add(videoListList[i][v]);
                }
            }

            /* Populate play list view */

            // Iterate jukebox playlist items
            for (int i = 0; i < this.jukeboxPlayList.Count; i++)
            {
                // Set video
                var video = this.jukeboxPlayList[i];

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

            /* Populate jukebox play list */

            // Get video lists list (sequentially)
            var videoListList = await this.GetVideoLists(false);

            // Populate alternating lists
            for (int i = 0; i < videoListList.Count; i++)
            {
                // Iterate video lists
                for (int v = 0; v < videoListList[i].Count; v++)
                {
                    // Add current video to jukebox playlist
                    this.jukeboxPlayList.Add(videoListList[i][v]);
                }
            }

            /* Populate play list view */

            // Iterate jukebox playlist items
            for (int i = 0; i < this.jukeboxPlayList.Count; i++)
            {
                // Set video
                var video = this.jukeboxPlayList[i];

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

            /* Populate jukebox play list */

            // Get video lists list (sequentially)
            var videoListList = await this.GetVideoLists(true);

            // Populate sequentially
            for (int i = 0; i < videoListList.Count; i++)
            {
                // Iterate video lists
                for (int v = 0; v < videoListList[i].Count; v++)
                {
                    // Add current video to jukebox playlist
                    this.jukeboxPlayList.Add(videoListList[i][v]);
                }
            }

            /* Shuffle jukebox play list */

            // Declare random 
            var rnd = new Random();

            // Shuffle with linq
            this.jukeboxPlayList = this.jukeboxPlayList.OrderBy(x => rnd.Next(0, this.jukeboxPlayList.Count)).ToList();

            /* Populate play list view */

            // Iterate jukebox playlist items
            for (int i = 0; i < this.jukeboxPlayList.Count; i++)
            {
                // Set video
                var video = this.jukeboxPlayList[i];

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
                        if (int.TryParse(Interaction.InputBox("Set max video count. 0 = Fetch all.", "Playlist max", this.playlistMaxVideoCount.ToString(), -1, -1), out customValue))
                        {
                            // Set custom value
                            this.playlistMaxVideoCount = customValue;

                            // Update item text
                            clickedItem.Text = $"&Custom value ({customValue})";
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

        /// <summary>
        /// Handles the loop button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLoopButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the first button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFirstButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the previous button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPrevButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the play pause button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPlayPauseButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the next button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNextButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the last button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLastButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}
