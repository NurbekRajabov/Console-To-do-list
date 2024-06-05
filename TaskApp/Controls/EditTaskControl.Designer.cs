namespace TaskApp
{
    partial class EditTaskControl
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
            editedRow = new DataGridView();
            label1 = new Label();
            TaskIdtTextBox = new TextBox();
            FindButton = new Button();
            SaveEditedBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)editedRow).BeginInit();
            SuspendLayout();
            // 
            // editedRow
            // 
            editedRow.AllowUserToAddRows = false;
            editedRow.BackgroundColor = Color.White;
            editedRow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editedRow.Location = new Point(21, 77);
            editedRow.Name = "editedRow";
            editedRow.RowHeadersWidth = 51;
            editedRow.Size = new Size(522, 273);
            editedRow.TabIndex = 0;
            editedRow.CellContentClick += editedRow_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Task Id";
            // 
            // TaskIdtTextBox
            // 
            TaskIdtTextBox.Location = new Point(114, 19);
            TaskIdtTextBox.Name = "TaskIdtTextBox";
            TaskIdtTextBox.Size = new Size(240, 27);
            TaskIdtTextBox.TabIndex = 2;
            TaskIdtTextBox.TextChanged += TaskIdtTextBox_TextChanged;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(360, 17);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(94, 29);
            FindButton.TabIndex = 3;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // SaveEditedBtn
            // 
            SaveEditedBtn.Location = new Point(21, 367);
            SaveEditedBtn.Name = "SaveEditedBtn";
            SaveEditedBtn.Size = new Size(94, 29);
            SaveEditedBtn.TabIndex = 4;
            SaveEditedBtn.Text = "Save";
            SaveEditedBtn.UseVisualStyleBackColor = true;
            SaveEditedBtn.Click += SaveEditedBtn_Click;
            // 
            // EditTaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveEditedBtn);
            Controls.Add(FindButton);
            Controls.Add(TaskIdtTextBox);
            Controls.Add(label1);
            Controls.Add(editedRow);
            Name = "EditTaskControl";
            Size = new Size(560, 426);
            Load += EditTaskControl_Load;
            ((System.ComponentModel.ISupportInitialize)editedRow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView editedRow;
        private Label label1;
        private TextBox TaskIdtTextBox;
        private Button FindButton;
        private Button SaveEditedBtn;
    }
}
