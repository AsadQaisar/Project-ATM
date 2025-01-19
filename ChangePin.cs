using Project_ATM.CommonMethod;
using Project_ATM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ATM
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void textBoxcurentpinonchangepin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitonchangepin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirmonchangepin_Click(object sender, EventArgs e)
        {
            ATMEntities db = new ATMEntities();
            tbl_User user = new tbl_User();
            var u = db.tbl_User.Where(x => x.UserID == Global_Variables.LoginID).FirstOrDefault();

            if (textBoxcurentpinonchangepin.Text == "" || textBoxNewpinonChangepin.Text == "" || textBoxConfirmpinonChangepin.Text == "")
            {
                MessageBox.Show("Please Fill All Required Fields", "Error");
            }
            else
            {
                try
                {
                    if (u.LoginPassword == PasswordEncrypt.EncodePasswordToBase64(textBoxcurentpinonchangepin.Text))
                    {
                        if (PasswordEncrypt.EncodePasswordToBase64(textBoxNewpinonChangepin.Text) != PasswordEncrypt.EncodePasswordToBase64(textBoxcurentpinonchangepin.Text))
                        {
                            if (PasswordEncrypt.EncodePasswordToBase64(textBoxNewpinonChangepin.Text) == PasswordEncrypt.EncodePasswordToBase64(textBoxConfirmpinonChangepin.Text))
                            {
                                u.LoginPassword = PasswordEncrypt.EncodePasswordToBase64(textBoxConfirmpinonChangepin.Text);
                                u.ModifyBy = u.UserID;
                                u.ModifyOn = DateTime.Now;
                                db.SaveChanges();
                                MessageBox.Show(this, "Password Changed");
                                textBoxcurentpinonchangepin.Clear();
                                textBoxNewpinonChangepin.Clear();
                                textBoxConfirmpinonChangepin.Clear();
                            }
                            else
                            {
                                MessageBox.Show(this, "Error New Password Does Not Match");
                                textBoxcurentpinonchangepin.Clear();
                                textBoxNewpinonChangepin.Clear();
                                textBoxConfirmpinonChangepin.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Error New Password Can't Be Your Old Password");
                            textBoxcurentpinonchangepin.Clear();
                            textBoxNewpinonChangepin.Clear();
                            textBoxConfirmpinonChangepin.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show(this, "Login Failed: Invalid User Password", "Error");
                        textBoxcurentpinonchangepin.Clear();
                        textBoxNewpinonChangepin.Clear();
                        textBoxConfirmpinonChangepin.Clear();
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Failed: " + exc.Message);
                    //Global_Functions.Exception_Log("frm_Login", "Login", exc);
                }
            }

        }

        private void labelcurentPINonchangepin_Click(object sender, EventArgs e)
        {

        }
    }
}
