using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class AddRecordController
    {

        public string feeling;
        public string description;
        public string date;


        public void descriptionChange(string input)
        {
            description = input;
        }

        public void feelingChange(string input)
        {
            feeling = input;
        }

        public void dateChange(string input)
        {
            date = input;
        }

        public void CreateNewRecord(IRecordRepository recordRepository) 
        {
            Record record = new Record(feeling, description, date);
            recordRepository.addNewRecord(record);
        }

    }
}
