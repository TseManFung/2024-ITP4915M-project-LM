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
            this.dataGridViewItemFollowingROL = new System.Windows.Forms.DataGridView();
            this.lblItemFollowingROL = new System.Windows.Forms.Label();
            this.lblReStock = new System.Windows.Forms.Label();
            this.dataGridViewRestock = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemFollowingROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItemFollowingROL
            // 
            this.dataGridViewItemFollowingROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewItemFollowingROL, 5);
            this.dataGridViewItemFollowingROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItemFollowingROL.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewItemFollowingROL.Name = "dataGridViewItemFollowingROL";
            this.dataGridViewItemFollowingROL.RowTemplate.Height = 24;
            this.dataGridViewItemFollowingROL.Size = new System.Drawing.Size(1094, 218);
            this.dataGridViewItemFollowingROL.TabIndex = 72;
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
            // dataGridViewRestock
            // 
            this.dataGridViewRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewRestock, 5);
            this.dataGridViewRestock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRestock.Location = new System.Drawing.Point(3, 339);
            this.dataGridViewRestock.Name = "dataGridViewRestock";
            this.dataGridViewRestock.RowTemplate.Height = 24;
            this.dataGridViewRestock.Size = new System.Drawing.Size(1094, 162);
            this.dataGridViewRestock.TabIndex = 75;
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
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblItemFollowingROL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewItemFollowingROL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewRestock, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblReStock, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 4, 5);
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
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(718, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 50);
            this.button2.TabIndex = 79;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(333, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 50);
            this.button1.TabIndex = 78;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(773, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 51);
            this.button3.TabIndex = 80;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmReStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmReStock";
            this.Text = "Re-Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemFollowingROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewItemFollowingROL;
        private System.Windows.Forms.Label lblItemFollowingROL;
        private System.Windows.Forms.Label lblReStock;
        private System.Windows.Forms.DataGridView dataGridViewRestock;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}