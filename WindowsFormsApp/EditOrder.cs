using WindowsFormsApp.Properties;
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
    public partial class frmEditOrder : Form
    {
        string orderSerial;
        DataTable orderItem;
        public frmEditOrder()
        {
            InitializeComponent();
            comboBoxOrderSerial.Items.Clear();
            string sql = $"select OrderSerial from `Order` where DealerID = {Main.dealerID} Order by OrderDate DESC";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    comboBoxOrderSerial.Items.Add(reader[0].ToString());
                }
            }
        }
        public frmEditOrder(string orderSerial)
        {
            InitializeComponent();
            this.orderSerial = orderSerial;
            comboBoxOrderSerial.Items.Clear();
            comboBoxOrderSerial.Items.Add(orderSerial);
            comboBoxOrderSerial.SelectedIndex = 0;
            comboBoxOrderSerial.Enabled = false;
        }

        private void btnOrderItem_Click(object sender, EventArgs e)
        {

            if (comboBoxOrderSerial.SelectedItem == null)
            {
                Main.ShowMessage("Please select a Order");
                return;
            }
            string sql = $"SELECT oi.ItemID,s.SpareName, oi.Quantity, IFNULL(sum(aqd.Quantity), 0) AS 'Processed Qty' FROM OrderItem oi LEFT JOIN Invoice i ON oi.OrderSerial = i.OrderSerial LEFT JOIN ActualQuantityDespatched aqd ON i.InvoiceID = aqd.InvoiceID AND oi.ItemID = aqd.ItemID inner join Spare s on oi.ItemID = s.SpareID WHERE oi.OrderSerial = '{this.orderSerial}' GROUP BY oi.ItemID;";
            orderItem = Main.db.GetDataTable(sql);
            comboBoxSpareName.Items.Clear();
            comboBoxSpareName.Items.AddRange(orderItem.AsEnumerable().Select(x => x["SpareName"].ToString()).ToArray());


            tableLayoutPanel3.Visible  = tableLayoutPanel8.Visible = true;
            tableLayoutPanel5.Visible = tableLayoutPanel8.Visible = tableLayoutPanel4.Visible = false;
            btnSave.Visible = true;

        }

        private void bunOrderNumber_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderSerial.SelectedItem == null)
            {
                Main.ShowMessage(Resources.Please_select_a_Order);
                return;
            }
            string sql = $"select OrderNumberfromDealer from `Order` where OrderSerial = '{this.orderSerial}'";
            using (var reader = Main.db.readBySql(sql))
            {
                while(reader.Read()){
                    txtOrderNumber.Text = reader[0].ToString();
                }

            }



            tableLayoutPanel3.Visible = tableLayoutPanel4.Visible = tableLayoutPanel8.Visible = false;
            tableLayoutPanel5.Visible = true;
            btnSave.Visible = true;

        }

        private void frmEditOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (tableLayoutPanel5.Visible)
            {
                sql = $"update `Order` set OrderNumberfromDealer ='{txtOrderNumber.Text}' where OrderSerial = '{this.orderSerial}'";

            }else if (tableLayoutPanel3.Visible)
            {
                sql = $"update OrderItem set Quantity = {numericUpDownQuantity.Value} where OrderSerial = '{this.orderSerial}' and ItemID = '{txtSpareID.Text}'";
            }else
            {
                throw new Exception(Resources.No_data_to_save);
            }
            Main.db.updateBySql(sql);
            Main.ShowMessage(Resources.Saved);
        }


        private void comboBoxSpareName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrderSerial_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSave.Visible = tableLayoutPanel3.Visible = tableLayoutPanel4.Visible = tableLayoutPanel8.Visible = tableLayoutPanel5.Visible  =
                tableLayoutPanel8.Visible = tableLayoutPanel4.Visible= false;
            this.orderSerial = comboBoxOrderSerial.SelectedItem.ToString();
        }

        private void comboBoxSpareName_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSpareID.Text = orderItem.Select($"SpareName = '{comboBoxSpareName.SelectedItem}'")[0]["ItemID"].ToString();
            int quantity = Convert.ToInt32(orderItem.Select($"SpareName = '{comboBoxSpareName.SelectedItem}'")[0]["Quantity"]);
            numericUpDownQuantity.Value = numericUpDownQuantity.Maximum =  quantity;
            numericUpDownQuantity.Minimum = Convert.ToInt32(orderItem.Select($"SpareName = '{comboBoxSpareName.SelectedItem}'")[0]["Processed Qty"]);
            tableLayoutPanel8.Visible = tableLayoutPanel4.Visible = true;
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderSerial.SelectedItem == null)
            {
                Main.ShowMessage(Resources.Please_select_a_Order);
                return;
            }
            string sql = $"SELECT State FROM `Order` where OrderSerial = '{this.orderSerial}'";
            string state;
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                state = reader[0].ToString();
            }
            if(state == "C")
            {

                sql = $"DELETE FROM OrderItem WHERE OrderSerial = '{this.orderSerial}';";
                Main.db.updateBySql(sql);
                sql = $"DELETE FROM `Order` WHERE OrderSerial = '{this.orderSerial}';";
                Main.db.updateBySql(sql);
                Main.ShowMessage(Resources.Order_Deleted);
                (this.ParentForm as Main)?.lblTitle_Click_1(sender,e);
            }
            else
            {
                Main.ShowMessage(Resources.Order_can_not_be_deleted);
            }
        }
    }
}
