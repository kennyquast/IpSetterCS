using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace IpSetterCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (IsApplicationAlreadyRunning() == true)
                {
                    MessageBox.Show("The application is already running");
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("error " + err.ToString());
            }
        }
        static bool IsApplicationAlreadyRunning()
        {
            string proc = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(proc);
            if (processes.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
       
    }
}

