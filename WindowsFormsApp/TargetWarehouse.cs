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
        private string Msg;
        public TargetWarehouse()
        {
            InitializeComponent();
        }

        private void TargetWarehouse_Load(object sender, EventArgs e)
        {
            List<string> WarehouseNamelist = new List<string>();
            String sql = $"SELECT Location FROM Warehouse;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    WarehouseNamelist.Add(reader.GetString(0));
                }
            }
            this.comboBoxWarehouseName.DataSource = WarehouseNamelist;
            this.comboBoxWarehouseName.DisplayMember = "SupplierName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Msg = comboBoxWarehouseName.SelectedItem.ToString();
        }

        private void input_Click(object sender, EventArgs e)
        {

        }
        public string GetMsg()
        {
            return Msg;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
