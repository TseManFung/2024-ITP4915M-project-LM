using MultiLang;
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
    public partial class frmUserManagementAndAccountManagement : Form
    {
        public static string GlobalLoginNameForCreate;
        public static int GlobalAccessLevelForCreate;
        public frmUserManagementAndAccountManagement()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //only menager can see this button
            (this.ParentForm as Main)?.Change_pContent(typeof(frmAccountManagement));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.ShowYesNoDialog(ml.ml_string(268,"Do you want to turn to the next page?")))
            {

                if (!string.IsNullOrEmpty(txtAccessLevel.Text) && !string.IsNullOrEmpty(txtLoginName.Text))
                {
                    GlobalLoginNameForCreate = txtLoginName.Text;
                    if (accForDealer.Checked)
                    {
                        (this.ParentForm as Main)?.Change_pContent(typeof(frmNewDealer));
                    }
                    else if (accForStaff.Checked)
                    {
                        (this.ParentForm as Main)?.Change_pContent(typeof(frmNewStaff));
                    }
                    else
                    {
                        MessageBox.Show(ml.ml_string(347,"Please select an account option!"));
                    }
                }
                else
                {
                    MessageBox.Show(ml.ml_string(348,"Login name or Access level has not been entered."));
                    txtLoginName.Text = String.Empty;
                    txtAccessLevel.Text = "0";
                }
            }

        }

        private void frmUserManagementAndAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccessLevel_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAccessLevel.Text?.TrimStart('0'), out int accessLevel))
            {
                if (accessLevel >= 0 && accessLevel <= 10000)
                {
                    GlobalAccessLevelForCreate = accessLevel;
                }
                else
                {
                    ShowInvalidAccessLevelError();
                }
            }
            else
            {
                if (txtAccessLevel.Text == null)
                {
                    txtAccessLevel.Text = "0";
                }
                else
                {
                    ShowInvalidAccessLevelError();
                }
            }

            void ShowInvalidAccessLevelError()
            {
                if (txtAccessLevel.Text != null && txtAccessLevel.Text != "0")
                {
                    Main.ShowMessage(ml.ml_string(269,"Invalid access level. Please enter a valid integer value between 0 and 10000."));
                    txtAccessLevel.Text = "0";
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoginName.Text = String.Empty;
            txtAccessLevel.Text = "0";
        }
    }
}
