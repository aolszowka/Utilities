// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014-2015. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ColumnSelector
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// A program to allow you to select a column from input.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The options for this program.
        /// </summary>
        private ColumnSelectorOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();

            // Column Selector Options
            this.options =
                new ColumnSelectorOptions()
                {
                    ColumnToSelect = 0,
                    ColumnDelimiter = '\t'
                };

            // Set our default font (Consolas)
            var currentFont =
                new Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this._SetTextBoxFont(currentFont);
        }

        /// <summary>
        /// EventHandler for when a Key is pressed down.
        /// </summary>
        /// <param name="sender">The object that invoked the ProcessHotkeys EventHandler.</param>
        /// <param name="e">The KeyEventArgs from that control.</param>
        private void ProcessHotkeys(object sender, KeyEventArgs e)
        {
            // Select All
            if (e.Control && e.KeyCode == Keys.A)
            {
                // Check to see if we were in a textbox control
                TextBox textBoxControl = sender as TextBox;
                if (textBoxControl != null)
                {
                    textBoxControl.SelectAll();
                }
            }
        }

        /// <summary>
        /// EventHandler for when the Text changes on the input textbox.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            this.SelectColumn();
        }

        /// <summary>
        /// Method to reset all of the fonts.
        /// </summary>
        /// <param name="font">The font to set the text boxes to</param>
        private void _SetTextBoxFont(Font font)
        {
            this.textBoxInput.Font = font;
            this.textBoxOutput.Font = font;
        }

        /// <summary>.
        /// Closes the Form
        /// </summary>
        /// <param name="sender">The object that sent this command.</param>
        /// <param name="e">The arguments to this event.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// EventHandler called when the Input Word Wrap Tool strip Menu Item checked property is changed.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void inputWordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxInput.WordWrap = this.inputWordWrapToolStripMenuItem.Checked;
        }

        /// <summary>
        /// EventHandler called when the Output Word Wrap Tool strip Menu Item checked property is changed.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void outputWordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxOutput.WordWrap = this.outputWordWrapToolStripMenuItem.Checked;
        }

        /// <summary>
        /// EventHandler called when the About tool strip menu item is clicked.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog(this);
            }
        }

        /// <summary>
        /// EventHandler called when the Column Options tool strip menu item is clicked.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void columnOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OptionsDialog optionsDialog = new OptionsDialog(this.options))
            {
                ColumnSelectorOptions previousSettings = this.options.Clone();

                if (optionsDialog.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                {
                    this.options = previousSettings;
                }
                else
                {
                    this.SelectColumn();
                }
            }
        }

        /// <summary>
        /// EventHandler called when the Sort Output tool strip menu item check changes.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void sortOutputToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.sortOutputToolStripMenuItem.Checked)
            {
                this.SelectColumn();
            }
        }

        /// <summary>
        /// Invoked when the inputs should be processed.
        /// </summary>
        private void SelectColumn()
        {
            // TODO: If we were using .NET 4.5 this should be async aware.
            // TODO: Business Logic is starting to creep in here, abstract!
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                IEnumerable<string> result;

                if (this.sortOutputToolStripMenuItem.Checked)
                {
                    result = ColumnUtility.GetColumnFromStringSorted(textBoxInput.Text, this.options.ColumnDelimiter, this.options.ColumnToSelect);
                }
                else
                {
                    result = ColumnUtility.GetColumnFromString(textBoxInput.Text, this.options.ColumnDelimiter, this.options.ColumnToSelect);
                }

                if (this.filterOutputDistinctToolStripMenuItem.Checked)
                {
                    result = result.Distinct();
                }

                StringBuilder sb = new StringBuilder();
                foreach (string line in result)
                {
                    sb.AppendLine(line);
                }

                this.textBoxOutput.Text = sb.ToString();
            }
        }

        private void filterOutputDistinctToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: We should probably abstract this out to a common method that can get recalled by any event that needs to reprocess the input.
            // We must reprocess the input
            this.SelectColumn();
        }
    }
}
