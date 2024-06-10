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

namespace WindowsFormsApp
{
    public partial class frmAddNewItem : Form
    {
        public frmAddNewItem()
        {
            InitializeComponent();
        }

        private void comboBoxSpareType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddNewItem_Load(object sender, EventArgs e)
        {
            List<string> SpareTypelist = new List<string>();
            String sql = $"SELECT CategoryLetter FROM Category;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SpareTypelist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSpareType.DataSource = SpareTypelist;
            this.comboBoxSpareType.DisplayMember = "SpareType";
            List<string> SupplierIDlist = new List<string>();
            String sqlofSupplierIDlist = $"SELECT Name FROM Supplier;";
            using (var reader = Main.db.readBySql(sqlofSupplierIDlist))
            {
                while (reader.Read())
                {
                    SupplierIDlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSupplier.DataSource = SupplierIDlist;
            this.comboBoxSupplier.DisplayMember = "Name";
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Do you want to turn to the next page?"))
            {



                if (
                comboBoxSpareType.SelectedItem != null &&
                !string.IsNullOrEmpty(txtSpareName.Text) &&
                !string.IsNullOrEmpty(txtSparePrice.Text) &&
                !string.IsNullOrEmpty(txtSpareWeight.Text) &&
                comboBoxSupplier.SelectedItem != null)
                {
                    string CattegoryLetter = comboBoxSpareType.SelectedItem.ToString();
                    string SpareName = txtSpareName.Text;
                    decimal price = decimal.Parse(txtSparePrice.Text);
                    string Description = textBoxDescription.Text;
                    float weight = float.Parse(txtSpareWeight.Text);
                    string supplierName = comboBoxSupplier.SelectedItem.ToString(); ;
                    String sqlofsupplier = $"SELECT SupplierID FROM Supplier WHERE Name = '{supplierName}'";
                    int SupplierID = 0;
                    using (var reader = Main.db.readBySql(sqlofsupplier))
                    {
                        while (reader.Read())
                        {
                            SupplierID = reader.GetInt32(0);
                        }
                    }
                    String sqlofMaxNumOfCLetter = $"SELECT max(SpareID) FROM Spare Where  CategoryLetter = '{CattegoryLetter}';";
                    string MaxNumOfCLetter = "";
                    using (var reader = Main.db.readBySql(sqlofMaxNumOfCLetter))
                    {
                        while (reader.Read())
                        {
                            MaxNumOfCLetter = reader.GetString(0);
                        }
                    }
                    string prefix = MaxNumOfCLetter.Substring(0, 1);
                    string lastFiveDigits = MaxNumOfCLetter.Substring(MaxNumOfCLetter.Length - 5);
                    int number = int.Parse(lastFiveDigits);
                    number += 1;
                    string newSpareID = prefix + number.ToString();

                    string query = $"INSERT INTO Spare (SpareID, SpareName, CategoryLetter, Price, Description, Weight, SupplierID) VALUES ('{newSpareID}','{SpareName}', '{CattegoryLetter}', {price}, '{Description}', {weight}, {SupplierID})";
                    Main.db.insertBySql(query);

                    MessageBox.Show("Successful ADD, your added new spare ID is " + newSpareID.ToString(), "Success");

                    txtSpareName.Text = "";
                    txtSparePrice.Text = "00.00";
                    txtSpareWeight.Text = "0";
                    textBoxDescription.Text = "";
                }
                else
                {
                    Main.ShowMessage("Please provide complete data");
                }
            }
        }

        private void txtSparePrice_TextChanged(object sender, EventArgs e)
        {
            string input = txtSparePrice.Text;
            double inputValue;
            if (double.TryParse(input, out inputValue))
            {
                this.txtSparePrice.Text = string.Format("{0:#,##0.00}", inputValue);
            }
            else
            {
                this.txtSparePrice.Text = "0.00";
            }
        }

        private void txtSpareName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpareWeight_TextChanged(object sender, EventArgs e)
        {
            string input = txtSpareWeight.Text;
            string pattern = @"^\d+$";
            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, pattern))
            {
                txtSpareWeight.Text = string.Empty;
                Main.ShowMessage("only number!"); // Show error message
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpareName.Text = String.Empty;
            txtSparePrice.Text = "00.00";
            txtSpareWeight.Text = "0";
            textBoxDescription.Text = String.Empty;
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
