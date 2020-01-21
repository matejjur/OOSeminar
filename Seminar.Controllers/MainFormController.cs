using System;
using System.Collections.Generic;
using System.Text;
using Seminar.BaseLib;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormFactory windowFormsFactory = null;
        private readonly IUserRepository userRepository = null;

        LoginController loginController = new LoginController();
        RegistrationController registrationController = new RegistrationController();

        public MainFormController(IWindowFormFactory winForFac, IUserRepository usrRepo)
        {
            windowFormsFactory = winForFac;
            userRepository = usrRepo;
        }

        public void UsernameInput(string input)
        {
            loginController.UsernameInputController(input);
        }

        public void PasswordInput(string input)
        {
            loginController.PasswordInputController(input);
        }

        public void LoginUser()
        {
            var HomeView = windowFormsFactory.CreateHomeView();

            loginController.LoginUserController(HomeView, userRepository);
        }

        public void UsernameInputRegistration(string input)
        {
            registrationController.UsernameInputController(input);
        }

        public void PasswordInputRegistration(string input)
        {
            registrationController.PasswordInputController(input);
        }

        public void RegisterUser(MainFormController _controller)
        {
            Console.WriteLine("Register user");
            var LoginView = windowFormsFactory.CreateLoginUserView(_controller);
            registrationController.RegisterUserController(LoginView, userRepository);
        }

        
    }
}
