namespace WindowsFormsApp
{
    partial class frmOrderStatus
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
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridViewOrderStatus = new System.Windows.Forms.DataGridView();
            this.btnCheckDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 0;
            this.pictureBoxBack.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBoxLogo.Location = new System.Drawing.Point(729, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblOrderStatus.Location = new System.Drawing.Point(824, 12);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(250, 48);
            this.lblOrderStatus.TabIndex = 2;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1802, 10);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLanguage.TabIndex = 3;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnSelect.Location = new System.Drawing.Point(1641, 96);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(143, 60);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrderStatus
            // 
            this.dataGridViewOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderStatus.Location = new System.Drawing.Point(89, 211);
            this.dataGridViewOrderStatus.Name = "dataGridViewOrderStatus";
            this.dataGridViewOrderStatus.RowTemplate.Height = 24;
            this.dataGridViewOrderStatus.Size = new System.Drawing.Size(1695, 564);
            this.dataGridViewOrderStatus.TabIndex = 5;
            // 
            // btnCheckDetail
            // 
            this.btnCheckDetail.Location = new System.Drawing.Point(1597, 892);
            this.btnCheckDetail.Name = "btnCheckDetail";
            this.btnCheckDetail.Size = new System.Drawing.Size(187, 72);
            this.btnCheckDetail.TabIndex = 6;
            this.btnCheckDetail.Text = "Check Detail";
            this.btnCheckDetail.UseVisualStyleBackColor = true;
            // 
            // frmOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnCheckDetail);
            this.Controls.Add(this.dataGridViewOrderStatus);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxBack);
            this.Name = "frmOrderStatus";
            this.Text = "Order Status";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridViewOrderStatus;
        private System.Windows.Forms.Button btnCheckDetail;
    }
}