using System.Data;
using MCON_368.Entity;
using MCON368.Data.Code;

namespace MCON_368.Data.Code
{
    public class UserFactory
    {
        // if all 3 are valid
        //1) populate userprofileentity with return data
        //2) call getStartupObjects

        public static UserProfileEntity GetUserInformation(string userName, string passWord)
        {
            string strSQL = "EXEC dbo.UserProfile_SEL '{0}'";
            DataSet ds = new();
            UserProfileEntity returnData = new();
            try
            {
                ds = DataFactory.GetDataSet(strSQL, "UserInformation");
                returnData.UserName = userName;
                returnData.Password = passWord;
                returnData.ErrorMessage = ValidateUser(ds, returnData);
                if(string.IsNullOrEmpty(returnData.ErrorMessage))
                {
                    returnData = PopulateUserInformation(ds);
                    returnData.StartupObjects = StartupFactory.GetStartUpData();
                }
            }
            catch (Exception ex)
            {
                returnData.ErrorMessage=ex.Message;
            }
            return returnData;
        }



        private static UserProfileEntity PopulateUserInformation(DataSet ds)
        {
            UserProfileEntity returnData = new();
            DataRow newRow = ds.Tables[0].Rows[0];
            returnData.ActiveInd = Convert.ToInt16(newRow["ActiveInd"]) == 1;
            returnData.PhoneNumber = newRow["PhoneNumber"].ToString();
            returnData.CreatedDateTime = Convert.ToDateTime(newRow["CreatedDateTime"]);
            returnData.EmailAddress = newRow["EmailAddress"].ToString();
            returnData.FirstName = newRow["FirstName"].ToString();
            returnData.LastName = newRow["LastName"].ToString();
            returnData.UserProfileKey = Convert.ToInt32(newRow["UserProfileKey"]);
            returnData.SQLUserName = newRow["SQLUserName"].ToString();
            returnData.UserName = newRow["UserName"].ToString();
            returnData.Password = newRow["Password"].ToString();
            returnData.LastRefreshed = DateTime.Now;
            return returnData;
        }

        private static string ValidateUser(DataSet ds, UserProfileEntity returnData)
        {
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            { return "No user information wasy found for username " + returnData.UserName; }
            else if (ds.Tables[0].Rows[0]["Password"].ToString() != returnData.Password)
            { return "Invalid password."; }
            else if (ds.Tables[0].Rows[0]["ActiveInd"].ToString() != "1")
            { return "This user account is inactive."; }
            else
            { return string.Empty; }

        }

    }
}
