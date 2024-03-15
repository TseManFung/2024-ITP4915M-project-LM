namespace WindowsFormsApp
{
    partial class frmPlacingOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlacingOrderForm));
            this.lblSeen = new System.Windows.Forms.TextBox();
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.txtSpareName = new System.Windows.Forms.TextBox();
            this.txtSpareID = new System.Windows.Forms.TextBox();
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.lblPlacingOrder = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogoViewCart = new System.Windows.Forms.PictureBox();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeen
            // 
            this.lblSeen.Location = new System.Drawing.Point(299, 555);
            this.lblSeen.Multiline = true;
            this.lblSeen.Name = "lblSeen";
            this.lblSeen.Size = new System.Drawing.Size(404, 59);
            this.lblSeen.TabIndex = 26;
            // 
            // comboBoxCategoryType
            // 
            this.comboBoxCategoryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCategoryType.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.Location = new System.Drawing.Point(521, 475);
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            this.comboBoxCategoryType.Size = new System.Drawing.Size(182, 34);
            this.comboBoxCategoryType.TabIndex = 25;
            // 
            // txtSpareName
            // 
            this.txtSpareName.Location = new System.Drawing.Point(521, 378);
            this.txtSpareName.Multiline = true;
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.Size = new System.Drawing.Size(182, 32);
            this.txtSpareName.TabIndex = 24;
            // 
            // txtSpareID
            // 
            this.txtSpareID.Location = new System.Drawing.Point(521, 267);
            this.txtSpareID.Multiline = true;
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.Size = new System.Drawing.Size(182, 32);
            this.txtSpareID.TabIndex = 23;
            // 
            // lblCategoryType
            // 
            this.lblCategoryType.AutoSize = true;
            this.lblCategoryType.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategoryType.CausesValidation = false;
            this.lblCategoryType.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold);
            this.lblCategoryType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoryType.Location = new System.Drawing.Point(293, 477);
            this.lblCategoryType.Name = "lblCategoryType";
            this.lblCategoryType.Size = new System.Drawing.Size(214, 32);
            this.lblCategoryType.TabIndex = 22;
            this.lblCategoryType.Text = "Category Type:";
            // 
            // lblSpareName
            // 
            this.lblSpareName.AutoSize = true;
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold);
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Location = new System.Drawing.Point(293, 378);
            this.lblSpareName.Name = "lblSpareName";
            this.lblSpareName.Size = new System.Drawing.Size(171, 32);
            this.lblSpareName.TabIndex = 21;
            this.lblSpareName.Text = "SpareName:";
            // 
            // lblSpareID
            // 
            this.lblSpareID.AutoSize = true;
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Location = new System.Drawing.Point(293, 267);
            this.lblSpareID.Name = "lblSpareID";
            this.lblSpareID.Size = new System.Drawing.Size(130, 32);
            this.lblSpareID.TabIndex = 20;
            this.lblSpareID.Text = "SpareID:";
            // 
            // lblPlacingOrder
            // 
            this.lblPlacingOrder.AutoSize = true;
            this.lblPlacingOrder.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPlacingOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlacingOrder.Location = new System.Drawing.Point(668, 18);
            this.lblPlacingOrder.Name = "lblPlacingOrder";
            this.lblPlacingOrder.Size = new System.Drawing.Size(545, 96);
            this.lblPlacingOrder.TabIndex = 19;
            this.lblPlacingOrder.Text = "Placing Order";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBoxLogo.Location = new System.Drawing.Point(499, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(163, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 18;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(138, 130);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 17;
            this.pictureBoxBack.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(1473, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 78);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.ItemHeight = 12;
            this.lstSearchResults.Location = new System.Drawing.Point(1095, 267);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(460, 244);
            this.lstSearchResults.TabIndex = 28;
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1763, 0);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(144, 130);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 27;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // pictureBoxLogoViewCart
            // 
            this.pictureBoxLogoViewCart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoViewCart.Image")));
            this.pictureBoxLogoViewCart.Location = new System.Drawing.Point(302, 663);
            this.pictureBoxLogoViewCart.Name = "pictureBoxLogoViewCart";
            this.pictureBoxLogoViewCart.Size = new System.Drawing.Size(142, 127);
            this.pictureBoxLogoViewCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoViewCart.TabIndex = 31;
            this.pictureBoxLogoViewCart.TabStop = false;
            // 
            // btnViewCart
            // 
            this.btnViewCart.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCart.Location = new System.Drawing.Point(521, 663);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(314, 127);
            this.btnViewCart.TabIndex = 32;
            this.btnViewCart.Text = "View cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnConfirm.Location = new System.Drawing.Point(1095, 663);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(460, 64);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnReduce
            // 
            this.btnReduce.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReduce.Location = new System.Drawing.Point(1095, 536);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(82, 78);
            this.btnReduce.TabIndex = 34;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = true;
            // 
            // frmPlacingOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.pictureBoxLogoViewCart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstSearchResults);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.lblSeen);
            this.Controls.Add(this.comboBoxCategoryType);
            this.Controls.Add(this.txtSpareName);
            this.Controls.Add(this.txtSpareID);
            this.Controls.Add(this.lblCategoryType);
            this.Controls.Add(this.lblSpareName);
            this.Controls.Add(this.lblSpareID);
            this.Controls.Add(this.lblPlacingOrder);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxBack);
            this.Name = "frmPlacingOrderForm";
            this.Text = "PlacingOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblSeen;
        public System.Windows.Forms.ComboBox comboBoxCategoryType;
        private System.Windows.Forms.TextBox txtSpareName;
        private System.Windows.Forms.TextBox txtSpareID;
        private System.Windows.Forms.Label lblCategoryType;
        private System.Windows.Forms.Label lblSpareName;
        private System.Windows.Forms.Label lblSpareID;
        private System.Windows.Forms.Label lblPlacingOrder;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.PictureBox pictureBoxLogoViewCart;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReduce;
    }
}