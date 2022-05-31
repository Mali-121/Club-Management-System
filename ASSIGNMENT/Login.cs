using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCs"].ToString());
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"select count(*) from users where username ='{txtUsername.Text}'and password = '{txtPassword.Text}'", con);
            Users obj1 = new Users(txtUsername.Text, txtPassword.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                this.Hide();
                SqlCommand cmd2 = new SqlCommand($"select role from users where username ='{obj1.Username}'", con);
                string userRole = cmd2.ExecuteScalar().ToString();
                if (userRole == "Admin")
                {
                    Admin_Home a = new Admin_Home(txtUsername.Text);
                    a.ShowDialog();
                }
                else if (userRole == "Student")
                {
                    StudentHome s = new StudentHome(txtUsername.Text);
                    s.ShowDialog();
                }
                else if (userRole == "Club Representative")
                {
                    ClubDetail cm = new ClubDetail(txtUsername.Text);
                    cm.ShowDialog();
                }
                this.Close();
            }
            else
                MessageBox.Show("Incorrect username or password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();

        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact the admin office to change your password", "Forgot Password");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
