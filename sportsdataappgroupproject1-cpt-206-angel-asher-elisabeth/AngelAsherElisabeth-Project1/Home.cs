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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDBDataSet.sports' table. You can move, or remove it, as needed.
            this.sportsTableAdapter.Fill(this.sportsDBDataSet.sports);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
