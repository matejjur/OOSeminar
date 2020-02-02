using System.Windows.Forms;
using Seminar.BaseLib;
using Seminar.Model;

namespace Seminar.PresentationLayer
{
    public partial class RecordDetailsForm : Form, IRecordDetailsView
    {

        public RecordDetailsForm()
        {
            InitializeComponent();
        }

        public bool ShowViewModal()
        {
            Show();
            return true;
        }

        public bool ShowViewModal(Record record)
        {
            feelingText.Text = record.Feeling;
            descriptionText.Text = record.Description;
            dateText.Text = record.Date;
            dietText.Text = record.Diet;
            keywordsText.Text = record.Keywords;
            Show();
            return true;
        }
    }
}
