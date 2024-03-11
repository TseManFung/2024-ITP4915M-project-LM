namespace WindowsFormsApp
{
    partial class FrmCheckOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckOrder));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.pictureBoxLaunuage = new System.Windows.Forms.PictureBox();
            this.lblSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaunuage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(179, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1524, 707);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 948);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(222, 58);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear All Item";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(816, 7);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.SystemColors.Control;
            this.lblCart.Font = new System.Drawing.Font("新細明體", 36F);
            this.lblCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCart.Location = new System.Drawing.Point(917, 9);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(98, 48);
            this.lblCart.TabIndex = 3;
            this.lblCart.Text = "Cart";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 4;
            this.pictureBoxBack.TabStop = false;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(1494, 900);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(222, 58);
            this.btnAddAll.TabIndex = 5;
            this.btnAddAll.Text = "Add All To Cert";
            this.btnAddAll.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLaunuage
            // 
            this.pictureBoxLaunuage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBoxLaunuage.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBoxLaunuage.Location = new System.Drawing.Point(1762, 12);
            this.pictureBoxLaunuage.Name = "pictureBoxLaunuage";
            this.pictureBoxLaunuage.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxLaunuage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLaunuage.TabIndex = 6;
            this.pictureBoxLaunuage.TabStop = false;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(1262, 923);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(179, 12);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "Items Selected with a total quantity of";
            // 
            // FrmCheckOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.pictureBoxLaunuage);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FrmCheckOrder";
            this.Text = "Check Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaunuage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.PictureBox pictureBoxLaunuage;
        private System.Windows.Forms.Label lblSelected;
    }
}