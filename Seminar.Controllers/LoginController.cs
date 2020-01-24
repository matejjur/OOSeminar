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

        public bool LoginUserController(IHomeView HomeView, IUserRepository usrRepo, IRecordRepository recRepo)
        {
            if (usrRepo.checkCredentials(username, password))
            {
                HomeView.ShowViewModal(recRepo); // saljes usrRepo tako da nakon sta se drugi put logira da povuce podatke
                Console.WriteLine("Logged in user");
                Console.WriteLine("Username " + username + " password " + password);
                return true;
            }
            Console.WriteLine("Wrong credentials");
            return false;
        }
    }
}
