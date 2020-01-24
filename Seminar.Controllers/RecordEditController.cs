using System;
using System.Collections.Generic;
using System.Text;
using Seminar.BaseLib;
using Seminar.Model;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    class RecordEditController
    {

        private string description;
        private string feeling;

        public void OpenRecordEdit(IRecordEditView recordEditView, IRecordRepository recordRepository, string date)
        {
            Record record = recordRepository.getRecordByID(date);
            recordEditView.ShowViewModal(record);
        }

        public void DescriptionEditText(string input)
        {
            description = input;
        }

        public void FeelingEditText(string input)
        {
            feeling = input;
        }

        public void SaveEditChanges(string date, IRecordRepository recordRepository)
        {
            Record record = recordRepository.getRecordByID(date);
            record.Feeling = feeling;
            record.Description = description;
        }

    }
}
