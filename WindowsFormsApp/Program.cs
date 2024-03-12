using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDirectory());
            Application.Run(new frmCheckOrder());
            Application.Run(new frmOrderStatus());
            Application.Run(new frmStatusDetail());
            Application.Run(new frmDISet());
            Application.Run(new frmAddNewItem());
            Application.Run(new frmGRN());
            Application.Run(new frmInvoice());
            Application.Run(new frmLogin());
            Application.Run(new frmNewDealer());
            Application.Run(new frmNewStaff());
            Application.Run(new frmPlacingOrderForm());
            Application.Run(new frmReorderSparePartsShippingDepartment());
            Application.Run(new frmReOrderPurchasingDepartment());
            Application.Run(new frmReport());
            Application.Run(new frmUserManagementAndAccountManagement());
        }
    }
}
