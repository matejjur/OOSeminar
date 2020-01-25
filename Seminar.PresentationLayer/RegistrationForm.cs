using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seminar.BaseLib;
using Seminar.Controllers;

namespace Seminar.PresentationLayer
{
    public partial class RegistrationForm : Form, IRegistrationView
    {

        MainFormController _controller;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        public RegistrationForm(MainFormController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        private void usernameRegistrationInput_TextChanged(object sender, EventArgs e)
        {
            _controller.UsernameInputRegistration(usernameRegistrationInput.Text);
        }

        private void passwordRegistrationInput_TextChanged(object sender, EventArgs e)
        {
            _controller.PasswordInputRegistration(passwordRegistrationInput.Text);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string registrationMessage = _controller.RegisterUser(_controller);
            if (registrationMessage == "User registered")
            {
                Hide();
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(registrationMessage, "Registration error", button);
            }
        }

        //TODO provjeriti sta je ovom funkcijom
        public bool ShowViewModal()
        {
            Show();
            return true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Hide();
            _controller.GoToLogin(_controller);
        }
    }
}
