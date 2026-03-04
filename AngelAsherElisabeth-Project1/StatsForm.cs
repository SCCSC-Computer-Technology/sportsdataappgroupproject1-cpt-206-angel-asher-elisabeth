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
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {   //Clears combo box
            comboBoxSport.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {   //Opens settings form 
            CustomizationForm settings = new CustomizationForm();
            settings.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   //Closes form
            this.Close();
        }
    }
}
