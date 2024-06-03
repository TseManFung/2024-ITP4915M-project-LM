using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Debug
//using System.Diagnostics;

namespace WindowsFormsApp
{

    public partial class Main : Form
    {
        public static sshdatabase db = new sshdatabase();
        public static int? userID;
        public static int? AssessLevel;
        public static Form currfrm = null;

        bool isLogin = false;
        Stack<Form> frmStack = new Stack<Form>();

        public void SetIsLogin(int id)
        {
            this.isLogin = true;
            Main.userID = id;
        }

        public void SetLogout()
        {
            this.isLogin = false;
            Main.userID = null;
            AssessLevel = null;
        }

        public Main()
        {
            InitializeComponent();
        }

        public static bool ShowYesNoDialog(string message)
        {
            var result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Change_pContent(typeof(frmLogin));
            //this.Change_pContent(typeof(frmOrderDetail));
        }

        private Form newForm(Type formType)
        {
            Form frm = (Form)Activator.CreateInstance(formType);
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            return frm;
        }

        public void Change_pContent(Type formType)
        {
            // add current frm to stack
            if (currfrm != null)
            {
                frmStack.Push(currfrm);

                if (currfrm_equals(typeof(frmLogin)))
                {
                    clear_frmStack();

                }
            }
            SwitchForm(newForm(formType));
        }

        private void SwitchForm(Form frm)
        {
            try
            {
                pContent.Controls.Clear();

                pContent.Controls.Add(frm);
                frm.Show();
                lblTitle.Text = frm.Text;
                Main.currfrm = frm;

                change_mainBar(frm.GetType());
                // Debug
                //Debug.WriteLine("\nfrmStack contents: " + frmStack.Count);
                //foreach (var form in frmStack)
                //{
                //    Debug.WriteLine(form.GetType().Name);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void change_mainBar(Type formType)
        {
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



        private void pContent_Paint(object sender, PaintEventArgs e)
        {

        }


        public bool currfrm_equals(Type frmType)
        {
            return Main.currfrm.GetType() == frmType;
        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

            if (currfrm_equals(typeof(frmLogin)) || currfrm_equals(typeof(frmMenu)))
            {
                return;
            }
            if (this.isLogin)
            {
                foreach (var form in frmStack)
                {
                    if (form.GetType() == typeof(frmMenu))
                    {

                        SwitchForm(form);
                        continue;
                    }

                }
                clear_frmStack();
            }
        }

        private void clear_frmStack()
        {
            foreach (var form in frmStack)
            {
                if (currfrm == form) { 
                continue;
                }
                form.Close();
            }
            frmStack.Clear();
        }

        private void pictureBoxLanguage_Click(object sender, EventArgs e)
        {
            frmLanguage f = new frmLanguage();
            f.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            currfrm.Close();

            SwitchForm(frmStack.Pop());
        }
    }
}
