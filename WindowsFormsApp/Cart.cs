﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dgvSelectedSpareName.DataSource = Cart;
            number.Controls[0].Visible = false;
            txtSpareID.Text = dgvSelectedSpareName.Rows[0].Cells["SpareID"].Value.ToString();
            number.Value = Convert.ToInt32(dgvSelectedSpareName.Rows[0].Cells["Qty"].Value);

            cucalateTotal(Cart.DefaultView);

        }

        private void getData()
        {
            // 
            string sql = $"SELECT c.SpareID, c.Qty, sp.SpareName, sp.Price, sp.Description, sp.Weight FROM Cart AS c JOIN Spare AS sp ON c.SpareID = sp.SpareID Where UserID = {Main.userID};";
            var conn = Main.db.get_dbconnect();
            Cart = new DataTable();

            using (var da = new MySqlDataAdapter(sql, conn))
            {
                da.Fill(Cart);
            }

        }

        public int getStock(string sid)
        {
            string sql = $"SELECT SUM(quantity) as quantity FROM Stock WHERE SpareID = '{sid}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    return reader.GetInt32("quantity");
                }
            }
            throw new Exception("No stock found");
        }

        private void dgvSelectedSpareName_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sid = dgvSelectedSpareName.Rows[e.RowIndex].Cells["SpareID"].Value.ToString();
            if (sid != txtSpareID.Text)
            {
                txtSpareID.Text = sid;
                number.Maximum = getStock(sid);
                number.Value = Convert.ToInt32(dgvSelectedSpareName.Rows[e.RowIndex].Cells["Qty"].Value);
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
            if (selectedRows.Length > 0)
            {
                selectedRows[0]["Qty"] = n;
            }

            cucalateTotal(Cart.DefaultView);
        }

        private void cucalateTotal(DataView dv)
        {
            int TotalQuantity = 0;
            decimal TotalPrice = 0;
            foreach (DataRowView row in dv)
            {
                TotalPrice += Convert.ToDecimal(row["Price"]) * Convert.ToDecimal(row["Qty"]);
                TotalQuantity += Convert.ToInt32(row["Qty"]);
            }
            lblTotalPrice.Text = $"Total Price:\n{TotalPrice}";
            lblTotalQuantity.Text = $"Total Quantity:\n{TotalQuantity}";
        }

        // ---------------- Remove with database record ----------------

        private bool ShowYesNoDialog(string message)
        {
            var result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private void removeRow(int index)
        {
            // get spare ID from txtSpareID
            string sid = txtSpareID.Text;
            // remove from database
            if (ShowYesNoDialog("Are you sure you want to remove this item from your cart?"))
            {
                string sql = $"DELETE FROM Cart WHERE SpareID = '{sid}' AND UserID = {Main.userID};";
                Main.db.updateBySql(sql);
                // remove from DataTable
                Cart.Rows.RemoveAt(index);
                cucalateTotal(Cart.DefaultView);
            }

        }
        private void removeAllRow() { }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }
        // ---------------- Create Order ----------------
        // upload修改的qty到資料庫
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            uploadToDB();
        }

        private void uploadToDB()
        {
            foreach (DataRow row in Cart.Rows)
            {
                string sql = $"UPDATE Cart SET Qty = {row["Qty"]} WHERE SpareID = {row["SpareID"]} AND UserID = {Main.userID};";
                Main.db.updateBySql(sql);
            }
        }

        private void frmCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Cart.Rows.Count <= 0)
            { return; }

            uploadToDB();

        }
    }
}
