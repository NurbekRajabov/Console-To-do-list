namespace AppUi
{
    partial class FormForCreation
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
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNamelabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            SignUpbtn = new Button();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 12F);
            FirstNameLabel.Location = new Point(12, 46);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(101, 28);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "FirstName";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(119, 50);
            FirstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(312, 27);
            FirstNameTextBox.TabIndex = 1;
            FirstNameTextBox.TextChanged += FirstNameTextBox_TextChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(119, 142);
            LastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(312, 27);
            LastNameTextBox.TabIndex = 3;
            LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Font = new Font("Segoe UI", 12F);
            LastNamelabel.Location = new Point(12, 138);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(98, 28);
            LastNamelabel.TabIndex = 2;
            LastNamelabel.Text = "LastName";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(119, 239);
            EmailTextBox.Margin = new Padding(3, 4, 3, 4);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(312, 27);
            EmailTextBox.TabIndex = 5;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F);
            EmailLabel.Location = new Point(12, 239);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(59, 28);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(119, 337);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(312, 27);
            PasswordTextBox.TabIndex = 7;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F);
            PasswordLabel.Location = new Point(12, 337);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(93, 28);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // SignUpbtn
            // 
            SignUpbtn.Location = new Point(150, 431);
            SignUpbtn.Margin = new Padding(3, 4, 3, 4);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(152, 90);
            SignUpbtn.TabIndex = 8;
            SignUpbtn.Text = "Sign up";
            SignUpbtn.UseVisualStyleBackColor = true;
            SignUpbtn.Click += SignUpbtn_Click;
            // 
            // FormForCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 563);
            Controls.Add(SignUpbtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNamelabel);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLabel);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormForCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormForCreation";
            Load += FormForCreation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SignUpbtn;
    }
}