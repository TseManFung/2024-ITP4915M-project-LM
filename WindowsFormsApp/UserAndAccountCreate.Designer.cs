namespace WindowsFormsApp
{
    partial class frmUserManagementAndAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagementAndAccountManagement));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageExistAccount = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.accForDealer = new System.Windows.Forms.RadioButton();
            this.accForStaff = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAccessLevel = new System.Windows.Forms.TextBox();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblThisAccountFor = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnManageExistAccount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblThisAccountFor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnManageExistAccount
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnManageExistAccount, 3);
            resources.ApplyResources(this.btnManageExistAccount, "btnManageExistAccount");
            this.btnManageExistAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageExistAccount.Name = "btnManageExistAccount";
            this.btnManageExistAccount.UseVisualStyleBackColor = true;
            this.btnManageExistAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.accForDealer, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.accForStaff, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // accForDealer
            // 
            resources.ApplyResources(this.accForDealer, "accForDealer");
            this.accForDealer.Name = "accForDealer";
            this.accForDealer.TabStop = true;
            this.accForDealer.UseVisualStyleBackColor = true;
            // 
            // accForStaff
            // 
            resources.ApplyResources(this.accForStaff, "accForStaff");
            this.accForStaff.Name = "accForStaff";
            this.accForStaff.TabStop = true;
            this.accForStaff.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtAccessLevel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblAccessLevel, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtAccessLevel
            // 
            resources.ApplyResources(this.txtAccessLevel, "txtAccessLevel");
            this.txtAccessLevel.Name = "txtAccessLevel";
            this.txtAccessLevel.TextChanged += new System.EventHandler(this.txtAccessLevel_TextChanged);
            // 
            // lblAccessLevel
            // 
            resources.ApplyResources(this.lblAccessLevel, "lblAccessLevel");
            this.lblAccessLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblAccessLevel.CausesValidation = false;
            this.lblAccessLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccessLevel.Name = "lblAccessLevel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.txtLoginName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblLoginName, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // txtLoginName
            // 
            resources.ApplyResources(this.txtLoginName, "txtLoginName");
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.TextChanged += new System.EventHandler(this.txtLoginName_TextChanged);
            // 
            // lblLoginName
            // 
            resources.ApplyResources(this.lblLoginName, "lblLoginName");
            this.lblLoginName.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoginName.CausesValidation = false;
            this.lblLoginName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoginName.Name = "lblLoginName";
            // 
            // lblThisAccountFor
            // 
            resources.ApplyResources(this.lblThisAccountFor, "lblThisAccountFor");
            this.lblThisAccountFor.Name = "lblThisAccountFor";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnCreate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmUserManagementAndAccountManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUserManagementAndAccountManagement";
            this.Load += new System.EventHandler(this.frmUserManagementAndAccountManagement_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton accForDealer;
        private System.Windows.Forms.RadioButton accForStaff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtAccessLevel;
        private System.Windows.Forms.Label lblAccessLevel;
        private System.Windows.Forms.Label lblThisAccountFor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnManageExistAccount;
        private System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.Button btnClear;
    }
}