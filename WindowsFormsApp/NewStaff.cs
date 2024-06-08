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
    public partial class frmNewStaff : Form
    {
        public frmNewStaff()
        {
            InitializeComponent();
        }

        private void frmNewStaff_Load(object sender, EventArgs e)
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
            this.comboBoxSaleArea.DataSource = SaleAreaLocationlist;
            this.comboBoxSaleArea.DisplayMember = "SaleAreaID";

            List<int> StaffIDlist = new List<int>();
            String sql2 = $"SELECT StaffID FROM Staff;";
            using (var reader = Main.db.readBySql(sql2))
            {
                while (reader.Read())
                {
                    StaffIDlist.Add(reader.GetInt32(0));
                }
            }
            this.comboBoxStaffID.DataSource = StaffIDlist;
            this.comboBoxStaffID.DisplayMember = "StaffID";

            List<string> Departmentlist = new List<string>();
            String sql3 = $"SELECT DeptName FROM Department;";
            using (var reader = Main.db.readBySql(sql3))
            {
                while (reader.Read())
                {
                    Departmentlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxDepartment.DataSource = Departmentlist;
            this.comboBoxDepartment.DisplayMember = "Department";
            List<string> Positionlist = new List<string>();
            String sql4 = $"SELECT DeptName FROM Department;";
            using (var reader = Main.db.readBySql(sql4))
            {
                while (reader.Read())
                {
                    Positionlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxPosition.DataSource = Positionlist;
            this.comboBoxPosition.DisplayMember = "Position";

        }



        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowTable();
        }

        private void ShowTable()
        {
            tableLayoutPanel1.Visible = radYes.Checked;
            tableLayoutPanel12.Visible = radNo.Checked;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {
                Random random = new Random();
                int randompasswd = random.Next(0, 1001);
                string passwd = '0' + Main.db.ComputeSha256Hash(randompasswd.ToString());
                string loginName = frmUserManagementAndAccountManagement.GlobalLoginNameForCreate;
                int accessLevel = frmUserManagementAndAccountManagement.GlobalAccessLevelForCreate;
                int? StaffID = null;
                string query;
                if (radYes.Checked)
                {

                        if (!string.IsNullOrEmpty(txtStaffName.Text)){
                        string txtSpareNameT = txtStaffName.Text;
                        string PositionT = comboBoxPosition.SelectedItem.ToString();
                        string SaleAreaT = comboBoxSaleArea.SelectedItem.ToString();
                        string DepartmentT = comboBoxDepartment.SelectedItem.ToString();

                        int? SaleAreaID = null;

                        string sql1 = $"SELECT AreaID FROM SaleArea WHERE Location = '{SaleAreaT}'";
                        using (var reader = Main.db.readBySql(sql1))
                        {
                            while (reader.Read())
                            {
                                SaleAreaID = reader.GetInt32(0);
                            }
                        }
                        if (comboBoxSaleArea.SelectedItem == null || comboBoxSaleArea.SelectedItem.ToString() == "-1")
                        {
                            query = $"SELECT AreaID FROM SaleArea WHERE Location = '{SaleAreaT}'";
                            Main.db.insertBySql(query);
                            using (var reader = Main.db.readBySql(query))
                            {
                                while (reader.Read())
                                {
                                    StaffID = reader.GetInt32(0);
                                }
                            }
                        }
                        else
                        {
                            query = $"SELECT AreaID FROM SaleArea WHERE Location = '{SaleAreaT}'";
                            Main.db.insertBySql(query);
                            using (var reader = Main.db.readBySql(query))
                            {
                                while (reader.Read())
                                {
                                    StaffID = reader.GetInt32(0);
                                }
                            }
                        }
                    }
                }
                else if (radNo.Checked)
                {
                    StaffID = Convert.ToInt32(comboBoxStaffID.SelectedItem);
                }
                query = $"INSERT INTO `User` (LoginName, Password, AccessLevel,DealerID) VALUES ('{loginName}', '{passwd}', {accessLevel}, {StaffID})";
                Main.db.insertBySql(query);
                Main.ShowMessage($"Successful editing, your password is {randompasswd},  please change your password as soon as possible!");
                txtStaffName.Text = String.Empty;

            }
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSaleArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSpareName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

