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

        private void InventoryHome_Click(object sender, EventArgs e)
        {

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        private void tblCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Form product = frmProduct.Instance;
            Form main = MainForm.Instance;
            main.AddOwnedForm(product);
            product.TopLevel = false;
            MainForm.Instance.MainPanel.Controls.Add(product);
            MainForm.Instance.MainPanel.Refresh();
            product.BringToFront();
            product.Show();
        }
        public void addtomain()
        {

        }
    }
}
