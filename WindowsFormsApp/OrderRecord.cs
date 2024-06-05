using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmOrderRecord : Form
    {
        int count = 1;
        public frmOrderRecord()
        {
            InitializeComponent();
        }

        List<string> ProcesingList = new List<string> { "C", "P", "W", "T" },
            CompleteList = new List<string> { "U", "F" };

        private void frmOrderRecord_Load(object sender, EventArgs e)
        {
            getData();

        }

        private void getData()
        {
            getData(count, count+999);
        }


        // include the start and end
        private void getData(int start,int end)
        {
            string sql;
            if (Main.dealerID != null)
            {
                sql = $"SELECT OrderSerial, OrderDate, OrderNumberfromDealer, State, remark FROM `Order` Where DealerID = {Main.dealerID} limit {start},{end};";
            }
            else if (Main.staffID != null)
            {
                sql = $"SELECT OrderSerial, OrderDate, OrderNumberfromDealer, State, remark FROM `Order` limit {start},{end};";
            }
            else { throw new Exception("No DealerID or StaffID"); }

            DataTable dt = Main.db.GetDataTable(sql);

            // Add columns to the DataGridView controls if they don't exist
            if (dgvProcessing.Columns.Count == 0)
            {
                dgvProcessing.Columns.Add("OrderSerial", "Order Serial");
                dgvProcessing.Columns.Add("OrderDate", "Order Date");
                dgvProcessing.Columns.Add("OrderNumberfromDealer", "Order Number from Dealer");
                dgvProcessing.Columns.Add("State", "State");
                dgvProcessing.Columns.Add("remark", "Remark");
            }

            if (dgvComplete.Columns.Count == 0)
            {
                dgvComplete.Columns.Add("OrderSerial", "Order Serial");
                dgvComplete.Columns.Add("OrderDate", "Order Date");
                dgvComplete.Columns.Add("OrderNumberfromDealer", "Order Number from Dealer");
                dgvComplete.Columns.Add("State", "State");
                dgvComplete.Columns.Add("remark", "Remark");
            }

            //State 在 ProcesingList 的就放入dgvProcessing，在否則就放入dgvComplete
            foreach (DataRow row in dt.Rows)
            {
                if (ProcesingList.Contains(row["State"].ToString()))
                {
                    dgvProcessing.Rows.Add(row["OrderSerial"], row["OrderDate"], row["OrderNumberfromDealer"], row["State"], row["remark"]);
                }
                else if (CompleteList.Contains(row["State"].ToString()))
                {
                    dgvComplete.Rows.Add(row["OrderSerial"], row["OrderDate"], row["OrderNumberfromDealer"], row["State"], row["remark"]);
                }
            }
            count = end + 1;
        }

        private void dgvProcessing_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollBar vs = dgvProcessing.Controls.OfType<VScrollBar>().First();

            if (e.NewValue >= (vs.Maximum - vs.LargeChange )/20 - 1)
            {
                getData();
                Console.WriteLine("Processing");
            }
        }

        private void dgvComplete_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollBar vs = dgvComplete.Controls.OfType<VScrollBar>().First();

            if (e.NewValue >= (vs.Maximum - vs.LargeChange) / 20 - 1)
            {
                getData();
            }
        }

        private void dgvProcessing_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string OrderSerial = dgvProcessing.Rows[e.RowIndex].Cells["OrderSerial"].Value.ToString();
                frmOrderDetail frm = new frmOrderDetail(OrderSerial);
                (this.ParentForm as Main)?.Change_pContent(frm);
            }
        }


    }
}
