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
        public static sshdatabase db = new sshdatabase();
        public static int? userID;
        public static int? AssessLevel;
        public static Type currfrm;

        bool isLogin = false;

        public void SetIsLogin(int id)
        {
            this.isLogin = true;
            Main.userID = id;
        }

        public void SetLogout()
        {
            this.isLogin = false;
            Main.userID = null;
            AssessLevel =null;
        }

        public Main()
        {
            InitializeComponent();
        }



        private void Main_Load(object sender, EventArgs e)
        {
            this.Change_pContent(typeof(frmLogin));
            //this.Change_pContent(typeof(frmOrderDetail));
        }

        public void Change_pContent(Type formType)
        {
            try
            {
                pContent.Controls.Clear();
                Form frm = (Form)Activator.CreateInstance(formType);
                frm.TopLevel = false;
                frm.TopMost = true;
                frm.Anchor = AnchorStyles.None;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                pContent.Controls.Add(frm);
                frm.Show();
                lblTitle.Text = frm.Text;
                Main.currfrm = formType;

                if (formType == typeof(frmLogin) || formType == typeof(frmMenu))
                {
                    pictureBoxBack.Visible = false;
                    lblTitle.Cursor = Cursors.Arrow;
                    if (formType == typeof(frmMenu) && AssessLevel > 10000)
                    {

                        String sql = $"SELECT AccessLevel FROM User WHERE UserID = {Main.userID};";
                        var reader = Main.db.readBySql(sql);
                        if (reader.HasRows)
                        {
                            reader.Read();
                            AssessLevel = Convert.ToInt32(reader[0]);
                        }

                    }
                }
                else
                {

                    pictureBoxBack.Visible = true;
                    lblTitle.Cursor = Cursors.Hand;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void pContent_Paint(object sender, PaintEventArgs e)
        {

        }


        private void lblTitle_Click_1(object sender, EventArgs e)
        {

            if (Main.currfrm == typeof(frmLogin) || Main.currfrm == typeof(frmMenu))
            {
                return;
            }
            if (this.isLogin)
            {
                this.Change_pContent(typeof(frmMenu));
            }
        }

        private void pictureBoxLanguage_Click(object sender, EventArgs e)
        {
            frmLanguage f = new frmLanguage();
            f.ShowDialog();
        }
    }
}
