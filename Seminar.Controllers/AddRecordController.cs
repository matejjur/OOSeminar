using System.Collections.Generic;
using Seminar.Model;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class AddRecordController
    {

        public string feeling = "";
        public string description = "";
        public string date = "";
        public string diet = "";
        public string keywords = "";


        public void descriptionChange(string input)
        {
            description = input;
        }

        public void dietChange(string input)
        {
            diet = input;
        }

        public void feelingChange(string input)
        {
            feeling = input;
        }

        public void dateChange(string input)
        {
            date = input;
        }

        public void keywordsChange(string input)
        {
            keywords = input;
        }

        private void resetValues()
        {
            feeling = "";
            description = "";
            date = "";
            diet = "";
            keywords = "";
        }

        public string CreateNewRecord(IRecordRepository recordRepository, ICurrentUserRepository currentUserRepository) 
        {
            if (feeling != "")
            {
                List<Record> allRecords = recordRepository.getAllRecords(currentUserRepository.getUsername());
                foreach (Record rec in allRecords)
                {
                    if (rec.Date == date)
                    {
                        return "dateError";
                    }
                }
                Record record = new Record(feeling, description, date, diet, keywords);
                recordRepository.addNewRecord(record, currentUserRepository.getUsername());
                resetValues();
                return "";
            }
            else
            {
                return "feelingError";
            }
            
        }

    }
}
