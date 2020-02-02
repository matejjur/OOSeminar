using Seminar.Model;

namespace Seminar.BaseLib
{
    public interface IRecordEditView
    {
        bool ShowViewModal();
        bool ShowViewModal(Record record);
    }
}
