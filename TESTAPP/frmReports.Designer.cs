
namespace SHOPLITE
{
    partial class frmReports
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
            this.mainpnl = new System.Windows.Forms.Panel();
            this.btnPrcChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrcChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 0;
            // 
            // mainpnl
            // 
            this.mainpnl.BackColor = System.Drawing.Color.Transparent;
            this.mainpnl.Location = new System.Drawing.Point(210, 127);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(476, 358);
            this.mainpnl.TabIndex = 1;
            // 
            // btnPrcChange
            // 
            this.btnPrcChange.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPrcChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrcChange.Location = new System.Drawing.Point(12, 12);
            this.btnPrcChange.Name = "btnPrcChange";
            this.btnPrcChange.Size = new System.Drawing.Size(110, 39);
            this.btnPrcChange.TabIndex = 0;
            this.btnPrcChange.Text = "Price Change";
            this.btnPrcChange.UseVisualStyleBackColor = true;
            this.btnPrcChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.mainpnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReports";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpnl;
        private System.Windows.Forms.Button btnPrcChange;
    }
}