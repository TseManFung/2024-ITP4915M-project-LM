namespace WindowsFormsApp
{
    partial class TargetWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetWarehouse));
            this.btnOK = new System.Windows.Forms.Button();
            this.comboBoxWarehouseName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxWarehouseName
            // 
            this.comboBoxWarehouseName.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxWarehouseName, "comboBoxWarehouseName");
            this.comboBoxWarehouseName.Name = "comboBoxWarehouseName";
            this.comboBoxWarehouseName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            resources.ApplyResources(this.input, "input");
            this.input.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input.Name = "input";
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // TargetWarehouse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.input);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxWarehouseName);
            this.Controls.Add(this.btnOK);
            this.Name = "TargetWarehouse";
            this.Load += new System.EventHandler(this.TargetWarehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox comboBoxWarehouseName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label input;
    }
}