﻿using System.Collections.Generic;

namespace Seminar.Model.Repositories
{
    public interface IRecordRepository
    {
        void addNewRecord(Record record, string currentUserUsername);

        List<Record> getAllRecords(string username);

        void getAllSortedRecords(string username, string sortBy, bool sort);

        Record getRecordByID(string username, string id);

        void AddUserToDictionary(string username, List<Record> records);

        void deleteUserRecords(string username);

        void getFilteredRecords(string username, string feeling, string keywords);

    }
}
