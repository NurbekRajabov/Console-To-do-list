namespace TaskApp
{
    partial class FormUser
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
            panelForProfile = new Panel();
            Exitbtn = new Button();
            EditProfilebtn = new Button();
            EditTaskbtn = new Button();
            ViewTaskbtn = new Button();
            DeleteTaskbtn = new Button();
            AddTaskbtn = new Button();
            rightPanel = new Panel();
            panelForProfile.SuspendLayout();
            SuspendLayout();
            // 
            // panelForProfile
            // 
            panelForProfile.Controls.Add(Exitbtn);
            panelForProfile.Controls.Add(EditProfilebtn);
            panelForProfile.Controls.Add(EditTaskbtn);
            panelForProfile.Controls.Add(ViewTaskbtn);
            panelForProfile.Controls.Add(DeleteTaskbtn);
            panelForProfile.Controls.Add(AddTaskbtn);
            panelForProfile.Location = new Point(25, 12);
            panelForProfile.Name = "panelForProfile";
            panelForProfile.Size = new Size(165, 426);
            panelForProfile.TabIndex = 0;
            panelForProfile.Paint += panelForProfile_Paint;
            // 
            // Exitbtn
            // 
            Exitbtn.Location = new Point(18, 364);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(135, 48);
            Exitbtn.TabIndex = 11;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = true;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // EditProfilebtn
            // 
            EditProfilebtn.Location = new Point(18, 292);
            EditProfilebtn.Name = "EditProfilebtn";
            EditProfilebtn.Size = new Size(135, 48);
            EditProfilebtn.TabIndex = 10;
            EditProfilebtn.Text = "Edit Profile";
            EditProfilebtn.UseVisualStyleBackColor = true;
            EditProfilebtn.Click += EditProfilebtn_Click;
            // 
            // EditTaskbtn
            // 
            EditTaskbtn.Location = new Point(18, 219);
            EditTaskbtn.Name = "EditTaskbtn";
            EditTaskbtn.Size = new Size(135, 48);
            EditTaskbtn.TabIndex = 9;
            EditTaskbtn.Text = "Edit Task";
            EditTaskbtn.UseVisualStyleBackColor = true;
            EditTaskbtn.Click += EditTaskbtn_Click;
            // 
            // ViewTaskbtn
            // 
            ViewTaskbtn.Location = new Point(18, 154);
            ViewTaskbtn.Name = "ViewTaskbtn";
            ViewTaskbtn.Size = new Size(135, 48);
            ViewTaskbtn.TabIndex = 8;
            ViewTaskbtn.Text = "View Task list";
            ViewTaskbtn.UseVisualStyleBackColor = true;
            ViewTaskbtn.Click += ViewTaskbtn_Click;
            // 
            // DeleteTaskbtn
            // 
            DeleteTaskbtn.Location = new Point(18, 85);
            DeleteTaskbtn.Name = "DeleteTaskbtn";
            DeleteTaskbtn.Size = new Size(135, 48);
            DeleteTaskbtn.TabIndex = 7;
            DeleteTaskbtn.Text = "Delete Task";
            DeleteTaskbtn.UseVisualStyleBackColor = true;
            DeleteTaskbtn.Click += DeleteTaskbtn_Click;
            // 
            // AddTaskbtn
            // 
            AddTaskbtn.Location = new Point(18, 14);
            AddTaskbtn.Name = "AddTaskbtn";
            AddTaskbtn.Size = new Size(135, 48);
            AddTaskbtn.TabIndex = 6;
            AddTaskbtn.Text = "Add Task";
            AddTaskbtn.UseVisualStyleBackColor = true;
            AddTaskbtn.Click += AddTaskbtn_Click;
            // 
            // rightPanel
            // 
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            rightPanel.Location = new Point(228, 12);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(560, 426);
            rightPanel.TabIndex = 1;
            rightPanel.Paint += rightPanel_Paint;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(rightPanel);
            Controls.Add(panelForProfile);
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUser";
            Load += FormUser_Load;
            panelForProfile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForProfile;
        private Button Exitbtn;
        private Button EditProfilebtn;
        private Button EditTaskbtn;
        private Button ViewTaskbtn;
        private Button DeleteTaskbtn;
        private Button AddTaskbtn;
        private Panel rightPanel;
    }
}