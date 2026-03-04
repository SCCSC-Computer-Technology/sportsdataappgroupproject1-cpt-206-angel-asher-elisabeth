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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            //Opens the RegisterForm
            RegisterForm registerForm = new RegisterForm();
            this.Hide(); 
            registerForm.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            string  username = textBox1.Text;
            string password = textBox2.Text;
            int loginResult = user.Login(username, password);
            
            if (loginResult < 0)
            {
                MessageBox.Show("Login failed! Try Again");
                // Proceed to the next form or functionality
            }
            else { 
                MessageBox.Show("Login successful! Welcome, " + username);
                // Proceed to the next form or functionality
                StatsForm statsForm = new StatsForm(loginResult);
                this.Hide();
                statsForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Clears the username and password textbox
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form1 
            this.Close();
        }
    }
}
