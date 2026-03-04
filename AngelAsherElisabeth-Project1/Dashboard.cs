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
        public int UserId { get; set; }
        public Dashboard(int id)
        {
            InitializeComponent();
            UserId = id;
            
            GetUserData(UserId);

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
    }
}
