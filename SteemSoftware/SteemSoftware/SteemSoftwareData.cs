// <copyright file="SteemSoftwareData.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// Steem software data.
    /// </summary>
    public class SteemSoftwareData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.SteemSoftwareData"/> class.
        /// </summary>
        public SteemSoftwareData()
        {
        }

        /// <summary>
        /// Gets or sets the size of the window.
        /// </summary>
        /// <value>The size of the window.</value>
        public Size WindowSize { get; set; }

        /// <summary>
        /// Gets or sets the window location.
        /// </summary>
        /// <value>The window location.</value>
        public Point WindowLocation { get; set; }

        /// <summary>
        /// Gets or sets the menu item checked state dictionary.
        /// </summary>
        /// <value>The menu item checked state dictionary.</value>
        public Dictionary<string, bool> MenuItemCheckedStateDictionary { get; set; }
    }
}
