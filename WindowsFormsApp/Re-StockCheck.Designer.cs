namespace WindowsFormsApp
{
    partial class frmReStockCheck
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
            this.dataGridViewItemHaveArrivedInROL = new System.Windows.Forms.DataGridView();
            this.lblFollowingROL = new System.Windows.Forms.Label();
            this.btnReceived = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemHaveArrivedInROL)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItemHaveArrivedInROL
            // 
            this.dataGridViewItemHaveArrivedInROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewItemHaveArrivedInROL, 2);
            this.dataGridViewItemHaveArrivedInROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItemHaveArrivedInROL.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewItemHaveArrivedInROL.Name = "dataGridViewItemHaveArrivedInROL";
            this.dataGridViewItemHaveArrivedInROL.RowTemplate.Height = 24;
            this.dataGridViewItemHaveArrivedInROL.Size = new System.Drawing.Size(1235, 490);
            this.dataGridViewItemHaveArrivedInROL.TabIndex = 74;
            // 
            // lblFollowingROL
            // 
            this.lblFollowingROL.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFollowingROL, 2);
            this.lblFollowingROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFollowingROL.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblFollowingROL.Location = new System.Drawing.Point(3, 0);
            this.lblFollowingROL.Name = "lblFollowingROL";
            this.lblFollowingROL.Size = new System.Drawing.Size(1235, 29);
            this.lblFollowingROL.TabIndex = 75;
            this.lblFollowingROL.Text = "The following items have arrived in ROL:";
            // 
            // btnReceived
            // 
            this.btnReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReceived.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnReceived.Location = new System.Drawing.Point(871, 528);
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(367, 53);
            this.btnReceived.TabIndex = 76;
            this.btnReceived.Text = "Received";
            this.btnReceived.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lblFollowingROL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReceived, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewItemHaveArrivedInROL, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1241, 584);
            this.tableLayoutPanel1.TabIndex = 77;
            // 
            // frmReStockCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReStockCheck";
            this.Text = "Re-stock Check";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemHaveArrivedInROL)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewItemHaveArrivedInROL;
        private System.Windows.Forms.Label lblFollowingROL;
        private System.Windows.Forms.Button btnReceived;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}