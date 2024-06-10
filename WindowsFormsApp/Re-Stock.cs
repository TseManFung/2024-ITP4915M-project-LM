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

    public partial class frmReStock : Form
    {
        DataTable RestockOrder;
        public frmReStock()
        {
            InitializeComponent();
        }

        private void lblFollowingROL_Click(object sender, EventArgs e)
        {

        }

        private void dgvItemFollowingROL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void getData()
        {
            int respent_warehouse = 0;
            string sql_getwarehouse = $"SELECT d.WarehouseID FROM User u inner join Staff s on u.StaffID = s.StaffID inner join Department d on s.DeptID = d.DeptID  where u.UserID={Main.userID};";
            using (var reader = Main.db.readBySql(sql_getwarehouse))
            {
                reader.Read();
                respent_warehouse = reader.GetInt32(0);
            }
            string sql = $"SELECT ws.WarehouseID, ws.SpareID, a.quantity FROM WarehouseStockLevel ws JOIN ActualStock a ON ws.WarehouseID = a.WarehouseID AND ws.SpareID = a.SpareID WHERE a.quantity <= ws.ROL AND a.WarehouseID = {respent_warehouse};";
            RestockOrder = Main.db.GetDataTable(sql);

        }

        private void frmReStock_Load(object sender, EventArgs e)
        {

            getData();

            if (RestockOrder == null)
            {

                MessageBox.Show("No ROL item");
                return;
            }

            try
            {
                dgvItemFollowingROL.DataSource = RestockOrder.AsEnumerable().CopyToDataTable();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("No data found");
            }
        }
    }
}
