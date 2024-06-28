using WindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace WindowsFormsApp
{
    public partial class frmAccountManagement : Form
    {
        bool ForTest = false;
        int id = 0;
        string isid = string.Empty;
        string LoginName = string.Empty;
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string LoginName = comboBoxLoginName.SelectedItem.ToString();
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel6.Visible = tableLayoutPanel7.Visible = ForTest;
            tableLayoutPanel9.Visible = tableLayoutPanel10.Visible = tableLayoutPanel11.Visible = tableLayoutPanel13.Visible = !ForTest;
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT LoginName FROM User WHERE Password LIKE '0%';";
            using (var reader = Main.db.readBySql(sql))
            {
                // Clear existing items in the ComboBox
                this.comboBoxLoginName.Items.Clear();

                while (reader.Read())
                {
                    // Add each LoginName directly to the ComboBox 
                    this.comboBoxLoginName.Items.Add(reader.GetString(0));
                }
            }
            comboBoxLoginName.SelectedIndex = 0;
            sql = $"SELECT Location FROM SaleArea;";
            using (var reader = Main.db.readBySql(sql))
            {
                this.comboBoxSaleArea.Items.Clear();
                this.comboBoxSaleArea.Items.Add("No saleArea");
                while (reader.Read())
                {
                    this.comboBoxSaleArea.Items.Add(reader.GetString(0));
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog(Resources.Do_you_want_to_change_the_data))
            {
                string passwd = txtPassword.Text;
                int accessL;
                if (int.TryParse(txtAccessLevel.Text, out accessL))
                {
                }
                else
                {
                    Main.ShowMessage(Resources._error);
                    return;

                }
                int usid = 0;
                string sql = $"SELECT UserID FROM User Where LoginName = '{LoginName}';";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            usid = reader.GetInt32(0);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(txtPassword.Text)){

                    String query = $"UPDATE User SET Password = '{passwd}' Where UserID = {usid};";
                    Main.db.updateBySql(query);
                }
                if (!string.IsNullOrEmpty(txtAccessLevel.Text))
                {
                    String query = $"UPDATE User SET AccessLevel = '{accessL}' Where UserID = {usid};";
                    Main.db.updateBySql(query);
                }
                if (isid == "StaffID")
                {

                    if (!string.IsNullOrEmpty(comboBoxSaleArea.SelectedItem?.ToString()) &&
                        !string.IsNullOrEmpty(comboBoxDepartment.SelectedItem?.ToString()) &&
                        !string.IsNullOrEmpty(comboBoxPosition.SelectedItem?.ToString()) &&
                        !string.IsNullOrEmpty(txtName.Text))
                    {
                        string department = comboBoxDepartment.SelectedItem?.ToString();
                        sql = $"SELECT DeptID FROM Department Where DeptName = '{department}';";
                        using (var reader = Main.db.readBySql(sql))
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    department = reader.GetString(0);
                                }   
                            }
                        }
                        string position = comboBoxPosition.SelectedItem?.ToString();
                        string name = txtName.Text;
                        string saleArea = comboBoxSaleArea.SelectedItem?.ToString();
                        int AreaID = 0;
                        if (!string.IsNullOrEmpty(saleArea) && saleArea != "No saleArea")
                        {
                            sql = $"SELECT AreaID FROM SaleArea Where Location = '{saleArea}';";
                            using (var reader = Main.db.readBySql(sql))
                            {
                                if (reader.Read())
                                {
                                    if (!reader.IsDBNull(0))
                                    {
                                        AreaID = reader.GetInt32(0);
                                    }
                                }
                            }
                            sql = $"UPDATE Staff SET StaffName = '{name}', SaleAreaID = {AreaID} , DeptID = '{department}', Position = '{position}' Where StaffID = {id};";
                            Main.db.updateBySql(sql);
                            Main.ShowMessage(Resources.succeed);
                            claerAll();

                        }
                        else
                        {
                            sql = $"UPDATE Staff SET StaffName = '{name}' ,DeptID = {department},   Position = '{position}'  Where StaffID = {id};";
                            Main.db.updateBySql(sql);
                            Main.ShowMessage(Resources.succeed);
                            claerAll();
                        }

                    }
                    else
                    {
                        Main.ShowMessage(Resources.Missging_data);
                    }
                }
                else if (isid == "DealerID"){



                    if (!string.IsNullOrEmpty(comboBoxSaleArea.SelectedItem?.ToString()) &&
                        !string.IsNullOrEmpty(txtEmail.Text) &&
                        !string.IsNullOrEmpty(txtOfficeAddress.Text) &&
                        !string.IsNullOrEmpty(txtPhoneNumber.Text)&&
                        !string.IsNullOrEmpty(txtName.Text))
                    {
                        string email = txtEmail.Text;
                        string OfficeAdress = txtOfficeAddress.Text;
                        int phonenumber;
                        if (int.TryParse(txtPhoneNumber.Text, out phonenumber))
                        {
                        }
                        else
                        {
                        }
                        string saleArea = comboBoxSaleArea.SelectedItem?.ToString();
                        int AreaID = 0;
                        string name = txtName.Text;
                        if (!string.IsNullOrEmpty(saleArea) && saleArea != "No saleArea")
                        {
                            sql = $"SELECT AreaID FROM SaleArea Where Location = '{saleArea}';";
                            using (var reader = Main.db.readBySql(sql))
                            {
                                if (reader.Read())
                                {
                                    if (!reader.IsDBNull(0))
                                    {
                                        AreaID = reader.GetInt32(0);
                                    }
                                }
                            }
                        }else
                        {
                            Main.ShowMessage(Resources.dealer_must_have_a_saleArea);
                            return;
                        }
                        if (!string.IsNullOrEmpty(txtDeliveryAddress.Text)){
                            string DeliveryAddress = txtDeliveryAddress.Text;
                            sql = $"UPDATE Dealer SET DealerName = '{name}', SaleAreaID = {AreaID} , email = '{email}', OfficeAddress = '{OfficeAdress}', DeliveryAddress = '{DeliveryAddress}' Where DealerID = {id};";
                            Main.db.updateBySql(sql);
                            Main.ShowMessage(Resources.succeed);
                            claerAll();
                        }
                        else
                        {
                            sql = $"UPDATE Dealer SET DealerName = '{name}', SaleAreaID = {AreaID} , email = '{email}', OfficeAddress = '{OfficeAdress}' Where DealerID = {id};";
                            Main.db.updateBySql(sql);
                            Main.ShowMessage(Resources.succeed);
                            claerAll();
                        }

                    }
                    else
                    {
                        Main.ShowMessage(Resources.Missging_data);
                    }
                }
            }

        }

        private void comboBoxLoginName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginName = comboBoxLoginName.SelectedItem.ToString();
            id = 0;
            isid = string.Empty;
            string sql = $"SELECT DealerID  FROM User Where LoginName = '{LoginName}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        id = reader.GetInt32(0);
                        isid = "DealerID";
                    }
                }
            }
            sql = $"SELECT StaffID FROM User Where LoginName ='{LoginName}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        id = reader.GetInt32(0);
                        isid = "StaffID";
                    }
                }
            }
            if(isid == "StaffID")
            {
                ForTest = true;
            }else if(isid == "DealerID")
            {
                ForTest = false;
            }
            tableLayoutPanel6.Visible = tableLayoutPanel7.Visible = ForTest;
            tableLayoutPanel9.Visible = tableLayoutPanel10.Visible = tableLayoutPanel11.Visible = tableLayoutPanel13.Visible = !ForTest;

            int Accesslevele = 0;
            if (isid == "StaffID")
            {
                sql = $@" SELECT u.AccessLevel, d.DeptName, s.Position, s.StaffName, a.Location FROM User u JOIN Staff s ON u.LoginName = '{LoginName}' AND s.StaffID = {id} JOIN Department d ON s.DeptID = d.DeptID LEFT JOIN SaleArea a ON s.SaleAreaID = a.AreaID WHERE s.StaffID = {id}; SELECT DeptName FROM Department; SELECT DISTINCT Position FROM Staff;";
                string deptName = string.Empty;
                string position = string.Empty;

                using (var reader = Main.db.readBySql(sql))
                {
                    // Read the first result set to populate AccessLevel and other fields
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            Accesslevele = reader.GetInt32(0);
                        }
                        txtAccessLevel.Text = Accesslevele.ToString();

                        // Store the department, position, and sale area temporarily
                        deptName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                        position = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                        string staffName = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                        string saleArea = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                        txtName.Text = staffName;
                        comboBoxSaleArea.Text = saleArea;
                    }

                    // Move to the next result set for Departments
                    if (reader.NextResult())
                    {
                        List<string> DeptNamelist = new List<string>();
                        while (reader.Read())
                        {
                            DeptNamelist.Add(reader.GetString(0));
                        }
                        this.comboBoxDepartment.DataSource = DeptNamelist;
                    }

                    // Move to the next result set for Positions
                    if (reader.NextResult())
                    {
                        List<string> comboBoxPositionlist = new List<string>();
                        while (reader.Read())
                        {
                            comboBoxPositionlist.Add(reader.GetString(0));
                        }
                        this.comboBoxPosition.DataSource = comboBoxPositionlist;
                    }

                    // Set the selected items after setting the DataSource
                    if (!string.IsNullOrEmpty(deptName))
                    {
                        comboBoxDepartment.SelectedItem = deptName;
                    }
                    if (!string.IsNullOrEmpty(position))
                    {
                        comboBoxPosition.SelectedItem = position;
                    }
                }
            }

            else if (isid == Resources.DealerID)
            {
                sql = $@" SELECT u.AccessLevel, d.DealerName, d.ContantNumber, d.email, d.OfficeAddress, d.DeliveryAddress, a.Location FROM User u LEFT JOIN Dealer d ON d.DealerID = {id} LEFT JOIN SaleArea a ON d.SaleAreaID = a.AreaID WHERE u.LoginName = '{LoginName}' AND u.DealerID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        // AccessLevel
                        if (!reader.IsDBNull(0))
                        {
                            Accesslevele = reader.GetInt32(0);
                        }
                        txtAccessLevel.Text = Accesslevele.ToString();

                        // DealerName
                        string DealerName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                        txtName.Text = DealerName;

                        // ContantNumber
                        string ContantNumber = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                        txtPhoneNumber.Text = ContantNumber;

                        // Email
                        string email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                        txtEmail.Text = email;

                        // OfficeAddress
                        string OfficeAddress = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                        txtOfficeAddress.Text = OfficeAddress;

                        // DeliveryAddress
                        string DeliveryAddress = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                        txtDeliveryAddress.Text = DeliveryAddress;

                        // SaleArea Location
                        string Area = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                        comboBoxSaleArea.Text = Area;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoginName = comboBoxLoginName.SelectedItem.ToString();

            string sql = $"SELECT Password FROM User WHERE LoginName = '{LoginName}';";
            string Password = null;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    Password = reader.GetString(0);
                    if (!string.IsNullOrEmpty(Password))
                    {
                        Password = "!" + Password.Substring(1);
                    }

                }
            }
            sql = $"UPDATE User SET Password = '{Password}' Where  LoginName = '{LoginName}';";
            Main.db.updateBySql(sql);
            Main.ShowMessage(Resources.succeed);
        }

        private void txtAccessLevel_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAccessLevel.Text?.TrimStart('1'), out int accessLevel))
            {
                if (accessLevel >= 1 && accessLevel <= 10000)
                {
                    // 执行正确的操作
                }
                else
                {
                    ShowInvalidAccessLevelError();
                }
            }
            else
            {
                if (txtAccessLevel.Text == null)
                {
                    txtAccessLevel.Text = "1";
                }
                else
                {
                    ShowInvalidAccessLevelError();
                }
            }

            void ShowInvalidAccessLevelError()
            {
                if (txtAccessLevel.Text != null && txtAccessLevel.Text != "1")
                {
                    Main.ShowMessage(Resources.Invalid_access_level_Please_en);
                    txtAccessLevel.Text = "1";
                }
            }
        }

        private void comboBoxSpareType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                // Check if the input is a valid number
                if (!long.TryParse(txtPhoneNumber.Text, out _))
                {
                    Main.ShowMessage(Resources.Invalid_input_Please_enter_a_v);
                    txtPhoneNumber.Text = string.Empty;
                }
                // Check if the input length exceeds 20 digits
                else if (txtPhoneNumber.Text.Length > 20)
                {
                    Main.ShowMessage(Resources.Phone_number_cannot_exceed_20_);
                    txtPhoneNumber.Text = txtPhoneNumber.Text.Substring(0, 20);
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    Main.ShowMessage(Resources.Please_enter_a_valid_email_add);
                    txtEmail.Text = string.Empty;
                }
            }
        }

        private void txtOfficeAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeliveryAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void claerAll()
        {
            txtName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtAccessLevel.Text = "1";
            txtDeliveryAddress.Text = String.Empty;
            txtOfficeAddress.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
        }
    }
}
