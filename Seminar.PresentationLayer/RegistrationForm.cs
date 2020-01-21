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
            this.Hide();
            _controller.RegisterUser(_controller);
        }

        //TODO provjeriti sta je ovom funkcijom
        public bool ShowViewModal()
        {
            Show();
            return true;
        }
    }
}
