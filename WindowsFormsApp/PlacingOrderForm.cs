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
