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
        IHomeView CreateHomeView(IMainFormController mc);
        IRegistrationView CreateRegistrationView();
        IRegistrationView CreateRegistrationView(IMainFormController mc);
        IAddNewRecordView CreateAddNewRecordView();
        IAddNewRecordView CreateAddNewRecordView(IMainFormController mc);
        IRecordDetailsView CreateRecordDetailsView();
        IRecordDetailsView CreateRecordDetailsView(IMainFormController mc);
        IRecordEditView CreateRecordEditView();
        IRecordEditView CreateRecordEditView(IMainFormController mc);
    }
}
