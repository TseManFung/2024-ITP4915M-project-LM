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
    public partial class frmDISet : Form
    {
        public frmDISet()
        {
            InitializeComponent();
        }

        private void frmDISet_Load(object sender, EventArgs e)
        {
            frmDID frm = new frmDID();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel1.Controls.Add(frm);
            frm.Show();
            frmDID frm2 = new frmDID();
            frm2.TopLevel = false;
            frm2.TopMost = true;
            frm2.Anchor = AnchorStyles.None;
            frm2.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel1.Controls.Add(frm2);
            frm2.Show();
        }


    }
}
