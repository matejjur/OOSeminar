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
            
            //this.listView1.Columns.Add("Date");
            //this.listView1.Columns.Add("Feeling");
            //this.listView1.Columns.Add("Keywords");
            //this.listView1.Columns[0].Width = 80;
            //this.listView1.Columns[1].Width = 70;
            //this.listView1.Columns[2].Width = 190;

        {
            this.addRecord = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editButton = new System.Windows.Forms.Button();
            this.feelingDropdown = new System.Windows.Forms.ComboBox();
            this.keywordsText = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(366, 41);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(75, 23);
            this.addRecord.TabIndex = 0;
            this.addRecord.Text = "Add new";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(10, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 162);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.columnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.editRecord);
            this.listView1.DoubleClick += new System.EventHandler(this.showDetails);
            this.listView1.Columns.Add("Date");
            this.listView1.Columns.Add("Feeling");
            this.listView1.Columns.Add("Keywords");
            this.listView1.Columns[0].Width = 80;
            this.listView1.Columns[1].Width = 70;
            this.listView1.Columns[2].Width = 190;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.deleteAccountToolStripMenuItem.Text = "Delete account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(366, 70);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // feelingDropdown
            // 
            this.feelingDropdown.FormattingEnabled = true;
            this.feelingDropdown.Items.AddRange(new object[] {
            "",
            "Neutral",
            "Happy",
            "Sad",
            "Angry",
            "Disappointed",
            "Stressed",
            "Satisfied"});
            this.feelingDropdown.Location = new System.Drawing.Point(59, 209);
            this.feelingDropdown.Name = "feelingDropdown";
            this.feelingDropdown.Text = "";
            this.feelingDropdown.Size = new System.Drawing.Size(121, 21);
            this.feelingDropdown.TabIndex = 5;
            this.feelingDropdown.SelectedIndexChanged += new System.EventHandler(this.feelingDropdown_SelectedIndexChanged);
            // 
            // keywordsText
            // 
            this.keywordsText.Location = new System.Drawing.Point(260, 210);
            this.keywordsText.Name = "keywordsText";
            this.keywordsText.Text = "";
            this.keywordsText.Size = new System.Drawing.Size(100, 20);
            this.keywordsText.TabIndex = 6;
            this.keywordsText.TextChanged += new System.EventHandler(this.keywordsText_TextChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(366, 209);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 22);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Keywords";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Feeling";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.keywordsText);
            this.Controls.Add(this.feelingDropdown);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.ListView listView1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem deleteAccountToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button editButton;
        private ComboBox feelingDropdown;
        private TextBox keywordsText;
        private Button filterButton;
        private Label label1;
        private Label label2;
    }
}