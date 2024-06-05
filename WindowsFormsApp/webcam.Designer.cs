namespace WindowsFormsApp
{
    partial class frmWebcam
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
            this.components = new System.ComponentModel.Container();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCamera.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCamera.Location = new System.Drawing.Point(3, 0);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(129, 90);
            this.lblCamera.TabIndex = 0;
            this.lblCamera.Text = "Camera:";
            this.lblCamera.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cboCamera
            // 
            this.cboCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.cboCamera, 2);
            this.cboCamera.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(138, 58);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(232, 29);
            this.cboCamera.TabIndex = 1;
            this.cboCamera.SelectedIndexChanged += new System.EventHandler(this.cboCamera_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.picCamera, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCamera, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCamera, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 452);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // picCamera
            // 
            this.picCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.picCamera, 3);
            this.picCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCamera.Location = new System.Drawing.Point(3, 93);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(399, 265);
            this.picCamera.TabIndex = 2;
            this.picCamera.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Location = new System.Drawing.Point(138, 361);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(129, 91);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "label1";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmWebcam";
            this.Text = "webcam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWebcam_FormClosing);
            this.Load += new System.EventHandler(this.frmWebcam_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCode;
    }
}