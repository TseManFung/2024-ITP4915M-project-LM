namespace WindowsFormsApp
{
    partial class frmReOrderPurchasingDepartment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblReOrderPurchasingDepartment = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFollowingROL = new System.Windows.Forms.Label();
            this.lblReStock = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBox3.Location = new System.Drawing.Point(465, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // lblReOrderPurchasingDepartment
            // 
            this.lblReOrderPurchasingDepartment.AutoSize = true;
            this.lblReOrderPurchasingDepartment.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblReOrderPurchasingDepartment.Location = new System.Drawing.Point(652, 46);
            this.lblReOrderPurchasingDepartment.Name = "lblReOrderPurchasingDepartment";
            this.lblReOrderPurchasingDepartment.Size = new System.Drawing.Size(663, 48);
            this.lblReOrderPurchasingDepartment.TabIndex = 45;
            this.lblReOrderPurchasingDepartment.Text = "Re-Order (Purchasing Department)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBox2.Location = new System.Drawing.Point(1681, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1488, 392);
            this.dataGridView1.TabIndex = 72;
            // 
            // lblFollowingROL
            // 
            this.lblFollowingROL.AutoSize = true;
            this.lblFollowingROL.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblFollowingROL.Location = new System.Drawing.Point(37, 171);
            this.lblFollowingROL.Name = "lblFollowingROL";
            this.lblFollowingROL.Size = new System.Drawing.Size(519, 32);
            this.lblFollowingROL.TabIndex = 73;
            this.lblFollowingROL.Text = "The following items have arrived in ROL:";
            this.lblFollowingROL.Click += new System.EventHandler(this.lblFollowingROL_Click);
            // 
            // lblReStock
            // 
            this.lblReStock.AutoSize = true;
            this.lblReStock.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblReStock.Location = new System.Drawing.Point(46, 633);
            this.lblReStock.Name = "lblReStock";
            this.lblReStock.Size = new System.Drawing.Size(118, 32);
            this.lblReStock.TabIndex = 74;
            this.lblReStock.Text = "Restock:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(178, 675);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1488, 160);
            this.dataGridView2.TabIndex = 75;
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
            // frmReOrderPurchasingDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblReStock);
            this.Controls.Add(this.lblFollowingROL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblReOrderPurchasingDepartment);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmReOrderPurchasingDepartment";
            this.Text = "Re-Order(Purchasing Department)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblReOrderPurchasingDepartment;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFollowingROL;
        private System.Windows.Forms.Label lblReStock;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnConfirm;
    }
}