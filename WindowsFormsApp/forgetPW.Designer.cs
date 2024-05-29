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
            this.lblYourLoginName.AutoSize = true;
            this.lblYourLoginName.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblYourLoginName.Location = new System.Drawing.Point(166, 35);
            this.lblYourLoginName.Name = "lblYourLoginName";
            this.lblYourLoginName.Size = new System.Drawing.Size(225, 32);
            this.lblYourLoginName.TabIndex = 0;
            this.lblYourLoginName.Text = "Your login name:";
            // 
            // lblYouAreDealerOrLMStaff
            // 
            this.lblYouAreDealerOrLMStaff.AutoSize = true;
            this.lblYouAreDealerOrLMStaff.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblYouAreDealerOrLMStaff.Location = new System.Drawing.Point(46, 114);
            this.lblYouAreDealerOrLMStaff.Name = "lblYouAreDealerOrLMStaff";
            this.lblYouAreDealerOrLMStaff.Size = new System.Drawing.Size(345, 32);
            this.lblYouAreDealerOrLMStaff.TabIndex = 1;
            this.lblYouAreDealerOrLMStaff.Text = "You are dealer or LM staff:";
            // 
            // radioButtonYouAreDealer
            // 
            this.radioButtonYouAreDealer.AutoSize = true;
            this.radioButtonYouAreDealer.Checked = true;
            this.radioButtonYouAreDealer.Font = new System.Drawing.Font("新細明體", 24F);
            this.radioButtonYouAreDealer.Location = new System.Drawing.Point(397, 114);
            this.radioButtonYouAreDealer.Name = "radioButtonYouAreDealer";
            this.radioButtonYouAreDealer.Size = new System.Drawing.Size(104, 36);
            this.radioButtonYouAreDealer.TabIndex = 2;
            this.radioButtonYouAreDealer.TabStop = true;
            this.radioButtonYouAreDealer.Text = "dealer";
            this.radioButtonYouAreDealer.UseVisualStyleBackColor = true;
            // 
            // radioButtonYouAreLMStaff
            // 
            this.radioButtonYouAreLMStaff.AutoSize = true;
            this.radioButtonYouAreLMStaff.Font = new System.Drawing.Font("新細明體", 24F);
            this.radioButtonYouAreLMStaff.Location = new System.Drawing.Point(518, 114);
            this.radioButtonYouAreLMStaff.Name = "radioButtonYouAreLMStaff";
            this.radioButtonYouAreLMStaff.Size = new System.Drawing.Size(138, 36);
            this.radioButtonYouAreLMStaff.TabIndex = 3;
            this.radioButtonYouAreLMStaff.Text = "LM staff";
            this.radioButtonYouAreLMStaff.UseVisualStyleBackColor = true;
            this.radioButtonYouAreLMStaff.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtYourLoginName
            // 
            this.txtYourLoginName.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtYourLoginName.Location = new System.Drawing.Point(407, 21);
            this.txtYourLoginName.Name = "txtYourLoginName";
            this.txtYourLoginName.Size = new System.Drawing.Size(249, 46);
            this.txtYourLoginName.TabIndex = 4;
            // 
            // lblDelearName
            // 
            this.lblDelearName.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblDelearName.Location = new System.Drawing.Point(52, 187);
            this.lblDelearName.Name = "lblDelearName";
            this.lblDelearName.Size = new System.Drawing.Size(339, 32);
            this.lblDelearName.TabIndex = 5;
            this.lblDelearName.Text = "Dealer name:";
            this.lblDelearName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDelearNmae
            // 
            this.txtDelearNmae.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtDelearNmae.Location = new System.Drawing.Point(407, 187);
            this.txtDelearNmae.Name = "txtDelearNmae";
            this.txtDelearNmae.Size = new System.Drawing.Size(249, 46);
            this.txtDelearNmae.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnSubmit.Location = new System.Drawing.Point(254, 289);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(247, 49);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtSubmitMessage
            // 
            this.txtSubmitMessage.BackColor = System.Drawing.SystemColors.Info;
            this.txtSubmitMessage.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtSubmitMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSubmitMessage.Location = new System.Drawing.Point(12, 369);
            this.txtSubmitMessage.Name = "txtSubmitMessage";
            this.txtSubmitMessage.ReadOnly = true;
            this.txtSubmitMessage.Size = new System.Drawing.Size(776, 46);
            this.txtSubmitMessage.TabIndex = 8;
            // 
            // frmForgetPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "forget password";
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