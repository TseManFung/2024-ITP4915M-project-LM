﻿using WindowsFormsApp.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp
{
    public partial class frmCart : Form
    {
        DataTable Cart;
        public frmCart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            getData();
            number.Controls[0].Visible = false;
            if (Cart.Rows.Count > 0)
            {
                txtSpareID.Text = dgvSelectedSpare.Rows[0].Cells[Resources.SpareID].Value.ToString();
                number.Value = Convert.ToInt32(dgvSelectedSpare.Rows[0].Cells[Resources.Qty].Value);

            }
            cucalateTotal(Cart.DefaultView);


        }

        private void getData()
        {
            // 
            string sql = $"SELECT c.SpareID, c.Qty, sp.SpareName, sp.Price, sp.Description, sp.Weight FROM Cart AS c JOIN Spare AS sp ON c.SpareID = sp.SpareID Where UserID = {Main.userID};";
            Cart = Main.db.GetDataTable(sql);
            dgvSelectedSpare.DataSource = Cart;

            CheckQuantity();
        }
        private bool CheckQuantity()
        {
            foreach (DataGridViewRow row in dgvSelectedSpare.Rows)
            {
                int qty = Convert.ToInt32(row.Cells[Resources.Qty].Value);
                int stock = getStock(row.Cells[Resources.SpareID].Value.ToString());
                if (qty > stock)
                {
                    qty = stock;
                    row.Cells[Resources.Qty].Style.BackColor = Color.Yellow;
                    return false;
                }
            }
            return true;
        }

        public int getStock(string sid)
        {
            string sql = $"SELECT quantity FROM Stock WHERE SpareID = '{sid}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    return reader.GetInt32(Resources.quantity);
                }
            }
            throw new Exception(Resources.No_stock_found);
        }

        private void dgvSelectedSpareName_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sid = dgvSelectedSpare.Rows[e.RowIndex].Cells[Resources.SpareID].Value.ToString();
            if (sid != txtSpareID.Text)
            {
                try{
                txtSpareID.Text = sid;
                number.Maximum = getStock(sid);
                    number.Value = Convert.ToInt32(dgvSelectedSpare.Rows[e.RowIndex].Cells[Resources.Qty].Value); }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    number.Value = number.Maximum;
                }
            }
        }

        private DataTable GetSelectedColumns(DataTable table, params string[] columnNames)
        {
            DataTable selectedTable = new DataTable();
            foreach (string columnName in columnNames)
            {
                selectedTable.Columns.Add(columnName, table.Columns[columnName].DataType);
            }

            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = selectedTable.NewRow();
                foreach (string columnName in columnNames)
                {
                    newRow[columnName] = row[columnName];
                }
                selectedTable.Rows.Add(newRow);
            }

            return selectedTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            change_qty(1);
        }
        private void btnReduce_Click(object sender, EventArgs e)
        {
            change_qty(-1);
        }

        private void change_qty(int change)
        {
            decimal qty = number.Value;
            try
            {
                number.Value = Math.Floor(qty + change);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void number_ValueChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(number.Value);
            var selectedRows = Cart.Select("SpareID = '" + txtSpareID.Text + "'");
            if (selectedRows.Length > 0 && n >=1 && n <=number.Maximum)
            {
                selectedRows[0][Resources.Qty] = n;
            }else if (n > number.Maximum)
            {
                number.Value = number.Maximum;

            }

            cucalateTotal(Cart.DefaultView);
        }

        private void cucalateTotal(DataView dv)
        {
            int TotalQuantity = 0;
            decimal TotalPrice = 0;
            foreach (DataRowView row in dv)
            {
                TotalPrice += Convert.ToDecimal(row[Resources.Price]) * Convert.ToDecimal(row[Resources.Qty]);
                TotalQuantity += Convert.ToInt32(row[Resources.Qty]);
            }
            lblTotalPrice.Text = String.Format(Resources.IS_Total_Price_0,TotalPrice);
            lblTotalQuantity.Text = String.Format(Resources.IS_Total_Quantity_0,TotalQuantity);
        }

        // ---------------- Remove with database record ----------------

        private void removeRow(int index)
        {
            // get spare ID from index
            string sid = dgvSelectedSpare.Rows[index].Cells[Resources.SpareID].Value.ToString(),
                sn = dgvSelectedSpare.Rows[0].Cells[Resources.SpareName].Value.ToString();

            // remove from database
            if (Main.ShowYesNoDialog(String.Format(Resources.IS_Are_you_sure_you_want_to_re,sid,sn)))
            {
                string sql = String.Format(Resources.IS_DELETE_FROM_Cart_WHERE_Spar,sid,Main.userID);
                Main.db.updateBySql(sql);

                Cart.Rows.RemoveAt(index);
                cucalateTotal(Cart.DefaultView);
            }

        }
        private void removeAllRow()
        {
            if (Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_remov))
            {
                ClearCart();
            }
        }
        private void ClearCart()
        {
            string sql = $"DELETE FROM Cart WHERE UserID = {Main.userID};";
            Main.db.updateBySql(sql);

            Cart.Clear();
            cucalateTotal(Cart.DefaultView);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvSelectedSpare.CurrentCell == null)
            {
                return;
            }
            removeRow(dgvSelectedSpare.CurrentCell.RowIndex);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            removeAllRow();
        }
        // ---------------- Create Order ----------------
        // upload修改的qty到資料庫
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Cart.Rows.Count <= 0)
            {
                Main.ShowMessage(Resources.No_item_in_cart);
                return;
            }
            int? dealerID = Main.dealerID;
            string orderID;



            // yyyyMMdd-HHmm-a fixed length(6) for dealerID
            // make sure is utf +8
            orderID = DateTime.UtcNow.AddHours(8).ToString("yyyyMMdd-HHmm-") + dealerID.ToString().PadLeft(6, '0');
            string DorderNumber = null;
            if (txtDorderNumber.Text != "")
            {
                DorderNumber = txtDorderNumber.Text;
            }
            try
            {
                Main.db.insert(Resources._Order, orderID, dealerID, DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss"), DorderNumber, "C", null);
            }
            catch (Exception ex) {
                Main.ShowMessage(Resources.System_is_busy_please_try_agai);
                return;
            }


            foreach (DataRow row in Cart.Rows)
            {
                // get the current stock
                string stockSQL = $"SELECT quantity FROM Stock WHERE SpareID = '{row[Resources.SpareID]}';";
                int stock;
                int qty = Convert.ToInt32(row[Resources.Qty]);
                using (var reader = Main.db.readBySql(stockSQL))
                {
                    stock = reader.Read() ? reader.GetInt32(Resources.quantity) : throw new Exception(Resources.can_not_get_stock);
                }
                if (stock < qty)
                {
                    if (Main.ShowYesNoDialog(String.Format(Resources.IS_Not_enough_stock_for_0_1_On,row[Resources.SpareID],row[Resources.SpareName],stock)))
                    {
                        qty = stock;
                    }
                    else
                    {
                        // delete the order
                        Main.db.updateBySql($"DELETE FROM `OrderItem` WHERE `OrderSerial` = \"{orderID}\";");

                        Main.db.updateBySql($"DELETE FROM `Order` WHERE `OrderSerial` = \"{orderID}\";");
                        //update the database
                        Main.db.updateBySql($"Update `Cart` set `Qty` = {stock} Where UserID = {Main.userID} and SpareID = \"{row[Resources.SpareID]}\"");
                        getData();
                        number.Value = stock;
                        return;
                    }
                }

                // get the current price
                decimal price;

                using (var reader = Main.db.readBySql($"SELECT Price FROM Spare WHERE SpareID = '{row[Resources.SpareID]}';"))
                {
                    price = reader.Read() ? reader.GetDecimal(Resources.Price) : throw new Exception(Resources.can_not_get_price);
                }
                if (price != (decimal)row[Resources.Price])
                {
                    if (Main.ShowYesNoDialog(String.Format(Resources.IS_The_price_of_0_1_has_change,row[Resources.SpareID],row[Resources.SpareName],row[Resources.Price],price)))
                    {
                        row[Resources.Price] = price;
                    }
                    else
                    {
                        // delete the order
                        Main.db.updateBySql($"DELETE FROM OrderItem WHERE OrderSerial = '{orderID}';");

                        Main.db.updateBySql($"DELETE FROM Order WHERE OrderSerial = '{orderID}';");
                        getData();

                        return;

                    }
                }

                Main.db.insert(Resources.OrderItem, orderID, row[Resources.SpareID], qty, row[Resources.Price]);
                // - the stock
                Main.db.updateBySql($"UPDATE Stock SET quantity = quantity - {qty} WHERE SpareID = '{row[Resources.SpareID]}';");

            }
            ClearCart();
            txtSpareID.Text = "";
            number.Value = 1;
            Main.ShowMessage(String.Format(Resources.IS_Order_placed_successfully_t,orderID));
            (this.ParentForm as Main)?.refreshPage();
        }

        private void uploadToDB()
        {
            foreach (DataRow row in Cart.Rows)
            {
                string sql = $"UPDATE Cart SET Qty = {row[Resources.Qty]} WHERE SpareID = \"{row[Resources.SpareID]}\" AND UserID = {Main.userID};";
                Main.db.updateBySql(sql);
            }
        }



        private void frmCart_Leave(object sender, EventArgs e)
        {
            if (Cart.Rows.Count <= 0)
            { return; }

            uploadToDB();
        }
    }
}
