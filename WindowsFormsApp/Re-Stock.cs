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

    public partial class frmReStock : Form
    {
        DataTable RestockOrder;
        public frmReStock()
        {
            InitializeComponent();
        }

        private void lblFollowingROL_Click(object sender, EventArgs e)
        {

        }

        private void dgvItemFollowingROL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void getData()
        {
            string table = "RestockOrder";
            RestockOrder = Main.db.getTable(table);

        }
        private void frmReStock_Load(object sender, EventArgs e)
        {
            getData();

            if (RestockOrder == null)
            {
                // 在此处进行 RestockOrder 数据源的初始化
                // 或者根据您的需求，处理数据源为 null 的情况
                // 例如，显示错误消息或执行其他操作
                MessageBox.Show("RestockOrder 数据源为空。");
                return;
            }

            try
            {
                // 继续进行数据绑定操作
                dgvItemFollowingROL.DataSource = RestockOrder.AsEnumerable()
                    .Select(row =>
                    {
                        if (row["Remark"] == null || row["Remark"] == DBNull.Value)
                        {
                            row["Remark"] = "No Remark.";
                        }
                        return row;
                    })
                    .CopyToDataTable();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("No data found");
            }
        }
    }
}
