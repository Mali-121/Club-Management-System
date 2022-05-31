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
    public partial class ActivitiesReport : Form
    {
        public ActivitiesReport()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCS"].ToString());
        private void ActivitiesReport_Load(object sender, EventArgs e)
        {
            this.activityTableAdapter.Fill(this.clubDBDataSet4.activity);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date = txtDateTime.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from activity where date ='{date}'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvActivityReport.DataSource = dt;
            dgvActivityReport.Refresh();
            conn.Close();
        }
    }
}
