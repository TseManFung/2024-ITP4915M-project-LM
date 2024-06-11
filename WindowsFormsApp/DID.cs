using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmDID : Form
    {
        string date, OrderSerial, Carrier;
        int DealerID, orderQty;
        DataRow dr;
        //SELECT
        //a.ItemID,
        //s.SpareName,
        //s.Weight,
        //oi.Quantity - IFNULL(f.Quantity, 0) - CASE WHEN i.CompleteState = 'C' THEN(SELECT SUM(quantity) FROM ActualQuantityDespatched WHERE InvoiceID = '202405240000011') ELSE 0 END AS 'Prev Qty',
        //a.Quantity AS 'Qty delivered',
        //IFNULL(f.Quantity, 0) AS 'Qty to follow',
        //a.BundlesNumber
        public frmDID(string date, string OrderSerial, int DealerID, string Carrier, DataRow dr)
        {
            this.date = date;
            this.OrderSerial = OrderSerial;
            this.DealerID = DealerID;
            this.Carrier = Carrier;
            this.dr = dr;
            InitializeComponent();
        }

        private void frmDID_Load(object sender, EventArgs e)
        {
            txtDate.Text = date;
            txtOrderSerial.Text = OrderSerial;
            txtDealerCode.Text = DealerID.ToString();
            txtOrderQuantity.Text = dr["Quantity"].ToString();
            txtCarrier.Text = Carrier;
            txtPartNumber.Text = dr["ItemID"].ToString();
            txtPreviousOutstanding.Text = dr["Prev Qty"].ToString();
            txtActualQuantityDespatched.Text = dr["Qty delivered"].ToString();
            txtToFollow.Text = dr["Qty to follow"].ToString();
            txtNumberofBundles.Text = dr["BundlesNumber"].ToString();
            txtWeight.Text = dr["Weight"].ToString();
        }
    }
}
