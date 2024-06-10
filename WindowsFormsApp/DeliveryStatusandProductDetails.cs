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

namespace WindowsFormsApp
{
    public partial class frmDeliveryStatusandProductDetails : Form
    {
        String InvoiceID, orderState, invoiceState;

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
            // download invoice as pdf
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
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
                { "prevQty", "Prev. Qty. under delivered" },
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
                { "weight", "Total weight" },
                { "DespatchForeman", "Despatch Foreman" },
                { "SignDate", "Date" },
                { "Sign", "Signature" }
            };
            string sql;
            sql = $"SELECT i.OrderSerial, StaffName, InvoiceDate,o.DealerID, OfficeAddress, DeliveryAddress, OrderNumberfromDealer, SignatureDate, Sign  FROM Invoice i  inner join Staff s on DespatchForemanID = StaffID  inner join `Order` o on i.OrderSerial = o.OrderSerial  inner join Dealer d on d.DealerID = o.DealerID  inner join Signature t on t.InvoiceID = i.InvoiceID  ;";
            // save to strdata
            







            Font font = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;
            int centerX = e.PageBounds.Width / 2;
            int centerY = e.PageBounds.Height / 2;




            // Define table properties
            int tableWidth = 400;
            int tableHeight = 200;
            int cellPadding = 5;

            // Define column widths
            int column1Width = 150;
            //int column2Width = 250;

            // Define table position
            int tableX = e.MarginBounds.Left;
            int tableY = e.MarginBounds.Top;

            // Define cell position
            int cellX = tableX + cellPadding;
            int cellY = tableY + cellPadding;

            // Draw table outline
            e.Graphics.DrawRectangle(Pens.Black, tableX, tableY, tableWidth, tableHeight);

            // Draw column lines
            e.Graphics.DrawLine(Pens.Black, cellX + column1Width, tableY, cellX + column1Width, tableY + tableHeight);

            // Draw row lines
            e.Graphics.DrawLine(Pens.Black, tableX, cellY + font.Height, tableX + tableWidth, cellY + font.Height);
            e.Graphics.DrawLine(Pens.Black, tableX, cellY + 2 * font.Height, tableX + tableWidth, cellY + 2 * font.Height);

            // Draw column headers
            e.Graphics.DrawString("Column 1", font, brush, cellX, cellY);
            e.Graphics.DrawString("Column 2", font, brush, cellX + column1Width, cellY);

            // Draw table data
            cellY += font.Height;
            e.Graphics.DrawString("Data 1", font, brush, cellX, cellY);
            e.Graphics.DrawString("Data 2", font, brush, cellX + column1Width, cellY);

            cellY += font.Height;
            e.Graphics.DrawString("Data 3", font, brush, cellX, cellY);
            e.Graphics.DrawString("Data 4", font, brush, cellX + column1Width, cellY);
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
