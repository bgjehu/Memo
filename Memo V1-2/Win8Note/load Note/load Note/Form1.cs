using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace load_Note
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }
        //Boardless Form
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        //Boardless Form[END]

        //Drag
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        //Drag[END]


        //Variables
        private System.Drawing.Point MouseDownLocation;
        string path;
        bool usingpath = true;
        int count = 0;


        //Dragable Panel
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            panel.Cursor = Cursors.SizeAll;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
        //Dragable textbox
        private void textbox_MouseDown(object sender, MouseEventArgs e)
        {
            panel.Cursor = Cursors.SizeAll;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }

        }
        private void textbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        

        private void Note_Load(object sender, EventArgs e)
        {
            path = string.Format(@"D:\Program Files\Win8Note\Notes\{0}.txt", GlobalVar.count.ToString("00000"));
            using (StreamReader sr = new StreamReader(path))
            { textBox.Text = sr.ReadToEnd(); }
            usingpath = false;
            
            
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!usingpath) { File.WriteAllText(path, textBox.Text); }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }
}
