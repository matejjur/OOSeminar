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
    public partial class LoginForm : Form, ILoginUserView
    {

        MainFormController _controller;

        public LoginForm()
        {
            InitializeComponent();
        }

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
            this.Hide();
            _controller.LoginUser();
        }

        private void Login_Click(object sender, EventArgs e) {}
    }
}
