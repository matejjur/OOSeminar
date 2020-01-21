namespace Seminar.PresentationLayer
{
    partial class RegistrationForm
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
            this.usernameRegistrationInput = new System.Windows.Forms.TextBox();
            this.passwordRegistrationInput = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // usernameRegistrationInput
            // 
            this.usernameRegistrationInput.Location = new System.Drawing.Point(387, 127);
            this.usernameRegistrationInput.Name = "usernameRegistrationInput";
            this.usernameRegistrationInput.Size = new System.Drawing.Size(100, 20);
            this.usernameRegistrationInput.TabIndex = 1;
            this.usernameRegistrationInput.TextChanged += new System.EventHandler(this.usernameRegistrationInput_TextChanged);
            // 
            // passwordRegistrationInput
            // 
            this.passwordRegistrationInput.Location = new System.Drawing.Point(387, 173);
            this.passwordRegistrationInput.Name = "passwordRegistrationInput";
            this.passwordRegistrationInput.PasswordChar = '*';
            this.passwordRegistrationInput.Size = new System.Drawing.Size(100, 20);
            this.passwordRegistrationInput.TabIndex = 2;
            this.passwordRegistrationInput.TextChanged += new System.EventHandler(this.passwordRegistrationInput_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(405, 225);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 442);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordRegistrationInput);
            this.Controls.Add(this.usernameRegistrationInput);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameRegistrationInput;
        private System.Windows.Forms.TextBox passwordRegistrationInput;
        private System.Windows.Forms.Button registerButton;
    }
}