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

        public string Username => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public bool ShowViewModal()
        {
            Console.WriteLine("LoginForm.cs ShowViewModal()");
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            _controller.LoginUser();
        }
    }
}
