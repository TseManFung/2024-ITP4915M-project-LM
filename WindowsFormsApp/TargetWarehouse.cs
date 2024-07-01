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
        private bool state = false;
        public string Msg { get; set; }
        public TargetWarehouse()
        {
            InitializeComponent();
        }
        public bool Getstate()
        {
            return state;
        }
        private Dictionary<string, string> warehouseDictionary = new Dictionary<string, string>();
        private void TargetWarehouse_Load(object sender, EventArgs e)
        {
            String sql = "SELECT Name, Location FROM Warehouse Where State = 'N';";
            var dt = Main.db.GetDataTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                string name = dr.Field<string>("Name");
                string location = dr.Field<string>("Location");

                // Add to dictionary
                warehouseDictionary[name] = location;

                // Add only name to comboBox
                comboBoxWarehouseName.Items.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            state = true;
            return_data();
        }
        private void return_data()
        {
            if (comboBoxWarehouseName.SelectedItem == null)
            {
                return;
            }
            // Get the selected name
            string selectedName = comboBoxWarehouseName.SelectedItem.ToString();

            // Get the corresponding location from the dictionary
            if (warehouseDictionary.TryGetValue(selectedName, out string correspondingLocation))
            {
                Msg = correspondingLocation;
            }
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
