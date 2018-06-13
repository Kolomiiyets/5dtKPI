using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // YOU GET AN ERROR FOR THE CODE BELOW?
            // Just copy the newest DLLs from DGlove\Data_Glove_Ultra\SDK\Windows\Latest\sdk\dll\
            Application.Run(new frmMain());
        }
    }
}
