using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskApp
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void panelForProfile_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void AddTaskbtn_Click(object sender, EventArgs e)
        {
            //panelForProfile.Visible = false;
            UserControl1 control1 = new UserControl1();
            rightPanel.Controls.Clear();
            rightPanel.Controls.Add(control1);
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteTaskbtn_Click(object sender, EventArgs e)
        {
            DeleteUserControl deleteUserControl = new DeleteUserControl();
            rightPanel.Controls.Clear();
            rightPanel.Controls.Add(deleteUserControl);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewTaskbtn_Click(object sender, EventArgs e)
        {
            ShowTasksControl showTasksControl = new ShowTasksControl();
            rightPanel.Controls.Clear();
            rightPanel.Controls.Add(showTasksControl);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditTaskbtn_Click(object sender, EventArgs e)
        {
            EditTaskControl editTaskControl = new EditTaskControl();
            rightPanel.Controls.Clear();
            rightPanel.Controls.Add(editTaskControl);
        }

        private void EditProfilebtn_Click(object sender, EventArgs e)
        {
            EditUserControl editUserControl = new EditUserControl();
            rightPanel.Controls.Clear();
            rightPanel.Controls.Add(editUserControl);
        }
    }
}
