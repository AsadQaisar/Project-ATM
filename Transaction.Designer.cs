namespace Project_ATM
{
    partial class Transaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelMyacctonTransaction = new System.Windows.Forms.Label();
            this.labelMyamountonTransaction = new System.Windows.Forms.Label();
            this.textBoxPINonTransaction = new System.Windows.Forms.TextBox();
            this.labelPINonTransaction = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.textBoxAmountonTransaction = new System.Windows.Forms.TextBox();
            this.labelAmountonTransaction = new System.Windows.Forms.Label();
            this.textBoxUseridonTransaction = new System.Windows.Forms.TextBox();
            this.labelUserid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(492, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "PKR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMyacctonTransaction
            // 
            this.labelMyacctonTransaction.AutoSize = true;
            this.labelMyacctonTransaction.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyacctonTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelMyacctonTransaction.Location = new System.Drawing.Point(409, 97);
            this.labelMyacctonTransaction.Name = "labelMyacctonTransaction";
            this.labelMyacctonTransaction.Size = new System.Drawing.Size(86, 17);
            this.labelMyacctonTransaction.TabIndex = 39;
            this.labelMyacctonTransaction.Text = "my amount";
            this.labelMyacctonTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMyacctonTransaction.Click += new System.EventHandler(this.labelMyacctonTransaction_Click);
            // 
            // labelMyamountonTransaction
            // 
            this.labelMyamountonTransaction.AutoSize = true;
            this.labelMyamountonTransaction.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyamountonTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelMyamountonTransaction.Location = new System.Drawing.Point(235, 97);
            this.labelMyamountonTransaction.Name = "labelMyamountonTransaction";
            this.labelMyamountonTransaction.Size = new System.Drawing.Size(112, 17);
            this.labelMyamountonTransaction.TabIndex = 38;
            this.labelMyamountonTransaction.Text = "Total Balance :";
            // 
            // textBoxPINonTransaction
            // 
            this.textBoxPINonTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPINonTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPINonTransaction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPINonTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPINonTransaction.Location = new System.Drawing.Point(330, 227);
            this.textBoxPINonTransaction.Multiline = true;
            this.textBoxPINonTransaction.Name = "textBoxPINonTransaction";
            this.textBoxPINonTransaction.PasswordChar = '*';
            this.textBoxPINonTransaction.Size = new System.Drawing.Size(165, 20);
            this.textBoxPINonTransaction.TabIndex = 45;
            // 
            // labelPINonTransaction
            // 
            this.labelPINonTransaction.AutoSize = true;
            this.labelPINonTransaction.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPINonTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelPINonTransaction.Location = new System.Drawing.Point(235, 230);
            this.labelPINonTransaction.Name = "labelPINonTransaction";
            this.labelPINonTransaction.Size = new System.Drawing.Size(71, 17);
            this.labelPINonTransaction.TabIndex = 44;
            this.labelPINonTransaction.Text = "Your PIN";
            // 
            // btnconfirm
            // 
            this.btnconfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnconfirm.FlatAppearance.BorderSize = 2;
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnconfirm.Location = new System.Drawing.Point(309, 271);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(131, 37);
            this.btnconfirm.TabIndex = 43;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // textBoxAmountonTransaction
            // 
            this.textBoxAmountonTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxAmountonTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountonTransaction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountonTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxAmountonTransaction.Location = new System.Drawing.Point(330, 181);
            this.textBoxAmountonTransaction.Multiline = true;
            this.textBoxAmountonTransaction.Name = "textBoxAmountonTransaction";
            this.textBoxAmountonTransaction.Size = new System.Drawing.Size(165, 20);
            this.textBoxAmountonTransaction.TabIndex = 42;
            // 
            // labelAmountonTransaction
            // 
            this.labelAmountonTransaction.AutoSize = true;
            this.labelAmountonTransaction.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountonTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelAmountonTransaction.Location = new System.Drawing.Point(235, 184);
            this.labelAmountonTransaction.Name = "labelAmountonTransaction";
            this.labelAmountonTransaction.Size = new System.Drawing.Size(67, 17);
            this.labelAmountonTransaction.TabIndex = 41;
            this.labelAmountonTransaction.Text = "Amount ";
            // 
            // textBoxUseridonTransaction
            // 
            this.textBoxUseridonTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxUseridonTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUseridonTransaction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUseridonTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxUseridonTransaction.Location = new System.Drawing.Point(330, 137);
            this.textBoxUseridonTransaction.Multiline = true;
            this.textBoxUseridonTransaction.Name = "textBoxUseridonTransaction";
            this.textBoxUseridonTransaction.Size = new System.Drawing.Size(165, 20);
            this.textBoxUseridonTransaction.TabIndex = 47;
            // 
            // labelUserid
            // 
            this.labelUserid.AutoSize = true;
            this.labelUserid.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelUserid.Location = new System.Drawing.Point(235, 140);
            this.labelUserid.Name = "labelUserid";
            this.labelUserid.Size = new System.Drawing.Size(62, 17);
            this.labelUserid.TabIndex = 46;
            this.labelUserid.Text = "User ID";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(747, 386);
            this.Controls.Add(this.textBoxUseridonTransaction);
            this.Controls.Add(this.labelUserid);
            this.Controls.Add(this.textBoxPINonTransaction);
            this.Controls.Add(this.labelPINonTransaction);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.textBoxAmountonTransaction);
            this.Controls.Add(this.labelAmountonTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMyacctonTransaction);
            this.Controls.Add(this.labelMyamountonTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMyacctonTransaction;
        private System.Windows.Forms.Label labelMyamountonTransaction;
        private System.Windows.Forms.TextBox textBoxPINonTransaction;
        private System.Windows.Forms.Label labelPINonTransaction;
        private System.Windows.Forms.Button btnconfirm;
        public System.Windows.Forms.TextBox textBoxAmountonTransaction;
        private System.Windows.Forms.Label labelAmountonTransaction;
        public System.Windows.Forms.TextBox textBoxUseridonTransaction;
        private System.Windows.Forms.Label labelUserid;
    }
}