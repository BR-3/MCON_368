using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MCON_368.Data.Code
{
    public class DataFactory
    {
        private static readonly string connectionString = "Data Source=LAPTOP-E134A62S\\SQLEXPRESS;Initial Catalog =MCON368; Integrated Security = True;TrustServerCertificate=True";
        public static DataSet GetDataSet(string strSQL, string tableName)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(strSQL, connectionString);
                sqlAdapter.Fill(ds, tableName);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetChainNameByParameter(int chainKey)
        {
            DataSet ds = new();
            SqlDataAdapter sqlAdapter;
            try
            {
                using (SqlConnection theConnection = new SqlConnection(connectionString))
                {
                    theConnection.Open();
                    using (SqlCommand theCommand = theConnection.CreateCommand())
                    {
                        theCommand.CommandText = "dbo.Chain_SELByKey";
                        theCommand.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter;
                        parameter = theCommand.Parameters.AddWithValue("@ChainKey", chainKey);
                        sqlAdapter = new SqlDataAdapter(theCommand);
                        sqlAdapter.SelectCommand.Connection = theConnection;
                        sqlAdapter.Fill(ds);
                    }
                }
                return ds.Tables[0].Rows.Count > 0 ? ds.Tables[0].Rows[0]["ChainName"].ToString() : "No chain was found for ID " + chainKey;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
