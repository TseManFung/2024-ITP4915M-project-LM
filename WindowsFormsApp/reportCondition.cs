using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class reportCondition : Form
    {
        Main main;
        DataTable Dealer, Spare;
        public Dictionary<string,Object> CoditionDict { set; get; }
        public reportCondition(Main main)
        {
            InitializeComponent();
            this.main = main;
            main.ResizeControlsFont(this);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;

        }

        private void reportCondition_Resize(object sender, EventArgs e)
        {
            main.ResizeControlsFont(this);
        }

        private void reportCondition_Load(object sender, EventArgs e)
        {
            getData();
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = comboBox3.SelectedIndex = comboBox4.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void return_data()
        {
            CoditionDict = new Dictionary<string, object>();
            if (radioButton1.Checked)
            {
                CoditionDict.Add("only", true);
            }
            else
            {
                CoditionDict.Add("only", false);
            }
            if (comboBox1.SelectedIndex != -1)
            {
                List<string> list = new List<string>() { "<", "<=", "=", ">=", ">" };
                CoditionDict.Add("quantity_operator", list[comboBox1.SelectedIndex]);
                CoditionDict.Add("quantity", numericUpDown1.Value);
            }
            if (comboBox2.SelectedIndex != -1)
            {

                CoditionDict.Add("SpareID", $"'{comboBox2.SelectedValue.ToString()}'");

            }
            if (comboBox3.SelectedIndex != -1)
            {

                CoditionDict.Add("Type", $"'{comboBox3.SelectedItem.ToString()}'");

            }
            if (comboBox4.SelectedIndex != -1)
            {

                CoditionDict.Add("DealerID", comboBox4.SelectedValue);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            return_data();

            this.Close();
        }

        private void reportCondition_FormClosing(object sender, FormClosingEventArgs e)
        {
            return_data();
        }

        private void getData()
        {
            string sql;

            sql = @"SELECT DealerID, DealerName FROM Dealer;";
            Dealer = Main.db.GetDataTable(sql);

            sql = @"SELECT SpareID,SpareName FROM Spare;";
            Spare = Main.db.GetDataTable(sql);

            comboBox4.DataSource = Dealer;
            comboBox4.DisplayMember = "DealerName";
            comboBox4.ValueMember = "DealerID";
            comboBox2.DataSource = Spare;
            comboBox2.DisplayMember = "SpareName";
            comboBox2.ValueMember = "SpareID";

            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;


        }
    }
}
