using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.BaseLib
{
    public interface IRecordDetailsView
    {

        bool ShowViewModal();
        bool ShowViewModal(string id);

    }
}
