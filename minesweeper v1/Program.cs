using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace minesweeper_v1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process p = Process.GetCurrentProcess();
            Process[] all = Process.GetProcesses();
            bool existe = false;
            foreach (Process p1 in all)
                if ((p.Id != p1.Id) && (string.CompareOrdinal(p.ProcessName.ToString(), p1.ProcessName.ToString()) == 0))
                { existe = true; break; }
            if (!existe) Application.Run(new Form1());
            else
            {
                MessageBox.Show("already opened application");
                Application.Exit();
            }

            
            
        }
    }
}
