using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sd_final
{
    static class Program
    {
        private static frmlogin _mainForm;
        public static frmlogin MainForm
        {
            get { return _mainForm; }
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmlogin _mainForm = new frmlogin();
            Application.Run(_mainForm);
        }
    }
}
