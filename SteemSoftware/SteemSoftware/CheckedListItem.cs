// <copyright file="CheckedListItem.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;

    /// <summary>
    /// Checked list item.
    /// </summary>
    [Serializable]
    public class CheckedListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.CheckedListItem"/> class.
        /// </summary>
        /// <param name="itemText">Item text.</param>
        /// <param name="checkedValue">If set to <c>true</c> checked value.</param>
        public CheckedListItem(string itemText, bool checkedValue)
        {
            // Set item text
            this.ItemText = itemText;

            // Set checked value
            this.CheckedValue = checkedValue;
        }

        /// <summary>
        /// Gets the item text.
        /// </summary>
        /// <value>The item text.</value>
        public string ItemText { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:SteemSoftware.CheckedListItem"/> value is checked.
        /// </summary>
        /// <value><c>true</c> if checked value; otherwise, <c>false</c>.</value>
        public bool CheckedValue { get; }
    }
}