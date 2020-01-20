using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.BaseLib
{
    public interface IWindowFormFactory
    {

        ILoginUserView CreateLoginUserView();
        IHomeView CreateHomeView();
    }
}
