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

        private void HomeForm_Shown()
        {
            this.listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
            this.listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
            this.listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
        }


        public bool ShowViewModal()
        {
            HomeForm_Shown();
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
            Console.WriteLine("Logged user out");
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Deleted user and user's data");
        }
    }
}