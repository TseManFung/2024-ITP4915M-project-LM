using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmInvoice : Form
    {
        int warehouseID;
        String InvoiceID, OrderSerial;
        public frmInvoice(int respent_warehouse, String respent_InvoiceID)
        {
            this.warehouseID = respent_warehouse;
            this.InvoiceID = respent_InvoiceID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSignature frm = new frmSignature(InvoiceID, OrderSerial);
            (this.ParentForm as Main)?.Change_pContent(frm);
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT i.OrderSerial, StaffName, InvoiceDate,o.DealerID, OfficeAddress, DeliveryAddress, OrderNumberfromDealer  FROM Invoice i  inner join Staff s on DespatchForemanID = StaffID  inner join `Order` o on i.OrderSerial = o.OrderSerial  inner join Dealer d on d.DealerID = o.DealerID   where i.InvoiceID = {InvoiceID};";
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
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                strdata["InvAdd"] = reader["OfficeAddress"].ToString();
                strdata["DeliAdd"] = reader["DeliveryAddress"].ToString();
                strdata["OrderDate"] = reader["InvoiceDate"].ToString();
                strdata["DealerOrderNo"] = reader["OrderNumberfromDealer"].ToString();
                strdata["OurOrderNo"] = this.OrderSerial=reader["OrderSerial"].ToString();
                strdata["DealerCode"] = reader["DealerID"].ToString();
                strdata["DespatchForeman"] = reader["StaffName"].ToString();
            }
            txtINVOICEADDRESS.Text = strdata["InvAdd"];
            txtDELIVERYADDRESS.Text = strdata["DeliAdd"];
            txtDate.Text = strdata["OrderDate"];
            txtYOURORDERNO.Text = strdata["DealerOrderNo"];
            txtOURORDERNO.Text = strdata["OurOrderNo"];
            txtDEALERCODE.Text = strdata["DealerCode"];
            txtDespatchForeman.Text = strdata["DespatchForeman"];

            decimal totalWeight = 0;
            sql = $"SELECT a.ItemID,SpareName,Weight, a.Quantity as 'Qty delivered', BundlesNumber, ifnull(f.Quantity,0) as 'Qty to follow' FROM ActualQuantityDespatched a  inner join Spare s on a.itemID = SpareID  left join OrderItemToFollow f on f.ItemID = a.ItemID where InvoiceID = '{InvoiceID}';";
            using(var dt = Main.db.GetDataTable(sql))
            {
                dgvInvoice.DataSource = dt;
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    totalWeight += Convert.ToDecimal(row.Cells["Weight"].Value) * Convert.ToDecimal(row.Cells["Qty delivered"].Value);
                }
            }

            dgvInvoice.Columns["Weight"].Visible = false;
            txtTotalWeight.Text = totalWeight.ToString()+" g";


        }

        private void frmInvoice_Resize(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.ResizeControlsFont(this);
        }
    }
}
