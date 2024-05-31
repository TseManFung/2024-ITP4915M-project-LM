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
            this.txtPrice.Text = string.Format("{0:#,##0.00}", Convert.ToDouble(input));
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
    }
}
