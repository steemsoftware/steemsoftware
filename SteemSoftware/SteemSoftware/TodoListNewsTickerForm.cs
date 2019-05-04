// <copyright file="TodoListNewsTickerForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
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
        /// To do list news ticker data.
        /// </summary>
        private ToDoListNewsTickerData toDoListNewsTickerData;

        /// <summary>
        /// The data file path.
        /// </summary>
        private string dataFilePath = Path.Combine(Application.StartupPath, "Data", "Settings", "ToDoListNewsTickerData.bin");

        /// <summary>
        /// The font converter.
        /// </summary>
        private FontConverter fontConverter = new FontConverter();

        /// <summary>
        /// The news ticker form.
        /// </summary>
        private NewsTickerForm newsTickerForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.TodoListNewsTickerForm"/> class.
        /// </summary>
        public TodoListNewsTickerForm()
        {
            // Required for Windows Forms designer support.
            this.InitializeComponent();

            /* Process data file */

            // Check for a previously-saved data file
            if (File.Exists(this.dataFilePath))
            {
                // Read previous data from binary file
                this.toDoListNewsTickerData = this.ReadTickerDataFromFile(this.dataFilePath);

                // Bring data to life in GUI
                this.LoadToDoListNewsTickerData();
            }
            else
            {
                // New ticker data instance with initial values set
                this.toDoListNewsTickerData = new ToDoListNewsTickerData
                {
                    TimerInterval = 10,

                    Separator = "  |  ",

                    TextFont = this.fontConverter.ConvertToInvariantString(this.mainFontDialog.Font),

                    ForegroundColor = this.foregroundColorDialog.Color,

                    BackgroundColor = this.backgroundColorDialog.Color,

                    LeftMargin = 50,

                    RightMargin = 50,
                };
            }
        }

        /// <summary>
        /// Reads the ticker data from file.
        /// </summary>
        /// <returns>The ticker data from file.</returns>
        /// <param name="tickerDataFilePath">Ticker data file path.</param>
        private ToDoListNewsTickerData ReadTickerDataFromFile(string tickerDataFilePath)
        {
            // Variable to hold read ticker data
            ToDoListNewsTickerData tickerData;

            // Read data from binary file
            IFormatter formatter = new BinaryFormatter();
            Stream binaryFileStream = new FileStream(tickerDataFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            tickerData = (ToDoListNewsTickerData)formatter.Deserialize(binaryFileStream);
            binaryFileStream.Close();

            // Return read ticker data
            return tickerData;
        }

        /// <summary>
        /// Writes the ticker data to file.
        /// </summary>
        /// <param name="tickerDataFilePath">Ticker data file path.</param>
        private void WriteTickerDataToFile(string tickerDataFilePath)
        {
            // Save ticker data to binary file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(tickerDataFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.toDoListNewsTickerData);
            stream.Close();
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
                $"plus, minus{Environment.NewLine}Icons made by Smashicons @ https://www.flaticon.com/authors/smashicons{Environment.NewLine}from https://www.flaticon.com/{Environment.NewLine}Licensed by Creative Commons BY 3.0 (CC 3.0 BY){Environment.NewLine}http://creativecommons.org/licenses/by/3.0/";

            // Set about form
            var aboutForm = new AboutForm(
                 $"About {this.moduleName}",
                 $"{this.moduleName} {this.semanticVersion}",
                 "Week #17 @ April 2019",
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
            // Variable to hold user input
            int parsedInt;

            // Try to parse
            if (int.TryParse(Interaction.InputBox("Set ticker timer interval (milliseconds, less is faster)", "Text speed", this.toDoListNewsTickerData.TimerInterval.ToString(), -1, -1), out parsedInt))
            {
                // Set custom value
                this.toDoListNewsTickerData.TimerInterval = parsedInt;
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
            if (this.todoListBox.Items.Count > 0 && MessageBox.Show("Proceed to clear list items?", "New list", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // Clear To-do list
                this.todoListBox.Items.Clear();
            }
        }

        /// <summary>
        /// Loads the To-do list news ticker data.
        /// </summary>
        private void LoadToDoListNewsTickerData()
        {
            // Font
            this.mainFontDialog.Font = (Font)this.fontConverter.ConvertFromInvariantString(this.toDoListNewsTickerData.TextFont);

            // Always on top
            this.alwaysOnTopToolStripMenuItem.Checked = this.toDoListNewsTickerData.AlwaysOnTop;

            // Full width
            this.fullWidthToolStripMenuItem.Checked = this.toDoListNewsTickerData.FullWidth;

            // Foreground color
            this.foregroundColorDialog.Color = this.toDoListNewsTickerData.ForegroundColor;

            // Background color
            this.backgroundColorDialog.Color = this.toDoListNewsTickerData.BackgroundColor;

            // Clear To-do list
            this.todoListBox.Items.Clear();

            // Load items
            this.todoListBox.Items.AddRange(this.toDoListNewsTickerData.ListItems.Cast<object>().ToArray());
        }

        /// <summary>
        /// Sets the To-do list news ticker data.
        /// </summary>
        private void SetToDoListNewsTickerData()
        {
            // Font
            this.toDoListNewsTickerData.TextFont = this.fontConverter.ConvertToInvariantString(this.mainFontDialog.Font);

            // Always on top
            this.toDoListNewsTickerData.AlwaysOnTop = this.alwaysOnTopToolStripMenuItem.Checked;

            // Full width
            this.toDoListNewsTickerData.FullWidth = this.fullWidthToolStripMenuItem.Checked;

            // Foreground color
            this.toDoListNewsTickerData.ForegroundColor = this.foregroundColorDialog.Color;

            // Background color
            this.toDoListNewsTickerData.BackgroundColor = this.backgroundColorDialog.Color;

            // Set new list (blank slate)
            this.toDoListNewsTickerData.ListItems = new List<string>(this.todoListBox.Items.Cast<string>());
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
                /* Populate ticker data */

                try
                {
                    // Deserialize to variable
                    this.toDoListNewsTickerData = this.ReadTickerDataFromFile(this.openFileDialog.FileName);

                    // Load data
                    this.LoadToDoListNewsTickerData();
                }
                catch (Exception)
                {
                    // Inform user
                    this.mainToolStripStatusLabel.Text = "Open file error";
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
            // Set file name
            this.saveFileDialog.FileName = Path.GetFileNameWithoutExtension(this.dataFilePath);

            // Open save file dialog
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
            {
                /* Save ticker data */

                try
                {
                    // Set data
                    this.SetToDoListNewsTickerData();

                    // Write data to file
                    this.WriteTickerDataToFile(this.saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    // Inform user
                    this.mainToolStripStatusLabel.Text = "Save file error";
                }

                // Inform user
                this.mainToolStripStatusLabel.Text = $"Saved to \"{Path.GetFileName(this.saveFileDialog.FileName)}\"";
            }
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
                this.todoListBox.Items.Add(listItem);
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
            if (this.todoListBox.SelectedIndex > -1)
            {
                // Remove item by index
                this.todoListBox.Items.RemoveAt(this.todoListBox.SelectedIndex);
            }
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
            string separator = Interaction.InputBox("Set To-do list items separator", "Separator", this.toDoListNewsTickerData.Separator, -1, -1);

            // Check there's something to work with
            if (separator.Length > 0)
            {
                // Set new separator
                this.toDoListNewsTickerData.Separator = separator;
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
        /// Handles the left tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLeftToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Variable to hold user input
            int parsedInt;

            // Try to parse
            if (int.TryParse(Interaction.InputBox("Set left margin (in pixels)", "Ticker form margin", this.toDoListNewsTickerData.LeftMargin.ToString(), -1, -1), out parsedInt))
            {
                // Set custom value
                this.toDoListNewsTickerData.LeftMargin = parsedInt;
            }
        }

        /// <summary>
        /// Handle the right tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRightToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Variable to hold user input
            int parsedInt;

            // Try to parse
            if (int.TryParse(Interaction.InputBox("Set right margin (in pixels)", "Ticker form margin", this.toDoListNewsTickerData.RightMargin.ToString(), -1, -1), out parsedInt))
            {
                // Set custom value
                this.toDoListNewsTickerData.RightMargin = parsedInt;
            }
        }

        /// <summary>
        /// Handles the bottom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBottomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Variable to hold user input
            int parsedInt;

            // Try to parse
            if (int.TryParse(Interaction.InputBox("Set bottom margin (in pixels)", "Ticker form margin", this.toDoListNewsTickerData.BottomMargin.ToString(), -1, -1), out parsedInt))
            {
                // Set custom value
                this.toDoListNewsTickerData.BottomMargin = parsedInt;
            }
        }

        /// <summary>
        /// Handles the todo list news ticker form form closing eve.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTodoListNewsTickerFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if must remember settings 
            if (this.rememberSettingsToolStripMenuItem.Checked)
            {
                // Set data
                this.SetToDoListNewsTickerData();

                // Write data to disk
                this.WriteTickerDataToFile(this.dataFilePath);
            }
            else
            {
                // Delete data file
                File.Delete(this.dataFilePath);
            }

            // Finally, check for an active ticker form
            if (this.newsTickerForm != null)
            {
                // Close ticker form
                this.newsTickerForm.Close();
            }
        }

        /// <summary>
        /// Handles the todo list box mouse down event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTodoListBoxMouseDown(object sender, MouseEventArgs e)
        {
            // Set item index
            int itemIndex = this.todoListBox.IndexFromPoint(e.Location);

            // Check for an actual item and a right click
            if (itemIndex > -1 && e.Button == MouseButtons.Right)
            {
                // Collect new item text
                string itemText = Interaction.InputBox("Modify To-do list item text", "Edit text", this.todoListBox.Items[itemIndex].ToString(), -1, -1);

                // Check there's something to work with
                if (itemText.Length > 0)
                {
                    // Set new item text
                    this.todoListBox.Items[itemIndex] = itemText;
                }
            }
        }

        /// <summary>
        /// Handles the show ticker button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnShowTickerButtonClick(object sender, EventArgs e)
        {
            // Check for list items
            if (this.todoListBox.Items.Count == 0)
            {
                // Halt flow
                return;
            }

            // Check button text
            if (this.showTickerButton.Text.StartsWith("&C", StringComparison.InvariantCulture))
            {
                // Close news ticker form
                this.newsTickerForm.Close();

                // Set text back
                this.showTickerButton.Text = "&Show ticker";

                // Halt flow
                return;
            }
            else
            {
                // Update text
                this.showTickerButton.Text = "&Close ticker";
            }

            // Set ticker data
            this.SetToDoListNewsTickerData();

            // Set working area width
            var workingAreaWidth = Screen.FromControl(this).WorkingArea.Width;

            // Set working area height
            var workingAreaHeight = Screen.FromControl(this).WorkingArea.Height;

            // Set news ticker font
            var newsTickerFont = (Font)this.fontConverter.ConvertFromInvariantString(this.toDoListNewsTickerData.TextFont);

            // Declare new ticker form
            this.newsTickerForm = new NewsTickerForm(string.Join(this.toDoListNewsTickerData.Separator, this.todoListBox.Items.Cast<string>()), newsTickerFont, this.toDoListNewsTickerData.TimerInterval, this.toDoListNewsTickerData.ForegroundColor, this.toDoListNewsTickerData.BackgroundColor)
            {
                // Set ticker height using font's height plus 10 pixels for padding
                Height = newsTickerFont.Height + 10,

                // Set ticker width
                Width = workingAreaWidth
            };

            // Check for full width
            if (!this.fullWidthToolStripMenuItem.Checked)
            {
                // Subtract from width
                this.newsTickerForm.Width -= this.toDoListNewsTickerData.LeftMargin + this.toDoListNewsTickerData.RightMargin;

                // Adjust left
                this.newsTickerForm.Left = this.toDoListNewsTickerData.LeftMargin;
            }

            // Adjust top
            this.newsTickerForm.Top = workingAreaHeight - this.newsTickerForm.Height - this.toDoListNewsTickerData.BottomMargin;

            // Handle always on top
            this.newsTickerForm.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;

            // Show news ticker
            this.newsTickerForm.Show();
        }
    }
}