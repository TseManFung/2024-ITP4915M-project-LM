namespace WindowsFormsApp
{
    partial class frmReStockCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReStockCheck));
            this.dataGridViewItemHaveArrivedInROL = new System.Windows.Forms.DataGridView();
            this.lblFollowingROL = new System.Windows.Forms.Label();
            this.btnReceived = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemHaveArrivedInROL)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItemHaveArrivedInROL
            // 
            this.dataGridViewItemHaveArrivedInROL.AllowUserToAddRows = false;
            this.dataGridViewItemHaveArrivedInROL.AllowUserToDeleteRows = false;
            this.dataGridViewItemHaveArrivedInROL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItemHaveArrivedInROL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewItemHaveArrivedInROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewItemHaveArrivedInROL, 2);
            resources.ApplyResources(this.dataGridViewItemHaveArrivedInROL, "dataGridViewItemHaveArrivedInROL");
            this.dataGridViewItemHaveArrivedInROL.Name = "dataGridViewItemHaveArrivedInROL";
            this.dataGridViewItemHaveArrivedInROL.ReadOnly = true;
            this.dataGridViewItemHaveArrivedInROL.RowTemplate.Height = 24;
            this.dataGridViewItemHaveArrivedInROL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemHaveArrivedInROL_CellClick);
            this.dataGridViewItemHaveArrivedInROL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemHaveArrivedInROL_CellContentClick);
            // 
            // lblFollowingROL
            // 
            resources.ApplyResources(this.lblFollowingROL, "lblFollowingROL");
            this.tableLayoutPanel1.SetColumnSpan(this.lblFollowingROL, 2);
            this.lblFollowingROL.Name = "lblFollowingROL";
            this.lblFollowingROL.Click += new System.EventHandler(this.lblFollowingROL_Click);
            // 
            // btnReceived
            // 
            resources.ApplyResources(this.btnReceived, "btnReceived");
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.UseVisualStyleBackColor = true;
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblFollowingROL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReceived, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewItemHaveArrivedInROL, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // frmReStockCheck
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReStockCheck";
            this.Load += new System.EventHandler(this.frmReStockCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemHaveArrivedInROL)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewItemHaveArrivedInROL;
        private System.Windows.Forms.Label lblFollowingROL;
        private System.Windows.Forms.Button btnReceived;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}