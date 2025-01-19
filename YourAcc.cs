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
    public partial class YourAcc : Form
    {
        public YourAcc()
        {

            InitializeComponent();
            ATMEntities db = new ATMEntities();
            tbl_User user = new tbl_User();
            var innerJoin = from e in db.tbl_User
                            join d in db.tbl_Amount on e.UserID equals d.UserID
                            where e.UserID==Global_Variables.LoginID
                            select new
                            {
                                FirstName = e.FirstName,
                                LastName = e.LastName,
                                FathersName = e.FathersName,
                                Phone=e.Phone,
                                Balance = d.Balance
                            };
            //user = db.tbl_User.Where(x => x.UserID == Global_Variables.LoginID).FirstOrDefault();
            if (innerJoin != null)
            {
                foreach (var inner in innerJoin) {
                    labelname.Text = inner.FirstName + " " + inner.LastName;
                    label2.Text = inner.FathersName;
                    labelmyPh.Text = inner.Phone;
                    label3.Text = inner.Balance.ToString(); 
                }
            }
        }

        private void YourAcc_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelmyname_Click(object sender, EventArgs e)
        {

        }
    }
}
