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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRepartNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {
                if (
                    !string.IsNullOrEmpty(txtOldPassword.Text) &&
                    !string.IsNullOrEmpty(txtNewPassword.Text) &&
                    !string.IsNullOrEmpty(txtRepartNewPassword.Text))
                {
                    String OldPassword = txtOldPassword.Text;
                    OldPassword = Main.db.ComputeSha256Hash(OldPassword);
                    OldPassword = "0" + OldPassword;
                    string dbOldPassword = string.Empty;
                    string sql = $"SELECT Password FROM `User` WHERE UserID = {Main.userID};";
                    using (var reader = Main.db.readBySql(sql))
                    {
                        while (reader.Read())
                        {
                            dbOldPassword = reader.GetString(0);
                        }
                    }

                    if (OldPassword == dbOldPassword)
                    {
                        if (txtNewPassword.Text == txtRepartNewPassword.Text)
                        {
                            String newpasswd = "0" + Main.db.ComputeSha256Hash(txtRepartNewPassword.Text);
                            String query = $"UPDATE User SET Password = '{newpasswd}' Where UserID = {Main.userID};";
                            Main.db.updateBySql(query);
                            MessageBox.Show("Successful reset password");
                            txtOldPassword.Text = String.Empty;
                            txtNewPassword.Text = String.Empty;
                            txtRepartNewPassword.Text = String.Empty;
                        }
                        else
                        {
                            MessageBox.Show("New password is not the same, please re-enter!");
                            txtOldPassword.Text = String.Empty;
                            txtNewPassword.Text = String.Empty;
                            txtRepartNewPassword.Text = String.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password is not the same, please re-enter!");
                        txtOldPassword.Text = String.Empty;
                        txtNewPassword.Text = String.Empty;
                        txtRepartNewPassword.Text = String.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Please complete all fences!");
                    txtOldPassword.Text = String.Empty;
                    txtNewPassword.Text = String.Empty;
                    txtRepartNewPassword.Text = String.Empty;
                }
            }
        }
    }
}
