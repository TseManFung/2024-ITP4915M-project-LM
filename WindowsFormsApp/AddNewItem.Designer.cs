namespace WindowsFormsApp
{
    partial class frmAddNewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewItem));
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSpareWeight = new System.Windows.Forms.Label();
            this.txtSpareWeight = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.lblSpareType = new System.Windows.Forms.Label();
            this.txtSpareName = new System.Windows.Forms.TextBox();
            this.comboBoxSpareType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSparePrice = new System.Windows.Forms.Label();
            this.txtSparePrice = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            resources.ApplyResources(this.lblSupplier, "lblSupplier");
            this.lblSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.lblSupplier.CausesValidation = false;
            this.lblSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplier.Name = "lblSupplier";
            // 
            // lblSpareWeight
            // 
            resources.ApplyResources(this.lblSpareWeight, "lblSpareWeight");
            this.lblSpareWeight.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareWeight.CausesValidation = false;
            this.lblSpareWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareWeight.Name = "lblSpareWeight";
            // 
            // txtSpareWeight
            // 
            resources.ApplyResources(this.txtSpareWeight, "txtSpareWeight");
            this.txtSpareWeight.Name = "txtSpareWeight";
            this.txtSpareWeight.TextChanged += new System.EventHandler(this.txtSpareWeight_TextChanged);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSpareName
            // 
            resources.ApplyResources(this.lblSpareName, "lblSpareName");
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Name = "lblSpareName";
            // 
            // lblSpareType
            // 
            resources.ApplyResources(this.lblSpareType, "lblSpareType");
            this.lblSpareType.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareType.CausesValidation = false;
            this.lblSpareType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareType.Name = "lblSpareType";
            // 
            // txtSpareName
            // 
            resources.ApplyResources(this.txtSpareName, "txtSpareName");
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.TextChanged += new System.EventHandler(this.txtSpareName_TextChanged);
            // 
            // comboBoxSpareType
            // 
            resources.ApplyResources(this.comboBoxSpareType, "comboBoxSpareType");
            this.comboBoxSpareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpareType.FormattingEnabled = true;
            this.comboBoxSpareType.Name = "comboBoxSpareType";
            this.comboBoxSpareType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpareType_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.CausesValidation = false;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Name = "lblDescription";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            // 
            // lblSparePrice
            // 
            resources.ApplyResources(this.lblSparePrice, "lblSparePrice");
            this.lblSparePrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblSparePrice.CausesValidation = false;
            this.lblSparePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSparePrice.Name = "lblSparePrice";
            // 
            // txtSparePrice
            // 
            resources.ApplyResources(this.txtSparePrice, "txtSparePrice");
            this.txtSparePrice.Name = "txtSparePrice";
            this.txtSparePrice.TextChanged += new System.EventHandler(this.txtSparePrice_TextChanged);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(this.tableLayoutPanel11, "tableLayoutPanel11");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel11, 5);
            this.tableLayoutPanel11.Controls.Add(this.textBoxDescription, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.labelDescription, 0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.BackColor = System.Drawing.SystemColors.Control;
            this.labelDescription.CausesValidation = false;
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDescription.Name = "labelDescription";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.comboBoxSupplier, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblSupplier, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // comboBoxSupplier
            // 
            resources.ApplyResources(this.comboBoxSupplier, "comboBoxSupplier");
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplier_SelectedIndexChanged);
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.txtSpareWeight, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblSpareWeight, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.txtSparePrice, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblSparePrice, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtSpareName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSpareName, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblSpareType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSpareType, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // frmAddNewItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Name = "frmAddNewItem";
            this.Load += new System.EventHandler(this.frmAddNewItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSpareWeight;
        private System.Windows.Forms.TextBox txtSpareWeight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSpareName;
        private System.Windows.Forms.Label lblSpareType;
        private System.Windows.Forms.TextBox txtSpareName;
        public System.Windows.Forms.ComboBox comboBoxSpareType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSparePrice;
        private System.Windows.Forms.TextBox txtSparePrice;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public System.Windows.Forms.ComboBox comboBoxSupplier;
    }
}