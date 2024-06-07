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
    public partial class frmSignature : Form
    {
        public frmSignature()
        {
            InitializeComponent();
        }

        private void frmSignature_Load(object sender, EventArgs e)
        {
            load_sign_form();
        }

        private void load_sign_form()
        {
            frmSign frm = new frmSign();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            PSign.Controls.Clear();
            PSign.Controls.Add(frm);
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ((Form)PSign.Controls[0]).Close();
            load_sign_form();
        }
    }
}
