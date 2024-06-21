using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmEditWarehouse : Form
    {
        public frmEditWarehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLocation.Text = comboBoxWarehouse.SelectedItem.ToString();
        }

        private void frmEditWarehouse_Load(object sender, EventArgs e)
        {
            List<string> WarehouseNamelist = new List<string>();
            String sql = $"SELECT Location FROM Warehouse;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    WarehouseNamelist.Add(reader.GetString(0));
                }
            }
            this.comboBoxWarehouse.DataSource = WarehouseNamelist;
            this.comboBoxWarehouse.DisplayMember = "SupplierName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {

                if (!string.IsNullOrEmpty(txtLocation.Text))
                {

                    string Location = txtLocation.Text;
                    string selectWarehouse = comboBoxWarehouse.SelectedItem.ToString(); ;
                    String sqlofWarehouse = $"SELECT WarehouseID FROM Warehouse WHERE Location = '{selectWarehouse}'";
                    int WarehouseID = 0;
                    using (var reader = Main.db.readBySql(sqlofWarehouse))
                    {
                        while (reader.Read())
                        {
                            WarehouseID = reader.GetInt32(0);
                        }
                    }

                    String  query = $"UPDATE Warehouse SET Location = '{Location}' WHERE WarehouseID = '{WarehouseID}'";
                    
                    Main.db.updateBySql(query);
                    Main.ShowMessage("Successful editing");
                    txtLocation.Text = String.Empty;
                }
                else
                {
                    Main.ShowMessage("Please provide Location!");
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TargetWarehouse input = new TargetWarehouse();
            String DeleteWarehouse = comboBoxWarehouse.SelectedItem.ToString();
            // 获取要删除仓库的 WarehouseID
            String sql = $"SELECT WarehouseID FROM Warehouse WHERE Location = '{DeleteWarehouse}'";
            int WarehouseID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    WarehouseID = reader.GetInt32(0);
                }
            }
            // 显示目标仓库输入对话框
            DialogResult dr = input.ShowDialog();
            String targetwarehouse = String.Empty;
            if (dr == DialogResult.OK)
            {
                targetwarehouse = input.GetMsg();
            }
            // 获取目标仓库的 WarehouseID
            int targetwarehouseID = 0;
            sql = $"SELECT WarehouseID FROM Warehouse WHERE Location = '{targetwarehouse}'";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    targetwarehouseID = reader.GetInt32(0);
                }
            }
            // 检查目标仓库是否与要删除的仓库相同
            if (targetwarehouse == DeleteWarehouse)
            {
                Main.ShowMessage("Cannot select the location to be deleted!");
            }else
            {
                // 确认删除操作
                if (Main.ShowYesNoDialog("Are you sure you want to delete it?"))
                {
                    // 获取当前用户的 StaffID
                    sql = $"select StaffID FROM User WHERE UserID = {Main.userID};";
                    int StaffID = 0;
                    using (var reader = Main.db.readBySql(sql))
                    {
                        if (reader.Read())
                        {
                            StaffID = reader.GetInt32(0);
                        }
                    }
                    // 获取要删除仓库的库存信息
                    sql = $"SELECT SpareID FROM ActualStock WHERE WarehouseID = '{WarehouseID}'";
                    List<string> SpareIDlist = new List<string>();
                    using (var reader = Main.db.readBySql(sql))
                    {
                        while (reader.Read())
                        {
                            string spareID = reader.GetString(0);
                            SpareIDlist.Add(spareID);
                        }
                    }
                    sql = $"SELECT quantity FROM ActualStock WHERE WarehouseID = '{WarehouseID}'";
                    List<int> quantitylist =  new List<int>();
                    using (var reader = Main.db.readBySql(sql))
                    {
                        while (reader.Read())
                        {
                            quantitylist.Add(reader.GetInt32(0));
                        }
                    }
                    DateTime now = DateTime.UtcNow.AddHours(8);
                    string date = now.ToString("yyyy-MM-dd");
                    sql = $"INSERT INTO RestockOrder (WarehouseID, OrderDate) VALUES ({targetwarehouseID}, '{date}')";
                    Main.db.insertBySql(sql);
                    sql = $"SELECT RestockOrderID FROM RestockOrder WHERE WarehouseID = '{targetwarehouseID}' AND OrderDate = '{date}'";
                    int RestockOrderID = 0;
                    using (var reader = Main.db.readBySql(sql))
                    {
                        while (reader.Read())
                        {
                            RestockOrderID = reader.GetInt32(0);
                        }
                    }
                    if (SpareIDlist.Count == quantitylist.Count)
                    {
                        for (int i = 0; i < SpareIDlist.Count; i++)
                        {
                            string id = SpareIDlist[i];
                            int quantity = quantitylist[i];
                            String Discrepancy = "Delete warehouse" + DeleteWarehouse;
                            sql = $"INSERT INTO ScrapItems (ItemID, RecordTime, RecordStaffID, Quantity, Discrepancy) VALUES ('{id}', '{DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss")}', {StaffID}, {quantity}, '{Discrepancy}')";
                            Main.db.insertBySql(sql);

                            sql = $"UPDATE Stock SET quantity = quantity - {quantity} WHERE SpareID = '{id}'";
                            Main.db.updateBySql(sql);

                            sql = $"UPDATE ActualStock SET quantity = quantity - {quantity} WHERE SpareID = '{id}' AND WarehouseID = {WarehouseID}";
                            Main.db.updateBySql(sql);

                            sql = $"INSERT INTO RestockItem (RestockOrderID, ItemID, Quantity, State) VALUES ({RestockOrderID}, '{id}', {quantity}, 'C')";
                            Main.db.insertBySql(sql);
                        }
                        sql = $"UPDATE Department SET WarehouseID = NULL ,State = 'D' WHERE WarehouseID = {WarehouseID}";
                        Main.db.updateBySql(sql);
                        Main.ShowMessage("Succeed!");
                    }
                    else
                    {
                        Main.ShowMessage("All fuck up");
                    }

                }
            }
        }
    }
}
