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
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel6.Visible = tableLayoutPanel7.Visible = ForTest;
            tableLayoutPanel9.Visible = tableLayoutPanel10.Visible = tableLayoutPanel11.Visible = tableLayoutPanel13.Visible = !ForTest;
        }


    }
}
