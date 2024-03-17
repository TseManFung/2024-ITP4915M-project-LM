using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            frmDeliveryStatusandProductDetails frm = new frmDeliveryStatusandProductDetails();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            flow.Controls.Add(frm);
            frm.Show();
            frmDeliveryStatusandProductDetails frm2 = new frmDeliveryStatusandProductDetails();
            frm2.TopLevel = false;
            frm2.TopMost = true;
            frm2.Anchor = AnchorStyles.None;
            frm2.FormBorderStyle = FormBorderStyle.None;
            flow.Controls.Add(frm2);
            frm2.Show();
        }
    }
}
