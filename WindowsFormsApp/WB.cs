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
    public partial class WB : Form
    {
        public WB()
        {
            InitializeComponent();
        }

        private void btnUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGo_Click(sender, e);
                e.Handled = true;

            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/";
            if (txtUrl.Text != String.Empty)
            {
                if (txtUrl.Text.Contains("http"))
                {
                    url = txtUrl.Text;
                }
                else
                {
                    url = $@"https://www.google.com/search?q={txtUrl.Text.Replace(" ", "+")}";
                }
            }
            WBMain.LoadUrl(url);
        }
    }
}
