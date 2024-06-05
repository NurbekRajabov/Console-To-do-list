using Console_To_do_list.Service.DTOs.ToDoLists;
using Console_To_do_list.Service.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class ShowTasksControl : UserControl
    {
        private readonly ToDoListService _service = new ToDoListService();

        public ShowTasksControl()
        {
            InitializeComponent();
        }


        private async void ShowTasksControl_Load(object sender, EventArgs e)
        {
            var records = (await _service.RetrieveAllAsync()).Where(u => u.UserId == UserHolder.UserId).ToList();

            dataGridView1.DataSource = records;

            this.Controls.Add(dataGridView1);
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
