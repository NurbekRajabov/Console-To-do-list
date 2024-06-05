namespace TaskApp
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            label1 = new Label();
            TaskTextBox = new RichTextBox();
            AddTaskbtn = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(67, 44);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(38, 20);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(139, 44);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(323, 27);
            TitleTextBox.TabIndex = 1;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 108);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Task";
            label1.Click += TaskLabel_Click;
            // 
            // TaskTextBox
            // 
            TaskTextBox.Location = new Point(139, 124);
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.Size = new Size(323, 120);
            TaskTextBox.TabIndex = 3;
            TaskTextBox.Text = "";
            TaskTextBox.TextChanged += TaskTextBox_TextChanged;
            // 
            // AddTaskbtn
            // 
            AddTaskbtn.Location = new Point(79, 306);
            AddTaskbtn.Name = "AddTaskbtn";
            AddTaskbtn.Size = new Size(108, 46);
            AddTaskbtn.TabIndex = 4;
            AddTaskbtn.Text = "Add";
            AddTaskbtn.UseVisualStyleBackColor = true;
            AddTaskbtn.Click += AddTaskbtn_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddTaskbtn);
            Controls.Add(TaskTextBox);
            Controls.Add(label1);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Name = "UserControl1";
            Size = new Size(560, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label label1;
        private RichTextBox TaskTextBox;
        private Button AddTaskbtn;
    }
}
