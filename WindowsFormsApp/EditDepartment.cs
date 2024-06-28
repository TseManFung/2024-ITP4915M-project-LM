using WindowsFormsApp.Properties;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

            // 获取选中的 DepartmentID
            string DepartmentID = comboBoxDepartment.SelectedItem.ToString();

            // 查询 Department 表中的 WarehouseID
            int? warehouseIDFromDept = null;  // 使用 nullable int 来处理可能的空值
            string sqlCheckWarehouseID = $"SELECT WarehouseID FROM Department WHERE DeptID = '{DepartmentID}';";
            using (var reader = Main.db.readBySql(sqlCheckWarehouseID))
            {
                if (reader.Read())
                {
                    warehouseIDFromDept = reader.IsDBNull(0) ? (int?)null : reader.GetInt32(0);  // 处理可能的 DB null 值
                }
            }

            // 如果 WarehouseID 不为空，则设置 tableLayoutPanel5 可见
            if (warehouseIDFromDept.HasValue)
            {
                tableLayoutPanel5.Visible = true;
            }
            List<string> WarehouseIDList = new List<string>();
            string sql = "SELECT Name FROM Warehouse Where State = 'N';";
            WarehouseIDList.Add("No Warehouse");
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    WarehouseIDList.Add(reader.GetString(0));
                }
            }
            this.comboBoxWarehouseID.DataSource = WarehouseIDList;

            // 如果 warehouseIDFromDept 有值，则查询对应的 Warehouse 名称并设置 comboBoxWarehouseID 的选中项
            if (warehouseIDFromDept.HasValue)
            {
                string warehouseName = null;
                string sqlGetWarehouseName = $"SELECT Name FROM Warehouse WHERE WarehouseID = {warehouseIDFromDept.Value};";
                using (var reader = Main.db.readBySql(sqlGetWarehouseName))
                {
                    if (reader.Read())
                    {
                        warehouseName = reader.GetString(0);
                    }
                }

                if (!string.IsNullOrEmpty(warehouseName))
                {
                    this.comboBoxWarehouseID.SelectedItem = warehouseName;
                }
            }
        }

        private void frmEditDepartment_Load(object sender, EventArgs e)
        {
            List<string> Departmentlist = new List<string>();
            String sql = $"SELECT DeptID FROM Department Where State = 'N';";
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
            if (Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_chang0))
            {

                if (!string.IsNullOrEmpty(txtDepartmentName.Text) && !string.IsNullOrEmpty(txtDepartmentEmail.Text))
                {
                    string DepartmentID = comboBoxDepartment.SelectedItem.ToString();
                    string DeptName = txtDepartmentName.Text;
                    string DeptEmail = txtDepartmentEmail.Text;
                    int WarehouseID = 0;
                    string selectedWarehouseName = comboBoxWarehouseID.SelectedItem.ToString();
                    string sql = $"SELECT WarehouseID FROM Warehouse WHERE Name = '{selectedWarehouseName}';";
                    using (var reader = Main.db.readBySql(sql))
                    {
                        while (reader.Read())
                        {
                            WarehouseID = reader.GetInt32(0);
                        }
                    }
                    string query;
                    if (selectedWarehouseName != "-1")
                    {
                        query = $"UPDATE Department SET DeptEmail = '{DeptEmail}', DeptName = '{DeptName}', WarehouseID = {WarehouseID} WHERE DeptID = '{DepartmentID}'";
                    }
                    else
                    {
                        query = $"UPDATE Department SET DeptEmail = '{DeptEmail}', DeptName = '{DeptName}',  WHERE DeptID = '{DepartmentID}'";
                    }

                    Main.db.updateBySql(query);
                    Main.ShowMessage(Resources.Successful_editing);
                    txtDepartmentName.Text = "";
                    txtDepartmentEmail.Text = "";
                }
                else
                {
                    Main.ShowMessage(Resources.Please_provide_Location);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_chang0))
            {
                String DepartmentID = comboBoxDepartment.SelectedItem.ToString();
                String query = $"UPDATE Department SET State = 'D' WHERE DeptID = '{DepartmentID}'";
                Main.db.updateBySql(query);
                Main.ShowMessage(Resources.Succeed0);
            }
        }
    }
}
