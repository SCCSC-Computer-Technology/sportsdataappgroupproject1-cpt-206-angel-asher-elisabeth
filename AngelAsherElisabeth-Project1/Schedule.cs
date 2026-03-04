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
    public partial class Schedule : Form
    {

        public string TeamName { get; set; }
        public Schedule(string teamName )
        {
            InitializeComponent();
            TeamName = teamName;
            LbLTeamNameTxt.Text = teamName;
            try
            {
                this.scheduleTableAdapter.FillScheduleByTeam(this.sportsDBDataSet.schedule, teamName);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
