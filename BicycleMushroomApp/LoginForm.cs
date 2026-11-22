using System;
using System.Windows.Forms;

namespace BicycleMushroomApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                ChooseForm chooseForm = new ChooseForm();
                chooseForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }
    }
}