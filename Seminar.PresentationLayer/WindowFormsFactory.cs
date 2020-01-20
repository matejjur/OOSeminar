using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seminar.BaseLib;

namespace Seminar.PresentationLayer
{
    public class WindowFormsFactory : IWindowFormFactory
    {
        public ILoginUserView CreateLoginUserView()
        {
            var form = new LoginForm();
            return form;
        }
    }
}
