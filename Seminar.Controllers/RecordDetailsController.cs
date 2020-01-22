using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model;
using Seminar.Model.Repositories;
using Seminar.BaseLib;

namespace Seminar.Controllers
{
    class RecordDetailsController
    {

        public void OpenRecordDetails(IRecordDetailsView recordDetailsView, IRecordRepository recordRepository, string id)
        {
            Record record = recordRepository.getRecordByID(id);
            recordDetailsView.ShowViewModal(record);
        }

    }
}
