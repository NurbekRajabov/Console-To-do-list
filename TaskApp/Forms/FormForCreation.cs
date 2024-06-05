using Console_To_do_list.Service.DTOs.Users;
using Console_To_do_list.Service.Interfaces;
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

namespace AppUi
{
    public partial class FormForCreation : Form
    {
        private readonly UserForCreationDto _dto = new UserForCreationDto();
        private readonly IUserService _userService = new UserService();

        public FormForCreation()
        {
            InitializeComponent();
        }
        private void FormForCreation_Load(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.FirstName = FirstNameTextBox.Text;
        }


        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.LastName = LastNameTextBox.Text;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.Email = EmailTextBox.Text;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.Password = PasswordTextBox.Text;
        }

        private async void SignUpbtn_Click(object sender, EventArgs e)
        {
            var result = await _userService.CreateAsync(_dto);
            if (result != null)
            {
                MessageBox.Show("User is created successfully...");
                this.Close();
            }
            else
            {
                MessageBox.Show("User is not created Please try with other password...");
            }
        }
    }
}
