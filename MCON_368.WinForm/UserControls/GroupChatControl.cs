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

namespace MCON_368.WinForm.UserControls
{
    public partial class GroupChatControl : UserControl

    {
        public object ChatTag;
        public GroupChatEntity CurrentChat = new();
        public GroupChatControl()
        {
            InitializeComponent();
        }

        private void GroupChatControl_Load(object sender, EventArgs e)
        {
            ColorConverter colorConverter = new ColorConverter();
            chatNameLabel.Text = CurrentChat.GroupName;
            memberCountLabel.Text = CurrentChat.NumberOfUsers.ToString();
            chatCountLabel.Text = CurrentChat.NumberOfChats.ToString();
            this.Tag = CurrentChat;
            this.Click += HandleTileClick;
            this.Height = 67;
            this.Width = 140;

            this.BackColor = (Color)colorConverter.ConvertFromString(CurrentChat.ChatColor.HexNumber);
            this.Refresh();
        }
        private void HandleTileClick(object? sender, EventArgs e)
        {
            GroupChatEntity newGroup = new();
            newGroup = (GroupChatEntity)this.Tag;
            ChatForm newChat = new();
            newChat.CurrentGroup = newGroup;
            newChat.Show();
        }

        
    }
}
