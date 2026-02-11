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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Opens Customization form
            CustomizationForm customizationForm = new CustomizationForm();
            this.Hide();
            customizationForm.Show();
        }
    }
}
