namespace ColumnSelector
{
    partial class OptionsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelColumnToSelect = new System.Windows.Forms.Label();
            this.textBoxColumnToSelect = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutButtons, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelColumnToSelect, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxColumnToSelect, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(284, 98);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutButtons
            // 
            this.tableLayoutButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutButtons.AutoSize = true;
            this.tableLayoutButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutButtons.ColumnCount = 2;
            this.tableLayoutPanelMain.SetColumnSpan(this.tableLayoutButtons, 2);
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutButtons.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutButtons.Controls.Add(this.buttonOk, 0, 0);
            this.tableLayoutButtons.Location = new System.Drawing.Point(119, 66);
            this.tableLayoutButtons.Name = "tableLayoutButtons";
            this.tableLayoutButtons.RowCount = 1;
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutButtons.Size = new System.Drawing.Size(162, 29);
            this.tableLayoutButtons.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(84, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(3, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelColumnToSelect
            // 
            this.labelColumnToSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelColumnToSelect.AutoSize = true;
            this.labelColumnToSelect.Location = new System.Drawing.Point(3, 6);
            this.labelColumnToSelect.Name = "labelColumnToSelect";
            this.labelColumnToSelect.Size = new System.Drawing.Size(91, 13);
            this.labelColumnToSelect.TabIndex = 1;
            this.labelColumnToSelect.Text = "Column To Select";
            // 
            // textBoxColumnToSelect
            // 
            this.textBoxColumnToSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumnToSelect.Location = new System.Drawing.Point(100, 3);
            this.textBoxColumnToSelect.Name = "textBoxColumnToSelect";
            this.textBoxColumnToSelect.Size = new System.Drawing.Size(181, 20);
            this.textBoxColumnToSelect.TabIndex = 2;
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsDialog";
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.Activated += new System.EventHandler(this.OptionsDialog_Activated);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelColumnToSelect;
        private System.Windows.Forms.TextBox textBoxColumnToSelect;
    }
}