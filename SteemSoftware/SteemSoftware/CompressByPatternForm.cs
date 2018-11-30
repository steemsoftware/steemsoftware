// <copyright file="CompressByPatternForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Ionic.Zip;
    using Newtonsoft.Json;

    /// <summary>
    /// Description of CompressByPatternForm.
    /// </summary>
    public partial class CompressByPatternForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "Compress By Pattern";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.0";

        /// <summary>
        /// The working directory path.
        /// </summary>
        private string workingDirectoryPath = string.Empty;

        /// <summary>
        /// The custom save directory path.
        /// </summary>
        private string customSaveDirectoryPath = string.Empty;

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
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Reset working directory path
            this.workingDirectoryPath = string.Empty;

            // Clear data grid view
            this.dataGridView.Rows.Clear();
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set initial file name
            this.saveFileDialog.FileName = "PatternTarget.txt";

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                /* Populate data grid view */

                try
                {
                    // Get JSON from file
                    var jsonString = File.ReadAllText(this.openFileDialog.FileName);

                    // Deserialize JSON to variable
                    var patternAndTargetRowList = JsonConvert.DeserializeObject<List<PatternAndTargetRow>>(jsonString);

                    // Iterate row list
                    foreach (var patternAndTargetRow in patternAndTargetRowList)
                    {
                        // Add to data grid view
                        this.dataGridView.Rows.Add(new object[] { patternAndTargetRow.Pattern, patternAndTargetRow.Target, patternAndTargetRow.IsRegex });
                    }
                }
                catch (Exception)
                {
                    // Inform user
                    this.toolStripStatusLabel.Text = "Open file error";
                }
            }
        }

        /// <summary>
        /// Handles the save tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set pattern and target row list
            var patternAndTargetRowList = this.GetPatternAndTargetRowList();

            // Check for data to save
            if (patternAndTargetRowList.Count == 0)
            {
                // Halt flow
                return;
            }

            // Set file name
            this.saveFileDialog.FileName = "PatternTarget.txt";

            // Open save file dialog
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
            {
                /* Save to JSON file */

                try
                {
                    // Write JSON file
                    using (var streamWriter = new StreamWriter(this.saveFileDialog.FileName))
                    using (var jsonWriter = new JsonTextWriter(streamWriter))
                    {
                        // Declare JSON serializer
                        var jsonSerializer = new JsonSerializer();

                        // Serialize to file
                        jsonSerializer.Serialize(jsonWriter, patternAndTargetRowList);
                    }
                }
                catch (Exception)
                {
                    // Inform user
                    this.toolStripStatusLabel.Text = "Save file error";
                }

                // Inform user
                this.toolStripStatusLabel.Text = $"Saved to \"{Path.GetFileName(this.saveFileDialog.FileName)}\"";
            }
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
            // Set description
            this.folderBrowserDialog.Description = "Set working directory";

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
            // Set pattern and target row list
            var patternAndTargetRowList = this.GetPatternAndTargetRowList();

            // Check for rows
            if (patternAndTargetRowList.Count == 0)
            {
                // No rows. Halt flow
                return;
            }

            // Check for working directory path
            if (this.workingDirectoryPath.Length == 0)
            {
                // Prompt user
                if (!this.TrySetWorkingDirectoryPath())
                {
                    // No path. halt flow
                    return;
                }
            }

            /* Compress files */

            // Set default file count
            var fileCount = 0;

            // Set progress value
            var progressValue = 100;

            // Set status message
            var statusMessage = string.Empty;

            // Set iteration count
            var iterationCount = 0;

            // Iterate rows
            foreach (var row in patternAndTargetRowList)
            {
                // Declare current file list
                var fileList = new List<string>();

                // Rise iteration count
                iterationCount++;

                // Update overall status 
                this.toolStripStatusLabel.Text = $"Processing {iterationCount}/{patternAndTargetRowList.Count}";

                try
                {
                    // Check for regex flag
                    if (row.IsRegex)
                    {
                        // Add by regex
                        fileList = Directory.GetFiles(this.workingDirectoryPath, "*.*")
                                            .Where(filePath => new Regex(row.Pattern).IsMatch(filePath))
                                            .ToList();
                    }
                    else
                    {
                        // Add by GetFiles
                        fileList.AddRange(Directory.GetFiles(this.workingDirectoryPath, row.Pattern, this.searchSubdirectoriesToolStripMenuItem.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                    }
                }
                catch (Exception)
                {
                    // Re-throw
                    throw;
                }

                // Check for files to compress
                if (fileList.Count == 0)
                {
                    // Skip to next iteration
                    continue;
                }

                /* Compress current one */

                try
                {
                    // Use zip file
                    using (var zip = new ZipFile())
                    {
                        // Set save progress event handler
                        zip.SaveProgress += this.SaveProgress;

                        // Set compression level
                        foreach (ToolStripMenuItem item in this.compressionLevelToolStripMenuItem.DropDownItems)
                        {
                            // Test for checked
                            if (item.Checked)
                            {
                                // Switch name
                                switch (item.Name)
                                {
                                    // Optimal
                                    case "optimalToolStripMenuItem":

                                        // Set to best
                                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;

                                        // Halt flow
                                        break;

                                    // No compression
                                    case "noCompressionToolStripMenuItem":

                                        // Set to none
                                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.None;

                                        // Halt flow
                                        break;

                                    // Fastest
                                    case "fastestToolStripMenuItem":

                                        // Set to best speed
                                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed;

                                        // Halt flow
                                        break;
                                }
                            }
                        }

                        // Add collected files
                        zip.AddFiles(fileList, this.preserveDirectoryHierarchyToolStripMenuItem.Checked, string.Empty);

                        // Save to zip file
                        if (this.generateIntoworkingDirectoryToolStripMenuItem.Checked)
                        {
                            // Save using working directory
                            zip.Save(Path.Combine(this.workingDirectoryPath, $"{row.Target}.zip"));
                        }
                        else
                        {
                            // Check for custom save directory path
                            if (this.customSaveDirectoryPath.Length == 0)
                            {
                                // Set description
                                this.folderBrowserDialog.Description = "Set destination directory";

                                // Show folder browser dialog
                                if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
                                {
                                    // Set custom directory path
                                    this.workingDirectoryPath = this.folderBrowserDialog.SelectedPath;
                                }
                                else
                                {
                                    // Reset status label
                                    this.toolStripStatusLabel.Text = "Enter pattern + target";

                                    // Reset progress bar value
                                    this.toolStripProgressBar.Value = 0;

                                    // Halt flow
                                    return;
                                }
                            }

                            // Save using custom directory
                            zip.Save(Path.Combine(this.customSaveDirectoryPath, $"{row.Target}.zip"));
                        }

                        // Increase file count
                        fileCount += fileList.Count;
                    }
                }
                catch (Exception)
                {
                    // Set progress value
                    progressValue = 0;

                    // Set status message
                    statusMessage = "Compress error.";

                    // Exit foreach loop
                    break;
                }
            }

            /* Post-compression */

            // Set progress bar value
            this.toolStripProgressBar.Value = progressValue;

            // Set success status message
            if (statusMessage.Length == 0)
            {
                // Set according to the total number of compressed files
                statusMessage = $"Compressed {fileCount} file{(fileCount > 1 ? "s" : string.Empty)}!";
            }

            // Inform user
            this.toolStripStatusLabel.Text = statusMessage;
        }

        /// <summary>
        /// Handles the compression level tool strip menu item drop down item clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCompressionLevelToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
        }

        /// <summary>
        /// Handles the save progress event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void SaveProgress(object sender, SaveProgressEventArgs e)
        {
            // Check event type
            if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
            {
                // Update tool strip progress bar
                this.toolStripProgressBar.Value = (int)((e.EntriesSaved * 100) / e.EntriesTotal);
            }
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
