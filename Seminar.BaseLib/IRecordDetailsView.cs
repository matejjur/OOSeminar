using Seminar.Model;

namespace Seminar.BaseLib
{
    public interface IRecordDetailsView
    {

        bool ShowViewModal();
        bool ShowViewModal(Record record);

    }
}
