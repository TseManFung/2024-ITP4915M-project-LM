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


        private void FrmDirectory_Load(object sender, EventArgs e)
        {

        }





        private void CAddNewItem(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmAddNewItem));
        }

        private void CUserManagementAndAccountManagement(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmUserManagementAndAccountManagement));
        }

        private void CPlacingOrder(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmPlacingOrder));
        }

        private void COrderRecord(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmOrderRecord));
        }

        private void CScrap(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmScrap));
        }

        private void CReport(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmReport));
        }

        private void CNewSupplier(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmNewSupplier));
        }

        private void CReStockCheck(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmReStockCheck));
        }

        private void CReStock(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmReStock));
        }

        private void CCollectSpare(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmCollectSpare));
        }

        private void CEditOrder(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmEditOrder));
        }

        private void CSetStockLevel(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmSetStockLevel));
        }

        private void CLogin(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmLogin));
        }

        private void CAddSaleArea(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmAddSaleArea));
        }

        private void CEditSaleArea(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmEditSaleArea));
        }

        private void CAddDepartment(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmAddDepartment));
        }

        private void CAddWarehouse(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmAddWarehouse));
        }

        private void CEditDepartment(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmEditDepartment));
        }

        private void CEditWarehouse(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmEditWarehouse));
        }

        private void CEditSpare(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmEditItem));
        }

        private void CModifyInformation(object sender, MouseEventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmModifyInformation));
        }

        private void CChangePassword(object sender, MouseEventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmChangePassword));
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmSpareQRCode));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
