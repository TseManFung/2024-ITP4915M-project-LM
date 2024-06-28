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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderDetail));
            this.groupBoxOrderOverview = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.lblPurchaseDateandTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.BtnDIset = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.groupBoxOrderOverview, "groupBoxOrderOverview");
            this.groupBoxOrderOverview.Name = "groupBoxOrderOverview";
            this.groupBoxOrderOverview.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.txtDateTime, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPurchaseDateandTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOrderNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDIset, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtOrderID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStatus, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnItem, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInvoice, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtDateTime
            // 
            resources.ApplyResources(this.txtDateTime, "txtDateTime");
            this.txtDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.ReadOnly = true;
            // 
            // lblPurchaseDateandTime
            // 
            resources.ApplyResources(this.lblPurchaseDateandTime, "lblPurchaseDateandTime");
            this.lblPurchaseDateandTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblPurchaseDateandTime.CausesValidation = false;
            this.lblPurchaseDateandTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPurchaseDateandTime.Name = "lblPurchaseDateandTime";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.CausesValidation = false;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Name = "lblStatus";
            // 
            // lblOrderNo
            // 
            resources.ApplyResources(this.lblOrderNo, "lblOrderNo");
            this.lblOrderNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrderNo.CausesValidation = false;
            this.lblOrderNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderNo.Name = "lblOrderNo";
            // 
            // BtnDIset
            // 
            resources.ApplyResources(this.BtnDIset, "BtnDIset");
            this.BtnDIset.Name = "BtnDIset";
            this.BtnDIset.UseVisualStyleBackColor = true;
            this.BtnDIset.Click += new System.EventHandler(this.btnDISet_Click);
            // 
            // txtOrderID
            // 
            resources.ApplyResources(this.txtOrderID, "txtOrderID");
            this.txtOrderID.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            // 
            // btnItem
            // 
            resources.ApplyResources(this.btnItem, "btnItem");
            this.btnItem.Name = "btnItem";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnOrderItemDetail_Click);
            // 
            // btnInvoice
            // 
            resources.ApplyResources(this.btnInvoice, "btnInvoice");
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // groupBoxDeliveryStatusandProductDetails
            // 
            this.groupBoxDeliveryStatusandProductDetails.Controls.Add(this.flowDeliveryStatusandProductDetails);
            resources.ApplyResources(this.groupBoxDeliveryStatusandProductDetails, "groupBoxDeliveryStatusandProductDetails");
            this.groupBoxDeliveryStatusandProductDetails.Name = "groupBoxDeliveryStatusandProductDetails";
            this.groupBoxDeliveryStatusandProductDetails.TabStop = false;
            // 
            // flowDeliveryStatusandProductDetails
            // 
            resources.ApplyResources(this.flowDeliveryStatusandProductDetails, "flowDeliveryStatusandProductDetails");
            this.flowDeliveryStatusandProductDetails.Name = "flowDeliveryStatusandProductDetails";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBoxOrderOverview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDeliveryStatusandProductDetails, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // frmOrderDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmOrderDetail";
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblPurchaseDateandTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button BtnDIset;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowDeliveryStatusandProductDetails;
    }
}