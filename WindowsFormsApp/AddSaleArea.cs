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
using static WindowsFormsApp.Google_map;

namespace WindowsFormsApp
{
    public partial class frmAddSaleArea : Form
    {
        public frmAddSaleArea()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmAddSaleArea_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Location = txtLocation.Text;
            Google_map map = new Google_map(Location);
            map.ShowDialog();
            if (map.Getstate())
            {
                double Latitude = (double)GlobalVariables.Latitude;
                double Longitude = (double)GlobalVariables.Latitude;
                {
                    if (!string.IsNullOrEmpty(txtLocation.Text))
                    {
                        string Remark = txtRemark.Text;
                        string query;

                        if (!string.IsNullOrEmpty(Remark))
                        {
                            query = $"INSERT INTO SaleArea (Location,Latitude,Longitude,Remark) VALUES ('{Location}',{Latitude},{Latitude}, '{Remark}')";
                        }
                        else
                        {
                            query = $"INSERT INTO SaleArea (Location,Latitude,Longitude) VALUES ('{Location}',{Latitude},{Latitude})";
                        }
                        Main.db.insertBySql(query);
                        Main.ShowMessage(Resources.Successful_add);
                        txtLocation.Text = String.Empty;
                        txtRemark.Text = String.Empty;
                    }
                    else
                    {
                        Main.ShowMessage(Resources.Please_provide_Location);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLocation.Text = String.Empty;
            txtRemark.Text = String.Empty;
        }

        private void lblSpareLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
