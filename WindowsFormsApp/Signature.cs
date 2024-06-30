using WindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Org.BouncyCastle.Asn1.Ocsp;

namespace WindowsFormsApp
{
    public partial class frmSignature : Form
    {
        string InvoiceID, OrderSerial;

        public frmSignature(string InvoiceID, string OrderSerial)
        {
            this.InvoiceID = InvoiceID;
            this.OrderSerial = OrderSerial;
            InitializeComponent();
        }

        private void frmSignature_Load(object sender, EventArgs e)
        {
            load_sign_form();
        }

        private void load_sign_form()
        {
            frmSign frm = new frmSign();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            PSign.Controls.Clear();
            PSign.Controls.Add(frm);
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ((Form)PSign.Controls[0]).Close();
            load_sign_form();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Main.ShowMessage(Resources.Please_enter_your_name);
                return;
            }
            // Get the signature from the form
            Image signature = ((frmSign)PSign.Controls[0]).signature;

            // Convert the signature to a byte array
            byte[] signatureBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                signature.Save(ms, ImageFormat.Png);
                signatureBytes = ms.ToArray();
            }

            // Insert the signature into the database

            string query = "INSERT INTO Signature (InvoiceID, Name, SignatureDate, Sign) VALUES (@InvoiceID, @Name, @SignatureDate, @Sign)";
            using (var command = new MySqlCommand(query, Main.db.get_dbconnect()))
            {
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@SignatureDate", DateTime.Now);
                command.Parameters.AddWithValue("@Sign", signatureBytes);
                try
                {
                    command.ExecuteNonQuery();
                }catch (Exception ex)
                {
                    Main.ShowMessage(Resources.Signature_already_exists);
                    return;
                }
            }
            string sql = $"UPDATE `Invoice` SET `CompleteState` = 'S' WHERE (`InvoiceID` = '{InvoiceID}');";
            Main.db.updateBySql(sql);
            // Check if any record in OrderItemToFollow table has OrderSerial equal to this.OrderSerial
            List<string> Followingstates = new List<string>();

            sql = $"SELECT State FROM OrderItemToFollow WHERE OrderSerial = '{OrderSerial}'";

            using (var command = new MySqlCommand(sql, Main.db.get_dbconnect()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string state = reader.GetString("State");
                        Followingstates.Add(state);
                    }
                }
            }
            int shippingInvoice=0;
            sql = $"SELECT COUNT(*) FROM Invoice WHERE CompleteState = 'C' AND OrderSerial = '{OrderSerial}'";
            using (var command = new MySqlCommand(sql, Main.db.get_dbconnect()))
            {
                shippingInvoice = Convert.ToInt32(command.ExecuteScalar());
            }

            string updateState;
            if (Followingstates.Count == 0 && shippingInvoice==0)
            {
                updateState = "F";
            }
            else if (shippingInvoice!=0) {
                updateState = "T";
            }
            else if (Followingstates.Contains("W"))
            {
                updateState = "W";
            }else if (Followingstates.Contains("U"))
            {
                updateState = "U";
            }
            else
            {
                throw new Exception(Resources.Unknown_state0);
            }
            sql = $"UPDATE `Order` SET `State` = '{updateState}' WHERE (`OrderSerial` = '{OrderSerial}');";
            Main.db.updateBySql(sql);

            Main.ShowMessage(Resources.success1);
            (this.ParentForm as Main)?.refreshPage(sender,e);

        }


    }
}
