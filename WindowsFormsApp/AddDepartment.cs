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
            if (Main.ShowYesNoDialog("Do you want to turn to the next page?"))
            {

                if (!string.IsNullOrEmpty(txtDepartmentName.Text) && !string.IsNullOrEmpty(txtDepartmentEmail.Text) && !string.IsNullOrEmpty(txtDepartmentID.Text))
                {
                    string DepartmentID = txtDepartmentID.Text;
                    string DeptName = txtDepartmentName.Text;
                    string DeptEmail = txtDepartmentEmail.Text;
                    string WarehouseLocation = comboBoxWarehouse.SelectedItem.ToString();
                    int WarehouseID = 0;

                    string sql1 = "SELECT DeptID FROM Department;";
                    List<string> deptIDs = new List<string>();

                    using (var reader = Main.db.readBySql(sql1))
                    {
                        while (reader.Read())
                        {
                            string deptID = reader.GetString(0);
                            deptIDs.Add(deptID);
                        }
                    }

                    if (deptIDs.Contains(DepartmentID))
                    {
                        Main.ShowMessage("Department ID already exists. Please choose a different ID.");
                        txtDepartmentName.Text = String.Empty;
                        txtDepartmentEmail.Text = String.Empty;
                        txtDepartmentID.Text = String.Empty;
                        return;
                    }

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
                        query = $"INSERT INTO Department (DeptID,DeptEmail, DeptName, WarehouseID) VALUES ('{DepartmentID}','{DeptEmail}', '{DeptName}', {WarehouseID})";
                    }
                    else
                    {
                        query = $"INSERT INTO Department (DeptID,DeptEmail, DeptName) VALUES ('{DepartmentID}','{DeptEmail}', '{DeptName}')";
                    }

                    Main.db.insertBySql(query);
                    Main.ShowMessage("Successful adding!");
                    txtDepartmentName.Text = String.Empty;
                    txtDepartmentEmail.Text = String.Empty;
                    txtDepartmentID.Text = String.Empty;
                }
                else
                {
                    Main.ShowMessage("Please fill in all the required information!");
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

        private void txtDepartmentID_TextChanged(object sender, EventArgs e)
        {
            string departmentID = txtDepartmentID.Text;

            if (departmentID.Length > 5)
            {
                Main.ShowMessage("Department ID cannot exceed 5 characters. Please re-enter.");
                txtDepartmentID.Text = string.Empty;
                txtDepartmentID.SelectionStart = txtDepartmentID.Text.Length;
            }
        }

        private void txtDepartmentEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
