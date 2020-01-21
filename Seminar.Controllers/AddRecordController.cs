using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class AddRecordController
    {

        public string description;

        public void descriptionChange(string input)
        {
            description = input;
        }

        public void CreateNewRecord(IRecordRepository recordRepository) 
        {
            Record record = new Record(description);
            recordRepository.addNewRecord(record);
        }

    }
}
