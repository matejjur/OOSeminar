using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model;
using Seminar.Model.Repositories;

namespace Seminar.MemoryBasedDAL
{
    public class UserRepository : IUserRepository
    {
        private static UserRepository _instance;
        private List<User> allUsers = new List<User>();

        public static UserRepository getInstance()
        {
            return _instance ?? (_instance = new UserRepository());
        }

        public void saveUser(User user)
        {
            allUsers.Add(user);
        }
    }
}
