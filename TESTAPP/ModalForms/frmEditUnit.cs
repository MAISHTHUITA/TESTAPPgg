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
    public partial class frmEditUnit : Form
    {
        private Unit _unit;
        public frmEditUnit(Unit UnitCd)
        {
            InitializeComponent();
            _unit= UnitCd;
            txtUnitCd.Text = _unit.UnitCd;
            txtUnitNm.Text = _unit.UnitNm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UnitRepository repository = new UnitRepository();
            Unit unit = new Unit();
            unit.UnitNm = txtUnitNm.Text;
            unit.UnitCd = txtUnitCd.Text;
            if (repository.EditUnit(unit))
            {
                MessageBox.Show("Record uppdated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
