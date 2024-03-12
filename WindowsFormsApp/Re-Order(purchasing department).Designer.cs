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
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblReOrderPurchasingDepartment = new System.Windows.Forms.Label();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.dataGridViewItemFollowingROL = new System.Windows.Forms.DataGridView();
            this.lblItemFollowingROL = new System.Windows.Forms.Label();
            this.lblReStock = new System.Windows.Forms.Label();
            this.dataGridViewRestock = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemFollowingROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(26, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(138, 130);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 42;
            this.pictureBoxBack.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBoxLogo.Location = new System.Drawing.Point(465, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(163, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 44;
            this.pictureBoxLogo.TabStop = false;
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
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1681, -5);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(144, 130);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 71;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // dataGridViewItemFollowingROL
            // 
            this.dataGridViewItemFollowingROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemFollowingROL.Location = new System.Drawing.Point(178, 216);
            this.dataGridViewItemFollowingROL.Name = "dataGridViewItemFollowingROL";
            this.dataGridViewItemFollowingROL.RowTemplate.Height = 24;
            this.dataGridViewItemFollowingROL.Size = new System.Drawing.Size(1488, 392);
            this.dataGridViewItemFollowingROL.TabIndex = 72;
            // 
            // lblItemFollowingROL
            // 
            this.lblItemFollowingROL.AutoSize = true;
            this.lblItemFollowingROL.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblItemFollowingROL.Location = new System.Drawing.Point(37, 171);
            this.lblItemFollowingROL.Name = "lblItemFollowingROL";
            this.lblItemFollowingROL.Size = new System.Drawing.Size(519, 32);
            this.lblItemFollowingROL.TabIndex = 73;
            this.lblItemFollowingROL.Text = "The following items have arrived in ROL:";
            this.lblItemFollowingROL.Click += new System.EventHandler(this.lblFollowingROL_Click);
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
            // dataGridViewRestock
            // 
            this.dataGridViewRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestock.Location = new System.Drawing.Point(178, 675);
            this.dataGridViewRestock.Name = "dataGridViewRestock";
            this.dataGridViewRestock.RowTemplate.Height = 24;
            this.dataGridViewRestock.Size = new System.Drawing.Size(1488, 160);
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
            // frmReOrderPurchasingDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dataGridViewRestock);
            this.Controls.Add(this.lblReStock);
            this.Controls.Add(this.lblItemFollowingROL);
            this.Controls.Add(this.dataGridViewItemFollowingROL);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.lblReOrderPurchasingDepartment);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxBack);
            this.Name = "frmReOrderPurchasingDepartment";
            this.Text = "Re-Order(Purchasing Department)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemFollowingROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblReOrderPurchasingDepartment;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.DataGridView dataGridViewItemFollowingROL;
        private System.Windows.Forms.Label lblItemFollowingROL;
        private System.Windows.Forms.Label lblReStock;
        private System.Windows.Forms.DataGridView dataGridViewRestock;
        private System.Windows.Forms.Button btnConfirm;
    }
}