namespace WindowsFormsApp
{
    partial class frmLanguage
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
            this.lblChooseYourLanguageEng = new System.Windows.Forms.Label();
            this.radioButtonEng = new System.Windows.Forms.RadioButton();
            this.radioButtonTw = new System.Windows.Forms.RadioButton();
            this.radioButtonChina = new System.Windows.Forms.RadioButton();
            this.lblChooseYourLanguageTW = new System.Windows.Forms.Label();
            this.lblChooseYourLanguageChina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChooseYourLanguageEng
            // 
            this.lblChooseYourLanguageEng.AutoSize = true;
            this.lblChooseYourLanguageEng.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblChooseYourLanguageEng.Location = new System.Drawing.Point(12, 9);
            this.lblChooseYourLanguageEng.Name = "lblChooseYourLanguageEng";
            this.lblChooseYourLanguageEng.Size = new System.Drawing.Size(282, 32);
            this.lblChooseYourLanguageEng.TabIndex = 0;
            this.lblChooseYourLanguageEng.Text = "Choose your language";
            // 
            // radioButtonEng
            // 
            this.radioButtonEng.AutoSize = true;
            this.radioButtonEng.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonEng.Location = new System.Drawing.Point(18, 135);
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.Size = new System.Drawing.Size(109, 31);
            this.radioButtonEng.TabIndex = 1;
            this.radioButtonEng.TabStop = true;
            this.radioButtonEng.Text = "English";
            this.radioButtonEng.UseVisualStyleBackColor = true;
            // 
            // radioButtonTw
            // 
            this.radioButtonTw.AutoSize = true;
            this.radioButtonTw.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonTw.Location = new System.Drawing.Point(18, 172);
            this.radioButtonTw.Name = "radioButtonTw";
            this.radioButtonTw.Size = new System.Drawing.Size(161, 31);
            this.radioButtonTw.TabIndex = 2;
            this.radioButtonTw.TabStop = true;
            this.radioButtonTw.Text = "中文 (繁體)";
            this.radioButtonTw.UseVisualStyleBackColor = true;
            // 
            // radioButtonChina
            // 
            this.radioButtonChina.AutoSize = true;
            this.radioButtonChina.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonChina.Location = new System.Drawing.Point(18, 209);
            this.radioButtonChina.Name = "radioButtonChina";
            this.radioButtonChina.Size = new System.Drawing.Size(161, 31);
            this.radioButtonChina.TabIndex = 3;
            this.radioButtonChina.TabStop = true;
            this.radioButtonChina.Text = "中文 (简体)";
            this.radioButtonChina.UseVisualStyleBackColor = true;
            // 
            // lblChooseYourLanguageTW
            // 
            this.lblChooseYourLanguageTW.AutoSize = true;
            this.lblChooseYourLanguageTW.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblChooseYourLanguageTW.Location = new System.Drawing.Point(12, 41);
            this.lblChooseYourLanguageTW.Name = "lblChooseYourLanguageTW";
            this.lblChooseYourLanguageTW.Size = new System.Drawing.Size(206, 32);
            this.lblChooseYourLanguageTW.TabIndex = 4;
            this.lblChooseYourLanguageTW.Text = "選擇你的語言";
            // 
            // lblChooseYourLanguageChina
            // 
            this.lblChooseYourLanguageChina.AutoSize = true;
            this.lblChooseYourLanguageChina.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblChooseYourLanguageChina.Location = new System.Drawing.Point(12, 73);
            this.lblChooseYourLanguageChina.Name = "lblChooseYourLanguageChina";
            this.lblChooseYourLanguageChina.Size = new System.Drawing.Size(206, 32);
            this.lblChooseYourLanguageChina.TabIndex = 5;
            this.lblChooseYourLanguageChina.Text = "选择你的语言";
            // 
            // frmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 252);
            this.Controls.Add(this.lblChooseYourLanguageChina);
            this.Controls.Add(this.lblChooseYourLanguageTW);
            this.Controls.Add(this.radioButtonChina);
            this.Controls.Add(this.radioButtonTw);
            this.Controls.Add(this.radioButtonEng);
            this.Controls.Add(this.lblChooseYourLanguageEng);
            this.Name = "frmLanguage";
            this.Text = "Language";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseYourLanguageEng;
        private System.Windows.Forms.RadioButton radioButtonEng;
        private System.Windows.Forms.RadioButton radioButtonTw;
        private System.Windows.Forms.RadioButton radioButtonChina;
        private System.Windows.Forms.Label lblChooseYourLanguageTW;
        private System.Windows.Forms.Label lblChooseYourLanguageChina;
    }
}