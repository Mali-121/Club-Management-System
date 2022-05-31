namespace Assignment
{
    partial class Report
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
            this.btnActivity = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActivity
            // 
            this.btnActivity.BackColor = System.Drawing.Color.Gray;
            this.btnActivity.Location = new System.Drawing.Point(323, 136);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(109, 62);
            this.btnActivity.TabIndex = 5;
            this.btnActivity.Text = "Activities";
            this.btnActivity.UseVisualStyleBackColor = false;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Gray;
            this.btnList.Location = new System.Drawing.Point(158, 136);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(109, 62);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "Clubs";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "SELECT REPORT TO GENERATE";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActivity);
            this.Controls.Add(this.btnList);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label1;
    }
}