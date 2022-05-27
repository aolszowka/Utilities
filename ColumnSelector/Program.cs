// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ColumnSelector
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Initial entry point for the Column Selector program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
