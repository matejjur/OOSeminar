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
    public partial class RecordEditForm : Form, IRecordEditView
    {
        MainFormController _controller;
        
        public RecordEditForm()
        {
            InitializeComponent();
        }

        public RecordEditForm(MainFormController mc)
        {
            _controller = mc;
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
            Show();
            return true;
        }

        private void descriptionText_TextChanged(object sender, EventArgs e)
        {
            _controller.DescriptionEditText(descriptionText.Text);
        }

        private void feelingText_TextChanged(object sender, EventArgs e)
        {
            _controller.FeelingEditText(feelingText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Save edit changes");
            _controller.SaveEditChanges(dateText.Text);
            Close();
        }
    }
}
