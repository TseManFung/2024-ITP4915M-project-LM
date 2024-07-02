using WindowsFormsApp.Properties;
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
            if (Main.ShowYesNoDialog(Resources.Do_you_want_to_turn_to_the_nex))
            {
                if (!string.IsNullOrEmpty(txtAccessLevel.Text) && !string.IsNullOrEmpty(txtLoginName.Text))
                {
                    GlobalLoginNameForCreate = txtLoginName.Text;

                    // 检查 LoginName 是否已存在
                    if (IsLoginNameDuplicate(GlobalLoginNameForCreate))
                    {
                        Main.ShowMessage(Resources.lnaepcann);
                        return;
                    }

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
                        MessageBox.Show(Resources.Please_select_an_account_optio);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.Login_name_or_Access_level_has);
                    txtLoginName.Text = String.Empty;
                    txtAccessLevel.Text = "1";
                }
            }
        }

        private void frmUserManagementAndAccountManagement_Load(object sender, EventArgs e)
        {
            txtAccessLevel.Text = "1";
        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccessLevel_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAccessLevel.Text, out int accessLevel))
            {
                // Check if the access level is within the allowed range
                if (accessLevel >= 1 && accessLevel <= 10000)
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
                // If parsing fails, show an error and reset the access level to 1
                ShowInvalidAccessLevelError();
            }

            void ShowInvalidAccessLevelError()
            {
                // Display an error message and reset the text to "1"
                Main.ShowMessage(Resources.Invalid_access_level_Please_en);
                txtAccessLevel.Text = "1";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoginName.Text = String.Empty;
            txtAccessLevel.Text = "1";
        }
        private bool IsLoginNameDuplicate(string loginName)
        {
            string query = $"SELECT COUNT(*) FROM `User` WHERE LoginName = '{loginName}'";
            int count = 0;

            using (var reader = Main.db.readBySql(query))
            {
                if (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
            }

            return count > 0;
        }
    }
}
