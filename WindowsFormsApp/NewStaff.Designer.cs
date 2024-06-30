namespace WindowsFormsApp
{
    partial class frmNewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewStaff));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGender = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSaleArea = new System.Windows.Forms.ComboBox();
            this.lblSaleArea = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAreYouNewStaff = new System.Windows.Forms.Label();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxStaffID = new System.Windows.Forms.ComboBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.lblGender, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.BackColor = System.Drawing.SystemColors.Control;
            this.lblGender.CausesValidation = false;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGender.Name = "lblGender";
            // 
            // tableLayoutPanel13
            // 
            resources.ApplyResources(this.tableLayoutPanel13, "tableLayoutPanel13");
            this.tableLayoutPanel13.Controls.Add(this.rbMale, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.rbFemale, 1, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            // 
            // rbMale
            // 
            resources.ApplyResources(this.rbMale, "rbMale");
            this.rbMale.Name = "rbMale";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            resources.ApplyResources(this.rbFemale, "rbFemale");
            this.rbFemale.Checked = true;
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.TabStop = true;
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.lblSupplierID, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtPhoneNum, 0, 1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // lblSupplierID
            // 
            resources.ApplyResources(this.lblSupplierID, "lblSupplierID");
            this.lblSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSupplierID.CausesValidation = false;
            this.lblSupplierID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierID.Name = "lblSupplierID";
            // 
            // txtPhoneNum
            // 
            resources.ApplyResources(this.txtPhoneNum, "txtPhoneNum");
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtSupplierID_TextChanged);
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.comboBoxDepartment, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblDepartment, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // comboBoxDepartment
            // 
            resources.ApplyResources(this.comboBoxDepartment, "comboBoxDepartment");
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            resources.ApplyResources(this.lblDepartment, "lblDepartment");
            this.lblDepartment.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartment.CausesValidation = false;
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartment.Name = "lblDepartment";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.comboBoxSaleArea, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblSaleArea, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // comboBoxSaleArea
            // 
            resources.ApplyResources(this.comboBoxSaleArea, "comboBoxSaleArea");
            this.comboBoxSaleArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaleArea.FormattingEnabled = true;
            this.comboBoxSaleArea.Name = "comboBoxSaleArea";
            this.comboBoxSaleArea.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaleArea_SelectedIndexChanged);
            // 
            // lblSaleArea
            // 
            resources.ApplyResources(this.lblSaleArea, "lblSaleArea");
            this.lblSaleArea.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaleArea.CausesValidation = false;
            this.lblSaleArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaleArea.Name = "lblSaleArea";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtStaffName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSpareName, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtStaffName
            // 
            resources.ApplyResources(this.txtStaffName, "txtStaffName");
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtSpareName_TextChanged);
            // 
            // lblSpareName
            // 
            resources.ApplyResources(this.lblSpareName, "lblSpareName");
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Name = "lblSpareName";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblPosition, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxPosition, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.BackColor = System.Drawing.SystemColors.Control;
            this.lblPosition.CausesValidation = false;
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPosition.Name = "lblPosition";
            // 
            // comboBoxPosition
            // 
            resources.ApplyResources(this.comboBoxPosition, "comboBoxPosition");
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.lblAreYouNewStaff, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radYes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radNo, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // lblAreYouNewStaff
            // 
            resources.ApplyResources(this.lblAreYouNewStaff, "lblAreYouNewStaff");
            this.lblAreYouNewStaff.Name = "lblAreYouNewStaff";
            this.tableLayoutPanel2.SetRowSpan(this.lblAreYouNewStaff, 2);
            // 
            // radYes
            // 
            resources.ApplyResources(this.radYes, "radYes");
            this.radYes.Checked = true;
            this.radYes.Name = "radYes";
            this.radYes.TabStop = true;
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // radNo
            // 
            resources.ApplyResources(this.radNo, "radNo");
            this.radNo.Name = "radNo";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.tableLayoutPanel12.Controls.Add(this.comboBoxStaffID, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.lblStaffID, 0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            // 
            // comboBoxStaffID
            // 
            resources.ApplyResources(this.comboBoxStaffID, "comboBoxStaffID");
            this.comboBoxStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStaffID.FormattingEnabled = true;
            this.comboBoxStaffID.Name = "comboBoxStaffID";
            this.comboBoxStaffID.SelectedIndexChanged += new System.EventHandler(this.comboBoxStaffID_SelectedIndexChanged);
            // 
            // lblStaffID
            // 
            resources.ApplyResources(this.lblStaffID, "lblStaffID");
            this.lblStaffID.Name = "lblStaffID";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnClear, 3, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // frmNewStaff
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel10);
            this.Name = "frmNewStaff";
            this.Load += new System.EventHandler(this.frmNewStaff_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblSaleArea;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblSpareName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.ComboBox comboBoxPosition;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAreYouNewStaff;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        public System.Windows.Forms.ComboBox comboBoxDepartment;
        public System.Windows.Forms.ComboBox comboBoxSaleArea;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        public System.Windows.Forms.ComboBox comboBoxStaffID;
    }
}