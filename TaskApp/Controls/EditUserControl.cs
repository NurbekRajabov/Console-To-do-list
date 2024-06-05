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
    public partial class EditUserControl : UserControl
    {
        private readonly UserForUpdateDto _dto = new UserForUpdateDto();
        private readonly IUserService _userService = new UserService();
        public EditUserControl()
        {
            InitializeComponent();
        }

        private async void SaveEditedBtn_Click(object sender, EventArgs e)
        {
            _dto.Id = UserHolder.UserId;
            _dto.FirstName = (string)editedRow.Rows[0].Cells[1].Value;
            _dto.LastName = (string)editedRow.Rows[0].Cells[2].Value;
            _dto.Email = (string)editedRow.Rows[0].Cells[3].Value;
            _dto.Password = (string)editedRow.Rows[0].Cells[4].Value;
            var result = await _userService.UpdateAsync(_dto);

            if (result == null)
            {
                MessageBox.Show("The changes are not saved");
                return;
            }
            else
            {
                MessageBox.Show("The changes are saved successfully");
                return;
            }
        }

        private async void EditUserControl_Load(object sender, EventArgs e)
        {

            var record = await _userService.RetrieveByIdAsync(UserHolder.UserId);
            if (record == null)
            {
                MessageBox.Show("The user is not found");
                return;
            }
            var user = new UserForUpdateDto();
            user.Id = record.Id;
            user.FirstName = record.FirstName;
            user.LastName = record.LastName;
            user.Email = UserHolder.Email;
            user.Password = UserHolder.Password;

            List<UserForUpdateDto> list = new List<UserForUpdateDto>();
            list.Add(user);
            editedRow.DataSource = list;
            editedRow.Columns[0].ReadOnly = true;
            this.Controls.Add(editedRow);
            //editedRow
        }
    }
}
