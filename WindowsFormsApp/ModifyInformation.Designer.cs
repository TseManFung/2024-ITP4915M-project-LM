namespace WindowsFormsApp
{
    partial class frmModifyInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyInformation));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOfficeAdress = new System.Windows.Forms.TextBox();
            this.lblOfficeAdress = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtOfficeAddress = new System.Windows.Forms.TextBox();
            this.lblOfficeAddress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 1, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.txtContactNumber, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblContactNumber, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // txtContactNumber
            // 
            resources.ApplyResources(this.txtContactNumber, "txtContactNumber");
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // lblContactNumber
            // 
            resources.ApplyResources(this.lblContactNumber, "lblContactNumber");
            this.lblContactNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblContactNumber.CausesValidation = false;
            this.lblContactNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContactNumber.Name = "lblContactNumber";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblEmail, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.CausesValidation = false;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Name = "lblEmail";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtOfficeAdress, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblOfficeAdress, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtOfficeAdress
            // 
            resources.ApplyResources(this.txtOfficeAdress, "txtOfficeAdress");
            this.txtOfficeAdress.Name = "txtOfficeAdress";
            this.txtOfficeAdress.TextChanged += new System.EventHandler(this.txtOfficeAdress_TextChanged);
            // 
            // lblOfficeAdress
            // 
            resources.ApplyResources(this.lblOfficeAdress, "lblOfficeAdress");
            this.lblOfficeAdress.BackColor = System.Drawing.SystemColors.Control;
            this.lblOfficeAdress.CausesValidation = false;
            this.lblOfficeAdress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOfficeAdress.Name = "lblOfficeAdress";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDeliveryAddress, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDeliveryAddress, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // txtDeliveryAddress
            // 
            resources.ApplyResources(this.txtDeliveryAddress, "txtDeliveryAddress");
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.TextChanged += new System.EventHandler(this.txtDeliveryAddress_TextChanged);
            // 
            // lblDeliveryAddress
            // 
            resources.ApplyResources(this.lblDeliveryAddress, "lblDeliveryAddress");
            this.lblDeliveryAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblDeliveryAddress.CausesValidation = false;
            this.lblDeliveryAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtOfficeAddress
            // 
            resources.ApplyResources(this.txtOfficeAddress, "txtOfficeAddress");
            this.txtOfficeAddress.Name = "txtOfficeAddress";
            // 
            // lblOfficeAddress
            // 
            resources.ApplyResources(this.lblOfficeAddress, "lblOfficeAddress");
            this.lblOfficeAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblOfficeAddress.CausesValidation = false;
            this.lblOfficeAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOfficeAddress.Name = "lblOfficeAddress";
            // 
            // frmModifyInformation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmModifyInformation";
            this.Load += new System.EventHandler(this.frmModifyInformation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtOfficeAddress;
        private System.Windows.Forms.Label lblOfficeAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtOfficeAdress;
        private System.Windows.Forms.Label lblOfficeAdress;
    }
}