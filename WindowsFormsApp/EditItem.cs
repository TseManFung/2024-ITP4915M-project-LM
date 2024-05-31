using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class frmEditItem : Form
    {
        public frmEditItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            
        }

        private void comboBoxSpareID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            List<string> SpareIDlist = new List<string>();
            String sql = $"SELECT SpareID FROM Spare;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    SpareIDlist.Add(reader.GetString(0));
                }
            }
            this.comboBoxSpareID.DataSource = SpareIDlist;
            this.comboBoxSpareID.DisplayMember = "SpareID";
        }
    }
}
