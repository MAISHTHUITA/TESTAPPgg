
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
            this.btnGrn = new System.Windows.Forms.Button();
            this.mainpnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGrn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnGrn
            // 
            this.btnGrn.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrn.Location = new System.Drawing.Point(19, 8);
            this.btnGrn.Name = "btnGrn";
            this.btnGrn.Size = new System.Drawing.Size(75, 43);
            this.btnGrn.TabIndex = 0;
            this.btnGrn.Text = "Good Receive";
            this.btnGrn.UseVisualStyleBackColor = false;
            this.btnGrn.Click += new System.EventHandler(this.btnGrn_Click);
            // 
            // mainpnl
            // 
            this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpnl.Location = new System.Drawing.Point(0, 58);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(816, 473);
            this.mainpnl.TabIndex = 1;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 531);
            this.Controls.Add(this.mainpnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmInventory";
            this.ShowInTaskbar = false;
            this.Text = "frmInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGrn;
        private System.Windows.Forms.Panel mainpnl;
    }
}