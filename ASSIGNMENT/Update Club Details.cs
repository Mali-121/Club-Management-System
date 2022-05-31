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
    public partial class Update_Club_Details : Form
    {
        public static int clubID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCs"].ToString());
        public Update_Club_Details(int c)
        {
            InitializeComponent();
            clubID = c;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Club_Details_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from clubInfo where clubID ='{clubID}'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txtClubId.Text = rd.GetInt32(0).ToString();
                txtClubId.Enabled = false;
                txtClubName.Text = rd.GetString(1);
                txtClubName.Enabled = false;
                txtPresident.Text = rd.GetString(2);
                txtVicePresident.Text = rd.GetString(3);
                txtRepresentative.Text = rd.GetString(4);
                txtDescription.Text = rd.GetString(5);
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            ClubRegistration obj1 = new ClubRegistration(txtClubName.Text);
            obj1.updateDetails(txtPresident.Text, txtVicePresident.Text, txtRepresentative.Text, txtDescription.Text);
            string query = "UPDATE clubInfo SET president=@President, vicePresident=@VicePresident, representative=@Representative, description=@Description WHERE clubID=@ClubID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@clubID", clubID);
            cmd.Parameters.AddWithValue("@President", obj1.President);
            cmd.Parameters.AddWithValue("@VicePresident", obj1.VicePresident);
            cmd.Parameters.AddWithValue("@Representative", obj1.ClubRepresentative);
            cmd.Parameters.AddWithValue("@Description", obj1.ClubDescription);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Update Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Update Unsuccessful.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            this.Close();
            View_Clubs vc = new View_Clubs();
            vc.Show();
            vc.Focus();
        }
    }
}
