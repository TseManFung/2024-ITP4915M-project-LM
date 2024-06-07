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
    public partial class frmEditSaleArea : Form
    {
        public frmEditSaleArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
        }

        private void frmEditSaleArea_Load(object sender, EventArgs e)
        {
            List<string> SaleAreaLocationlist = new List<string>();
            String sql = $"SELECT Location FROM SaleArea;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SaleAreaLocationlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSaleAreaLocation.DataSource = SaleAreaLocationlist;
            this.comboBoxSaleAreaLocation.DisplayMember = "SaleAreaID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {

                if (!string.IsNullOrEmpty(txtLocation.Text))
                {

                    string Location = txtLocation.Text;
                    string Remark = txtRemark.Text;
                    string selectLocation = comboBoxSaleAreaLocation.SelectedItem.ToString(); ;
                    String sqlofsupplier = $"SELECT AreaID FROM SaleArea WHERE Location = '{selectLocation}'";
                    int AreaID = 0;
                    using (var reader = Main.db.readBySql(sqlofsupplier))
                    {
                        while (reader.Read())
                        {
                            AreaID = reader.GetInt32(0);
                        }
                    }
                    string query;
                    if (!string.IsNullOrEmpty(Remark))
                    {
                        query = $"UPDATE SaleArea SET Location = '{Location}', Remark = '{Remark}' WHERE AreaID = '{AreaID}'";
                    }
                    else
                    {
                        query = $"UPDATE SaleArea SET Location = '{Location}' WHERE AreaID = '{AreaID}'";
                    }
                    Main.db.updateBySql(query);
                    MessageBox.Show("Successful editing");
                    txtLocation.Text = "";
                    txtRemark.Text = "";
                }
                else
                {
                    MessageBox.Show("Please provide Location!");
                }
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
