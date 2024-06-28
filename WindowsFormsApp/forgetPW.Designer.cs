namespace WindowsFormsApp
{
    partial class frmForgetPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPW));
            this.lblYourLoginName = new System.Windows.Forms.Label();
            this.lblYouAreDealerOrLMStaff = new System.Windows.Forms.Label();
            this.radioButtonYouAreDealer = new System.Windows.Forms.RadioButton();
            this.radioButtonYouAreLMStaff = new System.Windows.Forms.RadioButton();
            this.txtYourLoginName = new System.Windows.Forms.TextBox();
            this.lblDelearName = new System.Windows.Forms.Label();
            this.txtDelearNmae = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSubmitMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYourLoginName
            // 
            resources.ApplyResources(this.lblYourLoginName, "lblYourLoginName");
            this.lblYourLoginName.Name = "lblYourLoginName";
            // 
            // lblYouAreDealerOrLMStaff
            // 
            resources.ApplyResources(this.lblYouAreDealerOrLMStaff, "lblYouAreDealerOrLMStaff");
            this.lblYouAreDealerOrLMStaff.Name = "lblYouAreDealerOrLMStaff";
            // 
            // radioButtonYouAreDealer
            // 
            resources.ApplyResources(this.radioButtonYouAreDealer, "radioButtonYouAreDealer");
            this.radioButtonYouAreDealer.Checked = true;
            this.radioButtonYouAreDealer.Name = "radioButtonYouAreDealer";
            this.radioButtonYouAreDealer.TabStop = true;
            this.radioButtonYouAreDealer.UseVisualStyleBackColor = true;
            // 
            // radioButtonYouAreLMStaff
            // 
            resources.ApplyResources(this.radioButtonYouAreLMStaff, "radioButtonYouAreLMStaff");
            this.radioButtonYouAreLMStaff.Name = "radioButtonYouAreLMStaff";
            this.radioButtonYouAreLMStaff.UseVisualStyleBackColor = true;
            this.radioButtonYouAreLMStaff.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtYourLoginName
            // 
            resources.ApplyResources(this.txtYourLoginName, "txtYourLoginName");
            this.txtYourLoginName.Name = "txtYourLoginName";
            // 
            // lblDelearName
            // 
            resources.ApplyResources(this.lblDelearName, "lblDelearName");
            this.lblDelearName.Name = "lblDelearName";
            // 
            // txtDelearNmae
            // 
            resources.ApplyResources(this.txtDelearNmae, "txtDelearNmae");
            this.txtDelearNmae.Name = "txtDelearNmae";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtSubmitMessage
            // 
            this.txtSubmitMessage.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtSubmitMessage, "txtSubmitMessage");
            this.txtSubmitMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSubmitMessage.Name = "txtSubmitMessage";
            this.txtSubmitMessage.ReadOnly = true;
            // 
            // frmForgetPW
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSubmitMessage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDelearNmae);
            this.Controls.Add(this.lblDelearName);
            this.Controls.Add(this.txtYourLoginName);
            this.Controls.Add(this.radioButtonYouAreLMStaff);
            this.Controls.Add(this.radioButtonYouAreDealer);
            this.Controls.Add(this.lblYouAreDealerOrLMStaff);
            this.Controls.Add(this.lblYourLoginName);
            this.Name = "frmForgetPW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourLoginName;
        private System.Windows.Forms.Label lblYouAreDealerOrLMStaff;
        private System.Windows.Forms.RadioButton radioButtonYouAreDealer;
        private System.Windows.Forms.RadioButton radioButtonYouAreLMStaff;
        private System.Windows.Forms.TextBox txtYourLoginName;
        private System.Windows.Forms.Label lblDelearName;
        private System.Windows.Forms.TextBox txtDelearNmae;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSubmitMessage;
    }
}