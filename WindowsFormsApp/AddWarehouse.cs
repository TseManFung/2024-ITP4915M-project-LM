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
            if (Main.ShowYesNoDialog("Do you want to turn to the next page?"))
            {


                if (!string.IsNullOrEmpty(txtLocation.Text) && !string.IsNullOrEmpty(txtName.Text))
                {

                    string Location = txtLocation.Text;
                    string Name = txtName.Text;
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
                    String query = $"INSERT INTO Warehouse (Name,SaleAreaID, Location,State) VALUES ('{Name}','{SaleAreaID}', '{Location}','N')";
                    Main.db.insertBySql(query);
                    Main.ShowMessage("Successful add!");
                    txtLocation.Text = string.Empty;
                    txtName.Text = string.Empty;
                }
                else
                {
                    Main.ShowMessage("Please provide Location!");
                }
            }
        }

        private void comboBoxSaleArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
