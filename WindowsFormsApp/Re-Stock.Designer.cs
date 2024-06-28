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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReStock));
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
            this.dgvItemFollowingROL.AllowUserToAddRows = false;
            this.dgvItemFollowingROL.AllowUserToDeleteRows = false;
            this.dgvItemFollowingROL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemFollowingROL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvItemFollowingROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvItemFollowingROL, 5);
            resources.ApplyResources(this.dgvItemFollowingROL, "dgvItemFollowingROL");
            this.dgvItemFollowingROL.Name = "dgvItemFollowingROL";
            this.dgvItemFollowingROL.RowTemplate.Height = 24;
            this.dgvItemFollowingROL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemFollowingROL_CellContentClick);
            this.dgvItemFollowingROL.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvItemFollowingROL_CellPainting);
            this.dgvItemFollowingROL.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvItemFollowingROL_DataBindingComplete);
            // 
            // lblItemFollowingROL
            // 
            resources.ApplyResources(this.lblItemFollowingROL, "lblItemFollowingROL");
            this.tableLayoutPanel1.SetColumnSpan(this.lblItemFollowingROL, 5);
            this.lblItemFollowingROL.Name = "lblItemFollowingROL";
            this.lblItemFollowingROL.Click += new System.EventHandler(this.lblFollowingROL_Click);
            // 
            // lblReStock
            // 
            resources.ApplyResources(this.lblReStock, "lblReStock");
            this.tableLayoutPanel1.SetColumnSpan(this.lblReStock, 5);
            this.lblReStock.Name = "lblReStock";
            // 
            // dgvRestock
            // 
            this.dgvRestock.AllowUserToAddRows = false;
            this.dgvRestock.AllowUserToDeleteRows = false;
            this.dgvRestock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvRestock, 5);
            resources.ApplyResources(this.dgvRestock, "dgvRestock");
            this.dgvRestock.Name = "dgvRestock";
            this.dgvRestock.RowTemplate.Height = 24;
            this.dgvRestock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestock_CellContentClick);
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnMovedown, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblItemFollowingROL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveUp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvItemFollowingROL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvRestock, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblReStock, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnReStockConfirm, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnMovedown
            // 
            resources.ApplyResources(this.btnMovedown, "btnMovedown");
            this.btnMovedown.Name = "btnMovedown";
            this.btnMovedown.UseVisualStyleBackColor = true;
            this.btnMovedown.Click += new System.EventHandler(this.btnMovedown_Click);
            // 
            // btnMoveUp
            // 
            resources.ApplyResources(this.btnMoveUp, "btnMoveUp");
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnReStockConfirm
            // 
            resources.ApplyResources(this.btnReStockConfirm, "btnReStockConfirm");
            this.btnReStockConfirm.Name = "btnReStockConfirm";
            this.btnReStockConfirm.UseVisualStyleBackColor = true;
            this.btnReStockConfirm.Click += new System.EventHandler(this.btnReStockConfirm_Click);
            // 
            // frmReStock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmReStock";
            this.Load += new System.EventHandler(this.frmReStock_Load);
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