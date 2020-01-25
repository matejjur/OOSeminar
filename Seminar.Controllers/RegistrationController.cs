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

        public string RegisterUserController(ILoginUserView LoginView, IUserRepository usrRepo)
        {
            List<User> allUsers = usrRepo.getAllUsers();
            foreach (User usr in allUsers)
            {
                if (usr.Username.Equals(username)) return "Username already in use";
            }
            //if (password.Length < 8)
            //{
            //    return "Password must be 8 characters or longer";
            //}
            LoginView.ShowViewModal();
            User user = new User(username, password);
            usrRepo.saveUser(user);
            return "User registered";
        }

    }
}
