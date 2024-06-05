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
using TaskApp.InformationHolder;

namespace TaskApp
{
    public partial class FormForEnterProfile : Form
    {
        public FormForEnterProfile()
        {
            InitializeComponent();
        }
        private readonly UserForAccessProfileDTO _dto = new UserForAccessProfileDTO();
        private readonly IUserService _userService = new UserService();

        private void EmailAccessTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.Email = EmailAccessTextBox.Text;
        }

        private void PasswordAccessTextBox_TextChanged(object sender, EventArgs e)
        {
            _dto.Password = PasswordAccessTextBox.Text;
        }

        private async void SignInbtn_Click(object sender, EventArgs e)
        {
            var result = await _userService.AccessProfile(_dto);
            if (result == null)
            {
                MessageBox.Show("The user is not found");
            }

            else
            {
                UserHolder.UserId = result.Id;
                UserHolder.Email = _dto.Email;
                UserHolder.Password = _dto.Password;
                FormUser formUser = new();
                formUser.Show();
                this.Close();
            }
        }

        private void FormForEnterProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
