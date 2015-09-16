using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public static class GlobalVar
    {
        public static string version;
        public static string path_applocation;
        public static bool runapp = true;
        public static bool startup;
        public static Color memocolor;
        public static string libloc;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //run as admin
            if (!IsRunAsAdmin())
            {
                var processInfo = new ProcessStartInfo(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);

                // The following properties run the new process as administrator
                processInfo.UseShellExecute = true;
                processInfo.Verb = "runas";

                // Start the new process
                try
                {
                    Process.Start(processInfo);
                }
                catch (Exception)
                {
                    // The user did not allow the program to run as administrator
                    MessageBox.Show("Sorry, this application must be run as Administrator.");
                }

                // Shut down the current process
                Application.Exit();
            }
            else
            {
                mainthread();
            }
            
            
        }

        private static void mainthread()
        {
            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Memo", "Installer Path", null) == null) { }
            else
            {
                GlobalVar.libloc = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Memo", "Installer Path", null).ToString();
                File.Delete(GlobalVar.libloc);
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Memo", true))
                { key.DeleteValue("Installer Path"); }
            }


            loadsetting();
            if (GlobalVar.runapp)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainframeform());
            }
            else { Application.Exit(); }
        }

        private static void loadsetting()
        {
            


            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Memo", "Version", null) == null) { ExceptionHandle00(); }                //Version Loaded Unsuccessfully
            else
            {
                GlobalVar.version = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Memo", "Version", null).ToString();
                if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Memo", "Path", null) == null) { ExceptionHandle00(); }               //Path Loaded Unsuccessfully
                else
                {
                    GlobalVar.path_applocation = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Memo", "Path", null).ToString();
                    if (!Directory.Exists(GlobalVar.path_applocation)) { ExceptionHandle00(); }                                         //Path Do Not Exist
                    else
                    {
                        if (!File.Exists(GlobalVar.path_applocation + "\\setting\\pool")) { ExceptionHandle00(); }                      //Pool File Do Not Exist
                        else
                        {
                            if (!File.Exists(GlobalVar.path_applocation + "\\setting\\setting")) { loaddesettingfile(true); }               //SettingFile Do Not Exist
                            { loaddesettingfile(false); }
                        }
                    }
                }
            }
            
        }
        private static void loaddesettingfile(bool loaddefaultsetting)
        {
            if (loaddefaultsetting)
            {
                GlobalVar.startup = true;
                GlobalVar.memocolor = Color.PaleGreen;
            }
            else 
            {
                using(StreamReader tmp=new StreamReader(GlobalVar.path_applocation+"\\setting\\setting"))
                {
                    if (tmp.ReadLine() == "False")
                    {
                        GlobalVar.startup = false;
                    }
                    else { GlobalVar.startup = true ; }
                    

                    string tmpstr = tmp.ReadToEnd();
                    if (tmpstr.Length == 15)
                    {
                        string A = tmpstr[0].ToString() + tmpstr[1].ToString() + tmpstr[2].ToString();
                        string R = tmpstr[4].ToString() + tmpstr[5].ToString() + tmpstr[6].ToString();
                        string G = tmpstr[8].ToString() + tmpstr[9].ToString() + tmpstr[10].ToString();
                        string B = tmpstr[12].ToString() + tmpstr[13].ToString() + tmpstr[14].ToString();
                        if (Convert.ToInt32(A) < 256 && Convert.ToInt32(B) < 256 && Convert.ToInt32(G) < 256 && Convert.ToInt32(R) < 256)
                        {
                            if (Convert.ToInt32(A) >= 0 && Convert.ToInt32(B) >= 0 && Convert.ToInt32(G) >= 0 && Convert.ToInt32(R) >= 0)
                            {
                                GlobalVar.memocolor = Color.FromArgb(Convert.ToInt32(A), Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));

                            }
                        }
                    }
                    else { GlobalVar.memocolor = Color.PaleGreen; }



                    //MessageBox.Show(GlobalVar.startup.ToString() + "\n" + GlobalVar.memocolor.A.ToString("000") + "," + GlobalVar.memocolor.R.ToString("000") + "," + GlobalVar.memocolor.G.ToString("000") + "," + GlobalVar.memocolor.B.ToString("000"));
                }
            }

        }

        private static void ExceptionHandle00()
        {
            GlobalVar.runapp = false;
            MessageBox.Show(string.Format("Error: Critical Files missing!\nPlease reinstall Memo!", GlobalVar.version), "Error!");
            //Download App
            


        }

        private static bool IsRunAsAdmin()
        {
            var wi = System.Security.Principal.WindowsIdentity.GetCurrent();
            var wp = new System.Security.Principal.WindowsPrincipal(wi);

            return wp.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
        
        
    }
}
;