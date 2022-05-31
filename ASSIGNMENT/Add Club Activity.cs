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
    public partial class Add_Club_Activity : Form
    {
        public static string name;
        public static int i;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCS"].ToString());
        public Add_Club_Activity()
        {
            InitializeComponent();
        }
        public Add_Club_Activity(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void Add_Club_Activity_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from users where username ='{name}'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            string fullname = rd.GetString(1);
            rd.Close();
            SqlCommand cmd2 = new SqlCommand($"select * from clubInfo where representative ='{fullname}'", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                txtCID.Text = rd2.GetValue(0).ToString();
                txtCID.Enabled = false;
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (string.IsNullOrEmpty(txtActivityAchv.Text))
            {
                Activity obj1 = new Activity(txtActivityName.Text, txtActivityDesc.Text, dtpActivityDate.Value);
                SqlCommand cmd = new SqlCommand("insert into activity(name, description, date, clubID) values(@name, @d, @date, @c)", con);
                cmd.Parameters.AddWithValue("@name", obj1.Name);
                cmd.Parameters.AddWithValue("@d", obj1.Description);
                cmd.Parameters.AddWithValue("@date", obj1.EntryDate);
                cmd.Parameters.AddWithValue("@c", txtCID.Text);
                i = cmd.ExecuteNonQuery();
            }
            else
            {
                Activity obj1 = new Activity(txtActivityName.Text, txtActivityDesc.Text, txtActivityAchv.Text, dtpActivityDate.Value);
                SqlCommand cmd2 = new SqlCommand("insert into activity(name, description, achievements, date, clubID) values(@name, @d, @a, @date, @c)", con);
                cmd2.Parameters.AddWithValue("@name", obj1.Name);
                cmd2.Parameters.AddWithValue("@d", obj1.Description);
                cmd2.Parameters.AddWithValue("@a", obj1.Achievement);
                cmd2.Parameters.AddWithValue("@date", obj1.EntryDate);
                cmd2.Parameters.AddWithValue("@c", int.Parse(txtCID.Text));
                i = cmd2.ExecuteNonQuery();
            }
            if (i != 0)
            {
                MessageBox.Show("Activity Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Unable to Add Activity.", "Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            con.Close();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}