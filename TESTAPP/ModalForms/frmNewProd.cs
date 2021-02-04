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
    public partial class frmNewProd : Form
    {
        public frmNewProd()
        {
            InitializeComponent();
        }
        public Product product1 { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(prodCdTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Code.");
                return;
            }
            if (String.IsNullOrEmpty(prodNmTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Name.");
                return;
            }
            if (String.IsNullOrEmpty(UnitTextBox.Text))
            {
                MessageBox.Show("Please Enter Product unit.");
                return;
            }
            if (String.IsNullOrEmpty(deptTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Department.");
                return;
            }
            if (String.IsNullOrEmpty(SupTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Supplier.");
                return;
            }
            if (String.IsNullOrEmpty(cpTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Cost Price.");
                return;
            }
            if (String.IsNullOrEmpty(spTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Selling Price.");
                return;
            }
            if (String.IsNullOrEmpty(VatTextBox.Text))
            {
                MessageBox.Show("Please Enter Product Vat.");
                return;
            }
            ProductRepository repository = new ProductRepository();
            var prod = repository.GetProduct(prodCdTextBox.Text);
            if (prod !=null)
            {
                MessageBox.Show("Product Code Provided Exist in The database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Product product = new Product();
            product.ProdCd = prodCdTextBox.Text;
            product.ProdNm = prodNmTextBox.Text;
            product.UnitCd = UnitTextBox.Text;
            product.DeptCd = deptTextBox.Text;
            product.SuppCd = SupTextBox.Text;
            product.VatCd = VatTextBox.Text;
            product.CreatedBy = "Admin";
            product.Cp = Convert.ToDecimal(cpTextBox.Text);
            product.Sp = Convert.ToDecimal(spTextBox.Text);
            
            if (repository.AddProduct(product))
            {
                MessageBox.Show("Product Added Successfully.");
                product1.ProdCd = product.ProdCd;
                this.Close();
            }
            else
                MessageBox.Show("Error occorred. Please try again.");


        }
    }
}
