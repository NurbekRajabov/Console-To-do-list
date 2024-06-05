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

namespace TaskApp
{
    public partial class DeleteUserControl : UserControl
    {
        private readonly ToDoListService _service = new ToDoListService();
        public DeleteUserControl()
        {
            InitializeComponent();
        }

        private  void TaskIdTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void DeleteTaskbtn_Click(object sender, EventArgs e)
        {
            var text = TaskIdTextBox.Text;
            long id = 0;
            while (!long.TryParse(text, out id))
            {
                MessageBox.Show("Please enter only number");
            }
            var result = await _service.RemoveAsync(id);
            if (result == true)
            {
                MessageBox.Show("The task is deleted successfully");
            }
        }
    }
}
