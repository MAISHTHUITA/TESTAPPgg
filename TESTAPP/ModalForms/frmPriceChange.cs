using CrystalDecisions.CrystalReports.Engine;
using SHOPLITE.Models;
using SHOPLITE.PrintingForms;
using SHOPLITE.Reports;
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
    public partial class frmPriceChange : Form
    {
        public frmPriceChange()
        {
            InitializeComponent();
        }
        private static frmPriceChange _instance;
        public static frmPriceChange Instance
        {
            get { if (_instance == null) { _instance = new frmPriceChange(); }; return _instance; }
        }
        private void frmPriceChange_Load(object sender, EventArgs e)
        {
            forminitialize();
        }

        private void forminitialize()
        {
            ProductRepository productRepository = new ProductRepository();
            SupplierRepository supplierRepository = new SupplierRepository();
            DepartmentRepository departmentRepository = new DepartmentRepository();
            List<Product> products = productRepository.GetProducts().ToList();
            List<Supplier> suppliers = supplierRepository.GetSuppliers().ToList();
            List<Department> departments = departmentRepository.GetDepartments().ToList();
            txtProdFrom.Text = products.First<Product>().ProdCd;
            txtProdTo.Text = products.Last<Product>().ProdCd;
            txtSuppFrom.Text = suppliers.First<Supplier>().SuppCd;
            txtSuppTo.Text = suppliers.Last<Supplier>().SuppCd;
            txtDeptFrom.Text = departments.First<Department>().DeptCd;
            txtDeptTo.Text = departments.Last<Department>().DeptCd;
            fromdt.Value = DateTime.Now.Date;
            dtto.Value = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            rbsp.Checked = false;
            rbpc.Checked = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbsp.Checked)
            {
                PriceRepository priceRepository = new PriceRepository();
                var costPrices = priceRepository.GetSellingPrices(fromdt.Value, dtto.Value, txtProdFrom.Text, txtProdTo.Text, txtSuppFrom.Text, txtSuppTo.Text, txtDeptFrom.Text, txtDeptTo.Text).ToList();
                if (costPrices.Count <= 0)
                {
                    MessageBox.Show("No records to display!!", "No Records!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ReportDocument report = new PriceChange();
                    report.SetDataSource(costPrices);
                    report.SetParameterValue("@Company", "THUITAS CYBER CAFE NAROK");
                    report.SetParameterValue("@Branch", "NAROK BRANCH");
                    report.SetParameterValue("@Username", "ADMIN");
                    report.SetParameterValue("@ReportName", "Selling");
                    Form form = new frmPrint(report);
                    form.Text = "Selling Price Change Report";
                    form.Show();
                }
            }
            if (rbpc.Checked)
            {
                PriceRepository priceRepository = new PriceRepository();
                var costPrices = priceRepository.GetCostPrices(fromdt.Value, dtto.Value, txtProdFrom.Text, txtProdTo.Text, txtSuppFrom.Text, txtSuppTo.Text, txtDeptFrom.Text, txtDeptTo.Text).ToList();
                if (costPrices.Count<=0)
                {
                    MessageBox.Show("No records to display!!", "No Records!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ReportDocument report = new PriceChange();
                    report.SetDataSource(costPrices);
                    report.SetParameterValue("@Company", "THUITAS CYBER CAFE NAROK");
                    report.SetParameterValue("@Branch", "NAROK BRANCH");
                    report.SetParameterValue("@Username", "ADMIN");
                    report.SetParameterValue("@ReportName", "Cost");
                    Form form = new frmPrint(report);
                    form.Text = "Cost Price Change Report";
                    form.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            forminitialize();
        }
    }
}
