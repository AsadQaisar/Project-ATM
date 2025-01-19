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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void textBoxcurentpinonchangepin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconfirmonDeposit_Click(object sender, EventArgs e)
        {
            ATMEntities db = new ATMEntities();
            tbl_User user = new tbl_User();
            tbl_Amount amount = new tbl_Amount();
            var updateJoin = from c in db.tbl_User
                            join d in db.tbl_Amount on c.UserID equals d.UserID
                            where c.UserID == Global_Variables.LoginID
                            select new
                            {
                                LoginPassword = c.LoginPassword, 
                                Balance = d.Balance,
                                AmountID=d.AmountID
                            };
            //user = db.tbl_User.Where(x => x.UserID == Global_Variables.LoginID).FirstOrDefault();
            if (updateJoin != null)
            {
                foreach (var Update in updateJoin)
                {
                    if (textBoxAmountondeposit.Text == "" || textBoxPINonDeposit.Text == "")
                    {
                        MessageBox.Show("Please Fill All Required Fields", "Error");
                    }
                    else
                    { 
                        try
                        {
                            if (Update.LoginPassword == PasswordEncrypt.EncodePasswordToBase64(textBoxPINonDeposit.Text))
                            {
                                var amt = db.tbl_Amount.Where(x => x.AmountID == Update.AmountID).FirstOrDefault();
                                amt.Balance = (int)(Convert.ToInt32(textBoxAmountondeposit.Text) + amt.Balance);
                                amt.ModifyBy = amt.UserID;
                                amt.ModifyOn = DateTime.Now;
                                MessageBox.Show(this, "Deposit Successful");
                            }
                            else
                            {
                                MessageBox.Show(this, "Login Failed: Invalid User Password", "Error");
                                textBoxPINonDeposit.Clear();
                            }

                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Failed: " + exc.Message);
                            //Global_Functions.Exception_Log("frm_Login", "Login", exc);
                        }
                    }
                }
                db.SaveChanges();
                textBoxAmountondeposit.Clear();
                textBoxPINonDeposit.Clear();

            }
        }
    }
}
