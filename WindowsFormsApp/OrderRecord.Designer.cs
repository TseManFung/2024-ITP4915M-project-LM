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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderRecord));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCheckDetail = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxComplete = new System.Windows.Forms.GroupBox();
            this.dgvComplete = new System.Windows.Forms.DataGridView();
            this.groupBoxProcessing = new System.Windows.Forms.GroupBox();
            this.dgvProcessing = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDoubleClickSeeMoreDetaill = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).BeginInit();
            this.groupBoxProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCheckDetail
            // 
            resources.ApplyResources(this.btnCheckDetail, "btnCheckDetail");
            this.btnCheckDetail.Name = "btnCheckDetail";
            this.btnCheckDetail.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBoxComplete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxProcessing, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBoxComplete
            // 
            this.groupBoxComplete.Controls.Add(this.dgvComplete);
            resources.ApplyResources(this.groupBoxComplete, "groupBoxComplete");
            this.groupBoxComplete.Name = "groupBoxComplete";
            this.groupBoxComplete.TabStop = false;
            // 
            // dgvComplete
            // 
            this.dgvComplete.AllowUserToAddRows = false;
            this.dgvComplete.AllowUserToDeleteRows = false;
            this.dgvComplete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvComplete, "dgvComplete");
            this.dgvComplete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComplete.MultiSelect = false;
            this.dgvComplete.Name = "dgvComplete";
            this.dgvComplete.ReadOnly = true;
            this.dgvComplete.RowTemplate.Height = 24;
            this.dgvComplete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplete.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComplete_CellMouseDoubleClick);
            this.dgvComplete.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvComplete_Scroll);
            // 
            // groupBoxProcessing
            // 
            this.groupBoxProcessing.Controls.Add(this.dgvProcessing);
            resources.ApplyResources(this.groupBoxProcessing, "groupBoxProcessing");
            this.groupBoxProcessing.Name = "groupBoxProcessing";
            this.groupBoxProcessing.TabStop = false;
            // 
            // dgvProcessing
            // 
            this.dgvProcessing.AllowUserToAddRows = false;
            this.dgvProcessing.AllowUserToDeleteRows = false;
            this.dgvProcessing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvProcessing, "dgvProcessing");
            this.dgvProcessing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProcessing.MultiSelect = false;
            this.dgvProcessing.Name = "dgvProcessing";
            this.dgvProcessing.ReadOnly = true;
            this.dgvProcessing.RowTemplate.Height = 24;
            this.dgvProcessing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessing.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProcessing_CellMouseDoubleClick);
            this.dgvProcessing.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvProcessing_Scroll);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDoubleClickSeeMoreDetaill, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // lblDoubleClickSeeMoreDetaill
            // 
            resources.ApplyResources(this.lblDoubleClickSeeMoreDetaill, "lblDoubleClickSeeMoreDetaill");
            this.lblDoubleClickSeeMoreDetaill.Name = "lblDoubleClickSeeMoreDetaill";
            // 
            // frmOrderRecord
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCheckDetail);
            this.Controls.Add(this.btnSelect);
            this.Name = "frmOrderRecord";
            this.Load += new System.EventHandler(this.frmOrderRecord_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).EndInit();
            this.groupBoxProcessing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label lblDoubleClickSeeMoreDetaill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}