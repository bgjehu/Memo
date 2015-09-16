namespace Memo4._0_installer
{
    partial class installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(installer));
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.panel_page0 = new System.Windows.Forms.Panel();
            this.label_page0_1 = new System.Windows.Forms.Label();
            this.label_page0_0 = new System.Windows.Forms.Label();
            this.panel_page1 = new System.Windows.Forms.Panel();
            this.label_page1_0 = new System.Windows.Forms.Label();
            this.checkBox_shortcut = new System.Windows.Forms.CheckBox();
            this.checkBox_startup = new System.Windows.Forms.CheckBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.textBox_path_applocation = new System.Windows.Forms.TextBox();
            this.panel_page2 = new System.Windows.Forms.Panel();
            this.label_install = new System.Windows.Forms.Label();
            this.progressBar_install = new System.Windows.Forms.ProgressBar();
            this.panel_page3 = new System.Windows.Forms.Panel();
            this.checkBox_runapp = new System.Windows.Forms.CheckBox();
            this.label_installed = new System.Windows.Forms.Label();
            this.folderBrowserDialog_installpathselect = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_button.SuspendLayout();
            this.panel_page0.SuspendLayout();
            this.panel_page1.SuspendLayout();
            this.panel_page2.SuspendLayout();
            this.panel_page3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.button_back);
            this.panel_button.Controls.Add(this.button_cancel);
            this.panel_button.Controls.Add(this.button_next);
            this.panel_button.Location = new System.Drawing.Point(0, 300);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(555, 50);
            this.panel_button.TabIndex = 2;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(286, 15);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(468, 15);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(377, 15);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 0;
            this.button_next.Text = "Next >";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // panel_picture
            // 
            this.panel_picture.BackColor = System.Drawing.Color.White;
            this.panel_picture.BackgroundImage = global::Memo4._0_installer.Properties.Resources.installer_pic_01;
            this.panel_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_picture.Location = new System.Drawing.Point(0, 0);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(180, 300);
            this.panel_picture.TabIndex = 0;
            // 
            // panel_page0
            // 
            this.panel_page0.BackColor = System.Drawing.Color.White;
            this.panel_page0.Controls.Add(this.label_page0_1);
            this.panel_page0.Controls.Add(this.label_page0_0);
            this.panel_page0.Location = new System.Drawing.Point(180, 0);
            this.panel_page0.Name = "panel_page0";
            this.panel_page0.Size = new System.Drawing.Size(375, 300);
            this.panel_page0.TabIndex = 3;
            this.panel_page0.Visible = false;
            // 
            // label_page0_1
            // 
            this.label_page0_1.AutoSize = true;
            this.label_page0_1.Location = new System.Drawing.Point(16, 52);
            this.label_page0_1.Name = "label_page0_1";
            this.label_page0_1.Size = new System.Drawing.Size(347, 84);
            this.label_page0_1.TabIndex = 1;
            this.label_page0_1.Text = resources.GetString("label_page0_1.Text");
            // 
            // label_page0_0
            // 
            this.label_page0_0.AutoSize = true;
            this.label_page0_0.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_page0_0.Location = new System.Drawing.Point(16, 22);
            this.label_page0_0.Name = "label_page0_0";
            this.label_page0_0.Size = new System.Drawing.Size(240, 16);
            this.label_page0_0.TabIndex = 0;
            this.label_page0_0.Text = "Welcome to Memo 4.0 installer";
            // 
            // panel_page1
            // 
            this.panel_page1.BackColor = System.Drawing.Color.White;
            this.panel_page1.Controls.Add(this.label_page1_0);
            this.panel_page1.Controls.Add(this.checkBox_shortcut);
            this.panel_page1.Controls.Add(this.checkBox_startup);
            this.panel_page1.Controls.Add(this.button_browse);
            this.panel_page1.Controls.Add(this.textBox_path_applocation);
            this.panel_page1.Location = new System.Drawing.Point(180, 0);
            this.panel_page1.Name = "panel_page1";
            this.panel_page1.Size = new System.Drawing.Size(375, 300);
            this.panel_page1.TabIndex = 4;
            // 
            // label_page1_0
            // 
            this.label_page1_0.AutoSize = true;
            this.label_page1_0.Location = new System.Drawing.Point(16, 22);
            this.label_page1_0.Name = "label_page1_0";
            this.label_page1_0.Size = new System.Drawing.Size(263, 72);
            this.label_page1_0.TabIndex = 5;
            this.label_page1_0.Text = "The installer will install Memo 4.0 to the \r\nfollowing folder.\r\n\r\nTo install in t" +
    "his folder, click Next. To \r\ninstall to a different folder, enter it \r\nbelow or " +
    "click Browse.";
            // 
            // checkBox_shortcut
            // 
            this.checkBox_shortcut.AutoSize = true;
            this.checkBox_shortcut.Location = new System.Drawing.Point(16, 163);
            this.checkBox_shortcut.Name = "checkBox_shortcut";
            this.checkBox_shortcut.Size = new System.Drawing.Size(180, 16);
            this.checkBox_shortcut.TabIndex = 4;
            this.checkBox_shortcut.Text = "Create shortcut on Desktop";
            this.checkBox_shortcut.UseVisualStyleBackColor = true;
            // 
            // checkBox_startup
            // 
            this.checkBox_startup.AutoSize = true;
            this.checkBox_startup.Location = new System.Drawing.Point(16, 147);
            this.checkBox_startup.Name = "checkBox_startup";
            this.checkBox_startup.Size = new System.Drawing.Size(300, 16);
            this.checkBox_startup.TabIndex = 3;
            this.checkBox_startup.Text = "Run Memo 4.0 automatically when Windows starts";
            this.checkBox_startup.UseVisualStyleBackColor = true;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(282, 109);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 1;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // textBox_path_applocation
            // 
            this.textBox_path_applocation.Location = new System.Drawing.Point(16, 110);
            this.textBox_path_applocation.Name = "textBox_path_applocation";
            this.textBox_path_applocation.Size = new System.Drawing.Size(255, 21);
            this.textBox_path_applocation.TabIndex = 0;
            this.textBox_path_applocation.Text = "C:\\Program Files\\Memo";
            // 
            // panel_page2
            // 
            this.panel_page2.BackColor = System.Drawing.Color.White;
            this.panel_page2.Controls.Add(this.label_install);
            this.panel_page2.Controls.Add(this.progressBar_install);
            this.panel_page2.Location = new System.Drawing.Point(180, 0);
            this.panel_page2.Name = "panel_page2";
            this.panel_page2.Size = new System.Drawing.Size(375, 300);
            this.panel_page2.TabIndex = 5;
            this.panel_page2.Visible = false;
            // 
            // label_install
            // 
            this.label_install.AutoSize = true;
            this.label_install.Location = new System.Drawing.Point(16, 22);
            this.label_install.Name = "label_install";
            this.label_install.Size = new System.Drawing.Size(41, 12);
            this.label_install.TabIndex = 1;
            this.label_install.Text = "label1";
            // 
            // progressBar_install
            // 
            this.progressBar_install.Location = new System.Drawing.Point(16, 42);
            this.progressBar_install.Name = "progressBar_install";
            this.progressBar_install.Size = new System.Drawing.Size(322, 31);
            this.progressBar_install.Step = 1;
            this.progressBar_install.TabIndex = 0;
            // 
            // panel_page3
            // 
            this.panel_page3.BackColor = System.Drawing.Color.White;
            this.panel_page3.Controls.Add(this.checkBox_runapp);
            this.panel_page3.Controls.Add(this.label_installed);
            this.panel_page3.Location = new System.Drawing.Point(180, 0);
            this.panel_page3.Name = "panel_page3";
            this.panel_page3.Size = new System.Drawing.Size(375, 300);
            this.panel_page3.TabIndex = 6;
            this.panel_page3.Visible = false;
            // 
            // checkBox_runapp
            // 
            this.checkBox_runapp.AutoSize = true;
            this.checkBox_runapp.Location = new System.Drawing.Point(19, 52);
            this.checkBox_runapp.Name = "checkBox_runapp";
            this.checkBox_runapp.Size = new System.Drawing.Size(246, 16);
            this.checkBox_runapp.TabIndex = 4;
            this.checkBox_runapp.Text = "Run Memo after finishing installation";
            this.checkBox_runapp.UseVisualStyleBackColor = true;
            // 
            // label_installed
            // 
            this.label_installed.AutoSize = true;
            this.label_installed.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_installed.Location = new System.Drawing.Point(16, 22);
            this.label_installed.Name = "label_installed";
            this.label_installed.Size = new System.Drawing.Size(232, 16);
            this.label_installed.TabIndex = 3;
            this.label_installed.Text = "Thank you for using Memo 4.0";
            this.label_installed.Visible = false;
            // 
            // installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 350);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_picture);
            this.Controls.Add(this.panel_page3);
            this.Controls.Add(this.panel_page2);
            this.Controls.Add(this.panel_page1);
            this.Controls.Add(this.panel_page0);
            this.Icon = global::Memo4._0_installer.Properties.Resources.setup;
            this.Name = "installer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "installer";
            this.panel_button.ResumeLayout(false);
            this.panel_page0.ResumeLayout(false);
            this.panel_page0.PerformLayout();
            this.panel_page1.ResumeLayout(false);
            this.panel_page1.PerformLayout();
            this.panel_page2.ResumeLayout(false);
            this.panel_page2.PerformLayout();
            this.panel_page3.ResumeLayout(false);
            this.panel_page3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Panel panel_page0;
        private System.Windows.Forms.Panel panel_page1;
        private System.Windows.Forms.Panel panel_page2;
        private System.Windows.Forms.Panel panel_page3;
        private System.Windows.Forms.TextBox textBox_path_applocation;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_installpathselect;
        private System.Windows.Forms.CheckBox checkBox_shortcut;
        private System.Windows.Forms.CheckBox checkBox_startup;
        private System.Windows.Forms.ProgressBar progressBar_install;
        private System.Windows.Forms.Label label_install;
        private System.Windows.Forms.Label label_page0_1;
        private System.Windows.Forms.Label label_page0_0;
        private System.Windows.Forms.Label label_page1_0;
        private System.Windows.Forms.CheckBox checkBox_runapp;
        private System.Windows.Forms.Label label_installed;
    }
}

