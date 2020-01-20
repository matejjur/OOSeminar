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


        public MainFormController(IWindowFormFactory winForFac, IUserRepository usrRepo)
        {
            windowFormFactory = winForFac;
            userRepository = usrRepo;
        }

        public void LoginUser()
        {
            var loginController = new LoginController();

            var newFrm = windowFormFactory.CreateLoginUserView();

            loginController.LoginUser(newFrm, userRepository);
        }
    }
}
