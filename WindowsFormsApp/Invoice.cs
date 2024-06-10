using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmSignature));
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void frmInvoice_Resize(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.ResizeControlsFont(this);
        }
    }
}
