namespace WindowsFormsApp
{
    partial class frmDeliveryStatusandProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryStatusandProductDetails));
            this.tableLayoutPanelDeliveryStatusandProductDetails = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.dgvRelatedSpareItem = new System.Windows.Forms.DataGridView();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblRelatedspare = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.tableLayoutPanelDeliveryStatusandProductDetails.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatedSpareItem)).BeginInit();
            this.groupBoxDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDeliveryStatusandProductDetails
            // 
            resources.ApplyResources(this.tableLayoutPanelDeliveryStatusandProductDetails, "tableLayoutPanelDeliveryStatusandProductDetails");
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.groupBoxStatus, 0, 2);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.dgvRelatedSpareItem, 0, 4);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.lblDelivery, 0, 0);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.groupBoxDate, 0, 1);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Name = "tableLayoutPanelDeliveryStatusandProductDetails";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.lblState);
            resources.ApplyResources(this.groupBoxStatus, "groupBoxStatus");
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.TabStop = false;
            // 
            // lblState
            // 
            resources.ApplyResources(this.lblState, "lblState");
            this.lblState.Name = "lblState";
            // 
            // dgvRelatedSpareItem
            // 
            this.dgvRelatedSpareItem.AllowUserToAddRows = false;
            this.dgvRelatedSpareItem.AllowUserToDeleteRows = false;
            this.dgvRelatedSpareItem.AllowUserToOrderColumns = true;
            this.dgvRelatedSpareItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelatedSpareItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRelatedSpareItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvRelatedSpareItem, "dgvRelatedSpareItem");
            this.dgvRelatedSpareItem.Name = "dgvRelatedSpareItem";
            this.dgvRelatedSpareItem.ReadOnly = true;
            this.dgvRelatedSpareItem.RowTemplate.Height = 24;
            this.dgvRelatedSpareItem.ShowCellToolTips = false;
            this.dgvRelatedSpareItem.ShowEditingIcon = false;
            // 
            // lblDelivery
            // 
            resources.ApplyResources(this.lblDelivery, "lblDelivery");
            this.lblDelivery.Name = "lblDelivery";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.lblDate);
            resources.ApplyResources(this.groupBoxDate, "groupBoxDate");
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.TabStop = false;
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblItems);
            this.panel1.Controls.Add(this.lblRelatedspare);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblItems
            // 
            resources.ApplyResources(this.lblItems, "lblItems");
            this.lblItems.Name = "lblItems";
            // 
            // lblRelatedspare
            // 
            resources.ApplyResources(this.lblRelatedspare, "lblRelatedspare");
            this.lblRelatedspare.Name = "lblRelatedspare";
            // 
            // btnInvoice
            // 
            resources.ApplyResources(this.btnInvoice, "btnInvoice");
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmDeliveryStatusandProductDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.tableLayoutPanelDeliveryStatusandProductDetails);
            this.Name = "frmDeliveryStatusandProductDetails";
            this.Load += new System.EventHandler(this.frmDeliveryStatusandProductDetails_Load);
            this.tableLayoutPanelDeliveryStatusandProductDetails.ResumeLayout(false);
            this.tableLayoutPanelDeliveryStatusandProductDetails.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatedSpareItem)).EndInit();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeliveryStatusandProductDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRelatedspare;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.DataGridView dgvRelatedSpareItem;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnInvoice;
    }
}