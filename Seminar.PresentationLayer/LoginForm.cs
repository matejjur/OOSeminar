﻿using System;
using System.Windows.Forms;
using Seminar.BaseLib;
using Seminar.Controllers;

namespace Seminar.PresentationLayer
{
    public partial class LoginForm : Form, ILoginUserView
    {

        MainFormController _controller;

        public LoginForm(MainFormController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        public bool ShowViewModal()
        {
            Show();
            return true;
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            _controller.UsernameInput(usernameInput.Text);
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            _controller.PasswordInput(passwordInput.Text);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool success = _controller.LoginUser(_controller);
            if (success)
            {
                this.Hide();
            } 
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Wrong username of password", "Login error", button);
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Hide();
            _controller.GoToRegistration(_controller);
        }
    }
}
