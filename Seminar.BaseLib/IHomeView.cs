using Seminar.Model.Repositories;

namespace Seminar.BaseLib
{
    public interface IHomeView
    {
        bool ShowViewModal();
        bool ShowViewModal(IRecordRepository recordRepository, ICurrentUserRepository currentUserRepository);
    }
}
