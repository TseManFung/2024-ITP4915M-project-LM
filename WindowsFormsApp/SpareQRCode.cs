using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace WindowsFormsApp
{
    public partial class frmSpareQRCode : Form
    {
        DataTable Spare;
        QRCodeGenerator qrGenerator = new QRCodeGenerator();

        public frmSpareQRCode()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            string sql = "SELECT SpareID, SpareName FROM Spare";
            Spare = Main.db.GetDataTable(sql);


            comboBoxSpareID.DataSource = Spare;
            comboBoxSpareID.DisplayMember = "SpareID";
            comboBoxSpareID.ValueMember = "SpareID";
            comboBoxSpareName.DataSource = Spare;
            comboBoxSpareName.DisplayMember = "SpareName";
            comboBoxSpareName.ValueMember = "SpareName";
        }

        private void cboSpareID_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBoxSpareID.SelectedItem;
            string spareID = drv["SpareID"].ToString();


            genQR(spareID);
        }

        private void genQR(string qrData)
        {
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pictureBoxQRCode.Image = qrCodeImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // print the QR code
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBoxQRCode.Image, 0, 0);
        }
    }
}
