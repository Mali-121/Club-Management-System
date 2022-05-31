namespace Assignment
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.lblForgot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Welcome To Club Registration Portal";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(473, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 36);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(153, 111);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 22);
            this.txtUsername.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.Font = new System.Drawing.Font("Modern No. 20", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPass.Location = new System.Drawing.Point(389, 147);
            this.chkPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(115, 20);
            this.chkPass.TabIndex = 12;
            this.chkPass.Text = "Show Password";
            this.chkPass.UseVisualStyleBackColor = true;
            this.chkPass.CheckedChanged += new System.EventHandler(this.chkPass_CheckedChanged);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Location = new System.Drawing.Point(150, 178);
            this.lblForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(121, 17);
            this.lblForgot.TabIndex = 13;
            this.lblForgot.TabStop = true;
            this.lblForgot.Text = "Forgot password?";
            this.lblForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgot_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 282);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPass;
        private System.Windows.Forms.LinkLabel lblForgot;
    }
}