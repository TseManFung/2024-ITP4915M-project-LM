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

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = new PrintDocument();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected printer
                PrintDocument printDocument = printDialog.Document;

                // Attach the event handler for printing
                printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

                // Print to the selected printer
                printDocument.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Get the dimensions of the QR code image
            int qrCodeWidth = pictureBoxQRCode.Image.Width;
            int qrCodeHeight = pictureBoxQRCode.Image.Height;

            // Calculate the center coordinates of the page
            int centerX = e.PageBounds.Width / 2;
            int centerY = e.PageBounds.Height / 2;

            // Calculate the top-left coordinates to draw the QR code image in the center
            int qrCodeX = centerX - (qrCodeWidth / 2);
            int qrCodeY = centerY - (qrCodeHeight / 2);

            // Draw the QR code image in the center of the page
            e.Graphics.DrawImage(pictureBoxQRCode.Image, qrCodeX, qrCodeY);

            // Print SpareName and SpareID
            DataRowView drv = (DataRowView)comboBoxSpareID.SelectedItem;
            string spareID = drv["SpareID"].ToString(),spareName = drv["SpareName"].ToString();

            // Set the font and brush for drawing text
            Font font = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;

            int spareIDX = centerX - (int)(e.Graphics.MeasureString(spareID, font).Width / 2);
            int spareIDY = qrCodeY; // Adjust the vertical position as needed

            // Calculate the coordinates to draw the SpareName and SpareID
            int spareNameX = centerX - (int)(e.Graphics.MeasureString(spareName, font).Width / 2);
            int spareNameY = qrCodeY + (int)e.Graphics.MeasureString(spareID, font).Height + 2 ; // Adjust the vertical position as needed



            // Draw SpareName and SpareID on the page
            e.Graphics.DrawString(spareName, font, brush, spareNameX, spareNameY);
            e.Graphics.DrawString(spareID, font, brush, spareIDX, spareIDY);
        }
    }
}
