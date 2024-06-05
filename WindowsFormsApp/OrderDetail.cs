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
        string OrderSerial, dateTime, State;

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


        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            frmDeliveryStatusandProductDetails frm = new frmDeliveryStatusandProductDetails();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            flowDeliveryStatusandProductDetails.Controls.Add(frm);
            frm.Show();
            frmDeliveryStatusandProductDetails frm2 = new frmDeliveryStatusandProductDetails();
            frm2.TopLevel = false;
            frm2.TopMost = true;
            frm2.Anchor = AnchorStyles.None;
            frm2.FormBorderStyle = FormBorderStyle.None;
            flowDeliveryStatusandProductDetails.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmInvoice));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmDISet));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
