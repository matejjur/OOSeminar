namespace Seminar.PresentationLayer
{
    partial class RecordEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateText = new System.Windows.Forms.TextBox();
            this.feelingText = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dietText = new System.Windows.Forms.TextBox();
            this.keywordsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(165, 128);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(532, 107);
            this.descriptionText.TabIndex = 1;
            this.descriptionText.TextChanged += new System.EventHandler(this.descriptionText_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(69, 180);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feeling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(165, 84);
            this.dateText.Name = "dateText";
            this.dateText.ReadOnly = true;
            this.dateText.Size = new System.Drawing.Size(141, 20);
            this.dateText.TabIndex = 8;
            // 
            // feelingText
            // 
            this.feelingText.FormattingEnabled = true;
            this.feelingText.Items.AddRange(new object[] {
            "Neutral",
            "Happy",
            "Sad",
            "Angry",
            "Disappointed",
            "Stressed",
            "Satisfied"});
            this.feelingText.Location = new System.Drawing.Point(576, 83);
            this.feelingText.Name = "feelingText";
            this.feelingText.Size = new System.Drawing.Size(121, 21);
            this.feelingText.TabIndex = 9;
            this.feelingText.SelectedIndexChanged += new System.EventHandler(this.feelingText_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Keywords";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Diet";
            // 
            // dietText
            // 
            this.dietText.Location = new System.Drawing.Point(165, 253);
            this.dietText.Multiline = true;
            this.dietText.Name = "dietText";
            this.dietText.Size = new System.Drawing.Size(276, 107);
            this.dietText.TabIndex = 12;
            this.dietText.TextChanged += new System.EventHandler(this.dietText_TextChanged);
            // 
            // keywordsText
            // 
            this.keywordsText.Location = new System.Drawing.Point(534, 253);
            this.keywordsText.Multiline = true;
            this.keywordsText.Name = "keywordsText";
            this.keywordsText.Size = new System.Drawing.Size(163, 107);
            this.keywordsText.TabIndex = 13;
            this.keywordsText.TextChanged += new System.EventHandler(this.keywordsText_TextChanged);
            // 
            // RecordEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keywordsText);
            this.Controls.Add(this.dietText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.feelingText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label1);
            this.Name = "RecordEditForm";
            this.Text = "RecordEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.ComboBox feelingText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dietText;
        private System.Windows.Forms.TextBox keywordsText;
    }
}