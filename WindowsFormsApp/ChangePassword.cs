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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (text.Contains(" "))
            {
                text = text.Replace(" ", "");
                textBox.Text = text;
                textBox.SelectionStart = text.Length;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (text.Contains(" "))
            {
                text = text.Replace(" ", "");
                textBox.Text = text;
                textBox.SelectionStart = text.Length;
            }
        }

        private void txtRepartNewPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (text.Contains(" "))
            {

                text = text.Replace(" ", "");
                textBox.Text = text;
                textBox.SelectionStart = text.Length;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtOldPassword.Text) ||
                string.IsNullOrEmpty(txtNewPassword.Text) ||
                string.IsNullOrEmpty(txtRepartNewPassword.Text))
            {
                Main.ShowMessage(Resources.Please_fill_in_all_the_require);
                return;
            }

            String OldPassword = txtOldPassword.Text;
            OldPassword = Main.db.ComputeSha256Hash(OldPassword);
            OldPassword = "0" + OldPassword;
            string dbOldPassword = string.Empty;

            if (txtNewPassword.Text != txtRepartNewPassword.Text)
            {
                Main.ShowMessage(Resources.The_password_entered_twice_is_);
                claer();
                return;
            }

            string sql = $"SELECT Password FROM `User` WHERE UserID = {Main.userID};";
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();
                dbOldPassword = reader.GetString(0);
            }

            if (OldPassword == dbOldPassword && Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_chang))
            {
                String newpasswd = "0" + Main.db.ComputeSha256Hash(txtRepartNewPassword.Text);
                String query = $"UPDATE User SET Password = '{newpasswd}' Where UserID = {Main.userID};";
                Main.db.updateBySql(query);
                Main.ShowMessage(Resources.Successful_reset_password);
                (this.ParentForm as Main)?.SetLogout();
                (this.ParentForm as Main)?.Change_pContent(typeof(frmLogin));
            }
            else
            {
                Main.ShowMessage(Resources.The_old_password_does_not_matc);
                claer();
                return;
            }


        }

        private void claer()
        {
            txtOldPassword.Text = String.Empty;
            txtNewPassword.Text = String.Empty;
            txtRepartNewPassword.Text = String.Empty;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
