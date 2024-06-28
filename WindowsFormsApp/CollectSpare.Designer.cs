namespace WindowsFormsApp
{
    partial class frmCollectSpare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollectSpare));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActualQuantity = new System.Windows.Forms.Label();
            this.numActualQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblFollowingCollect = new System.Windows.Forms.Label();
            this.dgvCollect = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpareNumberofBundles = new System.Windows.Forms.Label();
            this.numSpareNumberofBundles = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.comboBoxSpareID = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTurnOnScanner = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActualQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollect)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpareNumberofBundles)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFollowingCollect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCollect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.lblActualQuantity, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.numActualQuantity, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // lblActualQuantity
            // 
            resources.ApplyResources(this.lblActualQuantity, "lblActualQuantity");
            this.lblActualQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblActualQuantity.CausesValidation = false;
            this.lblActualQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActualQuantity.Name = "lblActualQuantity";
            // 
            // numActualQuantity
            // 
            resources.ApplyResources(this.numActualQuantity, "numActualQuantity");
            this.numActualQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numActualQuantity.Name = "numActualQuantity";
            // 
            // lblFollowingCollect
            // 
            resources.ApplyResources(this.lblFollowingCollect, "lblFollowingCollect");
            this.tableLayoutPanel1.SetColumnSpan(this.lblFollowingCollect, 2);
            this.lblFollowingCollect.Name = "lblFollowingCollect";
            // 
            // dgvCollect
            // 
            this.dgvCollect.AllowUserToAddRows = false;
            this.dgvCollect.AllowUserToDeleteRows = false;
            this.dgvCollect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCollect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCollect, 2);
            resources.ApplyResources(this.dgvCollect, "dgvCollect");
            this.dgvCollect.MultiSelect = false;
            this.dgvCollect.Name = "dgvCollect";
            this.dgvCollect.ReadOnly = true;
            this.dgvCollect.RowHeadersVisible = false;
            this.dgvCollect.RowTemplate.Height = 24;
            this.dgvCollect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCollect_CellClick);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.lblSpareNumberofBundles, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.numSpareNumberofBundles, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // lblSpareNumberofBundles
            // 
            resources.ApplyResources(this.lblSpareNumberofBundles, "lblSpareNumberofBundles");
            this.lblSpareNumberofBundles.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareNumberofBundles.CausesValidation = false;
            this.lblSpareNumberofBundles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareNumberofBundles.Name = "lblSpareNumberofBundles";
            // 
            // numSpareNumberofBundles
            // 
            resources.ApplyResources(this.numSpareNumberofBundles, "numSpareNumberofBundles");
            this.numSpareNumberofBundles.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSpareNumberofBundles.Name = "numSpareNumberofBundles";
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
            this.comboBoxSpareID.SelectedValueChanged += new System.EventHandler(this.comboBoxSpareID_SelectedValueChanged);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.btnTurnOnScanner, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // btnTurnOnScanner
            // 
            resources.ApplyResources(this.btnTurnOnScanner, "btnTurnOnScanner");
            this.btnTurnOnScanner.Name = "btnTurnOnScanner";
            this.btnTurnOnScanner.UseVisualStyleBackColor = true;
            this.btnTurnOnScanner.Click += new System.EventHandler(this.btnscanner_Click);
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmCollectSpare
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCollectSpare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCollectSpare_FormClosing);
            this.Load += new System.EventHandler(this.frmCollectSpare_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActualQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollect)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpareNumberofBundles)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFollowingCollect;
        private System.Windows.Forms.Button btnTurnOnScanner;
        private System.Windows.Forms.DataGridView dgvCollect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSpareID;
        public System.Windows.Forms.ComboBox comboBoxSpareID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblSpareNumberofBundles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblActualQuantity;
        private System.Windows.Forms.NumericUpDown numActualQuantity;
        private System.Windows.Forms.NumericUpDown numSpareNumberofBundles;
    }
}