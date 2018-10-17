// <copyright file="AboutForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Description of AboutForm.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.AboutForm"/> class.
        /// </summary>
        public AboutForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Ons the ok button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOkButtonClick(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        /// <summary>
        /// Licenses the rich text box link clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLicenseRichTextBoxLinkClicked(object sender, LinkClickedEventArgs e)
        {
            // Uri
            var uri = new Uri(e.LinkText);

            // Validate url 
            if (uri.IsWellFormedOriginalString())
            {
                // Launch with default browser
                Process.Start(uri.ToString());
            }
        }
    }
}
