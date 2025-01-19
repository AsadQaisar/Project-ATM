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
    public partial class Recipt : Form
    {
        public Recipt()
        {
            InitializeComponent();
            ATMEntities db = new ATMEntities();
            tbl_User user = new tbl_User();
            var innerJoin = from f in db.tbl_User
                            join d in db.tbl_Amount on f.UserID equals d.UserID
                            where f.UserID == Global_Variables.LoginID
                            select new
                            {
                                Name = f.FirstName,
                                Lname = f.LastName,
                                UserID = f.UserID,
                                Phone = f.Phone,
                                Email = f.Email,
                                Balance = d.Balance
                            };

            foreach (var inner in innerJoin)
            {
                txtResult.Text += "\nDate & Time: " + DateTime.Now.ToString() + "\n\n";
                txtResult.Text += "User ID: " + inner.UserID + "\n";
                txtResult.Text += "Name: " + inner.Name + " " + inner.Lname + "\n";
                txtResult.Text += "Phone Number: " + inner.Phone + "\n";
                txtResult.Text += "Email ID: " + inner.Email + "\n";
                txtResult.Text += "\n******************************************************\n";
                txtResult.Text += "Total Balance: " + "                        " + inner.Balance + " " + "PKR" + "\n";
                txtResult.Text += "Withdraw Amount: " + "                    " + (Withdraw.SetValueForText1) + " " + "PKR" + "\n";
                txtResult.Text += "Current Balance: " + "                    " + (Withdraw.SetValueForText2) + " " + "PKR" + "\n";
                txtResult.Text += "\n******************************************************\n";
                txtResult.Text += "\n\n***                          THANK YOU!                           ***";
            }

        }

        private void Recipt_Load(object sender, EventArgs e)
        {

        }
    }
}
