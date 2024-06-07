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
            List<int> DealerIDlist = new List<int>();
            string sql = $"SELECT DealerID FROM Dealer;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    DealerIDlist.Add(reader.GetInt32(0));
                }
            }
            this.comboBoxDealerID.DataSource = DealerIDlist;
            this.comboBoxDealerID.DisplayMember = "DealerID";
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
                        MessageBox.Show("Please provide both Department Name and Department Email!");
                    }

                }
                else if(radNo.Checked)
                {
                    DealerID = Convert.ToInt32(comboBoxDealerID.SelectedItem);
                }
                query = $"INSERT INTO `User` (LoginName, Password, AccessLevel,DealerID) VALUES ('{loginName}', '{passwd}', {accessLevel}, {DealerID})";

                Main.db.insertBySql(query);
                MessageBox.Show($"Successful editing, your password is {randompasswd},  please change your password as soon as possible!");
                txtDealerName.Text = String.Empty;
                txtDeliveryAddress.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtPhoneNumber.Text = String.Empty;
                txtOfficeAddress.Text = String.Empty;
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
                if (!int.TryParse(txtPhoneNumber.Text, out _))
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                    txtPhoneNumber.Text = string.Empty;
                }
            }
        }
    }
}
