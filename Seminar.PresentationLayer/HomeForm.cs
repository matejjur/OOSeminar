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
using Seminar.Model.Repositories;

namespace Seminar.PresentationLayer
{
    public partial class HomeForm : Form, IHomeView
    {

        MainFormController _controller;
        private string selectedDateForEdit;
        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(MainFormController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        //private void HomeForm_Shown()
        //{
        //    listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
        //    listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
        //    listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
        //}

        public bool ShowViewModal()
        {
            Show();
            return true;
        }

        public bool ShowViewModal(IRecordRepository recordRepository)
        {
            List<Record> allRecords = recordRepository.getAllRecords();
            foreach (Record record in allRecords)
            {
                listView1.Items.Add(new ListViewItem(new string[] { record.Date, record.Feeling, record.Description }));
            }
            // HomeForm_Shown();
            Show();
            return true;
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            _controller.AddNewRecord(_controller);
        }

        private void showDetails(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0] != null)
            {
                string date = listView1.SelectedItems[0].Text;
                _controller.OpenRecordDetails(_controller, date);
            }
        }

        private void editRecord(object sender, EventArgs e) // ListViewItem click
        {
            if (listView1.SelectedItems.Count == 0) return;
            selectedDateForEdit = listView1.SelectedItems[0].Text;
        }


        /* TODO napraviti da uzme samo one ciji su indeksi veci od this.listView1.Items.Count */
        private void refreshButton_Click(object sender, EventArgs e)
        {
            // HomeForm_Shown();
            var records = _controller.RefreshData();
            foreach (var record in records)
            {
                Console.WriteLine(record.Description);
                this.listView1.Items.Add(new ListViewItem(new string[] { record.Date, record.Feeling, record.Description }));
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Edit record with date: " + selectedDateForEdit);
            _controller.OpenRecordEdit(_controller, selectedDateForEdit);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to logout", "Logout?", button);
            if (result == DialogResult.Yes)
            {
                _controller.Logout(_controller);
                Console.WriteLine("Logged user out");
                Hide();
            }
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button1 = MessageBoxButtons.YesNo;
            string warningMessage = "Are you sure you want delete your account? All data will be lost. This action is not reversible.";
            DialogResult result1 = MessageBox.Show(warningMessage, "Delete account?", button1);
            if (result1 == DialogResult.Yes)
            {
                MessageBoxButtons button2 = MessageBoxButtons.YesNo;
                string lastWarningMessage = "This is your final warning!";
                DialogResult result2 = MessageBox.Show(lastWarningMessage, "Delete account?", button2);
                if (result2 == DialogResult.Yes)
                {
                    _controller.DeleteAccount(_controller);
                    Console.WriteLine("User deleted");
                    Hide();
                }
            }
        }
    }
}