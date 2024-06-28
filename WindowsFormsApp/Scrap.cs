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
        public frmScrap()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
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
            if (Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_chang0))
            {
                if (!string.IsNullOrWhiteSpace(txtQuantity.Text) && !string.IsNullOrWhiteSpace(txtDiscrepancy.Text))
                {
                    int Quantity = 0;
                    if (int.TryParse(txtQuantity.Text, out Quantity))
                    {


                        string id = comboBoxSpareID.SelectedItem.ToString();
                        string Discrepancy = txtDiscrepancy.Text;
                        sql = $"INSERT INTO ScrapItems (ItemID, RecordTime, RecordStaffID, Quantity, Discrepancy) VALUES ('{id}', '{DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss")}', {StaffID}, {Quantity}, '{Discrepancy}')";
                        Main.db.insertBySql(sql);
                        sql = $"update Stock SET quantity = quantity - {Quantity} where SpareID = '{id}'";
                        Main.db.updateBySql(sql);
                        sql = $"update ActualStock SET quantity = quantity - {Quantity} where SpareID = '{id}' AND WarehouseID = {WarehouseID}"; 
                        Main.db.updateBySql(sql);
                        Main.ShowYesNoDialog(Resources.ScrapItem_Successful);
                    }
                }
                else
                {
                    Main.ShowYesNoDialog(Resources.Please_enter_full_data);
                }
            }
        }

        private void frmScrap_Load(object sender, EventArgs e)
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

        private void txtDiscrepancy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
