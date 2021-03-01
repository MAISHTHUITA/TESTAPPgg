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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = frmPriceChange.Instance;
            form.TopLevel = false;
           
            mainpnl.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        private static frmReports _instance;
        public static frmReports Instance
        {
            get { if (_instance == null) { _instance = new frmReports(); }; return _instance; }
        }
    }
}
