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
        public int UserId { get; set; }
        public StatsForm(int id)
        {
            InitializeComponent();
            UserId = id;

            GetUserData(UserId);

        }
        
        private void StatsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDBDataSet.nba_teams' table. You can move, or remove it, as needed.
            this.nba_teamsTableAdapter.Fill(this.sportsDBDataSet.nba_teams);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            CustomizationForm customizationForm = new CustomizationForm();
            this.Hide();
            customizationForm.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void GetUserData(int userId)
        {
            // Fetch user-specific data from the database using the userId
            // For example, you can display the user's name or preferences on the dashboard
            // You can use a database query to retrieve this information and update the UI accordingly
            User user = new User();

            DataRow userData = user.GetUser(userId);
            if (userData != null)
            {
                // Assuming userData contains a column "Name"
                string userName = userData["username"].ToString();
                LblUserGreeting.Text = $"Hey, {userName}!";
            }
            else
            {
                LblUserGreeting.Text = "Welcome, User!";
            }
        }

        private void cbSport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
