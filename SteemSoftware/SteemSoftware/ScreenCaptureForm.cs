// <copyright file="ScreenCaptureForm.cs" company="SteemSoftware">
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
    /// Description of ScreenCaptureForm.
    /// </summary>
    public partial class ScreenCaptureForm : Form
    {
        /// <summary>
        /// The second screen viewer data.
        /// </summary>
        SecondScreenViewerData secondScreenViewerData;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.ScreenCaptureForm"/> class.
        /// </summary>
        public ScreenCaptureForm(SecondScreenViewerData secondScreenViewerData)
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the screen picture box mouse down event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnScreenPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the screen picture box mouse move event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnScreenPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the screen picture box mouse up event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnScreenPictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            // TODO Add code 
        }
    }
}
