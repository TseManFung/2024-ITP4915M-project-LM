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
    public partial class OrderItemDetail : Form
    {
        string OrderSerial;
        DataTable OrderItem;
        public OrderItemDetail(string OrderSerial)
        {
            this.OrderSerial = OrderSerial;
            InitializeComponent();
        }

        private void getData()
        {
            string sql = "SELECT oi.ItemID,s.SpareName, oi.Quantity AS 'Order Qty', oi.PriceInOrder AS 'Price', IFNULL(sum(aqd.Quantity), 0) AS 'Processed Qty' FROM OrderItem oi LEFT JOIN Invoice i ON oi.OrderSerial = i.OrderSerial LEFT JOIN ActualQuantityDespatched aqd ON i.InvoiceID = aqd.InvoiceID AND oi.ItemID = aqd.ItemID inner join Spare s on oi.ItemID = s.SpareID WHERE oi.OrderSerial = '20240524-0900-000001' GROUP BY oi.ItemID;";
            OrderItem = Main.db.GetDataTable(sql);
        }

            private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
