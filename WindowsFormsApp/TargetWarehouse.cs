using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace WindowsFormsApp
{
    public partial class TargetWarehouse : Form
    {
        public string Msg { get; set; }
        public TargetWarehouse()
        {
            InitializeComponent();
        }

        private void TargetWarehouse_Load(object sender, EventArgs e)
        {
            List<string> WarehouseNamelist = new List<string>();
            String sql = $"SELECT Name,Location FROM Warehouse;";
            var dt = Main.db.GetDataTable(sql);
            comboBoxWarehouseName.Items.AddRange(dt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Name")+" | " + dr.Field<string>("Location")).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            return_data();
        }
        private void return_data()
        {
            if (comboBoxWarehouseName.SelectedItem == null)
            {
                return;
            }
            Msg = comboBoxWarehouseName.SelectedItem.ToString();
        }

        private void input_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TargetWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            return_data();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
