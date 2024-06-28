using WindowsFormsApp.Properties;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {

            InitializeComponent();

        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {

            login();
        }

        public bool login()
        {
            try
            {
                int id = Main.db.getUserID(txtLoginName.Text, txtPassword.Text);
                (this.ParentForm as Main)?.SetIsLogin(id);
                (this.ParentForm as Main)?.Change_pContent(typeof(frmMenu));
                return true;
            }
            catch (Exception ex)
            {
                lblWrongPassword.Show();
                txtLoginName.Text = txtPassword.Text = "";
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                if (login())
                {
                    e.Handled = true;
                }

            }

            else if (e.KeyChar == (char)27)
            {
                (this.ParentForm as Main)?.Close();
                e.Handled = true;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //frmForgetPW f = new frmForgetPW();
            //f.ShowDialog();
            MessageBox.Show(Resources.Please_contact_us_to_reset_you,Resources.Contact_Us);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
