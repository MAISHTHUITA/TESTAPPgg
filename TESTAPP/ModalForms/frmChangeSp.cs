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
    public partial class frmChangeSp : Form
    {
        private Product product1;
        public frmChangeSp( Product product)
        {
            InitializeComponent();
            product1 = product;
        }

        private void frmChangeSp_Load(object sender, EventArgs e)
        {
            txtProdCd.Text = product1.ProdCd;
            txtProdNm.Text = product1.ProdNm;
            txtSP.Text = product1.Sp.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PriceRepository priceRepository = new PriceRepository();
            SellingPrice cost = new SellingPrice();
            cost.ProdCd = txtProdCd.Text;
            cost.Int_Sp = product1.Sp;
            cost.New_Sp = Convert.ToDecimal(txtNewPrice.Text);
            if (priceRepository.ChangeSP(cost))
            {
                MessageBox.Show("Selling price Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error on Saving. Please Contact System Admin For more help.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
