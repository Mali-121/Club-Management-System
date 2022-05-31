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
    public partial class Register_User : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCs"].ToString());
        public Register_User()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            Users obj1 = new Users(txtFullName.Text, txtUsername.Text, txtPassword.Text, cmbRole.Text);
            SqlCommand cmd = new SqlCommand("insert into users (fullname, username, password, role) values (@fullname, @username, @password, @role)", con);
            cmd.Parameters.AddWithValue("@fullname", obj1.Fullname);
            cmd.Parameters.AddWithValue("@username", obj1.Username);
            cmd.Parameters.AddWithValue("@password", obj1.Password);
            cmd.Parameters.AddWithValue("@role", obj1.Role);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Registration Successful.");
            }
            else
                MessageBox.Show("Unable to register.");
            con.Close();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_User_Load(object sender, EventArgs e)
        {

        }
    }
}
