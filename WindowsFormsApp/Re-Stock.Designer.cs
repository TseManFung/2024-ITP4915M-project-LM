namespace WindowsFormsApp
{
    partial class frmReStock
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
            this.dgvItemFollowingROL = new System.Windows.Forms.DataGridView();
            this.lblItemFollowingROL = new System.Windows.Forms.Label();
            this.lblReStock = new System.Windows.Forms.Label();
            this.dgvRestock = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMovedown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnReStockConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemFollowingROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemFollowingROL
            // 
            this.dgvItemFollowingROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvItemFollowingROL, 5);
            this.dgvItemFollowingROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemFollowingROL.Location = new System.Drawing.Point(3, 31);
            this.dgvItemFollowingROL.Name = "dgvItemFollowingROL";
            this.dgvItemFollowingROL.RowTemplate.Height = 24;
            this.dgvItemFollowingROL.Size = new System.Drawing.Size(1094, 218);
            this.dgvItemFollowingROL.TabIndex = 72;
            this.dgvItemFollowingROL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemFollowingROL_CellContentClick);
            // 
            // lblItemFollowingROL
            // 
            this.lblItemFollowingROL.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblItemFollowingROL, 5);
            this.lblItemFollowingROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemFollowingROL.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblItemFollowingROL.Location = new System.Drawing.Point(3, 0);
            this.lblItemFollowingROL.Name = "lblItemFollowingROL";
            this.lblItemFollowingROL.Size = new System.Drawing.Size(1094, 28);
            this.lblItemFollowingROL.TabIndex = 73;
            this.lblItemFollowingROL.Text = "The following items have arrived in ROL:";
            this.lblItemFollowingROL.Click += new System.EventHandler(this.lblFollowingROL_Click);
            // 
            // lblReStock
            // 
            this.lblReStock.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblReStock, 5);
            this.lblReStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReStock.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblReStock.Location = new System.Drawing.Point(3, 308);
            this.lblReStock.Name = "lblReStock";
            this.lblReStock.Size = new System.Drawing.Size(1094, 28);
            this.lblReStock.TabIndex = 74;
            this.lblReStock.Text = "Restock:";
            // 
            // dgvRestock
            // 
            this.dgvRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvRestock, 5);
            this.dgvRestock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRestock.Location = new System.Drawing.Point(3, 339);
            this.dgvRestock.Name = "dgvRestock";
            this.dgvRestock.RowTemplate.Height = 24;
            this.dgvRestock.Size = new System.Drawing.Size(1094, 162);
            this.dgvRestock.TabIndex = 75;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnConfirm.Location = new System.Drawing.Point(1379, 864);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(287, 79);
            this.btnConfirm.TabIndex = 76;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btnMovedown, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblItemFollowingROL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveUp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvItemFollowingROL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvRestock, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblReStock, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnReStockConfirm, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 561);
            this.tableLayoutPanel1.TabIndex = 77;
            // 
            // btnMovedown
            // 
            this.btnMovedown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovedown.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnMovedown.Location = new System.Drawing.Point(718, 255);
            this.btnMovedown.Name = "btnMovedown";
            this.btnMovedown.Size = new System.Drawing.Size(49, 50);
            this.btnMovedown.TabIndex = 79;
            this.btnMovedown.Text = "↓";
            this.btnMovedown.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveUp.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnMoveUp.Location = new System.Drawing.Point(333, 255);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(49, 50);
            this.btnMoveUp.TabIndex = 78;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnReStockConfirm
            // 
            this.btnReStockConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReStockConfirm.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnReStockConfirm.Location = new System.Drawing.Point(773, 507);
            this.btnReStockConfirm.Name = "btnReStockConfirm";
            this.btnReStockConfirm.Size = new System.Drawing.Size(324, 51);
            this.btnReStockConfirm.TabIndex = 80;
            this.btnReStockConfirm.Text = "Confirm";
            this.btnReStockConfirm.UseVisualStyleBackColor = true;
            // 
            // frmReStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmReStock";
            this.Text = "Re-stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemFollowingROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItemFollowingROL;
        private System.Windows.Forms.Label lblItemFollowingROL;
        private System.Windows.Forms.Label lblReStock;
        private System.Windows.Forms.DataGridView dgvRestock;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMovedown;
        private System.Windows.Forms.Button btnReStockConfirm;
    }
}