namespace WindowsFormsApp
{
    partial class frmPlacingOrder
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSelectedSpareName = new System.Windows.Forms.TextBox();
            this.lblSelectedSpareName = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvPlacingOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSpareID = new System.Windows.Forms.ComboBox();
            this.comboBoxSpareName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacingOrder)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCategoryType
            // 
            this.comboBoxCategoryType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategoryType.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.Location = new System.Drawing.Point(247, 151);
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            this.comboBoxCategoryType.Size = new System.Drawing.Size(449, 40);
            this.comboBoxCategoryType.TabIndex = 25;
            // 
            // lblCategoryType
            // 
            this.lblCategoryType.AutoSize = true;
            this.lblCategoryType.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategoryType.CausesValidation = false;
            this.lblCategoryType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoryType.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold);
            this.lblCategoryType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoryType.Location = new System.Drawing.Point(3, 148);
            this.lblCategoryType.Name = "lblCategoryType";
            this.lblCategoryType.Size = new System.Drawing.Size(238, 32);
            this.lblCategoryType.TabIndex = 22;
            this.lblCategoryType.Text = "Category Type:";
            // 
            // lblSpareName
            // 
            this.lblSpareName.AutoSize = true;
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSpareName.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold);
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Location = new System.Drawing.Point(3, 74);
            this.lblSpareName.Name = "lblSpareName";
            this.lblSpareName.Size = new System.Drawing.Size(238, 32);
            this.lblSpareName.TabIndex = 21;
            this.lblSpareName.Text = "SpareName:";
            // 
            // lblSpareID
            // 
            this.lblSpareID.AutoSize = true;
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSpareID.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Location = new System.Drawing.Point(3, 0);
            this.lblSpareID.Name = "lblSpareID";
            this.lblSpareID.Size = new System.Drawing.Size(238, 32);
            this.lblSpareID.TabIndex = 20;
            this.lblSpareID.Text = "SpareID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(559, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 78);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnViewCart
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnViewCart, 2);
            this.btnViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewCart.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCart.Location = new System.Drawing.Point(3, 433);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(1404, 102);
            this.btnViewCart.TabIndex = 32;
            this.btnViewCart.Text = "View cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnConfirm
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnConfirm, 5);
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfirm.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.btnConfirm.Location = new System.Drawing.Point(3, 339);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(693, 64);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "Add to Cart";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnReduce
            // 
            this.btnReduce.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReduce.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReduce.Location = new System.Drawing.Point(281, 255);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(133, 78);
            this.btnReduce.TabIndex = 34;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtSelectedSpareName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSelectedSpareName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvPlacingOrder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReduce, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(708, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 424);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // txtSelectedSpareName
            // 
            this.txtSelectedSpareName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSelectedSpareName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSelectedSpareName.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSelectedSpareName.Location = new System.Drawing.Point(142, 255);
            this.txtSelectedSpareName.Multiline = true;
            this.txtSelectedSpareName.Name = "txtSelectedSpareName";
            this.txtSelectedSpareName.ReadOnly = true;
            this.txtSelectedSpareName.Size = new System.Drawing.Size(133, 45);
            this.txtSelectedSpareName.TabIndex = 52;
            // 
            // lblSelectedSpareName
            // 
            this.lblSelectedSpareName.AutoSize = true;
            this.lblSelectedSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedSpareName.CausesValidation = false;
            this.lblSelectedSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedSpareName.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelectedSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectedSpareName.Location = new System.Drawing.Point(3, 252);
            this.lblSelectedSpareName.Name = "lblSelectedSpareName";
            this.lblSelectedSpareName.Size = new System.Drawing.Size(133, 84);
            this.lblSelectedSpareName.TabIndex = 51;
            this.lblSelectedSpareName.Text = "Selected Spare Name:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantity.Font = new System.Drawing.Font("PMingLiU", 45F);
            this.txtQuantity.Location = new System.Drawing.Point(420, 255);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(133, 79);
            this.txtQuantity.TabIndex = 36;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPlacingOrder
            // 
            this.dgvPlacingOrder.AllowUserToAddRows = false;
            this.dgvPlacingOrder.AllowUserToDeleteRows = false;
            this.dgvPlacingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvPlacingOrder, 5);
            this.dgvPlacingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlacingOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvPlacingOrder.Name = "dgvPlacingOrder";
            this.dgvPlacingOrder.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvPlacingOrder, 3);
            this.dgvPlacingOrder.RowTemplate.Height = 24;
            this.dgvPlacingOrder.Size = new System.Drawing.Size(693, 246);
            this.dgvPlacingOrder.TabIndex = 37;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSpareID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSpareName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSpareName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCategoryType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCategoryType, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 297);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // comboBoxSpareID
            // 
            this.comboBoxSpareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSpareID.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSpareID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Location = new System.Drawing.Point(247, 3);
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            this.comboBoxSpareID.Size = new System.Drawing.Size(449, 40);
            this.comboBoxSpareID.TabIndex = 28;
            // 
            // comboBoxSpareName
            // 
            this.comboBoxSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSpareName.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSpareName.FormattingEnabled = true;
            this.comboBoxSpareName.Location = new System.Drawing.Point(247, 77);
            this.comboBoxSpareName.Name = "comboBoxSpareName";
            this.comboBoxSpareName.Size = new System.Drawing.Size(449, 40);
            this.comboBoxSpareName.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSearch, 2);
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.btnSearch.Location = new System.Drawing.Point(3, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(693, 42);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnViewCart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1410, 538);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // frmPlacingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 538);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmPlacingOrder";
            this.Text = "Placing Order";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacingOrder)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBoxCategoryType;
        private System.Windows.Forms.Label lblCategoryType;
        private System.Windows.Forms.Label lblSpareName;
        private System.Windows.Forms.Label lblSpareID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvPlacingOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSelectedSpareName;
        private System.Windows.Forms.TextBox txtSelectedSpareName;
        public System.Windows.Forms.ComboBox comboBoxSpareID;
        public System.Windows.Forms.ComboBox comboBoxSpareName;
    }
}