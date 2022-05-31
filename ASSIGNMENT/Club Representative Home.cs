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
    public partial class ClubDetail : Form
    {
        public static string name;
        public static int clubID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCS"].ToString());
        public ClubDetail()
        {
            InitializeComponent();
        }
        public ClubDetail(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Club_Description ecd = new Edit_Club_Description(name);
            ecd.ShowDialog();
            Club_detail_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Club_Activity a = new Add_Club_Activity(name);
            a.ShowDialog();
            Club_detail_Load(sender, e);
        }

        private void Club_detail_Load(object sender, EventArgs e)
        {
            this.activityTableAdapter.Fill(this.clubDBDataSet.activity);
            lblCName.Text = $"Welcome, {name}";
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
                lblDscptn.Text = rd2.GetString(5);
                clubID = rd2.GetInt32(0);
            }
            rd2.Close();
            SqlCommand cmd3 = new SqlCommand($"select * from activity where clubID ={clubID}", con);
            SqlDataReader rd3 = cmd3.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd3);
            dgvActivities.DataSource = dt;
            dgvActivities.Refresh();
            con.Close();
        }
    }
}
