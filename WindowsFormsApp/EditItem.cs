using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class frmEditItem : Form
    {
        public frmEditItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            List<string> SpareType = new List<string>();
            String sql = $"SELECT CategoryLetter FROM Category;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SpareType.Add(reader.GetString(0));
                }
            }
            this.comboBoxSpareType.DataSource = SpareType;
            this.comboBoxSpareType.DisplayMember = "Type";

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
            this.comboBoxSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void comboBoxSpareID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            List<string> SpareIDlist = new List<string>();
            String sql = $"SELECT SpareID FROM Spare;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SpareIDlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSpareID.DataSource = SpareIDlist;
            this.comboBoxSpareID.DisplayMember = "SpareID";
            this.comboBoxSpareID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxSpareID.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void txtSpareName_TextChanged(object sender, EventArgs e)
        {
            string input = txtSpareName.Text;
            string pattern = @"^[a-zA-Z\s]+$"; // only space and letter
            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, pattern))
            {
                txtSpareName.Text = string.Empty;
                MessageBox.Show("only space and letter!"); // Show error message
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string input = txtPrice.Text;
            double inputValue;
            if (double.TryParse(input, out inputValue))
            {
                this.txtPrice.Text = string.Format("{0:#,##0.00}", inputValue);
            }
            else
            {
                this.txtPrice.Text = "0.00";
            }
        }

        private void txtSpareWeight_TextChanged(object sender, EventArgs e)
        {
            string input = txtSpareWeight.Text;
            string pattern = @"^\d+$";
            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, pattern))
            {
                txtSpareWeight.Text = string.Empty;
                MessageBox.Show("only number!"); // Show error message
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxSpareID.SelectedItem != null &&
                comboBoxSpareType.SelectedItem != null &&
                !string.IsNullOrEmpty(txtSpareName.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text) &&
                !string.IsNullOrEmpty(txtSpareWeight.Text) &&
                comboBoxSupplier.SelectedItem != null)
            {
                string spareID = comboBoxSpareID.SelectedItem.ToString();
                string CattegoryLetter = comboBoxSpareType.SelectedItem.ToString();
                string SpareName = txtSpareName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string Description = txtDescription.Text;
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
                string query = $"UPDATE Spare SET SpareName = '{SpareName}', CategoryLetter = '{CattegoryLetter}', Price = {price}, Description = '{Description}', Weight = {weight}, SupplierID = {SupplierID} WHERE SpareID = '{spareID}'";
                Main.db.updateBySql(query);
                MessageBox.Show("Successful editing");

                txtSpareName.Text = "";
                txtPrice.Text = "00.00";
                txtSpareWeight.Text = "0";
                txtDescription.Text = "";
            }
            else
            {
                MessageBox.Show("Please provide complete data");
            }
   
        }

        private void comboBoxSpareType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}
