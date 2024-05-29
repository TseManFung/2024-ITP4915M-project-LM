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
            this.dgvSelectedSpareName = new System.Windows.Forms.DataGridView();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpareName = new System.Windows.Forms.TextBox();
            this.lblSelectedSpareName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblYourOrderNo = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSpareName)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSelectedSpareName
            // 
            this.dgvSelectedSpareName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSelectedSpareName, 5);
            this.dgvSelectedSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedSpareName.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectedSpareName.Name = "dgvSelectedSpareName";
            this.dgvSelectedSpareName.RowTemplate.Height = 24;
            this.dgvSelectedSpareName.Size = new System.Drawing.Size(1399, 294);
            this.dgvSelectedSpareName.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAll.Location = new System.Drawing.Point(3, 403);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(222, 58);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All Item";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(1127, 403);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(222, 58);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPrice, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvSelectedSpareName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAll, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYourOrderNo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalQuantity, 3, 2);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReduce, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(284, 303);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(275, 94);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(153, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 78);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReduce
            // 
            this.btnReduce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReduce.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReduce.Location = new System.Drawing.Point(3, 3);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(117, 78);
            this.btnReduce.TabIndex = 86;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtSpareName, 0, 1);
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
            // txtSpareName
            // 
            this.txtSpareName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSpareName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSpareName.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSpareName.Location = new System.Drawing.Point(3, 50);
            this.txtSpareName.Multiline = true;
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.ReadOnly = true;
            this.txtSpareName.Size = new System.Drawing.Size(269, 41);
            this.txtSpareName.TabIndex = 47;
            // 
            // lblSelectedSpareName
            // 
            this.lblSelectedSpareName.AutoSize = true;
            this.lblSelectedSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedSpareName.CausesValidation = false;
            this.lblSelectedSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedSpareName.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.lblTotalPrice.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.lblYourOrderNo.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblYourOrderNo.Location = new System.Drawing.Point(565, 400);
            this.lblYourOrderNo.Name = "lblYourOrderNo";
            this.lblYourOrderNo.Size = new System.Drawing.Size(275, 64);
            this.lblYourOrderNo.TabIndex = 0;
            this.lblYourOrderNo.Text = "Your order no. (if any) :";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalQuantity.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSpareName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectedSpareName;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtSpareName;
        private System.Windows.Forms.Label lblSelectedSpareName;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblYourOrderNo;
        private System.Windows.Forms.TextBox txtTotalQuantity;
    }
}