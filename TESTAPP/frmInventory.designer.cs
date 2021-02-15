
namespace SHOPLITE
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.InventoryHome = new System.Windows.Forms.TabPage();
            this.tbGoodReceive = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btngdPrint = new System.Windows.Forms.Button();
            this.btngdCancel = new System.Windows.Forms.Button();
            this.btngdNew = new System.Windows.Forms.Button();
            this.btngdSave = new System.Windows.Forms.Button();
            this.dgvgd = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlgdproduct = new System.Windows.Forms.Panel();
            this.btngdclear = new System.Windows.Forms.Button();
            this.btngdadd = new System.Windows.Forms.Button();
            this.txtgdDesc = new System.Windows.Forms.TextBox();
            this.txtgdQty = new System.Windows.Forms.TextBox();
            this.txtgdCuqty = new System.Windows.Forms.TextBox();
            this.txtgdSp = new System.Windows.Forms.TextBox();
            this.txtgdCp = new System.Windows.Forms.TextBox();
            this.txtgdVatcd = new System.Windows.Forms.TextBox();
            this.txtgdUnit = new System.Windows.Forms.TextBox();
            this.txtgdProdNm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgd = new System.Windows.Forms.DateTimePicker();
            this.txtgdsupcd = new System.Windows.Forms.TextBox();
            this.txtInv = new System.Windows.Forms.TextBox();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsupnm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGoodIssue = new System.Windows.Forms.TabPage();
            this.tblInvoice = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatAmnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControl.SuspendLayout();
            this.tbGoodReceive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).BeginInit();
            this.pnlgdproduct.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 33);
            this.panel1.TabIndex = 0;
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.InventoryHome);
            this.tbControl.Controls.Add(this.tbGoodReceive);
            this.tbControl.Controls.Add(this.tbGoodIssue);
            this.tbControl.Controls.Add(this.tblInvoice);
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.Location = new System.Drawing.Point(0, 33);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(816, 498);
            this.tbControl.TabIndex = 1;
            // 
            // InventoryHome
            // 
            this.InventoryHome.Location = new System.Drawing.Point(4, 29);
            this.InventoryHome.Name = "InventoryHome";
            this.InventoryHome.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryHome.Size = new System.Drawing.Size(808, 465);
            this.InventoryHome.TabIndex = 0;
            this.InventoryHome.Text = "Home";
            this.InventoryHome.UseVisualStyleBackColor = true;
            // 
            // tbGoodReceive
            // 
            this.tbGoodReceive.Controls.Add(this.panel2);
            this.tbGoodReceive.Location = new System.Drawing.Point(4, 29);
            this.tbGoodReceive.Name = "tbGoodReceive";
            this.tbGoodReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tbGoodReceive.Size = new System.Drawing.Size(808, 465);
            this.tbGoodReceive.TabIndex = 2;
            this.tbGoodReceive.Text = "Good Receive";
            this.tbGoodReceive.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(254)))), ((int)(((byte)(248)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pnlgdproduct);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 459);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.dgvgd);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 306);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.btngdPrint);
            this.panel7.Controls.Add(this.btngdCancel);
            this.panel7.Controls.Add(this.btngdNew);
            this.panel7.Controls.Add(this.btngdSave);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 195);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(798, 84);
            this.panel7.TabIndex = 3;
            // 
            // btngdPrint
            // 
            this.btngdPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(143)))));
            this.btngdPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(192)))), ((int)(((byte)(240)))));
            this.btngdPrint.FlatAppearance.BorderSize = 2;
            this.btngdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngdPrint.ForeColor = System.Drawing.Color.White;
            this.btngdPrint.Location = new System.Drawing.Point(374, 20);
            this.btngdPrint.Name = "btngdPrint";
            this.btngdPrint.Size = new System.Drawing.Size(75, 40);
            this.btngdPrint.TabIndex = 2;
            this.btngdPrint.Text = "Print";
            this.btngdPrint.UseVisualStyleBackColor = false;
            // 
            // btngdCancel
            // 
            this.btngdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(143)))));
            this.btngdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(192)))), ((int)(((byte)(240)))));
            this.btngdCancel.FlatAppearance.BorderSize = 2;
            this.btngdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngdCancel.ForeColor = System.Drawing.Color.White;
            this.btngdCancel.Location = new System.Drawing.Point(471, 20);
            this.btngdCancel.Name = "btngdCancel";
            this.btngdCancel.Size = new System.Drawing.Size(75, 40);
            this.btngdCancel.TabIndex = 1;
            this.btngdCancel.Text = "Cancel";
            this.btngdCancel.UseVisualStyleBackColor = false;
            // 
            // btngdNew
            // 
            this.btngdNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(143)))));
            this.btngdNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(192)))), ((int)(((byte)(240)))));
            this.btngdNew.FlatAppearance.BorderSize = 2;
            this.btngdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngdNew.ForeColor = System.Drawing.Color.White;
            this.btngdNew.Location = new System.Drawing.Point(184, 20);
            this.btngdNew.Name = "btngdNew";
            this.btngdNew.Size = new System.Drawing.Size(75, 40);
            this.btngdNew.TabIndex = 0;
            this.btngdNew.Text = "New";
            this.btngdNew.UseVisualStyleBackColor = false;
            this.btngdNew.Click += new System.EventHandler(this.btngdNew_Click);
            // 
            // btngdSave
            // 
            this.btngdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(143)))));
            this.btngdSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(192)))), ((int)(((byte)(240)))));
            this.btngdSave.FlatAppearance.BorderSize = 2;
            this.btngdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngdSave.ForeColor = System.Drawing.Color.White;
            this.btngdSave.Location = new System.Drawing.Point(279, 20);
            this.btngdSave.Name = "btngdSave";
            this.btngdSave.Size = new System.Drawing.Size(75, 40);
            this.btngdSave.TabIndex = 1;
            this.btngdSave.Text = "Save";
            this.btngdSave.UseVisualStyleBackColor = false;
            // 
            // dgvgd
            // 
            this.dgvgd.AllowUserToAddRows = false;
            this.dgvgd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdCode,
            this.ProdDesc,
            this.Unit,
            this.Qty,
            this.Cost,
            this.VatAmnt,
            this.Amount});
            this.dgvgd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvgd.EnableHeadersVisualStyles = false;
            this.dgvgd.Location = new System.Drawing.Point(0, 0);
            this.dgvgd.Name = "dgvgd";
            this.dgvgd.ReadOnly = true;
            this.dgvgd.RowHeadersWidth = 35;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvgd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvgd.Size = new System.Drawing.Size(798, 279);
            this.dgvgd.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(798, 25);
            this.panel6.TabIndex = 0;
            // 
            // pnlgdproduct
            // 
            this.pnlgdproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlgdproduct.Controls.Add(this.btngdclear);
            this.pnlgdproduct.Controls.Add(this.btngdadd);
            this.pnlgdproduct.Controls.Add(this.txtgdDesc);
            this.pnlgdproduct.Controls.Add(this.txtgdQty);
            this.pnlgdproduct.Controls.Add(this.txtgdCuqty);
            this.pnlgdproduct.Controls.Add(this.txtgdSp);
            this.pnlgdproduct.Controls.Add(this.txtgdCp);
            this.pnlgdproduct.Controls.Add(this.txtgdVatcd);
            this.pnlgdproduct.Controls.Add(this.txtgdUnit);
            this.pnlgdproduct.Controls.Add(this.txtgdProdNm);
            this.pnlgdproduct.Controls.Add(this.label5);
            this.pnlgdproduct.Controls.Add(this.label11);
            this.pnlgdproduct.Controls.Add(this.label10);
            this.pnlgdproduct.Controls.Add(this.label9);
            this.pnlgdproduct.Controls.Add(this.label8);
            this.pnlgdproduct.Controls.Add(this.label7);
            this.pnlgdproduct.Controls.Add(this.label6);
            this.pnlgdproduct.Controls.Add(this.label4);
            this.pnlgdproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlgdproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlgdproduct.Location = new System.Drawing.Point(0, 70);
            this.pnlgdproduct.Name = "pnlgdproduct";
            this.pnlgdproduct.Size = new System.Drawing.Size(800, 81);
            this.pnlgdproduct.TabIndex = 1;
            // 
            // btngdclear
            // 
            this.btngdclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngdclear.Location = new System.Drawing.Point(712, 44);
            this.btngdclear.Name = "btngdclear";
            this.btngdclear.Size = new System.Drawing.Size(69, 28);
            this.btngdclear.TabIndex = 2;
            this.btngdclear.Text = "CLEAR";
            this.btngdclear.UseVisualStyleBackColor = true;
            this.btngdclear.Click += new System.EventHandler(this.btngdclear_Click);
            // 
            // btngdadd
            // 
            this.btngdadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngdadd.Location = new System.Drawing.Point(649, 44);
            this.btngdadd.Name = "btngdadd";
            this.btngdadd.Size = new System.Drawing.Size(57, 28);
            this.btngdadd.TabIndex = 2;
            this.btngdadd.Text = "ADD";
            this.btngdadd.UseVisualStyleBackColor = true;
            this.btngdadd.Click += new System.EventHandler(this.btngdadd_Click);
            // 
            // txtgdDesc
            // 
            this.txtgdDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdDesc.BackColor = System.Drawing.Color.White;
            this.txtgdDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdDesc.Enabled = false;
            this.txtgdDesc.ForeColor = System.Drawing.Color.Black;
            this.txtgdDesc.Location = new System.Drawing.Point(267, 13);
            this.txtgdDesc.Name = "txtgdDesc";
            this.txtgdDesc.Size = new System.Drawing.Size(303, 21);
            this.txtgdDesc.TabIndex = 1;
            // 
            // txtgdQty
            // 
            this.txtgdQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdQty.BackColor = System.Drawing.Color.White;
            this.txtgdQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdQty.ForeColor = System.Drawing.Color.Black;
            this.txtgdQty.Location = new System.Drawing.Point(571, 48);
            this.txtgdQty.Name = "txtgdQty";
            this.txtgdQty.Size = new System.Drawing.Size(56, 21);
            this.txtgdQty.TabIndex = 1;
            // 
            // txtgdCuqty
            // 
            this.txtgdCuqty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdCuqty.BackColor = System.Drawing.Color.White;
            this.txtgdCuqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdCuqty.Enabled = false;
            this.txtgdCuqty.ForeColor = System.Drawing.Color.Black;
            this.txtgdCuqty.Location = new System.Drawing.Point(432, 48);
            this.txtgdCuqty.Name = "txtgdCuqty";
            this.txtgdCuqty.Size = new System.Drawing.Size(56, 21);
            this.txtgdCuqty.TabIndex = 1;
            // 
            // txtgdSp
            // 
            this.txtgdSp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdSp.BackColor = System.Drawing.Color.White;
            this.txtgdSp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdSp.Enabled = false;
            this.txtgdSp.ForeColor = System.Drawing.Color.Black;
            this.txtgdSp.Location = new System.Drawing.Point(306, 48);
            this.txtgdSp.Name = "txtgdSp";
            this.txtgdSp.Size = new System.Drawing.Size(56, 21);
            this.txtgdSp.TabIndex = 1;
            // 
            // txtgdCp
            // 
            this.txtgdCp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdCp.BackColor = System.Drawing.Color.White;
            this.txtgdCp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdCp.Enabled = false;
            this.txtgdCp.ForeColor = System.Drawing.Color.Black;
            this.txtgdCp.Location = new System.Drawing.Point(198, 48);
            this.txtgdCp.Name = "txtgdCp";
            this.txtgdCp.Size = new System.Drawing.Size(55, 21);
            this.txtgdCp.TabIndex = 1;
            // 
            // txtgdVatcd
            // 
            this.txtgdVatcd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdVatcd.BackColor = System.Drawing.Color.White;
            this.txtgdVatcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdVatcd.Enabled = false;
            this.txtgdVatcd.ForeColor = System.Drawing.Color.Black;
            this.txtgdVatcd.Location = new System.Drawing.Point(88, 48);
            this.txtgdVatcd.Name = "txtgdVatcd";
            this.txtgdVatcd.Size = new System.Drawing.Size(55, 21);
            this.txtgdVatcd.TabIndex = 1;
            // 
            // txtgdUnit
            // 
            this.txtgdUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdUnit.BackColor = System.Drawing.Color.White;
            this.txtgdUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdUnit.Enabled = false;
            this.txtgdUnit.ForeColor = System.Drawing.Color.Black;
            this.txtgdUnit.Location = new System.Drawing.Point(712, 13);
            this.txtgdUnit.Name = "txtgdUnit";
            this.txtgdUnit.Size = new System.Drawing.Size(69, 21);
            this.txtgdUnit.TabIndex = 1;
            // 
            // txtgdProdNm
            // 
            this.txtgdProdNm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgdProdNm.BackColor = System.Drawing.Color.White;
            this.txtgdProdNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgdProdNm.ForeColor = System.Drawing.Color.Black;
            this.txtgdProdNm.Location = new System.Drawing.Point(88, 13);
            this.txtgdProdNm.Name = "txtgdProdNm";
            this.txtgdProdNm.Size = new System.Drawing.Size(117, 21);
            this.txtgdProdNm.TabIndex = 0;
            this.txtgdProdNm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgdProdNm_KeyDown);
            this.txtgdProdNm.Leave += new System.EventHandler(this.txtgdProdNm_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Desc:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Qty Rcvd:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Curr. Qty:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "S.P:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "C.P:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vat Code:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unit:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prod Code:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtgd);
            this.panel3.Controls.Add(this.txtgdsupcd);
            this.panel3.Controls.Add(this.txtInv);
            this.panel3.Controls.Add(this.txtSn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblsupnm);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 70);
            this.panel3.TabIndex = 0;
            // 
            // dtgd
            // 
            this.dtgd.CustomFormat = "dd-MMM-yyyy";
            this.dtgd.Enabled = false;
            this.dtgd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgd.Location = new System.Drawing.Point(332, 9);
            this.dtgd.Name = "dtgd";
            this.dtgd.Size = new System.Drawing.Size(140, 26);
            this.dtgd.TabIndex = 2;
            // 
            // txtgdsupcd
            // 
            this.txtgdsupcd.Location = new System.Drawing.Point(87, 38);
            this.txtgdsupcd.Name = "txtgdsupcd";
            this.txtgdsupcd.Size = new System.Drawing.Size(117, 26);
            this.txtgdsupcd.TabIndex = 2;
            this.txtgdsupcd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgdsupcd_KeyDown);
            this.txtgdsupcd.Leave += new System.EventHandler(this.txtgdsupcd_Leave);
            // 
            // txtInv
            // 
            this.txtInv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInv.Location = new System.Drawing.Point(663, 9);
            this.txtInv.Name = "txtInv";
            this.txtInv.Size = new System.Drawing.Size(117, 26);
            this.txtInv.TabIndex = 1;
            // 
            // txtSn
            // 
            this.txtSn.Location = new System.Drawing.Point(87, 9);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(117, 26);
            this.txtSn.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sup. Cd:";
            // 
            // lblsupnm
            // 
            this.lblsupnm.AutoSize = true;
            this.lblsupnm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsupnm.Location = new System.Drawing.Point(217, 41);
            this.lblsupnm.Name = "lblsupnm";
            this.lblsupnm.Size = new System.Drawing.Size(0, 20);
            this.lblsupnm.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inv No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial No.";
            // 
            // tbGoodIssue
            // 
            this.tbGoodIssue.Location = new System.Drawing.Point(4, 29);
            this.tbGoodIssue.Name = "tbGoodIssue";
            this.tbGoodIssue.Padding = new System.Windows.Forms.Padding(3);
            this.tbGoodIssue.Size = new System.Drawing.Size(808, 465);
            this.tbGoodIssue.TabIndex = 3;
            this.tbGoodIssue.Text = "Good Issue";
            this.tbGoodIssue.UseVisualStyleBackColor = true;
            // 
            // tblInvoice
            // 
            this.tblInvoice.Location = new System.Drawing.Point(4, 29);
            this.tblInvoice.Name = "tblInvoice";
            this.tblInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tblInvoice.Size = new System.Drawing.Size(808, 465);
            this.tblInvoice.TabIndex = 4;
            this.tblInvoice.Text = "Invoice";
            this.tblInvoice.UseVisualStyleBackColor = true;
            this.tblInvoice.Click += new System.EventHandler(this.tblCustomer_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 465);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProdCode
            // 
            this.ProdCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProdCode.HeaderText = "Prod Code";
            this.ProdCode.Name = "ProdCode";
            this.ProdCode.ReadOnly = true;
            this.ProdCode.Width = 120;
            // 
            // ProdDesc
            // 
            this.ProdDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdDesc.HeaderText = "Prod Desc";
            this.ProdDesc.Name = "ProdDesc";
            this.ProdDesc.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 80;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 70;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 70;
            // 
            // VatAmnt
            // 
            this.VatAmnt.HeaderText = "VatAmnt";
            this.VatAmnt.Name = "VatAmnt";
            this.VatAmnt.ReadOnly = true;
            this.VatAmnt.Width = 80;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 531);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmInventory";
            this.ShowInTaskbar = false;
            this.Text = "frmInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.tbControl.ResumeLayout(false);
            this.tbGoodReceive.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).EndInit();
            this.pnlgdproduct.ResumeLayout(false);
            this.pnlgdproduct.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage InventoryHome;
        private System.Windows.Forms.TabPage tbGoodReceive;
        private System.Windows.Forms.TabPage tbGoodIssue;
        private System.Windows.Forms.TabPage tblInvoice;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgdsupcd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsupnm;
        private System.Windows.Forms.TextBox txtInv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtgd;
        private System.Windows.Forms.Panel pnlgdproduct;
        private System.Windows.Forms.TextBox txtgdDesc;
        private System.Windows.Forms.TextBox txtgdProdNm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgdQty;
        private System.Windows.Forms.TextBox txtgdCuqty;
        private System.Windows.Forms.TextBox txtgdSp;
        private System.Windows.Forms.TextBox txtgdCp;
        private System.Windows.Forms.TextBox txtgdVatcd;
        private System.Windows.Forms.TextBox txtgdUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btngdclear;
        private System.Windows.Forms.Button btngdadd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvgd;
        private System.Windows.Forms.Button btngdCancel;
        private System.Windows.Forms.Button btngdPrint;
        private System.Windows.Forms.Button btngdSave;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btngdNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatAmnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}