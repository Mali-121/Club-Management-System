namespace Assignment
{
    partial class Add_Club_Activity
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpActivityDate = new System.Windows.Forms.DateTimePicker();
            this.txtActivityAchv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActivityDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(824, 645);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 73);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(645, 645);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 73);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCID
            // 
            this.txtCID.BackColor = System.Drawing.Color.White;
            this.txtCID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCID.ForeColor = System.Drawing.Color.Black;
            this.txtCID.Location = new System.Drawing.Point(345, 509);
            this.txtCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCID.Multiline = true;
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(418, 46);
            this.txtCID.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(109, 518);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 37);
            this.label5.TabIndex = 82;
            this.label5.Text = "ClubID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(109, 430);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 37);
            this.label4.TabIndex = 81;
            this.label4.Text = "Date:";
            // 
            // dtpActivityDate
            // 
            this.dtpActivityDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dtpActivityDate.Location = new System.Drawing.Point(345, 436);
            this.dtpActivityDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpActivityDate.Name = "dtpActivityDate";
            this.dtpActivityDate.Size = new System.Drawing.Size(418, 31);
            this.dtpActivityDate.TabIndex = 80;
            // 
            // txtActivityAchv
            // 
            this.txtActivityAchv.BackColor = System.Drawing.Color.White;
            this.txtActivityAchv.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityAchv.ForeColor = System.Drawing.Color.Black;
            this.txtActivityAchv.Location = new System.Drawing.Point(345, 345);
            this.txtActivityAchv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActivityAchv.Multiline = true;
            this.txtActivityAchv.Name = "txtActivityAchv";
            this.txtActivityAchv.Size = new System.Drawing.Size(418, 46);
            this.txtActivityAchv.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(109, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 37);
            this.label3.TabIndex = 78;
            this.label3.Text = "Achievements:";
            // 
            // txtActivityDesc
            // 
            this.txtActivityDesc.BackColor = System.Drawing.Color.White;
            this.txtActivityDesc.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityDesc.ForeColor = System.Drawing.Color.Black;
            this.txtActivityDesc.Location = new System.Drawing.Point(345, 257);
            this.txtActivityDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActivityDesc.Multiline = true;
            this.txtActivityDesc.Name = "txtActivityDesc";
            this.txtActivityDesc.Size = new System.Drawing.Size(418, 46);
            this.txtActivityDesc.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 76;
            this.label2.Text = "Description:";
            // 
            // txtActivityName
            // 
            this.txtActivityName.BackColor = System.Drawing.Color.White;
            this.txtActivityName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityName.ForeColor = System.Drawing.Color.Black;
            this.txtActivityName.Location = new System.Drawing.Point(345, 172);
            this.txtActivityName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActivityName.Multiline = true;
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(418, 46);
            this.txtActivityName.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 74;
            this.label1.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 48);
            this.label7.TabIndex = 73;
            this.label7.Text = "NEW ACTIVITY";
            // 
            // Add_Club_Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 770);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpActivityDate);
            this.Controls.Add(this.txtActivityAchv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtActivityDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtActivityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "Add_Club_Activity";
            this.Text = "Add Club Activity";
            this.Load += new System.EventHandler(this.Add_Club_Activity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpActivityDate;
        private System.Windows.Forms.TextBox txtActivityAchv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtActivityDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}