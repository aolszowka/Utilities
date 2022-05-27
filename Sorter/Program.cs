// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014-2022. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Sorter
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// A Toy program that eases the sorting and filtering of a list of strings.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
