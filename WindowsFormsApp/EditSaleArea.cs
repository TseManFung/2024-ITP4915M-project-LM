using WindowsFormsApp.Properties;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp.Google_map;

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
            btnDelete.Visible = false;
            List<string> SaleAreaLocationlist = new List<string>(); //1
            String sql = $"SELECT Location FROM SaleArea;"; //1
            using (var reader = Main.db.readBySql(sql)) //1
            {
                while (reader.Read()) // n
                {
                    SaleAreaLocationlist.Add(reader.GetString(0)); //n
                }
            }
            this.comboBoxSaleAreaLocation.DataSource = SaleAreaLocationlist; // 1
            this.comboBoxSaleAreaLocation.DisplayMember = "SaleAreaID"; // n
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtLocation.Text = comboBoxSaleAreaLocation.SelectedItem.ToString();
            string Remark = null;
            string sql = $"SELECT remark FROM SaleArea Where Location = '{comboBoxSaleAreaLocation.SelectedItem.ToString()}';";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    Remark = reader.IsDBNull(0) ? "No remark" : reader.GetString(0);
                }
            }
            txtRemark.Text = Remark ?? string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectLocation = comboBoxSaleAreaLocation.SelectedItem.ToString();
            string Location = txtLocation.Text;
            String sqlofsupplier = $"SELECT AreaID FROM SaleArea WHERE Location = '{selectLocation}'";
            int AreaID = 0;
            using (var reader = Main.db.readBySql(sqlofsupplier))
            {
                while (reader.Read())
                {
                    AreaID = reader.GetInt32(0);
                }
            }
            Google_map map = new Google_map(AreaID, "SaleArea", Location);
            map.ShowDialog();
            if (map.Getstate())
            {

                if (!string.IsNullOrEmpty(txtLocation.Text))
                    {
                        double Latitude = (double)GlobalVariables.Latitude;
                        double Longitude = (double)GlobalVariables.Latitude;
                        Location = txtLocation.Text;
                        string Remark = txtRemark.Text;
                        string query;
                        if (!string.IsNullOrEmpty(Remark))
                        {
                            query = $"UPDATE SaleArea SET Location = '{Location}', Latitude = {Latitude},  Longitude = {Longitude} ,Remark = '{Remark}' WHERE AreaID = '{AreaID}'";
                        }
                        else
                        {
                            query = $"UPDATE SaleArea SET Location = '{Location}' , Latitude = {Latitude},  Longitude = {Longitude} WHERE AreaID = '{AreaID}'";
                        }
                        Main.db.updateBySql(query);
                        Main.ShowMessage(Resources.Successful_editing);
                        txtLocation.Text = "";
                        txtRemark.Text = "";
                    }
                    else
                    {
                        Main.ShowMessage(Resources.Please_provide_Location);
                    }
                }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Main.ShowMessage(Resources.succeed);

        }
    }
}
