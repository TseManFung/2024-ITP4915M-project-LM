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

            string sql = $"select StaffID FROM User WHERE UserID = {Main.userID};";
            int StaffID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    StaffID = reader.GetInt32(0);
                }
            }
            sql = $"SELECT w.WarehouseID FROM Staff s JOIN Department d ON s.DeptID = d.DeptID JOIN Warehouse w ON d.WarehouseID = w.WarehouseID WHERE s.StaffID = {StaffID}";
            int WarehouseID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    WarehouseID = reader.GetInt32(0);
                }
            }
            List<string> SpareIDlist = new List<string>();
            sql = $"SELECT SpareID FROM WarehouseStockLevel WHERE WarehouseID = {WarehouseID};";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SpareIDlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSpareID.DataSource = SpareIDlist;
            this.comboBoxSpareID.DisplayMember = "SpareID";
        }

        private void comboBoxSpareID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SpareIDD = comboBoxSpareID.SelectedItem.ToString();
            string sql = $"SELECT SpareName FROM Spare WHERE SpareID = '{SpareIDD}';";
            string spareName = String.Empty;
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    spareName = reader.GetString(0);
                }
            }
            txtSpareName.Text = spareName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = $"select StaffID FROM User WHERE UserID = {Main.userID};";
            int StaffID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    StaffID = reader.GetInt32(0);
                }
            }
            sql = $"SELECT w.WarehouseID FROM Staff s JOIN Department d ON s.DeptID = d.DeptID JOIN Warehouse w ON d.WarehouseID = w.WarehouseID WHERE s.StaffID = {StaffID}";
            int WarehouseID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    WarehouseID = reader.GetInt32(0);
                }
            }
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {
                if (!string.IsNullOrWhiteSpace(txtReOrderLevel.Text) && !string.IsNullOrWhiteSpace(txtCommonStockLevel.Text))
                {
                    int ReOrderLevel;
                    int CommonStockLevel;
                    if (int.TryParse(txtReOrderLevel.Text, out ReOrderLevel) &&
                      int.TryParse(txtCommonStockLevel.Text, out CommonStockLevel))
                    {
                        string id = comboBoxSpareID.SelectedItem.ToString();
                        sql = $"UPDATE WarehouseStockLevel SET ROL = {ReOrderLevel},  CSL = {CommonStockLevel} WHERE SpareID = '{id}' AND WarehouseID = {WarehouseID}";
                        Main.db.updateBySql(sql);
                        Main.ShowYesNoDialog("Setting Successful!");
                    }
                }
                else
                {
                    Main.ShowYesNoDialog("Please enter full data!");
                }
            }

        }

        private void txtSpareName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReOrderLevel_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtReOrderLevel.Text, @"^\d+$"))
            {
                txtReOrderLevel.Text = "";
            }
        }

        private void txtCommonStockLevel_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtReOrderLevel.Text, @"^\d+$"))
            {
                txtReOrderLevel.Text = "";
            }
        }
    }
}
