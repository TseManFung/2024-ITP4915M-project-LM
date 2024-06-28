using MultiLang;
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
                    Main.ShowMessage(ml.ml_string(356,"Invalid input. Please enter a valid number with up to 20 digits."));
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
                    Main.ShowMessage(ml.ml_string(286,"Please enter a valid email address!"));
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
                Main.ShowMessage(ml.ml_string(357,"Please enter values in at least one of the fields."));
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
            if (Main.ShowYesNoDialog(ml.ml_string(308,"Are you sure you want to change it?")))
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
                        Main.ShowMessage(ml.ml_string(332,"Duplicate phone numbers"));
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
                Main.ShowMessage(ml.ml_string(358,"Success!")); 
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
                    DeliveryAddress = reader.IsDBNull(0) ? ml.ml_string(355,"Delivery address not yet recorded.") : reader.GetString(0);
                }
            }
            txtDeliveryAddress.Text = DeliveryAddress ?? string.Empty;
        }
    }
}
