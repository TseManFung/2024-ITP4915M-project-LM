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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void FrmDirectory_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_MouseClick(object sender, MouseEventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmEditItem));
        }



        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmAddNewItem));
        }

        private void tableLayoutPanel9_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmUserManagementAndAccountManagement));
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmPlacingOrder));
        }

        private void pictureBoxCheckOrder_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmOrderRecord));
        }

        private void tableLayoutPanel13_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmScrap));
        }



        private void tableLayoutPanel7_Click(object sender, EventArgs e)
        {
            //(this.ParentForm as Main)?.Change_pContent(typeof(frmLogin));
            
        }

        private void tableLayoutPanel5_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmReport));
        }
    }
}
