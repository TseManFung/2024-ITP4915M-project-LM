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
            this.tableLayoutPanelDeliveryStatusandProductDetails.ColumnCount = 1;
            this.tableLayoutPanelDeliveryStatusandProductDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.groupBoxStatus, 0, 2);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.dgvRelatedSpareItem, 0, 4);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.lblDelivery, 0, 0);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.groupBoxDate, 0, 1);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelDeliveryStatusandProductDetails.Name = "tableLayoutPanelDeliveryStatusandProductDetails";
            this.tableLayoutPanelDeliveryStatusandProductDetails.RowCount = 5;
            this.tableLayoutPanelDeliveryStatusandProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDeliveryStatusandProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDeliveryStatusandProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDeliveryStatusandProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDeliveryStatusandProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelDeliveryStatusandProductDetails.Size = new System.Drawing.Size(376, 412);
            this.tableLayoutPanelDeliveryStatusandProductDetails.TabIndex = 0;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.lblState);
            this.groupBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStatus.Location = new System.Drawing.Point(3, 126);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(370, 97);
            this.groupBoxStatus.TabIndex = 5;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblState.Location = new System.Drawing.Point(6, 18);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(73, 32);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State";
            // 
            // dgvRelatedSpareItem
            // 
            this.dgvRelatedSpareItem.AllowUserToAddRows = false;
            this.dgvRelatedSpareItem.AllowUserToDeleteRows = false;
            this.dgvRelatedSpareItem.AllowUserToOrderColumns = true;
            this.dgvRelatedSpareItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelatedSpareItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRelatedSpareItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatedSpareItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRelatedSpareItem.Location = new System.Drawing.Point(3, 270);
            this.dgvRelatedSpareItem.Name = "dgvRelatedSpareItem";
            this.dgvRelatedSpareItem.ReadOnly = true;
            this.dgvRelatedSpareItem.RowTemplate.Height = 24;
            this.dgvRelatedSpareItem.ShowCellToolTips = false;
            this.dgvRelatedSpareItem.ShowEditingIcon = false;
            this.dgvRelatedSpareItem.Size = new System.Drawing.Size(370, 139);
            this.dgvRelatedSpareItem.TabIndex = 6;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDelivery.Location = new System.Drawing.Point(3, 0);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(370, 12);
            this.lblDelivery.TabIndex = 1;
            this.lblDelivery.Text = "Delivery";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.lblDate);
            this.groupBoxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDate.Location = new System.Drawing.Point(3, 44);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(370, 76);
            this.groupBoxDate.TabIndex = 4;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Delivery date";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.Location = new System.Drawing.Point(6, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 32);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "1/1/1970";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblItems);
            this.panel1.Controls.Add(this.lblRelatedspare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 35);
            this.panel1.TabIndex = 6;
            // 
            // lblItems
            // 
            this.lblItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(321, 13);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(46, 12);
            this.lblItems.TabIndex = 1;
            this.lblItems.Text = "0 item(s)";
            // 
            // lblRelatedspare
            // 
            this.lblRelatedspare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRelatedspare.AutoSize = true;
            this.lblRelatedspare.Location = new System.Drawing.Point(10, 13);
            this.lblRelatedspare.Name = "lblRelatedspare";
            this.lblRelatedspare.Size = new System.Drawing.Size(84, 12);
            this.lblRelatedspare.TabIndex = 3;
            this.lblRelatedspare.Text = "Related Spare(s):";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.btnInvoice.Location = new System.Drawing.Point(224, 430);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(158, 44);
            this.btnInvoice.TabIndex = 52;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Visible = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmDeliveryStatusandProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 481);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.tableLayoutPanelDeliveryStatusandProductDetails);
            this.Name = "frmDeliveryStatusandProductDetails";
            this.Text = "DeliveryStatusandProductDetails";
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