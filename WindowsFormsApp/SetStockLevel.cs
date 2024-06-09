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
            int ROL = 0;
            int CSL = 0;
            int DL = 0;


            string SpareIDD = comboBoxSpareID.SelectedItem.ToString();
            sql = $"SELECT SpareName FROM Spare WHERE SpareID = '{SpareIDD}';";
            string spareName = String.Empty;
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    spareName = reader.GetString(0);
                }
            }
            txtSpareName.Text = spareName;
            sql = $"SELECT ROL FROM WarehouseStockLevel WHERE SpareID = '{SpareIDD}' AND WarehouseID = {WarehouseID}";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        ROL = reader.GetInt32(0);
                    }
                }
            }
            txtReOrderLevel.Text = ROL.ToString();
            sql = $"SELECT DL FROM WarehouseStockLevel WHERE SpareID = '{SpareIDD}' AND WarehouseID = {WarehouseID}";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        DL = reader.GetInt32(0);
                    }
                }
            }
            txtDangerLevel.Text = DL.ToString();
            sql = $"SELECT CSL FROM WarehouseStockLevel WHERE SpareID = '{SpareIDD}' AND WarehouseID = {WarehouseID}";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        CSL = reader.GetInt32(0);
                    }
                }
            }
            txtCommonStockLevel.Text = CSL.ToString();

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
                    int DangerLevel;
                    if (int.TryParse(txtReOrderLevel.Text, out ReOrderLevel) &&
                      int.TryParse(txtCommonStockLevel.Text, out CommonStockLevel) &&
                      int.TryParse(txtDangerLevel.Text, out DangerLevel))
                    {
                        string id = comboBoxSpareID.SelectedItem.ToString();
                        if (checkBoxAutoReStock.Checked)
                        {
                            sql = $"UPDATE ActualStock SET AutoRestork = 1 WHERE SpareID = '{id}' AND WarehouseID = {WarehouseID}";

                        }
                        else
                        {
                            sql = $"UPDATE ActualStock SET AutoRestork = 0 WHERE SpareID = '{id}' AND WarehouseID = {WarehouseID}";
                        }
                        Main.db.updateBySql(sql);
                        sql = $"UPDATE WarehouseStockLevel SET ROL = {ReOrderLevel},  CSL = {CommonStockLevel},  DL = {DangerLevel} WHERE SpareID = '{id}' AND WarehouseID = {WarehouseID}";
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

        private void txtDangerLevel_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtReOrderLevel.Text, @"^\d+$"))
            {
                txtReOrderLevel.Text = "";
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
