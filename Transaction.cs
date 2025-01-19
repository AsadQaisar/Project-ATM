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
    public partial class Transaction : Form
    {
        bool ChkDB = false;
        public Transaction()
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
                labelMyacctonTransaction.Text = inner.Balance.ToString();
            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void labelMyacctonTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
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
                if (textBoxAmountonTransaction.Text == "" || textBoxPINonTransaction.Text == "" || textBoxUseridonTransaction.Text == "")
                {
                    MessageBox.Show("Please Fill All Required Fields", "Error");
                }
                else
                {
                    try
                    {
                        if (Update.LoginPassword == PasswordEncrypt.EncodePasswordToBase64(textBoxPINonTransaction.Text))
                        {
                            Global_Variables.Check_DB = Global_Functions.IsServerConnected();
                            ChkDB = Global_Variables.Check_DB;

                            tbl_User usr = new tbl_User();

                            if (ChkDB == true)
                            {
                                int userid = Convert.ToInt32(textBoxUseridonTransaction.Text);
                                usr = db.tbl_User.FirstOrDefault(u => u.UserID == userid);
                                
                                if (usr != null)
                                {
                                    
                                    if (Update.Balance >= (Convert.ToInt32(textBoxAmountonTransaction.Text)))
                                    {
                                        
                                        if (userid == Global_Variables.LoginID)
                                        {
                                            MessageBox.Show(this, "You Cannot Send Money To Yourself", "Transaction Not Possible!");
                                        }
                                        else
                                        {
                                            var amt = db.tbl_Amount.Where(x => x.AmountID == Update.AmountID).FirstOrDefault();
                                            amt.Balance = (int)(amt.Balance - Convert.ToInt32(textBoxAmountonTransaction.Text));
                                            amt.ModifyBy = amt.UserID;
                                            amt.ModifyOn = DateTime.Now;
                                            labelMyacctonTransaction.Text = amt.Balance.ToString();
                                            var cash = db.tbl_Amount.Where(x => x.UserID == userid).FirstOrDefault();
                                            cash.Balance = (int)(Convert.ToInt32(textBoxAmountonTransaction.Text) + cash.Balance);
                                            MessageBox.Show(this, "PKR" + " " + textBoxAmountonTransaction.Text + " " + "has been sent to" + " " + usr.FirstName.ToUpper() + " " + usr.LastName.ToUpper(), "Transaction Successful!");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Not Enough Amount");
                                        textBoxAmountonTransaction.Clear();
                                        textBoxPINonTransaction.Clear();
                                        textBoxUseridonTransaction.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "Login Failed: Invalid User ID", "Error");
                                    textBoxAmountonTransaction.Clear();
                                    textBoxPINonTransaction.Clear();
                                    textBoxUseridonTransaction.Clear();
                                }
                                

                            }
                            else
                            {
                                MessageBox.Show(this, "Login Failed: Invalid User ID", "Error");
                                textBoxAmountonTransaction.Clear();
                                textBoxPINonTransaction.Clear();
                                textBoxUseridonTransaction.Clear();
                            }
                        }

                    
                        else
                        {
                            MessageBox.Show(this, "Login Failed: Invalid User Password", "Error");
                            textBoxPINonTransaction.Clear();
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
            textBoxAmountonTransaction.Clear();
            textBoxPINonTransaction.Clear();
            textBoxUseridonTransaction.Clear();
        }
    }
}
