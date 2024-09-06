namespace WindowsFormsApp
{
    partial class WB
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.WBMain = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtUrl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WBMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Location = new System.Drawing.Point(3, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(694, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnUrl_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Location = new System.Drawing.Point(703, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 34);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // WBMain
            // 
            this.WBMain.ActivateBrowserOnCreation = false;
            this.tableLayoutPanel1.SetColumnSpan(this.WBMain, 2);
            this.WBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBMain.Location = new System.Drawing.Point(3, 43);
            this.WBMain.Name = "WBMain";
            this.WBMain.Size = new System.Drawing.Size(794, 404);
            this.WBMain.TabIndex = 2;
            // 
            // WB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WB";
            this.Text = "WB";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private CefSharp.WinForms.ChromiumWebBrowser WBMain;
    }
}