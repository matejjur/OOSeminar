namespace Seminar.BaseLib
{
    public interface IWindowFormFactory
    {
        ILoginUserView CreateLoginUserView(IMainFormController mc);
        IHomeView CreateHomeView(IMainFormController mc);
        IRegistrationView CreateRegistrationView(IMainFormController mc);
        IAddNewRecordView CreateAddNewRecordView(IMainFormController mc);
        IRecordDetailsView CreateRecordDetailsView();
        IRecordEditView CreateRecordEditView(IMainFormController mc);
    }
}
