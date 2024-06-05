using Console_To_do_list.Service.DTOs.Users;
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
    public partial class DisplayUsersForm : Form
    {
        private readonly UserService _service = new UserService();
        public DisplayUsersForm()
        {
            InitializeComponent();
        }

        private async void DisplayUsersForm_Load(object sender, EventArgs e)
        {

            var records = (await _service.RetrieveAllAsync()).ToList();
            if (records == null)
            {
                MessageBox.Show("Something doesn't work");
            }
            ViewUsersDataGridView.DataSource = records;
            ViewUsersDataGridView.Columns[^1].Visible = false;
            this.Controls.Add(ViewUsersDataGridView);
        }

        private void ViewUsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUsersDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
