using WindowsFormsApp.Properties;
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
        int count = 0;
        public frmOrderRecord()
        {
            InitializeComponent();
        }

        List<string> ProcesingList = new List<string> { "C", "P", "W", "T" },
            CompleteList = new List<string> { "U", "F" };

        DataTable dtP, dtC;
        private void frmOrderRecord_Load(object sender, EventArgs e)
        {
            getData();

        }

        private void getData()
        {
            getData(count, 100);
        }


        // include the start and end
        private void getData(int start, int end)
        {
            string sql;
             if (Main.staffID != null)
            {
                if (Main.AssessLevel == 400)
                {
                    sql = $"SELECT OrderSerial,DealerID, OrderDate, OrderNumberfromDealer, State, remark FROM `Order` where state = 'P' limit {start},{end};";

                }
                else if (Main.AssessLevel == 700)
                {
                    sql = $"SELECT OrderSerial,DealerID, OrderDate, OrderNumberfromDealer, State, remark FROM `Order` where state = 'T' limit {start},{end};";

                }
                else
                {
                    sql = $"SELECT OrderSerial,DealerID, OrderDate, OrderNumberfromDealer, State, remark FROM `Order` limit {start},{end};";

                }
            }
            else if (Main.dealerID != null)
            {
                sql = $"SELECT OrderSerial, OrderDate, OrderNumberfromDealer, State, remark FROM `Order` Where DealerID = {Main.dealerID} limit {start},{end};";
            }
            else { throw new Exception(Resources.No_DealerID_or_StaffID); }

            DataTable dt = Main.db.GetDataTable(sql);
            DataColumn dcRowString = dt.Columns.Add("_RowString",typeof(string));
            foreach (DataRow dataRow in dt.Rows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    sb.Append(dataRow[i].ToString());
                    sb.Append("\t");
                }
                dataRow[dcRowString] = sb.ToString();
            }

            // Add columns to the DataGridView controls if they don't exist
            if (dgvProcessing.Columns.Count == 0)
            {
                dtP = new DataTable();
                dtP.Columns.Add("OrderSerial", typeof(string));
                if (Main.staffID != null) { dtP.Columns.Add("DealerID", typeof(int)); }
                dtP.Columns.Add("OrderDate", typeof(DateTime));
                dtP.Columns.Add("OrderNumberfromDealer", typeof(string));
                dtP.Columns.Add("State", typeof(string));
                dtP.Columns.Add("remark", typeof(string));
                dtP.Columns.Add("_RowString", typeof(string));
                dgvProcessing.DataSource = dtP;
                dgvProcessing.Columns["_RowString"].Visible = false;
            }

            if (dgvComplete.Columns.Count == 0)
            {
                dtC = new DataTable();
                dtC.Columns.Add("OrderSerial", typeof(string));
                if (Main.staffID != null) { dtC.Columns.Add("DealerID", typeof(int)); }
                dtC.Columns.Add("OrderDate", typeof(DateTime));
                dtC.Columns.Add("OrderNumberfromDealer", typeof(string));
                dtC.Columns.Add("State", typeof(string));
                dtC.Columns.Add("remark", typeof(string));
                dtC.Columns.Add("_RowString", typeof(string));
                dgvComplete.DataSource = dtC;
                dgvComplete.Columns["_RowString"].Visible = false;
            }

            //State 在 ProcesingList 的就放入dgvProcessing，在否則就放入dgvComplete

             if (Main.staffID != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (ProcesingList.Contains(row["State"].ToString()))
                    {
                        dtP.Rows.Add(row["OrderSerial"], row["DealerID"], row["OrderDate"], row["OrderNumberfromDealer"], row["State"], row["remark"], row["_RowString"]);
                    }
                    else if (CompleteList.Contains(row["State"].ToString()))
                    {
                        dtC.Rows.Add(row["OrderSerial"], row["DealerID"], row["OrderDate"], row["OrderNumberfromDealer"], row["State"], row["remark"], row["_RowString"]);
                    }
                }
            }
            else if (Main.dealerID != null)
            {

                foreach (DataRow row in dt.Rows)
                {
                    if (ProcesingList.Contains(row["State"].ToString()))
                    {
                        dtP.Rows.Add(row["OrderSerial"], row["OrderDate"], row["OrderNumberfromDealer"], row["State"], row["remark"], row["_RowString"]);
                    }
                    else if (CompleteList.Contains(row["State"].ToString()))
                    {
                        dtC.Rows.Add(row["OrderSerial"], row["OrderDate"], row["OrderNumberfromDealer"], row["State"], row["remark"], row["_RowString"]);
                    }
                }
            }
            count += end;
        }

        private void dgvProcessing_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollBar vs = dgvProcessing.Controls.OfType<VScrollBar>().First();

            if (e.NewValue >= (vs.Maximum - vs.LargeChange) / 20 - 1)
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

        private void dgvComplete_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                string OrderSerial = dgvComplete.Rows[e.RowIndex].Cells["OrderSerial"].Value.ToString();
                frmOrderDetail frm = new frmOrderDetail(OrderSerial);
                (this.ParentForm as Main)?.Change_pContent(frm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtC.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
            dtP.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
        }

        private void dgvProcessing_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                string OrderSerial = dgvProcessing.Rows[e.RowIndex].Cells["OrderSerial"].Value.ToString();
                frmOrderDetail frm = new frmOrderDetail(OrderSerial);
                (this.ParentForm as Main)?.Change_pContent(frm);
            }
        }

    }
}
