using System;
using System.Windows.Forms;

namespace Queue
{
    internal static class Program
    {
        /// <summary>
        /// The main class of the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
