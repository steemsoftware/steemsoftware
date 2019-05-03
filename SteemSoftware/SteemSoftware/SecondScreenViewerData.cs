// <copyright file="SecondScreenViewerData.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;

    /// <summary>
    /// To do list news ticker data.
    /// </summary>
    [Serializable]
    public class SecondScreenViewerData
    {
        /// <summary>
        /// Gets or sets the timer interval.
        /// </summary>
        /// <value>The timer interval.</value>
        public int TimerInterval { get; set; }

        /// <summary>
        /// Gets or sets the initial width.
        /// </summary>
        /// <value>The initial width.</value>
        public int InitialWidth { get; set; }

        /// <summary>
        /// Gets or sets the initial height.
        /// </summary>
        /// <value>The initial height.</value>
        public int InitialHeight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:SteemSoftware.SecondScreenViewerData"/> field is always on top.
        /// </summary>
        /// <value><c>true</c> if always on top; otherwise, <c>false</c>.</value>
        public bool AlwaysOnTop { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:SteemSoftware.SecondScreenViewerData"/> keeps the aspect ratio.
        /// </summary>
        /// <value><c>true</c> if keep aspect ratio is kept; otherwise, <c>false</c>.</value>
        public bool KeepAspectRatio { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:SteemSoftware.SecondScreenViewerData"/> closes with a click.
        /// </summary>
        /// <value><c>true</c> if a click closes it; otherwise, <c>false</c>.</value>
        public bool ClickToClose { get; set; }
    }
}
