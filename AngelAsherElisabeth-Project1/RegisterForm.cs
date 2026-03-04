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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;
            string email = TxtEmail.Text;
            if (username == "" || password == "" || email == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            User user = new User();
            int result = user.RegisterUser(username, password, email);
            MessageBox.Show("registration result is " + result.ToString());
            

        }

        private void button3_Click(object sender, EventArgs e)
        {   //Clears all fields 
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtEmail.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   //Close form
            this.Close();
        }
    }
}
