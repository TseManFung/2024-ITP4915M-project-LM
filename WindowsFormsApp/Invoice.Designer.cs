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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDATE = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtYOURORDERNO = new System.Windows.Forms.TextBox();
            this.lblYOURORDERNO = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOURORDERTO = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1678, 513);
            this.tableLayoutPanel1.TabIndex = 115;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.txtDespatchForeman, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblDespatchForeman, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(422, 411);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(413, 99);
            this.tableLayoutPanel9.TabIndex = 92;
            // 
            // txtDespatchForeman
            // 
            this.txtDespatchForeman.BackColor = System.Drawing.SystemColors.Info;
            this.txtDespatchForeman.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDespatchForeman.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDespatchForeman.Location = new System.Drawing.Point(3, 52);
            this.txtDespatchForeman.Multiline = true;
            this.txtDespatchForeman.Name = "txtDespatchForeman";
            this.txtDespatchForeman.ReadOnly = true;
            this.txtDespatchForeman.Size = new System.Drawing.Size(407, 44);
            this.txtDespatchForeman.TabIndex = 47;
            // 
            // lblDespatchForeman
            // 
            this.lblDespatchForeman.AutoSize = true;
            this.lblDespatchForeman.BackColor = System.Drawing.SystemColors.Control;
            this.lblDespatchForeman.CausesValidation = false;
            this.lblDespatchForeman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDespatchForeman.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDespatchForeman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDespatchForeman.Location = new System.Drawing.Point(3, 0);
            this.lblDespatchForeman.Name = "lblDespatchForeman";
            this.lblDespatchForeman.Size = new System.Drawing.Size(407, 49);
            this.lblDespatchForeman.TabIndex = 50;
            this.lblDespatchForeman.Text = "Despatch Foreman:";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.txtTotalWeight, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblTotalWeight, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 411);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(413, 99);
            this.tableLayoutPanel8.TabIndex = 91;
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalWeight.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalWeight.Location = new System.Drawing.Point(3, 52);
            this.txtTotalWeight.Multiline = true;
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.ReadOnly = true;
            this.txtTotalWeight.Size = new System.Drawing.Size(407, 44);
            this.txtTotalWeight.TabIndex = 47;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalWeight.CausesValidation = false;
            this.lblTotalWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalWeight.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalWeight.Location = new System.Drawing.Point(3, 0);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(407, 49);
            this.lblTotalWeight.TabIndex = 50;
            this.lblTotalWeight.Text = "Total weight:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtINVOICEADDRESS, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblINVOICEADDRESS, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(413, 96);
            this.tableLayoutPanel4.TabIndex = 85;
            // 
            // txtINVOICEADDRESS
            // 
            this.txtINVOICEADDRESS.BackColor = System.Drawing.SystemColors.Info;
            this.txtINVOICEADDRESS.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtINVOICEADDRESS.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtINVOICEADDRESS.Location = new System.Drawing.Point(3, 51);
            this.txtINVOICEADDRESS.Multiline = true;
            this.txtINVOICEADDRESS.Name = "txtINVOICEADDRESS";
            this.txtINVOICEADDRESS.ReadOnly = true;
            this.txtINVOICEADDRESS.Size = new System.Drawing.Size(407, 42);
            this.txtINVOICEADDRESS.TabIndex = 47;
            // 
            // lblINVOICEADDRESS
            // 
            this.lblINVOICEADDRESS.AutoSize = true;
            this.lblINVOICEADDRESS.BackColor = System.Drawing.SystemColors.Control;
            this.lblINVOICEADDRESS.CausesValidation = false;
            this.lblINVOICEADDRESS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblINVOICEADDRESS.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblINVOICEADDRESS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblINVOICEADDRESS.Location = new System.Drawing.Point(3, 0);
            this.lblINVOICEADDRESS.Name = "lblINVOICEADDRESS";
            this.lblINVOICEADDRESS.Size = new System.Drawing.Size(407, 48);
            this.lblINVOICEADDRESS.TabIndex = 50;
            this.lblINVOICEADDRESS.Text = "INVOICE ADDRESS:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtDELIVERYADDRESS, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDELIVERYADDRESS, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(841, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 96);
            this.tableLayoutPanel2.TabIndex = 86;
            // 
            // txtDELIVERYADDRESS
            // 
            this.txtDELIVERYADDRESS.BackColor = System.Drawing.SystemColors.Info;
            this.txtDELIVERYADDRESS.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDELIVERYADDRESS.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDELIVERYADDRESS.Location = new System.Drawing.Point(3, 51);
            this.txtDELIVERYADDRESS.Multiline = true;
            this.txtDELIVERYADDRESS.Name = "txtDELIVERYADDRESS";
            this.txtDELIVERYADDRESS.ReadOnly = true;
            this.txtDELIVERYADDRESS.Size = new System.Drawing.Size(407, 42);
            this.txtDELIVERYADDRESS.TabIndex = 47;
            // 
            // lblDELIVERYADDRESS
            // 
            this.lblDELIVERYADDRESS.AutoSize = true;
            this.lblDELIVERYADDRESS.BackColor = System.Drawing.SystemColors.Control;
            this.lblDELIVERYADDRESS.CausesValidation = false;
            this.lblDELIVERYADDRESS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDELIVERYADDRESS.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDELIVERYADDRESS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDELIVERYADDRESS.Location = new System.Drawing.Point(3, 0);
            this.lblDELIVERYADDRESS.Name = "lblDELIVERYADDRESS";
            this.lblDELIVERYADDRESS.Size = new System.Drawing.Size(407, 48);
            this.lblDELIVERYADDRESS.TabIndex = 50;
            this.lblDELIVERYADDRESS.Text = "DELIVERY ADDRESS (IF DIFFERENT) (PER):";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDATE, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 105);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(413, 96);
            this.tableLayoutPanel3.TabIndex = 87;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(3, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(407, 42);
            this.textBox2.TabIndex = 47;
            // 
            // lblDATE
            // 
            this.lblDATE.AutoSize = true;
            this.lblDATE.BackColor = System.Drawing.SystemColors.Control;
            this.lblDATE.CausesValidation = false;
            this.lblDATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDATE.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDATE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDATE.Location = new System.Drawing.Point(3, 0);
            this.lblDATE.Name = "lblDATE";
            this.lblDATE.Size = new System.Drawing.Size(407, 48);
            this.lblDATE.TabIndex = 50;
            this.lblDATE.Text = "DATE:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtYOURORDERNO, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblYOURORDERNO, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(422, 105);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(413, 96);
            this.tableLayoutPanel5.TabIndex = 88;
            // 
            // txtYOURORDERNO
            // 
            this.txtYOURORDERNO.BackColor = System.Drawing.SystemColors.Info;
            this.txtYOURORDERNO.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtYOURORDERNO.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYOURORDERNO.Location = new System.Drawing.Point(3, 51);
            this.txtYOURORDERNO.Multiline = true;
            this.txtYOURORDERNO.Name = "txtYOURORDERNO";
            this.txtYOURORDERNO.ReadOnly = true;
            this.txtYOURORDERNO.Size = new System.Drawing.Size(407, 42);
            this.txtYOURORDERNO.TabIndex = 47;
            // 
            // lblYOURORDERNO
            // 
            this.lblYOURORDERNO.AutoSize = true;
            this.lblYOURORDERNO.BackColor = System.Drawing.SystemColors.Control;
            this.lblYOURORDERNO.CausesValidation = false;
            this.lblYOURORDERNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYOURORDERNO.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYOURORDERNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYOURORDERNO.Location = new System.Drawing.Point(3, 0);
            this.lblYOURORDERNO.Name = "lblYOURORDERNO";
            this.lblYOURORDERNO.Size = new System.Drawing.Size(407, 48);
            this.lblYOURORDERNO.TabIndex = 50;
            this.lblYOURORDERNO.Text = "YOUR ORDER NO:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.txtOURORDERTO, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblOURORDERTO, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(841, 105);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(413, 96);
            this.tableLayoutPanel6.TabIndex = 89;
            // 
            // txtOURORDERTO
            // 
            this.txtOURORDERTO.BackColor = System.Drawing.SystemColors.Info;
            this.txtOURORDERTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOURORDERTO.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOURORDERTO.Location = new System.Drawing.Point(3, 51);
            this.txtOURORDERTO.Multiline = true;
            this.txtOURORDERTO.Name = "txtOURORDERTO";
            this.txtOURORDERTO.ReadOnly = true;
            this.txtOURORDERTO.Size = new System.Drawing.Size(407, 42);
            this.txtOURORDERTO.TabIndex = 47;
            // 
            // lblOURORDERTO
            // 
            this.lblOURORDERTO.AutoSize = true;
            this.lblOURORDERTO.BackColor = System.Drawing.SystemColors.Control;
            this.lblOURORDERTO.CausesValidation = false;
            this.lblOURORDERTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOURORDERTO.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOURORDERTO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOURORDERTO.Location = new System.Drawing.Point(3, 0);
            this.lblOURORDERTO.Name = "lblOURORDERTO";
            this.lblOURORDERTO.Size = new System.Drawing.Size(407, 48);
            this.lblOURORDERTO.TabIndex = 50;
            this.lblOURORDERTO.Text = "OUR ORDER TO:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.txtDEALERCODE, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblDEALERCODE, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1260, 105);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(415, 96);
            this.tableLayoutPanel7.TabIndex = 90;
            // 
            // txtDEALERCODE
            // 
            this.txtDEALERCODE.BackColor = System.Drawing.SystemColors.Info;
            this.txtDEALERCODE.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDEALERCODE.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDEALERCODE.Location = new System.Drawing.Point(3, 51);
            this.txtDEALERCODE.Multiline = true;
            this.txtDEALERCODE.Name = "txtDEALERCODE";
            this.txtDEALERCODE.ReadOnly = true;
            this.txtDEALERCODE.Size = new System.Drawing.Size(409, 42);
            this.txtDEALERCODE.TabIndex = 47;
            // 
            // lblDEALERCODE
            // 
            this.lblDEALERCODE.AutoSize = true;
            this.lblDEALERCODE.BackColor = System.Drawing.SystemColors.Control;
            this.lblDEALERCODE.CausesValidation = false;
            this.lblDEALERCODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDEALERCODE.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDEALERCODE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDEALERCODE.Location = new System.Drawing.Point(3, 0);
            this.lblDEALERCODE.Name = "lblDEALERCODE";
            this.lblDEALERCODE.Size = new System.Drawing.Size(409, 48);
            this.lblDEALERCODE.TabIndex = 50;
            this.lblDEALERCODE.Text = "DEALER CODE:";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvInvoice, 4);
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.Location = new System.Drawing.Point(3, 207);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvInvoice, 2);
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(1672, 198);
            this.dgvInvoice.TabIndex = 93;
            // 
            // btnSign
            // 
            this.btnSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSign.Font = new System.Drawing.Font("PMingLiU", 24F);
            this.btnSign.Location = new System.Drawing.Point(1260, 411);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(415, 99);
            this.btnSign.TabIndex = 94;
            this.btnSign.Text = "Sign Here";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmInvoice";
            this.Text = "Invoice";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDATE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtYOURORDERNO;
        private System.Windows.Forms.Label lblYOURORDERNO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtOURORDERTO;
        private System.Windows.Forms.Label lblOURORDERTO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtDEALERCODE;
        private System.Windows.Forms.Label lblDEALERCODE;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btnSign;
    }
}