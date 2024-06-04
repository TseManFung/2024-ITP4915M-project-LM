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
    public partial class frmOrderRecord : Form
    {
        public frmOrderRecord()
        {
            InitializeComponent();
        }

        List<string> ProcesingList = new List<string> {"C","P","W","T"},
            CompleteList = new List<string> { "U","F"};

        private void frmOrderRecord_Load(object sender, EventArgs e)
        {
            
        }

        private void getData()
        {
            string sql = $"SELECT OrderSerial, OrderDate, OrderNumberfromDealer, State, remark FROM Order Where DealerID = {Main.dealerID}";
            DataTable dt = Main.db.GetDataTable(sql);
            dgvOrderRecord.DataSource = dt;
        }
    }
}
