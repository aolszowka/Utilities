// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DictionaryFilter
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// A Toy Program that simulates dynamic Dictionary creation and lookup.
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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
