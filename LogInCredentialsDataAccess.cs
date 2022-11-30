using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Capstone
{
    public class LogInCredentialsDataAccess
    {
        public List<LogInCredentials> GetPeople(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<LogInCredentials>($"select * from employee_user_profile where password = '{name}'").ToList();
                return output;
            }
        }
        public List<LogInCredentials> AdminLogInCredentials(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<LogInCredentials>($"SELECT username, password, emproles from emp_info_main where EmpRoles = '1' and username = '{username}' and password = '{password}'").ToList();
                return output;
            }
        }
        public List<LogInCredentials> StaffLogInCredentials(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<LogInCredentials>($"SELECT username, password, emproles from emp_info_main where EmpRoles = '2' and username = '{username}' and password = '{password}'").ToList();
                return output;
            }
        }
    }
}