using MCON_368.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCON_368.Data.Code
{
    public class GroupChatFactory
    {
        public static List<GroupChatEntity> GetGroupChats()
        {
            List<GroupChatEntity> returnData = new();
            DataSet ds = new();
            string strSQL = "EXEC dbo.GroupChat_SELStats";
            try
            {
                ds = DataFactory.GetDataSet(strSQL, "GroupChats");
                foreach(DataRow newRow in ds.Tables[0].Rows)
                {
                    GroupChatEntity newItem = new();
                    newItem.GroupName = newRow["Header"].ToString();
                    newItem.MetroColorKey = Convert.ToInt16(newRow["MetroColorKey"]);
                    newItem.NumberOfUsers = Convert.ToInt16(newRow["MemberCount"]);
                    newItem.NumberOfChats = Convert.ToInt16(newRow["ChatCount"]);
                    newItem.GroupChatKey = Convert.ToInt32(newRow["GroupChatKey"]);
                    newItem.ChatColor = GlobalSettingsEntity.CurrentUser.StartupObjects.MetroColorList.Where(x => x.MetroColorKey == newItem.MetroColorKey).FirstOrDefault(); 
                    returnData.Add(newItem);
                }
                return returnData;

            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static List<ChatEntity> GetChats(int groupChatKey)
        {
            string strSQL = "EXEC dbo.GroupChat_SelChats " + groupChatKey;
            List<ChatEntity> returnData = new();
            DataSet ds = new();
            try
            {
                ds = DataFactory.GetDataSet(strSQL, "ChatData");
                foreach(DataRow newRow in ds.Tables[0].Rows)
                {
                    ChatEntity newItem = new();
                    newItem.DisplayName = newRow["FirstName"] + " " + newRow["LastName"];
                    newItem.ChatDateTime = Convert.ToDateTime(newRow["CreatedDateTime"]);
                    newItem.ChatMessage = newRow["ChatMessage"].ToString();
                    newItem.UserProfileKey = Convert.ToInt32(newRow["UserProfileKey"]);
                    returnData.Add(newItem);
                }
                return returnData;
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

   
    }
}
