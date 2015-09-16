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
    public partial class mainframe : Form
    {
        //Variables
        Memo[] Memos;

        public mainframe()
        {
            InitializeComponent();
            setupmemo();
            showmemo();
        }
        //Boardless Form---------------------------
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        //-----------------------------------------
        

        
        //Functions
        //filetototal
        private void filetototal()
        {
            string tmp;
            GlobalVar.total = 0;
            using (StreamReader sr = new StreamReader(@"D:\Program Files\Memo\Setting\Count.txt"))
            { tmp = sr.ReadToEnd(); }
            for (int i = 0; i < tmp.Length; i++)
            {
                GlobalVar.total += (int)((tmp[i] - 48) * Math.Pow(10, tmp.Length - 1 - i));
            }
        }
        //totaltofile
        private void totaltofile()
        {
            File.WriteAllText(@"D:\Program Files\Memo\Setting\Count.txt", GlobalVar.total.ToString());
        }
        
        //setupmemo
        private void setupmemo()
        {
            filetototal();
            Memos = new Memo[GlobalVar.total];
            for (int i = 0; i < GlobalVar.total; i++) { Memos[i] = new Memo(i,false); }
        }

        //showmemo
        private void showmemo()
        {
            filetototal();
            for (int i = 0; i < GlobalVar.total; i++) { showmemo(i) ; }
 
        }
        private void showmemo(int i)
        {
            Memos[i].TopMost = true;
            Memos[i].Show() ;
            Memos[i].TopMost = false ;
        }

        //hidememo
        private void hidememo()
        {
            filetototal();
            for (int i = 0; i < GlobalVar.total; i++) { Memos[i].Hide(); }
        }

        //addmemo
        private void addmemo()
        {
            //filetototal();
            //GlobalVar.total++;
            //totaltofile();
            //if (GlobalVar.total == 1) { Memos = new Memo[1]; }
            //else { Array.Resize<Memo>(ref Memos, Memos.Length + 1); }
            //Memos[Memos.Length - 1] = new Memo(Memos.Length - 1,true);
            //showmemo(Memos.Length - 1);
            for (int i = 0; i < 100; i++)
            {
                if (GlobalVar.memo[i])
                {
                }
            }
        }

        //closememo
        private void closememo()
        {
            filetototal();
            for (int i = 0; i < GlobalVar.total; i++) { Memos[i].Close(); }
        }

        //clearmemo
        public void clearmemo(int a)
        {
            for (int i = a; i < Memos.Length-1; i++)
            {
                Memos[i] = Memos[i + 1];
            }
            Array.Resize<Memo>(ref Memos, Memos.Length - 1);
            GlobalVar.idx = -1;
            GlobalVar.total--;
            totaltofile();
        }
        private void clearmemo()
        {
            closememo();
            Array.Clear(Memos, 0, Memos.Length);
            Array.Resize(ref Memos, 0);
            GlobalVar.total = 0;
            totaltofile();
            cleardir();
        }
        //cleardir
        private void cleardir()
        {
            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(@"D:\Program Files\Memo\Data");

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        
        


        //EVENTS
        //mainframe no close------------------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        //------------------------------------------

        //Exit--------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            traybaricon.Icon = null;
            closememo();
            this.Close();
            Application.Exit();
        }
        //------------------------------------------

        private void showAllMemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showmemo();
        }

        private void hideAllMemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidememo();
        }

        private void addNewMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addmemo();
        }

        private void clearAllMemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearmemo();
        }

        private void traybaricon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showmemo();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Memos.Length; i++)
            {
                Memos[i].storedata();
            }
        }

        
        


    }
}
