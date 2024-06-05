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
    public partial class EditTaskControl : UserControl
    {
        private readonly ToDoListService _service = new ToDoListService();
        public EditTaskControl()
        {
            InitializeComponent();
        }

        //private async void TaskId_Enter(object sender, EventArgs e)
        //{
        //    var text = TaskIdtTextBox.Text;
        //    long taskId;

        //    if (long.TryParse(text, out taskId))
        //    {
        //        MessageBox.Show("Please enter number");
        //        return;
        //    }

        //    var records = (await _service.RetrieveByIdAsync(taskId));

        //    editedRow.DataSource = records;

        //    this.Controls.Add(editedRow);
        //}

        private void TaskIdtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editedRow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FindButton_Click(object sender, EventArgs e)
        {
            var text = TaskIdtTextBox.Text;
            long taskId;

            if (!long.TryParse(text, out taskId))
            {
                MessageBox.Show("Please enter number");
                return;
            }

            var record = (await _service.RetrieveByIdAsync(taskId));
            if (record == null)
            {
                MessageBox.Show("The task is not found");
                return;
            }
            List<ToDoListForResultDto> list = new List<ToDoListForResultDto>();
            list.Add(record);
            editedRow.DataSource = list;
            editedRow.Columns[0].ReadOnly = true;
            editedRow.Columns[^1].ReadOnly = true;
            editedRow.AllowUserToDeleteRows = true;
            this.Controls.Add(editedRow);
        }

        private async void SaveEditedBtn_Click(object sender, EventArgs e)
        {
            ToDoListForUpdateDto dto = new ToDoListForUpdateDto();

            long id = (long)editedRow.Rows[0].Cells[0].Value;
            string title = (string)editedRow.Rows[0].Cells[1].Value;
            string task = (string)editedRow.Rows[0].Cells[2].Value;
            bool status = (bool)editedRow.Rows[0].Cells[3].Value;

            dto.Id = id;
            dto.Title = title;
            dto.TaskDescription = task;
            dto.Status = status;
            dto.UserId = UserHolder.UserId;

            var result = await _service.UpdateAsync(dto);

            if (result == null)
            {
                MessageBox.Show("The changes are not saved");
            }
            else
            {
                MessageBox.Show("The changes are saved successfully");
            }
        }

        private void EditTaskControl_Load(object sender, EventArgs e)
        {

        }
    }
}
