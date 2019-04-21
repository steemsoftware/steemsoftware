// <copyright file="TodoListNewsTickerForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;

    /// <summary>
    /// Todo list news ticker form.
    /// </summary>
    public partial class TodoListNewsTickerForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "To-do List News Ticker";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.0";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.TodoListNewsTickerForm"/> class.
        /// </summary>
        public TodoListNewsTickerForm()
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
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode";

            // Set about form
            var aboutForm = new AboutForm(
                 $"About {this.moduleName}",
                 $"{this.moduleName} {this.semanticVersion}",
                 "Week #16 @ April 2019",
                 licenseText,
                 this.Icon.ToBitmap());

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the font tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFontToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Show the font dialog
            this.mainFontDialog.ShowDialog();
        }

        /// <summary>
        /// Handles the text speed tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTextSpeedToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the always on top tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAlwaysOnTopToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the remember settings tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRememberSettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
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
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the save tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
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
            // TODO add code
        }

        /// <summary>
        /// Handles the todo checked list box double click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTodoCheckedListBoxDoubleClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the add button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddButtonClick(object sender, EventArgs e)
        {
            // Ask user for new list item
            string listItem = Interaction.InputBox("Set new To-do list item text", "Add item", string.Empty, -1, -1);

            // Check there's something to work with
            if (listItem.Length > 0)
            {
                // Add to To-do list
                this.todoCheckedListBox.Items.Add(listItem);
            }
        }

        /// <summary>
        /// Handles the remove button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRemoveButtonClick(object sender, EventArgs e)
        {
            // Check for a selected item
            if (this.todoCheckedListBox.SelectedIndex > -1)
            {
                // Remove item by index
                this.todoCheckedListBox.Items.RemoveAt(this.todoCheckedListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Handles the launch button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLaunchButtonClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the full width tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFullWidthToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the horizontal tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnHorizontalToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the vertical tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnVerticalToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the separator tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSeparatorToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO add code
        }

        /// <summary>
        /// Handles the foreground tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnForegroundToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Show the foreground color dialog
            this.foregroundColorDialog.ShowDialog();
        }

        /// <summary>
        /// Handles the background tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBackgroundToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Show the background color dialog
            this.backgroundColorDialog.ShowDialog();
        }
    }
}
