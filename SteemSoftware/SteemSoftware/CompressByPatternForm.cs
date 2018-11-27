// <copyright file="CompressByPatternForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Description of CompressByPatternForm.
    /// </summary>
    public partial class CompressByPatternForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "Compress by Pattern";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.0";

        /// <summary>
        /// The working directory path.
        /// </summary>
        private string workingDirectoryPath = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.CompressByPatternForm"/> class.
        /// </summary>
        public CompressByPatternForm()
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
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"DotNetZip license{Environment.NewLine}" +
                $"https://raw.githubusercontent.com/haf/DotNetZip.Semverd/master/LICENSE{Environment.NewLine}{Environment.NewLine}" +
                $"zipper{Environment.NewLine}Icon made by Freepik @ https://www.freepik.com/{Environment.NewLine}from https://www.flaticon.com/{Environment.NewLine}Licensed by Creative Commons BY 3.0 (CC 3.0 BY){Environment.NewLine}http://creativecommons.org/licenses/by/3.0/{Environment.NewLine}{Environment.NewLine}" +
                $"folder{Environment.NewLine}Icon made by Smashicons @ https://www.flaticon.com/authors/smashicons{Environment.NewLine}from https://www.flaticon.com/{Environment.NewLine}Licensed by Creative Commons BY 3.0 (CC 3.0 BY){Environment.NewLine}http://creativecommons.org/licenses/by/3.0/";

            // Set about form
            var aboutForm = new AboutForm(
                $"About {this.moduleName}",
                $"{this.moduleName} {this.semanticVersion}",
                "Week #48 @ November 2018",
                licenseText,
                this.Icon.ToBitmap());

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set clicked item
            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle clicked item check state
            clickedItem.Checked = !clickedItem.Checked;
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
        /// Handles the paste tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPasteToolStripMenuItemClick(object sender, EventArgs e)
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
            // TODO Add code
        }

        /// <summary>
        /// Handles the set working directory button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSetWorkingDirectoryButtonClick(object sender, EventArgs e)
        {
            // Prompt user to set the working directory path
            this.TrySetWorkingDirectoryPath();
        }

        /// <summary>
        /// Tries to set the working directory path.
        /// </summary>
        /// <returns><c>true</c>, if working directory path was set, <c>false</c> otherwise.</returns>
        private bool TrySetWorkingDirectoryPath()
        {
            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Set working directory path
                this.workingDirectoryPath = this.folderBrowserDialog.SelectedPath;

                // Return positively
                return true;
            }

            // Default return
            return false;
        }

        /// <summary>
        /// Handles the compress by pattern button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCompressByPatternButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Gets the pattern and target row list.
        /// </summary>
        /// <returns>The pattern and target row list.</returns>
        private List<PatternAndTargetRow> GetPatternAndTargetRowList()
        {
            // Declare pattern and target row list
            var patternAndTargetRowList = new List<PatternAndTargetRow>();

            // Populate pattern and target row list
            for (int i = 0; i < this.dataGridView.Rows.Count; i++)
            {
                try
                {
                    // Add current row to list
                    patternAndTargetRowList.Add(new PatternAndTargetRow(
                        this.dataGridView.Rows[i].Cells[0].Value.ToString(), // Set pattern
                        this.dataGridView.Rows[i].Cells[1].Value.ToString(), // Set target
                        Convert.ToBoolean(this.dataGridView.Rows[i].Cells[2].Value))); // Set is regex flag
                }
                catch
                {
                    // Let it fall through
                }
            }

            // Return pattern and target row list
            return patternAndTargetRowList;
        }
    }
}
