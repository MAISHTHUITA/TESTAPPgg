
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.InventoryHome = new System.Windows.Forms.TabPage();
            this.tbGoodReceive = new System.Windows.Forms.TabPage();
            this.tbGoodIssue = new System.Windows.Forms.TabPage();
            this.tblInvoice = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbControl.SuspendLayout();
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
            this.tbGoodReceive.Location = new System.Drawing.Point(4, 29);
            this.tbGoodReceive.Name = "tbGoodReceive";
            this.tbGoodReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tbGoodReceive.Size = new System.Drawing.Size(808, 465);
            this.tbGoodReceive.TabIndex = 2;
            this.tbGoodReceive.Text = "Good Receive";
            this.tbGoodReceive.UseVisualStyleBackColor = true;
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
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 531);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventory";
            this.ShowInTaskbar = false;
            this.Text = "frmInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.tbControl.ResumeLayout(false);
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
    }
}