using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            if (!confirmconnection())
            {

                Dbsettings db = new Dbsettings();
                db.ShowDialog();
                if (db.DialogResult == DialogResult.OK)
                {
                    using (frmLogin login = new frmLogin() { user = new Models.User() })
                    {
                        login.ShowDialog();
                        if (login.DialogResult == DialogResult.OK)
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
            else
            {
                using (frmLogin login = new frmLogin() { user = new Models.User() })
                {
                    login.ShowDialog();
                    if (login.DialogResult == DialogResult.OK)
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
        private static bool confirmconnection()
        {

            string userRoot = "HKEY_CURRENT_USER" + "\\" + "SOFTWARE";
            string subKey = "ShopLite";
            string keyName = userRoot + "\\" + subKey;
            string server = (string)Registry.GetValue(keyName, "Server", "Localhost");
            string database = (string)Registry.GetValue(keyName, "Database", "ShopliteDb");
            string user = (string)Registry.GetValue(keyName, "User", "SA");
            string password = (string)Registry.GetValue(keyName, "Password", "*******");
            string conn = "Server=" + server + ";database=" + database + ";user=" + user + ";password=" + password;
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
    }
}
