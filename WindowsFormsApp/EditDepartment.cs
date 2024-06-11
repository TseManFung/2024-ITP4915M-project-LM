using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmEditDepartment : Form
    {
        public frmEditDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel5.Visible = false;

            string DepartmentID = comboBoxDepartment.SelectedItem.ToString();

            if (DepartmentID.Length >= 2 && DepartmentID.Substring(0, 2) == "wh")
            {
                tableLayoutPanel5.Visible = true;
            }

            List<string> WarehouseIDList = new List<string>();
            string sql = "SELECT Location FROM Warehouse;";
            WarehouseIDList.Add("No Warehouse");
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    WarehouseIDList.Add(reader.GetString(0));
                }
            }
            this.comboBoxWarehouseID.DataSource = WarehouseIDList;

        }

        private void frmEditDepartment_Load(object sender, EventArgs e)
        {
            List<string> Departmentlist = new List<string>();
            String sql = $"SELECT DeptID FROM Department;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    Departmentlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxDepartment.DataSource = Departmentlist;
            this.comboBoxDepartment.DisplayMember = "DeptID";
            
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Department = comboBoxDepartment.SelectedItem.ToString();
            String DepartmentName = string.Empty;
            String sql = $"SELECT DeptName FROM Department Where DeptID = '{Department}';";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    DepartmentName=reader.GetString(0);
                }
            }
            txtDepartmentName.Text = DepartmentName;
            String DepartmentEmail = string.Empty;
            sql = $"SELECT DeptEmail FROM Department Where DeptID = '{Department}';";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    DepartmentEmail = reader.GetString(0);
                }
            }
            txtDepartmentEmail.Text = DepartmentEmail;

        }

        private void comboBoxSpareType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {

                if (!string.IsNullOrEmpty(txtDepartmentName.Text) && !string.IsNullOrEmpty(txtDepartmentEmail.Text))
                {
                    string DepartmentID = comboBoxDepartment.SelectedItem.ToString();
                    string DeptName = txtDepartmentName.Text;
                    string DeptEmail = txtDepartmentEmail.Text;
                    string WarehouseID = comboBoxWarehouseID.SelectedItem.ToString();

                    string query;
                    if (WarehouseID != "-1")
                    {
                        query = $"UPDATE Department SET DeptEmail = '{DeptEmail}', DeptName = '{DeptName}', WarehouseID = '{WarehouseID}' WHERE DeptID = '{DepartmentID}'";
                    }
                    else
                    {
                        query = $"UPDATE Department SET DeptEmail = '{DeptEmail}', DeptName = '{DeptName}',  WHERE DeptID = '{DepartmentID}'";
                    }

                    Main.db.updateBySql(query);
                    Main.ShowMessage("Successful editing");
                    txtDepartmentName.Text = "";
                    txtDepartmentEmail.Text = "";
                }
                else
                {
                    Main.ShowMessage("Please provide Location!");
                }
            }
        }

        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartmentEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditDepartment_Resize(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.ResizeControlsFont(this);
        }
    }
}
