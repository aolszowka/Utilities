namespace ColumnSelector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterOutputDistinctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputWordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputWordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 27);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.textBoxInput);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.textBoxOutput);
            this.mainSplitContainer.Size = new System.Drawing.Size(771, 429);
            this.mainSplitContainer.SplitterDistance = 385;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(0, 0);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(385, 429);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "Input";
            this.textBoxInput.WordWrap = false;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(382, 429);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.Text = "Output";
            this.textBoxOutput.WordWrap = false;
            this.textBoxOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortOutputToolStripMenuItem,
            this.filterOutputDistinctToolStripMenuItem,
            this.columnOptionsToolStripMenuItem,
            this.inputDialogToolStripMenuItem,
            this.outputDialogToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // sortOutputToolStripMenuItem
            // 
            this.sortOutputToolStripMenuItem.CheckOnClick = true;
            this.sortOutputToolStripMenuItem.Name = "sortOutputToolStripMenuItem";
            this.sortOutputToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sortOutputToolStripMenuItem.Text = "&Sort Output";
            this.sortOutputToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sortOutputToolStripMenuItem_CheckedChanged);
            // 
            // filterOutputDistinctToolStripMenuItem
            // 
            this.filterOutputDistinctToolStripMenuItem.CheckOnClick = true;
            this.filterOutputDistinctToolStripMenuItem.Name = "filterOutputDistinctToolStripMenuItem";
            this.filterOutputDistinctToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.filterOutputDistinctToolStripMenuItem.Text = "Filter Output &Distinct";
            this.filterOutputDistinctToolStripMenuItem.CheckedChanged += new System.EventHandler(this.filterOutputDistinctToolStripMenuItem_CheckedChanged);
            // 
            // columnOptionsToolStripMenuItem
            // 
            this.columnOptionsToolStripMenuItem.Name = "columnOptionsToolStripMenuItem";
            this.columnOptionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.columnOptionsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.columnOptionsToolStripMenuItem.Text = "&Column Options";
            this.columnOptionsToolStripMenuItem.Click += new System.EventHandler(this.columnOptionsToolStripMenuItem_Click);
            // 
            // inputDialogToolStripMenuItem
            // 
            this.inputDialogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputWordWrapToolStripMenuItem});
            this.inputDialogToolStripMenuItem.Name = "inputDialogToolStripMenuItem";
            this.inputDialogToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.inputDialogToolStripMenuItem.Text = "&Input Dialog";
            // 
            // inputWordWrapToolStripMenuItem
            // 
            this.inputWordWrapToolStripMenuItem.CheckOnClick = true;
            this.inputWordWrapToolStripMenuItem.Name = "inputWordWrapToolStripMenuItem";
            this.inputWordWrapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inputWordWrapToolStripMenuItem.Text = "Word &Wrap";
            this.inputWordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.inputWordWrapToolStripMenuItem_CheckedChanged);
            // 
            // outputDialogToolStripMenuItem
            // 
            this.outputDialogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputWordWrapToolStripMenuItem});
            this.outputDialogToolStripMenuItem.Name = "outputDialogToolStripMenuItem";
            this.outputDialogToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.outputDialogToolStripMenuItem.Text = "&Output Dialog";
            // 
            // outputWordWrapToolStripMenuItem
            // 
            this.outputWordWrapToolStripMenuItem.CheckOnClick = true;
            this.outputWordWrapToolStripMenuItem.Name = "outputWordWrapToolStripMenuItem";
            this.outputWordWrapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputWordWrapToolStripMenuItem.Text = "Word &Wrap";
            this.outputWordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.outputWordWrapToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Column Selector";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputWordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputWordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterOutputDistinctToolStripMenuItem;
    }
}

