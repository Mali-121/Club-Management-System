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
    public partial class StudentHome : Form
    {
        public static string name;
        public StudentHome()
        {
            InitializeComponent();
        }
        public StudentHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clubDBDataSet6.clubInfo' table. You can move, or remove it, as needed.
            this.clubInfoTableAdapter2.Fill(this.clubDBDataSet6.clubInfo);
            // TODO: This line of code loads data into the 'clubDBDataSet5.clubInfo' table. You can move, or remove it, as needed.
            this.clubInfoTableAdapter1.Fill(this.clubDBDataSet5.clubInfo);
            // TODO: This line of code loads data into the 'clubDBDataSet2.clubInfo' table.
            this.clubInfoTableAdapter.Fill(this.clubDBDataSet2.clubInfo);
            lblIdentity.Text = $"Welcome {name}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
