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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScrap));
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
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSpareID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscrepancy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDiscrepancy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRecord, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // comboBoxSpareID
            // 
            resources.ApplyResources(this.comboBoxSpareID, "comboBoxSpareID");
            this.comboBoxSpareID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpareID.FormattingEnabled = true;
            this.comboBoxSpareID.Name = "comboBoxSpareID";
            // 
            // txtDiscrepancy
            // 
            resources.ApplyResources(this.txtDiscrepancy, "txtDiscrepancy");
            this.txtDiscrepancy.Name = "txtDiscrepancy";
            this.txtDiscrepancy.TextChanged += new System.EventHandler(this.txtDiscrepancy_TextChanged);
            // 
            // txtQuantity
            // 
            resources.ApplyResources(this.txtQuantity, "txtQuantity");
            this.txtQuantity.Name = "txtQuantity";
            // 
            // lblDiscrepancy
            // 
            resources.ApplyResources(this.lblDiscrepancy, "lblDiscrepancy");
            this.lblDiscrepancy.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiscrepancy.CausesValidation = false;
            this.lblDiscrepancy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiscrepancy.Name = "lblDiscrepancy";
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.CausesValidation = false;
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Name = "lblQuantity";
            // 
            // lblSpareID
            // 
            resources.ApplyResources(this.lblSpareID, "lblSpareID");
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Name = "lblSpareID";
            // 
            // btnRecord
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnRecord, 2);
            resources.ApplyResources(this.btnRecord, "btnRecord");
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // frmScrap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmScrap";
            this.Load += new System.EventHandler(this.frmScrap_Load);
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