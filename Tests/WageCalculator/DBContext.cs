using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CIS305_Web_Master_Project.Demos.WageCalculator
{
    public class DBContext
    {
        private string _connectionString;

        public DBContext(string hostName, string userName, string password, string targetDB)
        {
            //Build the connectionString with the user inputs

            _connectionString = $"Data Source={hostName};Initial Catalog={targetDB};User ID={userName};Password={password};";
        }

        public string CreateWageEntry (Consultant employee)
        {
            //Create a connection to the DB
            SqlConnection conn = new SqlConnection(_connectionString);

            //Convert IsMCSD to bit type for SQL (1-true, 0-false)
            int isMCSD = employee.IsMCSD ? 1 : 0;
            //DB conection can cause run-time errors!
            try
            {
                conn.Open();
                //construct SQL statements
                string sqlQuery = "INSERT INTO WageEntry VALUES (";
                sqlQuery += "'" + employee.Name + "',";
                sqlQuery += "'" + employee.JobTitle + "',";
                sqlQuery += "'" + employee.SkillSets + "',";
                sqlQuery += isMCSD + ",";
                sqlQuery += employee.WorkHours + ",";
                sqlQuery += employee.WeeklyWage + ")";

                SqlCommand cmdSQL = new SqlCommand(sqlQuery, conn);
                cmdSQL.ExecuteNonQuery();

                //DON'T FORGET TO CLOSE CONN
                conn.Close();
                return "Success";

            }
            catch (SqlException exception)
            {
                return exception.Message + " | " + exception.Number;
                throw;
            }

        }

    }
}