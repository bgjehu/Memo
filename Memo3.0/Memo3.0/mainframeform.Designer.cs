namespace Memo
{
    partial class mainframeform
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
            this.traybaricon = new System.Windows.Forms.NotifyIcon(this.components);
            this.traybariconmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllMemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllMemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllMemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.storememobutton = new System.Windows.Forms.Button();
            this.loadmemobutton = new System.Windows.Forms.Button();
            this.changeMemoColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMemoColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsStartupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.traybariconmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // traybaricon
            // 
            this.traybaricon.ContextMenuStrip = this.traybariconmenu;
            this.traybaricon.Icon = global::Memo.Properties.Resources.traybaricon;
            this.traybaricon.Text = "Memo";
            this.traybaricon.Visible = true;
            this.traybaricon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.traybaricon_MouseDoubleClick);
            // 
            // traybariconmenu
            // 
            this.traybariconmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMemoToolStripMenuItem,
            this.showAllMemosToolStripMenuItem,
            this.closeAllMemosToolStripMenuItem,
            this.deleteAllMemosToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.traybariconmenu.Name = "traybariconmenu";
            this.traybariconmenu.Size = new System.Drawing.Size(180, 180);
            // 
            // addNewMemoToolStripMenuItem
            // 
            this.addNewMemoToolStripMenuItem.Name = "addNewMemoToolStripMenuItem";
            this.addNewMemoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addNewMemoToolStripMenuItem.Text = "Add New Memo";
            this.addNewMemoToolStripMenuItem.Click += new System.EventHandler(this.addNewMemoToolStripMenuItem_Click);
            // 
            // showAllMemosToolStripMenuItem
            // 
            this.showAllMemosToolStripMenuItem.Name = "showAllMemosToolStripMenuItem";
            this.showAllMemosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showAllMemosToolStripMenuItem.Text = "Show All Memos";
            this.showAllMemosToolStripMenuItem.Click += new System.EventHandler(this.showAllMemosToolStripMenuItem_Click);
            // 
            // closeAllMemosToolStripMenuItem
            // 
            this.closeAllMemosToolStripMenuItem.Name = "closeAllMemosToolStripMenuItem";
            this.closeAllMemosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.closeAllMemosToolStripMenuItem.Text = "Close All Memos";
            this.closeAllMemosToolStripMenuItem.Click += new System.EventHandler(this.closeAllMemosToolStripMenuItem_Click);
            // 
            // deleteAllMemosToolStripMenuItem
            // 
            this.deleteAllMemosToolStripMenuItem.Name = "deleteAllMemosToolStripMenuItem";
            this.deleteAllMemosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteAllMemosToolStripMenuItem.Text = "Delete All Memos";
            this.deleteAllMemosToolStripMenuItem.Click += new System.EventHandler(this.deleteAllMemosToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMemoColorToolStripMenuItem1,
            this.windowsStartupToolStripMenuItem1});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // storememobutton
            // 
            this.storememobutton.Enabled = false;
            this.storememobutton.Location = new System.Drawing.Point(13, 226);
            this.storememobutton.Name = "storememobutton";
            this.storememobutton.Size = new System.Drawing.Size(75, 23);
            this.storememobutton.TabIndex = 1;
            this.storememobutton.Text = "store";
            this.storememobutton.UseVisualStyleBackColor = true;
            this.storememobutton.Visible = false;
            this.storememobutton.Click += new System.EventHandler(this.storememobutton_Click);
            // 
            // loadmemobutton
            // 
            this.loadmemobutton.Enabled = false;
            this.loadmemobutton.Location = new System.Drawing.Point(197, 226);
            this.loadmemobutton.Name = "loadmemobutton";
            this.loadmemobutton.Size = new System.Drawing.Size(75, 23);
            this.loadmemobutton.TabIndex = 2;
            this.loadmemobutton.Text = "load";
            this.loadmemobutton.UseVisualStyleBackColor = true;
            this.loadmemobutton.Visible = false;
            this.loadmemobutton.Click += new System.EventHandler(this.loadmemobutton_Click);
            // 
            // changeMemoColorToolStripMenuItem
            // 
            this.changeMemoColorToolStripMenuItem.Name = "changeMemoColorToolStripMenuItem";
            this.changeMemoColorToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.changeMemoColorToolStripMenuItem.Text = "Change Memo Color";
            // 
            // windowsStartupToolStripMenuItem
            // 
            this.windowsStartupToolStripMenuItem.Name = "windowsStartupToolStripMenuItem";
            this.windowsStartupToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.windowsStartupToolStripMenuItem.Text = "Windows Startup";
            // 
            // changeMemoColorToolStripMenuItem1
            // 
            this.changeMemoColorToolStripMenuItem1.Name = "changeMemoColorToolStripMenuItem1";
            this.changeMemoColorToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.changeMemoColorToolStripMenuItem1.Text = "Change Memo Color";
            this.changeMemoColorToolStripMenuItem1.Click += new System.EventHandler(this.changeMemoColorToolStripMenuItem1_Click);
            // 
            // windowsStartupToolStripMenuItem1
            // 
            this.windowsStartupToolStripMenuItem1.Checked = true;
            this.windowsStartupToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windowsStartupToolStripMenuItem1.Name = "windowsStartupToolStripMenuItem1";
            this.windowsStartupToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.windowsStartupToolStripMenuItem1.Text = "Windows Startup";
            this.windowsStartupToolStripMenuItem1.Click += new System.EventHandler(this.windowsStartupToolStripMenuItem1_Click);
            this.windowsStartupToolStripMenuItem1.Checked = GlobalVar.startup;
            
            // 
            // mainframeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loadmemobutton);
            this.Controls.Add(this.storememobutton);
            this.Name = "mainframeform";
            this.ShowInTaskbar = false;
            this.Text = "mainframeform";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainframeform_FormClosing);
            this.traybariconmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon traybaricon;
        private System.Windows.Forms.ContextMenuStrip traybariconmenu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem addNewMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllMemosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllMemosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllMemosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button storememobutton;
        private System.Windows.Forms.Button loadmemobutton;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMemoColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMemoColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowsStartupToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}