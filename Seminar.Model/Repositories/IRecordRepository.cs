using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.Model.Repositories
{
    public interface IRecordRepository
    {
        void addNewRecord(Record record, string currentUserUsername);

        List<Record> getAllRecords(string username);

        Record getRecordByID(string id);

        void AddUserToDictionary(string username, List<Record> records);

    }
}
