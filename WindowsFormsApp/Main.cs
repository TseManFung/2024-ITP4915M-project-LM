﻿using System;
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
    
    public partial class Main : Form
    {
        public static sshdatabase db = new sshdatabase();

        bool isLogin = false;
        int userID;
        public void SetIsLogin(int id)
        {
            this.isLogin = true;
            this.userID  = id;
        }
        public Main()
        {
            InitializeComponent();
        }



        private void Main_Load(object sender, EventArgs e)
        {
            this.Change_pContent(typeof(frmLogin));
            //this.Change_pContent(typeof(frmOrderDetail));
        }

        public void Change_pContent(Type formType) {
            pContent.Controls.Clear();
            Form frm = (Form)Activator.CreateInstance(formType);
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pContent.Controls.Add(frm);
            frm.Show();
            lblTitle.Text = frm.Text;

            if (lblTitle.Text == "Login" || lblTitle.Text == "Main Menu")
            {
                pictureBoxBack.Visible = false;
                lblTitle.Cursor = Cursors.Arrow;
            }
            else
            {

                pictureBoxBack.Visible = true;
                lblTitle.Cursor = Cursors.Hand;}
        }


        private void pContent_Paint(object sender, PaintEventArgs e)
        {

        }


        private void lblTitle_Click_1(object sender, EventArgs e) { 
        
            if (lblTitle.Text == "Login" || lblTitle.Text == "Main Menu")
            {
                return;
            }
            if(this.isLogin){
                this.Change_pContent(typeof(frmMenu));
            }
        }

        private void pictureBoxLanguage_Click(object sender, EventArgs e)
        {
            frmLanguage f=new frmLanguage();
            f.ShowDialog();
        }
    }
}
