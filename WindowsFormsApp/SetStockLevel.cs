using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmSetStockLevel : Form
    {

        public frmSetStockLevel()
        {
            InitializeComponent();
        }

        private void frmSetStockLevel_Load(object sender, EventArgs e)
        {
            LoadSpareIDs();
        }
        private void LoadSpareIDs()
        {
            string sql = "SELECT SpareID FROM Spare";
            using (var reader = Main.db.readBySql(sql))
            {
                comboBoxSpareID.Items.Clear();
                while (reader.Read())
                {
                    comboBoxSpareID.Items.Add(reader.GetString(0));
                }
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
            throw new Exception("StaffID not found for current user.");
        }
        private int GetWarehouseID(int staffID)
        {
            string sql = $"SELECT w.WarehouseID FROM Staff s JOIN Department d ON s.DeptID = d.DeptID JOIN Warehouse w ON d.WarehouseID = w.WarehouseID WHERE s.StaffID = {staffID}";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            throw new Exception("WarehouseID not found for current staff.");
        }
        private void LoadSpareDetails(string spareID, int warehouseID)
        {
            string sql = $"SELECT SpareName FROM Spare WHERE SpareID = '{spareID}'";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    txtSpareName.Text = reader.GetString(0);
                }
            }

            txtReOrderLevel.Text = GetStockLevel(spareID, warehouseID, "ROL").ToString();
            txtDangerLevel.Text = GetStockLevel(spareID, warehouseID, "DL").ToString();
            txtCommonStockLevel.Text = GetStockLevel(spareID, warehouseID, "CSL").ToString();
        }
        private int GetStockLevel(string spareID, int warehouseID, string column)
        {
            string sql = $"SELECT {column} FROM WarehouseStockLevel WHERE SpareID = '{spareID}' AND WarehouseID = {warehouseID}";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    return reader.GetInt32(0);
                }
            }
            return 0;
        }
        private void comboBoxSpareID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int staffID = GetStaffID();
            int warehouseID = GetWarehouseID(staffID);
            string spareID = comboBoxSpareID.SelectedItem.ToString();

            LoadSpareDetails(spareID, warehouseID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int staffID = GetStaffID();
            int warehouseID = GetWarehouseID(staffID);

            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {
                if (ValidateInput())
                {
                    int reOrderLevel = int.Parse(txtReOrderLevel.Text);
                    int commonStockLevel = int.Parse(txtCommonStockLevel.Text);
                    int dangerLevel = int.Parse(txtDangerLevel.Text);
                    string spareID = comboBoxSpareID.SelectedItem.ToString();
                    bool autoRestock = checkBoxAutoReStock.Checked;

                    UpdateStockLevels(spareID, warehouseID, reOrderLevel, commonStockLevel, dangerLevel);
                    UpdateAutoRestock(spareID, warehouseID, autoRestock);
                    CheckAndInsertActualStock(spareID, warehouseID, autoRestock);

                    Main.ShowYesNoDialog("Setting Successful!");
                }
                else
                {
                    Main.ShowYesNoDialog("Please enter full data!");
                }
            }
        }
        private void CheckAndInsertActualStock(string spareID, int warehouseID, bool autoRestock)
        {
            string sql = $"SELECT COUNT(*) FROM ActualStock WHERE SpareID = '{spareID}' AND WarehouseID = {warehouseID}";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read() && reader.GetInt32(0) == 0)
                {
                    reader.Close(); // Ensure the reader is closed before executing the insert statement
                    sql = $"INSERT INTO ActualStock (SpareID, WarehouseID, Quantity, AutoRestork) VALUES ('{spareID}', {warehouseID}, 0, {autoRestock})";
                    Main.db.insertBySql(sql);
                }
            }
        }
        private bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(txtReOrderLevel.Text) &&
                   !string.IsNullOrWhiteSpace(txtCommonStockLevel.Text) &&
                   !string.IsNullOrWhiteSpace(txtDangerLevel.Text) &&
                   int.TryParse(txtReOrderLevel.Text, out _) &&
                   int.TryParse(txtCommonStockLevel.Text, out _) &&
                   int.TryParse(txtDangerLevel.Text, out _);
        }
        private void UpdateStockLevels(string spareID, int warehouseID, int reOrderLevel, int commonStockLevel, int dangerLevel)
        {
            int check = 0;
            string checkSql = $"SELECT COUNT(*) FROM WarehouseStockLevel WHERE SpareID = '{spareID}' AND WarehouseID = {warehouseID}";
            using (var reader = Main.db.readBySql(checkSql))
            {
                while (reader.Read())
                {
                    check = reader.GetInt32(0);
                }
            }

            if (check == 0)
            {
                    // Record does not exist, insert new record
                    string insertSql = $"INSERT INTO WarehouseStockLevel (SpareID, WarehouseID, ROL, CSL, DL) VALUES ('{spareID}', {warehouseID}, {reOrderLevel}, {commonStockLevel}, {dangerLevel})";
                    Main.db.insertBySql(insertSql);
            }
            else if (check > 0)
            {
                        // Record exists, update existing record
                        string updateSql = $"UPDATE WarehouseStockLevel SET ROL = {reOrderLevel}, CSL = {commonStockLevel}, DL = {dangerLevel} WHERE SpareID = '{spareID}' AND WarehouseID = {warehouseID}";
                        Main.db.updateBySql(updateSql); 
            }
        }

        private void UpdateAutoRestock(string spareID, int warehouseID, bool autoRestock)
        {
            int autoRestockValue = autoRestock ? 1 : 0;
            string sql = $"UPDATE ActualStock SET AutoRestork = {autoRestockValue} WHERE SpareID = '{spareID}' AND WarehouseID = {warehouseID}";
            Main.db.updateBySql(sql);
        }
        private void txtSpareName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReOrderLevel_TextChanged(object sender, EventArgs e)
        {

            ValidateNumericInput(txtReOrderLevel);
        }

        private void txtCommonStockLevel_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(txtCommonStockLevel);
        }

        private void txtDangerLevel_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(txtDangerLevel);
        }
        private void ValidateNumericInput(TextBox textBox)
        {
            if (!Regex.IsMatch(textBox.Text, @"^\d+$"))
            {
                textBox.Text = string.Empty;
            }
        }
        private void lblDangerLevel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxAutoReStock_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
