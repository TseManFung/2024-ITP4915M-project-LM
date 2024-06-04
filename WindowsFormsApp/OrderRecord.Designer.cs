namespace WindowsFormsApp
{
    partial class frmOrderRecord
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCheckDetail = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxComplete = new System.Windows.Forms.GroupBox();
            this.dgvComplete = new System.Windows.Forms.DataGridView();
            this.groupBoxProcessing = new System.Windows.Forms.GroupBox();
            this.dgvProcessing = new System.Windows.Forms.DataGridView();
            this.lblDoubleClickSeeMoreDetaill = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).BeginInit();
            this.groupBoxProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.btnSelect.Location = new System.Drawing.Point(1641, 96);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(143, 60);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCheckDetail
            // 
            this.btnCheckDetail.Location = new System.Drawing.Point(1597, 892);
            this.btnCheckDetail.Name = "btnCheckDetail";
            this.btnCheckDetail.Size = new System.Drawing.Size(187, 72);
            this.btnCheckDetail.TabIndex = 6;
            this.btnCheckDetail.Text = "Check Detail";
            this.btnCheckDetail.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxComplete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxProcessing, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDoubleClickSeeMoreDetaill, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 621);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBoxComplete
            // 
            this.groupBoxComplete.Controls.Add(this.dgvComplete);
            this.groupBoxComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxComplete.Location = new System.Drawing.Point(3, 338);
            this.groupBoxComplete.Name = "groupBoxComplete";
            this.groupBoxComplete.Size = new System.Drawing.Size(833, 280);
            this.groupBoxComplete.TabIndex = 9;
            this.groupBoxComplete.TabStop = false;
            this.groupBoxComplete.Text = "complete";
            // 
            // dgvComplete
            // 
            this.dgvComplete.AllowUserToAddRows = false;
            this.dgvComplete.AllowUserToDeleteRows = false;
            this.dgvComplete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComplete.Location = new System.Drawing.Point(3, 18);
            this.dgvComplete.MultiSelect = false;
            this.dgvComplete.Name = "dgvComplete";
            this.dgvComplete.ReadOnly = true;
            this.dgvComplete.RowTemplate.Height = 24;
            this.dgvComplete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplete.Size = new System.Drawing.Size(827, 259);
            this.dgvComplete.TabIndex = 9;
            this.dgvComplete.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProcessing_CellMouseDoubleClick);
            // 
            // groupBoxProcessing
            // 
            this.groupBoxProcessing.Controls.Add(this.dgvProcessing);
            this.groupBoxProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProcessing.Location = new System.Drawing.Point(3, 53);
            this.groupBoxProcessing.Name = "groupBoxProcessing";
            this.groupBoxProcessing.Size = new System.Drawing.Size(833, 279);
            this.groupBoxProcessing.TabIndex = 8;
            this.groupBoxProcessing.TabStop = false;
            this.groupBoxProcessing.Text = "Processing";
            // 
            // dgvProcessing
            // 
            this.dgvProcessing.AllowUserToAddRows = false;
            this.dgvProcessing.AllowUserToDeleteRows = false;
            this.dgvProcessing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcessing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProcessing.Location = new System.Drawing.Point(3, 18);
            this.dgvProcessing.MultiSelect = false;
            this.dgvProcessing.Name = "dgvProcessing";
            this.dgvProcessing.ReadOnly = true;
            this.dgvProcessing.RowTemplate.Height = 24;
            this.dgvProcessing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessing.Size = new System.Drawing.Size(827, 258);
            this.dgvProcessing.TabIndex = 8;
            this.dgvProcessing.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProcessing_CellMouseDoubleClick);
            // 
            // lblDoubleClickSeeMoreDetaill
            // 
            this.lblDoubleClickSeeMoreDetaill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoubleClickSeeMoreDetaill.AutoSize = true;
            this.lblDoubleClickSeeMoreDetaill.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.lblDoubleClickSeeMoreDetaill.Location = new System.Drawing.Point(173, 9);
            this.lblDoubleClickSeeMoreDetaill.Name = "lblDoubleClickSeeMoreDetaill";
            this.lblDoubleClickSeeMoreDetaill.Size = new System.Drawing.Size(492, 32);
            this.lblDoubleClickSeeMoreDetaill.TabIndex = 10;
            this.lblDoubleClickSeeMoreDetaill.Text = "double click a record to see more detaill";
            this.lblDoubleClickSeeMoreDetaill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOrderRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCheckDetail);
            this.Controls.Add(this.btnSelect);
            this.Name = "frmOrderRecord";
            this.Text = "Order Record";
            this.Load += new System.EventHandler(this.frmOrderRecord_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).EndInit();
            this.groupBoxProcessing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCheckDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxProcessing;
        private System.Windows.Forms.GroupBox groupBoxComplete;
        private System.Windows.Forms.DataGridView dgvComplete;
        private System.Windows.Forms.DataGridView dgvProcessing;
        public System.Windows.Forms.Label lblDoubleClickSeeMoreDetaill;
    }
}