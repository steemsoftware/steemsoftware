// <copyright file="SecondScreenViewerForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Drawing;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;

    /// <summary>
    /// Description of SecondScreenMonitorForm.
    /// </summary>
    public partial class SecondScreenViewerForm : Form
    {
        /// <summary>
        /// The second screen viewer data.
        /// </summary>
        private SecondScreenViewerData secondScreenViewerData;

        /// <summary>
        /// The data file path.
        /// </summary>
        private string dataFilePath = Path.Combine(Application.StartupPath, "Data", "Settings", "SecondScreenViewerData.bin");

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.SecondScreenViewerForm"/> class event.
        /// </summary>
        public SecondScreenViewerForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // Check for a previously-saved data file
            if (File.Exists(this.dataFilePath))
            {
                // Read previous data from binary file
                this.secondScreenViewerData = this.ReadViewerDataFromFile(this.dataFilePath);

                // Bring data to life in GUI
                this.LoadViewerData();
            }
            else
            {
                // New second screen viewer data instance with initial values set
                this.secondScreenViewerData = new SecondScreenViewerData
                {
                    TimerInterval = 200,
                    InitialWidth = 0,
                    InitialHeight = 480,
                    AlwaysOnTop = true,
                    KeepAspectRatio = true,
                    ClickToClose = false
                };
            }
        }

        /// <summary>
        /// Reads the viewer data from file.
        /// </summary>
        /// <returns>The viewer data from file.</returns>
        /// <param name="viewerDataFilePath">Viewer data file path.</param>
        private SecondScreenViewerData ReadViewerDataFromFile(string viewerDataFilePath)
        {
            // Variable to hold read viewer data
            SecondScreenViewerData viewerData;

            // Read data from binary file
            IFormatter formatter = new BinaryFormatter();
            Stream binaryFileStream = new FileStream(viewerDataFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            viewerData = (SecondScreenViewerData)formatter.Deserialize(binaryFileStream);
            binaryFileStream.Close();

            // Return read viewer data
            return viewerData;
        }

        /// <summary>
        /// Writes the viewer data to file.
        /// </summary>
        /// <param name="viewerDataFilePath">Viewer data file path.</param>
        private void WriteViewerDataToFile(string viewerDataFilePath)
        {
            // Save viewer data to binary file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(viewerDataFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.secondScreenViewerData);
            stream.Close();
        }

        /// <summary>
        /// Loads the viewer data to the GUI.
        /// </summary>
        private void LoadViewerData()
        {
            // Always on top
            this.alwaysOnTopToolStripMenuItem.Checked = this.secondScreenViewerData.AlwaysOnTop;

            // Keep aspect ratio
            this.keepAspectRatioToolStripMenuItem.Checked = this.secondScreenViewerData.KeepAspectRatio;

            // Click to close
            this.clickToCloseToolStripMenuItem.Checked = this.secondScreenViewerData.ClickToClose;
        }

        /// <summary>
        /// Sets the viewer data from the GUI.
        /// </summary>
        private void SetViewerData()
        {
            // Always on top
            this.secondScreenViewerData.AlwaysOnTop = this.alwaysOnTopToolStripMenuItem.Checked;

            // Keep aspect ratio
            this.secondScreenViewerData.KeepAspectRatio = this.keepAspectRatioToolStripMenuItem.Checked;

            // Click to close
            this.secondScreenViewerData.ClickToClose = this.clickToCloseToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the screen capture interval tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnScreenCaptureIntervalToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the initialwidth tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnInitialwidthToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the initialheight tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnInitialheightToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked event.
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
            // TODO add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Exit module
            this.Close();
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set initial file name
            this.openFileDialog.FileName = Path.GetFileNameWithoutExtension(this.dataFilePath);

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Populate screen viewer data
                try
                {
                    // Deserialize to variable
                    this.secondScreenViewerData = this.ReadViewerDataFromFile(this.openFileDialog.FileName);

                    // Load data
                    this.LoadViewerData();
                }
                catch (Exception)
                {
                    // Inform user
                    this.toolStripStatusLabel.Text = "Open file error";
                }
            }
        }
    }
}
