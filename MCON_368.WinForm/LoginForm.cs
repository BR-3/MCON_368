using MCON_368.Data.Code;
using MCON_368.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// find icon online for a chat
// 
namespace MCON_368.WinForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            GlobalSettingsEntity.CurrentUser = UserFactory.GetUserInformation(userNameInput.Text, passwordInput.Text);
            if (GlobalSettingsEntity.CurrentUser == null)
            { MessageBox.Show("There was an error generating your user information.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (!string.IsNullOrEmpty(GlobalSettingsEntity.CurrentUser.ErrorMessage))
            { MessageBox.Show("There was an error generating your user information: " + GlobalSettingsEntity.CurrentUser.ErrorMessage); }
            else
            { this.Close(); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LogInOnEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginButton_Click(null, null);
            } 
        }
    }
}
