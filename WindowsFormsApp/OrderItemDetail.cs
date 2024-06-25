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
        bool leave = false;
        public OrderItemDetail(string OrderSerial)
        {
            this.OrderSerial = OrderSerial;
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            string sql = $"SELECT oi.ItemID,s.SpareName, oi.Quantity AS 'Order Qty', oi.PriceInOrder AS 'Price', IFNULL(sum(aqd.Quantity), 0) AS 'Processed Qty' FROM OrderItem oi LEFT JOIN Invoice i ON oi.OrderSerial = i.OrderSerial LEFT JOIN ActualQuantityDespatched aqd ON i.InvoiceID = aqd.InvoiceID AND oi.ItemID = aqd.ItemID inner join Spare s on oi.ItemID = s.SpareID WHERE oi.OrderSerial = '{OrderSerial}' GROUP BY oi.ItemID;";
            OrderItem = Main.db.GetDataTable(sql);
            DataColumn dcRowString = OrderItem.Columns.Add("_RowString", typeof(string));
            foreach (DataRow dataRow in OrderItem.Rows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < OrderItem.Columns.Count - 1; i++)
                {
                    sb.Append(dataRow[i].ToString());
                    sb.Append("\t");
                }
                dataRow[dcRowString] = sb.ToString();
            }
            dataGridView1.DataSource = OrderItem;
            dataGridView1.Columns["_RowString"].Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderItem.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditOrder frm = new frmEditOrder(OrderSerial);
            (this.ParentForm as Main)?.Change_pContent(frm);
        }

        private void OrderItemDetail_Layout(object sender, LayoutEventArgs e)
        {
            if (leave)
            {
                getData();
                leave = false;
            }
        }

        private void OrderItemDetail_Leave(object sender, EventArgs e)
        {
            if (!leave)
            {
                leave = true;
            }
        }

    }
}
