using System.Collections.Generic;
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

        public bool LoginUser(IMainFormController _controller)
        {
            var HomeView = windowFormsFactory.CreateHomeView(_controller);
            
            loginController.addObserver((IObserver)HomeView, (IObservable)recordRepository);

            return loginController.LoginUserController(HomeView, userRepository, recordRepository, currentUserRepository);
        }

        public void GoToRegistration(IMainFormController _controller)
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

        public string RegisterUser(IMainFormController _controller)
        {
            var LoginView = windowFormsFactory.CreateLoginUserView(_controller);
            return registrationController.RegisterUserController(LoginView, userRepository);
        }

        public void GoToLogin(IMainFormController _controller)
        {
            var LoginView = windowFormsFactory.CreateLoginUserView(_controller);
            registrationController.GoToLogin(LoginView);
        }


        // home
        public void AddNewRecord(IMainFormController _controller)
        {
            var AddNewRecordView = windowFormsFactory.CreateAddNewRecordView(_controller);
            homeController.AddNewRecord(AddNewRecordView, recordRepository);
        }

        public List<Record> RefreshData()
        {
            return homeController.RefreshData(recordRepository, currentUserRepository);
        }

        public void OpenRecordDetails(IMainFormController _controller, string id) // id je date
        {
            var RecordDetailsView = windowFormsFactory.CreateRecordDetailsView();
            recordDetailsController.OpenRecordDetails(RecordDetailsView, recordRepository, currentUserRepository, id);
        }

        public void OpenRecordEdit(IMainFormController _controller, string id)
        {
            var RecordEditView = windowFormsFactory.CreateRecordEditView(_controller);
            recordEditController.OpenRecordEdit(RecordEditView, recordRepository, currentUserRepository, id);
        }

        public void Logout(IMainFormController _controller)
        {
            var LoginView = windowFormsFactory.CreateLoginUserView(_controller);
            homeController.LogoutUser(LoginView);
        }

        public void DeleteAccount(IMainFormController _controller)
        {
            var RegistrationView = windowFormsFactory.CreateRegistrationView(_controller);
            homeController.DeleteUser(RegistrationView, userRepository, recordRepository, currentUserRepository);
        }

        public void SortByFeeling(bool sort)
        {
            homeController.SortByFeeling(sort, recordRepository, currentUserRepository);
        }

        public void SortByDate(bool sort)
        {
            homeController.SortByDate(sort, recordRepository, currentUserRepository);
        }

        public void FilterRecords(IMainFormController _controller)
        {
            homeController.FilterRecords(recordRepository, currentUserRepository);
        }

        public void FeelingFilterChange(string input)
        {
            homeController.feelingFilter(input);
        }

        public void KeywordsFilterChange(string input)
        {
            homeController.keywordsFilter(input);
        }


        // add new record
        public void DescriptionTextChange(string input)
        {
            addRecordController.descriptionChange(input);
        }

        public void DietTextChange(string input)
        {
            addRecordController.dietChange(input);
        }

        public void KeywordsTextChange(string input)
        {
            addRecordController.keywordsChange(input);
        }

        public void FeelingChange(string input)
        {
            addRecordController.feelingChange(input);
        }

        public void DateChange(string input)
        {
            addRecordController.dateChange(input);
        }

        public string SaveRecord()
        {
            return addRecordController.CreateNewRecord(recordRepository, currentUserRepository);
        }


        // edit record details
        public void DescriptionEditText(string input)
        {
            recordEditController.DescriptionEditText(input);
        }

        public void FeelingEditText(string input)
        {
            recordEditController.FeelingEditText(input);
        }

        public void DietEditText(string input)
        {
            recordEditController.DietEditText(input);
        }

        public void KeywordsEditText(string input)
        {
            recordEditController.KeywordsEditText(input);
        }

        public void SaveEditChanges(string date)
        {
            recordEditController.SaveEditChanges(date, recordRepository, currentUserRepository);
        }
    }
}
