// <copyright file="StrongPasswordGeneratorForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Strong password generator form.
    /// </summary>
    public partial class StrongPasswordGeneratorForm : Form
    {
        /// <summary>
        /// The name of the module.
        /// </summary>
        private string moduleName = "Strong Password Generator";

        /// <summary>
        /// The semantic version.
        /// </summary>
        private string semanticVersion = "0.1.1";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.StrongPasswordGeneratorForm"/> class.
        /// </summary>
        public StrongPasswordGeneratorForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Populate length combo box */

            // Add 16 to 128
            this.lengthComboBox.Items.AddRange(Enumerable.Range(16, 112).Cast<object>().ToArray());

            // Add 256+ doublings
            for (int i = 256; i <= 2048; i = i * 2)
            {
                // Add current value
                this.lengthComboBox.Items.Add(i);
            }
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}";

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
            // Set combo box back to 16
            this.lengthComboBox.Text = "16";

            // Reset text box
            this.passwordTextBox.Clear();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close
            this.Close();
        }

        /// <summary>
        /// Handles the generate password button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGeneratePasswordButtonClick(object sender, EventArgs e)
        {
            // Password length
            int passwordLength;

            // TODO Try to parse from combo box value [Allow numbers only on key preview]
            if (!int.TryParse(this.lengthComboBox.Text, out passwordLength))
            {
                // Inform user
                MessageBox.Show("Invalid length value", "Length error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Halt flow
                return;
            }

            // Generate new password
            var strongPassword = System.Web.Security.Membership.GeneratePassword(passwordLength, 0);

            // Status text
            var statusText = string.Empty;

            // Check if must copy to clipboard
            if (this.clipboardCheckBox.Checked)
            {
                // Set clipboard text
                Clipboard.SetText(strongPassword);

                // Set status text
                statusText = "Password has been copied to clipboard!";
            }
            else
            {
                // Set status text
                statusText = "Password has been generated!";
            }

            // Set password text box
            this.passwordTextBox.Text = strongPassword;

            // Show status text
            this.mainToolStripStatusLabel.Text = statusText;
        }
    }
}
