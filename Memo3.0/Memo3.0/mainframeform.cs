using System;
using Microsoft.Win32;
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
    public partial class mainframeform : Form
    {
        //Variables
        memoform[] memos;
        int space = 0;
        


        public mainframeform()
        {
            
            setupmemo();
            loadmemo();
            if (memos.Length == 0) { addmemo(false, ""); }
            InitializeComponent();
            timer.Start();
        }

        private void setupmemo()
        {
            memos = new memoform[space];                                                           //initiate dynamic form array
            for (int i = 0; i < space; i++) { memos[i] = new memoform(this); memos[i].Show(); }        //initiate forms
        }

        public void addmemo(bool loadmemo,string context)
        {
            bool isResizeNeeded = true;
            int index = 0;
            for (int i = 0; i < memos.Length; i++)
            {
                if (memos[i].isMemoDeleted) { isResizeNeeded = false; index = i; break; }
            }
            if (isResizeNeeded)
            {
                Array.Resize<memoform>(ref memos, memos.Length + 1);
                memos[memos.Length - 1] = new memoform(this);
                if (loadmemo) { memos[memos.Length - 1].textBox.Text = context; }
                memos[memos.Length - 1].Show();
            }
            else 
            {
                memos[index].isMemoDeleted = false;
                if (loadmemo) { memos[index].textBox.Text = context; }
                memos[index].Show();
            }

        }
        private void showmemo(int a)
        {
            if (!memos[a].isMemoDeleted) 
            {
                memos[a].TopMost = true;
                memos[a].Show();
                memos[a].TopMost = false;
            }
        }
        private void showmemo()
        {
            for (int i = 0; i < memos.Length; i++) { showmemo(i); }
        }
        private void closememo(bool realclose)
        {
            for (int i = 0; i < memos.Length; i++)
            {
                if (realclose) { memos[i].Close(); }
                else { memos[i].Hide(); }
            }
        }
        private void deletememo()
        {
            for (int i = 0; i < memos.Length; i++) { memos[i].isMemoDeleted = true; memos[i].textBox.Text = string.Empty; }
            closememo(false);
        }
        private void storememo()
        {
            int count = 0;
            for (int i = 0; i < memos.Length; i++) 
            {
                if (!memos[i].isMemoDeleted) 
                {
                    count++;
                    File.WriteAllText(string.Format(GlobalVar.path_applocation+"\\data\\{0}", count.ToString("00000")), memos[i].textBox.Text);
                } 
            }
            File.WriteAllText(GlobalVar.path_applocation+"\\setting\\pool", count.ToString());
        }
        private void loadmemo()
        {
            int count = 0;
            using (StreamReader tmp = new StreamReader(GlobalVar.path_applocation + "\\setting\\pool"))
            {
                count=ToInt(tmp.ReadToEnd());
            }
            for (int i = 0; i < count; i++)
            {
                using (StreamReader tmp = new StreamReader(string.Format(GlobalVar.path_applocation + "\\data\\{0}", (i + 1).ToString("00000"))))
                {
                    addmemo(true, tmp.ReadToEnd());
                }
            }
            
 
        }
        private void cleardir()
        {
            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(GlobalVar.path_applocation + "\\data");

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private int ToInt(string a)
        {
            int tmp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tmp += (int)(a[i]-48 * Math.Pow(10, a.Length - 1));
            }
            return tmp;
        }




        private void addNewMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addmemo(false,string.Empty);
        }

        private void showAllMemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showmemo();
        }

        private void closeAllMemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closememo(false);
        }

        private void deleteAllMemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletememo();
        }

        private void storememobutton_Click(object sender, EventArgs e)
        {
            storememo();
        }

        private void loadmemobutton_Click(object sender, EventArgs e)
        {
            loadmemo();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            storememo();
            storesetting();
        }
        private void mainframeform_FormClosing(Object sender, FormClosingEventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleardir();
            storememo();
            closememo(true);
            storesetting();
            traybaricon.Icon = null;
            Application.Exit();
        }

        //Boardless Form---------------------------
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void traybaricon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showmemo();
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
        //-----------------------------------------

        private void windowsStartupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (windowsStartupToolStripMenuItem1.Checked == true) 
            {
                windowsStartupToolStripMenuItem1.Checked = false; GlobalVar.startup = false;
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key.DeleteValue("Memo");
                }
            }
            else 
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Memo", GlobalVar.path_applocation+"\\Memo.exe");
                windowsStartupToolStripMenuItem1.Checked = true; GlobalVar.startup = true; 
            }
            storesetting();
            
        }

        private void changeMemoColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                GlobalVar.memocolor = colorDialog.Color;
                for (int i = 0; i < memos.Length; i++) { memos[i].changememocolor(); }
            }
            storesetting();

            
        }

        private void storesetting()
        {
            File.WriteAllText(GlobalVar.path_applocation + "\\setting\\setting", GlobalVar.startup.ToString() + Environment.NewLine + GlobalVar.memocolor.A.ToString("000") + "," + GlobalVar.memocolor.R.ToString("000") + "," + GlobalVar.memocolor.G.ToString("000") + "," + GlobalVar.memocolor.B.ToString("000"));
            
        }

        
        

        

        
    }
}
