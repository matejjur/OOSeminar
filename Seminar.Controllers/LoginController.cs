using System;
using Seminar.BaseLib;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class LoginController
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

        public void LoginUserController(IHomeView winFrmFac, IUserRepository usrRepo)
        {
            winFrmFac.ShowViewModal();
            
            Console.WriteLine("Username " + username + " password " + password);
        }
    }
}
