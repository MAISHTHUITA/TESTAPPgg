using SHOPLITE.ModalForms;
using SHOPLITE.Models;
using SHOPLITE.SearchFoms;
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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        private static frmInventory _instance;
        public static frmInventory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmInventory();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

       
        private void frmInventory_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnGrn_Click(object sender, EventArgs e)
        {
            Form form = frmGdRcv.Instance;
            form.TopLevel = false;
            mainpnl.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }
    }
}
