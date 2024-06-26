using Mysqlx.Crud;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        Dictionary<string, int> smallaccessMap = new Dictionary<string, int>() {
            {"Order Record", 10000 },
            {"Add New Spare", 200 },
            {"Edit Spare", 200 },
            {"Add SaleArea", 200 },
            {"Edit SaleArea", 200 },
            {"Add Department", 200 },
            {"Edit Department", 200 },
            {"Add Warehouse", 200 },
            {"Edit Warehouse", 200 },
            {"Supplier Management", 200 },
            {"User Management", 200 },
            {"Generate Spare QR-code", 600 }
        };
        
        Dictionary<string, int> equalaccessMap = new Dictionary<string, int>() {
            {"set stock level", 500 },
            {"Collect Spare", 400 },
            {"Re-Stock", 500 },
            {"scrap", 500 },
            {"Re-Stock Record", 500 },
            {"Order Edit", 600 },
            {"Report", 300 },
            {"Simulate server",0 }
        };

        Dictionary<string, int> bigaccessMap = new Dictionary<string, int>() {
            {"Place Order", 5000 },
            {"Order Edit", 5000 },
            {"Modify Information", 5000 }
        };


        private void FrmDirectory_Load(object sender, EventArgs e)
        {
            if (Main.AssessLevel == null)
            {
                String sql = $"SELECT AccessLevel FROM User WHERE UserID = {Main.userID};";
                var reader = Main.db.readBySql(sql);
                if (reader.HasRows)
                {
                    reader.Read();
                    Main.AssessLevel = Convert.ToInt32(reader[0]);
                }
                reader.Close();
            }
            List<TableLayoutPanel> tableLayoutPanels = flowLayoutPanel1.Controls.OfType<TableLayoutPanel>().ToList();


            foreach (TableLayoutPanel tableLayoutPanel in tableLayoutPanels)
            {
                if (Main.AssessLevel == 0)
                {
                    tableLayoutPanel.Visible = true;
                    continue;
                }

                Label label = tableLayoutPanel.Controls.OfType<Label>().FirstOrDefault();

                int v;
                if (smallaccessMap.TryGetValue(label.Text, out v))
                {
                    if (Main.AssessLevel <= v)
                    {
                        tableLayoutPanel.Visible = true;

                    }
                }
                if (equalaccessMap.TryGetValue(label.Text, out v))
                {
                    if (Main.AssessLevel == v)
                    {
                        tableLayoutPanel.Visible = true;

                    }
                }
                 if (bigaccessMap.TryGetValue(label.Text, out v))
                {
                    if (Main.AssessLevel >= v)
                    {
                        tableLayoutPanel.Visible = true;

                    }
                }


            }

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

        private void CLogout(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.SetLogout();
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

        private void CModifyInformation(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmModifyInformation));
        }

        private void CChangePassword(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmChangePassword));

        }

        private void CSpareQRcode(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmSpareQRCode));

        }

        private void server_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.Change_pContent(typeof(frmServer));
            //Google_map map = new Google_map();
            //map.ShowDialog();
        }
    }
}
