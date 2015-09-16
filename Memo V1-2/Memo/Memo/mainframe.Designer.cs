namespace Memo
{
    partial class mainframe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainframe));
            this.traybaricon = new System.Windows.Forms.NotifyIcon(this.components);
            this.traybariconmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAllMemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllMemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllMemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.traybariconmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // traybaricon
            // 
            this.traybaricon.ContextMenuStrip = this.traybariconmenu;
            this.traybaricon.Icon = ((System.Drawing.Icon)(resources.GetObject("traybaricon.Icon")));
            this.traybaricon.Text = "Memo";
            this.traybaricon.Visible = true;
            this.traybaricon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.traybaricon_MouseDoubleClick);
            // 
            // traybariconmenu
            // 
            this.traybariconmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllMemosToolStripMenuItem,
            this.hideAllMemosToolStripMenuItem,
            this.clearAllMemosToolStripMenuItem,
            this.addNewMemoToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.traybariconmenu.Name = "traybariconmenu";
            this.traybariconmenu.Size = new System.Drawing.Size(174, 136);
            // 
            // showAllMemosToolStripMenuItem
            // 
            this.showAllMemosToolStripMenuItem.Name = "showAllMemosToolStripMenuItem";
            this.showAllMemosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showAllMemosToolStripMenuItem.Text = "Show All Memos";
            this.showAllMemosToolStripMenuItem.Click += new System.EventHandler(this.showAllMemosToolStripMenuItem_Click);
            // 
            // hideAllMemosToolStripMenuItem
            // 
            this.hideAllMemosToolStripMenuItem.Name = "hideAllMemosToolStripMenuItem";
            this.hideAllMemosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.hideAllMemosToolStripMenuItem.Text = "Hide All Memos";
            this.hideAllMemosToolStripMenuItem.Click += new System.EventHandler(this.hideAllMemosToolStripMenuItem_Click);
            // 
            // clearAllMemosToolStripMenuItem
            // 
            this.clearAllMemosToolStripMenuItem.Name = "clearAllMemosToolStripMenuItem";
            this.clearAllMemosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearAllMemosToolStripMenuItem.Text = "Clear All Memos";
            this.clearAllMemosToolStripMenuItem.Click += new System.EventHandler(this.clearAllMemosToolStripMenuItem_Click);
            // 
            // addNewMemoToolStripMenuItem
            // 
            this.addNewMemoToolStripMenuItem.Name = "addNewMemoToolStripMenuItem";
            this.addNewMemoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addNewMemoToolStripMenuItem.Text = "Add New Memo";
            this.addNewMemoToolStripMenuItem.Click += new System.EventHandler(this.addNewMemoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "mainframe";
            this.ShowInTaskbar = false;
            this.Text = "mainframe";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.traybariconmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon traybaricon;
        private System.Windows.Forms.ContextMenuStrip traybariconmenu;
        private System.Windows.Forms.ToolStripMenuItem showAllMemosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllMemosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllMemosToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
    }
}