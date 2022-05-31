using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Admin_Home : Form
    {
        public static string name;
        public Admin_Home()
        {
            InitializeComponent();
        }
        public Admin_Home(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = $"Hello {name}.";
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            Register_User ru = new Register_User();
            ru.ShowDialog();
        }

        private void btnViewClub_Click(object sender, EventArgs e)
        {
            View_Clubs vc = new View_Clubs();
            vc.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }
    }
}
