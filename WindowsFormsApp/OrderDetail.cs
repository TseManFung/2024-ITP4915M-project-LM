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

        private void CreateDelivaryDetail()
        {
            frmDeliveryStatusandProductDetails frm = new frmDeliveryStatusandProductDetails();
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
            if(Main.AssessLevel == 700 || Main.AssessLevel<=300)
            {
                BtnDIset.Visible = true;
            }
            if (State == "T" || State == "F")
            {
               btnInvoice.Visible = true;
            }

            CreateDelivaryDetail();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            // if staff click: show invoice
            (this.ParentForm as Main)?.Change_pContent(typeof(frmInvoice));
            // if dealer click: print invoice
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmDISet));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if text  = Item Detail: show item detail, change to text to Delivery Detail
            // if text = Delivery Detail: show delivery detail, change to text to Item Detail
        }
    }
}
