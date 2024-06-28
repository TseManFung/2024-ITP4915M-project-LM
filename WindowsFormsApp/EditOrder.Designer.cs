namespace WindowsFormsApp
{
    partial class frmEditOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditOrder));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditYourOrderNumber = new System.Windows.Forms.Button();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxOrderSerial = new System.Windows.Forms.ComboBox();
            this.lblOrderSerial = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.txtSpareID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblYourOrderNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.comboBoxSpareName = new System.Windows.Forms.ComboBox();
            this.btnEditOrderItem = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteOrder, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEditYourOrderNumber, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel12, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnEditOrderItem, 2, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // buttonDeleteOrder
            // 
            resources.ApplyResources(this.buttonDeleteOrder, "buttonDeleteOrder");
            this.buttonDeleteOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // btnEditYourOrderNumber
            // 
            resources.ApplyResources(this.btnEditYourOrderNumber, "btnEditYourOrderNumber");
            this.btnEditYourOrderNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditYourOrderNumber.Name = "btnEditYourOrderNumber";
            this.btnEditYourOrderNumber.UseVisualStyleBackColor = true;
            this.btnEditYourOrderNumber.Click += new System.EventHandler(this.bunOrderNumber_Click);
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.tableLayoutPanel12.Controls.Add(this.comboBoxOrderSerial, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.lblOrderSerial, 0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            // 
            // comboBoxOrderSerial
            // 
            resources.ApplyResources(this.comboBoxOrderSerial, "comboBoxOrderSerial");
            this.comboBoxOrderSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderSerial.FormattingEnabled = true;
            this.comboBoxOrderSerial.Name = "comboBoxOrderSerial";
            this.comboBoxOrderSerial.SelectedValueChanged += new System.EventHandler(this.comboBoxOrderSerial_SelectedValueChanged);
            // 
            // lblOrderSerial
            // 
            resources.ApplyResources(this.lblOrderSerial, "lblOrderSerial");
            this.lblOrderSerial.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrderSerial.CausesValidation = false;
            this.lblOrderSerial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderSerial.Name = "lblOrderSerial";
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.lblSpareID, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSpareID, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // lblSpareID
            // 
            resources.ApplyResources(this.lblSpareID, "lblSpareID");
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Name = "lblSpareID";
            // 
            // txtSpareID
            // 
            this.txtSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.txtSpareID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpareID.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtSpareID, "txtSpareID");
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.txtOrderNumber, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblYourOrderNumber, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // txtOrderNumber
            // 
            resources.ApplyResources(this.txtOrderNumber, "txtOrderNumber");
            this.txtOrderNumber.Name = "txtOrderNumber";
            // 
            // lblYourOrderNumber
            // 
            resources.ApplyResources(this.lblYourOrderNumber, "lblYourOrderNumber");
            this.lblYourOrderNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblYourOrderNumber.CausesValidation = false;
            this.lblYourOrderNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYourOrderNumber.Name = "lblYourOrderNumber";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.lblQuantity, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.numericUpDownQuantity, 0, 1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.CausesValidation = false;
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Name = "lblQuantity";
            // 
            // numericUpDownQuantity
            // 
            resources.ApplyResources(this.numericUpDownQuantity, "numericUpDownQuantity");
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblSpareName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSpareName, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblSpareName
            // 
            resources.ApplyResources(this.lblSpareName, "lblSpareName");
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Name = "lblSpareName";
            // 
            // comboBoxSpareName
            // 
            resources.ApplyResources(this.comboBoxSpareName, "comboBoxSpareName");
            this.comboBoxSpareName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpareName.FormattingEnabled = true;
            this.comboBoxSpareName.Name = "comboBoxSpareName";
            this.comboBoxSpareName.SelectedValueChanged += new System.EventHandler(this.comboBoxSpareName_SelectedValueChanged);
            // 
            // btnEditOrderItem
            // 
            resources.ApplyResources(this.btnEditOrderItem, "btnEditOrderItem");
            this.btnEditOrderItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditOrderItem.Name = "btnEditOrderItem";
            this.btnEditOrderItem.UseVisualStyleBackColor = true;
            this.btnEditOrderItem.Click += new System.EventHandler(this.btnOrderItem_Click);
            // 
            // frmEditOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmEditOrder";
            this.Load += new System.EventHandler(this.frmEditOrder_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEditOrderItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label lblOrderSerial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblYourOrderNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSpareName;
        public System.Windows.Forms.ComboBox comboBoxSpareName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditYourOrderNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblSpareID;
        private System.Windows.Forms.TextBox txtSpareID;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        public System.Windows.Forms.ComboBox comboBoxOrderSerial;
        private System.Windows.Forms.Button buttonDeleteOrder;
    }
}