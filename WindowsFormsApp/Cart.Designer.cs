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
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
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
            this.dgvSelectedSpare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedSpare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSelectedSpare.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectedSpare.Name = "dgvSelectedSpare";
            this.dgvSelectedSpare.RowTemplate.Height = 24;
            this.dgvSelectedSpare.Size = new System.Drawing.Size(1399, 294);
            this.dgvSelectedSpare.TabIndex = 0;
            this.dgvSelectedSpare.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSelectedSpareName_CellMouseClick);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearAll.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAll.Location = new System.Drawing.Point(284, 403);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(275, 58);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All Item";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(1180, 440);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(222, 58);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(846, 300);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(196, 32);
            this.lblTotalQuantity.TabIndex = 7;
            this.lblTotalQuantity.Text = "Total Quantity:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPrice, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvSelectedSpare, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYourOrderNo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalQuantity, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAll, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1405, 501);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(3, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 58);
            this.button1.TabIndex = 87;
            this.button1.Text = "Remove this Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReduce, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.number, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(284, 303);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(556, 94);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(403, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 78);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReduce
            // 
            this.btnReduce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReduce.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReduce.Location = new System.Drawing.Point(34, 3);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(117, 78);
            this.btnReduce.TabIndex = 86;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // number
            // 
            this.number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.number.Font = new System.Drawing.Font("PMingLiU", 36F);
            this.number.Location = new System.Drawing.Point(188, 14);
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
            this.number.Size = new System.Drawing.Size(179, 65);
            this.number.TabIndex = 88;
            this.number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtSpareID, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSelectedSpareName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(275, 94);
            this.tableLayoutPanel4.TabIndex = 85;
            // 
            // txtSpareID
            // 
            this.txtSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.txtSpareID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpareID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSpareID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSpareID.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSpareID.Location = new System.Drawing.Point(3, 50);
            this.txtSpareID.Multiline = true;
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.ReadOnly = true;
            this.txtSpareID.Size = new System.Drawing.Size(269, 41);
            this.txtSpareID.TabIndex = 47;
            // 
            // lblSelectedSpareName
            // 
            this.lblSelectedSpareName.AutoSize = true;
            this.lblSelectedSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedSpareName.CausesValidation = false;
            this.lblSelectedSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedSpareName.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelectedSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectedSpareName.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedSpareName.Name = "lblSelectedSpareName";
            this.lblSelectedSpareName.Size = new System.Drawing.Size(269, 47);
            this.lblSelectedSpareName.TabIndex = 50;
            this.lblSelectedSpareName.Text = "Selected Spare Name:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1127, 300);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(153, 32);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblYourOrderNo
            // 
            this.lblYourOrderNo.AutoSize = true;
            this.lblYourOrderNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYourOrderNo.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.lblYourOrderNo.Location = new System.Drawing.Point(565, 400);
            this.lblYourOrderNo.Name = "lblYourOrderNo";
            this.lblYourOrderNo.Size = new System.Drawing.Size(275, 64);
            this.lblYourOrderNo.TabIndex = 0;
            this.lblYourOrderNo.Text = "Your order no. (if any) :";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalQuantity.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalQuantity.Location = new System.Drawing.Point(846, 403);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Size = new System.Drawing.Size(275, 46);
            this.txtTotalQuantity.TabIndex = 86;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCart";
            this.Text = "Cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCart_FormClosing);
            this.Load += new System.EventHandler(this.frmCart_Load);
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
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button button1;
    }
}