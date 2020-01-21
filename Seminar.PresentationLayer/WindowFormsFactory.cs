using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seminar.BaseLib;
using Seminar.Controllers;

namespace Seminar.PresentationLayer
{
    public class WindowFormsFactory : IWindowFormFactory
    {
        public ILoginUserView CreateLoginUserView()
        {
            var form = new LoginForm();
            return form;
        }

        public ILoginUserView CreateLoginUserView(IMainFormController mc)
        {
            var form = new LoginForm((MainFormController)mc);
            return form;
        }

        public IHomeView CreateHomeView()
        {
            var form = new HomeForm();
            return form;
        }

        public IRegistrationView CreateRegistrationView()
        {
            var form = new RegistrationForm();
            return form;
        }
    }
}
