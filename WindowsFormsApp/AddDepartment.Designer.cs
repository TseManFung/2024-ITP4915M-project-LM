namespace WindowsFormsApp
{
    partial class frmAddDepartment
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
            this.txtDepartmentEmail = new System.Windows.Forms.TextBox();
            this.lblDepartmentEmail = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIsItWarehouse = new System.Windows.Forms.Label();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.lblWareHouse = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.txtDepartmentEmail, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblDepartmentEmail, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(483, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(154, 101);
            this.tableLayoutPanel6.TabIndex = 86;
            // 
            // txtDepartmentEmail
            // 
            this.txtDepartmentEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDepartmentEmail.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDepartmentEmail.Location = new System.Drawing.Point(3, 53);
            this.txtDepartmentEmail.Multiline = true;
            this.txtDepartmentEmail.Name = "txtDepartmentEmail";
            this.txtDepartmentEmail.Size = new System.Drawing.Size(148, 45);
            this.txtDepartmentEmail.TabIndex = 57;
            // 
            // lblDepartmentEmail
            // 
            this.lblDepartmentEmail.AutoSize = true;
            this.lblDepartmentEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartmentEmail.CausesValidation = false;
            this.lblDepartmentEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartmentEmail.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDepartmentEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartmentEmail.Location = new System.Drawing.Point(3, 0);
            this.lblDepartmentEmail.Name = "lblDepartmentEmail";
            this.lblDepartmentEmail.Size = new System.Drawing.Size(148, 50);
            this.lblDepartmentEmail.TabIndex = 58;
            this.lblDepartmentEmail.Text = "Department Email:";
            this.lblDepartmentEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("PMingLiU", 32F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(483, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 62);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("PMingLiU", 32F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(163, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 62);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lblIsItWarehouse, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radYes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radNo, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 174);
            this.tableLayoutPanel2.TabIndex = 94;
            // 
            // lblIsItWarehouse
            // 
            this.lblIsItWarehouse.AutoSize = true;
            this.lblIsItWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsItWarehouse.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold);
            this.lblIsItWarehouse.Location = new System.Drawing.Point(3, 0);
            this.lblIsItWarehouse.Name = "lblIsItWarehouse";
            this.tableLayoutPanel2.SetRowSpan(this.lblIsItWarehouse, 2);
            this.lblIsItWarehouse.Size = new System.Drawing.Size(325, 174);
            this.lblIsItWarehouse.TabIndex = 0;
            this.lblIsItWarehouse.Text = "Is it warehouse?";
            this.lblIsItWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radYes.Font = new System.Drawing.Font("PMingLiU", 20.25F);
            this.radYes.Location = new System.Drawing.Point(334, 53);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(137, 31);
            this.radYes.TabIndex = 1;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Checked = true;
            this.radNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.radNo.Font = new System.Drawing.Font("PMingLiU", 20.25F);
            this.radNo.Location = new System.Drawing.Point(334, 90);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(137, 31);
            this.radNo.TabIndex = 2;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxWarehouse, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWareHouse, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(483, 183);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(154, 101);
            this.tableLayoutPanel5.TabIndex = 85;
            this.tableLayoutPanel5.Visible = false;
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouse.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(3, 53);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(148, 35);
            this.comboBoxWarehouse.TabIndex = 74;
            this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
            // 
            // lblWareHouse
            // 
            this.lblWareHouse.AutoSize = true;
            this.lblWareHouse.BackColor = System.Drawing.SystemColors.Control;
            this.lblWareHouse.CausesValidation = false;
            this.lblWareHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWareHouse.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWareHouse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWareHouse.Location = new System.Drawing.Point(3, 0);
            this.lblWareHouse.Name = "lblWareHouse";
            this.lblWareHouse.Size = new System.Drawing.Size(148, 50);
            this.lblWareHouse.TabIndex = 73;
            this.lblWareHouse.Text = "Warehouse:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtDepartmentID, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(163, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(154, 101);
            this.tableLayoutPanel3.TabIndex = 95;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDepartmentID.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDepartmentID.Location = new System.Drawing.Point(3, 53);
            this.txtDepartmentID.Multiline = true;
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(148, 45);
            this.txtDepartmentID.TabIndex = 47;
            this.txtDepartmentID.TextChanged += new System.EventHandler(this.txtDepartmentID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.CausesValidation = false;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 50);
            this.label1.TabIndex = 50;
            this.label1.Text = "Department ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtDepartmentName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblDepartmentName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(323, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(154, 101);
            this.tableLayoutPanel4.TabIndex = 84;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDepartmentName.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDepartmentName.Location = new System.Drawing.Point(3, 53);
            this.txtDepartmentName.Multiline = true;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(148, 45);
            this.txtDepartmentName.TabIndex = 47;
            this.txtDepartmentName.TextChanged += new System.EventHandler(this.txtDepartmentName_TextChanged);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartmentName.CausesValidation = false;
            this.lblDepartmentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartmentName.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDepartmentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartmentName.Location = new System.Drawing.Point(3, 0);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(148, 50);
            this.lblDepartmentName.TabIndex = 50;
            this.lblDepartmentName.Text = "Department Name:";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmAddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAddDepartment";
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.frmAddDepartment_Load);
            this.Resize += new System.EventHandler(this.frmAddDepartment_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtDepartmentEmail;
        private System.Windows.Forms.Label lblDepartmentEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblWareHouse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblIsItWarehouse;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        public System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label label1;
    }
}