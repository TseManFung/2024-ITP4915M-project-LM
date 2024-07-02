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
            this.comboBoxSaleArea.DisplayMember = Resources.Location;
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
            txtName.Text = string.Empty; 
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Do you want to add a new Warehouse?"))
            {
                if (!string.IsNullOrEmpty(txtLocation.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    string location = txtLocation.Text;
                    string name = txtName.Text;
                    string saleArea = comboBoxSaleArea.SelectedItem.ToString();
                    int saleAreaID = 0;

                    // 获取SaleAreaID
                    string sql3 = $"SELECT AreaID FROM SaleArea WHERE Location = '{saleArea}'";
                    using (var reader = Main.db.readBySql(sql3))
                    {
                        while (reader.Read())
                        {
                            saleAreaID = reader.GetInt32(0);
                        }
                    }

                    // 检查名字和地点是否重复
                    string checkSql = $"SELECT COUNT(*) FROM Warehouse WHERE Name = '{name}' OR Location = '{location}'";
                    int existingRecords = 0;
                    using (var reader = Main.db.readBySql(checkSql))
                    {
                        if (reader.Read())
                        {
                            existingRecords = reader.GetInt32(0);
                        }
                    }

                    if (existingRecords > 0)
                    {
                        Main.ShowMessage("Name or Location already exists");
                    }
                    else
                    {
                        // 插入新仓库记录
                        string insertSql = $"INSERT INTO Warehouse (Name, SaleAreaID, Location, State) VALUES ('{name}', {saleAreaID}, '{location}', 'N')";
                        Main.db.insertBySql(insertSql);
                        Main.ShowMessage(Resources.Successful_add);

                        // 清空输入框
                        txtLocation.Text = string.Empty;
                        txtName.Text = string.Empty;
                    }
                }
                else
                {
                    Main.ShowMessage(Resources.Please_provide_Location);
                }
            }
        }

            private void comboBoxSaleArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
