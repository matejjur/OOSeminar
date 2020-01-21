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
    public partial class AddNewRecordForm : Form, IAddNewRecordView
    {
        MainFormController _controller;
        public AddNewRecordForm()
        {
            InitializeComponent();
        }

        public AddNewRecordForm(MainFormController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        public bool ShowViewModal()
        {
            Show();
            return true;
        }

        private void descriptionText_TextChanged(object sender, EventArgs e)
        {
            _controller.DescriptionTextChange(descriptionText.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _controller.SaveRecord();
            this.Close();
        }
    }
}
