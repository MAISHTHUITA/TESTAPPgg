using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOPLITE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static MainForm _instance;
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainForm();
                return _instance;
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form dashboard = frmDashboard.Instance;
            dashboard.TopLevel = false;
            MainPanel.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form inventory = frmInventory.Instance;
            inventory.TopLevel = false;
            MainPanel.Controls.Add(inventory);
            inventory.BringToFront();
            inventory.Show();
        }
     
        private void btnProducts_Click(object sender, EventArgs e)
        {
            Form form = frmProduct.Instance;
            form.TopLevel = false;
            MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblBranch.Text = Properties.Settings.Default.BRANCHNAME;
            lblCompany.Text = Properties.Settings.Default.COMPANYNAME;
            lblUser.Text = Properties.Settings.Default.USERNAME;
            lblLogindate.Text = DateTime.Now.ToShortDateString();
            lblVersion.Text = Application.ProductVersion.ToString();
        }
    }
}
