// <copyright file="NewsTickerForm.cs" company="SteemSoftware">
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
    /// News ticker form.
    /// </summary>
    public partial class NewsTickerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.NewsTickerForm"/> class.
        /// </summary>
        /// <param name="newsTickerText">News ticker text.</param>
        /// <param name="newsTickerTextFont">News ticker text font.</param>
        /// <param name="textSpeed">Text speed.</param>
        /// <param name="foregroundColor">Foreground color.</param>
        /// <param name="backgroundColor">Background color.</param>
        public NewsTickerForm(string newsTickerText, Font newsTickerTextFont, int textSpeed, Color foregroundColor, Color backgroundColor)
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Newses the ticker timer tick.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void NewsTickerTimerTick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the news ticker form shown event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewsTickerFormShown(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}
