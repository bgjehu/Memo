using System;
using System.Threading;
using Shell32;
using IWshRuntimeLibrary;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo4._0_installer
{
    public partial class installer : Form
    {
        int page = 0;
        int page_total = 4;
        //string filepathrgx = @"^(?:[a-zA-Z]\:|\\\\[\w\\.]+\\[\w.$]+)\\(?:[\w]+\\)*\w([\w.])+$";
        string filepathrgx = @"^[a-zA-Z]\:|\\\\[\w\\.]+\\[\w.$]+";
        Panel[] panel_page;
        string path_applocation;
        string version = "4.0.1";
        byte[] app=Properties.Resources.Memo;
        byte[] lib = Properties.Resources.lib;
        
        
        public installer()
        {
            InitializeComponent();
            mainthread();
        }

        private void mainthread()
        {            
            setuppage();
        }


        private void setuppage()
        {
            panel_page = new Panel[page_total];
            panel_page[0] = panel_page0;
            panel_page[1] = panel_page1;
            panel_page[2] = panel_page2;
            panel_page[3] = panel_page3;
            turntopage(page);
 
        }

        private void turntopage(int page)
        {
            for (int i = 0; i < page_total; i++)
            {
                if (i == page) { panel_page[i].Visible = true; }
                else { panel_page[i].Visible = false; }
                if (page > 0) { button_back.Visible = true; }
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case 0:
                    page++;
                    turntopage(page);
                    break;
                case 1:
                    if (setpath()) 
                    {
                        page++;
                        turntopage(page);
                        button_back.Enabled = false;
                        button_next.Enabled = false;
                        button_cancel.Enabled = false;
                        if (isInstallad())
                        {
                            button_next.Enabled = true; 
                        }
                        else { }                                                                        //install unsuccessfully
                    }
                    else { }
                    break;
                case 2:
                    page++;
                    turntopage(page);
                    button_next.Text = "Finish";
                    break;
                case 3:
                    if (checkBox_runapp.Checked) 
                    {
                        Process.Start(path_applocation+"\\Memo.exe");
                    }
                    Application.Exit();
                    break;

            }

            
            
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_installpathselect.ShowDialog() != DialogResult.Cancel)
            { textBox_path_applocation.Text = folderBrowserDialog_installpathselect.SelectedPath+"\\Memo"; }
        }

        private bool setpath()
        {
            if (Regex.IsMatch(textBox_path_applocation.Text,filepathrgx))
            {
                path_applocation = textBox_path_applocation.Text;
                if (Directory.Exists(path_applocation)) { return true; }
                else 
                {
                    if (MessageBox.Show("The location does not exist.\nDo you want to create?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Directory.CreateDirectory(path_applocation);
                        return true;
                    }
                    else { return false; }
                }
            }
            else { MessageBox.Show("The location is invalid for the installation", "Error"); return false; }
        }

        private bool isInstallad()
        {
            if (Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Memo") == null)       //never installed
            {
                install();
                return true;
            }
            else                                                                              //installed
            {
                install();
                return true;
 
            }
 
        }
        private void install()
        {
            progressBar_install.Minimum = 1;
            progressBar_install.Maximum = 10;
            progressBar_install.Step = 1;

            //setup Registry
            label_install.Text = "Registering......";
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Memo", "Path", path_applocation);
            progressBar_install.Value++;
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Memo", "Version", version);
            progressBar_install.Value++;
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Memo", "Installation Time", DateTime.Now.ToString());
            progressBar_install.Value++;

            //setup filepath
            label_install.Text = "Installing......";
            Directory.CreateDirectory(path_applocation);
            progressBar_install.Value++;
            Directory.CreateDirectory(path_applocation + "\\Data");
            progressBar_install.Value++;
            Directory.CreateDirectory(path_applocation + "\\Setting");
            progressBar_install.Value++;
            System.IO.File.WriteAllText(path_applocation + "\\Setting\\setting", string.Empty);
            progressBar_install.Value++;
            System.IO.File.WriteAllText(path_applocation + "\\Setting\\pool", string.Empty);
            progressBar_install.Value++;
            System.IO.File.WriteAllBytes(path_applocation + "\\Memo.exe", app);
            progressBar_install.Value++;

            label_install.Text = "Done......";

            if (checkBox_startup.Checked)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Memo", path_applocation + "\\Memo.exe");
            }
            if (checkBox_shortcut.Checked)
            {
                string insloc = Path.GetDirectoryName(Application.ExecutablePath);
                string libloc = insloc + "\\Interop.IWshRuntimeLibrary.dll";
                System.IO.File.WriteAllBytes(libloc, lib);
                createshortcut();
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Memo", "Installer Path", libloc);
                

                
                
                
                
                
                

            }
            label_installed.Visible = true;
        }

        private void uninstall()
        {
 
        }

        private void createshortcut()
        {
            WshShellClass wsh = new WshShellClass();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Memo.lnk") as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = "";
            shortcut.TargetPath = path_applocation + "\\Memo.exe";
            // not sure about what this is for
            shortcut.WindowStyle = 1;
            shortcut.WorkingDirectory = path_applocation;
            //shortcut.IconLocation = "";
            //shortcut.Description = "";
            shortcut.Save();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            page--;
            turntopage(page);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel the installation?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        

        

    }
}
