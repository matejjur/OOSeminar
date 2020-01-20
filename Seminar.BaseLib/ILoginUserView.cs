using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.BaseLib
{
    public interface ILoginUserView
    {
        bool ShowViewModal();

        string Username { get; }
        string Password { get; }
    }
}
