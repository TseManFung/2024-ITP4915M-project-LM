namespace WindowsFormsApp
{
    partial class frmReorderSparePartsShippingDepartment
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
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.lblReOrderPurchasingDepartment = new System.Windows.Forms.Label();
            this.dataGridViewItemHaveArrivedInROL = new System.Windows.Forms.DataGridView();
            this.lblFollowingROL = new System.Windows.Forms.Label();
            this.btnOutputToPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemHaveArrivedInROL)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(138, 130);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 43;
            this.pictureBoxBack.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBoxLogo.Location = new System.Drawing.Point(525, -1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(163, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 45;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1708, -1);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(144, 130);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 72;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // lblReOrderPurchasingDepartment
            // 
            this.lblReOrderPurchasingDepartment.AutoSize = true;
            this.lblReOrderPurchasingDepartment.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblReOrderPurchasingDepartment.Location = new System.Drawing.Point(712, 46);
            this.lblReOrderPurchasingDepartment.Name = "lblReOrderPurchasingDepartment";
            this.lblReOrderPurchasingDepartment.Size = new System.Drawing.Size(834, 48);
            this.lblReOrderPurchasingDepartment.TabIndex = 73;
            this.lblReOrderPurchasingDepartment.Text = "Re-order (Spare Parts Shipping Department)";
            // 
            // dataGridViewItemHaveArrivedInROL
            // 
            this.dataGridViewItemHaveArrivedInROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemHaveArrivedInROL.Location = new System.Drawing.Point(190, 220);
            this.dataGridViewItemHaveArrivedInROL.Name = "dataGridViewItemHaveArrivedInROL";
            this.dataGridViewItemHaveArrivedInROL.RowTemplate.Height = 24;
            this.dataGridViewItemHaveArrivedInROL.Size = new System.Drawing.Size(1488, 392);
            this.dataGridViewItemHaveArrivedInROL.TabIndex = 74;
            // 
            // lblFollowingROL
            // 
            this.lblFollowingROL.AutoSize = true;
            this.lblFollowingROL.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblFollowingROL.Location = new System.Drawing.Point(52, 156);
            this.lblFollowingROL.Name = "lblFollowingROL";
            this.lblFollowingROL.Size = new System.Drawing.Size(519, 32);
            this.lblFollowingROL.TabIndex = 75;
            this.lblFollowingROL.Text = "The following items have arrived in ROL:";
            // 
            // btnOutputToPDF
            // 
            this.btnOutputToPDF.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnOutputToPDF.Location = new System.Drawing.Point(1411, 730);
            this.btnOutputToPDF.Name = "btnOutputToPDF";
            this.btnOutputToPDF.Size = new System.Drawing.Size(257, 90);
            this.btnOutputToPDF.TabIndex = 76;
            this.btnOutputToPDF.Text = "Output To PDF";
            this.btnOutputToPDF.UseVisualStyleBackColor = true;
            // 
            // frmReorderSparePartsShippingDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnOutputToPDF);
            this.Controls.Add(this.lblFollowingROL);
            this.Controls.Add(this.dataGridViewItemHaveArrivedInROL);
            this.Controls.Add(this.lblReOrderPurchasingDepartment);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxBack);
            this.Name = "frmReorderSparePartsShippingDepartment";
            this.Text = "Re-order(Spare Parts Shipping Department)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemHaveArrivedInROL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.Label lblReOrderPurchasingDepartment;
        private System.Windows.Forms.DataGridView dataGridViewItemHaveArrivedInROL;
        private System.Windows.Forms.Label lblFollowingROL;
        private System.Windows.Forms.Button btnOutputToPDF;
    }
}