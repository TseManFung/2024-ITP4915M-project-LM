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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WindowsFormsApp
{
    public partial class frmModifyInformation : Form
    {
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
        public frmModifyInformation()
        {
            InitializeComponent();
        }
        private bool IsNumeric(string input)
        {
            return long.TryParse(input, out _);
        }
        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContactNumber.Text))
            {
                if (txtContactNumber.Text.Length > 20 || !IsNumeric(txtContactNumber.Text))
                {
                    Main.ShowMessage(Resources.Invalid_input_Please_enter_a_v0);
                    txtContactNumber.Text = string.Empty;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactNumber.Text) &&
                string.IsNullOrEmpty(txtEmail.Text) &&
                string.IsNullOrEmpty(txtOfficeAdress.Text) &&
                string.IsNullOrEmpty(txtDeliveryAddress.Text))
            {
                Main.ShowMessage(Resources.Please_enter_values_in_at_leas);
                return;
            }
            
            string sql = $"select DealerID FROM User WHERE UserID = {Main.userID};";
            int DealerID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    DealerID = reader.GetInt32(0);
                }
            }
            if (Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_chang0))
            {
                
                if (!string.IsNullOrEmpty(txtContactNumber.Text))
                {
                    string ContactNumber = txtContactNumber.Text;
                    sql = $"SELECT COUNT(*) FROM Dealer WHERE ContantNumber = '{ContactNumber}'";
                    int count = 0;
                    using (var reader = Main.db.readBySql(sql))
                    {
                        if (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }

                    if (count > 0)
                    {
                        Main.ShowMessage(Resources.Duplicate_phone_numbers);
                        txtContactNumber.Text = string.Empty;
                        return;
                    }

                    sql = $"UPDATE Dealer SET ContantNumber = '{ContactNumber}' WHERE DealerID = {DealerID};";
                    Main.db.updateBySql(sql);

                }
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    string Email = txtEmail.Text.ToString();
                    sql = $"UPDATE Dealer SET email = '{Email}' WHERE DealerID = {DealerID};";
                    Main.db.updateBySql(sql);
                }
                if (!string.IsNullOrEmpty(txtOfficeAdress.Text))
                {
                    string OfficeAdress = txtOfficeAdress.Text.ToString();
                    sql = $"UPDATE Dealer SET OfficeAddress = '{OfficeAdress}' WHERE DealerID = {DealerID};";
                    Main.db.updateBySql(sql);
                }
                if (!string.IsNullOrEmpty(txtDeliveryAddress.Text))
                {
                    string DeliveryAddress = txtDeliveryAddress.Text.ToString();
                    sql = $"UPDATE Dealer SET DeliveryAddress = '{DeliveryAddress}' WHERE DealerID = {DealerID};";
                    Main.db.updateBySql(sql);
                }
                Main.ShowMessage(Resources.Success0); 
                txtContactNumber.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtOfficeAdress.Text = string.Empty;
                txtDeliveryAddress.Text = string.Empty;
            }

        }

        private void txtOfficeAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeliveryAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmModifyInformation_Load(object sender, EventArgs e)
        {
            string sql = $"select DealerID FROM User WHERE UserID = {Main.userID};";
            int DealerID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    DealerID = reader.GetInt32(0);
                }
            }
            sql = $"select ContantNumber FROM Dealer WHERE DealerID = {DealerID};";
            String ContactNumber = String.Empty;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    ContactNumber = reader.GetString(0);
                }
            }
            txtContactNumber.Text = ContactNumber;
            sql = $"select email FROM Dealer WHERE DealerID = {DealerID};";
            String Email = String.Empty;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    Email = reader.GetString(0);
                }
            }
            txtEmail.Text = Email;
            sql = $"select OfficeAddress FROM Dealer WHERE DealerID = {DealerID};";
            String OfficeAdress = String.Empty;
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    OfficeAdress = reader.GetString(0);
                }
            }
            txtOfficeAdress.Text = OfficeAdress;
            string DeliveryAddress = null;
            sql = $"SELECT DeliveryAddress FROM Dealer WHERE DealerID = {DealerID};";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    DeliveryAddress = reader.IsDBNull(0) ? Resources.Delivery_address_not_yet_recor : reader.GetString(0);
                }
            }
            txtDeliveryAddress.Text = DeliveryAddress ?? string.Empty;
        }
    }
}
