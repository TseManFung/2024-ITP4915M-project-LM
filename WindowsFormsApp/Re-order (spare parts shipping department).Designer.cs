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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblReOrderPurchasingDepartment = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFollowingROL = new System.Windows.Forms.Label();
            this.btnOutputToPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBox3.Location = new System.Drawing.Point(525, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBox2.Location = new System.Drawing.Point(1708, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1488, 392);
            this.dataGridView1.TabIndex = 74;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblReOrderPurchasingDepartment);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmReorderSparePartsShippingDepartment";
            this.Text = "Re-order(Spare Parts Shipping Department)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblReOrderPurchasingDepartment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFollowingROL;
        private System.Windows.Forms.Button btnOutputToPDF;
    }
}