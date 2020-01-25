using System;
using System.Collections.Generic;
using System.Text;
using Seminar.BaseLib;
using Seminar.Model;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormFactory windowFormsFactory = null;
        private readonly IUserRepository userRepository = null;
        private readonly IRecordRepository recordRepository = null;
        private readonly ICurrentUserRepository currentUserRepository = null;

        LoginController loginController = new LoginController();
        RegistrationController registrationController = new RegistrationController();
        HomeController homeController = new HomeController();
        AddRecordController addRecordController = new AddRecordController();
        RecordDetailsController recordDetailsController = new RecordDetailsController();
        RecordEditController recordEditController = new RecordEditController();

        public MainFormController(IWindowFormFactory winForFac, IUserRepository usrRepo, IRecordRepository rcdRepo, ICurrentUserRepository currUsrRepo)
        {
            windowFormsFactory = winForFac;
            userRepository = usrRepo;
            recordRepository = rcdRepo;
            currentUserRepository = currUsrRepo;
        }

        // login
        public void UsernameInput(string input)
        {
            loginController.UsernameInputController(input);
        }

        public void PasswordInput(string input)
        {
            loginController.PasswordInputController(input);
        }

        public bool LoginUser(MainFormController _controller)
        {
            var HomeView = windowFormsFactory.CreateHomeView(_controller);

            return loginController.LoginUserController(HomeView, userRepository, recordRepository, currentUserRepository);
        }

        public void GoToRegistration(MainFormController _controller)
        {
            var RegistrationView = windowFormsFactory.CreateRegistrationView(_controller);
            loginController.GoToRegistration(RegistrationView);
        }


        // registration
        public void UsernameInputRegistration(string input)
        {
            registrationController.UsernameInputController(input);
        }

        public void PasswordInputRegistration(string input)
        {
            registrationController.PasswordInputController(input);
        }

        public string RegisterUser(MainFormController _controller)
        {
            Console.WriteLine("Register user");
            var LoginView = windowFormsFactory.CreateLoginUserView(_controller);
            return registrationController.RegisterUserController(LoginView, userRepository);
        }

        public void GoToLogin(MainFormController _controller)
        {
            var LoginView = windowFormsFactory.CreateLoginUserView(_controller);
            registrationController.GoToLogin(LoginView);
        }

        // home
        public void AddNewRecord(MainFormController _controller)
        {
            var AddNewRecordView = windowFormsFactory.CreateAddNewRecordView(_controller);
            homeController.AddNewRecord(AddNewRecordView, recordRepository);
        }

        public List<Record> RefreshData()
        {
            return homeController.RefreshData(recordRepository);
        }

        public void OpenRecordDetails(MainFormController _controller, string id) // id je date
        {
            Console.WriteLine("Open record details");
            var RecordDetailsView = windowFormsFactory.CreateRecordDetailsView(_controller);
            recordDetailsController.OpenRecordDetails(RecordDetailsView, recordRepository, id);
        }

        public void OpenRecordEdit(MainFormController _controller, string id)
        {
            Console.WriteLine("Open record edit");
            var RecordEditView = windowFormsFactory.CreateRecordEditView(_controller);
            recordEditController.OpenRecordEdit(RecordEditView, recordRepository, id);
        }

        public void Logout(MainFormController _controller)
        {
            Console.WriteLine("Logout user");
            var LoginView = windowFormsFactory.CreateLoginUserView(_controller);
            homeController.LogoutUser(LoginView);
        }

        public void DeleteAccount(MainFormController _controller)
        {
            Console.WriteLine("Delete user");
            var RegistrationView = windowFormsFactory.CreateRegistrationView(_controller);
            homeController.DeleteUser(RegistrationView, userRepository, currentUserRepository);
        }


        // add new record
        public void DescriptionTextChange(string input)
        {
            addRecordController.descriptionChange(input);
        }

        public void FeelingChange(string input)
        {
            addRecordController.feelingChange(input);
        }

        public void DateChange(string input)
        {
            addRecordController.dateChange(input);
        }

        public bool SaveRecord()
        {
            return addRecordController.CreateNewRecord(recordRepository);
        }


        // record details
        public void DescriptionEditText(string input)
        {
            recordEditController.DescriptionEditText(input);
        }

        public void FeelingEditText(string input)
        {
            recordEditController.FeelingEditText(input);
        }

        public void SaveEditChanges(string date)
        {
            recordEditController.SaveEditChanges(date, recordRepository);
        }

    }
}
