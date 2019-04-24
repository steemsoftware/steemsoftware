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
        /// The news ticker timer interval.
        /// </summary>
        private int newsTickerTimerInterval;

        /// <summary>
        /// The news ticker separator.
        /// </summary>
        private string newsTickerSeparator;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.TodoListNewsTickerForm"/> class.
        /// </summary>
        public TodoListNewsTickerForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set values */

            // News ticker timer interval
            this.newsTickerTimerInterval = 10;

            // News ticker separator
            this.newsTickerSeparator = "  |  ";
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
            // Declare custom value variable
            int customValue;

            // Try to parse
            if (int.TryParse(Interaction.InputBox("Set ticker timer interval (milliseconds, less is faster)", "Text speed", this.newsTickerTimerInterval.ToString(), -1, -1), out customValue))
            {
                // Set custom value
                this.newsTickerTimerInterval = customValue;
            }
        }

        /// <summary>
        /// Handles the always on top tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAlwaysOnTopToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Toggle checked state
            this.alwaysOnTopToolStripMenuItem.Checked = !this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the remember settings tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRememberSettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Toggle checked state
            this.rememberSettingsToolStripMenuItem.Checked = !this.rememberSettingsToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check for items, then ask user about clearing them
            if (this.todoCheckedListBox.Items.Count > 0 && MessageBox.Show("Proceed to clear list items?", "New list", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // Clear To-do list
                this.todoCheckedListBox.Items.Clear();
            }
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
            // Exit module
            this.Close();
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

                // Check added item
                this.todoCheckedListBox.SetItemChecked(this.todoCheckedListBox.Items.Count - 1, true);
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
            // Toggle checked state
            this.fullWidthToolStripMenuItem.Checked = !this.fullWidthToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the separator tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSeparatorToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Ask user for new separator
            string separator = Interaction.InputBox("Set To-do list items separator", "Separator", this.newsTickerSeparator, -1, -1);

            // Check there's something to work with
            if (separator.Length > 0)
            {
                // Set new separator
                this.newsTickerSeparator = separator;
            }
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

        /// <summary>
        /// Handles the todo checked list box mouse down event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTodoCheckedListBoxMouseDown(object sender, MouseEventArgs e)
        {
            // Set item index
            int itemIndex = this.todoCheckedListBox.IndexFromPoint(e.Location);

            // Check for an actual item and a right click
            if (itemIndex > -1 && e.Button == MouseButtons.Right)
            {
                // Collect new item text
                string itemText = Interaction.InputBox("Modify To-do list item text", "Edit text", this.todoCheckedListBox.Items[itemIndex].ToString(), -1, -1);

                // Check there's something to work with
                if (itemText.Length > 0)
                {
                    // Set new item text
                    this.todoCheckedListBox.Items[itemIndex] = itemText;
                }
            }
        }

        /// <summary>
        /// Handlesthe left tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLeftToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handlesthe right tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRightToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handlesthe bottom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBottomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}