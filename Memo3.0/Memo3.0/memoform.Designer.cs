namespace Memo
{
    partial class memoform
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
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.draggablepanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.draggablepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.PaleGreen;
            this.closebutton.BackgroundImage = global::Memo.Properties.Resources.closeicon;
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebutton.Location = new System.Drawing.Point(244, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(25, 25);
            this.closebutton.TabIndex = 2;
            this.closebutton.TabStop = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.PaleGreen;
            this.deletebutton.BackgroundImage = global::Memo.Properties.Resources.deletebuttonV2;
            this.deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebutton.Location = new System.Drawing.Point(275, 0);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(25, 25);
            this.deletebutton.TabIndex = 0;
            this.deletebutton.TabStop = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(0, 25);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(300, 275);
            this.textBox.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PaleGreen;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.draggablepanel);
            this.panel.Controls.Add(this.textBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 301);
            this.panel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(275, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // draggablepanel
            // 
            this.draggablepanel.Controls.Add(this.closebutton);
            this.draggablepanel.Controls.Add(this.deletebutton);
            this.draggablepanel.Location = new System.Drawing.Point(0, 0);
            this.draggablepanel.Name = "draggablepanel";
            this.draggablepanel.Size = new System.Drawing.Size(300, 25);
            this.draggablepanel.TabIndex = 4;
            this.draggablepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draggablepanel_MouseDown);
            this.draggablepanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draggablepanel_MouseMove);
            // 
            // memoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 301);
            this.Controls.Add(this.panel);
            this.Name = "memoform";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "memoform";
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.draggablepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closebutton;
        private System.Windows.Forms.PictureBox deletebutton;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel draggablepanel;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}