using MultiLang;
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
    public partial class frmForgetPW : Form
    {
        public frmForgetPW()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYouAreLMStaff.Checked)
            {
                lblDelearName.Text = ml.ml_string(354,"Your name:");
            }else
            {
                lblDelearName.Text = ml.ml_string(103,"Dealer name:");
            }
        }
    }
}
