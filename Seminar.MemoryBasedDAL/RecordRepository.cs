using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model.Repositories;
using Seminar.Model;
using System.Collections.ObjectModel;
using System.Linq;
using Seminar.BaseLib;

namespace Seminar.MemoryBasedDAL
{
    public class RecordRepository : IRecordRepository, IObservable
    {
        private static RecordRepository _instance;
        private Dictionary<string, List<Record>> userRecords = new Dictionary<string, List<Record>>(); // username i njegovi recordsi

        public List<IObserver> _listObservers = new List<IObserver>();

        //private List<Record> allRecords = new List<Record>();

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
            Console.WriteLine(record.Date);
            List<Record> temp = userRecords[currentUserUsername];
            temp.Add(record);
            NotifyObservers();
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

        public void getAllSortedRecords(string username, string sortBy, bool sort)
        {
            List<Record> temp = userRecords[username];
            List<Record> sorted = null;
            if (sortBy == "feeling")
            {
                if (sort)
                {
                    sorted = temp.OrderBy(o => o.Feeling).ToList();
                }
                else
                {
                    sorted = temp.OrderByDescending(o => o.Feeling).ToList();
                }
            }
            else if (sortBy == "date")
            {
                if (sort)
                {
                    sorted = temp.OrderBy(o => {
                        DateTime dt;
                        DateTime.TryParse(o.Date, out dt);
                        return dt;
                    }).ToList();
                }
                else
                {
                    sorted = temp.OrderByDescending(o => {
                        DateTime dt;
                        DateTime.TryParse(o.Date, out dt);
                        return dt;
                    }).ToList();
                }
            }
            userRecords[username] = sorted;
            NotifyObservers();
        }

        public Record getRecordByID(string username, string id)
        {
            List<Record> currentUserRecords = userRecords[username];
            foreach (Record record in currentUserRecords)
            {
                if (record.Date == id)
                {
                    return record;
                }
            }
            return new Record("Not found", "Not found", "Not found", "Not found", "Not found");
        }

        public void deleteUserRecords(string username)
        {
            userRecords.Remove(username);
        }

        public void Attach(IObserver obs)
        {
            _listObservers.Add(obs);
        }

        public void Delete(IObserver obs)
        {
            _listObservers.Remove(obs);
        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in _listObservers)
                obs.Updt();
        }
    }
}
