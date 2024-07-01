using WindowsFormsApp.Properties;
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
            tableLayoutPanel2.Visible = true;
            string id = comboBoxSpareID.SelectedItem.ToString();
            tableLayoutPanel1.Visible = true;

            LoadSpareTypes();
            LoadSupplierNames();
            LoadSpareDetails(id);
        }
        private void LoadSpareTypes()
        {
            var spareTypes = new List<string>();
            string sql = "SELECT CategoryLetter FROM Category";

            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    spareTypes.Add(reader.GetString(0));
                }
            }
            comboBoxSpareType.DataSource = spareTypes;
        }

        private void LoadSupplierNames()
        {
            var supplierNames = new List<string>();
            string sql = "SELECT Name FROM Supplier";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    supplierNames.Add(reader.GetString(0));
                }
            }
            comboBoxSupplier.DataSource = supplierNames;
        }

        private void LoadSpareDetails(string id)
        {
            string sql = $"SELECT Spare.SpareName, Spare.CategoryLetter, Spare.Price, Spare.Weight, Spare.Description, Supplier.Name AS SupplierName FROM Spare INNER JOIN Supplier ON Spare.SupplierID = Supplier.SupplierID WHERE Spare.SpareID = '{id}'";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    txtSpareName.Text = reader.GetString(0);
                    comboBoxSpareType.Text = reader.GetString(1);
                    txtPrice.Text = reader.GetDecimal(2).ToString();
                    txtSpareWeight.Text = reader.IsDBNull(3) ? string.Empty : reader.GetFloat(3).ToString();
                    txtDescription.Text = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    comboBoxSupplier.Text = reader.GetString(5);

                }
            }
        }
        private void comboBoxSpareID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            var spareIDs = new List<string>();
            string sql = "SELECT SpareID FROM Spare WHERE state <> 'D'";

            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    spareIDs.Add(reader.GetString(0));
                }
            }
            comboBoxSpareID.DataSource = spareIDs;
        }

        private void txtSpareName_TextChanged(object sender, EventArgs e)
        {
            string input = txtSpareName.Text;
            string pattern = @"^[a-zA-Z\s]+$";

            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, pattern))
            {
                txtSpareName.Text = string.Empty;
                Main.ShowMessage(Resources.Only_spaces_and_letters_are_al);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text, out double inputValue))
            {
                txtPrice.Text = string.Format("{0:#,##0.00}", inputValue);
            }
            else
            {
                txtPrice.Text = "0.00";
            }
        }

        private void txtSpareWeight_TextChanged(object sender, EventArgs e)
        {
            string input = txtSpareWeight.Text;
            string pattern = @"^(\d*\.\d+|\d+)$";

            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, pattern))
            {
                txtSpareWeight.Text = string.Empty;
                Main.ShowMessage("Only numbers and decimal points are allowed!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string spareID = comboBoxSpareID.SelectedItem.ToString();
                string categoryLetter = comboBoxSpareType.SelectedItem.ToString();
                string spareName = txtSpareName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string description = txtDescription.Text;
                float weight = float.Parse(txtSpareWeight.Text);
                string supplierName = comboBoxSupplier.SelectedItem.ToString();

                int supplierID = GetSupplierIDByName(supplierName);

                string query = $"UPDATE Spare SET SpareName = '{spareName}', CategoryLetter = '{categoryLetter}', Price = {price}, Description = '{description}', Weight = {weight}, SupplierID = {supplierID} WHERE SpareID = '{spareID}'";
                Main.db.updateBySql(query);
                Main.ShowMessage(Resources.Successful_editing);

                ClearForm();
            }
            else
            {
                Main.ShowMessage(Resources.Please_provide_complete_data);
            }


        }
        private bool ValidateInput()
        {
            return comboBoxSpareID.SelectedItem != null &&
                   comboBoxSpareType.SelectedItem != null &&
                   !string.IsNullOrEmpty(txtSpareName.Text) &&
                   !string.IsNullOrEmpty(txtPrice.Text) &&
                   !string.IsNullOrEmpty(txtSpareWeight.Text) &&
                   comboBoxSupplier.SelectedItem != null;
        }
        private int GetSupplierIDByName(string supplierName)
        {
            string sql = $"SELECT SupplierID FROM Supplier WHERE Name = '{supplierName}'";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            return 0;
        }
        private void ClearForm()
        {
            txtSpareName.Text = string.Empty;
            txtPrice.Text = "0.00";
            txtSpareWeight.Text = "0";
            txtDescription.Text = string.Empty;
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
            if (comboBoxSpareID.SelectedItem != null)
            {
                string spareID = comboBoxSpareID.SelectedItem.ToString();
                string query = $"UPDATE Spare SET State = 'D' WHERE SpareID = '{spareID}'";
                Main.db.updateBySql(query);
                Main.ShowMessage(Resources.Item_successfully_deleted);

                // Refresh the SpareID list after deletion
                frmEditItem_Load(sender, e);
                (this.ParentForm as Main)?.refreshPage(sender, e);

            }
            else
            {
                Main.ShowMessage(Resources.Please_select_an_item_to_delet);
            }
        }
    }
}
