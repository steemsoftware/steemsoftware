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
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Windows.Forms;
    using System.Xml.Serialization;

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
        /// The assembly version.
        /// </summary>
        private Version assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = string.Empty;

        /// <summary>
        /// The steem software data.
        /// </summary>
        private SteemSoftwareData steemSoftwareData = new SteemSoftwareData();

        /// <summary>
        /// The data directory dictionary.
        /// </summary>
        private Dictionary<string, string> dataDirectoryDictionary = null;

        /// <summary>
        /// The steem software data file path.
        /// </summary>
        private string steemSoftwareDataFilePath = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // Set load from lib directory resolve event handler
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(this.LoadAssemblyFromLibDirectory);

            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Data directories and data file */

            // Set data directory path
            var dataDirectoryPath = Path.Combine(Application.StartupPath, "Data");

            // Set data directory dictionary
            this.dataDirectoryDictionary = new Dictionary<string, string>()
            {
                ["Data"] = dataDirectoryPath,
                ["Libraries"] = Path.Combine(dataDirectoryPath, "Libraries"),
                ["License"] = Path.Combine(dataDirectoryPath, "License"),
                ["Settings"] = Path.Combine(dataDirectoryPath, "Settings"),
            };

            // Iterate data directories
            foreach (var currentDataDirectory in this.dataDirectoryDictionary.Values)
            {
                // Create current directory
                Directory.CreateDirectory(currentDataDirectory);
            }

            // Set data file path
            this.steemSoftwareDataFilePath = Path.Combine(this.dataDirectoryDictionary["Settings"], "SteemSoftwareData.bin");

            /* Semantic versioning */

            // Set semantic version
            this.semanticVersion = this.assemblyVersion.Major + "." + this.assemblyVersion.Minor + "." + this.assemblyVersion.Build;

            // Append semantic version to form title
            this.Text += " " + this.semanticVersion;

            /* Module info lists */

            // Video
            var videoModuleInfoList = new List<ModuleInfo>()
            {
                new ModuleInfo("YouTube Downloader", "Download videos from YouTube.com", typeof(YouTubeDownloaderForm)),
            };

            /* Module info dictionary */

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
        /// Loads the assembly from lib directory.
        /// </summary>
        /// <returns>The assembly from lib directory.</returns>
        /// <param name="sender">Sender object.</param>
        /// <param name="args">Event arguments.</param>
        private Assembly LoadAssemblyFromLibDirectory(object sender, ResolveEventArgs args)
        {
            // Return loaded assembly
            return Assembly.LoadFrom(Path.Combine(Path.Combine(Application.StartupPath, "Libraries"), args.Name));
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
            // Confirm open module close
            if (!this.askOnNewToolStripMenuItem.Checked || this.ConfirmOpenModuleClose())
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
            // Open tag on busy
            Process.Start("https://busy.org/trending/steemsoftware");
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
        /// Gets all menu item checked state dictionary.
        /// </summary>
        /// <param name="toolStripMenuItem">Tool strip menu item.</param>
        /// <param name="menuItemCheckedStateDictionary">Menu item checked state dictionary.</param>
        private void GetAllMenuItemCheckedStateDictionary(ToolStripMenuItem toolStripMenuItem, Dictionary<string, bool> menuItemCheckedStateDictionary)
        {
            // Iterate tool strip menu items
            toolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().ToList().ForEach(dropDownItem =>
            {
                // Add to dictionary
                menuItemCheckedStateDictionary.Add(dropDownItem.Name, dropDownItem.Checked);

                // Check for more drop down items
                if (dropDownItem.HasDropDownItems)
                {
                    // Use recursion
                    GetAllMenuItemCheckedStateDictionary(dropDownItem, menuItemCheckedStateDictionary);
                }
            });
        }

        /// <summary>
        /// Handles the main form form closing event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask on exit
            if (this.askOnExitToolStripMenuItem.Checked && !this.ConfirmOpenModuleClose())
            {
                // Set cancel
                e.Cancel = true;
            }

            // Skip saving data
            if (e.Cancel)
            {
                // Halt flow
                return;
            }

            /* Set window data */

            // Check if must remember window size
            if (this.rememberWindowSizeToolStripMenuItem.Checked)
            {
                // Set window size
                this.steemSoftwareData.WindowSize = this.Size;
            }

            // Check if must remember window location
            if (this.rememberWindowLocationToolStripMenuItem.Checked)
            {
                // Set window location
                this.steemSoftwareData.WindowLocation = this.Location;
            }

            /* Set menu items checked state */

            // Declare checked state dictionary
            var menuItemCheckedStateDictionary = new Dictionary<string, bool>();

            // Populate checked state dictionary
            this.GetAllMenuItemCheckedStateDictionary(this.toolsToolStripMenuItem, menuItemCheckedStateDictionary);

            // Set menu item checked state dictionary on class
            this.steemSoftwareData.MenuItemCheckedStateDictionary = menuItemCheckedStateDictionary;

            /* Save to bin file */
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(this.steemSoftwareDataFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.steemSoftwareData);
            stream.Close();
        }

        /// <summary>
        /// Confirms the open module close.
        /// </summary>
        /// <returns><c>true</c>, if open module close was confirmed, <c>false</c> otherwise.</returns>
        private bool ConfirmOpenModuleClose()
        {
            // Open module count
            var openModuleCount = this.GetOpenModuleCount();

            // Check for open modules, if so, ask user for confirmation
            if (openModuleCount == 0 || MessageBox.Show($"This action will close {openModuleCount} open module{(openModuleCount > 1 ? "s" : string.Empty)}. Continue?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // True
                return true;
            }

            // False
            return false;
        }

        /// <summary>
        /// Gets the open module count.
        /// </summary>
        /// <returns>The open module count.</returns>
        private int GetOpenModuleCount()
        {
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

            // Return the open module count
            return openModuleCount;
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set about form
            var aboutForm = new AboutForm(
                "About SteemSoftware",
                $"SteemSoftware {this.semanticVersion}",
                "Week #41 @ October 2018",
                "CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication\nhttps://creativecommons.org/publicdomain/zero/1.0/legalcode",
                this.Icon.ToBitmap()
            );

            // Show about form
            aboutForm.ShowDialog();
        }
    }
}
