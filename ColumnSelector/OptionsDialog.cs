// -----------------------------------------------------------------------
// <copyright file="OptionsDialog.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ColumnSelector
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The Options Dialog.
    /// </summary>
    public partial class OptionsDialog : Form
    {
        /// <summary>
        /// The <see cref="ColumnSelectorOptions"/> that this dialog manipulates.
        /// </summary>
        private ColumnSelectorOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsDialog"/> class.
        /// </summary>
        /// <remarks>This should only be called via the designer.</remarks>
        public OptionsDialog()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsDialog"/> class.
        /// </summary>
        /// <param name="options">The <see cref="ColumnSelectorOptions"/> associated with this dialog.</param>
        public OptionsDialog(ColumnSelectorOptions options)
        {
            this.InitializeComponent();
            this.options = options;
            this.textBoxColumnToSelect.DataBindings.Add("Text", this.options, "ColumnToSelect");
        }

        /// <summary>
        /// EventHandler for the OK Button Click.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// EventHandler for the Cancel Button Click.
        /// </summary>
        /// <param name="sender">The object that raised this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
