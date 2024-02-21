using System.Data;

namespace MCON_368.Entity
{
    public class StartUpObjectEntity
    {
        public List<GroupChatEntity> GroupChatList {  get; set; }
        public List<UserProfileEntity> UserList { get; set; }
        public List<MetroColorEntity> MetroColorList { get; set; }
        public Exception ErrorObject { get; set; }
    }
}