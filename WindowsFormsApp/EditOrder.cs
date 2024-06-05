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
    public partial class frmEditOrder : Form
    {
        string orderserial;
        public frmEditOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = tableLayoutPanel4.Visible = tableLayoutPanel8.Visible = true;
            tableLayoutPanel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = tableLayoutPanel4.Visible = tableLayoutPanel8.Visible = false;
            tableLayoutPanel5.Visible = true;
        }

        private void frmEditOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
