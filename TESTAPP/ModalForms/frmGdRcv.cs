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

namespace SHOPLITE.ModalForms
{
    public partial class frmGdRcv : Form
    {
        public frmGdRcv()
        {
            InitializeComponent();
        }
        private static frmGdRcv _instance;
        public static frmGdRcv Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmGdRcv();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }


        private void frmGdRcv_Load(object sender, EventArgs e)
        {

            txtgdsupcd.Enabled = false;
            pnlgdproduct.Enabled = false;
        }
        private void btngdNew_Click(object sender, EventArgs e)
        {
            if (dgvgd.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to cancel the current transaction?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtgdsupcd.Text = txtInv.Text = txtSn.Text = lblsupnm.Text = "";
                    btngdclear_Click(sender, e);
                    txtSn.Enabled = false;
                    txtgdsupcd.Enabled = true;
                    dgvgd.Rows.Clear();
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
                txtgdsupcd.Enabled = true;
                txtInv.Focus();
            }

        }

        private void btngdclear_Click(object sender, EventArgs e)
        {
            txtgdProdNm.Text = txtgdDesc.Text = txtgdUnit.Text = txtgdVatcd.Text = txtgdSp.Text = txtgdCp.Text = txtgdCuqty.Text = txtgdQty.Text = "";
        }

        private void txtgdsupcd_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtgdsupcd.Text))
            {
                SupplierRepository repository = new SupplierRepository();
                Supplier supplier = new Supplier();
                supplier = repository.GetSupplier(txtgdsupcd.Text);
                if (supplier == null)
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
                    txtgdProdNm.Text = product.ProdCd; txtgdDesc.Text = product.ProdNm; txtgdUnit.Text = product.UnitCd;
                    txtgdVatcd.Text = product.VatPercentage.ToString(); txtgdCp.Text = product.Cp.ToString("0.00"); txtgdSp.Text = product.Sp.ToString("0.00");
                    txtgdCuqty.Text = product.QtyAvble.ToString("0.00"); txtgdQty.Text = "0";

                }
                else
                {
                    MessageBox.Show("Invalid Product code or Scancode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgdDesc.Text = txtgdUnit.Text =
                    txtgdVatcd.Text = txtgdCp.Text = txtgdSp.Text =
                    txtgdCuqty.Text = txtgdQty.Text = "";
                    return;
                }
            }
        }

        private void btngdadd_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtgdProdNm.Text))
            {
                MessageBox.Show("Please enter Product code");
                txtgdProdNm.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtgdQty.Text))
            {
                MessageBox.Show("Please enter Quantity");
                txtgdQty.Focus();
                return;
            }
            if (Convert.ToDecimal(txtgdQty.Text)<=0)
            {
                MessageBox.Show("Please enter valid quantity");
                txtgdQty.Focus();
                return;
            }
            foreach (DataGridViewRow row in dgvgd.Rows)
            {
                if (row.Cells[0].Value.ToString() == txtgdProdNm.Text)
                {
                    MessageBox.Show("Product " + txtgdProdNm.Text + " is already added");
                    return;
                }
            }
            try
            {
                PriceRepository price = new PriceRepository();
                decimal amt = Convert.ToDecimal(txtgdQty.Text) * Convert.ToDecimal(txtgdCp.Text);
                decimal prcexcl = price.CalculateVat(amt, Convert.ToDecimal(txtgdVatcd.Text));
                decimal vatamt = amt - prcexcl;
                dgvgd.Rows.Add(txtgdProdNm.Text, txtgdDesc.Text, txtgdUnit.Text, txtgdQty.Text, txtgdCp.Text, vatamt, prcexcl);
                btngdclear_Click(sender, e);
                calculateamounts();
                txtgdProdNm.Focus();

            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
           

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
                _instance = null;
            }
        }
        private void dgvRcv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvgd.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();

        }
        private void calculateamounts()
        {
            decimal amount = 0;
            decimal vat = 0;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvgd.Rows)
            {
                amount = amount + Convert.ToDecimal(row.Cells[6].Value.ToString());
                vat = vat + Convert.ToDecimal(row.Cells[5].Value.ToString());
                total = amount + vat;
            }
            lblNetAmt.Text = amount.ToString("0.00");
            lblVatAmt.Text = vat.ToString("0.00");
            lblTtlAmt.Text = total.ToString("0.00");
        }
        private void dgvRcv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            if (y >= 0)
            {
                if (String.IsNullOrEmpty(txtgdProdNm.Text))
                {
                    string codde = dgvgd.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string quty = dgvgd.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtgdProdNm.Text = codde;
                    txtgdProdNm_Leave(sender, e);
                    txtgdQty.Text = quty;
                    dgvgd.Rows.RemoveAt(e.RowIndex);
                    calculateamounts();

                }
                else
                {
                    MessageBox.Show("Please Enter or clear Current Product ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        
        }
    }
}

