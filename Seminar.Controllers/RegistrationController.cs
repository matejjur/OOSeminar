using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model;
using Seminar.Model.Repositories;
using Seminar.BaseLib;

namespace Seminar.Controllers
{
    class RegistrationController
    {

        public string username;
        public string password;

        public void UsernameInputController(string input)
        {
            username = input;
        }

        public void PasswordInputController(string input)
        {
            password = input;
        }

        public void RegisterUserController(ILoginUserView LoginView, IUserRepository usrRepo)
        {
            LoginView.ShowViewModal();
            User user = new User(username, password);
            usrRepo.saveUser(user);
        }

    }
}
