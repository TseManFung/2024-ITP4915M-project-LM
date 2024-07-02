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
    public partial class frmScrap : Form
    {
        private int Qty = 0; // 当前仓库中备件的数量
        private bool isTextChangedHandlerActive = true; // 标志位，防止递归调用
        public frmScrap()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // 檢查 comboBoxSpareID 是否有選取的項目
            if (comboBoxSpareID.SelectedItem == null)
            {
                return;
            }


            // 確認操作
            if (!Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_chang0)) return;

            // 檢查 txtQuantity 和 txtDiscrepancy 是否為空
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtDiscrepancy.Text))
            {
                Main.ShowYesNoDialog(Resources.Please_enter_full_data);
                return;
            }

            // 檢查數量是否為有效的整數
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                int staffID = GetStaffID();
                int warehouseID = GetWarehouseID(staffID);
                string itemID = comboBoxSpareID.SelectedItem.ToString();
                string discrepancy = txtDiscrepancy.Text;

                string sql = $"INSERT INTO ScrapItems (ItemID, WarehouseID, RecordTime, RecordStaffID, Quantity, Discrepancy) " +
                             $"VALUES ('{itemID}', {warehouseID}, '{DateTime.UtcNow.AddHours(8):yyyy-MM-dd HH:mm:ss}', {staffID}, {quantity}, '{discrepancy}')";
                Main.db.insertBySql(sql);

                UpdateStock(itemID, quantity, warehouseID);

                Main.ShowYesNoDialog(Resources.ScrapItem_Successful);
            }
        }

        private void frmScrap_Load(object sender, EventArgs e)
        {
            int staffID = GetStaffID();
            int warehouseID = GetWarehouseID(staffID);
            LoadSpareIDs(warehouseID);
        }

        private void txtDiscrepancy_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSpareID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int staffID = GetStaffID();
            int warehouseID = GetWarehouseID(staffID);
            string spareID = comboBoxSpareID.SelectedItem.ToString();
            Qty = GetActualStockQuantity(warehouseID, spareID);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!isTextChangedHandlerActive) return;

            if (int.TryParse(txtQuantity.Text, out int inputQuantity) && inputQuantity > Qty)
            {
                isTextChangedHandlerActive = false;
                txtQuantity.Text = Qty.ToString();
                isTextChangedHandlerActive = true;
            }
            else if (!int.TryParse(txtQuantity.Text, out _))
            {
                isTextChangedHandlerActive = false;
                txtQuantity.Clear();
                isTextChangedHandlerActive = true;
            }
        }
        private int GetStaffID()
        {
            string sql = $"SELECT StaffID FROM User WHERE UserID = {Main.userID}";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            return 0;
        }

        private int GetWarehouseID(int staffID)
        {
            string sql = $"SELECT w.WarehouseID FROM Staff s " +
                         $"JOIN Department d ON s.DeptID = d.DeptID " +
                         $"JOIN Warehouse w ON d.WarehouseID = w.WarehouseID " +
                         $"WHERE s.StaffID = {staffID}";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            return 0;
        }

        private void LoadSpareIDs(int warehouseID)
        {
            List<string> spareIDList = new List<string>();
            string sql = $"SELECT SpareID FROM ActualStock WHERE WarehouseID = {warehouseID} AND quantity > 0";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    spareIDList.Add(reader.GetString(0));
                }
            }
            comboBoxSpareID.DataSource = spareIDList;
        }

        private int GetActualStockQuantity(int warehouseID, string spareID)
        {
            string sql = $"SELECT quantity FROM ActualStock WHERE WarehouseID = {warehouseID} AND SpareID = '{spareID}'";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            return 0;
        }
        private void UpdateStock(string spareID, int quantity, int warehouseID)
        {
            // 更新 Stock 表
            string sql = $"UPDATE Stock SET quantity = quantity - {quantity} WHERE SpareID = '{spareID}'";
            Main.db.updateBySql(sql);

            // 更新 ActualStock 表
            sql = $"UPDATE ActualStock SET quantity = quantity - {quantity} WHERE SpareID = '{spareID}' AND WarehouseID = {warehouseID}";
            Main.db.updateBySql(sql);
        }
    }
}
