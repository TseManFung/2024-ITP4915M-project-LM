using MySql.Data.MySqlClient;
using System;
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
            
        }

        private void comboBoxSpareID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBoxSpareID.SelectedItem.ToString();
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

            string SpareName = string.Empty;
            sql = $"SELECT SpareName FROM Spare WHERE SpareID = '{id}';";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SpareName = reader.GetString(0);
                }
            }
            txtSpareName.Text = SpareName;
            Decimal Price = 0;
            sql = $"SELECT Price FROM Spare WHERE SpareID = '{id}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    Price = reader.GetDecimal(0);
                }
            }
            txtPrice.Text = Price.ToString();
            float Weight = 0;
            sql = $"SELECT Weight FROM Spare WHERE SpareID = '{id}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        Weight = reader.GetFloat(0);
                    }
                }
            }
            txtSpareWeight.Text = Weight.ToString();
            string Description = null;
            sql = $"SELECT Description FROM Spare WHERE SpareID = '{id}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        Description = reader.GetString(0);
                    }
                }
            }

            if (Description != null)
            {
                txtDescription.Text = Description;
            }
            else
            {
                txtDescription.Text = string.Empty;
            }
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            List<string> SpareIDlist = new List<string>();
            string sql = $"SELECT SpareID FROM Spare WHERE state <> 'D';";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SpareIDlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSpareID.DataSource = SpareIDlist;
            this.comboBoxSpareID.DisplayMember = "SpareID";

        }

        private void txtSpareName_TextChanged(object sender, EventArgs e)
        {
            string input = txtSpareName.Text;
            string pattern = @"^[a-zA-Z\s]+$"; // only space and letter
            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, pattern))
            {
                txtSpareName.Text = string.Empty;
                Main.ShowMessage("only space and letter!"); // Show error message
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
            string pattern = @"^(\d*\.\d+|\d+)$";
            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, pattern))
            {
                txtSpareWeight.Text = string.Empty;
                Main.ShowMessage("Only numbers and decimal points are allowed!"); // Show error message
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
                Main.ShowMessage("Successful editing");

                txtSpareName.Text = "";
                txtPrice.Text = "00.00";
                txtSpareWeight.Text = "0";
                txtDescription.Text = "";
            }
            else
            {
                Main.ShowMessage("Please provide complete data");
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
            string spareID = comboBoxSpareID.SelectedItem.ToString();
            string query = $"UPDATE Spare SET State = 'D' WHERE SpareID = '{spareID}'";

        }
    }
}
