using System;
using Seminar.BaseLib;
using Seminar.Model.Repositories;
using Seminar.Model;
using System.Collections.Generic;

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

        public void addObserver(IObserver HomeView, IObservable recordRepository)
        {
            recordRepository.Attach(HomeView);
        }

        public bool LoginUserController(IHomeView HomeView, IUserRepository usrRepo, IRecordRepository recRepo, ICurrentUserRepository currUsrRepo)
        {
            if (usrRepo.checkCredentials(username, password))
            {
                currUsrRepo.setUsername(username);
                recRepo.AddUserToDictionary(username, new List<Record>());
                HomeView.ShowViewModal(recRepo, currUsrRepo); // saljes usrRepo tako da nakon sta se drugi put logira da povuce podatke
                Console.WriteLine("Logged in user " + username + " password " + password);
                return true;
            }
            Console.WriteLine("Wrong credentials");
            return false;
        }

        public void GoToRegistration(IRegistrationView RegistrationView)
        {
            RegistrationView.ShowViewModal();
        }
    }
}
