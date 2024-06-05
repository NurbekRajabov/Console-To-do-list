using Console_To_do_list.Service.DTOs.ToDoLists;
using Console_To_do_list.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskApp.InformationHolder;

namespace TaskApp
{
    public partial class UserControl1 : UserControl
    {
        private readonly ToDoListForCreationDto _dto = new ToDoListForCreationDto();
        private readonly ToDoListService _service = new ToDoListService();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void TaskLabel_Click(object sender, EventArgs e)
        {

        }

        private async void AddTaskbtn_Click(object sender, EventArgs e)
        {
            var result = await _service.CreateAsync(_dto);
            if (result != null)
            {
                MessageBox.Show("The task is addded");
            }
            else
            {
                MessageBox.Show("The task is not added");
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.Title = TitleTextBox.Text;
        }

        private void TaskTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.TaskDescription = TaskTextBox.Text;
            _dto.Status = false;
            _dto.UserId = UserHolder.UserId;
        }
    }
}
