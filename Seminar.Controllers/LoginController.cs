using System;
using Seminar.BaseLib;
using Seminar.Model.Repositories;
using Seminar.Model;

namespace Seminar.Controllers
{
    public class LoginController
    {

        public string username = null;
        public string password = null;


        public void UsernameInputController(string input)
        {
            username = input;
        }

        public void PasswordInputController(string input)
        {
            password = input;
        }

        public void LoginUserController(IHomeView HomeView, IUserRepository usrRepo)
        {
            if (usrRepo.checkCredentials(username, password))
            {
                HomeView.ShowViewModal();
                Console.WriteLine("Logged in user");
                Console.WriteLine("Username " + username + " password " + password);
            } else
            {
                Console.WriteLine("Wrong credentials");
            }
        }
    }
}
