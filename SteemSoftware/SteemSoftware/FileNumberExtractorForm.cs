﻿// <copyright file="FileNumberExtractorForm.cs" company="SteemSoftware">
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
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    /// <summary>
    /// Description of FileNumberExtractorForm.
    /// </summary>
    public partial class FileNumberExtractorForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "File Number Extractor";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.1";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.FileNumberExtractorForm"/> class.
        /// </summary>
        public FileNumberExtractorForm()
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
                $"archives, folder{Environment.NewLine}Icons made by Icongeek26 @ https://www.flaticon.com/authors/icongeek26{Environment.NewLine}from https://www.flaticon.com/{Environment.NewLine}Licensed by Creative Commons BY 3.0 (CC 3.0 BY){Environment.NewLine}http://creativecommons.org/licenses/by/3.0/";

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
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Reset suffix text box
            this.suffixTextBox.Text = "_numbers";

            // Reset extension text box
            this.extensionTextBox.Text = "txt,text";

            // Reset status message
            this.statusToolStripStatusLabel.Text = "Browse for file or folder";
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open file
            this.openFileButton.PerformClick();
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
        /// Handles the open file button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenFileButtonClick(object sender, EventArgs e)
        {
            // Show open file dialog
            if (this.mainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Process files
                this.ProcessFiles(this.mainOpenFileDialog.FileNames);
            }
        }

        /// <summary>
        /// Handles the browse for folder button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseForFolderButtonClick(object sender, EventArgs e)
        {
            // Show folder browser dialog
            if (this.mainFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // File path list
                var filePathList = new List<string>();

                // File extension list
                var fileExtensionList = new List<string>();

                // Populate file extension list
                foreach (var extension in this.extensionTextBox.Text.Split(','))
                {
                    // Add extension to list
                    fileExtensionList.Add($"{(extension.StartsWith(".", StringComparison.InvariantCulture) ? "" : ".")}{extension}");
                }

                // Collect target files
                var targetFiles = Directory.GetFiles(this.mainFolderBrowserDialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
                                           .Where(s => fileExtensionList.Contains(Path.GetExtension(s)))
                                           .ToArray();

                // Process target files
                this.ProcessFiles(targetFiles);
            }
        }

        /// <summary>
        /// Processes the files.
        /// </summary>
        /// <param name="filePathArray">File path array.</param>
        private void ProcessFiles(string[] filePathArray)
        {
            // Processed files counter
            var processedFiles = 0;

            // Try to save extracted numbers to file
            try
            {
                // Process files
                foreach (var filePath in filePathArray)
                {
                    // Get file numbers
                    var fileNumbers = this.ExtractNumbersFromFile(filePath, this.suffixTextBox.Text);

                    // Chek for non-empty
                    if (fileNumbers.Length > 0)
                    {
                        // Set numbers file path
                        var numberFilePath = Path.Combine(Path.GetDirectoryName(filePath), $"{Path.GetFileNameWithoutExtension(filePath)}{this.suffixTextBox.Text}{Path.GetExtension(filePath)}");

                        // Save extracted file numbers
                        File.WriteAllText(numberFilePath, fileNumbers);

                        // Rise processed files counter
                        processedFiles++;
                    }
                }

                // Update status
                this.statusToolStripStatusLabel.Text = $"Saved {processedFiles} number file{(processedFiles > 1 ? "s" : string.Empty)}";
            }
            catch (Exception)
            {
                // Update status
                this.statusToolStripStatusLabel.Text = "Error when processing files.";
            }
        }

        /// <summary>
        /// Extracts the numbers from file.
        /// </summary>
        /// <returns>The numbers from file.</returns>
        /// <param name="filePath">File path.</param>
        /// <param name="fileSuffix">File suffix.</param>
        private string ExtractNumbersFromFile(string filePath, string fileSuffix)
        {
            // Try to extract numbers from file
            try
            {
                // Read all lines to file lines
                var fileLines = File.ReadAllLines(filePath);

                // Declare number string builder
                var numberStringBuilder = new StringBuilder();

                // Extract numbers from lines
                foreach (var line in fileLines)
                {
                    // Set current line numbers
                    var lineNumbers = string.Join(" ", Regex.Matches(line, @"-?\d+").Cast<Match>().Select(m => m.Value));

                    // Check for non-empty
                    if (lineNumbers.Length > 0)
                    {
                        // Append current line numbers
                        numberStringBuilder.AppendLine(lineNumbers);
                    }
                }

                // Return extracted numbers
                return numberStringBuilder.ToString();
            }
            catch (Exception)
            {
                // Default
                return string.Empty;
            }
        }
    }
}
