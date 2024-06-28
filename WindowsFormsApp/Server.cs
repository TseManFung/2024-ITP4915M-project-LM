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
            Main.db.updateBySql(sql); AssignOrderItemsToCollect();

        }
        public void AssignOrderItemsToCollect()
        {
            string fetchOrderItemsSql = @"
            SELECT oit.OrderSerial, oit.ItemID, oit.Quantity, o.DealerID, o.State AS OrderState, sa.AreaID AS DealerAreaID
            FROM OrderItemToFollow oit
            JOIN `Order` o ON oit.OrderSerial = o.OrderSerial
            JOIN Dealer d ON o.DealerID = d.DealerID
            JOIN SaleArea sa ON d.SaleAreaID = sa.AreaID
            WHERE oit.State != 'D'"; // Assuming 'D' means 'Done'

            DataTable orderItemsTable = Main.db.GetDataTable(fetchOrderItemsSql);

            foreach (DataRow orderItemRow in orderItemsTable.Rows)
            {
                string orderSerial = orderItemRow["OrderSerial"].ToString();
                string itemId = orderItemRow["ItemID"].ToString();
                int quantity = Convert.ToInt32(orderItemRow["Quantity"]);
                int dealerId = Convert.ToInt32(orderItemRow["DealerID"]);
                string orderState = orderItemRow["OrderState"].ToString();
                int dealerAreaId = Convert.ToInt32(orderItemRow["DealerAreaID"]);

                // Fetch SaleArea's coordinates for the dealer
                string fetchDealerSaleAreaSql = $@"
                SELECT Latitude, Longitude
                FROM SaleArea
                WHERE AreaID = {dealerAreaId}";

                DataTable dealerSaleAreaTable = Main.db.GetDataTable(fetchDealerSaleAreaSql);
                double dealerLatitude = 0;
                double dealerLongitude = 0;
                if (dealerSaleAreaTable.Rows.Count > 0)
                {
                    dealerLatitude = Convert.ToDouble(dealerSaleAreaTable.Rows[0]["Latitude"]);
                    dealerLongitude = Convert.ToDouble(dealerSaleAreaTable.Rows[0]["Longitude"]);
                }

                int remainingQuantity = quantity;

                // Find the nearest Warehouses with enough stock using Haversine formula
                string fetchWarehousesSql = $@"
                SELECT w.WarehouseID, w.SaleAreaID, ast.quantity as AvailableQuantity,
                       sa.Latitude, sa.Longitude,
                       (6371 * acos(cos(radians({dealerLatitude})) * cos(radians(sa.Latitude)) * cos(radians(sa.Longitude) - radians({dealerLongitude})) + sin(radians({dealerLatitude})) * sin(radians(sa.Latitude)))) AS distance
                FROM Warehouse w
                JOIN ActualStock ast ON w.WarehouseID = ast.WarehouseID
                JOIN SaleArea sa ON w.SaleAreaID = sa.AreaID
                WHERE ast.SpareID = '{itemId}' AND ast.quantity > 0
                ORDER BY distance ASC";

                DataTable warehousesTable = Main.db.GetDataTable(fetchWarehousesSql);

                foreach (DataRow warehouseRow in warehousesTable.Rows)
                {
                    if (remainingQuantity <= 0) break;

                    int warehouseId = Convert.ToInt32(warehouseRow["WarehouseID"]);
                    int availableQuantity = Convert.ToInt32(warehouseRow["AvailableQuantity"]);

                    int assignedQuantity = Math.Min(availableQuantity, remainingQuantity);

                    // Insert into OrderItemForCollect
                    string insertCollectSql = $@"
                    INSERT INTO OrderItemForCollect (OrderSerial, ItemID, Assgin, Quantity)
                    VALUES ('{orderSerial}', '{itemId}', {warehouseId}, {assignedQuantity})";

                    Main.db.insertBySql(insertCollectSql);

                    // Update ActualStock
                    string updateStockSql = $@"
                    UPDATE ActualStock
                    SET quantity = quantity - {assignedQuantity}
                    WHERE WarehouseID = {warehouseId} AND SpareID = '{itemId}'";

                    Main.db.updateBySql(updateStockSql);

                    remainingQuantity -= assignedQuantity;
                }

                if (remainingQuantity <= 0)
                {
                    // Update OrderItemToFollow state to 'D' (Done)
                    string updateOrderItemToFollowSql = $@"
                    UPDATE OrderItemToFollow
                    SET State = 'D'
                    WHERE OrderSerial = '{orderSerial}' AND ItemID = '{itemId}'";

                    Main.db.updateBySql(updateOrderItemToFollowSql);

                    // Update Order state to 'P' if it is 'C' or 'W'
                    if (orderState == "C" || orderState == "W")
                    {
                        string updateOrderSql = $@"
                        UPDATE `Order`
                        SET State = 'P'
                        WHERE OrderSerial = '{orderSerial}'";

                        Main.db.updateBySql(updateOrderSql);
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough stock for ItemID: {itemId} in any warehouse.");

                }
            }
            Main.ShowMessage(Resources.Order_Items_Assigned_to_Collec);
        }
    }
}
