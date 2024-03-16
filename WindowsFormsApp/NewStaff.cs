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
    public partial class frmNewStaff : Form
    {
        public frmNewStaff()
        {
            InitializeComponent();
        }

        private void frmNewStaff_Load(object sender, EventArgs e)
        {

        }



        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowTable();
        }

        private void ShowTable()
        {
            tableLayoutPanel1.Visible = radYes.Checked;
            tableLayoutPanel12.Visible = radNo.Checked;

        }

    }
}
