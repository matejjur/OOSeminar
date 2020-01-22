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

        public IHomeView CreateHomeView(IMainFormController mc)
        {
            var form = new HomeForm((MainFormController)mc);
            return form;
        }

        public IRegistrationView CreateRegistrationView()
        {
            var form = new RegistrationForm();
            return form;
        }

        public IAddNewRecordView CreateAddNewRecordView()
        {
            var form = new AddNewRecordForm();
            return form;
        }

        public IAddNewRecordView CreateAddNewRecordView(IMainFormController mc)
        {
            var form = new AddNewRecordForm((MainFormController)mc);
            return form;
        }

        public IRecordDetailsView CreateRecordDetailsView()
        {
            var form = new RecordDetailsForm();
            return form;
        }

        public IRecordDetailsView CreateRecordDetailsView(IMainFormController mc)
        {
            var form = new RecordDetailsForm((MainFormController)mc);
            return form;
        }
    }
}
