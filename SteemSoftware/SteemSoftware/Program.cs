// <copyright file="Program.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    // Directives
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        [STAThread]
        private static void Main(string[] args)
        {
            // Enable visual styles
            Application.EnableVisualStyles();

            // Set compatible text rendering default
            Application.SetCompatibleTextRenderingDefault(false);

            // Run application
            Application.Run(new MainForm());
        }
    }
}
