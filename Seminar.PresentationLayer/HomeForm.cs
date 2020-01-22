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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listView1.SelectedIndices[0];
            string s = listView1.Items[i].Text; // tu je datum koji moze biti ID sad bi trebalo otvorit 
            Console.WriteLine(s);
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
    }
}