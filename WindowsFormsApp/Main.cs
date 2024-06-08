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
        public static sshdatabase db;
        public static int? userID, dealerID, staffID, AssessLevel;
        public static Form currfrm = null;


        bool isLogin = false;
        Stack<Form> frmStack = new Stack<Form>();

        public void SetIsLogin(int id)
        {
            this.isLogin = true;
            Main.userID = id;
            setDSID();
        }

        public void SetLogout()
        {
            this.isLogin = false;
            Main.userID = null;
            Main.AssessLevel = null;
            Main.dealerID = null;
            Main.staffID = null;
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
            try
            {
                Main.db = new sshdatabase();
                this.Change_pContent(typeof(frmLogin));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main.ShowMessage("Error: Can not connect server\nPlease call technician for help.");
                Application.Exit();
                this.Close();
                return;
            }
            //this.Change_pContent(typeof(frmOrderDetail));
        }

        private Form newForm(Type formType)
        {
            Form frm = (Form)Activator.CreateInstance(formType);
            return frm;
        }

        public void Change_pContent(Type formType)
        {
            Change_pContent(newForm(formType));
        }

        public void Change_pContent(Form frm)
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
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            SwitchForm(frm);
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
                if (currfrm == form)
                {
                    continue;
                }
                form.Close();
            }
            frmStack.Clear();
        }


        public void ResizeControlsFont(Control container)
        {
            float formWidth = container.Width;
            float formHeight = container.Height;

            // Adjust font size for all controls in the container
            foreach (Control control in container.Controls)
            {
                // no control is DataGridView
                //if (control is Label || control is Button || control is TextBox || control is ComboBox  || control is CheckBox || control is RadioButton){
                ResizeControlFont(control, formWidth, formHeight);
                //}
            }
        }

        private void ResizeControlFont(Control control, float formWidth, float formHeight)
        {
            control.Font = new Font(control.Font.FontFamily, (formWidth + formHeight) / 100, control.Font.Style);

            ResizeControlText(control);

            // Recursively adjust font size for child controls if applicable
            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    ResizeControlFont(childControl, formWidth, formHeight);
                }
            }
        }

        private void ResizeControlText(Control control)
        {
            using (Graphics graphics = control.CreateGraphics())
            {
                SizeF textSize = graphics.MeasureString(control.Text, control.Font);
                while (textSize.Width > control.Width || textSize.Height > control.Height)
                {
                    float newSize = control.Font.Size - 0.5f;
                    if (newSize < 8)
                        break;

                    control.Font = new Font(control.Font.FontFamily, newSize, control.Font.Style);
                    textSize = graphics.MeasureString(control.Text, control.Font);
                }
            }
        }

        private void pictureBoxLanguage_Click(object sender, EventArgs e)
        {
            frmLanguage f = new frmLanguage();
            f.ShowDialog();
        }

        public void goBack()
        {
            currfrm.Close();
            SwitchForm(frmStack.Pop());
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void setDSID()
        {
            using (var reader = Main.db.readBySql($"SELECT DealerID,StaffID FROM User WHERE UserID = {Main.userID};"))
            {
                reader.Read();
                if (!reader.IsDBNull(reader.GetOrdinal("DealerID")))
                {
                    Main.dealerID = reader.GetInt32(reader.GetOrdinal("DealerID"));
                }

                if (!reader.IsDBNull(reader.GetOrdinal("StaffID")))
                {
                    Main.staffID = reader.GetInt32(reader.GetOrdinal("StaffID"));
                }
            }
        }
    }
}
