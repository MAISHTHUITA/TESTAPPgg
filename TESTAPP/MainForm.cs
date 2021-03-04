using SHOPLITE.Models;
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
            UserRepository userRepository = new UserRepository();
            if (userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANVIEWSTOCK && userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANCHANGECP &&
                userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANCHANGESP && userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANADDSTOCK)
            {
                Form inventory = frmInventory.Instance;
                inventory.TopLevel = false;
                MainPanel.Controls.Add(inventory);
                inventory.BringToFront();
                inventory.Show();
            }
            else
                MessageBox.Show("You have insufficient privillege to view requested resource");
            
        }
     
        private void btnProducts_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            if (userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANVIEWSTOCK && userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANCHANGECP &&
                userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANCHANGESP && userRepository.GetUserWithRoles(Properties.Settings.Default.USERNAME).CANADDSTOCK)
            {
                Form form = frmProduct.Instance;
                form.TopLevel = false;
                MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            else
                MessageBox.Show("You have insufficient privillege to view requested resource");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblBranch.Text = Properties.Settings.Default.BRANCHNAME;
            lblCompany.Text = Properties.Settings.Default.COMPANYNAME;
            lblUser.Text = Properties.Settings.Default.USERNAME;
            lblLogindate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            lblVersion.Text = Application.ProductVersion.ToString();
            Form form = frmDashboard.Instance;
            form.TopLevel = false;
            MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form form = frmReports.Instance;
            form.TopLevel = false;
            MainPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            Form form = frmManagement.Instance;
            form.TopLevel = false;
            MainPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }
    }
}
