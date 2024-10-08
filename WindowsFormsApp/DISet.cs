﻿using WindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace WindowsFormsApp
{
    public partial class frmDISet : Form
    {
        int? warehouseID;
        String InvoiceID, OrderSerial;
        List<Form> forms = new List<Form>();
        public frmDISet(int? respent_warehouse, String respent_InvoiceID)
        {
            this.warehouseID = respent_warehouse;
            this.InvoiceID = respent_InvoiceID;
            InitializeComponent();
        }

        private void frmDISet_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT i.OrderSerial, StaffName, OrderDate,o.DealerID,d.DealerName, OfficeAddress, DeliveryAddress, OrderNumberfromDealer  FROM Invoice i  inner join Staff s on DespatchForemanID = StaffID  inner join `Order` o on i.OrderSerial = o.OrderSerial  inner join Dealer d on d.DealerID = o.DealerID   where i.InvoiceID = {InvoiceID};";
            Dictionary<string, string> strdata = new Dictionary<string, string>
    {
    { "InvAdd", "INVOICE ADDRESS" },
    { "DeliAdd", "DELIVERY ADDRESS (IF DIFFERENT)" },
    { "OrderDate", "Date" },
    { "DealerOrderNo", "YOUR ORDER NO." },
    { "OurOrderNo", "OUR ORDER NO." },
    { "DealerCode", "DEALER CODE" },
    { "DespatchForeman", "Despatch Foreman" },
    { "DealerName", "D" }

    };
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                strdata["InvAdd"] = reader["OfficeAddress"].ToString();
                strdata["DeliAdd"] = reader["DeliveryAddress"].ToString();
                strdata["OrderDate"] = reader["OrderDate"].ToString();
                strdata["DealerOrderNo"] = reader["OrderNumberfromDealer"].ToString();
                strdata["OurOrderNo"] = this.OrderSerial = reader["OrderSerial"].ToString();
                strdata["DealerCode"] = reader["DealerID"].ToString();
                strdata["DespatchForeman"] = reader["StaffName"].ToString();
                strdata["DealerName"] = reader["DealerName"].ToString();
            }
            txtDate.Text = strdata["OrderDate"];
            txtDealerOrderNo.Text = strdata["DealerOrderNo"];
            txtDeliveryAddress.Text = strdata["DeliAdd"];
            txtInvoiceAddress.Text = strdata["InvAdd"];
            txtOrderSerial.Text = strdata["OurOrderNo"];
            txtInvoiceName.Text = strdata["DealerName"];



            sql = $"SELECT a.ItemID,  s.SpareName,  s.Weight,oi.Quantity,  oi.Quantity - IFNULL(f.Quantity, 0) - CASE WHEN i.CompleteState = 'C' THEN (SELECT SUM(quantity) FROM ActualQuantityDespatched WHERE InvoiceID = '{InvoiceID}' and ItemID = a.ItemID) ELSE 0 END AS 'Prev Qty',  a.Quantity AS 'Qty delivered',  IFNULL(f.Quantity, 0) AS 'Qty to follow',  a.BundlesNumber FROM  ActualQuantityDespatched a  INNER JOIN Invoice i ON a.InvoiceID = i.InvoiceID  INNER JOIN Spare s ON a.ItemID = s.SpareID  LEFT JOIN OrderItemToFollow f ON f.ItemID = a.ItemID and f.OrderSerial =  i.OrderSerial INNER JOIN OrderItem oi ON a.ItemID = oi.ItemID AND oi.OrderSerial = '{OrderSerial}' WHERE  a.InvoiceID = '{InvoiceID}' GROUP BY  a.ItemID,  s.SpareName,  s.Weight,  'Prev Qty',  a.Quantity,  'Qty delivered',f.Quantity,  a.BundlesNumber;";
            forms.Add(this);
            using (var dt = Main.db.GetDataTable(sql))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    createDID(strdata["OrderDate"], strdata["OurOrderNo"], Convert.ToInt32(strdata["DealerCode"]), strdata["DespatchForeman"], dr);
                }
            }
        }
        int currentPageIndex = 0;
        private void btnExportasPDF_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = new PrintDocument();



            try
            {


                // download invoice as pdf

                //PrintDocument printDocument1 = new PrintDocument();
                //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                //printPreviewDialog1.ShowDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the selected printer
                    PrintDocument printDocument = printDialog.Document;

                    printDocument.DefaultPageSettings.Landscape = true;

                    // Attach the event handler for printing
                    printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

                    // Print to the selected printer
                    printDocument.Print();
                    currentPageIndex = 0;
                }


                //printDocument1.Print();
            }
            catch (Exception ex)
            {
                Main.ShowMessage(Resources.Can_not_print_now);
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }



            flowLayoutPanel1.Visible = true;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            if (currentPageIndex == 0)
            {
                pdfCover(e);
            }
            else
            {
                pdfContent(e);
            }

            currentPageIndex++;
            if (forms.Count - 1 <= currentPageIndex)
            {
                e.HasMorePages = false;
            }
            else
            {
                e.HasMorePages = true;
            }
        }
        Font font = new Font("Arial", 48, System.Drawing.FontStyle.Regular);
        Brush brush = Brushes.Black;
        private void pdfCover(System.Drawing.Printing.PrintPageEventArgs e)
        {
            int centerX = e.PageBounds.Width / 2;
            int centerY = e.PageBounds.Height / 2;
            int mt = e.MarginBounds.Top, ml = e.MarginBounds.Left, mr = e.MarginBounds.Right, mb = e.MarginBounds.Bottom;
            e.Graphics.DrawString(Resources.Despatch_Instruction_Set, font, brush, centerX, mt - 100, new StringFormat() { Alignment = StringAlignment.Center });

            //e.Graphics.DrawImage(Form2Bitmap(forms[0], mb-mt,mr-ml), 0,0 );
            e.Graphics.DrawImage(Form2Bitmap(forms[0], mb - mt, mr - ml), ml, mt);


        }

        private Bitmap Form2Bitmap(Form frm, int maxHeight, int maxWidth)
        {
            int height = maxHeight;
            int width = maxWidth;

            if (frm.Width > frm.Height)
            {
                height = (int)(((double)frm.Height / frm.Width) * maxWidth);
            }
            else
            {
                width = (int)(((double)frm.Width / frm.Height) * maxHeight);
            }
            Bitmap original = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(original, new System.Drawing.Rectangle(0, 0, frm.Width, frm.Height));

            Bitmap resized = new Bitmap(original, new Size(width, height));

            return resized;
        }

        private void pdfContent(System.Drawing.Printing.PrintPageEventArgs e)
        {
            int mt = e.MarginBounds.Top, ml = e.MarginBounds.Left, mr = e.MarginBounds.Right, mb = e.MarginBounds.Bottom;
            e.Graphics.DrawImage(Form2Bitmap(forms[currentPageIndex], mb - mt, mr - ml), ml, mt);
        }

        private void createDID(string date, string OrderSerial, int DealerID, string Carrier, DataRow dr)
        {
            frmDID frm2 = new frmDID(date, OrderSerial, DealerID, Carrier, dr);
            forms.Add(frm2);
            frm2.TopLevel = false;
            frm2.TopMost = true;
            frm2.Anchor = AnchorStyles.None;
            frm2.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel1.Controls.Add(frm2);
            forms.Add(frm2);
            frm2.Show();
        }
    }
}
