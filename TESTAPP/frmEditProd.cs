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
    public partial class frmEditProd : Form
    {
        private Product product;
        public frmEditProd( string product1)
        {
            InitializeComponent();
            ProductRepository repository = new ProductRepository();
            
            product =repository.GetProduct(product1);
            prodCdTextBox.Text = product.ProdCd;
            prodNmTextBox.Text = product.ProdNm;
            UnitTextBox.Text = product.UnitCd;
            deptTextBox.Text = product.DeptCd;
            SupTextBox.Text = product.SuppCd;
            cpTextBox.Text = product.Cp.ToString();
            spTextBox.Text = product.Sp.ToString();
            isActiveCheckBox.Checked = product.IsActive;
            VatTextBox.Text = product.VatCd;
            qtyAvbleTextBox.Text = product.QtyAvble.ToString();
            qtyOnOrderTextBox.Text = product.QtyOnOrder.ToString();
        }
        public Product product1 { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            var prod = repository.GetProduct(prodCdTextBox.Text);
            if (prod==null)
            {
                MessageBox.Show("Error Occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Product product = new Product();
            product.ProdCd = prodCdTextBox.Text;
            product.ProdNm = prodNmTextBox.Text;
            product.UnitCd = UnitTextBox.Text;
            product.DeptCd = deptTextBox.Text;
            product.SuppCd = SupTextBox.Text;
            product.VatCd= VatTextBox.Text;
            product.IsActive =isActiveCheckBox.Checked;
            
            if (repository.EditProduct(product))
            {
                MessageBox.Show("Updated successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                product1.ProdCd = product.ProdCd;
                this.Close();
            }
        }

        private void frmEditProd_Load(object sender, EventArgs e)
        {

        }
    }
}
