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
            this.btnOK = new System.Windows.Forms.Button();
            this.comboBoxWarehouseName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(145, 145);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Confirm";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxWarehouseName
            // 
            this.comboBoxWarehouseName.FormattingEnabled = true;
            this.comboBoxWarehouseName.Location = new System.Drawing.Point(145, 90);
            this.comboBoxWarehouseName.Name = "comboBoxWarehouseName";
            this.comboBoxWarehouseName.Size = new System.Drawing.Size(200, 20);
            this.comboBoxWarehouseName.TabIndex = 2;
            this.comboBoxWarehouseName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold);
            this.input.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input.Location = new System.Drawing.Point(12, 25);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(333, 32);
            this.input.TabIndex = 4;
            this.input.Text = "Please specify a location";
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // TargetWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 201);
            this.Controls.Add(this.input);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxWarehouseName);
            this.Controls.Add(this.btnOK);
            this.MaximumSize = new System.Drawing.Size(426, 240);
            this.MinimumSize = new System.Drawing.Size(426, 240);
            this.Name = "TargetWarehouse";
            this.Text = "TargetWarehouse";
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