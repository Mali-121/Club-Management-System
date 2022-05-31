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
    public partial class View_Clubs : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["clubCs"].ToString());
        public View_Clubs()
        {
            InitializeComponent();
        }

        private void View_Clubs_Load(object sender, EventArgs e)
        {
            this.clubInfoTableAdapter.Fill(this.clubDBDataSet1.clubInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Register_Club rc = new Register_Club();
            rc.ShowDialog();
            this.clubInfoTableAdapter.Fill(this.clubDBDataSet1.clubInfo);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var clubID = Convert.ToInt32(dgvViewClubs.SelectedRows[0].Cells[0].Value);
                Update_Club_Details ucd = new Update_Club_Details(clubID);
                this.Close();
                ucd.Show();
                ucd.Focus();
            }
            catch
            {
                MessageBox.Show("Please select a club to update.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            try
            {
                var clubID = Convert.ToInt32(dgvViewClubs.SelectedRows[0].Cells[0].Value);
                string status = dgvViewClubs.SelectedRows[0].Cells[7].Value.ToString();
                if (status == "Active")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"update clubInfo set status='Archived' where clubID={clubID}", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Club has been archived.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clubInfoTableAdapter.Fill(this.clubDBDataSet1.clubInfo);
                }
                else
                {
                    MessageBox.Show("The selected club is already archived", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please selecg a club first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnarchive_Click(object sender, EventArgs e)
        {
            try
            {
                var clubID = Convert.ToInt32(dgvViewClubs.SelectedRows[0].Cells[0].Value);
                string status = dgvViewClubs.SelectedRows[0].Cells[7].Value.ToString();
                if (status == "Archived")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"update clubInfo set status='Active' where clubID={clubID}", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Club has been unarchived.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clubInfoTableAdapter.Fill(this.clubDBDataSet1.clubInfo);
                }
                else
                {
                    MessageBox.Show("The selected club is already active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please selecg a club first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
