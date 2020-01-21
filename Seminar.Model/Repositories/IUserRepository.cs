using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.Model.Repositories
{
    public interface IUserRepository
    {
        void saveUser(User user);
        bool checkCredentials(string username, string password);
    }
}
