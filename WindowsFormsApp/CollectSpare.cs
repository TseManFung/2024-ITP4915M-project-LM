using WindowsFormsApp.Properties;
using Mysqlx.Crud;
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
    public partial class frmCollectSpare : Form
    {
        int whID, dealerID;
        string OrderSerial;
        string invoiceID;

        public frmCollectSpare()
        {
            InitializeComponent();
        }

        private void btnscanner_Click(object sender, EventArgs e)
        {
            using (frmWebcam webcam = new frmWebcam())
            {
                webcam.ShowDialog();
                string code = webcam.scanCode;
                Console.WriteLine(code);
                //if can not find the code in the collect list
                if(code == null || code == string.Empty)
                {
                    return;
                }
                if (!comboBoxSpareID.Items.Contains(code))
                {
                    Main.ShowMessage(Resources.The_spare_is_not_in_the_collec);
                    return;
                }
                comboBoxSpareID.SelectedItem = code;
            }

        }

        private void frmCollectSpare_Load(object sender, EventArgs e)
        {
            string sql = $@"SELECT
  IF(d.WarehouseID IS NULL, -1, d.WarehouseID) AS WarehouseID
FROM Staff s
JOIN Department d ON s.DeptID = d.DeptID  
WHERE s.StaffID = {Main.staffID}";
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();

                whID = Convert.ToInt32(reader["WarehouseID"]);

            }
            getData();
        }

        private void deleteOITF()
        {
            string sql = $@" DELETE FROM OrderItemToFollow
WHERE OrderSerial = '{OrderSerial}' AND Quantity = 0";
            Main.db.updateBySql(sql);
}

        private void getData()
        {
            deleteOITF();


            invoiceID = null;
            string sql = $@"SELECT 
  OrderSerial
FROM OrderItemForCollect
WHERE Assgin = {whID} AND State = 'W'  
GROUP BY OrderSerial
ORDER BY OrderSerial ASC
limit 0,1";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    OrderSerial = reader["OrderSerial"].ToString();
                }
                else
                {
                    Main.ShowMessage(Resources.No_Order_to_Collect);
                    return;
                }
            }

            sql = $@"UPDATE OrderItemForCollect 
SET State = 'C'
WHERE OrderSerial = '{OrderSerial}' 
  AND Assgin = {whID}
  AND State = 'W'";
            Main.db.updateBySql(sql);
            sql = $@"SELECT 
  o.OrderSerial,
  o.ItemID,
  s.SpareName,
  o.Quantity
FROM OrderItemForCollect o
JOIN Spare s ON o.ItemID = s.SpareID
WHERE OrderSerial = '{OrderSerial}' 
  AND Assgin = {whID}
  AND o.State = 'C'";
            var dt = Main.db.GetDataTable(sql);
            sql = $@"SELECT DealerID 
FROM `Order`
WHERE OrderSerial = '{OrderSerial}';";
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                dealerID = Convert.ToInt32(reader["DealerID"]);
            }


            dgvCollect.DataSource = dt;
            dgvCollect.Columns["OrderSerial"].Visible = false;
            comboBoxSpareID.Items.AddRange(dt.AsEnumerable().Select(x => x["ItemID"].ToString()).ToArray());
            Main.ShowMessage(Resources.The_current_order_number_is + OrderSerial);
        }

        private void frmCollectSpare_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql = $@"UPDATE OrderItemForCollect 
SET State = 'W'
WHERE OrderSerial = '{OrderSerial}' 
  AND Assgin = {whID}
  AND State = 'C'";
            Main.db.updateBySql(sql);
        }

        private void dgvCollect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // selete this row's ItemID in the comboBoxSpareID
            comboBoxSpareID.SelectedItem = dgvCollect.Rows[e.RowIndex].Cells["ItemID"].Value;
        }

        private void comboBoxSpareID_SelectedValueChanged(object sender, EventArgs e)
        {
            // find the quantity of the selected ItemID
            var row = dgvCollect.Rows
                .OfType<DataGridViewRow>()
                .FirstOrDefault(x => x.Cells["ItemID"].Value.ToString() == comboBoxSpareID.SelectedItem.ToString());

            if (row != null)
            {
                var quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                numActualQuantity.Value = numActualQuantity.Maximum = quantity;
                numSpareNumberofBundles.Value = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxSpareID.SelectedItem == null)
            {
                Main.ShowMessage(Resources.Please_select_a_spare);
                return;
            }
            else if (numSpareNumberofBundles.Value == 0)
            {
                Main.ShowMessage(Resources.Please_input_the_Number_of_Bun);
                return;
            }
            if (invoiceID == null)
            {
                createInvoice();
            }
            string sql;

            sql = $@"UPDATE `Order`
SET State = 'T' 
WHERE `OrderSerial` = '{OrderSerial}'";
            Main.db.updateBySql(sql);



            // item to ActualQuantityDespatched
            sql = $@"INSERT INTO ActualQuantityDespatched
(WarehouseID, InvoiceID, ItemID, Quantity, BundlesNumber)
VALUES
({whID}, 
 '{invoiceID}',
 '{comboBoxSpareID.SelectedItem.ToString()}',
 {numActualQuantity.Value}, 
 {numSpareNumberofBundles.Value})";
            Main.db.insertBySql(sql);

            // get OrderItemToFollow qty - qty, if OrderItemToFollow qty - qty = 0, OrderItemToFollow delete a row, 
            // else update OrderItemToFollow qty - qty, and state to 'W'
            //            string updateOrderItemToFollowS
            sql = $@"UPDATE OrderItemToFollow
SET Quantity = Quantity - {numActualQuantity.Value},State = 'W'
WHERE OrderSerial = '{OrderSerial}' AND ItemID = '{comboBoxSpareID.SelectedItem}'";
            Main.db.updateBySql(sql);

            // comboBoxSpareID and dgvCollect remove this item
            dgvCollect.Rows.Remove(dgvCollect.Rows
    .OfType<DataGridViewRow>()
    .FirstOrDefault(x => x.Cells["ItemID"].Value.ToString() == comboBoxSpareID.SelectedItem.ToString()));
            comboBoxSpareID.Items.Remove(comboBoxSpareID.SelectedItem);

            if (comboBoxSpareID.Items.Count == 0)
            {
                sql = $@"DELETE FROM OrderItemForCollect 
WHERE OrderSerial = '{OrderSerial}' 
  AND Assgin = {whID}
  AND State = 'C'";
                Main.db.updateBySql(sql);
                getData();
            }

        }

        private void createInvoice()
        {
            //UTC+8
            string today = DateTime.UtcNow.AddHours(8).ToString("yyyyMMdd");// + dealerID.ToString().PadLeft(6, '0')
            string sql = $@"SELECT MAX(InvoiceID) as max_IID
FROM Invoice
WHERE InvoiceID LIKE '{today + dealerID.ToString().PadLeft(6, '0')}__'";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    string k = reader["max_IID"].ToString();
                    if (k == String.Empty)
                    {
                        invoiceID = today + dealerID.ToString().PadLeft(6, '0') + "01";
                    }
                    else
                    {
                        int max_IID = Convert.ToInt32(k.Substring(14));
                        if (max_IID != 0)
                        {
                            invoiceID = today + dealerID.ToString().PadLeft(6, '0') + ((max_IID + 1)%100).ToString().PadLeft(2, '0');
                        }
                    }
                }
                else
                {
                    invoiceID = today + dealerID.ToString().PadLeft(6, '0') + "01";
                }
            }

            sql = $@"INSERT INTO Invoice 
(InvoiceID, OrderSerial, DespatchForemanID, InvoiceDate, CompleteState)
VALUES
('{invoiceID}', 
 '{OrderSerial}',
 {Main.staffID},
 '{today}',
 'C')";
            Main.db.insertBySql(sql);

        }

    }
}
