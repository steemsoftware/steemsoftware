// <copyright file="MainForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
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

            /* Set module info lists */

            // Video
            var videoModuleInfoList = new List<ModuleInfo>()
            {
                new ModuleInfo("YouTube Downloader", "Download videos from YouTube.com", typeof(YouTubeDownloaderForm)),
            };

            /* Set module info dictionary */

            // Video
            this.moduleInfoDictionary.Add("Video", videoModuleInfoList);

            /* Set categories */

            // Iterate categories
            foreach (var category in this.moduleInfoDictionary.Keys)
            {
                // Add current one
                this.categoryListBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Gets the list view item with module info tag.
        /// </summary>
        /// <returns>The list view item with module info tag.</returns>
        /// <param name="moduleInfo">Module info.</param>
        private ListViewItem GetListViewItemWithModuleInfoTag(ModuleInfo moduleInfo)
        {
            // New list view item
            var listViewItem = new ListViewItem(moduleInfo.Name);

            // Set its tag
            listViewItem.Tag = moduleInfo;

            // Return it
            return listViewItem;
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close all open module forms
            foreach (var moduleForm in this.moduleFormList)
            {
                // Close
                moduleForm.Close();
            }

            // Reset category selected index
            this.categoryListBox.SelectedIndex = -1;

            // Reset last category selected index
            this.lastCategorySelectedIndex = -1;

            // Clear functionality list box
            this.functionalityListView.Items.Clear();

            // Clear description rich text box
            this.descriptionRichTextBox.Clear();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Trigger close
            this.Close();
        }

        /// <summary>
        /// Handles the launch button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLaunchButtonClick(object sender, EventArgs e)
        {
            // Check for a selected item
            if (this.functionalityListView.SelectedItems.Count > 0)
            {
                // Set module type
                ModuleInfo moduleType = (ModuleInfo)this.functionalityListView.SelectedItems[0].Tag;

                // Cast to form
                Form moduleForm = (Form)Activator.CreateInstance(moduleType.FormType);

                // Set icon
                moduleForm.Icon = this.Icon;

                // Add to module form list
                this.moduleFormList.Add(moduleForm);

                // Check if must center
                if (this.launchcenteredToolStripMenuItem.Checked)
                {
                    // Center module form
                    moduleForm.StartPosition = FormStartPosition.CenterScreen;
                }

                // Show form                                 
                moduleForm.Show();
            }
        }

        /// <summary>
        /// Handles the github repository tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGithubRepositoryToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open github repository
            Process.Start("https://github.com/steemsoftware/steemsoftware");
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
            // Open tag on steemit
            Process.Start("https://steemit.com/trending/steemsoftware");
        }

        /// <summary>
        /// Handles the category list box selected index changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCategoryListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            // Check for last selected index match or no selected item
            if (this.categoryListBox.SelectedIndex == this.lastCategorySelectedIndex || this.categoryListBox.SelectedIndex == -1)
            {
                // Halt flow
                return;
            }

            // Set last category selected index
            this.lastCategorySelectedIndex = this.categoryListBox.SelectedIndex;

            // Clear functionality list box
            this.functionalityListView.Items.Clear();

            // Clear description rich text box
            this.descriptionRichTextBox.Clear();

            // Iterate module info dictionary
            foreach (var item in this.moduleInfoDictionary[this.categoryListBox.SelectedItem.ToString()])
            {
                // Add current module
                this.functionalityListView.Items.Add(this.GetListViewItemWithModuleInfoTag(item));
            }
        }

        /// <summary>
        /// Handles the functionality list view selected index changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFunctionalityListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            // Check for a selected item
            if (this.functionalityListView.SelectedItems.Count > 0)
            {
                // Set description
                this.descriptionRichTextBox.Text = ((ModuleInfo)this.functionalityListView.SelectedItems[0].Tag).Description;
            }
        }

        /// <summary>
        /// Handles the tool strip menu item drop down item clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set clicked item
            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle check state
            clickedItem.Checked = !clickedItem.Checked;
        }

        /// <summary>
        /// Handles the functionality list view double click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFunctionalityListViewDoubleClick(object sender, EventArgs e)
        {
            // Query check state
            if (this.doubleClickLaunchToolStripMenuItem.Checked)
            {
                // Simulate launch button click
                this.launchButton.PerformClick();
            }
        }

        /// <summary>
        /// Mains the form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Test ask on exit check state
            if (!this.askOnExitToolStripMenuItem.Checked)
            {
                // Halt flow
                return;
            }

            // Open module count
            var openModuleCount = 0;

            // Check for open module forms
            foreach (var moduleForm in this.moduleFormList)
            {
                // Check for not disposed
                if (!moduleForm.IsDisposed)
                {
                    // Increment open module count
                    openModuleCount++;
                }
            }

            // Check for open module windows
            if (openModuleCount > 0)
            {
                // Ask user for confirmation
                if (MessageBox.Show("This action will close " + openModuleCount + " open module" + (openModuleCount > 1 ? "s" : string.Empty) + ". Continue?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    // Set cancel
                    e.Cancel = true;
                }
            }
        }
    }
}
