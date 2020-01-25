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

        public bool checkCredentials(string username, string password)
        {
            foreach (var user in allUsers)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public List<User> getAllUsers()
        {
            return allUsers;
        }

        public User findUserByID(string id)
        {
            foreach (User user in allUsers)
            {
                if (user.Username == id)
                {
                    return user;
                }
            }
            return new User("Not found", "Not found");
        }

        public void DeleteUser(User user)
        {
            allUsers.Remove(user);
        }
    }
}
