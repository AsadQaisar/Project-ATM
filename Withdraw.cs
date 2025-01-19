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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
            ATMEntities db = new ATMEntities();
            tbl_User user = new tbl_User();
            var innerJoin = from e in db.tbl_User
                            join d in db.tbl_Amount on e.UserID equals d.UserID
                            where e.UserID == Global_Variables.LoginID
                            select new
                            {
                                Balance = d.Balance
                            };

            foreach (var inner in innerJoin)
            {
                labelMyacctonwithdraw.Text = inner.Balance.ToString();
            }

        }
        public static int SetValueForText1 = 0;
        public static int SetValueForText2 = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAmounttoWithdraw_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            ATMEntities db = new ATMEntities();
            tbl_User user = new tbl_User();
            tbl_Amount amount = new tbl_Amount();
            var updateJoin = from a in db.tbl_User
                             join d in db.tbl_Amount on a.UserID equals d.UserID
                             where a.UserID == Global_Variables.LoginID
                             select new
                             {
                                 LoginPassword = a.LoginPassword,
                                 Balance = d.Balance,
                                 AmountID = d.AmountID
                             };

            foreach (var Update in updateJoin)
            {
                if (textBoxAmounttoWithdraw.Text == "" || textBoxPINonWithdraw.Text == "")
                {
                    MessageBox.Show("Please Fill All Required Fields", "Error");
                }
                else
                {
                    try
                    {
                        if (Update.LoginPassword == PasswordEncrypt.EncodePasswordToBase64(textBoxPINonWithdraw.Text))
                        {
                            if (Update.Balance >= (Convert.ToInt32(textBoxAmounttoWithdraw.Text)))
                            {
                                var amt = db.tbl_Amount.Where(x => x.AmountID == Update.AmountID).FirstOrDefault();
                                amt.Balance = (int)(amt.Balance - Convert.ToInt32(textBoxAmounttoWithdraw.Text));
                                amt.ModifyBy = amt.UserID;
                                amt.ModifyOn = DateTime.Now;
                                labelMyacctonwithdraw.Text = amt.Balance.ToString();
                                SetValueForText1 = Convert.ToInt32(textBoxAmounttoWithdraw.Text);
                                SetValueForText2 = (int)amt.Balance;
                                Recipt rp = new Recipt();
                                rp.Show();
                            }
                            else
                            {
                                MessageBox.Show(this, "Not Enough Amount");
                                textBoxAmounttoWithdraw.Clear();
                                textBoxPINonWithdraw.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Login Failed: Invalid User Password", "Error");
                            textBoxPINonWithdraw.Clear();
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
            textBoxAmounttoWithdraw.Clear();
            textBoxPINonWithdraw.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
