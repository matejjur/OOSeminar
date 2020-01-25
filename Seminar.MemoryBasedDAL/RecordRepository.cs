using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model.Repositories;
using Seminar.Model;
using System.Collections.ObjectModel;

namespace Seminar.MemoryBasedDAL
{
    public class RecordRepository : IRecordRepository
    {
        private static RecordRepository _instance;
        private Dictionary<string, List<Record>> userRecords = new Dictionary<string, List<Record>>(); // username i njegovi recordsi

        private List<Record> allRecords = new List<Record>();

        public static RecordRepository getInstance()
        {
            return _instance ?? (_instance = new RecordRepository());
        }

        public void AddUserToDictionary(string username, List<Record> records)
        {
            if (!userRecords.ContainsKey(username))
            {
                userRecords.Add(username, records);
            }
        }

        public void addNewRecord(Record record, string currentUserUsername) // tu ide logika za dictionary
        {
            List<Record> temp = userRecords[currentUserUsername];
            temp.Add(record);
            userRecords[currentUserUsername] = temp;
            // allRecords.Add(record);
        }

        public List<Record> getAllRecords(string username)
        {
            Console.WriteLine("Username");
            Console.WriteLine(username);
            return userRecords[username];
            // return allRecords;
        }

        public Record getRecordByID(string id)
        {
            foreach (Record record in allRecords)
            {
                if (record.Date == id)
                {
                    return record;
                }
            }
            return new Record("Not found", "Not found", "Not found");
        }
    }
}
