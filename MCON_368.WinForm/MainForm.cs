using MCON_368.WinForm.Code;
using MCON_368.Entity;

namespace MCON_368.WinForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopLoginForm();
        }
        private void PopLoginForm()
        {
            if (GlobalSettingsEntity.CurrentUser == null || GlobalSettingsEntity.CurrentUser.UserProfileKey == 0)
            {
                LoginForm loginPopup = new();
                loginPopup.FormClosed += LoginFormClosed;
                loginPopup.ShowDialog();
            }
        }
        private void LoginFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (GlobalSettingsEntity.CurrentUser != null && GlobalSettingsEntity.CurrentUser.UserProfileKey > 0)
            {
                this.Text = "MCON 368 ChatBot - Welcome Back, " + GlobalSettingsEntity.CurrentUser.FirstName + " " + GlobalSettingsEntity.CurrentUser.LastName;
                this.Refresh();
                for (int i = 1; i < 51; i++)
                {
                    panelLayout.Controls.Add(new Button { Text = "Button " + i}) ;
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }

}
