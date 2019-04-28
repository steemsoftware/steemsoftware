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
        /// The form graphics.
        /// </summary>
        private Graphics formGraphics;

        /// <summary>
        /// The news ticker text font.
        /// </summary>
        private Font newsTickerTextFont;

        /// <summary>
        /// The news ticker text.
        /// </summary>
        private string newsTickerText;

        /// <summary>
        /// The position in the x axis.
        /// </summary>
        private int xPos;

        /// <summary>
        /// The color of the foreground.
        /// </summary>
        private Color foregroundColor;

        /// <summary>
        /// The size of the text.
        /// </summary>
        private Size textSize;

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

            // Set form control graphics
            this.formGraphics = this.CreateGraphics();

            // Set ticker text
            this.newsTickerText = newsTickerText;

            // Set ticker font
            this.newsTickerTextFont = newsTickerTextFont;

            // Measure string.
            this.textSize = TextRenderer.MeasureText(newsTickerText, newsTickerTextFont);

            // Set ticker text speed
            this.newsTickerTimer.Interval = textSpeed;

            // Set form's background color
            this.BackColor = backgroundColor;

            // Set ticker font color
            this.foregroundColor = foregroundColor;

            // Set xPos to the rightmost point
            this.xPos = this.DisplayRectangle.Width;
        }

        /// <summary>
        /// Handles the form's paint event.
        /// </summary>
        /// <param name="e">Paint event arguments.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Set current buffered graphics context
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;

            // Set buffered graphics
            BufferedGraphics bufferedGraphics = currentContext.Allocate(e.Graphics, this.DisplayRectangle);

            // Clear graphics
            bufferedGraphics.Graphics.Clear(this.BackColor);

            // Draw news ticker text. 5 = half padding
            bufferedGraphics.Graphics.DrawString(this.newsTickerText, this.newsTickerTextFont, new SolidBrush(this.foregroundColor), this.xPos, 5);

            // Make it happen
            bufferedGraphics.Render();

            // Free resources
            bufferedGraphics.Dispose();
        }

        /// <summary>
        /// Newses the ticker timer tick.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void NewsTickerTimerTick(object sender, EventArgs e)
        {
            // Check if text finished displaying
            if (this.xPos < (this.textSize.Width * -1))
            {
                // Reset text position to the rightmost point
                this.xPos = this.DisplayRectangle.Width;
            }
            else
            {
                // Make text move to the left smoothly i.e. one pixel at a time
                this.xPos -= 1;
            }

            // Force redraw
            this.Invalidate();
        }

        /// <summary>
        /// Handles the news ticker form shown event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewsTickerFormShown(object sender, EventArgs e)
        {
            // Enable news ticker timer
            this.newsTickerTimer.Enabled = true;
        }
    }
}