namespace WindowsFormsApp
{
    partial class frmCollectSpare
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtActualQuantity = new System.Windows.Forms.TextBox();
            this.lblActualQuantity = new System.Windows.Forms.Label();
            this.lblFollowingCollect = new System.Windows.Forms.Label();
            this.dgvCollect = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpareNumberofBundles = new System.Windows.Forms.TextBox();
            this.lblSpareNumberofBundles = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.comboBoxSpareID = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTurnOnScanner = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollect)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFollowingCollect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCollect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 621);
            this.tableLayoutPanel1.TabIndex = 78;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.txtActualQuantity, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblActualQuantity, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(798, 437);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(335, 101);
            this.tableLayoutPanel6.TabIndex = 86;
            // 
            // txtActualQuantity
            // 
            this.txtActualQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtActualQuantity.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtActualQuantity.Location = new System.Drawing.Point(3, 53);
            this.txtActualQuantity.Multiline = true;
            this.txtActualQuantity.Name = "txtActualQuantity";
            this.txtActualQuantity.Size = new System.Drawing.Size(329, 45);
            this.txtActualQuantity.TabIndex = 47;
            // 
            // lblActualQuantity
            // 
            this.lblActualQuantity.AutoSize = true;
            this.lblActualQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblActualQuantity.CausesValidation = false;
            this.lblActualQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActualQuantity.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblActualQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActualQuantity.Location = new System.Drawing.Point(3, 0);
            this.lblActualQuantity.Name = "lblActualQuantity";
            this.lblActualQuantity.Size = new System.Drawing.Size(329, 50);
            this.lblActualQuantity.TabIndex = 50;
            this.lblActualQuantity.Text = "Actual Quantity:";
            // 
            // lblFollowingCollect
            // 
            this.lblFollowingCollect.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFollowingCollect, 2);
            this.lblFollowingCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFollowingCollect.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblFollowingCollect.Location = new System.Drawing.Point(3, 0);
            this.lblFollowingCollect.Name = "lblFollowingCollect";
            this.lblFollowingCollect.Size = new System.Drawing.Size(1130, 31);
            this.lblFollowingCollect.TabIndex = 75;
            this.lblFollowingCollect.Text = "The following items have need to collect:";
            // 
            // dgvCollect
            // 
            this.dgvCollect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCollect, 2);
            this.dgvCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollect.Location = new System.Drawing.Point(3, 34);
            this.dgvCollect.Name = "dgvCollect";
            this.dgvCollect.RowTemplate.Height = 24;
            this.dgvCollect.Size = new System.Drawing.Size(1130, 397);
            this.dgvCollect.TabIndex = 74;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 437);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(789, 118);
            this.tableLayoutPanel2.TabIndex = 77;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtSpareNumberofBundles, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSpareNumberofBundles, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(389, 101);
            this.tableLayoutPanel4.TabIndex = 85;
            // 
            // txtSpareNumberofBundles
            // 
            this.txtSpareNumberofBundles.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSpareNumberofBundles.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSpareNumberofBundles.Location = new System.Drawing.Point(3, 53);
            this.txtSpareNumberofBundles.Multiline = true;
            this.txtSpareNumberofBundles.Name = "txtSpareNumberofBundles";
            this.txtSpareNumberofBundles.Size = new System.Drawing.Size(383, 45);
            this.txtSpareNumberofBundles.TabIndex = 47;
            // 
            // lblSpareNumberofBundles
            // 
            this.lblSpareNumberofBundles.AutoSize = true;
            this.lblSpareNumberofBundles.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareNumberofBundles.CausesValidation = false;
            this.lblSpareNumberofBundles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpareNumberofBundles.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareNumberofBundles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareNumberofBundles.Location = new System.Drawing.Point(3, 0);
            this.lblSpareNumberofBundles.Name = "lblSpareNumberofBundles";
            this.lblSpareNumberofBundles.Size = new System.Drawing.Size(383, 50);
            this.lblSpareNumberofBundles.TabIndex = 50;
            this.lblSpareNumberofBundles.Text = "Number of Bundles:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSpareID, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 101);
            this.tableLayoutPanel3.TabIndex = 84;
            // 
            // lblSpareID
            // 
            this.lblSpareID.AutoSize = true;
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpareID.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Location = new System.Drawing.Point(3, 0);
            this.lblSpareID.Name = "lblSpareID";
            this.lblSpareID.Size = new System.Drawing.Size(382, 50);
            this.lblSpareID.TabIndex = 48;
            this.lblSpareID.Text = "Spare ID:";
            // 
            // comboBoxSpareID
            // 
            this.comboBoxSpareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSpareID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxSpareID.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Location = new System.Drawing.Point(3, 53);
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            this.comboBoxSpareID.Size = new System.Drawing.Size(382, 41);
            this.comboBoxSpareID.TabIndex = 45;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnTurnOnScanner, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 561);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(789, 57);
            this.tableLayoutPanel5.TabIndex = 78;
            // 
            // btnTurnOnScanner
            // 
            this.btnTurnOnScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTurnOnScanner.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnTurnOnScanner.Location = new System.Drawing.Point(3, 3);
            this.btnTurnOnScanner.Name = "btnTurnOnScanner";
            this.btnTurnOnScanner.Size = new System.Drawing.Size(388, 51);
            this.btnTurnOnScanner.TabIndex = 76;
            this.btnTurnOnScanner.Text = "Turn on scanner";
            this.btnTurnOnScanner.UseVisualStyleBackColor = true;
            this.btnTurnOnScanner.Click += new System.EventHandler(this.btnscanner_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnConfirm.Location = new System.Drawing.Point(798, 561);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(335, 57);
            this.btnConfirm.TabIndex = 79;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // frmCollectSpare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCollectSpare";
            this.Text = "Collect Spare";
            this.Load += new System.EventHandler(this.frmCollectSpare_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollect)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFollowingCollect;
        private System.Windows.Forms.Button btnTurnOnScanner;
        private System.Windows.Forms.DataGridView dgvCollect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSpareID;
        public System.Windows.Forms.ComboBox comboBoxSpareID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtSpareNumberofBundles;
        private System.Windows.Forms.Label lblSpareNumberofBundles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtActualQuantity;
        private System.Windows.Forms.Label lblActualQuantity;
    }
}