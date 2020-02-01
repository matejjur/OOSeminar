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

        private void dietText_TextChanged(object sender, EventArgs e)
        {
            _controller.DietTextChange(dietText.Text);
        }

        private void keywordsText_TextChanged(object sender, EventArgs e)
        {
            _controller.KeywordsTextChange(keywordsText.Text);
        }

        // feeling
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.FeelingChange(comboBox1.Text);
        }

        // date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _controller.DateChange(dateTimePicker1.Text);
            Console.WriteLine("DATUM");
            Console.WriteLine(dateTimePicker1.Text);
        }

        // date
        private void saveButton_Click(object sender, EventArgs e)
        {
            _controller.DateChange(dateTimePicker1.Text); // u slucaju ako se ostavi defaultno, odnosno danasnji dan
            string successMessage = _controller.SaveRecord();
            if (successMessage == "")
            {
                Close();
            }
            else if (successMessage == "dateError")
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Record with this date already exists", "Existing date error", button);
            }
            else if (successMessage == "feelingError") 
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("You have to enter your feeling", "Missing feeling error", button);
            }
        }
    }
}
