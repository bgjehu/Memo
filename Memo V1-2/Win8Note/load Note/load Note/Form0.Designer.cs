namespace load_Note
{
    partial class Form0
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAllNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = global::load_Note.Properties.Resources.memo;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllNotesToolStripMenuItem,
            this.hideAllNotesToolStripMenuItem,
            this.addNewNoteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 92);
            // 
            // showAllNotesToolStripMenuItem
            // 
            this.showAllNotesToolStripMenuItem.Name = "showAllNotesToolStripMenuItem";
            this.showAllNotesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showAllNotesToolStripMenuItem.Text = "Show All Notes";
            this.showAllNotesToolStripMenuItem.Click += new System.EventHandler(this.showAllNotesToolStripMenuItem_Click);
            // 
            // hideAllNotesToolStripMenuItem
            // 
            this.hideAllNotesToolStripMenuItem.Name = "hideAllNotesToolStripMenuItem";
            this.hideAllNotesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hideAllNotesToolStripMenuItem.Text = "Hide All Notes";
            this.hideAllNotesToolStripMenuItem.Click += new System.EventHandler(this.hideAllNotesToolStripMenuItem_Click);
            // 
            // addNewNoteToolStripMenuItem
            // 
            this.addNewNoteToolStripMenuItem.Name = "addNewNoteToolStripMenuItem";
            this.addNewNoteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addNewNoteToolStripMenuItem.Text = "Add New Note";
            this.addNewNoteToolStripMenuItem.Click += new System.EventHandler(this.addNewNoteToolStripMenuItem_Click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form0";
            this.ShowInTaskbar = false;
            this.Text = "Form0";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAllNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewNoteToolStripMenuItem;
    }
}