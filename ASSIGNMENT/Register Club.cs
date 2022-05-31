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
    public partial class Register_Club : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCs"].ToString());
        public Register_Club()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            ClubRegistration obj1 = new ClubRegistration(txtClubName.Text, dtpRDate.Value, txtPresident.Text, txtVicePresident.Text, txtRepresentative.Text, txtDescription.Text);
            SqlCommand cmd = new SqlCommand("insert into clubInfo (name, president, vicePresident, representative, description, registeredDate, status) values (@name, @pres, @vp, @rep, @desc, @date, 'Active')", con);
            cmd.Parameters.AddWithValue("@name", obj1.Name);
            cmd.Parameters.AddWithValue("@pres", obj1.President);
            cmd.Parameters.AddWithValue("@vp", obj1.VicePresident);
            cmd.Parameters.AddWithValue("@rep", obj1.ClubRepresentative);
            cmd.Parameters.AddWithValue("@desc", obj1.ClubDescription);
            cmd.Parameters.AddWithValue("@date", obj1.RegistrationDate);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Registration Successful.");
                this.Close();
            }
            else
                MessageBox.Show("Unable to register.");
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Club_Load(object sender, EventArgs e)
        {

        }
    }
}
