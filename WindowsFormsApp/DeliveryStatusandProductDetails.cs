using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmDeliveryStatusandProductDetails : Form
    {
        String InvoiceID, orderState, invoiceState,orderSerial;
        DataTable dt;

        Dictionary<String, String> dictInvoiceStates = new Dictionary<string, string> {
            {"C","Shipping" },{"S","Received" }
        };
        public frmDeliveryStatusandProductDetails()
        {
            InitializeComponent();
        }
        public frmDeliveryStatusandProductDetails(String InvoiceID, String orderState)
        {
            this.InvoiceID = InvoiceID;
            InitializeComponent();

        }
        private void showData()
        {
            string sql = $"SELECT InvoiceID,InvoiceDate,CompleteState FROM Invoice where InvoiceID = '{InvoiceID}';";
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                lblDate.Text = Convert.ToDateTime(reader["InvoiceDate"]).ToString("dd/MM/yyyy");
                try
                {
                    invoiceState = reader["CompleteState"].ToString();
                    lblState.Text = dictInvoiceStates[invoiceState];
                }
                catch (Exception e) { lblState.Text = "Unknown State"; }
                //reader.Close();
            }
            sql = $"SELECT a.ItemID,s.SpareName,sum(a.Quantity) as 'Qty',sum(a.BundlesNumber) as 'Bundles Number' FROM  ActualQuantityDespatched a inner join Spare s on a.ItemID =s.SpareID  where a.InvoiceID = '{InvoiceID}' group by itemID;";
            DataTable dt = Main.db.GetDataTable(sql);
            dgvRelatedSpareItem.DataSource = dt;
            int totalItem = 0, totalBundle = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalItem += Convert.ToInt32(row["Qty"]);
                totalBundle += Convert.ToInt32(row["Bundles Number"]);
            }

            lblItems.Text = $"{totalItem} item(s) in {totalBundle} package(s)";
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            string sql;
            sql = $"SELECT i.OrderSerial, StaffName, InvoiceDate,o.DealerID, OfficeAddress, DeliveryAddress, OrderNumberfromDealer  FROM Invoice i  inner join Staff s on DespatchForemanID = StaffID  inner join `Order` o on i.OrderSerial = o.OrderSerial  inner join Dealer d on d.DealerID = o.DealerID   where i.InvoiceID = {InvoiceID};";
            // save to strdata
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                strdata["InvAdd"] = reader["OfficeAddress"].ToString();
                strdata["DeliAdd"] = reader["DeliveryAddress"].ToString();
                strdata["OrderDate"] = reader["InvoiceDate"].ToString();
                strdata["DealerOrderNo"] = reader["OrderNumberfromDealer"].ToString();
                strdata["OurOrderNo"] = this.orderSerial = reader["OrderSerial"].ToString();
                strdata["DealerCode"] = reader["DealerID"].ToString();
                strdata["DespatchForeman"] = reader["StaffName"].ToString();
            }


            sql = $"SELECT a.ItemID, s.SpareName, s.Weight, oi.Quantity - IFNULL(f.Quantity, 0) - CASE WHEN i.CompleteState = 'C' THEN (SELECT SUM(quantity) FROM ActualQuantityDespatched WHERE InvoiceID = '{InvoiceID}') ELSE 0 END AS 'Prev Qty', a.Quantity AS 'Qty delivered', IFNULL(f.Quantity, 0) AS 'Qty to follow', a.BundlesNumber FROM ActualQuantityDespatched a INNER JOIN Invoice i ON a.InvoiceID = i.InvoiceID INNER JOIN Spare s ON a.ItemID = s.SpareID LEFT JOIN OrderItemToFollow f ON f.ItemID = a.ItemID INNER JOIN OrderItem oi ON a.ItemID = oi.ItemID AND oi.OrderSerial = '{orderSerial}' WHERE a.InvoiceID = '{InvoiceID}' GROUP BY a.ItemID, s.SpareName, s.Weight, oi.Quantity - IFNULL(f.Quantity, 0) - CASE WHEN i.CompleteState = 'C' THEN (SELECT SUM(quantity) FROM ActualQuantityDespatched WHERE InvoiceID = '{InvoiceID}') ELSE 0 END, a.Quantity, IFNULL(f.Quantity, 0),f.Quantity, a.BundlesNumber;";
            using (dt = Main.db.GetDataTable(sql))
            {
                foreach (DataRow row in dt.Rows)
                {
                    totalWeight += Convert.ToDecimal(row["Weight"]) * Convert.ToDecimal(row["Qty delivered"]);
                }
            }
            this.i = dt.Rows.Count;


            try
            {
                // download invoice as pdf
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
            }
            catch(Exception ex)
            {
                Main.ShowMessage("Can not print now");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }
        }
        private int currentPageIndex = 0,i=0;

        Font font = new Font("Arial", 12, System.Drawing.FontStyle.Regular);
        Brush brush = Brushes.Black;
        Dictionary<string, string> str = new Dictionary<string, string>
            {
                { "Title", "Legend MOTOR Co. Ltd." },
                { "companyName", "SMLC District, Tienhou, Guangzhou." },
                { "tel", "Tel: 133 808 12345" },
                { "Grams", "Grams: LegendMC" },
                { "InvAdd", "INVOICE ADDRESS" },
                { "DeliAdd", "DELIVERY ADDRESS (IF DIFFERENT)" },
                { "Date", "Date" },
                { "DealerOrderNo", "YOUR ORDER NO." },
                { "OurOrderNo", "OUR ORDER NO." },
                { "DealerCode", "DEALER CODE" },
                { "bundle", "No. of bundles" },
                { "PartNo", "Part No." },
                { "prevQty", "Prev. Qty." },
                { "followQty", "Qty to follow" },
                { "Qtydelivered", "Quantity delivered" },
                { "weight", "Total weight" },
                { "DespatchForeman", "Despatch Foreman" },
                { "Receive", "Received in good order" },
                { "Sign", "Signature" }
            };

        Dictionary<string, string> strdata = new Dictionary<string, string>
                {
                { "InvAdd", "INVOICE ADDRESS" },
                { "DeliAdd", "DELIVERY ADDRESS (IF DIFFERENT)" },
                { "OrderDate", "Date" },
                { "DealerOrderNo", "YOUR ORDER NO." },
                { "OurOrderNo", "OUR ORDER NO." },
                { "DealerCode", "DEALER CODE" },
                { "DespatchForeman", "Despatch Foreman" }
                };
        decimal totalWeight = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            if (currentPageIndex == 0)
            {
                pdfCover(e);
            }
            else if (i>0)
            {
                // Page 2 content
                pdfContent(e);
            }else if (i==0)
            {
                // Page 3 content
                pdfEnd(e);
            }

            currentPageIndex++;
        }

        private void pdfCover(System.Drawing.Printing.PrintPageEventArgs e)
        {
            int centerX = e.PageBounds.Width / 2;
            int centerY = e.PageBounds.Height / 2;
            int mt = e.MarginBounds.Top, ml = e.MarginBounds.Left;
            e.Graphics.DrawString(this.str["Title"], font, brush, centerX, mt, new StringFormat() { Alignment = StringAlignment.Center });
            e.Graphics.DrawString(this.str["companyName"], font, brush, centerX, mt + 20, new StringFormat() { Alignment = StringAlignment.Center });
            int k = (int)(e.Graphics.MeasureString(this.str["companyName"], font).Width / 2);
            e.Graphics.DrawString(this.str["tel"], font, brush, centerX-k- (int)(e.Graphics.MeasureString(this.str["tel"], font).Width / 2), mt + 40, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["Grams"], font, brush, centerX +k-(int)(e.Graphics.MeasureString(this.str["Grams"], font).Width / 2), mt + 40, new StringFormat() { Alignment = StringAlignment.Near });

            e.Graphics.DrawString(this.str["InvAdd"], font, brush, ml, mt + 70, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.strdata["InvAdd"], font, brush, ml, mt + 90, new StringFormat() { Alignment = StringAlignment.Near });

            e.Graphics.DrawString(this.str["DeliAdd"], font, brush, ml, mt + 120, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.strdata["DeliAdd"], font, brush, ml, mt + 140, new StringFormat() { Alignment = StringAlignment.Near });

            e.Graphics.DrawString(this.str["Date"], font, brush, ml, mt + 170, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.strdata["OrderDate"], font, brush, ml, mt + 190, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["DealerCode"], font, brush, centerX, mt + 170, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.strdata["DealerCode"], font, brush, centerX , mt + 190, new StringFormat() { Alignment = StringAlignment.Near });

            e.Graphics.DrawString(this.str["DealerOrderNo"], font, brush, ml, mt + 220, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.strdata["DealerOrderNo"], font, brush, ml, mt + 240, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["OurOrderNo"], font, brush, centerX, mt + 220, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.strdata["OurOrderNo"], font, brush, centerX, mt + 240, new StringFormat() { Alignment = StringAlignment.Near });

            e.Graphics.DrawString(this.str["DespatchForeman"], font, brush, ml, mt + 270, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.strdata["DespatchForeman"], font, brush, ml, mt + 290, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["weight"], font, brush, centerX, mt + 270, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(totalWeight.ToString()+" g", font, brush, centerX, mt + 290, new StringFormat() { Alignment = StringAlignment.Near });

            e.HasMorePages = true;

        }


        private void pdfContent(System.Drawing.Printing.PrintPageEventArgs e)
        {
            int centerX = e.PageBounds.Width / 2;
            int centerY = e.PageBounds.Height / 2;
            int mt = e.MarginBounds.Top, ml = e.MarginBounds.Left,mr = e.MarginBounds.Right,mb= e.MarginBounds.Bottom;
            int col1x = (ml+mr)/5, col2x = (ml + mr)*2 /5 , col3x = (ml + mr) * 3 / 5,col4x = (ml + mr) * 4 / 5;
            int r = 30;

            e.Graphics.DrawString(this.str["PartNo"], font, brush, ml, mt , new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["prevQty"], font, brush, col1x, mt , new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["Qtydelivered"], font, brush, col2x, mt , new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["followQty"], font, brush, col3x, mt , new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString(this.str["bundle"], font, brush, col4x, mt , new StringFormat() { Alignment = StringAlignment.Near });

            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                if(count < (currentPageIndex-1)*18)
                {
                    count++;
                    continue;
                }
                e.Graphics.DrawString(row["ItemID"].ToString(), font, brush, ml, mt + r, new StringFormat() { Alignment = StringAlignment.Near });
                e.Graphics.DrawString(row["SpareName"].ToString(), font, brush, ml, mt + r+20, new StringFormat() { Alignment = StringAlignment.Near });
                e.Graphics.DrawString(row["Prev Qty"].ToString(), font, brush, col1x, mt + r, new StringFormat() { Alignment = StringAlignment.Near });
                e.Graphics.DrawString(row["Qty delivered"].ToString(), font, brush, col2x, mt + r, new StringFormat() { Alignment = StringAlignment.Near });
                e.Graphics.DrawString(row["Qty to follow"].ToString(), font, brush, col3x, mt + r, new StringFormat() { Alignment = StringAlignment.Near });
                e.Graphics.DrawString(row["BundlesNumber"].ToString(), font, brush, col4x, mt + r, new StringFormat() { Alignment = StringAlignment.Near });
                r += 50;
                i--;
                if (r+ml > mb)
                {
                    break;
                }
            }
            e.HasMorePages = true;

            Console.WriteLine(mb - mt);

        }
        private void pdfEnd(System.Drawing.Printing.PrintPageEventArgs e)
        {
            int centerX = e.PageBounds.Width / 2;
            int centerY = e.PageBounds.Height / 2;
            int mt = e.MarginBounds.Top, ml = e.MarginBounds.Left;

            string sql = $"SELECT * FROM Signature where InvoiceID = {InvoiceID};";
            Image sign;

            e.Graphics.DrawString(this.str["Date"], font, brush, ml, mt, new StringFormat() { Alignment = StringAlignment.Near });
            e.Graphics.DrawString("Signatory", font, brush, centerX, mt, new StringFormat() { Alignment = StringAlignment.Near });

            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                string name = reader["Name"].ToString();
                string signatureDate = reader["SignatureDate"].ToString();

                // Draw Name
                e.Graphics.DrawString(name, font, brush, centerX, mt + 20, new StringFormat() { Alignment = StringAlignment.Near });

                // Draw SignatureDate
                e.Graphics.DrawString(signatureDate, font, brush, ml, mt + 20, new StringFormat() { Alignment = StringAlignment.Near });

                e.Graphics.DrawString(this.str["Sign"], font, brush, centerX, mt + 50, new StringFormat() { Alignment = StringAlignment.Near });
                // Draw "Sign" to image sign
                using (var ms = new MemoryStream((byte[]) reader["Sign"]))
                {
                   sign = Image.FromStream(ms);
                }
                int signWidth = centerX - ml;
                int signHeight = (int)(((double)signWidth / sign.Width) * sign.Height);
                Image s_image = (Image) ResizeImage(sign,signWidth,signHeight);
                e.Graphics.DrawImage(s_image, centerX, mt + 70);
                currentPageIndex = 0;
                s_image.Dispose();
            }
            sign.Dispose();
            
        }
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void frmDeliveryStatusandProductDetails_Load(object sender, EventArgs e)
        {
            showData();
            if (invoiceState == "S" && Main.dealerID != null)
            {
                btnInvoice.Visible = true;
            }
            if (Main.AssessLevel <= 300 || Main.AssessLevel == 600)
            {
                btnInvoice.Visible = true;
            }

        }
    }
}
