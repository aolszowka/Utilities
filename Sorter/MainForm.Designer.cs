namespace Sorter
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
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.splitContainerMainForm = new System.Windows.Forms.SplitContainer();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.distinctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).BeginInit();
            this.splitContainerMainForm.Panel1.SuspendLayout();
            this.splitContainerMainForm.Panel2.SuspendLayout();
            this.splitContainerMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 470);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(602, 22);
            this.statusStripMainForm.TabIndex = 0;
            this.statusStripMainForm.Text = "statusStrip1";
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(602, 24);
            this.menuStripMainForm.TabIndex = 1;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // splitContainerMainForm
            // 
            this.splitContainerMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainForm.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMainForm.Name = "splitContainerMainForm";
            this.splitContainerMainForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainForm.Panel1
            // 
            this.splitContainerMainForm.Panel1.Controls.Add(this.textBoxInput);
            // 
            // splitContainerMainForm.Panel2
            // 
            this.splitContainerMainForm.Panel2.Controls.Add(this.textBoxOutput);
            this.splitContainerMainForm.Size = new System.Drawing.Size(602, 446);
            this.splitContainerMainForm.SplitterDistance = 223;
            this.splitContainerMainForm.TabIndex = 2;
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
            this.descendingToolStripMenuItem,
            this.distinctToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.CheckOnClick = true;
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descendingToolStripMenuItem.Text = "&Descending";
            this.descendingToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnInputsChanged);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(0, 0);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(602, 223);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "Input";
            this.textBoxInput.WordWrap = false;
            this.textBoxInput.TextChanged += new System.EventHandler(this.OnInputsChanged);
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(602, 219);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.Text = "Output";
            this.textBoxOutput.WordWrap = false;
            this.textBoxOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessHotkeys);
            // 
            // distinctToolStripMenuItem
            // 
            this.distinctToolStripMenuItem.CheckOnClick = true;
            this.distinctToolStripMenuItem.Name = "distinctToolStripMenuItem";
            this.distinctToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.distinctToolStripMenuItem.Text = "Distinc&t";
            this.distinctToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnInputsChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 492);
            this.Controls.Add(this.splitContainerMainForm);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.menuStripMainForm);
            this.MainMenuStrip = this.menuStripMainForm;
            this.Name = "MainForm";
            this.Text = "Sorter";
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.splitContainerMainForm.Panel1.ResumeLayout(false);
            this.splitContainerMainForm.Panel1.PerformLayout();
            this.splitContainerMainForm.Panel2.ResumeLayout(false);
            this.splitContainerMainForm.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).EndInit();
            this.splitContainerMainForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.SplitContainer splitContainerMainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.ToolStripMenuItem distinctToolStripMenuItem;
    }
}

