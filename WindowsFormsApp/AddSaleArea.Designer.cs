namespace WindowsFormsApp
{
    partial class frmAddSaleArea
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblSpareLocation = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel11, 5);
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.txtRemark, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.lblRemark, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(794, 101);
            this.tableLayoutPanel11.TabIndex = 91;
            // 
            // txtRemark
            // 
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRemark.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRemark.Location = new System.Drawing.Point(3, 53);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(788, 45);
            this.txtRemark.TabIndex = 80;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.BackColor = System.Drawing.SystemColors.Control;
            this.lblRemark.CausesValidation = false;
            this.lblRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemark.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRemark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemark.Location = new System.Drawing.Point(3, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(788, 50);
            this.lblRemark.TabIndex = 81;
            this.lblRemark.Text = "Remark:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 5);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtLocation, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSpareLocation, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 101);
            this.tableLayoutPanel3.TabIndex = 83;
            // 
            // txtLocation
            // 
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLocation.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLocation.Location = new System.Drawing.Point(3, 53);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(788, 45);
            this.txtLocation.TabIndex = 81;
            // 
            // lblSpareLocation
            // 
            this.lblSpareLocation.AutoSize = true;
            this.lblSpareLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareLocation.CausesValidation = false;
            this.lblSpareLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpareLocation.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareLocation.Location = new System.Drawing.Point(3, 0);
            this.lblSpareLocation.Name = "lblSpareLocation";
            this.lblSpareLocation.Size = new System.Drawing.Size(788, 50);
            this.lblSpareLocation.TabIndex = 48;
            this.lblSpareLocation.Text = "Location:";
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("新細明體", 32F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(483, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 62);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("新細明體", 32F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(163, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 62);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAddSaleArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAddSaleArea";
            this.Text = "Add SaleArea";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSpareLocation;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLocation;
    }
}