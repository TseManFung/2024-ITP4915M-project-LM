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
    public partial class frmAddWarehouse : Form
    {
        public frmAddWarehouse()
        {
            InitializeComponent();
        }

        private void frmAddWarehouse_Load(object sender, EventArgs e)
        {
            List<string> Locationlist = new List<string>();
            String sql = $"SELECT Location FROM SaleArea;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    Locationlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSaleArea.DataSource = Locationlist;
            this.comboBoxSaleArea.DisplayMember = "Location";
            List<string> StaffNamelist = new List<string>();
            string sql2 = "SELECT StaffName FROM Staff WHERE position = 'manager'";
            using (var reader = Main.db.readBySql(sql2))
            {
                while (reader.Read())
                {
                    StaffNamelist.Add(reader.GetString(0));
                }
            }

            if (StaffNamelist.Count > 0)
            {
                using (var reader = Main.db.readBySql(sql2))
                {
                    while (reader.Read())
                    {
                        StaffNamelist.Add(reader.GetString(0));
                    }
                }
            }
            else
            {
                Main.ShowMessage("No manager");
            }
            this.comboBoxManager.DataSource = StaffNamelist;
            this.comboBoxManager.DisplayMember = "StaffName";

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLocation.Text = string.Empty;
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLocation.Text))
            {

                string Location = txtLocation.Text;
                string Manager = comboBoxManager.SelectedItem.ToString();
                string SaleArea = comboBoxSaleArea.SelectedItem.ToString();
                int SaleAreaID = new int();
                string sql3 = $"SELECT AreaID FROM SaleArea WHERE Location = '{SaleArea}'";
                using (var reader = Main.db.readBySql(sql3))
                {
                    while (reader.Read())
                    {
                        SaleAreaID = reader.GetInt32(0);
                    }
                }
                String query = $"INSERT INTO Warehouse (SaleAreaID, Location) VALUES ('{SaleAreaID}', '{Location}')";
                Main.db.insertBySql(query);

                int WarehouseID = new int();
                string sql = $"SELECT WarehouseID FROM Warehouse WHERE Location = '{Location}'";
                using (var reader = Main.db.readBySql(sql))
                {
                    while (reader.Read())
                    {
                        WarehouseID = reader.GetInt32(0);
                    }
                }

                string WarehouseName = "wh" + WarehouseID;
                string query2 = $"UPDATE Staff SET DeptID = '{WarehouseName}' WHERE StaffName = '{Manager}'";
                Main.db.updateBySql(query2);
                Main.ShowMessage("Successful add!");
                txtLocation.Text = string.Empty;
            }
            else
            {
                Main.ShowMessage("Please provide Location!");
            }
        }

        private void comboBoxSaleArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
