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
    public partial class Form1 : Form
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
        ATMEntities db = new ATMEntities();
        static string macAddresses = Global_Functions.GetMac();
        static string ip = Global_Functions.GetIP();
        bool ChkDB = false;
        public Form1()
        {
            InitializeComponent();
            txt_Acc.Focus();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Global_Variables.Check_DB = Global_Functions.IsServerConnected();
            ChkDB = Global_Variables.Check_DB;



            {
                if (txt_Acc.Text == "" || txt_Pin.Text == "")
                {
                    MessageBox.Show("Please Fill All Required Fields", "Error");
                }
                else
                {
                    try
                    {

                        tbl_User usr = new tbl_User();

                        if (ChkDB == true)
                        {
                            usr = db.tbl_User.FirstOrDefault(u => u.Email == txt_Acc.Text);
                        }
                        if (usr != null)
                        {
                            if (usr.LoginPassword == PasswordEncrypt.EncodePasswordToBase64(txt_Pin.Text))
                            {
                                if (usr.IsActive == true)
                                {

                                    Global_Variables.LoginID = usr.UserID;
                                    Global_Variables.UserLogin = txt_Acc.Text.Trim();
                                    
                                    Global_Functions.Event_Log("Login", "Login");
                                    tbl_LoginHistory loginHistory = new tbl_LoginHistory();
                                    loginHistory.UserID = Global_Variables.LoginID;
                                    loginHistory.IpAddress = ip;
                                    loginHistory.MACAddress = macAddresses;
                                    loginHistory.SystemName = System.Environment.MachineName;
                                    loginHistory.DateTime = DateTime.Now;
                                    db.tbl_LoginHistory.Add(loginHistory);
                                    if (ChkDB)
                                    {
                                        db.SaveChanges();
                                    }

                                    main mn = new main();
                                    mn.Show();
                                    this.Hide();


                                }

                                else
                                {
                                    MessageBox.Show("Login Failed: Inactive User", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "Login Failed: Invalid User Name or Password", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Login Failed: Invalid User Name or Password", "Error");
                            txt_Acc.Clear();
                            txt_Pin.Clear();
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Failed: " + exc.Message);
                        Global_Functions.Exception_Log("frm_Login", "Login", exc);
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {

            SignUP frmDashboard_vrb = new SignUP();
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            frmDashboard_vrb.Show();
            this.Hide();   

        }

        private void txt_Acc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
