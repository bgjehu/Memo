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

namespace Memo
{
    public partial class Memo : Form
    {
        //Variables
        private System.Drawing.Point MouseDownLocation;
        public int index;
        bool isPathUsed = false;
        string path;

        public Memo(int i,bool b)
        {
            InitializeComponent();
            index = i;
            path = string.Format(@"D:\Program Files\Memo\Data\{0}.txt", index.ToString("00000"));
            if (!b) { loaddata(); }
            else { storedata(); }
        }

        public Memo()
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

        //Dragable textbox
        private void textbox_MouseDown(object sender, MouseEventArgs e)
        {
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

       

        private void Memo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        

        public void storedata()
        {
            File.WriteAllText(path, textBox.Text);
        }
        public void loaddata()
        {
            isPathUsed = true;
            using (StreamReader sr = new StreamReader(path))
            { textBox.Text = sr.ReadToEnd(); }
            isPathUsed = false; ;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!isPathUsed) { storedata(); }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        


    }
}
