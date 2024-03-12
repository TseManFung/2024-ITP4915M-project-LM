namespace WindowsFormsApp
{
    partial class frmInvoice
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblLM = new System.Windows.Forms.Label();
            this.lblSMLC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblINVOICEADDRESS = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblDATE = new System.Windows.Forms.Label();
            this.lblOURORDERTO = new System.Windows.Forms.Label();
            this.lblYOUROrderNO = new System.Windows.Forms.Label();
            this.lBLDEALERCODE = new System.Windows.Forms.Label();
            this.lblNoOfBundles = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.lblQuantityToFollow = new System.Windows.Forms.Label();
            this.lblQtyUnderDelivered = new System.Windows.Forms.Label();
            this.lblQuantityDelivered = new System.Windows.Forms.Label();
            this.lblDespatchForeman = new System.Windows.Forms.Label();
            this.lblReceivedInGoodOrder = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblSignDate = new System.Windows.Forms.Label();
            this.txtINVOICEADDRESS = new System.Windows.Forms.TextBox();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.txtDATE = new System.Windows.Forms.TextBox();
            this.txtYOUROrderNO = new System.Windows.Forms.TextBox();
            this.txtOURORDERTO = new System.Windows.Forms.TextBox();
            this.txtDealerCode = new System.Windows.Forms.TextBox();
            this.txtQtyUnderDelivered = new System.Windows.Forms.TextBox();
            this.txtQuantityToFollow = new System.Windows.Forms.TextBox();
            this.txtQuantityDelivered = new System.Windows.Forms.TextBox();
            this.txtDespatchForeman = new System.Windows.Forms.TextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.txtNoOfBundles = new System.Windows.Forms.TextBox();
            this.txtSignDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp.Properties.Resources.LoGoLeGend;
            this.pictureBoxLogo.Location = new System.Drawing.Point(722, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(163, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 75;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::WindowsFormsApp.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(2, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(138, 130);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 77;
            this.pictureBoxBack.TabStop = false;
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLanguage.Image = global::WindowsFormsApp.Properties.Resources.languageimage1;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(1759, 0);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(144, 130);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 78;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("新細明體", 72F);
            this.lblInvoice.Location = new System.Drawing.Point(936, 19);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(310, 96);
            this.lblInvoice.TabIndex = 79;
            this.lblInvoice.Text = "Invoice";
            // 
            // lblLM
            // 
            this.lblLM.AutoSize = true;
            this.lblLM.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLM.Location = new System.Drawing.Point(156, 147);
            this.lblLM.Name = "lblLM";
            this.lblLM.Size = new System.Drawing.Size(349, 32);
            this.lblLM.TabIndex = 80;
            this.lblLM.Text = "Legend MOTOR Co. Ltd.";
            // 
            // lblSMLC
            // 
            this.lblSMLC.AutoSize = true;
            this.lblSMLC.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblSMLC.Location = new System.Drawing.Point(248, 197);
            this.lblSMLC.Name = "lblSMLC";
            this.lblSMLC.Size = new System.Drawing.Size(470, 32);
            this.lblSMLC.TabIndex = 81;
            this.lblSMLC.Text = "SMLC District, Tienhou, Guangzhou.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F);
            this.label1.Location = new System.Drawing.Point(248, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 32);
            this.label1.TabIndex = 82;
            this.label1.Text = "Tel: 133 808 12345          Grams: LegendMC\r\n";
            // 
            // lblINVOICEADDRESS
            // 
            this.lblINVOICEADDRESS.AutoSize = true;
            this.lblINVOICEADDRESS.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblINVOICEADDRESS.Location = new System.Drawing.Point(156, 298);
            this.lblINVOICEADDRESS.Name = "lblINVOICEADDRESS";
            this.lblINVOICEADDRESS.Size = new System.Drawing.Size(292, 32);
            this.lblINVOICEADDRESS.TabIndex = 83;
            this.lblINVOICEADDRESS.Text = "INVOICE ADDRESS:";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblDeliveryAddress.Location = new System.Drawing.Point(1009, 298);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(626, 32);
            this.lblDeliveryAddress.TabIndex = 84;
            this.lblDeliveryAddress.Text = "DELIVERY ADDRESS (IF DIFFERENT) (PER):";
            // 
            // lblDATE
            // 
            this.lblDATE.AutoSize = true;
            this.lblDATE.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblDATE.Location = new System.Drawing.Point(156, 425);
            this.lblDATE.Name = "lblDATE";
            this.lblDATE.Size = new System.Drawing.Size(102, 32);
            this.lblDATE.TabIndex = 85;
            this.lblDATE.Text = "DATE:";
            // 
            // lblOURORDERTO
            // 
            this.lblOURORDERTO.AutoSize = true;
            this.lblOURORDERTO.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblOURORDERTO.Location = new System.Drawing.Point(703, 425);
            this.lblOURORDERTO.Name = "lblOURORDERTO";
            this.lblOURORDERTO.Size = new System.Drawing.Size(244, 32);
            this.lblOURORDERTO.TabIndex = 86;
            this.lblOURORDERTO.Text = "OUR ORDER TO:";
            // 
            // lblYOUROrderNO
            // 
            this.lblYOUROrderNO.AutoSize = true;
            this.lblYOUROrderNO.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblYOUROrderNO.Location = new System.Drawing.Point(363, 425);
            this.lblYOUROrderNO.Name = "lblYOUROrderNO";
            this.lblYOUROrderNO.Size = new System.Drawing.Size(270, 32);
            this.lblYOUROrderNO.TabIndex = 87;
            this.lblYOUROrderNO.Text = "YOUR ORDER NO:";
            // 
            // lBLDEALERCODE
            // 
            this.lBLDEALERCODE.AutoSize = true;
            this.lBLDEALERCODE.Font = new System.Drawing.Font("新細明體", 24F);
            this.lBLDEALERCODE.Location = new System.Drawing.Point(1025, 425);
            this.lBLDEALERCODE.Name = "lBLDEALERCODE";
            this.lBLDEALERCODE.Size = new System.Drawing.Size(230, 32);
            this.lBLDEALERCODE.TabIndex = 88;
            this.lBLDEALERCODE.Text = "DEALER CODE:";
            // 
            // lblNoOfBundles
            // 
            this.lblNoOfBundles.AutoSize = true;
            this.lblNoOfBundles.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblNoOfBundles.Location = new System.Drawing.Point(135, 584);
            this.lblNoOfBundles.Name = "lblNoOfBundles";
            this.lblNoOfBundles.Size = new System.Drawing.Size(201, 32);
            this.lblNoOfBundles.TabIndex = 89;
            this.lblNoOfBundles.Text = "No. of bundles:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 24F);
            this.label9.Location = new System.Drawing.Point(1025, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 90;
            // 
            // lblPartNo
            // 
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblPartNo.Location = new System.Drawing.Point(417, 584);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(115, 32);
            this.lblPartNo.TabIndex = 91;
            this.lblPartNo.Text = "Part No:";
            // 
            // lblQuantityToFollow
            // 
            this.lblQuantityToFollow.AutoSize = true;
            this.lblQuantityToFollow.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblQuantityToFollow.Location = new System.Drawing.Point(1025, 584);
            this.lblQuantityToFollow.Name = "lblQuantityToFollow";
            this.lblQuantityToFollow.Size = new System.Drawing.Size(243, 32);
            this.lblQuantityToFollow.TabIndex = 92;
            this.lblQuantityToFollow.Text = "Quantity to follow:";
            // 
            // lblQtyUnderDelivered
            // 
            this.lblQtyUnderDelivered.AutoSize = true;
            this.lblQtyUnderDelivered.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblQtyUnderDelivered.Location = new System.Drawing.Point(629, 584);
            this.lblQtyUnderDelivered.Name = "lblQtyUnderDelivered";
            this.lblQtyUnderDelivered.Size = new System.Drawing.Size(340, 32);
            this.lblQtyUnderDelivered.TabIndex = 93;
            this.lblQtyUnderDelivered.Text = "Prev. Qty. under delivered:";
            // 
            // lblQuantityDelivered
            // 
            this.lblQuantityDelivered.AutoSize = true;
            this.lblQuantityDelivered.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblQuantityDelivered.Location = new System.Drawing.Point(1320, 584);
            this.lblQuantityDelivered.Name = "lblQuantityDelivered";
            this.lblQuantityDelivered.Size = new System.Drawing.Size(244, 32);
            this.lblQuantityDelivered.TabIndex = 94;
            this.lblQuantityDelivered.Text = "Quantity delivered:";
            // 
            // lblDespatchForeman
            // 
            this.lblDespatchForeman.AutoSize = true;
            this.lblDespatchForeman.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblDespatchForeman.Location = new System.Drawing.Point(930, 750);
            this.lblDespatchForeman.Name = "lblDespatchForeman";
            this.lblDespatchForeman.Size = new System.Drawing.Size(247, 32);
            this.lblDespatchForeman.TabIndex = 95;
            this.lblDespatchForeman.Text = "Despatch Foreman:";
            this.lblDespatchForeman.Click += new System.EventHandler(this.lblDespatchForeman_Click);
            // 
            // lblReceivedInGoodOrder
            // 
            this.lblReceivedInGoodOrder.AutoSize = true;
            this.lblReceivedInGoodOrder.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblReceivedInGoodOrder.Location = new System.Drawing.Point(591, 881);
            this.lblReceivedInGoodOrder.Name = "lblReceivedInGoodOrder";
            this.lblReceivedInGoodOrder.Size = new System.Drawing.Size(294, 32);
            this.lblReceivedInGoodOrder.TabIndex = 96;
            this.lblReceivedInGoodOrder.Text = "Received in good order";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblSignature.Location = new System.Drawing.Point(674, 978);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(136, 32);
            this.lblSignature.TabIndex = 97;
            this.lblSignature.Text = "Signature:";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblTotalWeight.Location = new System.Drawing.Point(377, 750);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(173, 32);
            this.lblTotalWeight.TabIndex = 98;
            this.lblTotalWeight.Text = "Total weight:";
            // 
            // lblSignDate
            // 
            this.lblSignDate.AutoSize = true;
            this.lblSignDate.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblSignDate.Location = new System.Drawing.Point(318, 978);
            this.lblSignDate.Name = "lblSignDate";
            this.lblSignDate.Size = new System.Drawing.Size(102, 32);
            this.lblSignDate.TabIndex = 99;
            this.lblSignDate.Text = "DATE:";
            // 
            // txtINVOICEADDRESS
            // 
            this.txtINVOICEADDRESS.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtINVOICEADDRESS.Location = new System.Drawing.Point(195, 366);
            this.txtINVOICEADDRESS.Name = "txtINVOICEADDRESS";
            this.txtINVOICEADDRESS.Size = new System.Drawing.Size(207, 46);
            this.txtINVOICEADDRESS.TabIndex = 100;
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtDeliveryAddress.Location = new System.Drawing.Point(1128, 355);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(376, 46);
            this.txtDeliveryAddress.TabIndex = 101;
            // 
            // txtDATE
            // 
            this.txtDATE.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtDATE.Location = new System.Drawing.Point(128, 505);
            this.txtDATE.Name = "txtDATE";
            this.txtDATE.Size = new System.Drawing.Size(147, 46);
            this.txtDATE.TabIndex = 102;
            // 
            // txtYOUROrderNO
            // 
            this.txtYOUROrderNO.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtYOUROrderNO.Location = new System.Drawing.Point(383, 505);
            this.txtYOUROrderNO.Name = "txtYOUROrderNO";
            this.txtYOUROrderNO.Size = new System.Drawing.Size(207, 46);
            this.txtYOUROrderNO.TabIndex = 103;
            // 
            // txtOURORDERTO
            // 
            this.txtOURORDERTO.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtOURORDERTO.Location = new System.Drawing.Point(722, 505);
            this.txtOURORDERTO.Name = "txtOURORDERTO";
            this.txtOURORDERTO.Size = new System.Drawing.Size(207, 46);
            this.txtOURORDERTO.TabIndex = 104;
            // 
            // txtDealerCode
            // 
            this.txtDealerCode.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtDealerCode.Location = new System.Drawing.Point(1039, 505);
            this.txtDealerCode.Name = "txtDealerCode";
            this.txtDealerCode.Size = new System.Drawing.Size(207, 46);
            this.txtDealerCode.TabIndex = 105;
            // 
            // txtQtyUnderDelivered
            // 
            this.txtQtyUnderDelivered.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtQtyUnderDelivered.Location = new System.Drawing.Point(680, 658);
            this.txtQtyUnderDelivered.Name = "txtQtyUnderDelivered";
            this.txtQtyUnderDelivered.Size = new System.Drawing.Size(207, 46);
            this.txtQtyUnderDelivered.TabIndex = 106;
            // 
            // txtQuantityToFollow
            // 
            this.txtQuantityToFollow.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtQuantityToFollow.Location = new System.Drawing.Point(1015, 658);
            this.txtQuantityToFollow.Name = "txtQuantityToFollow";
            this.txtQuantityToFollow.Size = new System.Drawing.Size(207, 46);
            this.txtQuantityToFollow.TabIndex = 107;
            // 
            // txtQuantityDelivered
            // 
            this.txtQuantityDelivered.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtQuantityDelivered.Location = new System.Drawing.Point(1326, 658);
            this.txtQuantityDelivered.Name = "txtQuantityDelivered";
            this.txtQuantityDelivered.Size = new System.Drawing.Size(207, 46);
            this.txtQuantityDelivered.TabIndex = 108;
            // 
            // txtDespatchForeman
            // 
            this.txtDespatchForeman.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtDespatchForeman.Location = new System.Drawing.Point(952, 813);
            this.txtDespatchForeman.Name = "txtDespatchForeman";
            this.txtDespatchForeman.Size = new System.Drawing.Size(207, 46);
            this.txtDespatchForeman.TabIndex = 109;
            // 
            // txtSignature
            // 
            this.txtSignature.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtSignature.Location = new System.Drawing.Point(834, 972);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(207, 46);
            this.txtSignature.TabIndex = 110;
            // 
            // txtPartNo
            // 
            this.txtPartNo.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtPartNo.Location = new System.Drawing.Point(383, 658);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(207, 46);
            this.txtPartNo.TabIndex = 111;
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtTotalWeight.Location = new System.Drawing.Point(369, 813);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(207, 46);
            this.txtTotalWeight.TabIndex = 112;
            // 
            // txtNoOfBundles
            // 
            this.txtNoOfBundles.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtNoOfBundles.Location = new System.Drawing.Point(128, 658);
            this.txtNoOfBundles.Name = "txtNoOfBundles";
            this.txtNoOfBundles.Size = new System.Drawing.Size(207, 46);
            this.txtNoOfBundles.TabIndex = 113;
            // 
            // txtSignDate
            // 
            this.txtSignDate.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtSignDate.Location = new System.Drawing.Point(436, 964);
            this.txtSignDate.Name = "txtSignDate";
            this.txtSignDate.Size = new System.Drawing.Size(207, 46);
            this.txtSignDate.TabIndex = 114;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtSignDate);
            this.Controls.Add(this.txtNoOfBundles);
            this.Controls.Add(this.txtTotalWeight);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.txtSignature);
            this.Controls.Add(this.txtDespatchForeman);
            this.Controls.Add(this.txtQuantityDelivered);
            this.Controls.Add(this.txtQuantityToFollow);
            this.Controls.Add(this.txtQtyUnderDelivered);
            this.Controls.Add(this.txtDealerCode);
            this.Controls.Add(this.txtOURORDERTO);
            this.Controls.Add(this.txtYOUROrderNO);
            this.Controls.Add(this.txtDATE);
            this.Controls.Add(this.txtDeliveryAddress);
            this.Controls.Add(this.txtINVOICEADDRESS);
            this.Controls.Add(this.lblSignDate);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblReceivedInGoodOrder);
            this.Controls.Add(this.lblDespatchForeman);
            this.Controls.Add(this.lblQuantityDelivered);
            this.Controls.Add(this.lblQtyUnderDelivered);
            this.Controls.Add(this.lblQuantityToFollow);
            this.Controls.Add(this.lblPartNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNoOfBundles);
            this.Controls.Add(this.lBLDEALERCODE);
            this.Controls.Add(this.lblYOUROrderNO);
            this.Controls.Add(this.lblOURORDERTO);
            this.Controls.Add(this.lblDATE);
            this.Controls.Add(this.lblDeliveryAddress);
            this.Controls.Add(this.lblINVOICEADDRESS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSMLC);
            this.Controls.Add(this.lblLM);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "frmInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.lblQuantityDelivered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblLM;
        private System.Windows.Forms.Label lblSMLC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblINVOICEADDRESS;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Label lblDATE;
        private System.Windows.Forms.Label lblOURORDERTO;
        private System.Windows.Forms.Label lblYOUROrderNO;
        private System.Windows.Forms.Label lBLDEALERCODE;
        private System.Windows.Forms.Label lblNoOfBundles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.Label lblQuantityToFollow;
        private System.Windows.Forms.Label lblQtyUnderDelivered;
        private System.Windows.Forms.Label lblQuantityDelivered;
        private System.Windows.Forms.Label lblDespatchForeman;
        private System.Windows.Forms.Label lblReceivedInGoodOrder;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblSignDate;
        private System.Windows.Forms.TextBox txtINVOICEADDRESS;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.TextBox txtDATE;
        private System.Windows.Forms.TextBox txtYOUROrderNO;
        private System.Windows.Forms.TextBox txtOURORDERTO;
        private System.Windows.Forms.TextBox txtDealerCode;
        private System.Windows.Forms.TextBox txtQtyUnderDelivered;
        private System.Windows.Forms.TextBox txtQuantityToFollow;
        private System.Windows.Forms.TextBox txtQuantityDelivered;
        private System.Windows.Forms.TextBox txtDespatchForeman;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.TextBox txtNoOfBundles;
        private System.Windows.Forms.TextBox txtSignDate;
    }
}