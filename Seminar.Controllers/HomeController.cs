using System;
using System.Collections.Generic;
using System.Text;
using Seminar.BaseLib;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    class HomeController
    {
        public string feeling;

        public void AddNewRecord(IAddNewRecordView addNewRecordView, IRecordRepository recordRepository)
        {
            addNewRecordView.ShowViewModal();
            // Record record = new Record(feeling);
            // recordRepository.addNewRecord(record);
        }

    }
}
