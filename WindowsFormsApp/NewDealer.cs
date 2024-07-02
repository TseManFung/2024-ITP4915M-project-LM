using WindowsFormsApp.Properties;
using Google.Protobuf.WellKnownTypes;
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
    public partial class frmNewDealer : Form
    {
        public frmNewDealer()
        {
            InitializeComponent();
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowTable();
            // 使用 LEFT JOIN 查询未在 User 表中使用的 DealerID
            List<int> availableDealerIDs = new List<int>();
            string sql = @" SELECT d.DealerID FROM Dealer d LEFT JOIN User u ON d.DealerID = u.DealerID WHERE u.DealerID IS NULL;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    availableDealerIDs.Add(reader.GetInt32(0));
                }
            }

            // 将 availableDealerIDs 绑定到 comboBoxDealerID
            this.comboBoxDealerID.DataSource = availableDealerIDs;
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

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    Main.ShowMessage(Resources.Please_enter_a_valid_email_add);
                    txtEmail.Text = string.Empty;
                }

                return;
            }
            if (Main.ShowYesNoDialog("Do you want to creat a new account?"))
            {
                Random random = new Random();
                string randompasswd = CreatePassword(8);
                string passwd = '0' + Main.db.ComputeSha256Hash(randompasswd.ToString());
                string loginName = frmUserManagementAndAccountManagement.GlobalLoginNameForCreate;
                int accessLevel = frmUserManagementAndAccountManagement.GlobalAccessLevelForCreate;
                int? DealerID = null;
                string query;

                if (radYes.Checked)
                {

                    if (!string.IsNullOrEmpty(txtDealerName.Text) &&
                    !string.IsNullOrEmpty(txtEmail.Text) &&
                    !string.IsNullOrEmpty(txtPhoneNumber.Text) &&
                    !string.IsNullOrEmpty(txtOfficeAddress.Text) &&
                    comboBoxSaleArea.SelectedItem != null)
                    {
                        string DealerNameT = txtDealerName.Text;
                        string txtDeliveryAddressT = txtDeliveryAddress.Text;
                        string txtEmailT = txtEmail.Text;
                        string txtPhoneNumberT = txtPhoneNumber.Text;
                        string txtOfficeAddressT = txtOfficeAddress.Text;
                        string comboBoxSaleAreaT = comboBoxSaleArea.SelectedItem.ToString();
                        int? SaleAreaID = null;



                        string sql = $"SELECT AreaID FROM SaleArea WHERE Location = '{comboBoxSaleAreaT}';";
                        using (var reader = Main.db.readBySql(sql))
                        {
                            if (reader.Read())
                            {
                                SaleAreaID = reader.GetInt32(0);
                            }
                        }
                        if (string.IsNullOrEmpty(txtDeliveryAddress.Text))
                        {
                            query = $"INSERT INTO Dealer (DealerName, SaleAreaID, ContantNumber,email,OfficeAddress) VALUES ('{DealerNameT}', {SaleAreaID}, '{txtPhoneNumberT}', '{txtEmailT}','{txtOfficeAddressT}')";
                            Main.db.insertBySql(query);
                            query = $"SELECT DealerID FROM Dealer WHERE DealerName = '{DealerNameT}' AND SaleAreaID = {SaleAreaID} AND ContantNumber = '{txtPhoneNumberT}' AND email = '{txtEmailT}' AND OfficeAddress = '{txtOfficeAddressT}'";
                            using (var reader = Main.db.readBySql(query))
                            {
                                while (reader.Read())
                                {
                                    DealerID = reader.GetInt32(0);
                                }
                            }
                        }
                        else
                        {
                            query = $"INSERT INTO Dealer (DealerName, SaleAreaID, ContantNumber,email,OfficeAddress,DeliveryAddress) VALUES ('{DealerNameT}', {SaleAreaID}, '{txtPhoneNumberT}', '{txtEmailT}','{txtOfficeAddressT}','{txtDeliveryAddressT}')";
                            Main.db.insertBySql(query);
                            query = $"SELECT DealerID FROM Dealer WHERE DealerName = '{DealerNameT}' AND SaleAreaID = {SaleAreaID} AND ContantNumber = '{txtPhoneNumberT}' AND email = '{txtEmailT}' AND OfficeAddress = '{txtOfficeAddressT}' AND DeliveryAddress = '{txtDeliveryAddressT}'";
                            using (var reader = Main.db.readBySql(query))
                            {
                                while (reader.Read())
                                {
                                    DealerID = reader.GetInt32(0);
                                }
                            }
                        }
                    }
                    else
                    {
                        Main.ShowMessage(Resources.Please_provide_both_Department);
                        return;
                    }

                }
                else if(radNo.Checked)
                {
                    DealerID = Convert.ToInt32(comboBoxDealerID.SelectedItem);
                }
                query = $"INSERT INTO `User` (LoginName, Password, AccessLevel,DealerID) VALUES ('{loginName}', '{passwd}', {accessLevel}, {DealerID})";

                Main.db.insertBySql(query);
                Main.ShowMessage($"Successful editing, your password is {randompasswd},  please change your password as soon as possible!");
                txtDealerName.Text = String.Empty;
                txtDeliveryAddress.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtPhoneNumber.Text = String.Empty;
                txtOfficeAddress.Text = String.Empty;
            }
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
        private void frmNewDealer_Load(object sender, EventArgs e)
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
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSaleArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDealerName.Text =String.Empty;
            txtDeliveryAddress.Text = String.Empty; 
            txtEmail.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            txtOfficeAddress.Text = String.Empty;

        }

        private void txtDealerName_TextChanged(object sender, EventArgs e)
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

        }
    }
}
