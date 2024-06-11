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
            Main.ShowMessage("succeed!");
        }
    }
}
