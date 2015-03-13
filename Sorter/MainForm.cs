// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    ///     The Main Form for a Toy program that eases the sorting and
    /// filtering of a list of strings.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Given an "Input String" that is delimited by newline characters
        /// </summary>
        /// <param name="inputString">The "Input String" as described below.</param>
        /// <param name="sortDescending">Indicates that the result should be returned in descending order.</param>
        /// <param name="distinctInputs">Indicates that the result should only include the distinct elements.</param>
        /// <returns>An "Output String" that is delimited by newline characters.</returns>
        /// <remarks>
        ///     The "Input String" and "Output String" are just a plain old
        /// string that stores several inputs, delimited by a newline.
        /// </remarks>
        private static string _SortInput(string inputString, bool sortDescending, bool distinctInputs)
        {
            // TODO: This method needs to be re-factored and abstracted into its own library!

            // Parse the Input String
            IEnumerable<string> inputs = _ParseInputString(inputString);

            // Perform the Actual Sorting/Distinct
            IEnumerable<string> outputs = _SortInput(inputs, sortDescending, distinctInputs);

            // Rebuild the output string
            StringBuilder sb = new StringBuilder();
            foreach (string output in outputs)
            {
                sb.AppendLine(output);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Given an Enumerable of strings, filter them according to the arguments.
        /// </summary>
        /// <param name="inputs">The input to filter.</param>
        /// <param name="sortDescending">Indicates that the result should be returned in descending order.</param>
        /// <param name="distinctInputs">Indicates that the result should only include the distinct elements.</param>
        /// <returns>An Enumerable that is filtered according to the arguments.</returns>
        private static IEnumerable<string> _SortInput(IEnumerable<string> inputs, bool sortDescending, bool distinctInputs)
        {
            IEnumerable<string> outputs = inputs;

            // Determine if we should only return distinct
            if (distinctInputs)
            {
                outputs = outputs.Distinct();
            }

            // Sort the inputs
            if (sortDescending)
            {
                outputs = outputs.OrderByDescending(input => input);
            }
            else
            {
                outputs = outputs.OrderBy(input => input);
            }

            return outputs;
        }

        /// <summary>
        /// Parses the "Input String" as defined below and then delineates it to a IEnumerable of strings.
        /// </summary>
        /// <param name="inputString">The "Input String" to parse.</param>
        /// <returns>An Enumerable that represent the Inputs.</returns>
        /// <remarks>
        ///     The "Input String" is just a plain old string that stores
        /// several inputs, delimited by a newline.
        /// </remarks>
        private static IEnumerable<string> _ParseInputString(string inputString)
        {
            return
                inputString.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
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
                _SortInput(
                this.textBoxInput.Text,
                this.descendingToolStripMenuItem.Checked,
                this.distinctToolStripMenuItem.Checked);

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
                TextBox textBoxControl = sender as TextBox;
                if (textBoxControl != null)
                {
                    textBoxControl.SelectAll();
                }
            }
        }
    }
}
