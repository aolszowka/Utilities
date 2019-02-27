// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014-2019. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Sorter
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    ///     The Main Form for a Toy program that eases the sorting and
    /// filtering of a list of strings.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Stores the Distinct Filter State
        /// </summary>
        DistinctOptions distinctOptionsState = DistinctOptions.None;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            UpdateDistinctOptionsState();
        }

        /// <summary>
        /// EventHandler for when the Exit Item is invoked.
        /// </summary>
        /// <param name="sender">The object that invoked the ProcessHotkeys EventHandler.</param>
        /// <param name="e">The EventArgs from that control.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// EventHander for when the Input TextBoxes Change.
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void OnInputsChanged(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "Processing...";

            string output =
                SorterLogic.SortInput(
                this.textBoxInput.Text,
                this.descendingToolStripMenuItem.Checked,
                distinctOptionsState);

            // Set our text
            this.textBoxOutput.Text = output;
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
                RichTextBox textBoxControl = sender as RichTextBox;
                if (textBoxControl != null)
                {
                    textBoxControl.SelectAll();
                }
            }
        }

        /// <summary>
        /// Called whenever one of the Distinct Checkboxes change state.
        /// </summary>
        private void UpdateDistinctOptionsState()
        {
            // Reset all of the check boxes prior to setting them correctly
            this.distinctNoneToolStripMenuItem.Checked = false;
            this.distinctCaseSensitiveToolStripMenuItem.Checked = false;
            this.distinctCaseInsensitiveToolStripMenuItem.Checked = false;

            switch (distinctOptionsState)
            {
                case DistinctOptions.None:
                    {
                        this.distinctNoneToolStripMenuItem.Checked = true;
                        break;
                    }
                case DistinctOptions.CaseSensitive:
                    {
                        this.distinctCaseSensitiveToolStripMenuItem.Checked = true;
                        break;
                    }
                case DistinctOptions.CaseInsensitive:
                    {
                        this.distinctCaseInsensitiveToolStripMenuItem.Checked = true;
                        break;
                    }
                default:
                    {
                        string exception = $"The {nameof(DistinctOptions)} enumerable changed but this code was not updated.";
                        throw new InvalidOperationException(exception);
                    }
            }

            OnInputsChanged(this, new EventArgs());
        }

        /// <summary>
        /// Invoked when Distinct is set to None
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void distinctNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            distinctOptionsState = DistinctOptions.None;
            UpdateDistinctOptionsState();
        }

        /// <summary>
        /// Invoked when Distinct is set to Case Sensitive
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void distinctCaseSensitiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            distinctOptionsState = DistinctOptions.CaseSensitive;
            UpdateDistinctOptionsState();
        }

        /// <summary>
        /// Invoked when Distinct is set to Case Insensitive
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void distinctCaseInsensitiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            distinctOptionsState = DistinctOptions.CaseInsensitive;
            UpdateDistinctOptionsState();
        }
    }
}
