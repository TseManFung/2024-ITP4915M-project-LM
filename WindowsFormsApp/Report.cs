using System;
using System.Collections;
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
    public partial class frmReport : Form
    {
        Dictionary<string, Object> CoditionDict;
        public frmReport()
        {
            InitializeComponent();
            CoditionDict = new Dictionary<string, object>() { { "only", true } };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportCondition reportCondition = new reportCondition(this.ParentForm as Main);
            reportCondition.ShowDialog();
            CoditionDict = reportCondition.CoditionDict;
            string s = "Condition: ";
            foreach (KeyValuePair<string, Object> kvp in CoditionDict)
            {
                if (kvp.Key == "quantity_operator")
                {
                    continue;
                }
                if (kvp.Key == "only")
                {
                    if ((bool)kvp.Value)
                    {
                        s += "your working warehouse";
                    }
                    else
                    {
                        s += "all warehouse";
                    }
                }
                else
                {
                    s += " and ";
                    s += kvp.Key + " ";
                    if (kvp.Key == "quantity")
                    {
                        s += CoditionDict["quantity_operator"] + " ";
                    }
                    else
                    {
                        s += "= ";
                    }
                    s += kvp.Value;
                }
            }
            lblCondition.Text = s;
            //update report
            GenReport();
        }

        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update report
            GenReport();
        }
        private void GenReport()
        {
            //generate report
            if (comboBoxReportType.SelectedIndex == -1)
            {
                //Main.ShowMessage("Please select report type");
                return;
            }
            string codition = lblCondition.Text.Replace("Condition:", "");
            string start = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
            string end = dateTimePickerEnd.Value.ToString("yyyy-MM-dd");

            string sql = $@"SELECT
  IF(d.WarehouseID IS NULL, -1, d.WarehouseID) AS WarehouseID
FROM Staff s
JOIN Department d ON s.DeptID = d.DeptID  
WHERE s.StaffID = {Main.staffID}";
            int warehouseID;
            using (var reader = Main.db.readBySql(sql))
            {
                reader.Read();

                warehouseID = reader.GetInt32(0);

            }


            if (comboBoxReportType.SelectedIndex == 0)
            {
                sql = $@"SELECT 
a.WarehouseID,
w.Name,
sum(a.Quantity) as 'Total Quantity',
SUM(o.PriceInOrder * a.Quantity) AS 'Total Sales'
FROM ActualQuantityDespatched a
JOIN Invoice i ON a.InvoiceID = i.InvoiceID
JOIN OrderItem o ON i.OrderSerial = o.OrderSerial AND a.ItemID = o.ItemID   
JOIN `Order` ord ON i.OrderSerial = ord.OrderSerial
JOIN Warehouse w ON a.WarehouseID = w.WarehouseID
WHERE i.CompleteState = 'S'
  AND i.InvoiceDate BETWEEN '{start}' AND '{end}'  ";
                if (CoditionDict.ContainsKey("only") && (bool)CoditionDict["only"] && (warehouseID != -1))
                {
                    sql += " AND a.WarehouseID = " + warehouseID;
                }
                if (CoditionDict.ContainsKey("quantity_operator"))
                {
                    sql += " AND a.Quantity " + CoditionDict["quantity_operator"] + " " + CoditionDict["quantity"];
                }
                if (CoditionDict.ContainsKey("SpareID"))
                {
                    sql += " AND a.ItemID = " + CoditionDict["SpareID"];
                }
                if (CoditionDict.ContainsKey("DealerID"))
                {
                    sql += " AND ord.DealerID = " + CoditionDict["DealerID"];
                }
                sql +=" GROUP BY a.WarehouseID";

                DataTable dt = Main.db.GetDataTable(sql);
                dgvPreview.DataSource = dt;

                tableLayoutPanel4.Visible = tableLayoutPanel6.Visible = tableLayoutPanel7.Visible =  true;
                txtTotalNumberofDistinctItem.Text = dt.Rows.Count.ToString();
                txtTotalPrice.Text = dt.Compute("SUM([Total Sales])", "").ToString();
                txtTotalNumberofItem.Text = dt.Compute("SUM([Total Quantity])", "").ToString();
            }
            else if (comboBoxReportType.SelectedIndex == 1)
            {
                sql = $@"SELECT
a.ItemID,
  s.SpareName,
sum(a.Quantity) as 'Total Quantity',
  SUM(o.PriceInOrder * a.Quantity) AS 'Total Sales'
FROM ActualQuantityDespatched a
JOIN Invoice i ON a.InvoiceID = i.InvoiceID  
JOIN OrderItem o ON i.OrderSerial = o.OrderSerial AND a.ItemID = o.ItemID
JOIN `Order` ord ON i.OrderSerial = ord.OrderSerial
JOIN Spare s ON a.ItemID = s.SpareID
WHERE i.CompleteState = 'S'
  AND i.InvoiceDate BETWEEN '{start}' AND '{end}'  ";
                if (CoditionDict.ContainsKey("only") && (bool)CoditionDict["only"] && (warehouseID != -1))
                {
                    sql += " AND a.WarehouseID = " + warehouseID;
                }
                if (CoditionDict.ContainsKey("quantity_operator"))
                {
                    sql += " AND a.Quantity " + CoditionDict["quantity_operator"] + " " + CoditionDict["quantity"];
                }
                if (CoditionDict.ContainsKey("SpareID"))
                {
                    sql += " AND a.ItemID = " + CoditionDict["SpareID"];
                }
                if (CoditionDict.ContainsKey("Type"))
                {
                    sql += " AND s.CategoryLetter = " + CoditionDict["Type"];
                }
                if (CoditionDict.ContainsKey("DealerID"))
                {
                    sql += " AND ord.DealerID = " + CoditionDict["DealerID"];
                }
                sql += " GROUP BY a.ItemID";
                DataTable dt = Main.db.GetDataTable(sql);
                dgvPreview.DataSource = dt;

                tableLayoutPanel4.Visible = tableLayoutPanel6.Visible = tableLayoutPanel7.Visible = true;
                txtTotalNumberofDistinctItem.Text = dt.Rows.Count.ToString();
                txtTotalPrice.Text = dt.Compute("SUM([Total Sales])", "").ToString();
                txtTotalNumberofItem.Text = dt.Compute("SUM([Total Quantity])", "").ToString();
            }
            else if (comboBoxReportType.SelectedIndex == 2)
            {
                sql = $@"SELECT 
a.WarehouseID,
w.Name AS WarehouseName,
a.SpareID,
s.SpareName,
a.quantity 
FROM ActualStock a
JOIN Warehouse w ON a.WarehouseID = w.WarehouseID
JOIN Spare s ON a.SpareID = s.SpareID WHERE ";
                if (CoditionDict.ContainsKey("only") && (bool)CoditionDict["only"] && (warehouseID != -1))
                {
                    sql += " a.WarehouseID = " + warehouseID;
                }
                else
                {
                    sql += " 1=1";
                }
                if (CoditionDict.ContainsKey("quantity_operator"))
                {
                    sql += " AND a.quantity " + CoditionDict["quantity_operator"] + " " + CoditionDict["quantity"];
                }
                if (CoditionDict.ContainsKey("SpareID"))
                {
                    sql += " AND a.SpareID = " + CoditionDict["SpareID"];
                }
                if (CoditionDict.ContainsKey("Type"))
                {
                    sql += " AND s.CategoryLetter = " + CoditionDict["Type"];
                }

                DataTable dt = Main.db.GetDataTable(sql);
                dgvPreview.DataSource = dt;
                tableLayoutPanel4.Visible = tableLayoutPanel6.Visible =  true;
                tableLayoutPanel7.Visible = false;
                txtTotalNumberofDistinctItem.Text = dt.Rows.Count.ToString();
                txtTotalNumberofItem.Text = dt.Compute("SUM([quantity])", "").ToString();
            }
            else if (comboBoxReportType.SelectedIndex == 3)
            {

            }
        }

        private void frmReport_Resize(object sender, EventArgs e)
        {
            (this.ParentForm as Main)?.ResizeControlsFont(this);
        }
    }
}
