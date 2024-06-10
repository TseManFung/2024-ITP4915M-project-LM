using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmDeliveryStatusandProductDetails : Form
    {
        String InvoiceID, orderState;

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
                    lblState.Text = dictInvoiceStates[reader["CompleteState"].ToString()];
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
        private void frmDeliveryStatusandProductDetails_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
