using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model.Repositories;

namespace Seminar.BaseLib
{
    public interface IHomeView
    {
        bool ShowViewModal();
        bool ShowViewModal(IRecordRepository recordRepository);
    }
}
