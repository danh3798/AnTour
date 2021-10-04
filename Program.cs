using AnTour.ChildForm;
using System;
using System.Windows.Forms;

namespace AnTour
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
            
            FormLogin frmLogin = new FormLogin();
            Application.Run(frmLogin);
            if (frmLogin.IsLogin == true)
            {
                Application.Run(new Form1(frmLogin.FullName));
            }
        }
    }
}
