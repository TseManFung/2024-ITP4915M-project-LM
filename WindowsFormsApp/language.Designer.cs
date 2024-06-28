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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanguage));
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
            resources.ApplyResources(this.lblChooseYourLanguageEng, "lblChooseYourLanguageEng");
            this.lblChooseYourLanguageEng.Name = "lblChooseYourLanguageEng";
            // 
            // radioButtonEng
            // 
            resources.ApplyResources(this.radioButtonEng, "radioButtonEng");
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.TabStop = true;
            this.radioButtonEng.UseVisualStyleBackColor = true;
            // 
            // radioButtonTw
            // 
            resources.ApplyResources(this.radioButtonTw, "radioButtonTw");
            this.radioButtonTw.Name = "radioButtonTw";
            this.radioButtonTw.TabStop = true;
            this.radioButtonTw.UseVisualStyleBackColor = true;
            // 
            // radioButtonChina
            // 
            resources.ApplyResources(this.radioButtonChina, "radioButtonChina");
            this.radioButtonChina.Name = "radioButtonChina";
            this.radioButtonChina.TabStop = true;
            this.radioButtonChina.UseVisualStyleBackColor = true;
            // 
            // lblChooseYourLanguageTW
            // 
            resources.ApplyResources(this.lblChooseYourLanguageTW, "lblChooseYourLanguageTW");
            this.lblChooseYourLanguageTW.Name = "lblChooseYourLanguageTW";
            // 
            // lblChooseYourLanguageChina
            // 
            resources.ApplyResources(this.lblChooseYourLanguageChina, "lblChooseYourLanguageChina");
            this.lblChooseYourLanguageChina.Name = "lblChooseYourLanguageChina";
            // 
            // frmLanguage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChooseYourLanguageChina);
            this.Controls.Add(this.lblChooseYourLanguageTW);
            this.Controls.Add(this.radioButtonChina);
            this.Controls.Add(this.radioButtonTw);
            this.Controls.Add(this.radioButtonEng);
            this.Controls.Add(this.lblChooseYourLanguageEng);
            this.Name = "frmLanguage";
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