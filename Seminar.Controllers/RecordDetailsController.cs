using Seminar.Model;
using Seminar.Model.Repositories;
using Seminar.BaseLib;

namespace Seminar.Controllers
{
    class RecordDetailsController
    {

        public void OpenRecordDetails(IRecordDetailsView recordDetailsView, IRecordRepository recordRepository, ICurrentUserRepository currentUserRepository, string id)
        {
            Record record = recordRepository.getRecordByID(currentUserRepository.getUsername(), id);
            recordDetailsView.ShowViewModal(record);
        }

    }
}
