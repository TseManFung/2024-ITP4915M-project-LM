namespace WindowsFormsApp
{
    partial class frmNewDealer
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
            this.AddNewStaff = new System.Windows.Forms.Label();
            this.txtInfromation = new System.Windows.Forms.TextBox();
            this.btnCencel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewStaff
            // 
            this.AddNewStaff.AutoSize = true;
            this.AddNewStaff.Font = new System.Drawing.Font("新細明體", 36F);
            this.AddNewStaff.Location = new System.Drawing.Point(625, 119);
            this.AddNewStaff.Name = "AddNewStaff";
            this.AddNewStaff.Size = new System.Drawing.Size(350, 48);
            this.AddNewStaff.TabIndex = 1;
            this.AddNewStaff.Text = "Add New Dealer?";
            // 
            // txtInfromation
            // 
            this.txtInfromation.Font = new System.Drawing.Font("新細明體", 36F);
            this.txtInfromation.Location = new System.Drawing.Point(616, 325);
            this.txtInfromation.Name = "txtInfromation";
            this.txtInfromation.Size = new System.Drawing.Size(385, 65);
            this.txtInfromation.TabIndex = 5;
            // 
            // btnCencel
            // 
            this.btnCencel.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnCencel.Location = new System.Drawing.Point(1008, 543);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(139, 79);
            this.btnCencel.TabIndex = 6;
            this.btnCencel.Text = "Cencel";
            this.btnCencel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnEdit.Location = new System.Drawing.Point(738, 543);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 79);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnConfirm.Location = new System.Drawing.Point(395, 543);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(139, 79);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // frmNewDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.txtInfromation);
            this.Controls.Add(this.AddNewStaff);
            this.Name = "frmNewDealer";
            this.Text = "New Dealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewStaff;
        private System.Windows.Forms.TextBox txtInfromation;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnConfirm;
    }
}