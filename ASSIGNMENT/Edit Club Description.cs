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
    public partial class Edit_Club_Description : Form
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCS"].ToString());
        public Edit_Club_Description(string n)
        {
            InitializeComponent();
            name = n;
        }
        public Edit_Club_Description()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string desc = txtEdit.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand($"update clubInfo set description =@desc", con);
            cmd.Parameters.AddWithValue("@desc", desc);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Description Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Description Update Unsuccessful.", "Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void Edit_Club_Description_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from clubInfo where representative ='{name}'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txtEdit.Text = rd.GetString(5);
            }
            con.Close();
        }
    }
}