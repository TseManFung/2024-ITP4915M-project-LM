namespace WindowsFormsApp
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.lblPreview = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCondition = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReportType = new System.Windows.Forms.Label();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalNumberofItem = new System.Windows.Forms.TextBox();
            this.lblTotalNumberofItem = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalNumberofDistinctItem = new System.Windows.Forms.TextBox();
            this.lblTotalNumberofDistinctItem = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPreview
            // 
            resources.ApplyResources(this.lblPreview, "lblPreview");
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Name = "lblPreview";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPreview, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvPreview, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOutput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.lblCondition, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel9, 2);
            // 
            // lblCondition
            // 
            resources.ApplyResources(this.lblCondition, "lblCondition");
            this.lblCondition.BackColor = System.Drawing.SystemColors.Control;
            this.lblCondition.CausesValidation = false;
            this.lblCondition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCondition.Name = "lblCondition";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.lblPeriod, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // lblPeriod
            // 
            resources.ApplyResources(this.lblPeriod, "lblPeriod");
            this.lblPeriod.BackColor = System.Drawing.SystemColors.Control;
            this.lblPeriod.CausesValidation = false;
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPeriod.Name = "lblPeriod";
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.dateTimePickerStart, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblTo, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.dateTimePickerEnd, 2, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // dateTimePickerStart
            // 
            resources.ApplyResources(this.dateTimePickerStart, "dateTimePickerStart");
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            // 
            // lblTo
            // 
            resources.ApplyResources(this.lblTo, "lblTo");
            this.lblTo.Name = "lblTo";
            // 
            // dateTimePickerEnd
            // 
            resources.ApplyResources(this.dateTimePickerEnd, "dateTimePickerEnd");
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblReportType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxReportType, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblReportType
            // 
            resources.ApplyResources(this.lblReportType, "lblReportType");
            this.lblReportType.BackColor = System.Drawing.SystemColors.Control;
            this.lblReportType.CausesValidation = false;
            this.lblReportType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReportType.Name = "lblReportType";
            // 
            // comboBoxReportType
            // 
            resources.ApplyResources(this.comboBoxReportType, "comboBoxReportType");
            this.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            resources.GetString("comboBoxReportType.Items"),
            resources.GetString("comboBoxReportType.Items1"),
            resources.GetString("comboBoxReportType.Items2"),
            resources.GetString("comboBoxReportType.Items3"),
            resources.GetString("comboBoxReportType.Items4"),
            resources.GetString("comboBoxReportType.Items5")});
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.SelectedIndexChanged += new System.EventHandler(this.comboBoxReportType_SelectedIndexChanged);
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvPreview, 3);
            resources.ApplyResources(this.dgvPreview, "dgvPreview");
            this.dgvPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPreview.MultiSelect = false;
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreview.ShowCellErrors = false;
            this.dgvPreview.ShowCellToolTips = false;
            this.dgvPreview.ShowEditingIcon = false;
            this.dgvPreview.ShowRowErrors = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtTotalNumberofItem, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalNumberofItem, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtTotalNumberofItem
            // 
            this.txtTotalNumberofItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalNumberofItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalNumberofItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtTotalNumberofItem, "txtTotalNumberofItem");
            this.txtTotalNumberofItem.Name = "txtTotalNumberofItem";
            this.txtTotalNumberofItem.ReadOnly = true;
            // 
            // lblTotalNumberofItem
            // 
            resources.ApplyResources(this.lblTotalNumberofItem, "lblTotalNumberofItem");
            this.lblTotalNumberofItem.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalNumberofItem.CausesValidation = false;
            this.lblTotalNumberofItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalNumberofItem.Name = "lblTotalNumberofItem";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.txtTotalNumberofDistinctItem, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblTotalNumberofDistinctItem, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // txtTotalNumberofDistinctItem
            // 
            this.txtTotalNumberofDistinctItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalNumberofDistinctItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalNumberofDistinctItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtTotalNumberofDistinctItem, "txtTotalNumberofDistinctItem");
            this.txtTotalNumberofDistinctItem.Name = "txtTotalNumberofDistinctItem";
            this.txtTotalNumberofDistinctItem.ReadOnly = true;
            // 
            // lblTotalNumberofDistinctItem
            // 
            resources.ApplyResources(this.lblTotalNumberofDistinctItem, "lblTotalNumberofDistinctItem");
            this.lblTotalNumberofDistinctItem.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalNumberofDistinctItem.CausesValidation = false;
            this.lblTotalNumberofDistinctItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalNumberofDistinctItem.Name = "lblTotalNumberofDistinctItem";
            // 
            // btnOutput
            // 
            resources.ApplyResources(this.btnOutput, "btnOutput");
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.txtTotalPrice, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblTotalPrice, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtTotalPrice, "txtTotalPrice");
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            // 
            // lblTotalPrice
            // 
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.CausesValidation = false;
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalPrice.Name = "lblTotalPrice";
            // 
            // frmReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReport";
            this.Resize += new System.EventHandler(this.frmReport_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtTotalNumberofItem;
        private System.Windows.Forms.Label lblTotalNumberofItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtTotalNumberofDistinctItem;
        private System.Windows.Forms.Label lblTotalNumberofDistinctItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Button button1;
    }
}