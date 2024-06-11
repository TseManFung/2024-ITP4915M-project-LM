using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmOrderDetail : Form
    {
        string OrderSerial, dateTime, State,respent_InvoiceID;
        int respent_warehouse;



        Dictionary<string, string> dictState = new Dictionary<string, string>() {
            { "C", "Order Create" } ,
            { "P", "Processing" } ,
            { "W", "Waiting" } ,
            { "U", "Unavailable" } ,
            { "T", "In transit" },
            { "F", "this order is finfshed" }
        };
        public frmOrderDetail(string OrderSerial)
        {
            InitializeComponent();
            this.OrderSerial = OrderSerial;
            txtOrderID.Text = OrderSerial;


            string sql = $"select * from `Order` where OrderSerial = '{OrderSerial}';";
            var reader = Main.db.readBySql(sql);
            reader.Read();

            State = Convert.ToString(reader["State"]);
            txtStatus.Text = dictState[State];

            txtDateTime.Text = reader["OrderDate"].ToString();

            reader.Close();
        }

        private void CreateDelivaryDetail(String InvoiceID)
        {
            frmDeliveryStatusandProductDetails frm = new frmDeliveryStatusandProductDetails(InvoiceID, State);
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            //frm.Dock = DockStyle.Top;
            frm.FormBorderStyle = FormBorderStyle.None;
            flowDeliveryStatusandProductDetails.Controls.Add(frm);
            frm.Show();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            string sql_getwarehouse = $"SELECT d.WarehouseID FROM User u inner join Staff s on u.StaffID = s.StaffID inner join Department d on s.DeptID = d.DeptID  where u.UserID={Main.userID};";
            using (var reader = Main.db.readBySql(sql_getwarehouse))
            {
                reader.Read();
                respent_warehouse = reader.GetInt32(0);
            }
            string sql_getInvoiceID = $"SELECT max(i.InvoiceID) as IID,WarehouseID FROM Invoice i inner join ActualQuantityDespatched a on i.InvoiceID = a.InvoiceID where WarehouseID = {respent_warehouse} and OrderSerial = '{OrderSerial}' group by WarehouseID;";
            using (var reader = Main.db.readBySql(sql_getInvoiceID))
            {
                reader.Read();
                respent_InvoiceID = reader["IID"].ToString();
            }
            if (Main.AssessLevel == 700 || Main.AssessLevel<=300)
            {
                BtnDIset.Visible = true;
            }
            if (State == "T" && Main.AssessLevel == 700)
            {
               btnInvoice.Visible = true;

            }

            string sql = $"SELECT InvoiceID FROM Invoice where OrderSerial = '{OrderSerial}';";
            List<string> ListInvoiceID = new List<string>();
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    ListInvoiceID.Add(reader["InvoiceID"].ToString());
                }
            }
            foreach (var InvoiceID in ListInvoiceID)
            {
                CreateDelivaryDetail(InvoiceID);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice frm = new frmInvoice(respent_warehouse, respent_InvoiceID);
            (this.ParentForm as Main)?.Change_pContent(frm);
        }

        private void btnDISet_Click(object sender, EventArgs e)
        {
            frmDISet frm = new frmDISet(respent_warehouse,respent_InvoiceID);
            (this.ParentForm as Main)?.Change_pContent(frm);
        }

        private void btnOrderItemDetail_Click(object sender, EventArgs e)
        {
            OrderItemDetail frm = new OrderItemDetail(OrderSerial);
            frm.Text += $"{OrderSerial}";
            (this.ParentForm as Main)?.Change_pContent(frm);
        }
    }
}
