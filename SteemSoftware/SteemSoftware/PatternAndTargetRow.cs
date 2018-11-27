// <copyright file="PatternAndTargetRow.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;

    /// <summary>
    /// Pattern and target row.
    /// </summary>
    public class PatternAndTargetRow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.PatternAndTargetRow"/> class.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="target">The target.</param>
        /// <param name="isRegex">If set to <c>true</c> is regex.</param>
        public PatternAndTargetRow(string pattern, string target, bool isRegex)
        {
            // Set pattern
            this.Pattern = pattern;

            // Set target
            this.Target = target;

            // Set is regex flag
            this.IsRegex = isRegex;
        }

        /// <summary>
        /// Gets or sets the pattern.
        /// </summary>
        /// <value>The pattern.</value>
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:SteemSoftware.PatternAndTargetRow"/> is regex.
        /// </summary>
        /// <value><c>true</c> if is regex; otherwise, <c>false</c>.</value>
        public bool IsRegex { get; set; }
    }
}
