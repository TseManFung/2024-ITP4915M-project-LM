using WindowsFormsApp.Properties;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace WindowsFormsApp
{
    public partial class frmEditSupplier : Form
    {
        public frmEditSupplier()
        {   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;

        }

        private void frmEditSupplier_Load(object sender, EventArgs e)
        {
            List<string> SupplierNamelist = new List<string>();
            String sql = $"SELECT Name FROM Supplier WHERE State = 'N';";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SupplierNamelist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSupplierID.DataSource = SupplierNamelist;
            this.comboBoxSupplierID.DisplayMember = "SupplierName";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectSupplier = comboBoxSupplierID.SelectedItem.ToString();
            String sqlofsupplier = $"SELECT supplierID FROM Supplier WHERE Name = '{selectSupplier}'";
            int supplierID = 0;
            int flag = 0;
            using (var reader = Main.db.readBySql(sqlofsupplier))
            {
                while (reader.Read())
                {
                    supplierID = reader.GetInt32(0);
                }
            }
            // 检查所有文本框是否都为空
            if (string.IsNullOrEmpty(txtName.Text) &&
                string.IsNullOrEmpty(txtEmail.Text) &&
                string.IsNullOrEmpty(txtContantNumber.Text) &&
                string.IsNullOrEmpty(txtAddress.Text))
            {
                Main.ShowMessage("Please enter at least one field!");
                return;  // 退出方法
            }
            if (Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_chang0))
            {
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    string Name = txtName.Text;
                    string query = $"UPDATE Supplier SET Name = '{Name}' WHERE supplierID = '{supplierID}'";
                    Main.db.updateBySql(query);
                    flag = 1;
                }
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    string Email = txtEmail.Text;
                    string query = $"UPDATE Supplier SET email = '{Email}' WHERE supplierID = '{supplierID}'";
                    Main.db.updateBySql(query);
                    flag = 1;
                }
                if (!string.IsNullOrEmpty(txtContantNumber.Text))
                {
                        string ContantNumber = txtContantNumber.Text;
                        string query = $"UPDATE Supplier SET ContantNumber = '{ContantNumber}' WHERE supplierID = '{supplierID}'";
                        Main.db.updateBySql(query);
                        flag = 1;
                }
                if (!string.IsNullOrEmpty(txtAddress.Text))
                {
                    string Address = txtAddress.Text;
                    string query = $"UPDATE Supplier SET Address = '{Address}' WHERE supplierID = '{supplierID}'";
                    Main.db.updateBySql(query);
                    flag = 1;
                }

                if (flag == 1)
                {
                    Main.ShowMessage(Resources.Successful_editing);
                    txtName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtContantNumber.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
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
                    Main.ShowMessage(Resources.Please_enter_a_maximum_of_20_d);
                    txtContantNumber.Text = string.Empty;
                }
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = comboBoxSupplierID.Text;
            string selectSupplier = comboBoxSupplierID.SelectedItem.ToString();
            String sql = $"SELECT supplierID FROM Supplier WHERE Name = '{selectSupplier}'";
            int supplierID = 0;
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    supplierID = reader.GetInt32(0);
                }
            }
            string email = String.Empty;
            sql = $"SELECT email FROM Supplier WHERE SupplierID = '{supplierID}'";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    email = reader.GetString(0);
                }
            }
            txtEmail.Text = email;
            string ContantNumber = String.Empty;
            sql = $"SELECT ContantNumber FROM Supplier WHERE SupplierID = '{supplierID}'";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    ContantNumber = reader.GetString(0);
                }
            }
            txtContantNumber.Text = ContantNumber;
            string Address = String.Empty;
            sql = $"SELECT Address FROM Supplier WHERE SupplierID = '{supplierID}'";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    Address = reader.GetString(0);
                }
            }
            txtAddress.Text = Address;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog(Resources.Are_you_sure_you_want_to_delet))
            {
                string selectSupplier = comboBoxSupplierID.SelectedItem.ToString();
                String sqlofsupplier = $"SELECT supplierID FROM Supplier WHERE Name = '{selectSupplier}'";
                int supplierID = 0;
                using (var reader = Main.db.readBySql(sqlofsupplier))
                {
                    while (reader.Read())
                    {
                        supplierID = reader.GetInt32(0);
                    }
                }
                string sql = $"UPDATE Supplier SET State = 'D' Where  SupplierID = '{supplierID}';";
                Main.db.updateBySql(sql);
                Main.ShowMessage(Resources.succeed);
                (this.ParentForm as Main)?.refreshPage(sender, e);
            }
        }
    }
}
