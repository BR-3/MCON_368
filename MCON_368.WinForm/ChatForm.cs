using MCON_368.Data.Code;
using MCON_368.Entity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCON_368.WinForm
{
    public partial class ChatForm : Form
    {
        public GroupChatEntity CurrentGroup;
        List<ChatEntity> TheChats = new();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            ColorConverter colorConverter = new();
            int yPosition = 75;
            Font labelFont = new("Verdana", 10);

            try
            {
                this.BackColor = (Color)colorConverter.ConvertFromString(CurrentGroup.ChatColor.HexNumber);
                TheChats = GroupChatFactory.GetChats(CurrentGroup.GroupChatKey);
                Label headerLabel = new();
                headerLabel.Font = new("Verdana", 16);
                headerLabel.ForeColor = Color.White;
                headerLabel.Dock = DockStyle.Top;
                headerLabel.Height = 75;
                headerLabel.Text = CurrentGroup.GroupName;
                headerLabel.TextAlign = ContentAlignment.TopCenter;
                headerLabel.Padding = new Padding(10);
                ChatPanel.Controls.Add(headerLabel);
                foreach (ChatEntity newItem in TheChats)
                {
                    ContentAlignment theAlignment = newItem.UserProfileKey == GlobalSettingsEntity.CurrentUser.UserProfileKey ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
                    int leftMargin = newItem.UserProfileKey == GlobalSettingsEntity.CurrentUser.UserProfileKey ? 150 : 5;
                    Color labelColor = newItem.UserProfileKey == GlobalSettingsEntity.CurrentUser.UserProfileKey ? Color.LightGreen : Color.White;
                    Label chatLabel = new();
                    chatLabel.Width = 400;
                    chatLabel.Height = 100;
                    chatLabel.AutoSize = false;
                    chatLabel.TextAlign = theAlignment;
                    chatLabel.Text = newItem.ChatDateTime.ToString("yyy-MM-dd hh:mm:ss") + Environment.NewLine;
                    chatLabel.Text += newItem.DisplayName + Environment.NewLine;
                    chatLabel.Text += newItem.ChatMessage;
                    chatLabel.BackColor = labelColor;
                    chatLabel.Location = new Point(leftMargin, yPosition);
                    chatLabel.Padding = new Padding(10);
                    chatLabel.Font = labelFont;

                    yPosition += 110;
                    ChatPanel.Controls.Add(chatLabel);
                    chatLabel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, chatLabel.Width, chatLabel.Height, 30, 30));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            String fileName = "C:\\temp\\" + DateTime.Now.ToString("yyyMMddmmss") + ".txt";
            System.IO.FileStream oFileStr = default(System.IO.FileStream);
            string thePath = System.IO.Path.GetDirectoryName(fileName);

            if (!System.IO.File.Exists(thePath))
            {
                System.IO.Directory.CreateDirectory(thePath);
            }

            if (!System.IO.File.Exists(fileName))
            {
                oFileStr = new System.IO.FileStream(fileName, System.IO.FileMode.CreateNew);
                oFileStr.Close();
            }

            FileSystem.FileOpen(1, fileName, OpenMode.Append, OpenAccess.Write);
            foreach (ChatEntity newItem in TheChats)
            {
                string theLine = newItem.ChatDateTime.ToString("yyyy-MM-dd hh:mm:ss") + Environment.NewLine;
                theLine += newItem.DisplayName + Environment.NewLine;
                theLine += newItem.ChatMessage + Environment.NewLine;
                theLine += "------------------------------------------";
                FileSystem.Print(1, theLine + Environment.NewLine);
            }
            FileSystem.FileClose(1);
            Process.Start("notepad", fileName);

        }

        
    }
}
