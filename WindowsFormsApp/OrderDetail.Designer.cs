namespace WindowsFormsApp
{
    partial class frmOrderDetail
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
            this.groupBoxOrderOverview = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPurchaseDateandTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.BtnDIset = new System.Windows.Forms.Button();
            this.groupBoxDeliveryStatusandProductDetails = new System.Windows.Forms.GroupBox();
            this.flowDeliveryStatusandProductDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOrderOverview.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxDeliveryStatusandProductDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOrderOverview
            // 
            this.groupBoxOrderOverview.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxOrderOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOrderOverview.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOrderOverview.Name = "groupBoxOrderOverview";
            this.groupBoxOrderOverview.Size = new System.Drawing.Size(1243, 165);
            this.groupBoxOrderOverview.TabIndex = 0;
            this.groupBoxOrderOverview.TabStop = false;
            this.groupBoxOrderOverview.Text = "Order Overview";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblPurchaseDateandTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOrderNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInvoice, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnDIset, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1237, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblPurchaseDateandTime
            // 
            this.lblPurchaseDateandTime.AutoSize = true;
            this.lblPurchaseDateandTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblPurchaseDateandTime.CausesValidation = false;
            this.lblPurchaseDateandTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPurchaseDateandTime.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPurchaseDateandTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPurchaseDateandTime.Location = new System.Drawing.Point(3, 94);
            this.lblPurchaseDateandTime.Name = "lblPurchaseDateandTime";
            this.lblPurchaseDateandTime.Size = new System.Drawing.Size(365, 32);
            this.lblPurchaseDateandTime.TabIndex = 23;
            this.lblPurchaseDateandTime.Text = "Purchase date and time :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.CausesValidation = false;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(3, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(365, 32);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status :";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrderNo.CausesValidation = false;
            this.lblOrderNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderNo.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderNo.Location = new System.Drawing.Point(3, 0);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(365, 32);
            this.lblOrderNo.TabIndex = 21;
            this.lblOrderNo.Text = "Order No. :";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnInvoice.Location = new System.Drawing.Point(992, 97);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(242, 42);
            this.btnInvoice.TabIndex = 24;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDIset
            // 
            this.BtnDIset.Font = new System.Drawing.Font("新細明體", 24F);
            this.BtnDIset.Location = new System.Drawing.Point(992, 50);
            this.BtnDIset.Name = "BtnDIset";
            this.BtnDIset.Size = new System.Drawing.Size(242, 41);
            this.BtnDIset.TabIndex = 25;
            this.BtnDIset.Text = "DI set";
            this.BtnDIset.UseVisualStyleBackColor = true;
            this.BtnDIset.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxDeliveryStatusandProductDetails
            // 
            this.groupBoxDeliveryStatusandProductDetails.Controls.Add(this.flowDeliveryStatusandProductDetails);
            this.groupBoxDeliveryStatusandProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDeliveryStatusandProductDetails.Location = new System.Drawing.Point(3, 174);
            this.groupBoxDeliveryStatusandProductDetails.Name = "groupBoxDeliveryStatusandProductDetails";
            this.groupBoxDeliveryStatusandProductDetails.Size = new System.Drawing.Size(1243, 395);
            this.groupBoxDeliveryStatusandProductDetails.TabIndex = 1;
            this.groupBoxDeliveryStatusandProductDetails.TabStop = false;
            this.groupBoxDeliveryStatusandProductDetails.Text = "Delivery Status and Product Details";
            // 
            // flowDeliveryStatusandProductDetails
            // 
            this.flowDeliveryStatusandProductDetails.AutoScroll = true;
            this.flowDeliveryStatusandProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDeliveryStatusandProductDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowDeliveryStatusandProductDetails.Location = new System.Drawing.Point(3, 18);
            this.flowDeliveryStatusandProductDetails.Name = "flowDeliveryStatusandProductDetails";
            this.flowDeliveryStatusandProductDetails.Size = new System.Drawing.Size(1237, 374);
            this.flowDeliveryStatusandProductDetails.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxOrderOverview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDeliveryStatusandProductDetails, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1249, 572);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmOrderDetail";
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            this.groupBoxOrderOverview.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxDeliveryStatusandProductDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOrderOverview;
        private System.Windows.Forms.GroupBox groupBoxDeliveryStatusandProductDetails;
        private System.Windows.Forms.FlowLayoutPanel flowDeliveryStatusandProductDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblPurchaseDateandTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button BtnDIset;
    }
}