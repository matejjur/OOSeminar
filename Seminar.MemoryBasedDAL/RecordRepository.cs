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
        private List<Record> allRecords = new List<Record>();

        public static RecordRepository getInstance()
        {
            return _instance ?? (_instance = new RecordRepository());
        }

        public void addNewRecord(Record record)
        {
            allRecords.Add(record);
        }

        public List<Record> getAllRecords()
        {
            return allRecords;
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
