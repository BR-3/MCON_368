using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCON_368.Entity
{
    internal class ChatEntity
    {
        public int GroupChatKey { get; set; }
        public string GroupName { get; set; }
        public string ChatMessage { get; set; }
        public string DisplayName { get; set; }
        public int UserProfileKey { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime ChatDateTime {  get; set; }

    }
}
