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
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblYearlyOrMonthly = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblReportType = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.txtYearlyOrMonthly = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtReportType = new System.Windows.Forms.TextBox();
            this.lstPreview = new System.Windows.Forms.ListBox();
            this.btnOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1748, -1);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(144, 130);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 71;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBoxLogo.Location = new System.Drawing.Point(667, -1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(163, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 72;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(1, -1);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(138, 130);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 73;
            this.pictureBoxBack.TabStop = false;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("新細明體", 72F);
            this.lblReport.Location = new System.Drawing.Point(848, 9);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(285, 96);
            this.lblReport.TabIndex = 74;
            this.lblReport.Text = "Report";
            // 
            // lblYearlyOrMonthly
            // 
            this.lblYearlyOrMonthly.AutoSize = true;
            this.lblYearlyOrMonthly.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblYearlyOrMonthly.Location = new System.Drawing.Point(144, 178);
            this.lblYearlyOrMonthly.Name = "lblYearlyOrMonthly";
            this.lblYearlyOrMonthly.Size = new System.Drawing.Size(328, 48);
            this.lblYearlyOrMonthly.TabIndex = 75;
            this.lblYearlyOrMonthly.Text = "Yearly/Monthly:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblPeriod.Location = new System.Drawing.Point(822, 178);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(152, 48);
            this.lblPeriod.TabIndex = 76;
            this.lblPeriod.Text = "Period:";
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblReportType.Location = new System.Drawing.Point(1318, 178);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(263, 48);
            this.lblReportType.TabIndex = 77;
            this.lblReportType.Text = "Report Type:";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblPreview.Location = new System.Drawing.Point(144, 421);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(182, 48);
            this.lblPreview.TabIndex = 78;
            this.lblPreview.Text = "Preview:";
            // 
            // txtYearlyOrMonthly
            // 
            this.txtYearlyOrMonthly.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtYearlyOrMonthly.Location = new System.Drawing.Point(186, 321);
            this.txtYearlyOrMonthly.Name = "txtYearlyOrMonthly";
            this.txtYearlyOrMonthly.Size = new System.Drawing.Size(168, 46);
            this.txtYearlyOrMonthly.TabIndex = 79;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtPeriod.Location = new System.Drawing.Point(806, 305);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(168, 46);
            this.txtPeriod.TabIndex = 80;
            // 
            // txtReportType
            // 
            this.txtReportType.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtReportType.Location = new System.Drawing.Point(1366, 321);
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.Size = new System.Drawing.Size(168, 46);
            this.txtReportType.TabIndex = 81;
            // 
            // lstPreview
            // 
            this.lstPreview.FormattingEnabled = true;
            this.lstPreview.ItemHeight = 12;
            this.lstPreview.Location = new System.Drawing.Point(190, 512);
            this.lstPreview.Name = "lstPreview";
            this.lstPreview.Size = new System.Drawing.Size(1344, 208);
            this.lstPreview.TabIndex = 82;
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnOutput.Location = new System.Drawing.Point(1650, 242);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(242, 109);
            this.btnOutput.TabIndex = 83;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lstPreview);
            this.Controls.Add(this.txtReportType);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtYearlyOrMonthly);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblYearlyOrMonthly);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Name = "frmReport";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblYearlyOrMonthly;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.TextBox txtYearlyOrMonthly;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtReportType;
        private System.Windows.Forms.ListBox lstPreview;
        private System.Windows.Forms.Button btnOutput;
    }
}