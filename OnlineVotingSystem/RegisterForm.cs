using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineVotingSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            UserData.RegisteredUsername = txtName.Text;    // Or whatever textbox you used for name
            UserData.RegisteredEmail = txtEmail.Text;
            UserData.RegisteredAddress = txtAddress.Text;
            UserData.RegisteredPassword = txtPassword.Text;

            // TODO: Validate and send to database
            MessageBox.Show("User registered: " + name);
            // [Optional] Save registration data here

            // Show Login Form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close or hide current form
            this.Hide(); // or this.Close();


        }

       // private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
          //  LoginForm loginForm = new LoginForm();
           // loginForm.Show();
           // this.Hide();
       //
        private void lnkLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
