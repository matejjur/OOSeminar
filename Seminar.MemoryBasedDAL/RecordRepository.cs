using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model.Repositories;
using Seminar.Model;

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

        public void addNewRecord()
        {
            // allRecords.Add(record);
            throw new NotImplementedException();
        }
    }
}
