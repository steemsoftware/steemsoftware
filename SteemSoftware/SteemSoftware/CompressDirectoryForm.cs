// <copyright file="CompressDirectoryForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Ionic.Zip;

    /// <summary>
    /// Description of CompressDirectoryForm.
    /// </summary>
    public partial class CompressDirectoryForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "Compress Directory";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.0";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.CompressDirectoryForm"/> class.
        /// </summary>
        public CompressDirectoryForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
            $"Icons from wpclipart.com are in the public domain:{Environment.NewLine}" +
            $"package x generic @ https://www.wpclipart.com/computer/icons/file_type/mimetypes/package_x_generic.png.html{Environment.NewLine}" +
            $"folder @ https://www.wpclipart.com/computer/icons/folders/tango_folders/folder.png.html";

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
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close module
            this.Close();
        }

        /// <summary>
        /// Handles the compress button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnCompressButtonClick(object sender, EventArgs e)
        {
            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Directory name
                var directoryName = new DirectoryInfo(this.folderBrowserDialog.SelectedPath).Name;

                // Set file name
                this.saveFileDialog.FileName = $"{directoryName}.zip";

                // Open save file dialog
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    // Set progress value
                    var progressValue = 100;

                    // Set status message
                    var statusMessage = "Success!";

                    // Compress directory to zip file
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

                            // Check if must add root directory
                            if (this.addDirectoryRootToolStripMenuItem.Checked)
                            {
                                // Add directory to zip file with root
                                zip.AddDirectory(this.folderBrowserDialog.SelectedPath, directoryName);
                            }
                            else
                            {
                                // Add directory to zip file, no root
                                zip.AddDirectory(this.folderBrowserDialog.SelectedPath);
                            }

                            // Save to zip file
                            zip.Save(this.saveFileDialog.FileName);
                        }
                    }
                    catch (Exception)
                    {
                        // Set progress value
                        progressValue = 0;

                        // Set status message
                        statusMessage = "Error.";
                    }
                    finally
                    {
                        // Set progress bar value
                        this.progressToolStripProgressBar.Value = progressValue;

                        // Inform user
                        this.statusToolStripStatusLabel.Text = statusMessage;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Perform click on expand button
            this.expandButton.PerformClick();
        }

        /// <summary>
        /// Handles the browse tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnBrowseToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the compression level tool strip menu item drop down item clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnCompressionLevelToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Uncheck all drop down items
            foreach (var item in this.compressionLevelToolStripMenuItem.DropDownItems)
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
        /// Handles the add directory root tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnAddDirectoryRootToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Toggle check state
            this.addDirectoryRootToolStripMenuItem.Checked = !this.addDirectoryRootToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the expand button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnExpandButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
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
                this.progressToolStripProgressBar.Value = (int)(e.EntriesSaved * 100 / e.EntriesTotal);
            }
        }
    }
}
