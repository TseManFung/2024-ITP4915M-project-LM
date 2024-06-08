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

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContactNumber.Text))
            {
                if (!int.TryParse(txtContactNumber.Text, out _))
                {
                    Main.ShowMessage("Invalid input. Please enter a valid number.");
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
                    Main.ShowMessage("Please enter a valid email address!");
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
                Main.ShowMessage("Please enter values in at least one of the fields.");
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
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
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
                        Main.ShowMessage("Duplicate phone numbers");
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
                Main.ShowMessage("Success!"); 
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
    }
}
