using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmCollectSpare : Form
    {
        int whID;
        string OrderSerial;

        public frmCollectSpare()
        {
            InitializeComponent();
        }

        private void btnscanner_Click(object sender, EventArgs e)
        {
            using (frmWebcam webcam = new frmWebcam())
            {
                webcam.ShowDialog();
                string code = webcam.scanCode;
                Console.WriteLine(code);
                //if can not find the code in the collect list
                if (!comboBoxSpareID.Items.Contains(code))
                {
                    Main.ShowMessage("The spare is not in the collect list");
                    return;
                }
                comboBoxSpareID.SelectedItem = code;
            }

        }

        private void frmCollectSpare_Load(object sender, EventArgs e)
        {
            string sql = $@"SELECT
  IF(d.WarehouseID IS NULL, -1, d.WarehouseID) AS WarehouseID
FROM Staff s
JOIN Department d ON s.DeptID = d.DeptID  
WHERE s.StaffID = {Main.staffID}";
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();

                whID = Convert.ToInt32(reader["WarehouseID"]);

            }
            getData();
        }

        private void getData()
        {
            string
sql = $@"SELECT 
  OrderSerial
FROM OrderItemForCollect
WHERE Assgin = {whID} AND State = 'W'  
GROUP BY OrderSerial
ORDER BY OrderSerial ASC
limit 0,1";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    OrderSerial = reader["OrderSerial"].ToString();
                }
                else
                {
                    Main.ShowMessage("No Order to Collect");
                    return;
                }
            }

            sql = $@"UPDATE OrderItemForCollect 
SET State = 'C'
WHERE OrderSerial = '{OrderSerial}' 
  AND Assgin = {whID}
  AND State = 'W'";
            Main.db.updateBySql(sql);
            sql = $@"SELECT 
  o.OrderSerial,
  o.ItemID,
  s.SpareName,
  o.Quantity
FROM OrderItemForCollect o
JOIN Spare s ON o.ItemID = s.SpareID
WHERE OrderSerial = '{OrderSerial}' 
  AND Assgin = {whID}
  AND o.State = 'C'";
            var dt = Main.db.GetDataTable(sql);
            dgvCollect.DataSource = dt;
            dgvCollect.Columns["OrderSerial"].Visible = false;
            comboBoxSpareID.Items.AddRange(dt.AsEnumerable().Select(x => x["ItemID"].ToString()).ToArray());
        }

        private void frmCollectSpare_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql = $@"UPDATE OrderItemForCollect 
SET State = 'W'
WHERE OrderSerial = '{OrderSerial}' 
  AND Assgin = {whID}
  AND State = 'C'";
            Main.db.updateBySql(sql);
        }

        private void dgvCollect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // selete this row's ItemID in the comboBoxSpareID
            comboBoxSpareID.SelectedItem = dgvCollect.Rows[e.RowIndex].Cells["ItemID"].Value;
        }
    }
}
