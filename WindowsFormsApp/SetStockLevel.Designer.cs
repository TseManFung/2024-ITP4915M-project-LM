﻿namespace WindowsFormsApp
{
    partial class frmSetStockLevel
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
            this.lblSpareID = new System.Windows.Forms.Label();
            this.comboBoxSpareID = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpareName = new System.Windows.Forms.TextBox();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBoxAutoReStock = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReOrderLevel = new System.Windows.Forms.Label();
            this.txtReOrderLevel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCommonStockLevel = new System.Windows.Forms.TextBox();
            this.lblCommonStockLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDangerLevel = new System.Windows.Forms.TextBox();
            this.lblDangerLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAutoReStock, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSpareID, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(317, 174);
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
            this.lblSpareID.Size = new System.Drawing.Size(311, 87);
            this.lblSpareID.TabIndex = 48;
            this.lblSpareID.Text = "Spare ID:";
            this.lblSpareID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxSpareID
            // 
            this.comboBoxSpareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSpareID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpareID.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Location = new System.Drawing.Point(3, 90);
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            this.comboBoxSpareID.Size = new System.Drawing.Size(311, 35);
            this.comboBoxSpareID.TabIndex = 45;
            this.comboBoxSpareID.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpareID_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtSpareName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSpareName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(326, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(317, 174);
            this.tableLayoutPanel4.TabIndex = 85;
            // 
            // txtSpareName
            // 
            this.txtSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSpareName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpareName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSpareName.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSpareName.Location = new System.Drawing.Point(3, 90);
            this.txtSpareName.Multiline = true;
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.ReadOnly = true;
            this.txtSpareName.Size = new System.Drawing.Size(311, 41);
            this.txtSpareName.TabIndex = 47;
            this.txtSpareName.TextChanged += new System.EventHandler(this.txtSpareName_TextChanged);
            // 
            // lblSpareName
            // 
            this.lblSpareName.AutoSize = true;
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpareName.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Location = new System.Drawing.Point(3, 0);
            this.lblSpareName.Name = "lblSpareName";
            this.lblSpareName.Size = new System.Drawing.Size(311, 87);
            this.lblSpareName.TabIndex = 50;
            this.lblSpareName.Text = "Spare Name:";
            this.lblSpareName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnSave.Location = new System.Drawing.Point(326, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(317, 84);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBoxAutoReStock
            // 
            this.checkBoxAutoReStock.AutoSize = true;
            this.checkBoxAutoReStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAutoReStock.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxAutoReStock.Location = new System.Drawing.Point(649, 3);
            this.checkBoxAutoReStock.Name = "checkBoxAutoReStock";
            this.checkBoxAutoReStock.Size = new System.Drawing.Size(318, 174);
            this.checkBoxAutoReStock.TabIndex = 93;
            this.checkBoxAutoReStock.Text = "Auto Re-stock";
            this.checkBoxAutoReStock.UseVisualStyleBackColor = true;
            this.checkBoxAutoReStock.CheckedChanged += new System.EventHandler(this.checkBoxAutoReStock_CheckedChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.lblReOrderLevel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtReOrderLevel, 0, 1);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(326, 183);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(317, 174);
            this.tableLayoutPanel8.TabIndex = 89;
            // 
            // lblReOrderLevel
            // 
            this.lblReOrderLevel.AutoSize = true;
            this.lblReOrderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblReOrderLevel.CausesValidation = false;
            this.lblReOrderLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReOrderLevel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReOrderLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReOrderLevel.Location = new System.Drawing.Point(3, 0);
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            this.lblReOrderLevel.Size = new System.Drawing.Size(311, 87);
            this.lblReOrderLevel.TabIndex = 69;
            this.lblReOrderLevel.Text = "Re Order Level:";
            this.lblReOrderLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReOrderLevel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReOrderLevel.Location = new System.Drawing.Point(3, 90);
            this.txtReOrderLevel.Multiline = true;
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Size = new System.Drawing.Size(311, 41);
            this.txtReOrderLevel.TabIndex = 68;
            this.txtReOrderLevel.TextChanged += new System.EventHandler(this.txtReOrderLevel_TextChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.txtCommonStockLevel, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblCommonStockLevel, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(317, 174);
            this.tableLayoutPanel9.TabIndex = 90;
            // 
            // txtCommonStockLevel
            // 
            this.txtCommonStockLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCommonStockLevel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCommonStockLevel.Location = new System.Drawing.Point(3, 90);
            this.txtCommonStockLevel.Multiline = true;
            this.txtCommonStockLevel.Name = "txtCommonStockLevel";
            this.txtCommonStockLevel.Size = new System.Drawing.Size(311, 41);
            this.txtCommonStockLevel.TabIndex = 77;
            this.txtCommonStockLevel.TextChanged += new System.EventHandler(this.txtCommonStockLevel_TextChanged);
            // 
            // lblCommonStockLevel
            // 
            this.lblCommonStockLevel.AutoSize = true;
            this.lblCommonStockLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblCommonStockLevel.CausesValidation = false;
            this.lblCommonStockLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCommonStockLevel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCommonStockLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCommonStockLevel.Location = new System.Drawing.Point(3, 0);
            this.lblCommonStockLevel.Name = "lblCommonStockLevel";
            this.lblCommonStockLevel.Size = new System.Drawing.Size(311, 87);
            this.lblCommonStockLevel.TabIndex = 78;
            this.lblCommonStockLevel.Text = "Common Stock Level:";
            this.lblCommonStockLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtDangerLevel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDangerLevel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(649, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(317, 174);
            this.tableLayoutPanel2.TabIndex = 94;
            // 
            // txtDangerLevel
            // 
            this.txtDangerLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDangerLevel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDangerLevel.Location = new System.Drawing.Point(3, 90);
            this.txtDangerLevel.Multiline = true;
            this.txtDangerLevel.Name = "txtDangerLevel";
            this.txtDangerLevel.Size = new System.Drawing.Size(311, 41);
            this.txtDangerLevel.TabIndex = 77;
            this.txtDangerLevel.TextChanged += new System.EventHandler(this.txtDangerLevel_TextChanged);
            // 
            // lblDangerLevel
            // 
            this.lblDangerLevel.AutoSize = true;
            this.lblDangerLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblDangerLevel.CausesValidation = false;
            this.lblDangerLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDangerLevel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDangerLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDangerLevel.Location = new System.Drawing.Point(3, 0);
            this.lblDangerLevel.Name = "lblDangerLevel";
            this.lblDangerLevel.Size = new System.Drawing.Size(311, 87);
            this.lblDangerLevel.TabIndex = 78;
            this.lblDangerLevel.Text = "Danger Level:";
            this.lblDangerLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDangerLevel.Click += new System.EventHandler(this.lblDangerLevel_Click);
            // 
            // frmSetStockLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSetStockLevel";
            this.Text = "Set Stock Level";
            this.Load += new System.EventHandler(this.frmSetStockLevel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSpareID;
        public System.Windows.Forms.ComboBox comboBoxSpareID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtSpareName;
        private System.Windows.Forms.Label lblSpareName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblReOrderLevel;
        private System.Windows.Forms.TextBox txtReOrderLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox txtCommonStockLevel;
        private System.Windows.Forms.Label lblCommonStockLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBoxAutoReStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtDangerLevel;
        private System.Windows.Forms.Label lblDangerLevel;
    }
}