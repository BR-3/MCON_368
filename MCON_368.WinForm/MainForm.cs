using MCON_368.WinForm.Code;
using MCON_368.Entity;
using MCON_368.WinForm.UserControls;
using MCON_368.Data.Code;

namespace MCON_368.WinForm
{
    public partial class MainForm : Form
    {
        List<GroupChatEntity> groupList = new();
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
                loginPopup.ShowDialog(); // this has control, nothing underneath it matters (so mainform won't show)
            }
        }
        private void LoginFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (GlobalSettingsEntity.CurrentUser != null && GlobalSettingsEntity.CurrentUser.UserProfileKey > 0)
            {
                this.Text = ("MCON 368 ChatBot - Welcome Back, " + GlobalSettingsEntity.CurrentUser.DisplayName);
                this.Refresh();
                groupList = GroupChatFactory.GetGroupChats();
                foreach(GroupChatEntity newItem in groupList)
                {
                    /*panelLayout.Controls.Add(new Button { Text = "Button " + i});
                    panelLayout.Controls.Add(new TextBox { Text = "Button " + i });*/
                    panelLayout.Controls.Add(new GroupChatControl {CurrentChat = newItem});
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
        
    }

    public static class Extensions
    {
        public static string MixedCase(this string theString)
        {
            string returnData = string.Empty;
            if (!string.IsNullOrEmpty(theString))
            {
                for (int i = 0; i < theString.Length; i++)
                {
                    returnData += i % 2 != 0 ? theString.Substring(i, 1).ToLower() : theString.Substring(i, 1).ToUpper();
                }
            }
            return returnData;
        }
    }

}
