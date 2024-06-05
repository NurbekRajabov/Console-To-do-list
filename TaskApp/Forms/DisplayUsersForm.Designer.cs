namespace TaskApp
{
    partial class DisplayUsersForm
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
            ViewUsersDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ViewUsersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ViewUsersDataGridView
            // 
            ViewUsersDataGridView.AllowUserToAddRows = false;
            ViewUsersDataGridView.AllowUserToDeleteRows = false;
            ViewUsersDataGridView.BackgroundColor = Color.White;
            ViewUsersDataGridView.BorderStyle = BorderStyle.None;
            ViewUsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewUsersDataGridView.Location = new Point(14, 21);
            ViewUsersDataGridView.Name = "ViewUsersDataGridView";
            ViewUsersDataGridView.ReadOnly = true;
            ViewUsersDataGridView.RowHeadersWidth = 51;
            ViewUsersDataGridView.Size = new Size(773, 417);
            ViewUsersDataGridView.TabIndex = 1;
            ViewUsersDataGridView.CellContentClick += ViewUsersDataGridView_CellContentClick_1;
            // 
            // DisplayUsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewUsersDataGridView);
            Name = "DisplayUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DisplayUsersForm";
            Load += DisplayUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)ViewUsersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ViewUsersDataGridView;
    }
}