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

        }

        /* TODO napraviti da uzme samo one ciji su indeksi veci od this.listView1.Items.Count */
        private void refreshButton_Click(object sender, EventArgs e)
        {
            var records = _controller.RefreshData();
            foreach (var record in records)
            {
                Console.WriteLine(record.Description);
                this.listView1.Items.Add(new ListViewItem(new string[] { record.Description, "Nesto", "Nesto drugo" }));
            }
        }
    }
}
