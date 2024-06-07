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
    public partial class frmAddDepartment : Form
    {
        public frmAddDepartment()
        {
            InitializeComponent();
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel5.Visible = radYes.Checked;

        }

        private void frmAddDepartment_Resize(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.ResizeControlsFont(this);
        }

        private void frmAddDepartment_Load(object sender, EventArgs e)
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
                if (!string.IsNullOrEmpty(txtDepartmentName.Text) && !string.IsNullOrEmpty(txtDepartmentEmail.Text))
                {
                    string DepartmentID = comboBoxWarehouse.SelectedItem.ToString();
                    string DeptName = txtDepartmentName.Text;
                    string DeptEmail = txtDepartmentEmail.Text;
                    string WarehouseLocation = comboBoxWarehouse.SelectedItem.ToString();
                    int WarehouseID = 0;

                    string query;
                    if (radYes.Checked)
                    {
                        string sql = $"SELECT WarehouseID FROM Warehouse WHERE Location = '{WarehouseLocation}';";
                        using (var reader = Main.db.readBySql(sql))
                        {
                            if (reader.Read())
                            {
                                WarehouseID = reader.GetInt32(0);
                            }
                        }
                        query = $"INSERT INTO Department (DeptEmail, DeptName, WarehouseID) VALUES ('{DeptEmail}', '{DeptName}', '{WarehouseID}')";
                    }
                    else
                    {
                        query = $"INSERT INTO Department (DeptEmail, DeptName) VALUES ('{DeptEmail}', '{DeptName}')";
                    }

                    Main.db.insertBySql(query);
                    MessageBox.Show("Successful editing");
                    txtDepartmentName.Text = "";
                    txtDepartmentEmail.Text = "";
                }
                else
                {
                    MessageBox.Show("Please provide both Department Name and Department Email!");
                }
            }
        }

        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = String.Empty;
            txtDepartmentEmail.Text = String.Empty;
        }
    }
}
