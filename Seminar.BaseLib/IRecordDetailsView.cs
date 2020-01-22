using System;
using System.Collections.Generic;
using System.Text;
using Seminar.Model;

namespace Seminar.BaseLib
{
    public interface IRecordDetailsView
    {

        bool ShowViewModal();
        bool ShowViewModal(Record record);

    }
}
