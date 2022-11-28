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
   public class DashboardDataAccess
    {
        public void FirstName(string username, string password)
        {
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select FirstName from employee_user_profile where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_firstname = str;
                Properties.Settings.Default.staff_dash_firstname = str;
            }

        }

        public void MiddleName(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select MiddleName from employee_user_profile where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_middlename = str;
                Properties.Settings.Default.staff_dash_middlename = str;
            }
        }
        public void LastName(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select LastName from employee_user_profile where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_lastname = str;
                Properties.Settings.Default.staff_dash_lastname = str;
            }
        }
        public void Position(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select Position from employee_user_profile where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_position = str;
                Properties.Settings.Default.staff_dash_position = str;
            }
        }
        public void HierarchyLvl(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select HierarchyLvl from employee_user_profile where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_hierarchylvl = str;
                Properties.Settings.Default.staff_dash_hierarchylvl = str;
            }
        }
        public void Email(string username, string password) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select EMailAddress from employee_user_profile where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_emailad = str;
                Properties.Settings.Default.staff_dash_emailad = str;
                Properties.Settings.Default.Save();
            }
        }
    }
}
