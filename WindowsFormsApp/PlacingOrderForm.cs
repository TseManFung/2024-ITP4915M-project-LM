using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmPlacingOrder : Form
    {
        DataTable Spare;
        public frmPlacingOrder()
        {
            InitializeComponent();
        }

        private void getData()
        {
            string sql = "select s.SpareID as SpareID,CategoryLetter,SpareName,Price,Weight,quantity from Spare s inner join Stock on s.SpareID =Stock.SpareID;";
            var conn = Main.db.get_dbconnect();
            Spare = new DataTable();

            using (var da = new MySqlDataAdapter(sql, conn))
            {
                da.Fill(Spare);
            }

            using (var sid = Spare.Columns["SpareID"])
            {
                comboBoxSpareID.Items.Clear();
                comboBoxSpareID.Items.AddRange(Spare.AsEnumerable().Select(x => x[sid].ToString()).ToArray());
            }
            using (var sn = Spare.Columns["SpareName"])
            {
                comboBoxSpareName.Items.Clear();
                comboBoxSpareName.Items.AddRange(Spare.AsEnumerable().Select(x => x[sn].ToString()).ToArray());
            }
            //comboBoxSpareID.DataSource = Spare;
            //comboBoxSpareID.DisplayMember = "SpareID"; 
            //comboBoxSpareID.ValueMember = "SpareID"; 
            //comboBoxCategoryType.DataSource = Spare;
            //comboBoxCategoryType.DisplayMember = "CategoryLetter";
            //comboBoxCategoryType.ValueMember = "CategoryLetter";
            //comboBoxSpareName.DataSource = Spare;
            //comboBoxSpareName.DisplayMember = "SpareName";
            //comboBoxSpareName.ValueMember = "SpareName";
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmCart));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sid = comboBoxSpareID.Text, ct = comboBoxCategoryType.Text, sn = comboBoxSpareName.Text.ToLower();

            try
            {
                dgvPlacingOrder.DataSource = Spare.AsEnumerable().Where(x =>
                ((x["quantity"] as int?) > 0) &&
                (sid == "" || x["SpareID"].ToString() == sid) &&
                (ct == "" || x["CategoryLetter"].ToString() == ct) &&
                (x["SpareName"].ToString().ToLower().IndexOf(sn) > -1)).CopyToDataTable();
                txtSelectedSpareName.Text = dgvPlacingOrder.Rows[0].Cells["SpareID"].Value.ToString();
                numQuantity.Value = 1;
                numQuantity.Maximum = getStock(txtSelectedSpareName.Text);
                tlpSelectSpace.Visible = true;
            }
            catch (InvalidOperationException ex) { MessageBox.Show("No data found"); }
        }

        private void dgvPlacingOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sid = dgvPlacingOrder.Rows[e.RowIndex].Cells["SpareID"].Value.ToString();
            if (sid != txtSelectedSpareName.Text)
            {
                txtSelectedSpareName.Text = sid;
                numQuantity.Value = 1;
                numQuantity.Maximum = getStock(txtSelectedSpareName.Text);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            change_qty(1);
        }
        private void btnReduce_Click(object sender, EventArgs e)
        {
            change_qty(-1);
        }

        public int getStock(string sid)
        {
            var rows = Spare.Select("SpareID = '" + txtSelectedSpareName.Text + "'");
            if (rows.Length > 0)
            {
                var row = rows[0];
                int stock = row.Field<int>("quantity");
                return stock;

            }
            throw new Exception("No stock found");
        }

        private void change_qty(int change)
        {
            decimal qty = numQuantity.Value;
            //get the quantity of the selected item
            // 要優化 未完成
            try
            {
                numQuantity.Value = Math.Floor(qty + change);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
//UserID int PK
//SpareID char(6) PK
//Qty int
           Main.db.insert("Cart",new )
        }

        private void frmPlacingOrder_Load(object sender, EventArgs e)
        {
            numQuantity.Controls[0].Visible = false;
            getData();
        }
    }
}
