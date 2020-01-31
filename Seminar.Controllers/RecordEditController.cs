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
        private string diet;
        private string keywords;

        public void OpenRecordEdit(IRecordEditView recordEditView, IRecordRepository recordRepository, ICurrentUserRepository currentUserRepository, string date)
        {
            Record record = recordRepository.getRecordByID(currentUserRepository.getUsername(), date);
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

        public void DietEditText(string input)
        {
            diet = input;
        }
         
        public void KeywordsEditText(string input)
        {
            keywords = input;
        }

        public void SaveEditChanges(string date, IRecordRepository recordRepository, ICurrentUserRepository currentUserRepository)
        {
            Record record = recordRepository.getRecordByID(currentUserRepository.getUsername(), date);
            record.Feeling = feeling;
            record.Description = description;
            record.Diet = diet;
            record.Keywords = keywords;
        }

    }
}
