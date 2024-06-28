namespace WindowsFormsApp
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.dgvSelectedSpare = new System.Windows.Forms.DataGridView();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpareID = new System.Windows.Forms.TextBox();
            this.lblSelectedSpareName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblYourOrderNo = new System.Windows.Forms.Label();
            this.txtDorderNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSpare)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSelectedSpare
            // 
            this.dgvSelectedSpare.AllowUserToAddRows = false;
            this.dgvSelectedSpare.AllowUserToDeleteRows = false;
            this.dgvSelectedSpare.AllowUserToResizeRows = false;
            this.dgvSelectedSpare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedSpare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSelectedSpare, 5);
            resources.ApplyResources(this.dgvSelectedSpare, "dgvSelectedSpare");
            this.dgvSelectedSpare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSelectedSpare.MultiSelect = false;
            this.dgvSelectedSpare.Name = "dgvSelectedSpare";
            this.dgvSelectedSpare.RowHeadersVisible = false;
            this.dgvSelectedSpare.RowTemplate.Height = 24;
            this.dgvSelectedSpare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedSpare.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSelectedSpareName_CellMouseClick);
            // 
            // btnClearAll
            // 
            resources.ApplyResources(this.btnClearAll, "btnClearAll");
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTotalQuantity
            // 
            resources.ApplyResources(this.lblTotalQuantity, "lblTotalQuantity");
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPrice, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvSelectedSpare, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYourOrderNo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDorderNumber, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAll, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReduce, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.number, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReduce
            // 
            resources.ApplyResources(this.btnReduce, "btnReduce");
            this.btnReduce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // number
            // 
            resources.ApplyResources(this.number, "number");
            this.number.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtSpareID, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSelectedSpareName, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtSpareID
            // 
            this.txtSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.txtSpareID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpareID.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtSpareID, "txtSpareID");
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.ReadOnly = true;
            // 
            // lblSelectedSpareName
            // 
            resources.ApplyResources(this.lblSelectedSpareName, "lblSelectedSpareName");
            this.lblSelectedSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedSpareName.CausesValidation = false;
            this.lblSelectedSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectedSpareName.Name = "lblSelectedSpareName";
            // 
            // lblTotalPrice
            // 
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.Name = "lblTotalPrice";
            // 
            // lblYourOrderNo
            // 
            resources.ApplyResources(this.lblYourOrderNo, "lblYourOrderNo");
            this.lblYourOrderNo.Name = "lblYourOrderNo";
            // 
            // txtDorderNumber
            // 
            resources.ApplyResources(this.txtDorderNumber, "txtDorderNumber");
            this.txtDorderNumber.Name = "txtDorderNumber";
            // 
            // frmCart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCart";
            this.Load += new System.EventHandler(this.frmCart_Load);
            this.Leave += new System.EventHandler(this.frmCart_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSpare)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectedSpare;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtSpareID;
        private System.Windows.Forms.Label lblSelectedSpareName;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblYourOrderNo;
        private System.Windows.Forms.TextBox txtDorderNumber;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button button1;
    }
}