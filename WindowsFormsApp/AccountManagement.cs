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
            List<string> LoginNamelist = new List<string>();
            String sql = $"SELECT LoginName FROM User;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    LoginNamelist.Add(reader.GetString(0));
                }
            }
            this.comboBoxLoginName.DataSource = LoginNamelist;
            this.comboBoxLoginName.DisplayMember = "LoginName";
            List<string> Locationlist = new List<string>();
            Locationlist.Add("No saleArea");
            sql = $"SELECT Location FROM SaleArea;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    Locationlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSaleArea.DataSource = Locationlist;
            this.comboBoxSaleArea.DisplayMember = "SaleArea";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Do you want to change the data?"))
            {
                string passwd = txtPassword.Text;
                int accessL;
                if (int.TryParse(txtAccessLevel.Text, out accessL))
                {
                }
                else
                {
                    Main.ShowMessage("error");

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
                            Main.ShowMessage("succeed!");
                            txtName.Text = String.Empty;
                            txtPassword.Text = String.Empty;
                            txtAccessLevel.Text = String.Empty;

                        }
                        else
                        {
                            sql = $"UPDATE Staff SET StaffName = '{name}' ,DeptID = {department},   Position = '{position}'  Where StaffID = {id};";
                            Main.db.updateBySql(sql);
                            Main.ShowMessage("succeed!");
                            txtName.Text = String.Empty;
                            txtPassword.Text = String.Empty;
                            txtAccessLevel.Text = String.Empty;
                        }

                    }
                    else
                    {
                        Main.ShowMessage("Missging data!");
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
                            Main.ShowMessage("dealer must have a saleArea!");
                            return;
                        }
                        if (!string.IsNullOrEmpty(txtDeliveryAddress.Text)){
                            string DeliveryAddress = txtDeliveryAddress.Text;
                            sql = $"UPDATE Dealer SET DealerName = '{name}', SaleAreaID = {AreaID} , email = '{email}', OfficeAddress = '{OfficeAdress}', DeliveryAddress = '{DeliveryAddress}' Where DealerID = {id};";
                            Main.db.updateBySql(sql);
                            Main.ShowMessage("succeed!");
                            txtName.Text = String.Empty;
                            txtPassword.Text = String.Empty;
                            txtAccessLevel.Text = String.Empty;
                            txtDeliveryAddress.Text = String.Empty;
                            txtOfficeAddress.Text = String.Empty;
                            txtEmail.Text = String.Empty;
                            txtPhoneNumber.Text = String.Empty;
                        }
                        else
                        {
                            sql = $"UPDATE Dealer SET DealerName = '{name}', SaleAreaID = {AreaID} , email = '{email}', OfficeAddress = '{OfficeAdress}' Where DealerID = {id};";
                            Main.db.updateBySql(sql);
                            Main.ShowMessage("succeed!");
                            txtName.Text = String.Empty;
                            txtPassword.Text = String.Empty;
                            txtAccessLevel.Text = String.Empty;
                            txtDeliveryAddress.Text = String.Empty;
                            txtOfficeAddress.Text = String.Empty;
                            txtEmail.Text = String.Empty;
                            txtPhoneNumber.Text = String.Empty;
                        }

                    }
                    else
                    {
                        Main.ShowMessage("Missging data!");
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
            if (isid == "StaffID" )
            {

                sql = $"SELECT AccessLevel FROM User Where LoginName ='{LoginName}'AND  StaffID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            Accesslevele = reader.GetInt32(0);
                        }
                    }
                }
                txtAccessLevel.Text = Accesslevele.ToString();
                List<string> DeptNamelist = new List<string>();
                sql = $"SELECT DeptName FROM Department;";
                using (var reader = Main.db.readBySql(sql))
                {
                    while (reader.Read())
                    {
                        DeptNamelist.Add(reader.GetString(0));
                    }
                }
                this.comboBoxDepartment.DataSource = DeptNamelist;
                this.comboBoxDepartment.DisplayMember = "DeptName";
                String DeptName = null;
                sql = $"SELECT d.DeptName FROM Staff s JOIN Department d ON s.DeptID = d.DeptID WHERE s.StaffID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        DeptName = reader.GetString(0);

                    }
                }
                comboBoxDepartment.Text = DeptName;
                List<string> comboBoxPositionlist = new List<string>();
                sql = $"SELECT DISTINCT Position FROM Staff;";
                using (var reader = Main.db.readBySql(sql))
                {
                    while (reader.Read())
                    {
                        comboBoxPositionlist.Add(reader.GetString(0));
                    }
                }
                this.comboBoxPosition.DataSource = comboBoxPositionlist;
                this.comboBoxPosition.DisplayMember = "Position";
                String position = null;
                sql = $"SELECT Position FROM Staff WHERE StaffID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        position = reader.GetString(0);

                    }
                }
                comboBoxPosition.Text = position;
                string StaffName = null;
                sql = $"SELECT StaffName FROM Staff WHERE StaffID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        StaffName = reader.GetString(0);
                    }
                }
                txtName.Text = StaffName;
                String Area = null;
                sql = $"SELECT a.Location FROM Staff s INNER JOIN SaleArea a ON s.SaleAreaID = a.AreaID WHERE s.StaffID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        Area = reader.GetString(0);

                    }
                }
                comboBoxSaleArea.Text = Area;

            }

            else if (isid == "DealerID")
            {
                sql = $"SELECT AccessLevel FROM User Where LoginName ='{LoginName}' AND DealerID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            Accesslevele = reader.GetInt32(0);
                        }
                    }
                }
                txtAccessLevel.Text = Accesslevele.ToString();

                sql = $"SELECT DealerName FROM Dealer WHERE DealerID = {id};";
                string DealerName = null;
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        DealerName = reader.GetString(0);

                    }
                }
                txtName.Text = DealerName;
                string ContantNumber = string.Empty;
                sql = $"SELECT ContantNumber FROM Dealer WHERE DealerID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        ContantNumber = reader.GetString(0);

                    }
                }
                txtPhoneNumber.Text = ContantNumber.ToString();
                String eamil = String.Empty;
                sql = $"SELECT email FROM Dealer WHERE DealerID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        eamil = reader.GetString(0);

                    }
                }
                txtEmail.Text = eamil;
                String OfficeAddress = String.Empty;
                sql = $"SELECT OfficeAddress FROM Dealer WHERE DealerID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        OfficeAddress = reader.GetString(0);

                    }
                }
                txtOfficeAddress.Text = OfficeAddress;
                String DeliveryAddress = String.Empty;
                sql = $"SELECT DeliveryAddress FROM Dealer WHERE DealerID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        DeliveryAddress = reader.GetString(0);

                    }
                }
                txtDeliveryAddress.Text = DeliveryAddress;
                string Area = null;
                sql = $"SELECT a.Location FROM Dealer d INNER JOIN SaleArea a ON d.SaleAreaID = a.AreaID WHERE d.DealerID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    if (reader.Read())
                    {
                        Area = reader.GetString("Location");
                    }
                }
                comboBoxSaleArea.Text = Area;
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
            Main.ShowMessage("succeed!");
        }

        private void txtAccessLevel_TextChanged(object sender, EventArgs e)
        {

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
                if (!int.TryParse(txtPhoneNumber.Text, out _))
                {
                    Main.ShowMessage("Invalid input. Please enter a valid number.");
                    txtPhoneNumber.Text = string.Empty;
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    Main.ShowMessage("Please enter a valid email address!");
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
    }
}
