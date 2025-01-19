namespace Project_ATM
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.pnlsubsettings = new System.Windows.Forms.Panel();
            this.pnlNav2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btndeposit = new System.Windows.Forms.Button();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.btnaccdetail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeluserinfo = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlsubsettings.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlsubsettings);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnsetting);
            this.panel1.Controls.Add(this.btndeposit);
            this.panel1.Controls.Add(this.btnwithdraw);
            this.panel1.Controls.Add(this.btnaccdetail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(3, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 42);
            this.panel3.TabIndex = 5;
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTransaction.Location = new System.Drawing.Point(3, 284);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(183, 42);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // pnlsubsettings
            // 
            this.pnlsubsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlsubsettings.Controls.Add(this.pnlNav2);
            this.pnlsubsettings.Controls.Add(this.btnLogOut);
            this.pnlsubsettings.Controls.Add(this.btnChangePin);
            this.pnlsubsettings.Location = new System.Drawing.Point(80, 426);
            this.pnlsubsettings.Name = "pnlsubsettings";
            this.pnlsubsettings.Size = new System.Drawing.Size(103, 91);
            this.pnlsubsettings.TabIndex = 6;
            // 
            // pnlNav2
            // 
            this.pnlNav2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav2.Location = new System.Drawing.Point(-1, 20);
            this.pnlNav2.Name = "pnlNav2";
            this.pnlNav2.Size = new System.Drawing.Size(3, 50);
            this.pnlNav2.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogOut.Location = new System.Drawing.Point(2, 48);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(98, 40);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnChangePin
            // 
            this.btnChangePin.FlatAppearance.BorderSize = 0;
            this.btnChangePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePin.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnChangePin.Location = new System.Drawing.Point(2, 3);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(98, 40);
            this.btnChangePin.TabIndex = 0;
            this.btnChangePin.Text = "Change PIN";
            this.btnChangePin.UseVisualStyleBackColor = true;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 150);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 125);
            this.pnlNav.TabIndex = 4;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // btnsetting
            // 
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnsetting.Location = new System.Drawing.Point(3, 523);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(183, 42);
            this.btnsetting.TabIndex = 4;
            this.btnsetting.Text = "Settings";
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btndeposit
            // 
            this.btndeposit.FlatAppearance.BorderSize = 0;
            this.btndeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeposit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btndeposit.Location = new System.Drawing.Point(3, 236);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(183, 42);
            this.btndeposit.TabIndex = 2;
            this.btndeposit.Text = "Deposit";
            this.btndeposit.UseVisualStyleBackColor = true;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.FlatAppearance.BorderSize = 0;
            this.btnwithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwithdraw.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnwithdraw.Location = new System.Drawing.Point(3, 188);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(183, 42);
            this.btnwithdraw.TabIndex = 1;
            this.btnwithdraw.Text = "Withdraw";
            this.btnwithdraw.UseVisualStyleBackColor = true;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // btnaccdetail
            // 
            this.btnaccdetail.FlatAppearance.BorderSize = 0;
            this.btnaccdetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccdetail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccdetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnaccdetail.Location = new System.Drawing.Point(3, 140);
            this.btnaccdetail.Name = "btnaccdetail";
            this.btnaccdetail.Size = new System.Drawing.Size(183, 42);
            this.btnaccdetail.TabIndex = 0;
            this.btnaccdetail.Text = "Your Account";
            this.btnaccdetail.UseVisualStyleBackColor = true;
            this.btnaccdetail.Click += new System.EventHandler(this.btnaccdetail_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labeluserinfo);
            this.panel2.Controls.Add(this.labelusername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // labeluserinfo
            // 
            this.labeluserinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeluserinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.labeluserinfo.Location = new System.Drawing.Point(3, 115);
            this.labeluserinfo.Name = "labeluserinfo";
            this.labeluserinfo.Size = new System.Drawing.Size(180, 12);
            this.labeluserinfo.TabIndex = 0;
            this.labeluserinfo.Text = "Some User Info";
            this.labeluserinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelusername
            // 
            this.labelusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.labelusername.Location = new System.Drawing.Point(9, 88);
            this.labelusername.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(171, 16);
            this.labelusername.TabIndex = 0;
            this.labelusername.Text = "User Name";
            this.labelusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelusername.Click += new System.EventHandler(this.labelusername_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_ATM.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnexit.Location = new System.Drawing.Point(914, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(25, 25);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(216, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your ATM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlmain
            // 
            this.pnlmain.Controls.Add(this.label3);
            this.pnlmain.Location = new System.Drawing.Point(186, 140);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(765, 425);
            this.pnlmain.TabIndex = 3;
            this.pnlmain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmain_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please Select Your Desired Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(766, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Made By : Muhammad Asad Qaisar";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "la";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.pnlsubsettings.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeluserinfo;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Button btnaccdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Panel pnlsubsettings;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePin;
        private System.Windows.Forms.Panel pnlNav2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel panel3;
    }
}