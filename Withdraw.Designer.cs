namespace Project_ATM
{
    partial class Withdraw
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
            this.labelMyacctonwithdraw = new System.Windows.Forms.Label();
            this.labelMyamountonWithdraw = new System.Windows.Forms.Label();
            this.textBoxAmounttoWithdraw = new System.Windows.Forms.TextBox();
            this.labelAmounttoWithdraw = new System.Windows.Forms.Label();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.textBoxPINonWithdraw = new System.Windows.Forms.TextBox();
            this.labelPINonWithdraw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMyacctonwithdraw
            // 
            this.labelMyacctonwithdraw.AutoSize = true;
            this.labelMyacctonwithdraw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyacctonwithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelMyacctonwithdraw.Location = new System.Drawing.Point(430, 120);
            this.labelMyacctonwithdraw.Name = "labelMyacctonwithdraw";
            this.labelMyacctonwithdraw.Size = new System.Drawing.Size(86, 17);
            this.labelMyacctonwithdraw.TabIndex = 29;
            this.labelMyacctonwithdraw.Text = "my amount";
            this.labelMyacctonwithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMyacctonwithdraw.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMyamountonWithdraw
            // 
            this.labelMyamountonWithdraw.AutoSize = true;
            this.labelMyamountonWithdraw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyamountonWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelMyamountonWithdraw.Location = new System.Drawing.Point(256, 120);
            this.labelMyamountonWithdraw.Name = "labelMyamountonWithdraw";
            this.labelMyamountonWithdraw.Size = new System.Drawing.Size(112, 17);
            this.labelMyamountonWithdraw.TabIndex = 28;
            this.labelMyamountonWithdraw.Text = "Total Balance :";
            // 
            // textBoxAmounttoWithdraw
            // 
            this.textBoxAmounttoWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxAmounttoWithdraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmounttoWithdraw.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmounttoWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxAmounttoWithdraw.Location = new System.Drawing.Point(351, 164);
            this.textBoxAmounttoWithdraw.Multiline = true;
            this.textBoxAmounttoWithdraw.Name = "textBoxAmounttoWithdraw";
            this.textBoxAmounttoWithdraw.Size = new System.Drawing.Size(165, 20);
            this.textBoxAmounttoWithdraw.TabIndex = 31;
            this.textBoxAmounttoWithdraw.TextChanged += new System.EventHandler(this.textBoxAmounttoWithdraw_TextChanged);
            // 
            // labelAmounttoWithdraw
            // 
            this.labelAmounttoWithdraw.AutoSize = true;
            this.labelAmounttoWithdraw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmounttoWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelAmounttoWithdraw.Location = new System.Drawing.Point(256, 167);
            this.labelAmounttoWithdraw.Name = "labelAmounttoWithdraw";
            this.labelAmounttoWithdraw.Size = new System.Drawing.Size(67, 17);
            this.labelAmounttoWithdraw.TabIndex = 30;
            this.labelAmounttoWithdraw.Text = "Amount ";
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnwithdraw.FlatAppearance.BorderSize = 2;
            this.btnwithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwithdraw.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnwithdraw.Location = new System.Drawing.Point(330, 254);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(131, 37);
            this.btnwithdraw.TabIndex = 34;
            this.btnwithdraw.Text = "Withdraw";
            this.btnwithdraw.UseVisualStyleBackColor = true;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // textBoxPINonWithdraw
            // 
            this.textBoxPINonWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPINonWithdraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPINonWithdraw.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPINonWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPINonWithdraw.Location = new System.Drawing.Point(351, 210);
            this.textBoxPINonWithdraw.Multiline = true;
            this.textBoxPINonWithdraw.Name = "textBoxPINonWithdraw";
            this.textBoxPINonWithdraw.PasswordChar = '*';
            this.textBoxPINonWithdraw.Size = new System.Drawing.Size(165, 20);
            this.textBoxPINonWithdraw.TabIndex = 36;
            // 
            // labelPINonWithdraw
            // 
            this.labelPINonWithdraw.AutoSize = true;
            this.labelPINonWithdraw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPINonWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelPINonWithdraw.Location = new System.Drawing.Point(256, 213);
            this.labelPINonWithdraw.Name = "labelPINonWithdraw";
            this.labelPINonWithdraw.Size = new System.Drawing.Size(33, 17);
            this.labelPINonWithdraw.TabIndex = 35;
            this.labelPINonWithdraw.Text = "PIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(513, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "PKR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(763, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPINonWithdraw);
            this.Controls.Add(this.labelPINonWithdraw);
            this.Controls.Add(this.btnwithdraw);
            this.Controls.Add(this.textBoxAmounttoWithdraw);
            this.Controls.Add(this.labelAmounttoWithdraw);
            this.Controls.Add(this.labelMyacctonwithdraw);
            this.Controls.Add(this.labelMyamountonWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMyacctonwithdraw;
        private System.Windows.Forms.Label labelMyamountonWithdraw;
        private System.Windows.Forms.Label labelAmounttoWithdraw;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.TextBox textBoxPINonWithdraw;
        private System.Windows.Forms.Label labelPINonWithdraw;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxAmounttoWithdraw;
    }
}