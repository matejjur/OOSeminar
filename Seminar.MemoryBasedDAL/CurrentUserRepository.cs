using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model.Repositories;

namespace Seminar.MemoryBasedDAL
{
    public class CurrentUserRepository : ICurrentUserRepository
    {

        private static CurrentUserRepository _instance;
        public string Username { get; set; }

        public static CurrentUserRepository getInstance()
        {
            return _instance ?? (_instance = new CurrentUserRepository());
        }

        public void setUsername(string username)
        {
            Username = username;
        }

        public string getUsername()
        {
            return Username;
        }
    }
}
