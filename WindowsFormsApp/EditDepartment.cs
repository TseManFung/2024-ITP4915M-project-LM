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
    public partial class frmEditDepartment : Form
    {
        public frmEditDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;

            string DepartmentID = comboBoxDepartment.SelectedItem.ToString();

            if (DepartmentID.Length >= 2 && DepartmentID.Substring(0, 2) == "wh")
            {
                tableLayoutPanel5.Visible = true;
            }

            List<int> WarehouseIDList = new List<int>();
            string sql = "SELECT WarehouseID FROM Warehouse;";
            WarehouseIDList.Add(-1);
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    WarehouseIDList.Add(reader.GetInt32(0));
                }
            }
            this.comboBoxWarehouseID.DataSource = WarehouseIDList;
            this.comboBoxWarehouseID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxWarehouseID.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            this.comboBoxDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSpareType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
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
                MessageBox.Show("Successful editing");
                txtDepartmentName.Text = "";
                txtDepartmentEmail.Text = "";
            }
            else
            {
                MessageBox.Show("Please provide Location!");
            }
        }

        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartmentEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
