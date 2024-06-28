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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDepartment));
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
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.txtDepartmentEmail, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblDepartmentEmail, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // txtDepartmentEmail
            // 
            resources.ApplyResources(this.txtDepartmentEmail, "txtDepartmentEmail");
            this.txtDepartmentEmail.Name = "txtDepartmentEmail";
            this.txtDepartmentEmail.TextChanged += new System.EventHandler(this.txtDepartmentEmail_TextChanged);
            // 
            // lblDepartmentEmail
            // 
            resources.ApplyResources(this.lblDepartmentEmail, "lblDepartmentEmail");
            this.lblDepartmentEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartmentEmail.CausesValidation = false;
            this.lblDepartmentEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartmentEmail.Name = "lblDepartmentEmail";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblIsItWarehouse, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radYes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radNo, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // lblIsItWarehouse
            // 
            resources.ApplyResources(this.lblIsItWarehouse, "lblIsItWarehouse");
            this.lblIsItWarehouse.Name = "lblIsItWarehouse";
            this.tableLayoutPanel2.SetRowSpan(this.lblIsItWarehouse, 2);
            // 
            // radYes
            // 
            resources.ApplyResources(this.radYes, "radYes");
            this.radYes.Name = "radYes";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // radNo
            // 
            resources.ApplyResources(this.radNo, "radNo");
            this.radNo.Checked = true;
            this.radNo.Name = "radNo";
            this.radNo.TabStop = true;
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.comboBoxWarehouse, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWareHouse, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // comboBoxWarehouse
            // 
            resources.ApplyResources(this.comboBoxWarehouse, "comboBoxWarehouse");
            this.comboBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
            // 
            // lblWareHouse
            // 
            resources.ApplyResources(this.lblWareHouse, "lblWareHouse");
            this.lblWareHouse.BackColor = System.Drawing.SystemColors.Control;
            this.lblWareHouse.CausesValidation = false;
            this.lblWareHouse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWareHouse.Name = "lblWareHouse";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.txtDepartmentID, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // txtDepartmentID
            // 
            resources.ApplyResources(this.txtDepartmentID, "txtDepartmentID");
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.TextChanged += new System.EventHandler(this.txtDepartmentID_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.CausesValidation = false;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtDepartmentName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblDepartmentName, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtDepartmentName
            // 
            resources.ApplyResources(this.txtDepartmentName, "txtDepartmentName");
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.TextChanged += new System.EventHandler(this.txtDepartmentName_TextChanged);
            // 
            // lblDepartmentName
            // 
            resources.ApplyResources(this.lblDepartmentName, "lblDepartmentName");
            this.lblDepartmentName.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartmentName.CausesValidation = false;
            this.lblDepartmentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartmentName.Name = "lblDepartmentName";
            // 
            // frmAddDepartment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAddDepartment";
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