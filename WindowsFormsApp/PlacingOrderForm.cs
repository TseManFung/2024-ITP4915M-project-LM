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
    public partial class frmPlacingOrder : Form
    {
        public frmPlacingOrder()
        {
            InitializeComponent();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmCart));
        }
    }
}
