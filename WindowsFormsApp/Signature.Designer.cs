namespace WindowsFormsApp
{
    partial class frmSignature
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
            this.groupBoxPleaseSignBelow = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.PSign = new System.Windows.Forms.Panel();
            this.groupBoxPleaseSignBelow.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPleaseSignBelow
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxPleaseSignBelow, 3);
            this.groupBoxPleaseSignBelow.Controls.Add(this.PSign);
            this.groupBoxPleaseSignBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPleaseSignBelow.Font = new System.Drawing.Font("新細明體", 24F);
            this.groupBoxPleaseSignBelow.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPleaseSignBelow.Name = "groupBoxPleaseSignBelow";
            this.groupBoxPleaseSignBelow.Size = new System.Drawing.Size(794, 354);
            this.groupBoxPleaseSignBelow.TabIndex = 0;
            this.groupBoxPleaseSignBelow.TabStop = false;
            this.groupBoxPleaseSignBelow.Text = "please sign below";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPleaseSignBelow, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnConfirm.Location = new System.Drawing.Point(643, 363);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(154, 84);
            this.btnConfirm.TabIndex = 97;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnClear.Location = new System.Drawing.Point(3, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 84);
            this.btnClear.TabIndex = 95;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PSign
            // 
            this.PSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSign.Location = new System.Drawing.Point(3, 42);
            this.PSign.Name = "PSign";
            this.PSign.Size = new System.Drawing.Size(788, 309);
            this.PSign.TabIndex = 0;
            // 
            // frmSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSignature";
            this.Text = "Signature";
            this.Load += new System.EventHandler(this.frmSignature_Load);
            this.groupBoxPleaseSignBelow.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPleaseSignBelow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel PSign;
    }
}