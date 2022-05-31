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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ClubReport cr = new ClubReport();
            cr.Show();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            ActivitiesReport ar = new ActivitiesReport();
            ar.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
