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
            pnlgdproduct.Enabled = false;
        }

        private void tblCustomer_Click(object sender, EventArgs e)
        {

        }
        private void btngdNew_Click(object sender, EventArgs e)
        {
            if (dgvgd.Rows.Count>0)
            {
              if(  MessageBox.Show("Are you sure you want to cancel the current transaction?","Cancel?", MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    txtgdsupcd.Text = txtInv.Text = txtSn.Text = lblsupnm.Text = "";
                    btngdclear_Click(sender, e);
                    txtSn.Enabled = false;
                    txtInv.Focus();

                }
                else
                {
                    return;
                }
            }
            else
            {
                txtgdsupcd.Text = txtInv.Text = txtSn.Text = lblsupnm.Text = "";
                btngdclear_Click(sender, e);
                txtSn.Enabled = false;
                txtInv.Focus();
            }
            
        }

        private void btngdclear_Click(object sender, EventArgs e)
        {
            txtgdProdNm.Text = txtgdDesc.Text = txtgdUnit.Text = txtgdVatcd.Text = txtgdSp.Text = txtgdCp.Text = txtgdCuqty.Text = txtgdQty.Text = "";
        }

        private void txtgdsupcd_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty( txtgdsupcd.Text))
            {
                SupplierRepository repository = new SupplierRepository();
                Supplier supplier = new Supplier();
                supplier = repository.GetSupplier(txtgdsupcd.Text);
                if (supplier==null)
                {
                    MessageBox.Show("Invalid Supplier Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgdsupcd.Focus();
                    txtgdsupcd.Text = "";
                    return;
                }
                else
                {
                    txtgdsupcd.Text = supplier.SuppCd;
                    lblsupnm.Text = supplier.SuppNm;
                    pnlgdproduct.Enabled = true;
                    txtgdProdNm.Focus();
                   
                }
            }
        }

        private void txtgdsupcd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SupplierRepository repository = new SupplierRepository();
                List<Supplier> suppliers = repository.GetSuppliers().ToList();
                if (suppliers.Count == 0)
                {
                    MessageBox.Show("No Records to Display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    using (frmSearchSupp su = new frmSearchSupp(suppliers) { supplier = new Supplier() })
                    {
                        su.ShowDialog();
                        txtgdsupcd.Text = su.supplier.SuppCd;
                    }
                }
            }
        }

        private void txtgdProdNm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                ProductRepository repository = new ProductRepository();
                List<Product> products = repository.GetProducts().ToList();
                if (products.Count == 0)
                {
                    MessageBox.Show("No Records to Display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    using (frmSearchProd su = new frmSearchProd(products) { product = new Product() })
                    {
                        su.ShowDialog();
                        txtgdProdNm.Text = su.product.ProdCd;
                    }
                }
            }
        }

        private void txtgdProdNm_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtgdProdNm.Text))
            {
                ProductRepository productRepository = new ProductRepository();
                Product product = new Product();
                product = productRepository.GetProduct(txtgdProdNm.Text);
                if (product != null)
                {
                    txtgdProdNm.Text = product.ProdCd;txtgdDesc.Text = product.ProdNm; txtgdUnit.Text = product.UnitCd;
                    txtgdVatcd.Text = product.VatCd;txtgdCp.Text = product.Cp.ToString("0.00");txtgdSp.Text = product.Sp.ToString("0.00");
                    txtgdCuqty.Text = product.QtyAvble.ToString("0.00");txtgdQty.Text = "0";

                }
                else
                {
                    MessageBox.Show("Invalid Product code or Scancode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgdDesc.Text =txtgdUnit.Text =
                    txtgdVatcd.Text =  txtgdCp.Text =  txtgdSp.Text =
                    txtgdCuqty.Text =  txtgdQty.Text = "";
                    return;
                }
            }
        }

        private void btngdadd_Click(object sender, EventArgs e)
        {
            if (txtgdProdNm.Text != null && txtgdDesc != null && txtgdQty.Text != null)
            {

            }
        }
    }
}
