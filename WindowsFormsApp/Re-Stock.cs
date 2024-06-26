﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WindowsFormsApp
{

    public partial class frmReStock : Form
    {
        private BindingSource restockBindingSource = new BindingSource();
        private BindingSource followingROLBindingSource = new BindingSource();
        DataTable RestockOrder;
        int respent_warehouse = 0;
        public frmReStock()
        {
            InitializeComponent();
            // 确保 DataGridView 允许整行选择
            this.dgvItemFollowingROL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void InitializeDgvRestock()
        {
            // 初始化dgvRestock的列，與dgvItemFollowingROL列一致
            dgvRestock.Columns.Clear();
            foreach (DataGridViewColumn column in dgvItemFollowingROL.Columns)
            {
                dgvRestock.Columns.Add((DataGridViewColumn)column.Clone());
            }
        }
        private void lblFollowingROL_Click(object sender, EventArgs e)
        {

        }

        private void dgvItemFollowingROL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void getData()
        {
            string sql_getwarehouse = $"SELECT d.WarehouseID FROM User u INNER JOIN Staff s ON u.StaffID = s.StaffID INNER JOIN Department d ON s.DeptID = d.DeptID WHERE u.UserID={Main.userID};";
            using (var reader = Main.db.readBySql(sql_getwarehouse))
            {
                reader.Read();
                respent_warehouse = reader.GetInt32(0);
            }
            string sql = $@" SELECT ws.WarehouseID, ws.SpareID, a.quantity FROM WarehouseStockLevel ws JOIN ActualStock a ON ws.WarehouseID = a.WarehouseID AND ws.SpareID = a.SpareID WHERE a.quantity <= ws.ROL AND a.WarehouseID = '{respent_warehouse}' AND NOT EXISTS ( SELECT 1 FROM RestockItem ri JOIN RestockOrder ro ON ri.RestockOrderID = ro.RestockOrderID WHERE ri.ItemID = ws.SpareID AND ri.Quantity = a.quantity AND ri.State = 'C' AND ro.WarehouseID = '{respent_warehouse}' ); "; 
            RestockOrder = Main.db.GetDataTable(sql);

        }

        private void frmReStock_Load(object sender, EventArgs e)
        {

            getData();

            if (RestockOrder == null || RestockOrder.Rows.Count == 0)
            {
                //Main.ShowMessage("No ROL item");
                return;
            }

            try
            {
                // 使用 BindingSource 進行數據綁定
                followingROLBindingSource.DataSource = RestockOrder.Clone(); // 克隆一個空表給 followingROL
                restockBindingSource.DataSource = RestockOrder;

                dgvItemFollowingROL.DataSource = restockBindingSource;
                dgvRestock.DataSource = followingROLBindingSource;

                InitializeDgvRestock();
            }
            catch (InvalidOperationException ex)
            {
                Main.ShowMessage("No data found");
            }
        }

        private void btnMovedown_Click(object sender, EventArgs e)
        {
            if (dgvItemFollowingROL.Rows.Count == 0)
            {
                Main.ShowMessage("No rows available to move.");
                return;
            }

            if (dgvItemFollowingROL.SelectedRows.Count == 0)
            {
                Main.ShowMessage("Please select a row to move.");
                return;
            }

            int selectedIndex = dgvItemFollowingROL.SelectedRows[0].Index;

            DataTable restockTable = (DataTable)restockBindingSource.DataSource;
            DataTable followingROLTable = (DataTable)followingROLBindingSource.DataSource;

            if (restockTable == null || followingROLTable == null)
            {
                Main.ShowMessage("Data sources are not properly initialized.");
                return;
            }

            if (selectedIndex < 0 || selectedIndex >= restockTable.Rows.Count)
            {
                return;
            }

            DataRow rowToMove = restockTable.Rows[selectedIndex];
            DataRow newRow = followingROLTable.NewRow();
            newRow.ItemArray = rowToMove.ItemArray;

            followingROLTable.Rows.Add(newRow);
            restockTable.Rows.Remove(rowToMove);

            // Refresh BindingSource
            restockBindingSource.ResetBindings(false);
            followingROLBindingSource.ResetBindings(false);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (dgvRestock.Rows.Count == 0)
            {
                Main.ShowMessage("No rows available to move.");
                return;
            }

            if (dgvRestock.SelectedRows.Count == 0)
            {
                Main.ShowMessage("Please select a row to move.");
                return;
            }

            int selectedIndex = dgvRestock.SelectedRows[0].Index;

            DataTable restockTable = (DataTable)restockBindingSource.DataSource;
            DataTable followingROLTable = (DataTable)followingROLBindingSource.DataSource;

            if (restockTable == null || followingROLTable == null)
            {
                Main.ShowMessage("Data sources are not properly initialized.");
                return;
            }

            if (selectedIndex < 0 || selectedIndex >= followingROLTable.Rows.Count)
            {
                return;
            }

            DataRow rowToMove = followingROLTable.Rows[selectedIndex];
            DataRow newRow = restockTable.NewRow();
            newRow.ItemArray = rowToMove.ItemArray;

            restockTable.Rows.Add(newRow);
            followingROLTable.Rows.Remove(rowToMove);

            // Refresh BindingSource
            restockBindingSource.ResetBindings(false);
            followingROLBindingSource.ResetBindings(false);
        }

        private void btnReStockConfirm_Click(object sender, EventArgs e)
        {
            // 確保 DataGridView 有行可供處理
            if (dgvRestock.Rows.Count == 0)
            {
                MessageBox.Show("No rows available in the restock list.");
                return;
            }

            bool rowsProcessed = false;
            string processedRowsDetails = string.Empty;
            int RestockOrderID = 0;

            // 獲取最大的 RestockOrderID 並加 1
            string query = " SELECT MAX(RestockOrderID) AS NextRestockOrderID FROM RestockOrder;";
            using (var reader = Main.db.readBySql(query))
            {
                if (reader.Read())
                {
                    RestockOrderID = reader.GetInt32(0);
                }
            }
            RestockOrderID += 1;
            // 插入新的 RestockOrder
            query = $"INSERT INTO RestockOrder (RestockOrderID, WarehouseID, OrderDate, Remark) VALUES ({RestockOrderID}, '{respent_warehouse}', '{DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd")}', 'ROL order')";
            Main.db.insertBySql(query);

            // 遍歷 DataGridView 中的所有行
            foreach (DataGridViewRow row in dgvRestock.Rows)
            {
                // 跳過新的行佔位符（如果有）
                if (row.IsNewRow) continue;

                // 使用列名獲取特定列中的數據
                var warehouseID = row.Cells["WarehouseID"].Value;
                var spareID = row.Cells["SpareID"].Value;
                var quantity = row.Cells["quantity"].Value;

                // 插入 RestockItem
                query = $"INSERT INTO RestockItem (RestockOrderID, ItemID, Quantity, State) VALUES ({RestockOrderID}, '{spareID}', {quantity}, 'C')";
                Main.db.insertBySql(query);

                // 處理數據並構建詳細信息字符串
                processedRowsDetails += $"WarehouseID: {warehouseID}, SpareID: {spareID}, Quantity: {quantity}\n";

                rowsProcessed = true; // 設置標誌，表明至少有一行被處理
            }

            // 顯示處理的行的詳細信息或沒有行的消息
            if (rowsProcessed)
            {
                MessageBox.Show($"Processed Rows:\n{processedRowsDetails}");
            }
            else
            {
                MessageBox.Show("No rows were processed.");
            }
        }
    }
}
