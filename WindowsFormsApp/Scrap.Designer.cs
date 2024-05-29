namespace WindowsFormsApp
{
    partial class frmScrap
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
            this.comboBoxSpareID = new System.Windows.Forms.ComboBox();
            this.txtDiscrepancy = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblDiscrepancy = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSpareID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscrepancy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDiscrepancy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRecord, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxSpareID
            // 
            this.comboBoxSpareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSpareID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxSpareID.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Location = new System.Drawing.Point(221, 3);
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            this.comboBoxSpareID.Size = new System.Drawing.Size(213, 47);
            this.comboBoxSpareID.TabIndex = 60;
            // 
            // txtDiscrepancy
            // 
            this.txtDiscrepancy.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDiscrepancy.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDiscrepancy.Location = new System.Drawing.Point(221, 145);
            this.txtDiscrepancy.Multiline = true;
            this.txtDiscrepancy.Name = "txtDiscrepancy";
            this.txtDiscrepancy.Size = new System.Drawing.Size(213, 45);
            this.txtDiscrepancy.TabIndex = 58;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantity.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuantity.Location = new System.Drawing.Point(221, 74);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(213, 45);
            this.txtQuantity.TabIndex = 57;
            // 
            // lblDiscrepancy
            // 
            this.lblDiscrepancy.AutoSize = true;
            this.lblDiscrepancy.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiscrepancy.CausesValidation = false;
            this.lblDiscrepancy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscrepancy.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscrepancy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiscrepancy.Location = new System.Drawing.Point(3, 142);
            this.lblDiscrepancy.Name = "lblDiscrepancy";
            this.lblDiscrepancy.Size = new System.Drawing.Size(212, 71);
            this.lblDiscrepancy.TabIndex = 55;
            this.lblDiscrepancy.Text = "Discrepancy:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.CausesValidation = false;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Location = new System.Drawing.Point(3, 71);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(212, 71);
            this.lblQuantity.TabIndex = 53;
            this.lblQuantity.Text = "Quantity:";
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
            this.lblSpareID.Size = new System.Drawing.Size(212, 71);
            this.lblSpareID.TabIndex = 51;
            this.lblSpareID.Text = "Spare ID:";
            // 
            // btnRecord
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnRecord, 2);
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecord.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnRecord.Location = new System.Drawing.Point(3, 216);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(431, 47);
            this.btnRecord.TabIndex = 59;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // frmScrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmScrap";
            this.Text = "Scrap";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDiscrepancy;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSpareID;
        private System.Windows.Forms.TextBox txtDiscrepancy;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnRecord;
        public System.Windows.Forms.ComboBox comboBoxSpareID;
    }
}