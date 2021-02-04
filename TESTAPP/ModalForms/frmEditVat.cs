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

namespace SHOPLITE.ModalForms
{
    public partial class frmEditVat : Form
    {
        public Vat vat1 { get; set; }
        public frmEditVat( Vat vat)
        {
            InitializeComponent();
            vat1 = vat;
            txtVatCode.Text = vat1.VatCd;
            txtVatPercentage.Text = vat1.VatPercentage.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VatRepository repository = new VatRepository();
            Vat vat = new Vat();
            vat.VatCd = txtVatCode.Text;
            vat.VatPercentage = Convert.ToDecimal(txtVatPercentage.Text);
            if (repository.EditVat(vat))
            {
                MessageBox.Show("Vat Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vat1.VatPercentage = Convert.ToDecimal(txtVatPercentage.Text);
                this.Close();
            }
        }
    }
}
