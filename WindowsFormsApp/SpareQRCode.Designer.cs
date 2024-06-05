namespace WindowsFormsApp
{
    partial class frmSpareQRCode
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.comboBoxSpareName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.comboBoxSpareID = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxQRCode, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblSpareName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSpareName, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 129);
            this.tableLayoutPanel3.TabIndex = 84;
            // 
            // lblSpareName
            // 
            this.lblSpareName.AutoSize = true;
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpareName.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Location = new System.Drawing.Point(3, 0);
            this.lblSpareName.Name = "lblSpareName";
            this.lblSpareName.Size = new System.Drawing.Size(388, 64);
            this.lblSpareName.TabIndex = 48;
            this.lblSpareName.Text = "Spare Name:";
            this.lblSpareName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxSpareName
            // 
            this.comboBoxSpareName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSpareName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSpareName.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSpareName.FormattingEnabled = true;
            this.comboBoxSpareName.Location = new System.Drawing.Point(3, 67);
            this.comboBoxSpareName.Name = "comboBoxSpareName";
            this.comboBoxSpareName.Size = new System.Drawing.Size(388, 35);
            this.comboBoxSpareName.TabIndex = 45;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSpareID, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 129);
            this.tableLayoutPanel2.TabIndex = 85;
            // 
            // lblSpareID
            // 
            this.lblSpareID.AutoSize = true;
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpareID.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Location = new System.Drawing.Point(3, 0);
            this.lblSpareID.Name = "lblSpareID";
            this.lblSpareID.Size = new System.Drawing.Size(388, 64);
            this.lblSpareID.TabIndex = 48;
            this.lblSpareID.Text = "Spare ID:";
            this.lblSpareID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxSpareID
            // 
            this.comboBoxSpareID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSpareID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSpareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSpareID.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Location = new System.Drawing.Point(3, 67);
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            this.comboBoxSpareID.Size = new System.Drawing.Size(388, 35);
            this.comboBoxSpareID.TabIndex = 45;
            this.comboBoxSpareID.SelectedValueChanged += new System.EventHandler(this.cboSpareID_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.printing_document_72649;
            this.pictureBox1.Location = new System.Drawing.Point(768, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxQRCode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxQRCode, 2);
            this.pictureBoxQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(3, 160);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(794, 287);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQRCode.TabIndex = 89;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // frmSpareQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSpareQRCode";
            this.Text = "Genarate Spare QRCode";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSpareName;
        public System.Windows.Forms.ComboBox comboBoxSpareName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSpareID;
        public System.Windows.Forms.ComboBox comboBoxSpareID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
    }
}