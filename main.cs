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
using Project_ATM.CommonMethod;
namespace Project_ATM
{
    public partial class main : Form
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

        public main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnaccdetail.Height;
            pnlNav.Top = btnaccdetail.Top;
            pnlNav.Left = btnaccdetail.Left;
            panel3.Hide();
            //btnaccdetail.BackColor = Color.FromArgb(24, 30, 54);
            labelusername.Text = Global_Variables.LoginID.ToString();
            labeluserinfo.Text = Global_Variables.UserLogin;
            pnlsubsettings.Hide();
            pnlNav2.Height = btnChangePin.Height;
            pnlNav2.Top = btnChangePin.Top;
            pnlNav2.Left = btnChangePin.Left;
            //btnChangePin.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnaccdetail_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnaccdetail.Height;
            pnlNav.Top = btnaccdetail.Top;
            pnlNav.Left = btnaccdetail.Left;
            //btnaccdetail.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Hide();
            pnlsubsettings.Hide();
            label1.Text = "Your Account";
            this.pnlmain.Controls.Clear();
            YourAcc YA = new YourAcc() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            YA.FormBorderStyle = FormBorderStyle.None;
            this.pnlmain.Controls.Add(YA);
            YA.Show();
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnwithdraw.Height;
            pnlNav.Top = btnwithdraw.Top;
            pnlNav.Left = btnwithdraw.Left;
            //btnwithdraw.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Hide();
            pnlsubsettings.Hide();
            label1.Text = "Withdraw";
            this.pnlmain.Controls.Clear();
            Withdraw WD = new Withdraw() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            WD.FormBorderStyle = FormBorderStyle.None;
            this.pnlmain.Controls.Add(WD);
            WD.Show();
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btndeposit.Height;
            pnlNav.Top = btndeposit.Top;
            pnlNav.Left = btndeposit.Left;
            //btndeposit.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Hide();
            pnlsubsettings.Hide();
            label1.Text = "Deposit";
            this.pnlmain.Controls.Clear();
            Deposit DP = new Deposit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DP.FormBorderStyle = FormBorderStyle.None;
            this.pnlmain.Controls.Add(DP);
            DP.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTransaction.Height;
            pnlNav.Top = btnTransaction.Top;
            pnlNav.Left = btnTransaction.Left;
            panel3.Show();
            pnlsubsettings.Hide();
            label1.Text = "Transaction";
            this.pnlmain.Controls.Clear();
            Transaction TN = new Transaction() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TN.FormBorderStyle = FormBorderStyle.None;
            this.pnlmain.Controls.Add(TN);
            TN.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsetting.Height;
            pnlNav.Top = btnsetting.Top;
            pnlNav.Left = btnsetting.Left;
            panel3.Hide();
            //btnsetting.BackColor = Color.FromArgb(24, 30, 54);
            pnlsubsettings.Show();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnChangePin_Click(object sender, EventArgs e)
        {
            pnlNav2.Height = btnChangePin.Height;
            pnlNav2.Top = btnChangePin.Top;
            pnlNav2.Left = btnChangePin.Left;
            //btnChangePin.BackColor = Color.FromArgb(46, 51, 73);
            label1.Text = "Change PIN";
            this.pnlmain.Controls.Clear();
            ChangePin CP = new ChangePin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CP.FormBorderStyle = FormBorderStyle.None;
            this.pnlmain.Controls.Add(CP);
            CP.Show();
        }
        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            pnlNav2.Height = btnLogOut.Height;
            pnlNav2.Top = btnLogOut.Top;
            pnlNav2.Left = btnLogOut.Left;
            //btnLogOut.BackColor = Color.FromArgb(46, 51, 73);
            Form1 log = new Form1();
            log.FormBorderStyle = FormBorderStyle.None;
            log.Show();
            Close();
        }

        private void labelusername_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
