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
    public partial class frmAccountManagement : Form
    {
        bool ForTest = true;
        public frmAccountManagement()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string LoginName = comboBoxLoginName.SelectedItem.ToString();
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel6.Visible = tableLayoutPanel7.Visible = ForTest;
            tableLayoutPanel9.Visible = tableLayoutPanel10.Visible = tableLayoutPanel11.Visible = tableLayoutPanel13.Visible = !ForTest;
            
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            List<string> LoginNamelist = new List<string>();
            String sql = $"SELECT LoginName FROM User;";
            using (var reader = Main.db.readBySql(sql))
            {
                while (reader.Read())
                {
                    LoginNamelist.Add(reader.GetString(0));
                }
            }
            this.comboBoxLoginName.DataSource = LoginNamelist;
            this.comboBoxLoginName.DisplayMember = "LoginName";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLoginName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoginName = comboBoxLoginName.SelectedItem.ToString();
            int id = 0;
            string isid = string.Empty;
            string sql = $"SELECT DealerID  FROM User Where LoginName = '{LoginName}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        id = reader.GetInt32(0);
                        isid = "DealerID";
                    }
                }
            }
            sql = $"SELECT StaffID FROM User Where LoginName ='{LoginName}';";
            using (var reader = Main.db.readBySql(sql))
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        id = reader.GetInt32(0);
                        isid = "StaffID";
                    }
                }
            }
            Main.ShowMessage(isid);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
