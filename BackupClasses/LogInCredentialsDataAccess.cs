using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

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
                var output = connection.Query<LogInCredentials>($"select * from employee_user_profile where Username = '{username}' and Password = '{password}' and HierarchyLvl = 'Administrator'").ToList();
                
                return output;
            }
        }
        public List<LogInCredentials> StaffLogInCredentials(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<LogInCredentials>($"select * from employee_user_profile where username = '{username}' and password = '{password}' and HierarchyLvl = 'Staff'").ToList();
                return output;
            }
        }
    }
}
