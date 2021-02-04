using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SHOPLITE
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
            using (frmLogin login = new frmLogin() { user = new Models.User() })
            {
                login.ShowDialog();
                if (login.DialogResult==DialogResult.OK)
                {
                    Properties.Settings.Default.USERNAME = login.user.UserName;
                    Properties.Settings.Default.COMPANYNAME = login.Company;
                    Properties.Settings.Default.BRANCHNAME = login.Branch;
                    Properties.Settings.Default.Save();
                    Application.Run(new MainForm());
                }
            }
            
            
        }
    }
}
