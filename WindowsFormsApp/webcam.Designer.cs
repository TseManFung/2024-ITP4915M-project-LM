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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebcam));
            this.lblCamera = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCamera
            // 
            resources.ApplyResources(this.lblCamera, "lblCamera");
            this.lblCamera.Name = "lblCamera";
            // 
            // cboCamera
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboCamera, 2);
            resources.ApplyResources(this.cboCamera, "cboCamera");
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.SelectedIndexChanged += new System.EventHandler(this.cboCamera_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.picCamera, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCamera, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCamera, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // picCamera
            // 
            this.picCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.picCamera, 3);
            resources.ApplyResources(this.picCamera, "picCamera");
            this.picCamera.Name = "picCamera";
            this.picCamera.TabStop = false;
            // 
            // lblCode
            // 
            resources.ApplyResources(this.lblCode, "lblCode");
            this.tableLayoutPanel1.SetColumnSpan(this.lblCode, 3);
            this.lblCode.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCode.Name = "lblCode";
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmWebcam
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmWebcam";
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