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
    public partial class frmUserManagementAndAccountManagement : Form
    {
        public frmUserManagementAndAccountManagement()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(accForD.Checked){
                (this.ParentForm as Main)?.Change_pContent(typeof(frmNewDealer));
            }
            if (accForS.Checked) { 
                (this.ParentForm as Main)?.Change_pContent(typeof(frmNewStaff)); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //only menager can see this button
            (this.ParentForm as Main)?.Change_pContent(typeof(frmAccountManagement));
        }
    }
}
