namespace Project_ATM
{
    partial class Deposit
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
            this.textBoxAmountondeposit = new System.Windows.Forms.TextBox();
            this.labelDepositonDeposit = new System.Windows.Forms.Label();
            this.btnconfirmonDeposit = new System.Windows.Forms.Button();
            this.textBoxPINonDeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAmountondeposit
            // 
            this.textBoxAmountondeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxAmountondeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountondeposit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountondeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxAmountondeposit.Location = new System.Drawing.Point(316, 127);
            this.textBoxAmountondeposit.Name = "textBoxAmountondeposit";
            this.textBoxAmountondeposit.Size = new System.Drawing.Size(165, 22);
            this.textBoxAmountondeposit.TabIndex = 28;
            this.textBoxAmountondeposit.TextChanged += new System.EventHandler(this.textBoxcurentpinonchangepin_TextChanged);
            // 
            // labelDepositonDeposit
            // 
            this.labelDepositonDeposit.AutoSize = true;
            this.labelDepositonDeposit.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepositonDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelDepositonDeposit.Location = new System.Drawing.Point(238, 130);
            this.labelDepositonDeposit.Name = "labelDepositonDeposit";
            this.labelDepositonDeposit.Size = new System.Drawing.Size(67, 17);
            this.labelDepositonDeposit.TabIndex = 27;
            this.labelDepositonDeposit.Text = "Amount ";
            // 
            // btnconfirmonDeposit
            // 
            this.btnconfirmonDeposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnconfirmonDeposit.FlatAppearance.BorderSize = 2;
            this.btnconfirmonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmonDeposit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmonDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnconfirmonDeposit.Location = new System.Drawing.Point(316, 233);
            this.btnconfirmonDeposit.Name = "btnconfirmonDeposit";
            this.btnconfirmonDeposit.Size = new System.Drawing.Size(131, 37);
            this.btnconfirmonDeposit.TabIndex = 33;
            this.btnconfirmonDeposit.Text = "Confirm";
            this.btnconfirmonDeposit.UseVisualStyleBackColor = true;
            this.btnconfirmonDeposit.Click += new System.EventHandler(this.btnconfirmonDeposit_Click);
            // 
            // textBoxPINonDeposit
            // 
            this.textBoxPINonDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPINonDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPINonDeposit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPINonDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPINonDeposit.Location = new System.Drawing.Point(316, 179);
            this.textBoxPINonDeposit.Name = "textBoxPINonDeposit";
            this.textBoxPINonDeposit.PasswordChar = '*';
            this.textBoxPINonDeposit.Size = new System.Drawing.Size(165, 22);
            this.textBoxPINonDeposit.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(238, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "PIN";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(763, 425);
            this.Controls.Add(this.textBoxPINonDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconfirmonDeposit);
            this.Controls.Add(this.textBoxAmountondeposit);
            this.Controls.Add(this.labelDepositonDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "f";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAmountondeposit;
        private System.Windows.Forms.Label labelDepositonDeposit;
        private System.Windows.Forms.Button btnconfirmonDeposit;
        private System.Windows.Forms.TextBox textBoxPINonDeposit;
        private System.Windows.Forms.Label label1;
    }
}