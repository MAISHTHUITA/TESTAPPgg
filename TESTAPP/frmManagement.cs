using SHOPLITE.ModalForms;
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
    public partial class frmManagement : Form
    {
        private static frmManagement _instance;
        public static frmManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmManagement();
                return _instance;
            }
        }
        public frmManagement()
        {
            InitializeComponent();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            Form form = frmGroups.Instance;
            form.TopLevel = false;
            pnlmain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = frmUsers.Instance;
            form.TopLevel = false;
            pnlmain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }
    }
}
