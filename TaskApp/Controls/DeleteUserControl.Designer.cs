namespace TaskApp
{
    partial class DeleteUserControl
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
            TaskIdTextBox = new TextBox();
            label1 = new Label();
            DeleteTaskbtn = new Button();
            SuspendLayout();
            // 
            // TaskIdTextBox
            // 
            TaskIdTextBox.Location = new Point(155, 63);
            TaskIdTextBox.Name = "TaskIdTextBox";
            TaskIdTextBox.Size = new Size(125, 27);
            TaskIdTextBox.TabIndex = 0;
            TaskIdTextBox.TextChanged += TaskIdTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(66, 59);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 1;
            label1.Text = "Task Id ";
            // 
            // DeleteTaskbtn
            // 
            DeleteTaskbtn.Location = new Point(66, 142);
            DeleteTaskbtn.Name = "DeleteTaskbtn";
            DeleteTaskbtn.Size = new Size(76, 47);
            DeleteTaskbtn.TabIndex = 2;
            DeleteTaskbtn.Text = "Delete";
            DeleteTaskbtn.UseVisualStyleBackColor = true;
            DeleteTaskbtn.Click += DeleteTaskbtn_Click;
            // 
            // DeleteUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteTaskbtn);
            Controls.Add(label1);
            Controls.Add(TaskIdTextBox);
            Name = "DeleteUserControl";
            Size = new Size(560, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskIdTextBox;
        private Label label1;
        private Button DeleteTaskbtn;
    }
}
