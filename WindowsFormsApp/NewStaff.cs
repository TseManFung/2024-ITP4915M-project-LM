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
using ZXing;
using System.Security.Cryptography;

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
            SaleAreaLocationlist.Add("NO SaleArea");
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

            // 使用 LEFT JOIN 查询未在 User 表中使用的 StaffID
            List<int> availableStaffIDs = new List<int>();
            sql = @" SELECT s.StaffID FROM Staff s LEFT JOIN User u ON s.StaffID = u.StaffID WHERE u.StaffID IS NULL;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    availableStaffIDs.Add(reader.GetInt32(0));
                }
            }

            // 将 availableStaffIDs 绑定到 comboBoxStaffID
            this.comboBoxStaffID.DataSource = availableStaffIDs;

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
            string sql4 = "SELECT DISTINCT Position FROM Staff;";
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
        private string CreatePassword(int length)
        {
            const string valid = "abcdefghkmnpqrstuvwxyzABCDEFGHKLMNPQRSTUVWXYZ23456789@#$%&*";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog(Resources.dywtcana))
            {

                Random random = new Random();
                string randompasswd = CreatePassword(8);
                string passwd = '0' + Main.db.ComputeSha256Hash(randompasswd.ToString());
                string loginName = frmUserManagementAndAccountManagement.GlobalLoginNameForCreate;
                int accessLevel = frmUserManagementAndAccountManagement.GlobalAccessLevelForCreate;
                int? StaffID = null;
                string query;
                if (radYes.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtStaffName.Text))
                    {
                        Main.ShowMessage(Resources.sncbe);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtPhoneNum.Text))
                    {
                        Main.ShowMessage(Resources.pncbe);
                        return;
                    }
                    if (!string.IsNullOrEmpty(txtStaffName.Text)){
                        string SpareNameT = txtStaffName.Text;
                        string PositionT = comboBoxPosition.SelectedItem.ToString();
                        string DepartmentT = comboBoxDepartment.SelectedItem.ToString();
                        string PhoneNumberT = txtPhoneNum.Text;
                        query = $"SELECT COUNT(*) FROM Staff WHERE PhoneNunber = '{PhoneNumberT}'";
                        int count = 0;
                        using (var reader = Main.db.readBySql(query))
                        {
                            if (reader.Read())
                            {
                                count = reader.GetInt32(0);
                            }
                        }

                        if (count > 0)
                        {
                            Main.ShowMessage(Resources.Duplicate_phone_numbers);
                            txtPhoneNum.Text = String.Empty;
                            return;
                        }
                        char Gender = '0';
                        string sqlD = $"SELECT DeptID FROM Department WHERE DeptName = '{DepartmentT}'";
                        using (var reader = Main.db.readBySql(sqlD))
                        {
                            while (reader.Read())
                            {
                                DepartmentT = reader.GetString(0);
                            }
                        }
                        if (rbMale.Checked)
                        {
                            Gender = 'M';
                        }else if (rbFemale.Checked)
                        {
                            Gender = 'F';
                        }
                        else
                        {
                            Main.ShowMessage(Resources.Please_select_a_gemder);
                            return;
                        }
                        int? SaleAreaID = null;
                        if (comboBoxSaleArea.SelectedItem == null || comboBoxSaleArea.SelectedItem.ToString() == "NO SaleArea")
                        {
                            query = $"INSERT INTO Staff (StaffName, DeptID, Position,PhoneNunber,Gender) VALUES ('{SpareNameT}', '{DepartmentT}', '{PositionT}', '{PhoneNumberT}','{Gender}')";
                            Main.db.insertBySql(query);
                            query = $"SELECT StaffID FROM Staff WHERE StaffName = '{SpareNameT}' AND DeptID = '{DepartmentT}' AND Position = '{PositionT}' AND PhoneNunber = '{PhoneNumberT}' AND Gender = '{Gender}'";
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
                            string SaleAreaT = comboBoxSaleArea.SelectedItem.ToString();
                            string sql1 = $"SELECT AreaID FROM SaleArea WHERE Location = '{SaleAreaT}'";
                            using (var reader = Main.db.readBySql(sql1))
                            {
                                while (reader.Read())
                                {
                                    SaleAreaID = reader.GetInt32(0);
                                }
                            }
                            query = $"INSERT INTO Staff (StaffName, DeptID,SaleAreaID, Position,PhoneNunber,Gender) VALUES ('{SpareNameT}', '{DepartmentT}',{SaleAreaID} ,'{PositionT}', '{PhoneNumberT}','{Gender}')";
                            Main.db.insertBySql(query);
                            query = $"SELECT StaffID FROM Staff WHERE StaffName = '{SpareNameT}' AND SaleAreaID = {SaleAreaID} AND DeptID = '{DepartmentT}'AND Position = '{PositionT}' AND PhoneNunber = '{PhoneNumberT}' AND Gender = '{Gender}'";

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

                query = $"INSERT INTO `User` (LoginName, Password, AccessLevel,StaffID) VALUES ('{loginName}', '{passwd}', {accessLevel}, {StaffID})";
                Main.db.insertBySql(query);
                Main.ShowMessage($"Successful editing, your password is {randompasswd},  please change your password as soon as possible!");
                txtStaffName.Text = String.Empty;
                txtPhoneNum.Text = String.Empty;
                (this.ParentForm as Main)?.refreshPage(sender, e);
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

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNum.Text))
            {
                if (!int.TryParse(txtPhoneNum.Text, out _))
                {
                    Main.ShowMessage(Resources.Invalid_input_Please_enter_a_v);
                    txtPhoneNum.Text = string.Empty;
                }
            }
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

