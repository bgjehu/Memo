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

namespace Memo3._0_setup
{
    public partial class Installer : Form
    {
        public static int pagenumber=1;
        public Installer()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit Installer", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagenumber++;
            if (pagenumber == 2)
            {
                panel4.Visible = false;
                panel5.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                install();
            }
        }
        private void install()
        {
            Directory.CreateDirectory(@"D:\Program Files\Memo3.0\data");
            Directory.CreateDirectory(@"D:\Program Files\Memo3.0\setting");
            Directory.CreateDirectory(@"D:\Program Files\Memo3.0\bin");
            System.IO.File.WriteAllText(@"D:\Program Files\Memo3.0\setting\pool", 0.ToString());
            System.IO.File.WriteAllBytes(@"D:\Program Files\Memo3.0\bin\Memo3.0.exe", Properties.Resources.Memo3_0_exe);



            

        }


    }
}
