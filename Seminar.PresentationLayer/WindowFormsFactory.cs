using Seminar.BaseLib;
using Seminar.Controllers;

namespace Seminar.PresentationLayer
{
    public class WindowFormsFactory : IWindowFormFactory
    {
        public ILoginUserView CreateLoginUserView(IMainFormController mc)
        {
            var form = new LoginForm((MainFormController)mc);
            return form;
        }

        public IHomeView CreateHomeView(IMainFormController mc)
        {
            var form = new HomeForm((MainFormController)mc);
            return form;
        }

        public IRegistrationView CreateRegistrationView(IMainFormController mc)
        {
            var form = new RegistrationForm((MainFormController)mc);
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

        public IRecordEditView CreateRecordEditView(IMainFormController mc)
        {
            var form = new RecordEditForm((MainFormController)mc);
            return form;
        }
    }
}
