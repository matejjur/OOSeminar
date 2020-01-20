using System;
using Seminar.BaseLib;
using Seminar.Model.Repositories;

namespace Seminar.Controllers
{
    public class LoginController
    {

        public void LoginUser(ILoginUserView winFrmFac, IUserRepository usrRepo)
        {
            Console.WriteLine("LoginUser() in LoginController");
        }

    }
}
