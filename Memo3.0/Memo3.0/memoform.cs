using System;
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
    public partial class memoform : Form
    {
        private System.Drawing.Point MouseDownLocation;
        public bool isMemoDeleted=true;
        mainframeform parent;
        Bitmap close = Properties.Resources.closeicon_x;
        public memoform()
        {
            isMemoDeleted = false;
            InitializeComponent();
            //MessageBox.Show(GlobalVar.startup.ToString());
            changememocolor();
        }

        public memoform(mainframeform m)
        {
            parent = m;
            isMemoDeleted = false;
            InitializeComponent();
            //MessageBox.Show(GlobalVar.startup.ToString());
            changememocolor();
        }


        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            isMemoDeleted = true;
            textBox.Text = string.Empty;
            this.Hide();
        }

        //Boardless Form
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on WS_EX_TOOLWINDOW style bit
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
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
        //private void textbox_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //    {
        //        MouseDownLocation = e.Location;
        //    }

        //}
        //private void textbox_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //    {
        //        this.Left = e.X + this.Left - MouseDownLocation.X;
        //        this.Top = e.Y + this.Top - MouseDownLocation.Y;
        //    }
        //}

        private void draggablepanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void draggablepanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }



        private void memoform_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void changememocolor()
        {
            panel.BackColor = GlobalVar.memocolor;
            textBox.BackColor = GlobalVar.memocolor;
            
            draggablepanel.BackColor = Color.FromArgb(textBox.BackColor.ToArgb() ^ 0x00005f);
            deletebutton.BackColor = Color.FromArgb(textBox.BackColor.ToArgb() ^ 0x00005f);
            closebutton.BackColor = Color.FromArgb(textBox.BackColor.ToArgb() ^ 0x00005f);
            for (int i = 0; i < close.Width; i++)
            {
                for (int j = 0; j < close.Height; j++)
                {
                    close.SetPixel(i, j, Color.FromArgb(textBox.BackColor.ToArgb() ^ close.GetPixel(i,j).ToArgb()));
                }
            }
            closebutton.BackgroundImage = close;
            textBox.ForeColor = Color.FromArgb(textBox.BackColor.ToArgb() ^ 0xffffff);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
            this.Cursor = Cursors.SizeNWSE;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int dx = e.X - MouseDownLocation.X;
                
                if (this.panel.Width + dx < 200)
                {
                    
                }
                else if (this.panel.Width + dx > 1600)
                {
                    
                }
                else
                {
                    this.Width += dx;
                    this.pictureBox1.Left += dx;
                    this.draggablepanel.Width += dx;
                    this.closebutton.Left += dx;
                    this.deletebutton.Left += dx;
                    this.textBox.Width += dx;
                }

                int dy = e.Y - MouseDownLocation.Y;
                if (this.panel.Height + dy < 200)
                {
                    
                }
                else if (this.panel.Height + dy > 900)
                {
                    
                }
                else
                {
                    this.Height += dy;
                    this.pictureBox1.Top += dy;
                    this.textBox.Height += dy;
                } 
            }  
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        
        

    }
}
