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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            start();
            showallnotes();
            
        }
        //Boardless Form
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        //Boardless Form[END]
        
        
        //Variables
        Note[] Notes;

        private void start()
        {
            if (GlobalVar.total != 0)
            {
                Notes = new Note[GlobalVar.total];
                for (int i = 0; i < GlobalVar.total; i++)
                {
                    GlobalVar.count++;
                    Notes[i] = new Note();
                }
                GlobalVar.count = 0;
            }
        }

        
        private void showallnotes()
        {
            updatetotal();
            for (int i = 0; i < GlobalVar.total; i++)
            {
                GlobalVar.count++;
                Notes[i].TopMost = true;
                Notes[i].Show();
                Notes[i].TopMost = false;
            }
            GlobalVar.count = 0;
        }
        private void hideallnotes()
        {
            updatetotal();
            for (int i = 0; i < GlobalVar.total; i++)
            {
                GlobalVar.count++;
                Notes[i].Hide();
            }
            GlobalVar.count = 0;
        }
        private void addnewnote()
        {
            updatetotal();
            if (GlobalVar.total != 0)
            {   
                Array.Resize<Note>(ref Notes, Notes.Length + 1);
            }
            else 
            {
                Notes = new Note[1];
            }
            GlobalVar.total++;
            updatetotaltofile();
            Notes[Notes.Length - 1] = new Note();

            Notes[Notes.Length - 1].Show();
        }
        private void updatetotal()
        {
            string tmp;
            using (StreamReader sr = new StreamReader(@"D:\Program Files\Win8Note\Settings\NotesCount"))
            { tmp = sr.ReadToEnd(); }
            for (int i = 0; i < tmp.Length; i++)
            {
                GlobalVar.total += (int)((tmp[i] - 48) * Math.Pow(10, tmp.Length - 1 - i));
            }
        }
        private void updatetotaltofile()
        {
            File.WriteAllText(@"D:\Program Files\Win8Note\Settings\NotesCount", GlobalVar.total.ToString());
        }

        private void showAllNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showallnotes();
        }

        private void hideAllNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideallnotes();
        }

        private void addNewNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewnote();
        }
    }
}
