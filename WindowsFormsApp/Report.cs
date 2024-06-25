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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportCondition reportCondition = new reportCondition(this.ParentForm as Main);
            reportCondition.ShowDialog();
            CoditionDict = reportCondition.CoditionDict;
            foreach (KeyValuePair<string, Object> kvp in CoditionDict)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
