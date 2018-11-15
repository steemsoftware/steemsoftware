// <copyright file="CompressDirectoryForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Description of CompressDirectoryForm.
    /// </summary>
    public partial class CompressDirectoryForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.CompressDirectoryForm"/> class.
        /// </summary>
        public CompressDirectoryForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the compress button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnCompressButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the open tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the browse tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event parameters.</param>
        private void OnBrowseToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the compression level tool strip menu item drop down item clicked.
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
            clickedItem.Checked = !clickedItem.Checked;
        }
    }
}
