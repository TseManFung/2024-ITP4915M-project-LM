﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace WindowsFormsApp
{
    public partial class frmNewSupplier : Form
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
        public frmNewSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmEditSupplier));
        }

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

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

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContantNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContantNumber.Text))
            {
                string contantNumber = txtContantNumber.Text;

                if (Regex.IsMatch(contantNumber, @"^\d{1,20}$"))
                {

                }
                else
                {
                    Main.ShowMessage("Please enter a maximum of 20 digits!");
                    txtContantNumber.Text = string.Empty;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContantNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;


        }

        private void btnCreateNewSupplier_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Are you sure you want to change it?"))
            {
                if (!string.IsNullOrEmpty(txtName.Text) &&
                    !string.IsNullOrEmpty(txtAddress.Text) &&
                    !string.IsNullOrEmpty(txtContantNumber.Text) &&
                    !string.IsNullOrEmpty(txtEmail.Text))
                    {
                    string Name = txtName.Text;
                    string Address = txtAddress.Text;
                    string Email = txtEmail.Text;
                    string ContantNumber = txtContantNumber.Text;
                    string query = $"INSERT INTO Supplier (Name, Address, ContantNumber, email) VALUES ('{Name}','{Address}', '{ContantNumber}', '{Email}')";
                    Main.db.insertBySql(query);
                    Main.ShowMessage("Successful creating");
                }
                else
                {
                    Main.ShowMessage("Please fill in all information");
                }
            }
        }
    }
}
