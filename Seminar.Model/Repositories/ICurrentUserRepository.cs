using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.Model.Repositories
{
    public interface ICurrentUserRepository
    {
        void setUsername(string username);
        string getUsername();
    }
}
