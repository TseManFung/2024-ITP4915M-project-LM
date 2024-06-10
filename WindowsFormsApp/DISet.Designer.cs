namespace WindowsFormsApp
{
    partial class frmDISet
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOrderSerial = new System.Windows.Forms.TextBox();
            this.lblOrderSerial = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDealerOrderNo = new System.Windows.Forms.TextBox();
            this.lblDealerOrderNo = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInvoiceName = new System.Windows.Forms.TextBox();
            this.lblInvoiceName = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInvoiceAddress = new System.Windows.Forms.TextBox();
            this.lblInvoiceAddress = new System.Windows.Forms.Label();
            this.btnExportasPDF = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExportasPDF, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 587);
            this.tableLayoutPanel1.TabIndex = 94;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtDate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(203, 82);
            this.tableLayoutPanel4.TabIndex = 86;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Info;
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDate.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(3, 44);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(197, 35);
            this.txtDate.TabIndex = 47;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDate.CausesValidation = false;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(197, 41);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtOrderSerial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOrderSerial, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(203, 82);
            this.tableLayoutPanel2.TabIndex = 87;
            // 
            // txtOrderSerial
            // 
            this.txtOrderSerial.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrderSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOrderSerial.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderSerial.Location = new System.Drawing.Point(3, 44);
            this.txtOrderSerial.Multiline = true;
            this.txtOrderSerial.Name = "txtOrderSerial";
            this.txtOrderSerial.ReadOnly = true;
            this.txtOrderSerial.Size = new System.Drawing.Size(197, 35);
            this.txtOrderSerial.TabIndex = 47;
            // 
            // lblOrderSerial
            // 
            this.lblOrderSerial.AutoSize = true;
            this.lblOrderSerial.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrderSerial.CausesValidation = false;
            this.lblOrderSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderSerial.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderSerial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderSerial.Location = new System.Drawing.Point(3, 0);
            this.lblOrderSerial.Name = "lblOrderSerial";
            this.lblOrderSerial.Size = new System.Drawing.Size(197, 41);
            this.lblOrderSerial.TabIndex = 50;
            this.lblOrderSerial.Text = "Order Serial:";
            this.lblOrderSerial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtDealerOrderNo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDealerOrderNo, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(203, 82);
            this.tableLayoutPanel3.TabIndex = 88;
            // 
            // txtDealerOrderNo
            // 
            this.txtDealerOrderNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtDealerOrderNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDealerOrderNo.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDealerOrderNo.Location = new System.Drawing.Point(3, 44);
            this.txtDealerOrderNo.Multiline = true;
            this.txtDealerOrderNo.Name = "txtDealerOrderNo";
            this.txtDealerOrderNo.ReadOnly = true;
            this.txtDealerOrderNo.Size = new System.Drawing.Size(197, 35);
            this.txtDealerOrderNo.TabIndex = 47;
            // 
            // lblDealerOrderNo
            // 
            this.lblDealerOrderNo.AutoSize = true;
            this.lblDealerOrderNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblDealerOrderNo.CausesValidation = false;
            this.lblDealerOrderNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDealerOrderNo.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDealerOrderNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDealerOrderNo.Location = new System.Drawing.Point(3, 0);
            this.lblDealerOrderNo.Name = "lblDealerOrderNo";
            this.lblDealerOrderNo.Size = new System.Drawing.Size(197, 41);
            this.lblDealerOrderNo.TabIndex = 50;
            this.lblDealerOrderNo.Text = "Dealer Order No. :";
            this.lblDealerOrderNo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtInvoiceName, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblInvoiceName, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(212, 91);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(203, 82);
            this.tableLayoutPanel5.TabIndex = 89;
            // 
            // txtInvoiceName
            // 
            this.txtInvoiceName.BackColor = System.Drawing.SystemColors.Info;
            this.txtInvoiceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInvoiceName.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInvoiceName.Location = new System.Drawing.Point(3, 44);
            this.txtInvoiceName.Multiline = true;
            this.txtInvoiceName.Name = "txtInvoiceName";
            this.txtInvoiceName.ReadOnly = true;
            this.txtInvoiceName.Size = new System.Drawing.Size(197, 35);
            this.txtInvoiceName.TabIndex = 47;
            // 
            // lblInvoiceName
            // 
            this.lblInvoiceName.AutoSize = true;
            this.lblInvoiceName.BackColor = System.Drawing.SystemColors.Control;
            this.lblInvoiceName.CausesValidation = false;
            this.lblInvoiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceName.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInvoiceName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInvoiceName.Location = new System.Drawing.Point(3, 0);
            this.lblInvoiceName.Name = "lblInvoiceName";
            this.lblInvoiceName.Size = new System.Drawing.Size(197, 41);
            this.lblInvoiceName.TabIndex = 50;
            this.lblInvoiceName.Text = "Invoice Name:";
            this.lblInvoiceName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.txtDeliveryAddress, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblDeliveryAddress, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(421, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(412, 82);
            this.tableLayoutPanel6.TabIndex = 90;
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtDeliveryAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDeliveryAddress.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(3, 44);
            this.txtDeliveryAddress.Multiline = true;
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.ReadOnly = true;
            this.txtDeliveryAddress.Size = new System.Drawing.Size(406, 35);
            this.txtDeliveryAddress.TabIndex = 47;
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblDeliveryAddress.CausesValidation = false;
            this.lblDeliveryAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeliveryAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(3, 0);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(406, 41);
            this.lblDeliveryAddress.TabIndex = 50;
            this.lblDeliveryAddress.Text = "Delivery Address:";
            this.lblDeliveryAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.txtInvoiceAddress, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblInvoiceAddress, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(421, 91);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(412, 82);
            this.tableLayoutPanel7.TabIndex = 91;
            // 
            // txtInvoiceAddress
            // 
            this.txtInvoiceAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtInvoiceAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInvoiceAddress.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInvoiceAddress.Location = new System.Drawing.Point(3, 44);
            this.txtInvoiceAddress.Multiline = true;
            this.txtInvoiceAddress.Name = "txtInvoiceAddress";
            this.txtInvoiceAddress.ReadOnly = true;
            this.txtInvoiceAddress.Size = new System.Drawing.Size(406, 35);
            this.txtInvoiceAddress.TabIndex = 47;
            // 
            // lblInvoiceAddress
            // 
            this.lblInvoiceAddress.AutoSize = true;
            this.lblInvoiceAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblInvoiceAddress.CausesValidation = false;
            this.lblInvoiceAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceAddress.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInvoiceAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInvoiceAddress.Location = new System.Drawing.Point(3, 0);
            this.lblInvoiceAddress.Name = "lblInvoiceAddress";
            this.lblInvoiceAddress.Size = new System.Drawing.Size(406, 41);
            this.lblInvoiceAddress.TabIndex = 50;
            this.lblInvoiceAddress.Text = "Invoice Address:";
            this.lblInvoiceAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnExportasPDF
            // 
            this.btnExportasPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportasPDF.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.btnExportasPDF.Location = new System.Drawing.Point(630, 179);
            this.btnExportasPDF.Name = "btnExportasPDF";
            this.btnExportasPDF.Size = new System.Drawing.Size(203, 52);
            this.btnExportasPDF.TabIndex = 92;
            this.btnExportasPDF.Text = "Export as PDF";
            this.btnExportasPDF.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 237);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(830, 347);
            this.flowLayoutPanel1.TabIndex = 93;
            // 
            // frmDISet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDISet";
            this.Text = "Despatch Instruction Set";
            this.Load += new System.EventHandler(this.frmDISet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtOrderSerial;
        private System.Windows.Forms.Label lblOrderSerial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtDealerOrderNo;
        private System.Windows.Forms.Label lblDealerOrderNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtInvoiceName;
        private System.Windows.Forms.Label lblInvoiceName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtInvoiceAddress;
        private System.Windows.Forms.Label lblInvoiceAddress;
        private System.Windows.Forms.Button btnExportasPDF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}