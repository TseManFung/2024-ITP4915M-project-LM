﻿using System;
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

        //step to dnow
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try{
                 int id =Main.db.getUserID(txtLoginName.Text, txtPassword.Text);
                (this.ParentForm as Main)?.Change_pContent(typeof(frmMenu));
                (this.ParentForm as Main)?.SetIsLogin(id);
            }
            catch (Exception ex)
            {
                lblWrongPassword.Show();
            }



        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgetPW f = new frmForgetPW();
            f.ShowDialog();
        }
    }
}
