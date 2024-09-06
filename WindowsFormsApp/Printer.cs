using NPOI.XWPF.UserModel;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Printer : Form
    {
        public Printer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Let the user select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Call print dialog to print the selected file
                PrintDialog printDialog = new PrintDialog();

                using (PrintDocument pd = new PrintDocument())
                {
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        pd.OriginAtMargins = true;
                        pd.PrintPage += pd_PrintPage;
                        pd.DocumentName = filePath;
                        pd.Print();
                        pd.PrintPage -= pd_PrintPage;
                    }
                }
            }
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            string labelPath = ((PrintDocument)sender).DocumentName;
            string extension = Path.GetExtension(labelPath).ToLower();

            if (extension == ".pdf")
            {
                // Handle PDF rendering here
                // Example: Use a PDF rendering library to convert PDF to image
                // Replace the following line with your PDF rendering code
                RenderPdfToImage(labelPath, e.Graphics);
            }
            else if (extension == ".doc" || extension == ".docx")
            {
                // Handle DOC/DOCX rendering here
                // Example: Use a Word processing library to convert DOC/DOCX to image
                // Replace the following line with your DOC/DOCX rendering code
                RenderDocToImage(labelPath, e.Graphics);
            }
            else
            {
                e.Graphics.DrawImage(new Bitmap(labelPath), 0, 0);
            }
        }

        private void RenderPdfToImage(string filePath, Graphics graphics)
        {
            // Use a PDF rendering library to convert PDF to image
            // Replace the following line with your PDF rendering code
            using (var document = PdfDocument.Load(filePath))
            {
                using (var image = document.Render(0, 300, 300, true))
                {
                    graphics.DrawImage(image, 0, 0);
                }
            }

        }

        private void RenderDocToImage(string filePath, Graphics graphics)
        {
            // Implement DOC/DOCX rendering logic here
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                XWPFDocument doc = new XWPFDocument(stream);

                // Convert the first page of the document to an image
                // Note: This is a simplified example. You may need a more complex solution for multi-page documents.

                // Export the document to a bitmap
                Bitmap bitmap = new Bitmap(850, 1100); // A4 size at 96 DPI
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White);
                    int y = 0;

                    foreach (var paragraph in doc.Paragraphs)
                    {
                        y += (int)g.MeasureString(paragraph.ParagraphText, new Font("Arial", 12)).Height;
                        g.DrawString(paragraph.ParagraphText, new Font("Arial", 12), Brushes.Black, new RectangleF(0, y, bitmap.Width, bitmap.Height));

                        // Break if the page is full
                        if (y >= bitmap.Height)
                            break;
                    }
                }

                // Draw the bitmap to the printer graphics
                graphics.DrawImage(bitmap, 0, 0);
            }
        }
    }
}
