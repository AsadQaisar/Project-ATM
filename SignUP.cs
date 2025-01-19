using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Project_ATM.Model;
using Project_ATM.CommonMethod;

namespace Project_ATM
{
    public partial class SignUP : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
   );

        public SignUP()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }

        private void btnExitonSignup_Click(object sender, EventArgs e)
        {
            Form1 FM = new Form1(); 
            FM.Show();
            Close();
        }

        private void btnloginonsignup_Click(object sender, EventArgs e)
        {
            ATMEntities db = new ATMEntities();
            if (textBoxfname.Text == "" || textBoxLname.Text == "" || textfathersname.Text == "" || dateTimePicker1.Text == "" || textBoxemail.Text == "" || textBoxphoneno.Text == "" || textBoxPIN.Text == "")
            {
                MessageBox.Show("Please Fill All Required Fields", "Error");
            }
            else
            {
                try
                {
                    tbl_Amount usr = new tbl_Amount();
                    tbl_User user = new tbl_User();
                    var ur = db.tbl_User.Where(x => x.Email == textBoxemail.Text).FirstOrDefault();
                    if (ur == null)
                    {
                        user.FirstName = textBoxfname.Text;
                        user.LastName = textBoxLname.Text;
                        user.Phone = textBoxphoneno.Text;
                        user.Email = textBoxemail.Text;
                        user.LoginPassword = PasswordEncrypt.EncodePasswordToBase64(textBoxPIN.Text);
                        user.DOB = dateTimePicker1.Value.Date;
                        user.FathersName = textfathersname.Text;
                        user.IsActive = true;
                        db.tbl_User.Add(user);
                        db.SaveChanges();

                        usr.UserID = user.UserID;
                        usr.CreatedBy = user.UserID;
                        usr.CreatedOn = DateTime.Now;
                        usr.Balance = 0;
                        usr.IsActive = true;
                        db.tbl_Amount.Add(usr);
                        db.SaveChanges();
                        MessageBox.Show("Registration Successfull");
                    }
                    else { MessageBox.Show("User already exist", "Error"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }
    }
}
