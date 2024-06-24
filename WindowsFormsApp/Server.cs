using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace WindowsFormsApp
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string sql;
            sql = $"INSERT INTO `OrderItemToFollow` (`OrderSerial`, `ItemID`, `Quantity`, `State`) SELECT `OrderSerial`, `ItemID`, `Quantity`, 'W' FROM `OrderItem` WHERE `OrderSerial` IN (   SELECT `OrderSerial`   FROM `Order`   WHERE `State` = 'C' );";
            Main.db.insertBySql(sql);
            sql = $"UPDATE `Order` SET `State` = 'W' WHERE `State` = 'C';";
            Main.db.updateBySql(sql);AssignOrderItemsToCollect();

        }
        public void AssignOrderItemsToCollect()
        {
            // Fetch all OrderItemToFollow records that are not completed
            string fetchOrderItemsSql = @"
            SELECT oit.OrderSerial, oit.ItemID, oit.Quantity, o.DealerID 
            FROM OrderItemToFollow oit
            JOIN `Order` o ON oit.OrderSerial = o.OrderSerial
            WHERE oit.State != 'D'"; // Assuming 'D' means 'Done'

            DataTable orderItemsTable = Main.db.GetDataTable(fetchOrderItemsSql);

            foreach (DataRow orderItemRow in orderItemsTable.Rows)
            {
                string orderSerial = orderItemRow["OrderSerial"].ToString();
                string itemId = orderItemRow["ItemID"].ToString();
                int quantity = Convert.ToInt32(orderItemRow["Quantity"]);
                int dealerId = Convert.ToInt32(orderItemRow["DealerID"]);

                // Fetch Dealer's DeliveryAddress or OfficeAddress
                string fetchDealerAddressSql = $@"
                SELECT COALESCE(NULLIF(d.DeliveryAddress, ''), d.OfficeAddress) as Address
                FROM Dealer d
                WHERE d.DealerID = {dealerId}";

                DataTable dealerAddressTable = Main.db.GetDataTable(fetchDealerAddressSql);
                string dealerAddress = "";
                if (dealerAddressTable.Rows.Count > 0)
                {
                    dealerAddress = dealerAddressTable.Rows[0]["Address"].ToString();
                }

                // Find the nearest Warehouse with enough stock
                string fetchWarehouseSql = $@"
                SELECT w.WarehouseID, ast.quantity as AvailableQuantity
                FROM Warehouse w
                JOIN ActualStock ast ON w.WarehouseID = ast.WarehouseID
                WHERE ast.SpareID = '{itemId}' AND ast.quantity >= {quantity}
                ORDER BY ast.quantity DESC
                LIMIT 1"; // Simplified to pick the warehouse with the most stock

                DataTable warehouseTable = Main.db.GetDataTable(fetchWarehouseSql);
                if (warehouseTable.Rows.Count > 0)
                {
                    int warehouseId = Convert.ToInt32(warehouseTable.Rows[0]["WarehouseID"]);
                    int availableQuantity = Convert.ToInt32(warehouseTable.Rows[0]["AvailableQuantity"]);

                    // Check if we can assign the quantity
                    if (availableQuantity >= quantity)
                    {
                        // Insert into OrderItemForCollect
                        string insertCollectSql = $@"
                        INSERT INTO OrderItemForCollect (OrderSerial, ItemID, Assgin, Quantity)
                        VALUES ('{orderSerial}', '{itemId}', {warehouseId}, {quantity})";

                        Main.db.insertBySql(insertCollectSql);

                        // Update ActualStock
                        string updateStockSql = $@"
                        UPDATE ActualStock
                        SET quantity = quantity - {quantity}
                        WHERE WarehouseID = {warehouseId} AND SpareID = '{itemId}'";

                        Main.db.updateBySql(updateStockSql);

                        // Update OrderItemToFollow state to 'D' (Done)
                        string updateOrderItemToFollowSql = $@"
                        UPDATE OrderItemToFollow
                        SET State = 'D'
                        WHERE OrderSerial = '{orderSerial}' AND ItemID = '{itemId}'";

                        Main.db.updateBySql(updateOrderItemToFollowSql);
                    }
                    else
                    {
                        Console.WriteLine($"Not enough stock for ItemID: {itemId} in any warehouse.");
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough stock for ItemID: {itemId} in any warehouse.");
                }
            }
        }
    }
}
