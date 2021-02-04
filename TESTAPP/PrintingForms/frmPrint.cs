using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOPLITE.PrintingForms
{
    public partial class frmPrint : Form
    {
        private ReportDocument _report;
        public frmPrint(ReportDocument report)
        {
            InitializeComponent();
            _report = report;
            ReportViewer.ReportSource = _report;
        }
    }
}
