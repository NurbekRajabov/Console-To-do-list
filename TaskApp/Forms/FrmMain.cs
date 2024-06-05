using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskApp;

namespace AppUi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            FormForCreation formForCreation = new FormForCreation();
            formForCreation.Show();
        }

        private void btnEnterProfile_Click(object sender, EventArgs e)
        {
            FormForEnterProfile formForEnterProfile = new FormForEnterProfile();
            formForEnterProfile.Show();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            DisplayUsersForm displayUsersForm = new DisplayUsersForm();
            displayUsersForm.Show();
        }
    }
}
