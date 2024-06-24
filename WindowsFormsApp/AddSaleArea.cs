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
            if (Main.ShowYesNoDialog("Do you want to save?"))
            {
                if (!string.IsNullOrEmpty(txtLocation.Text))
                {

                    string Location = txtLocation.Text;
                    string Remark = txtRemark.Text;
                    string query;

                    if (!string.IsNullOrEmpty(Remark))
                    {
                        query = $"INSERT INTO SaleArea (Location, Remark) VALUES ('{Location}', '{Remark}')";
                    }
                    else
                    {
                        query = $"INSERT INTO SaleArea (Location) VALUES ('{Location}')";
                    }
                    Main.db.insertBySql(query);
                    Main.ShowMessage("Successful add!");
                    txtLocation.Text = String.Empty;
                    txtRemark.Text = String.Empty;
                }
                else
                {
                    Main.ShowMessage("Please provide Location!");
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
