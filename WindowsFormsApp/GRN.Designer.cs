namespace WindowsFormsApp
{
    partial class frmGRN
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
            this.lblGOODSRECEIVEDNOTE = new System.Windows.Forms.Label();
            this.txtGOODSRECEIVEDNOTE = new System.Windows.Forms.TextBox();
            this.lblSUPPLIER = new System.Windows.Forms.Label();
            this.lblSerialStamp = new System.Windows.Forms.Label();
            this.txtSUPPLIER = new System.Windows.Forms.TextBox();
            this.txtSerialStamp = new System.Windows.Forms.TextBox();
            this.lblGRN = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGOODSRECEIVEDNOTE
            // 
            this.lblGOODSRECEIVEDNOTE.AutoSize = true;
            this.lblGOODSRECEIVEDNOTE.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblGOODSRECEIVEDNOTE.Location = new System.Drawing.Point(480, 191);
            this.lblGOODSRECEIVEDNOTE.Name = "lblGOODSRECEIVEDNOTE";
            this.lblGOODSRECEIVEDNOTE.Size = new System.Drawing.Size(371, 32);
            this.lblGOODSRECEIVEDNOTE.TabIndex = 77;
            this.lblGOODSRECEIVEDNOTE.Text = "GOODS RECEIVED NOTE:";
            // 
            // txtGOODSRECEIVEDNOTE
            // 
            this.txtGOODSRECEIVEDNOTE.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtGOODSRECEIVEDNOTE.Location = new System.Drawing.Point(975, 191);
            this.txtGOODSRECEIVEDNOTE.Name = "txtGOODSRECEIVEDNOTE";
            this.txtGOODSRECEIVEDNOTE.Size = new System.Drawing.Size(218, 46);
            this.txtGOODSRECEIVEDNOTE.TabIndex = 78;
            this.txtGOODSRECEIVEDNOTE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSUPPLIER
            // 
            this.lblSUPPLIER.AutoSize = true;
            this.lblSUPPLIER.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblSUPPLIER.Location = new System.Drawing.Point(598, 337);
            this.lblSUPPLIER.Name = "lblSUPPLIER";
            this.lblSUPPLIER.Size = new System.Drawing.Size(161, 32);
            this.lblSUPPLIER.TabIndex = 79;
            this.lblSUPPLIER.Text = "SUPPLIER:";
            // 
            // lblSerialStamp
            // 
            this.lblSerialStamp.AutoSize = true;
            this.lblSerialStamp.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblSerialStamp.Location = new System.Drawing.Point(598, 512);
            this.lblSerialStamp.Name = "lblSerialStamp";
            this.lblSerialStamp.Size = new System.Drawing.Size(175, 32);
            this.lblSerialStamp.TabIndex = 80;
            this.lblSerialStamp.Text = "Serial Stamp:";
            // 
            // txtSUPPLIER
            // 
            this.txtSUPPLIER.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtSUPPLIER.Location = new System.Drawing.Point(975, 323);
            this.txtSUPPLIER.Name = "txtSUPPLIER";
            this.txtSUPPLIER.Size = new System.Drawing.Size(218, 46);
            this.txtSUPPLIER.TabIndex = 81;
            // 
            // txtSerialStamp
            // 
            this.txtSerialStamp.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtSerialStamp.Location = new System.Drawing.Point(975, 512);
            this.txtSerialStamp.Name = "txtSerialStamp";
            this.txtSerialStamp.Size = new System.Drawing.Size(218, 46);
            this.txtSerialStamp.TabIndex = 82;
            // 
            // lblGRN
            // 
            this.lblGRN.AutoSize = true;
            this.lblGRN.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblGRN.Location = new System.Drawing.Point(793, 61);
            this.lblGRN.Name = "lblGRN";
            this.lblGRN.Size = new System.Drawing.Size(362, 32);
            this.lblGRN.TabIndex = 83;
            this.lblGRN.Text = "Goods Received note (GRN)";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(138, 130);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 76;
            this.pictureBoxBack.TabStop = false;
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1748, 12);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(144, 130);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 75;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBoxLogo.Location = new System.Drawing.Point(596, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(163, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 74;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblGRN);
            this.Controls.Add(this.txtSerialStamp);
            this.Controls.Add(this.txtSUPPLIER);
            this.Controls.Add(this.lblSerialStamp);
            this.Controls.Add(this.lblSUPPLIER);
            this.Controls.Add(this.txtGOODSRECEIVEDNOTE);
            this.Controls.Add(this.lblGOODSRECEIVEDNOTE);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "frmGRN";
            this.Text = "GRN(e-GRN) for LM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label lblGOODSRECEIVEDNOTE;
        private System.Windows.Forms.TextBox txtGOODSRECEIVEDNOTE;
        private System.Windows.Forms.Label lblSUPPLIER;
        private System.Windows.Forms.Label lblSerialStamp;
        private System.Windows.Forms.TextBox txtSUPPLIER;
        private System.Windows.Forms.TextBox txtSerialStamp;
        private System.Windows.Forms.Label lblGRN;
    }
}