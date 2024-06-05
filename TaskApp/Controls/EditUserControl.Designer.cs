namespace TaskApp
{
    partial class EditUserControl
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
            SaveEditedBtn = new Button();
            editedRow = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)editedRow).BeginInit();
            SuspendLayout();
            // 
            // SaveEditedBtn
            // 
            SaveEditedBtn.Location = new Point(19, 359);
            SaveEditedBtn.Name = "SaveEditedBtn";
            SaveEditedBtn.Size = new Size(107, 49);
            SaveEditedBtn.TabIndex = 9;
            SaveEditedBtn.Text = "Save";
            SaveEditedBtn.UseVisualStyleBackColor = true;
            SaveEditedBtn.Click += SaveEditedBtn_Click;
            // 
            // editedRow
            // 
            editedRow.AllowUserToAddRows = false;
            editedRow.BackgroundColor = Color.White;
            editedRow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editedRow.Location = new Point(19, 3);
            editedRow.Name = "editedRow";
            editedRow.RowHeadersWidth = 51;
            editedRow.Size = new Size(522, 350);
            editedRow.TabIndex = 5;
            // 
            // EditUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(SaveEditedBtn);
            Controls.Add(editedRow);
            Name = "EditUserControl";
            Size = new Size(560, 426);
            Load += EditUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)editedRow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SaveEditedBtn;
        private DataGridView editedRow;
    }
}
