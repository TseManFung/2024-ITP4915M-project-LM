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
            getData();
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
    }
}
