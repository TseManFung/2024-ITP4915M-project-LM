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
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreview.Font = new System.Drawing.Font("PMingLiU", 36F);
            this.lblPreview.Location = new System.Drawing.Point(3, 80);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(482, 53);
            this.lblPreview.TabIndex = 78;
            this.lblPreview.Text = "Preview:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPreview, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvPreview, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOutput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1198, 536);
            this.tableLayoutPanel1.TabIndex = 84;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.lblCondition, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(711, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel9, 2);
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(484, 127);
            this.tableLayoutPanel9.TabIndex = 95;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.SystemColors.Control;
            this.lblCondition.CausesValidation = false;
            this.lblCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCondition.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Bold);
            this.lblCondition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCondition.Location = new System.Drawing.Point(3, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(478, 63);
            this.lblCondition.TabIndex = 73;
            this.lblCondition.Text = "Condition: your working warehouse";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(478, 58);
            this.button1.TabIndex = 74;
            this.button1.Text = "make condition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblPeriod, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 74);
            this.tableLayoutPanel2.TabIndex = 87;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.BackColor = System.Drawing.SystemColors.Control;
            this.lblPeriod.CausesValidation = false;
            this.lblPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriod.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Bold);
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPeriod.Location = new System.Drawing.Point(3, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(476, 37);
            this.lblPeriod.TabIndex = 73;
            this.lblPeriod.Text = "Period:";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.dateTimePickerStart, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblTo, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.dateTimePickerEnd, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(476, 31);
            this.tableLayoutPanel8.TabIndex = 74;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePickerStart.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(207, 22);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTo.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.lblTo.Location = new System.Drawing.Point(216, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(44, 16);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "to";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(266, 3);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(207, 22);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblReportType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxReportType, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(491, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 74);
            this.tableLayoutPanel3.TabIndex = 88;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.BackColor = System.Drawing.SystemColors.Control;
            this.lblReportType.CausesValidation = false;
            this.lblReportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportType.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Bold);
            this.lblReportType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReportType.Location = new System.Drawing.Point(3, 0);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(208, 37);
            this.lblReportType.TabIndex = 73;
            this.lblReportType.Text = "Report Type:";
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportType.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "sale report (warehouse)",
            "sale report (spare)",
            "stock report",
            "scarp report"});
            this.comboBoxReportType.Location = new System.Drawing.Point(3, 40);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(208, 29);
            this.comboBoxReportType.TabIndex = 74;
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
            this.dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPreview.Location = new System.Drawing.Point(3, 136);
            this.dgvPreview.MultiSelect = false;
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreview.ShowCellErrors = false;
            this.dgvPreview.ShowCellToolTips = false;
            this.dgvPreview.ShowEditingIcon = false;
            this.dgvPreview.ShowRowErrors = false;
            this.dgvPreview.Size = new System.Drawing.Size(1192, 235);
            this.dgvPreview.TabIndex = 89;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtTotalNumberofItem, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalNumberofItem, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 377);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(482, 74);
            this.tableLayoutPanel4.TabIndex = 91;
            // 
            // txtTotalNumberofItem
            // 
            this.txtTotalNumberofItem.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalNumberofItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalNumberofItem.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalNumberofItem.Location = new System.Drawing.Point(3, 40);
            this.txtTotalNumberofItem.Multiline = true;
            this.txtTotalNumberofItem.Name = "txtTotalNumberofItem";
            this.txtTotalNumberofItem.ReadOnly = true;
            this.txtTotalNumberofItem.Size = new System.Drawing.Size(476, 31);
            this.txtTotalNumberofItem.TabIndex = 72;
            // 
            // lblTotalNumberofItem
            // 
            this.lblTotalNumberofItem.AutoSize = true;
            this.lblTotalNumberofItem.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalNumberofItem.CausesValidation = false;
            this.lblTotalNumberofItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalNumberofItem.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.lblTotalNumberofItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalNumberofItem.Location = new System.Drawing.Point(3, 0);
            this.lblTotalNumberofItem.Name = "lblTotalNumberofItem";
            this.lblTotalNumberofItem.Size = new System.Drawing.Size(476, 37);
            this.lblTotalNumberofItem.TabIndex = 73;
            this.lblTotalNumberofItem.Text = "Total number of item(s):";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.txtTotalNumberofDistinctItem, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblTotalNumberofDistinctItem, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(491, 377);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(214, 74);
            this.tableLayoutPanel6.TabIndex = 92;
            // 
            // txtTotalNumberofDistinctItem
            // 
            this.txtTotalNumberofDistinctItem.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalNumberofDistinctItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalNumberofDistinctItem.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalNumberofDistinctItem.Location = new System.Drawing.Point(3, 40);
            this.txtTotalNumberofDistinctItem.Multiline = true;
            this.txtTotalNumberofDistinctItem.Name = "txtTotalNumberofDistinctItem";
            this.txtTotalNumberofDistinctItem.ReadOnly = true;
            this.txtTotalNumberofDistinctItem.Size = new System.Drawing.Size(208, 31);
            this.txtTotalNumberofDistinctItem.TabIndex = 72;
            // 
            // lblTotalNumberofDistinctItem
            // 
            this.lblTotalNumberofDistinctItem.AutoSize = true;
            this.lblTotalNumberofDistinctItem.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalNumberofDistinctItem.CausesValidation = false;
            this.lblTotalNumberofDistinctItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalNumberofDistinctItem.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.lblTotalNumberofDistinctItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalNumberofDistinctItem.Location = new System.Drawing.Point(3, 0);
            this.lblTotalNumberofDistinctItem.Name = "lblTotalNumberofDistinctItem";
            this.lblTotalNumberofDistinctItem.Size = new System.Drawing.Size(208, 37);
            this.lblTotalNumberofDistinctItem.TabIndex = 73;
            this.lblTotalNumberofDistinctItem.Text = "Number of row:";
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOutput.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.btnOutput.Location = new System.Drawing.Point(491, 469);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(214, 52);
            this.btnOutput.TabIndex = 94;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.txtTotalPrice, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblTotalPrice, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(711, 377);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(484, 74);
            this.tableLayoutPanel7.TabIndex = 93;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalPrice.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPrice.Location = new System.Drawing.Point(3, 40);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(478, 31);
            this.txtTotalPrice.TabIndex = 72;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.CausesValidation = false;
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalPrice.Location = new System.Drawing.Point(3, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(478, 37);
            this.lblTotalPrice.TabIndex = 73;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReport";
            this.Text = "Report";
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