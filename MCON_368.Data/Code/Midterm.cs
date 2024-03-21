using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCON_368.Data.Code
{
    public class Midterm
    {
        public static List<string> HTMLTablesFromDataSet(DataSet ds)
        {

            List<string> htmlStrings = new List<string>();
            // loop through whole thing

            foreach(DataTable dt in ds.Tables)
            {
                htmlStrings.Add("<h1>" + dt.TableName + "</h1>"); // adding the table name
                htmlStrings.Add("<table>");

                // here loop through each column in each row to get the name
                htmlStrings.Add("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    // get the column names
                    htmlStrings.Add("<th>" + dc.ColumnName + "</th>");
                }
                htmlStrings.Add("</tr>");

                // here loop through each row
                foreach (DataRow dr in dt.Rows)
                {
                    htmlStrings.Add("<tr>");
                    // loop through columns in each row to get the value
                    foreach(DataColumn dc in dt.Columns)
                    {
                        htmlStrings.Add("<td>" + dr[dc].ToString() + "</td>");
                    }            
                    htmlStrings.Add("</tr>");
                }

                htmlStrings.Add("</table>");
            }

            return htmlStrings;

        }
    }
}
