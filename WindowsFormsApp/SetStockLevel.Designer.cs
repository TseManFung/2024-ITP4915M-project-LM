namespace WindowsFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetStockLevel));
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
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAutoReStock, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSpareID, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblSpareID
            // 
            resources.ApplyResources(this.lblSpareID, "lblSpareID");
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Name = "lblSpareID";
            // 
            // comboBoxSpareID
            // 
            resources.ApplyResources(this.comboBoxSpareID, "comboBoxSpareID");
            this.comboBoxSpareID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            this.comboBoxSpareID.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpareID_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtSpareName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSpareName, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtSpareName
            // 
            this.txtSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSpareName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSpareName, "txtSpareName");
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.ReadOnly = true;
            this.txtSpareName.TextChanged += new System.EventHandler(this.txtSpareName_TextChanged);
            // 
            // lblSpareName
            // 
            resources.ApplyResources(this.lblSpareName, "lblSpareName");
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Name = "lblSpareName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBoxAutoReStock
            // 
            resources.ApplyResources(this.checkBoxAutoReStock, "checkBoxAutoReStock");
            this.checkBoxAutoReStock.Name = "checkBoxAutoReStock";
            this.checkBoxAutoReStock.UseVisualStyleBackColor = true;
            this.checkBoxAutoReStock.CheckedChanged += new System.EventHandler(this.checkBoxAutoReStock_CheckedChanged);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.lblReOrderLevel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtReOrderLevel, 0, 1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // lblReOrderLevel
            // 
            resources.ApplyResources(this.lblReOrderLevel, "lblReOrderLevel");
            this.lblReOrderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblReOrderLevel.CausesValidation = false;
            this.lblReOrderLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            // 
            // txtReOrderLevel
            // 
            resources.ApplyResources(this.txtReOrderLevel, "txtReOrderLevel");
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.TextChanged += new System.EventHandler(this.txtReOrderLevel_TextChanged);
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.txtCommonStockLevel, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblCommonStockLevel, 0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // txtCommonStockLevel
            // 
            resources.ApplyResources(this.txtCommonStockLevel, "txtCommonStockLevel");
            this.txtCommonStockLevel.Name = "txtCommonStockLevel";
            this.txtCommonStockLevel.TextChanged += new System.EventHandler(this.txtCommonStockLevel_TextChanged);
            // 
            // lblCommonStockLevel
            // 
            resources.ApplyResources(this.lblCommonStockLevel, "lblCommonStockLevel");
            this.lblCommonStockLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblCommonStockLevel.CausesValidation = false;
            this.lblCommonStockLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCommonStockLevel.Name = "lblCommonStockLevel";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.txtDangerLevel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDangerLevel, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtDangerLevel
            // 
            resources.ApplyResources(this.txtDangerLevel, "txtDangerLevel");
            this.txtDangerLevel.Name = "txtDangerLevel";
            this.txtDangerLevel.TextChanged += new System.EventHandler(this.txtDangerLevel_TextChanged);
            // 
            // lblDangerLevel
            // 
            resources.ApplyResources(this.lblDangerLevel, "lblDangerLevel");
            this.lblDangerLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblDangerLevel.CausesValidation = false;
            this.lblDangerLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDangerLevel.Name = "lblDangerLevel";
            this.lblDangerLevel.Click += new System.EventHandler(this.lblDangerLevel_Click);
            // 
            // frmSetStockLevel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSetStockLevel";
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