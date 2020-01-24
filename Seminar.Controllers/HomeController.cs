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

    }
}
