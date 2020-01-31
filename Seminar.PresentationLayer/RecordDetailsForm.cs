using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seminar.BaseLib;
using Seminar.Controllers;
using Seminar.Model;

namespace Seminar.PresentationLayer
{
    public partial class RecordDetailsForm : Form, IRecordDetailsView
    {

        MainFormController _controller;

        public RecordDetailsForm()
        {
            InitializeComponent();
        }

        public RecordDetailsForm(MainFormController inController)
        {
            _controller = inController;
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
