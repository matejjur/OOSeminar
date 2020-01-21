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
        private readonly IRecordRepository recordRepository = null;

        LoginController loginController = new LoginController();
        RegistrationController registrationController = new RegistrationController();
        HomeController homeController = new HomeController();
        AddRecordController addRecordController = new AddRecordController();

        public MainFormController(IWindowFormFactory winForFac, IUserRepository usrRepo, IRecordRepository rcdRepo)
        {
            windowFormsFactory = winForFac;
            userRepository = usrRepo;
            recordRepository = rcdRepo;
        }

        public void UsernameInput(string input)
        {
            loginController.UsernameInputController(input);
        }

        public void PasswordInput(string input)
        {
            loginController.PasswordInputController(input);
        }

        public void LoginUser(MainFormController _controller)
        {
            var HomeView = windowFormsFactory.CreateHomeView(_controller);

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



        public void AddNewRecord(MainFormController _controller)
        {
            var AddNewRecordView = windowFormsFactory.CreateAddNewRecordView(_controller);
            homeController.AddNewRecord(AddNewRecordView, recordRepository);
        }
        
        public void DescriptionTextChange(string input)
        {
            addRecordController.descriptionChange(input);
        }

        public void SaveRecord()
        {
            addRecordController.CreateNewRecord(recordRepository);
        }

    }
}
