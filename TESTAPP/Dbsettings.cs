using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOPLITE
{
    public partial class Dbsettings : Form
    {
        string userRoot = "HKEY_CURRENT_USER" + "\\" + "SOFTWARE";
        string subKey = "ShopLite";

        public Dbsettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkconn())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool checkconn()
        {
            string keyName = userRoot + "\\" + subKey;
            string server = txtServer.Text;
                Registry.SetValue(keyName, "Server", server);
            string database = txtDatabase.Text;
                Registry.SetValue(keyName, "Database", database);
            string user = txtUser.Text;
                Registry.SetValue(keyName, "User", user);
            string password = txtPassword.Text;
                Registry.SetValue(keyName, "Password", password);
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

        private void Dbsettings_Load(object sender, EventArgs e)
        {

            string keyName = userRoot + "\\" + subKey;
            string server = (string)Registry.GetValue(keyName, "Server", "Localhost");
            string database = (string)Registry.GetValue(keyName, "Database", "ShopliteDb");
            string user = (string)Registry.GetValue(keyName, "User", "SA");
            string password = (string)Registry.GetValue(keyName, "Password", "*******");
            txtServer.Text = server;
            txtDatabase.Text = database;
            txtUser.Text = user;
            txtPassword.Text = password;
        }
    }
}
