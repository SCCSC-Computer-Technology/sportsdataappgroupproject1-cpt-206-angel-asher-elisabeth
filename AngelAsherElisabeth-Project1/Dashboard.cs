using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelAsherElisabeth_Project1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnSport1_Click(object sender, EventArgs e)
        {
            //Opens Stat form From Button1 
            StatsForm statsForm = new StatsForm();
            this.Hide();
            statsForm.Show();
        }

        private void btnSport2_Click(object sender, EventArgs e)
        {
            //Opens Stat form From Button2
            StatsForm statsForm = new StatsForm();
            this.Hide();
            statsForm.Show();
        }
    }
}
