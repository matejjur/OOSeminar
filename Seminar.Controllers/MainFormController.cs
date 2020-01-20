using System;
using System.Collections.Generic;
using System.Text;
using Seminar.BaseLib;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormFactory windowFormFactory = null;
        private readonly IUserRepository userRepository = null;

        LoginController loginController = new LoginController();


        public MainFormController(IWindowFormFactory winForFac, IUserRepository usrRepo)
        {
            windowFormFactory = winForFac;
            userRepository = usrRepo;
        }

        public void UsernameInput(string input)
        {
            var newFrm = windowFormFactory.CreateLoginUserView();

            loginController.UsernameInputController(input);
        }

        public void PasswordInput(string input)
        {
            loginController.PasswordInputController(input);
        }

        public void LoginUser()
        {
            var newFrm = windowFormFactory.CreateHomeView();

            loginController.LoginUserController(newFrm, userRepository);
        }

        
    }
}
