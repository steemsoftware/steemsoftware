// <copyright file="ModuleInfo.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Module info.
    /// </summary>
    public class ModuleInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SteemSoftware.ModuleInfo"/> class.
        /// </summary>
        /// <param name="name">Module name.</param>
        /// <param name="description">Module description.</param>
        /// <param name="formType">Form type.</param>
        public ModuleInfo(string name, string description, Type formType)
        {
            // Set name
            this.Name = name;

            // Set description
            this.Description = description;

            // Set form type
            this.FormType = formType;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the form.
        /// </summary>
        /// <value>The type of the form.</value>
        public Type FormType { get; set; }
    }
}
