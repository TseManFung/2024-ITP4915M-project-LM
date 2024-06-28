namespace WindowsFormsApp
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDespatchForeman = new System.Windows.Forms.TextBox();
            this.lblDespatchForeman = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtINVOICEADDRESS = new System.Windows.Forms.TextBox();
            this.lblINVOICEADDRESS = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDELIVERYADDRESS = new System.Windows.Forms.TextBox();
            this.lblDELIVERYADDRESS = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDATE = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtYOURORDERNO = new System.Windows.Forms.TextBox();
            this.lblYOURORDERNO = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOURORDERNO = new System.Windows.Forms.TextBox();
            this.lblOURORDERTO = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDEALERCODE = new System.Windows.Forms.TextBox();
            this.lblDEALERCODE = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btnSign = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvInvoice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSign, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.txtDespatchForeman, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblDespatchForeman, 0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // txtDespatchForeman
            // 
            this.txtDespatchForeman.BackColor = System.Drawing.SystemColors.Control;
            this.txtDespatchForeman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDespatchForeman.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtDespatchForeman, "txtDespatchForeman");
            this.txtDespatchForeman.Name = "txtDespatchForeman";
            this.txtDespatchForeman.ReadOnly = true;
            // 
            // lblDespatchForeman
            // 
            resources.ApplyResources(this.lblDespatchForeman, "lblDespatchForeman");
            this.lblDespatchForeman.BackColor = System.Drawing.SystemColors.Control;
            this.lblDespatchForeman.CausesValidation = false;
            this.lblDespatchForeman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDespatchForeman.Name = "lblDespatchForeman";
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.txtTotalWeight, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblTotalWeight, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalWeight.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtTotalWeight, "txtTotalWeight");
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.ReadOnly = true;
            // 
            // lblTotalWeight
            // 
            resources.ApplyResources(this.lblTotalWeight, "lblTotalWeight");
            this.lblTotalWeight.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalWeight.CausesValidation = false;
            this.lblTotalWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalWeight.Name = "lblTotalWeight";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtINVOICEADDRESS, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblINVOICEADDRESS, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtINVOICEADDRESS
            // 
            this.txtINVOICEADDRESS.BackColor = System.Drawing.SystemColors.Control;
            this.txtINVOICEADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtINVOICEADDRESS.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtINVOICEADDRESS, "txtINVOICEADDRESS");
            this.txtINVOICEADDRESS.Name = "txtINVOICEADDRESS";
            this.txtINVOICEADDRESS.ReadOnly = true;
            // 
            // lblINVOICEADDRESS
            // 
            resources.ApplyResources(this.lblINVOICEADDRESS, "lblINVOICEADDRESS");
            this.lblINVOICEADDRESS.BackColor = System.Drawing.SystemColors.Control;
            this.lblINVOICEADDRESS.CausesValidation = false;
            this.lblINVOICEADDRESS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblINVOICEADDRESS.Name = "lblINVOICEADDRESS";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDELIVERYADDRESS, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDELIVERYADDRESS, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtDELIVERYADDRESS
            // 
            this.txtDELIVERYADDRESS.BackColor = System.Drawing.SystemColors.Control;
            this.txtDELIVERYADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDELIVERYADDRESS.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtDELIVERYADDRESS, "txtDELIVERYADDRESS");
            this.txtDELIVERYADDRESS.Name = "txtDELIVERYADDRESS";
            this.txtDELIVERYADDRESS.ReadOnly = true;
            // 
            // lblDELIVERYADDRESS
            // 
            resources.ApplyResources(this.lblDELIVERYADDRESS, "lblDELIVERYADDRESS");
            this.lblDELIVERYADDRESS.BackColor = System.Drawing.SystemColors.Control;
            this.lblDELIVERYADDRESS.CausesValidation = false;
            this.lblDELIVERYADDRESS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDELIVERYADDRESS.Name = "lblDELIVERYADDRESS";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.txtDate, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDATE, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            // 
            // lblDATE
            // 
            resources.ApplyResources(this.lblDATE, "lblDATE");
            this.lblDATE.BackColor = System.Drawing.SystemColors.Control;
            this.lblDATE.CausesValidation = false;
            this.lblDATE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDATE.Name = "lblDATE";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.txtYOURORDERNO, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblYOURORDERNO, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // txtYOURORDERNO
            // 
            this.txtYOURORDERNO.BackColor = System.Drawing.SystemColors.Control;
            this.txtYOURORDERNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYOURORDERNO.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtYOURORDERNO, "txtYOURORDERNO");
            this.txtYOURORDERNO.Name = "txtYOURORDERNO";
            this.txtYOURORDERNO.ReadOnly = true;
            // 
            // lblYOURORDERNO
            // 
            resources.ApplyResources(this.lblYOURORDERNO, "lblYOURORDERNO");
            this.lblYOURORDERNO.BackColor = System.Drawing.SystemColors.Control;
            this.lblYOURORDERNO.CausesValidation = false;
            this.lblYOURORDERNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYOURORDERNO.Name = "lblYOURORDERNO";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.txtOURORDERNO, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblOURORDERTO, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // txtOURORDERNO
            // 
            this.txtOURORDERNO.BackColor = System.Drawing.SystemColors.Control;
            this.txtOURORDERNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOURORDERNO.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtOURORDERNO, "txtOURORDERNO");
            this.txtOURORDERNO.Name = "txtOURORDERNO";
            this.txtOURORDERNO.ReadOnly = true;
            // 
            // lblOURORDERTO
            // 
            resources.ApplyResources(this.lblOURORDERTO, "lblOURORDERTO");
            this.lblOURORDERTO.BackColor = System.Drawing.SystemColors.Control;
            this.lblOURORDERTO.CausesValidation = false;
            this.lblOURORDERTO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOURORDERTO.Name = "lblOURORDERTO";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.txtDEALERCODE, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblDEALERCODE, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // txtDEALERCODE
            // 
            this.txtDEALERCODE.BackColor = System.Drawing.SystemColors.Control;
            this.txtDEALERCODE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDEALERCODE.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtDEALERCODE, "txtDEALERCODE");
            this.txtDEALERCODE.Name = "txtDEALERCODE";
            this.txtDEALERCODE.ReadOnly = true;
            // 
            // lblDEALERCODE
            // 
            resources.ApplyResources(this.lblDEALERCODE, "lblDEALERCODE");
            this.lblDEALERCODE.BackColor = System.Drawing.SystemColors.Control;
            this.lblDEALERCODE.CausesValidation = false;
            this.lblDEALERCODE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDEALERCODE.Name = "lblDEALERCODE";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToOrderColumns = true;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvInvoice, 4);
            resources.ApplyResources(this.dgvInvoice, "dgvInvoice");
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvInvoice, 2);
            this.dgvInvoice.RowTemplate.Height = 24;
            // 
            // btnSign
            // 
            resources.ApplyResources(this.btnSign, "btnSign");
            this.btnSign.Name = "btnSign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInvoice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmInvoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.Resize += new System.EventHandler(this.frmInvoice_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox txtDespatchForeman;
        private System.Windows.Forms.Label lblDespatchForeman;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtINVOICEADDRESS;
        private System.Windows.Forms.Label lblINVOICEADDRESS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtDELIVERYADDRESS;
        private System.Windows.Forms.Label lblDELIVERYADDRESS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDATE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtYOURORDERNO;
        private System.Windows.Forms.Label lblYOURORDERNO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtOURORDERNO;
        private System.Windows.Forms.Label lblOURORDERTO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtDEALERCODE;
        private System.Windows.Forms.Label lblDEALERCODE;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btnSign;
    }
}