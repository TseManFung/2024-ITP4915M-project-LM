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
    public partial class frmReStockCheck : Form
    {
        DataTable RestockOrder;
        private int clickedRowIndex = -1;
        private int clickedColumnIndex = -1;

        string sql_getwarehouse;
        int respent_warehouse;

        public frmReStockCheck()
        {
            InitializeComponent();
        }
        private void getData()
        {
            sql_getwarehouse = $"SELECT d.WarehouseID FROM User u inner join Staff s on u.StaffID = s.StaffID inner join Department d on s.DeptID = d.DeptID  where u.UserID={Main.userID};";
            using (var reader = Main.db.readBySql(sql_getwarehouse))
            {
                reader.Read();
                respent_warehouse = reader.GetInt32(0);
            }
            string sql = $"SELECT ro.RestockOrderID, ri.ItemID, ri.Quantity, ri.State FROM RestockOrder ro JOIN RestockItem ri ON ro.RestockOrderID = ri.RestockOrderID WHERE ro.WarehouseID = {respent_warehouse};";
            
            RestockOrder = Main.db.GetDataTable(sql);



        }
        private void frmReStockCheck_Load(object sender, EventArgs e)
        {
            getData();

            if (RestockOrder == null)
            {

                MessageBox.Show("No RestockOrder ");
                return;
            }

            foreach (DataRow row in RestockOrder.Rows)
            {
                if (row["State"].ToString() == "C")
                {
                    row["State"] = "Create order";
                }
                else if (row["State"].ToString() == "F")
                {
                    row["State"] = "this order is finished";
                }
            }
            try
            {

                dataGridViewItemHaveArrivedInROL.DataSource = RestockOrder.AsEnumerable().CopyToDataTable();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("No data found");
            }
        }

        private void dataGridViewItemHaveArrivedInROL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFollowingROL_Click(object sender, EventArgs e)
        {

        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog("Are you sure you want to receive it?"))
            {

                if (clickedRowIndex >= 0 && clickedColumnIndex >= 0)
                {
                    // 获取被点击单元格的 RestockOrderID 值
                    int restockOrderId;
                    int Quantity;
                    string id = string.Empty;
                    string State = string.Empty;
                    if (int.TryParse(dataGridViewItemHaveArrivedInROL.Rows[clickedRowIndex].Cells["RestockOrderID"].Value.ToString(), out restockOrderId))
                    {
                    }
                    else
                    {
                    }
                    if (int.TryParse(dataGridViewItemHaveArrivedInROL.Rows[clickedRowIndex].Cells["Quantity"].Value.ToString(), out Quantity))
                    {
                    }
                    else
                    {
                    }
                    id = dataGridViewItemHaveArrivedInROL.Rows[clickedRowIndex].Cells["ItemID"].Value.ToString();
                    State = dataGridViewItemHaveArrivedInROL.Rows[clickedRowIndex].Cells["State"].Value.ToString();
                    if (State != "this order is finished")
                    {
                        string sql = $"update RestockItem SET State = 'F' where RestockOrderID = {restockOrderId};";
                        Main.db.updateBySql(sql);
                        sql = $"update Stock SET quantity = quantity + {Quantity} where SpareID = '{id}'";
                        Main.db.updateBySql(sql);
                        sql = $"update ActualStock SET quantity = quantity + {Quantity} where SpareID = '{id}' AND WarehouseID = {respent_warehouse}";
                        Main.db.updateBySql(sql);
                        Main.ShowMessage($"The RestockOrderID: {restockOrderId} is Received");
                        Form currentForm = this;

                        // 关闭当前 Form
                        currentForm.Close();

                        // 重新创建并显示当前 Form
                        currentForm = new frmReStockCheck();
                        currentForm.Show();

                    }
                    else
                    {
                        Main.ShowMessage($"The RestockOrderID: {restockOrderId} is already received");
                    }
                }
                else
                {
                    MessageBox.Show("No cell has been clicked yet.");
                }
            }
        }

        private void dataGridViewItemHaveArrivedInROL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedRowIndex = e.RowIndex;
            clickedColumnIndex = e.ColumnIndex;
        }
    }
}
