using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.BaseLib
{
    public interface IWindowFormFactory
    {
        ILoginUserView CreateLoginUserView();
        ILoginUserView CreateLoginUserView(IMainFormController mc);
        IHomeView CreateHomeView();
        IRegistrationView CreateRegistrationView();
    }
}
