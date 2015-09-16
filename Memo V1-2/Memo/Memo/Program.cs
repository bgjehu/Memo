using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public static class GlobalVar
    {
        public static int total = 0;
        public static bool[] memo = new bool[100];
        public static int idx = -1;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            for (int i = 0; i < 100; i++) { GlobalVar.memo[i] = false; }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Memo());
            Application.Run(new mainframe());
        }
    }
}
