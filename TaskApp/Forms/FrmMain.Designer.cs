namespace AppUi
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnCreateUser = new Button();
            btnEnterProfile = new Button();
            btnViewUser = new Button();
            btnExit = new Button();
            PersonPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(77, 56);
            btnCreateUser.Margin = new Padding(3, 4, 3, 4);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(162, 86);
            btnCreateUser.TabIndex = 0;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnEnterProfile
            // 
            btnEnterProfile.Location = new Point(77, 191);
            btnEnterProfile.Margin = new Padding(3, 4, 3, 4);
            btnEnterProfile.Name = "btnEnterProfile";
            btnEnterProfile.Size = new Size(162, 86);
            btnEnterProfile.TabIndex = 1;
            btnEnterProfile.Text = "Enter your profile";
            btnEnterProfile.UseVisualStyleBackColor = true;
            btnEnterProfile.Click += btnEnterProfile_Click;
            // 
            // btnViewUser
            // 
            btnViewUser.Location = new Point(77, 316);
            btnViewUser.Margin = new Padding(3, 4, 3, 4);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(162, 86);
            btnViewUser.TabIndex = 2;
            btnViewUser.Text = "View Users";
            btnViewUser.UseVisualStyleBackColor = true;
            btnViewUser.Click += btnViewUser_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(77, 447);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(162, 86);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PersonPictureBox
            // 
            PersonPictureBox.Image = (Image)resources.GetObject("PersonPictureBox.Image");
            PersonPictureBox.Location = new Point(393, 30);
            PersonPictureBox.Margin = new Padding(3, 4, 3, 4);
            PersonPictureBox.Name = "PersonPictureBox";
            PersonPictureBox.Size = new Size(499, 491);
            PersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PersonPictureBox.TabIndex = 4;
            PersonPictureBox.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(992, 601);
            Controls.Add(PersonPictureBox);
            Controls.Add(btnExit);
            Controls.Add(btnViewUser);
            Controls.Add(btnEnterProfile);
            Controls.Add(btnCreateUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnEnterProfile;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox PersonPictureBox;
    }
}

