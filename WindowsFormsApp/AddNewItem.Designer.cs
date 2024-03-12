namespace WindowsFormsApp
{
    partial class frmAddNewItem
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
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblSpareWeight = new System.Windows.Forms.Label();
            this.txtSpareWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.comboBoxSpareList = new System.Windows.Forms.ComboBox();
            this.lblSpareList = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSpareName = new System.Windows.Forms.Label();
            this.lblSpareID = new System.Windows.Forms.Label();
            this.lblSpareType = new System.Windows.Forms.Label();
            this.txtSpareName = new System.Windows.Forms.TextBox();
            this.txtSpareID = new System.Windows.Forms.TextBox();
            this.comboBoxSpareType = new System.Windows.Forms.ComboBox();
            this.lblAddNewItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblReOrderLevel = new System.Windows.Forms.Label();
            this.txtReOrderLevel = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSupplierID.CausesValidation = false;
            this.lblSupplierID.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSupplierID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierID.Location = new System.Drawing.Point(832, 297);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(166, 32);
            this.lblSupplierID.TabIndex = 60;
            this.lblSupplierID.Text = "SupplierID:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(834, 332);
            this.txtSupplierID.Multiline = true;
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(260, 59);
            this.txtSupplierID.TabIndex = 59;
            // 
            // lblSpareWeight
            // 
            this.lblSpareWeight.AutoSize = true;
            this.lblSpareWeight.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareWeight.CausesValidation = false;
            this.lblSpareWeight.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareWeight.Location = new System.Drawing.Point(439, 297);
            this.lblSpareWeight.Name = "lblSpareWeight";
            this.lblSpareWeight.Size = new System.Drawing.Size(116, 32);
            this.lblSpareWeight.TabIndex = 58;
            this.lblSpareWeight.Text = "Weight:";
            // 
            // txtSpareWeight
            // 
            this.txtSpareWeight.Location = new System.Drawing.Point(442, 332);
            this.txtSpareWeight.Multiline = true;
            this.txtSpareWeight.Name = "txtSpareWeight";
            this.txtSpareWeight.Size = new System.Drawing.Size(289, 59);
            this.txtSpareWeight.TabIndex = 57;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.SystemColors.Control;
            this.lblWeight.CausesValidation = false;
            this.lblWeight.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWeight.Location = new System.Drawing.Point(59, 297);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(116, 32);
            this.lblWeight.TabIndex = 56;
            this.lblWeight.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(65, 332);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(289, 59);
            this.txtWeight.TabIndex = 55;
            // 
            // comboBoxSpareList
            // 
            this.comboBoxSpareList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxSpareList.Font = new System.Drawing.Font("新細明體", 32F);
            this.comboBoxSpareList.FormattingEnabled = true;
            this.comboBoxSpareList.Location = new System.Drawing.Point(442, 574);
            this.comboBoxSpareList.Name = "comboBoxSpareList";
            this.comboBoxSpareList.Size = new System.Drawing.Size(316, 60);
            this.comboBoxSpareList.TabIndex = 54;
            // 
            // lblSpareList
            // 
            this.lblSpareList.AutoSize = true;
            this.lblSpareList.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareList.CausesValidation = false;
            this.lblSpareList.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareList.Location = new System.Drawing.Point(461, 526);
            this.lblSpareList.Name = "lblSpareList";
            this.lblSpareList.Size = new System.Drawing.Size(146, 32);
            this.lblSpareList.TabIndex = 53;
            this.lblSpareList.Text = "SpareList:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("新細明體", 32F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(653, 442);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 54);
            this.btnEdit.TabIndex = 52;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 32F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(225, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 54);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblSpareName
            // 
            this.lblSpareName.AutoSize = true;
            this.lblSpareName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareName.CausesValidation = false;
            this.lblSpareName.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareName.Location = new System.Drawing.Point(59, 168);
            this.lblSpareName.Name = "lblSpareName";
            this.lblSpareName.Size = new System.Drawing.Size(171, 32);
            this.lblSpareName.TabIndex = 50;
            this.lblSpareName.Text = "SpareName:";
            // 
            // lblSpareID
            // 
            this.lblSpareID.AutoSize = true;
            this.lblSpareID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareID.CausesValidation = false;
            this.lblSpareID.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareID.Location = new System.Drawing.Point(468, 168);
            this.lblSpareID.Name = "lblSpareID";
            this.lblSpareID.Size = new System.Drawing.Size(130, 32);
            this.lblSpareID.TabIndex = 49;
            this.lblSpareID.Text = "SpareID:";
            // 
            // lblSpareType
            // 
            this.lblSpareType.AutoSize = true;
            this.lblSpareType.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpareType.CausesValidation = false;
            this.lblSpareType.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpareType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSpareType.Location = new System.Drawing.Point(828, 164);
            this.lblSpareType.Name = "lblSpareType";
            this.lblSpareType.Size = new System.Drawing.Size(161, 32);
            this.lblSpareType.TabIndex = 48;
            this.lblSpareType.Text = "SpareType:";
            // 
            // txtSpareName
            // 
            this.txtSpareName.Location = new System.Drawing.Point(65, 203);
            this.txtSpareName.Multiline = true;
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.Size = new System.Drawing.Size(289, 59);
            this.txtSpareName.TabIndex = 47;
            // 
            // txtSpareID
            // 
            this.txtSpareID.Location = new System.Drawing.Point(445, 203);
            this.txtSpareID.Multiline = true;
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.Size = new System.Drawing.Size(286, 59);
            this.txtSpareID.TabIndex = 46;
            // 
            // comboBoxSpareType
            // 
            this.comboBoxSpareType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxSpareType.Font = new System.Drawing.Font("新細明體", 32F);
            this.comboBoxSpareType.FormattingEnabled = true;
            this.comboBoxSpareType.Location = new System.Drawing.Point(834, 202);
            this.comboBoxSpareType.Name = "comboBoxSpareType";
            this.comboBoxSpareType.Size = new System.Drawing.Size(182, 60);
            this.comboBoxSpareType.TabIndex = 45;
            // 
            // lblAddNewItem
            // 
            this.lblAddNewItem.AutoSize = true;
            this.lblAddNewItem.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddNewItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddNewItem.Location = new System.Drawing.Point(664, 19);
            this.lblAddNewItem.Name = "lblAddNewItem";
            this.lblAddNewItem.Size = new System.Drawing.Size(580, 96);
            this.lblAddNewItem.TabIndex = 44;
            this.lblAddNewItem.Text = "Add New Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "Spare ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBox3.Location = new System.Drawing.Point(495, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(-3, 1);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(138, 130);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 41;
            this.pictureBoxBack.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(936, 556);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(280, 78);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblReOrderLevel
            // 
            this.lblReOrderLevel.AutoSize = true;
            this.lblReOrderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblReOrderLevel.CausesValidation = false;
            this.lblReOrderLevel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReOrderLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReOrderLevel.Location = new System.Drawing.Point(1208, 297);
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            this.lblReOrderLevel.Size = new System.Drawing.Size(223, 32);
            this.lblReOrderLevel.TabIndex = 69;
            this.lblReOrderLevel.Text = "Re Order Level:";
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.Location = new System.Drawing.Point(1255, 349);
            this.txtReOrderLevel.Multiline = true;
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Size = new System.Drawing.Size(99, 59);
            this.txtReOrderLevel.TabIndex = 68;
            this.txtReOrderLevel.TextChanged += new System.EventHandler(this.txtReOrderLevel_TextChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocation.CausesValidation = false;
            this.lblLocation.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLocation.Location = new System.Drawing.Point(1218, 168);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(136, 32);
            this.lblLocation.TabIndex = 67;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(1202, 203);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(289, 59);
            this.txtLocation.TabIndex = 66;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.CausesValidation = false;
            this.lblDescription.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Location = new System.Drawing.Point(1471, 297);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(173, 32);
            this.lblDescription.TabIndex = 75;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(1477, 332);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(383, 59);
            this.txtDescription.TabIndex = 74;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.CausesValidation = false;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.Location = new System.Drawing.Point(1574, 167);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 32);
            this.lblPrice.TabIndex = 73;
            this.lblPrice.Text = "Price:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1568, 202);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 59);
            this.textBox4.TabIndex = 72;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 32F);
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(1406, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 54);
            this.button5.TabIndex = 71;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1759, 1);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(144, 130);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 70;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 32F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(1011, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(268, 54);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmAddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.lblReOrderLevel);
            this.Controls.Add(this.txtReOrderLevel);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.lblSpareWeight);
            this.Controls.Add(this.txtSpareWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.comboBoxSpareList);
            this.Controls.Add(this.lblSpareList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSpareName);
            this.Controls.Add(this.lblSpareID);
            this.Controls.Add(this.lblSpareType);
            this.Controls.Add(this.txtSpareName);
            this.Controls.Add(this.txtSpareID);
            this.Controls.Add(this.comboBoxSpareType);
            this.Controls.Add(this.lblAddNewItem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBack);
            this.Name = "frmAddNewItem";
            this.Text = "FormAddNewItem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblSpareWeight;
        private System.Windows.Forms.TextBox txtSpareWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        public System.Windows.Forms.ComboBox comboBoxSpareList;
        private System.Windows.Forms.Label lblSpareList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSpareName;
        private System.Windows.Forms.Label lblSpareID;
        private System.Windows.Forms.Label lblSpareType;
        private System.Windows.Forms.TextBox txtSpareName;
        private System.Windows.Forms.TextBox txtSpareID;
        public System.Windows.Forms.ComboBox comboBoxSpareType;
        private System.Windows.Forms.Label lblAddNewItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblReOrderLevel;
        private System.Windows.Forms.TextBox txtReOrderLevel;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.Button btnDelete;
    }
}