using System;
using System.Windows.Forms;
using Seminar.BaseLib;
using Seminar.Controllers;
using Seminar.Model;

namespace Seminar.PresentationLayer
{
    public partial class RecordEditForm : Form, IRecordEditView
    {
        MainFormController _controller;

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
            dietText.Text = record.Diet;
            keywordsText.Text = record.Keywords;
            Show();
            return true;
        }

        private void descriptionText_TextChanged(object sender, EventArgs e)
        {
            _controller.DescriptionEditText(descriptionText.Text);
        }

        private void dietText_TextChanged(object sender, EventArgs e)
        {
            _controller.DietEditText(dietText.Text);
        }

        private void keywordsText_TextChanged(object sender, EventArgs e)
        {
            _controller.KeywordsEditText(keywordsText.Text);
        }

        private void feelingText_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.FeelingEditText(feelingText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.SaveEditChanges(dateText.Text);
            Close();
        }
    }
}
