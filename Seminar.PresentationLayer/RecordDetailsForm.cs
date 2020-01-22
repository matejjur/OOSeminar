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
            InitializeComponent();
            _controller = inController;
        }

        public bool ShowViewModal()
        {
            Show();
            return true;
        }

        public bool ShowViewModal(string id)
        {
            Console.WriteLine("RecordDetailsForm");
            Console.WriteLine(id);
            Show();
            return true;
        }
    }
}
