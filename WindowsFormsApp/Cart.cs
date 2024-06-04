using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MySqlConnector;
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
            dgvSelectedSpare.DataSource = Cart;
            number.Controls[0].Visible = false;
            if (Cart.Rows.Count > 0)
            {
                txtSpareID.Text = dgvSelectedSpare.Rows[0].Cells["SpareID"].Value.ToString();
                number.Value = Convert.ToInt32(dgvSelectedSpare.Rows[0].Cells["Qty"].Value);

            }
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

            CheckQuantity();
        }
        private bool CheckQuantity()
        {
            foreach (DataRow row in dgvSelectedSpare.Rows)
            {
                int qty = Convert.ToInt32(row["Qty"]);
                int stock = Convert.ToInt32(row["quantity"]);
                if (qty > stock)
                {
                    qty = stock;
                    ((DataGridViewCell)row["Qty"]).Style.BackColor = Color.Yellow;
                    return false;
                }
            }
            return true;
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
            string sid = dgvSelectedSpare.Rows[e.RowIndex].Cells["SpareID"].Value.ToString();
            if (sid != txtSpareID.Text)
            {
                txtSpareID.Text = sid;
                number.Maximum = getStock(sid);
                number.Value = Convert.ToInt32(dgvSelectedSpare.Rows[e.RowIndex].Cells["Qty"].Value);
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

        private void removeRow(int index)
        {
            // get spare ID from index
            string sid = dgvSelectedSpare.Rows[index].Cells["SpareID"].Value.ToString(),
                sn = dgvSelectedSpare.Rows[0].Cells["SpareName"].Value.ToString();

            // remove from database
            if (Main.ShowYesNoDialog($"Are you sure you want to remove {sid}:{sn} from your cart?"))
            {
                string sql = $"DELETE FROM Cart WHERE SpareID = '{sid}' AND UserID = {Main.userID};";
                Main.db.updateBySql(sql);

                Cart.Rows.RemoveAt(index);
                cucalateTotal(Cart.DefaultView);
            }

        }
        private void removeAllRow()
        {
            if (Main.ShowYesNoDialog("Are you sure you want to remove all items from your cart?"))
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
                Main.ShowMessage("No item in cart");
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

            Main.db.insert("Order", orderID, dealerID, DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd HH:MM:ss"), DorderNumber, "C", null);


            foreach (DataRow row in Cart.Rows)
            {
                // get the current stock
                string stockSQL = $"SELECT SUM(quantity) as quantity FROM Stock WHERE SpareID = '{row["SpareID"]}';";
                int stock;
                int qty = Convert.ToInt32(row["Qty"]);
                using (var reader = Main.db.readBySql(stockSQL))
                {
                    stock = reader.Read() ? reader.GetInt32("quantity") : throw new Exception("can not get stock");
                }
                if (stock < qty)
                {
                    if (Main.ShowYesNoDialog($"Not enough stock for {row["SpareID"]}:{row["SpareName"]}\n Only can order {stock}\nStill placing order?"))
                    {
                        qty = stock;
                    }
                    else
                    {
                        // delete the order
                        Main.db.updateBySql($"DELETE FROM OrderItem WHERE OrderID = '{orderID}';");
                        Main.db.updateBySql($"DELETE FROM Order WHERE OrderID = '{orderID}';");
                        getData();

                        return;
                    }
                }

                // get the current price
                decimal price;

                using (var reader = Main.db.readBySql($"SELECT Price FROM Spare WHERE SpareID = '{row["SpareID"]}';"))
                {
                    price = reader.Read() ? reader.GetDecimal("Price") : throw new Exception("can not get price");
                }
                if (price != (decimal)row["Price"])
                {
                    if (Main.ShowYesNoDialog($"The price of {row["SpareID"]}:{row["SpareName"]} has changed from {row["Price"]} to {price}\nStill placing order?"))
                    {
                        row["Price"] = price;
                    }
                    else
                    {
                        // delete the order
                        Main.db.updateBySql($"DELETE FROM OrderItem WHERE OrderID = '{orderID}';");
                        Main.db.updateBySql($"DELETE FROM Order WHERE OrderID = '{orderID}';");
                        getData();

                        return;

                    }
                }

                Main.db.insert("OrderItem", orderID, row["SpareID"], qty, row["Price"]);

            }
            ClearCart();
            txtSpareID.Text = "";
            number.Value = 1;
            Main.ShowMessage($"Order placed successfully, the order serial is {orderID}");
        }

        private void uploadToDB()
        {
            foreach (DataRow row in Cart.Rows)
            {
                string sql = $"UPDATE Cart SET Qty = {row["Qty"]} WHERE SpareID = \"{row["SpareID"]}\" AND UserID = {Main.userID};";
                Main.db.updateBySql(sql);
            }
        }

        private void frmCart_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCart_Leave(object sender, EventArgs e)
        {
            if (Cart.Rows.Count <= 0)
            { return; }

            uploadToDB();
        }
    }
}
