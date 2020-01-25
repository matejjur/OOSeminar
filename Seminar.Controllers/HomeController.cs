using System;
using System.Collections.Generic;
using System.Text;
using Seminar.BaseLib;
using Seminar.Model;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    class HomeController
    {

        public void AddNewRecord(IAddNewRecordView addNewRecordView, IRecordRepository recordRepository)
        {
            addNewRecordView.ShowViewModal();
        }

        public List<Record> RefreshData(IRecordRepository recordRepository)
        {
            return recordRepository.getAllRecords();
        }

        public void LogoutUser(ILoginUserView loginUserView) {
            loginUserView.ShowViewModal();
        }

        public void DeleteUser(IRegistrationView registrationView, IUserRepository userRepository, ICurrentUserRepository currUsrRepo)
        {
            string currentUserUsername = currUsrRepo.getUsername();
            User user = userRepository.findUserByID(currentUserUsername);
            userRepository.DeleteUser(user);
            registrationView.ShowViewModal();

            Console.WriteLine(userRepository.getAllUsers().Count);
        }

    }
}
