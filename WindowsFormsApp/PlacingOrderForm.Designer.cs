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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlacingOrder));
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.tlpSelectSpace = new System.Windows.Forms.TableLayoutPanel();
            this.txtSelectedSpareName = new System.Windows.Forms.TextBox();
            this.lblSelectedSpareName = new System.Windows.Forms.Label();
            this.dgvPlacingOrder = new System.Windows.Forms.DataGridView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSpareID = new System.Windows.Forms.ComboBox();
            this.comboBoxSpareName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSelectSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacingOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCategoryType
            // 
            resources.ApplyResources(this.comboBoxCategoryType, "comboBoxCategoryType");
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.Items.AddRange(new object[] {
            resources.GetString("comboBoxCategoryType.Items"),
            resources.GetString("comboBoxCategoryType.Items1"),
            resources.GetString("comboBoxCategoryType.Items2"),
            resources.GetString("comboBoxCategoryType.Items3")});
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            // 
            // lblCategoryType
            // 
            resources.ApplyResources(this.lblCategoryType, "lblCategoryType");
            this.lblCategoryType.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategoryType.CausesValidation = false;
            this.lblCategoryType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoryType.Name = "lblCategoryType";
            // 
            // lblSpareName
            // 
            resources.ApplyResources(this.lblSpareName, "lblSpareName");
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Name = "lblSpareName";
            // 
            // lblSpareID
            // 
            resources.ApplyResources(this.lblSpareID, "lblSpareID");
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Name = "lblSpareID";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewCart
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnViewCart, 2);
            resources.ApplyResources(this.btnViewCart, "btnViewCart");
            this.btnViewCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnConfirm
            // 
            this.tlpSelectSpace.SetColumnSpan(this.btnConfirm, 5);
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReduce
            // 
            resources.ApplyResources(this.btnReduce, "btnReduce");
            this.btnReduce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // tlpSelectSpace
            // 
            resources.ApplyResources(this.tlpSelectSpace, "tlpSelectSpace");
            this.tlpSelectSpace.Controls.Add(this.txtSelectedSpareName, 1, 3);
            this.tlpSelectSpace.Controls.Add(this.lblSelectedSpareName, 0, 3);
            this.tlpSelectSpace.Controls.Add(this.btnConfirm, 0, 4);
            this.tlpSelectSpace.Controls.Add(this.dgvPlacingOrder, 0, 0);
            this.tlpSelectSpace.Controls.Add(this.btnReduce, 2, 3);
            this.tlpSelectSpace.Controls.Add(this.btnAdd, 4, 3);
            this.tlpSelectSpace.Controls.Add(this.numQuantity, 3, 3);
            this.tlpSelectSpace.Name = "tlpSelectSpace";
            // 
            // txtSelectedSpareName
            // 
            this.txtSelectedSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSelectedSpareName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectedSpareName.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtSelectedSpareName, "txtSelectedSpareName");
            this.txtSelectedSpareName.Name = "txtSelectedSpareName";
            this.txtSelectedSpareName.ReadOnly = true;
            this.txtSelectedSpareName.TextChanged += new System.EventHandler(this.txtSelectedSpareName_TextChanged);
            // 
            // lblSelectedSpareName
            // 
            resources.ApplyResources(this.lblSelectedSpareName, "lblSelectedSpareName");
            this.lblSelectedSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedSpareName.CausesValidation = false;
            this.lblSelectedSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectedSpareName.Name = "lblSelectedSpareName";
            this.lblSelectedSpareName.Click += new System.EventHandler(this.lblSelectedSpareName_Click);
            // 
            // dgvPlacingOrder
            // 
            this.dgvPlacingOrder.AllowUserToAddRows = false;
            this.dgvPlacingOrder.AllowUserToDeleteRows = false;
            this.dgvPlacingOrder.AllowUserToResizeRows = false;
            this.dgvPlacingOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlacingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpSelectSpace.SetColumnSpan(this.dgvPlacingOrder, 5);
            resources.ApplyResources(this.dgvPlacingOrder, "dgvPlacingOrder");
            this.dgvPlacingOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlacingOrder.MultiSelect = false;
            this.dgvPlacingOrder.Name = "dgvPlacingOrder";
            this.dgvPlacingOrder.ReadOnly = true;
            this.dgvPlacingOrder.RowHeadersVisible = false;
            this.tlpSelectSpace.SetRowSpan(this.dgvPlacingOrder, 3);
            this.dgvPlacingOrder.RowTemplate.Height = 24;
            this.dgvPlacingOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlacingOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlacingOrder_CellContentClick);
            this.dgvPlacingOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlacingOrder_CellMouseClick);
            // 
            // numQuantity
            // 
            resources.ApplyResources(this.numQuantity, "numQuantity");
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSpareID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSpareName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSpareName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCategoryType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCategoryType, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // comboBoxSpareID
            // 
            this.comboBoxSpareID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSpareID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxSpareID, "comboBoxSpareID");
            this.comboBoxSpareID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            // 
            // comboBoxSpareName
            // 
            this.comboBoxSpareName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSpareName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxSpareName, "comboBoxSpareName");
            this.comboBoxSpareName.FormattingEnabled = true;
            this.comboBoxSpareName.Name = "comboBoxSpareName";
            this.comboBoxSpareName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpareName_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSearch, 2);
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.btnViewCart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tlpSelectSpace, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // frmPlacingOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmPlacingOrder";
            this.Load += new System.EventHandler(this.frmPlacingOrder_Load);
            this.tlpSelectSpace.ResumeLayout(false);
            this.tlpSelectSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacingOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpSelectSpace;
        private System.Windows.Forms.DataGridView dgvPlacingOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSelectedSpareName;
        private System.Windows.Forms.TextBox txtSelectedSpareName;
        public System.Windows.Forms.ComboBox comboBoxSpareID;
        public System.Windows.Forms.ComboBox comboBoxSpareName;
        private System.Windows.Forms.NumericUpDown numQuantity;
    }
}