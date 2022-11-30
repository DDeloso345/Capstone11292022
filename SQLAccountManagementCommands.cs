using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{

    public class SQLAccountManagementCommands
    {
        List<AccountDetails_Get> details = new List<AccountDetails_Get>();

        public List<AccountDetails_Get> CompareSameUsernameAdmin(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from emp_info_main where username = '{keyword}' and EmpRoles = 1").ToList();
                if (output.Count >= 1)
                {
                    MessageBox.Show("An administrator account with the same username has already existed.\nPlease create another account with a different username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<AccountDetails_Get> Upd_CompareSameUsernameAdmin(String id, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from emp_info_main where username = '{keyword}' and id != '{id}' and EmpRoles = 1").ToList();
                if (output.Count >= 1)
                {
                    MessageBox.Show("An administrator account with the same username has already existed.\nPlease choose" +
                        " a different username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<AccountDetails_Get> CompareSameUsernameStaff(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from emp_info_main where username = '{keyword}' and EmpRoles = 2").ToList();
                if (output.Count >= 1)
                {
                    MessageBox.Show("A staff account with the same username has already existed.\nPlease create another account with a different username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;

            }
        }
        public List<AccountDetails_Get> Upd_CompareSameUsernameStaff(String id, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from emp_info_main where username = '{keyword}' and id != '{id}' and EmpRoles = 2").ToList();
                if (output.Count >= 1)
                {
                    MessageBox.Show("A staff account with the same username has already existed.\nPlease choose a different username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;

            }
        }
        public String SetDashboardProfilePic(String username, String password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select imgpath from emp_info_main where Username = '{username}' and Password = '{password}'");
                String imgpath = Convert.ToString(output);
                return imgpath;
            }
        }


        public void Insert(string firstname, string middlename, string lastname, string suffix, string position, string hieararchy, string email, string contactno, string username, string password, string imgpath)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"insert into emp_info_main values ('{firstname}', '{middlename}','{lastname}','{suffix}','{position}', '{hieararchy}', '{email}','{contactno}','{username}', '{password}', '{imgpath}')");
                MessageBox.Show("The specified account has now been added to the database.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<AccountDetails_Get> SearchAdmin(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from [Admin Info Data] where {criteria} like '%{keyword}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<AccountDetails_Get> SearchStaff_Admin(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from [Staff Data] where {criteria} like '%{keyword}%'").ToList();
                connection.Close();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (output.Count > 0)
                {
                    return output;
                }
                return output;

            }
        }
        public List<AccountDetails_Get_Staff> SearchStaff(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Staff>($"select *from [Staff Data] where {criteria} like '%{keyword}%'").ToList();
                connection.Close();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (output.Count > 0)
                {
                    return output;
                }
                return output;

            }
        }

        public void Update(String id, String fname, String mname, String lname, String suffix, String position, String hierlvl, String email, String number, String username, String password, String imgpath, String activest)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var com = connection.Query<AccountDetails_Get>($"select *from emp_info_main where Username = '{username}'").ToList();
                    if (com.Count > 1) {
                        MessageBox.Show("The specified username is already taken. Please choose another username.");
                    }
                    var output = connection.Execute($"update emp_info_main set FirstName = '{fname}', MiddleName = '{mname}', LastName = '{lname}', Suffix = '{suffix}', Position = '{position}', EmpRoles = '{hierlvl}', EMailAddress = '{email}', ContactNo = '{number}', Username = '{username}', password = '{password}', ImgPath = '{imgpath}' where id = '{id}'");
                    MessageBox.Show("The specified account has been successfully updated.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please select a record from the table provided.");
                }
            }
        }
        public void UpdateStaff(String id, String fname, String mname, String lname, String suffix, String position, String hierlvl, String email, String number, String username, String imgpath)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Execute($"update emp_info_main set FirstName = '{fname}', MiddleName = '{mname}', LastName = '{lname}', Suffix = '{suffix}', Position = '{position}', EmpRoles = '{hierlvl}', EMailAddress = '{email}', ContactNo = '{number}', Username = '{username}', ImgPath = '{imgpath}' where id = '{id}'");
                    MessageBox.Show("The specified account has been successfully updated.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select a record from the table provided.");
                }
            }
        }

        public void Delete(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var insert = connection.Execute($"insert into archive_emp_info_main select FirstName, MiddleName, LastName, Position, EmpRoles, EMailAddress, ContactNo, username, password, ImgPath, ActiveStatus from emp_info_main where emp_info_main.id = '{id}'");
                    var output = connection.Execute($"delete from emp_info_main where id = '{id}'");
                    MessageBox.Show("The specified account has been successfully deleted.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Please click an account on the table being provided to specify which account is to be deleted.");
                }
            }
        }
        public void InsertMemberOR_Repeat(string uid, string firstname, string middlename, string lastname, string MemberStart, string MemberEnd, string ORNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                DateTime dt = DateTime.Now;
                try
                {
                    var start = connection.ExecuteScalar($"select MemberStart from {uid}{firstname}{lastname} where id = 1");
                    String conv = Convert.ToString(start);
                    MessageBox.Show(conv);

                    TimeSpan dt_1yr = new TimeSpan(365, 0, 0, 0);
                    DateTime dt_plus1yr = dt.Add(dt_1yr);
                    Properties.Settings.Default.memberend = dt_plus1yr.ToString("MM-dd-yyyy");
                    Properties.Settings.Default.Save();
                    String membend = Properties.Settings.Default.memberend;
                    var output = connection.Execute($"insert into {uid}{firstname}{lastname} (COCPL_UID, FirstName, MiddleName, LastName, MemberStart, MemberEnd, ORNumber, ORReceivedDate) values ('{uid}','{firstname}', '{middlename}','{lastname}', '{conv}', '{membend}','{ORNumber}','{dt}')");
                }
                catch (Exception)
                {
                    String membstart = Properties.Settings.Default.memberstart;
                    var create_db = connection.Execute($"create table {uid}{firstname}{lastname} (id int identity(1,1) primary key, COCPL_UID varchar(100), FirstName varchar(100), MiddleName varchar(100), LastName varchar(100), MemberStart date, MemberEnd date, ORNumber varchar(100), ORReceivedDate datetime)");
                    var input = connection.Execute($"insert into {uid}{firstname}{lastname} (COCPL_UID, FirstName, MiddleName, LastName, MemberStart, MemberEnd, ORNumber, ORReceivedDate) values ('{uid}','{firstname}', '{middlename}','{lastname}', '{MemberStart}', '{MemberEnd}','{ORNumber}','{dt}')");
                }
                MessageBox.Show("The specified OR Number has been inserted successfully.");
            }
        }
        public void CheckIfORTableExists(String uid, String fn, String ln)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query($"select *from {uid}{fn}{ln}").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("Database missing.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (output.Count == 1)
                {
                    MessageBox.Show("Database present.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        public void UpdateMember(String id, String uid, String fname, String mname, String lname, String suffix, String Organization, String Address, String EmailAddress, String ContactNo, String MemberStart, String MemberEnd, String imgpath)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Execute($"update member_id_info set COCPL_UID = '{uid}', FirstName = '{fname}', MiddleName = '{mname}', LastName = '{lname}', Suffix = '{suffix}', SchoolOrOrganization = '{Organization}', Address = '{Address}', EmailAddress = '{EmailAddress}', ContactNo = '{ContactNo}', MemberStart = '{MemberStart}', MemberEnd = '{MemberEnd}', ImgPath = '{imgpath}' where id = '{id}'");
                    var main = connection.Execute($"update member_info_main set Suffix = '{suffix}',  SchoolOrOrganization = '{Organization}' where id = '{id}'");
                    MessageBox.Show("The specified account has been successfully updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error might be avoided by doing some of the suggested options: " +
                        "\n\n1. Please click an account on the table being provided to specify which account is to be updated." +
                        "\n2. Please enter the dates in the format of mm/dd/yyyy." +
                        "\n3. Please select a valid option in the organization table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }
        public void UpdateMembEnd(String id, String MemberEnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    if (id.Equals("[ID Txt]"))
                    {

                    }
                    else
                    {
                        var output = connection.Execute($"update member_id_info set MemberEnd = '{MemberEnd}' where id = '{id}'");
                        MessageBox.Show("The end of membership on specified account has been successfully updated.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("The following error might be avoided by doing some of the suggested options: " +
                        "\n\n1. Please click an account on the table being provided to specify which account is to be updated." +
                        "\n2. Please enter the dates in the format of mm/dd/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeleteMember(String uid, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Execute($"delete from member_info_main where COCPL_UID = '{id}'");
                    String con = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = '{id}'"));
                    var output2 = connection.Execute($"delete from member_id_info where COCPL_UID = '{con}'");
                    MessageBox.Show("The specified account has been successfully deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Please click an account on the table being provided to specify which account is to be deleted.");
                }
            }
        }
    }
}
