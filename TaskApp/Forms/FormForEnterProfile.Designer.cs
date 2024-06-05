namespace TaskApp
{
    partial class FormForEnterProfile
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
            label1 = new Label();
            label2 = new Label();
            EmailAccessTextBox = new TextBox();
            PasswordAccessTextBox = new TextBox();
            SignInbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(37, 89);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(37, 181);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // EmailAccessTextBox
            // 
            EmailAccessTextBox.Location = new Point(127, 89);
            EmailAccessTextBox.Name = "EmailAccessTextBox";
            EmailAccessTextBox.Size = new Size(223, 27);
            EmailAccessTextBox.TabIndex = 2;
            EmailAccessTextBox.TextChanged += EmailAccessTextBox_TextChanged;
            // 
            // PasswordAccessTextBox
            // 
            PasswordAccessTextBox.Location = new Point(127, 181);
            PasswordAccessTextBox.Name = "PasswordAccessTextBox";
            PasswordAccessTextBox.Size = new Size(223, 27);
            PasswordAccessTextBox.TabIndex = 3;
            PasswordAccessTextBox.TextChanged += PasswordAccessTextBox_TextChanged;
            // 
            // SignInbtn
            // 
            SignInbtn.Location = new Point(37, 264);
            SignInbtn.Name = "SignInbtn";
            SignInbtn.Size = new Size(107, 42);
            SignInbtn.TabIndex = 4;
            SignInbtn.Text = "Sign In";
            SignInbtn.UseVisualStyleBackColor = true;
            SignInbtn.Click += SignInbtn_Click;
            // 
            // FormForEnterProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 377);
            Controls.Add(SignInbtn);
            Controls.Add(PasswordAccessTextBox);
            Controls.Add(EmailAccessTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormForEnterProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormForEnterProfile";
            Load += FormForEnterProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EmailAccessTextBox;
        private TextBox PasswordAccessTextBox;
        private Button SignInbtn;
    }
}