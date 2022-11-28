using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class DashboardDataAccess
    {
        public void FirstName(string username, string password)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select FirstName from emp_info_main where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_firstname = str;
                Properties.Settings.Default.staff_dash_firstname = str;
            }

        }

        public void MiddleName(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select MiddleName from emp_info_main where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_middlename = str;
                Properties.Settings.Default.staff_dash_middlename = str;
            }
        }
        public void LastName(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select LastName from emp_info_main where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_lastname = str;
                Properties.Settings.Default.staff_dash_lastname = str;
            }
        }
        public void Position(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select Position from emp_info_main where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_position = str;
                Properties.Settings.Default.staff_dash_position = str;
            }
        }
        public void HierarchyLvl(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select EmpRoles from emp_info_main where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_hierarchylvl = str;
                Properties.Settings.Default.staff_dash_hierarchylvl = str;
            }
        }
        public void Email(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select EMailAddress from emp_info_main where Username = '{username}' and Password = '{password}'");
                String str = Convert.ToString(output);
                Properties.Settings.Default.ad_dash_emailad = str;
                Properties.Settings.Default.staff_dash_emailad = str;
                Properties.Settings.Default.Save();
            }
        }
        public String SelectAvailableBooks() {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                int a = connection.Query<BKINV_DBRecords>($"select *from BKINV_BKInfo where Availability = '3'").ToList().Count;
                int b = connection.Query<BKINV_DBRecords>($"select *from BKINV_BKInfo where Availability = '5'").ToList().Count;
                int c = a + b;
                var output = Convert.ToString(c);
                return output;
            }
        }
        public String SelectMissingBooks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.ExecuteScalar($"select *from BKINV_BKInfo where Availability = '4'"));
                return output;
            }
        }
        public String SelectMonthBKBR(String dt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {   
                var output = Convert.ToString(connection.Query<BookBorrowingInfo>($"select *from BKBorrowingInfo where BKAvailability = '1' and Date_Borrowed like '%{dt}%'").ToList().Count);
                return output;
            }
        }
        public String SelectTotalBKBR()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.Query<BookBorrowingInfo>($"select *from BKBorrowingInfo where BKAvailability = '1'").ToList().Count);
                return output;
            }
        }
        public String SelectTotalExpMemb(String dt) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.Query<AccountDetails_Get_Member>($"select *from [Member Data] where MemberEnd <= Convert(datetime, '{dt}')").ToList().Count);
                return output;
            }
        }
        public String SelectTotalLogbook() {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.Query<ClientWalkInLogbookInfo>($"select *from [Client Logbook]").ToList().Count);
                return output;
            }
        }
        public String SelectTodayLogbook(String dt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.Query<ClientWalkInLogbookInfo>($"select *from [Client Logbook] where Date = '{dt}'").ToList().Count);
                return output;
            }
        }
    }
}
