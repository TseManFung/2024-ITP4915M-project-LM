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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lblPlacingOrder_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin() { TopLevel = false,TopMost =true,Anchor= AnchorStyles.None , FormBorderStyle = FormBorderStyle.None ,Dock=DockStyle.Fill};

            pContent.Controls.Add(login);
            login.Show();
            lblTitle.Text = login.Text;
        }
    }
}
