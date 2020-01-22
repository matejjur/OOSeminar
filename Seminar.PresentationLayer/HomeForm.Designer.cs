using System.Windows.Forms;

namespace Seminar.PresentationLayer
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.addRecord = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(713, 13);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(75, 23);
            this.addRecord.TabIndex = 0;
            this.addRecord.Text = "Add new";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // listView1
            // 
            //this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            //listViewItem1,
            //listViewItem2});

            //this.listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
            //this.listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));
            //this.listView1.Items.Add(new ListViewItem(new string[] { "Fake data", "Nesto", "Nesto drugo" }));

            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(695, 426);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Columns.Add("Column1");
            this.listView1.Columns.Add("Column2");
            this.listView1.Columns.Add("Column3");
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(712, 414);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addRecord);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button refreshButton;
    }
}