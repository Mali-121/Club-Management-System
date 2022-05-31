namespace Assignment
{
    partial class Admin_Home
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
            this.lblIdentity = new System.Windows.Forms.Label();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnViewClub = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentity.Location = new System.Drawing.Point(54, 33);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(0, 31);
            this.lblIdentity.TabIndex = 0;
            this.lblIdentity.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackColor = System.Drawing.Color.Gray;
            this.btnAddUsers.Location = new System.Drawing.Point(60, 103);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(102, 50);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "Add Users";
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnViewClub
            // 
            this.btnViewClub.BackColor = System.Drawing.Color.Gray;
            this.btnViewClub.Location = new System.Drawing.Point(188, 103);
            this.btnViewClub.Name = "btnViewClub";
            this.btnViewClub.Size = new System.Drawing.Size(102, 50);
            this.btnViewClub.TabIndex = 2;
            this.btnViewClub.Text = "View Clubs";
            this.btnViewClub.UseVisualStyleBackColor = false;
            this.btnViewClub.Click += new System.EventHandler(this.btnViewClub_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gray;
            this.btnReport.Location = new System.Drawing.Point(313, 103);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(104, 50);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 212);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnViewClub);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.lblIdentity);
            this.Name = "Admin_Home";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.Admin_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnViewClub;
        private System.Windows.Forms.Button btnReport;
    }
}