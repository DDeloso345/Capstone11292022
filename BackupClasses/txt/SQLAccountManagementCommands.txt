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

    public class SQLAccountManagementCommands
    {
        List<AccountDetails_Get> details = new List<AccountDetails_Get>();
        public List<AccountDetails_Get> LoadAdminData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from employee_user_profile where HierarchyLvl = 'Administrator'").ToList();
                return output;
            }
        }
        public List<AccountDetails_Get> LoadAdmin_StaffData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from employee_user_profile where hierarchylvl = 'Staff'").ToList();
                return output;
            }
        }
        public List<AccountDetails_Get_Staff> LoadStaffData() {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Staff>($"select id, FirstName, MiddleName, LastName, Position, HierarchyLvl, EMailAddress, ContactNo, Username from employee_user_profile where hierarchylvl = 'Staff'").ToList();
                return output;
            }
        }
        public List<AccountDetails_Get_Member> LoadMemberData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Member>($"select *from member_id_info").ToList();
                return output;
            }
        }
        public List<AccountDetails_Get> CompareSameUsernameAdmin(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from employee_user_profile where username = '{keyword}' and HierarchyLvl = 'Administrator'").ToList();
                if (output.Count >= 1 )
                {
                    MessageBox.Show("An administrator account with the same username has already existed.\nPlease create another account with a different username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<AccountDetails_Get_Member> CompareSameMemberUID(String uid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Member>($"select *from member_id_info where COCPL_UID = '{uid}'").ToList();
                if (output.Count >= 1)
                {
                    MessageBox.Show("A library member account with the same COCPL UID has already existed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<AccountDetails_Get> CompareSameUsernameStaff(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"select *from employee_user_profile where username = '{keyword}' and HierarchyLvl = 'Staff'").ToList();
                if (output.Count >= 1)
                {
                    MessageBox.Show("A staff account with the same username has already existed.\nPlease create another account with a different username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;

            }
        }
        public void Insert(string firstname, string middlename, string lastname,  string position, string hieararchy, string email, string contactno, string username, string password) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"insert into employee_user_profile (FirstName, MiddleName, LastName, Position, HierarchyLvl, EMailAddress, ContactNo, Username, Password) values ('{firstname}', '{middlename}','{lastname}','{position}', '{hieararchy}', '{email}','{contactno}','{username}', '{password}')");
            }
        }
        public List<AccountDetails_Get> SearchAdmin(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                    var output = connection.Query<AccountDetails_Get>($"select *from employee_user_profile where {criteria} = '{keyword}' and HierarchyLvl = 'Administrator'").ToList();
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
                var output = connection.Query<AccountDetails_Get>($"select *from employee_user_profile where {criteria} = '{keyword}' and HierarchyLvl = 'Staff'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;

            }
        }
        public List<AccountDetails_Get_Staff> SearchStaff(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Staff>($"select *from employee_user_profile where {criteria} = '{keyword}' and HierarchyLvl = 'Staff'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;

            }
        }
        public List<AccountDetails_Get_Member> SearchMemberDetails(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query< AccountDetails_Get_Member> ($"select *from member_id_info where {criteria} = '{keyword}'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;

            }
        }
        public void Update(String fname, String mname, String lname, String position, String hierlvl, String email, String number, String username, String password, String id) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"update employee_user_profile set FirstName = '{fname}', MiddleName = '{mname}', LastName = '{lname}', Position = '{position}', HierarchyLvl = '{hierlvl}', EMailAddress = '{email}', ContactNo = '{number}', Username = '{username}', password = '{password}' where id = '{id}'");
                MessageBox.Show("The specified account has been successfully updated.");
            }
        }
        public void Delete(String id) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try { 
                var output = connection.Execute($"delete from employee_user_profile where id = '{id}'");
                MessageBox.Show("The specified account has been successfully deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please click an account on the table being provided to specify which account is to be deleted.");
                }
            }
        }
        public void InsertMember(string uid, string firstname, string middlename, string lastname, string Organization, string Address, string Email, string ContactNo, string MemberStart, string MemberEnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    Properties.Settings.Default.membercatchinvaliddates = "success";
                    Properties.Settings.Default.Save();
                    var output = connection.Execute($"insert into member_id_info (COCPL_UID, FirstName, MiddleName, LastName, Organization, Address, EmailAddress, ContactNo, MemberStart, MemberEnd) values ('{uid}','{firstname}', '{middlename}','{lastname}','{Organization}', '{Address}', '{Email}','{ContactNo}','{MemberStart}', '{MemberEnd}')");
                    if (Properties.Settings.Default.membercatchinvaliddates.Length>1) {
                        MessageBox.Show("An administrator account has been added successfully.");
                        InsertORNoForm or = new InsertORNoForm();
                        or.Show();
                    }
                    
                }
                catch (Exception ex) {
                    Properties.Settings.Default.membercatchinvaliddates = Convert.ToString(ex);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Please insert appropriate values in the 'Membership Start' and 'Membership End' with the following format: mm-dd-yyyy");
                }
                try {
                    var create_db = connection.Execute($"create table {uid}{firstname}{lastname} (id int identity(1,1) primary key, COCPL_UID varchar(100), FirstName varchar(100), MiddleName varchar(100), LastName varchar(100), MemberStart date, MemberEnd date, ORNumber varchar(100), ORReceivedDate datetime)");
                }
                catch (Exception ex) {
                    MessageBox.Show("A similar database dedicated to storing the receipts has already been created.");
                }
            }
        }
        public void InsertMemberOR(string uid, string firstname, string middlename, string lastname, string MemberStart, string MemberEnd, string ORNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                DateTime dt = DateTime.Now;
                try
                {
                    TimeSpan dt_1yr = new TimeSpan(365, 0, 0, 0);
                    DateTime dt_plus1yr = dt.Add(dt_1yr);
                    Properties.Settings.Default.memberend = dt_plus1yr.ToString("MM-dd-yyyy");
                    Properties.Settings.Default.Save();
                    String membend = Properties.Settings.Default.memberend;
                    var output = connection.Execute($"insert into {uid}{firstname}{lastname} (COCPL_UID, FirstName, MiddleName, LastName, MemberStart, MemberEnd, ORNumber, ORReceivedDate) values ('{uid}','{firstname}', '{middlename}','{lastname}', '{MemberStart}', '{membend}','{ORNumber}','{dt}')");
                }
                catch (Exception ex) {
                    String membstart = Properties.Settings.Default.memberstart;
                    var create_db = connection.Execute($"create table {uid}{firstname}{lastname} (id int identity(1,1) primary key, COCPL_UID varchar(100), FirstName varchar(100), MiddleName varchar(100), LastName varchar(100), MemberStart date, MemberEnd date, ORNumber varchar(100), ORReceivedDate datetime)");
                    var input = connection.Execute($"insert into {uid}{firstname}{lastname} (COCPL_UID, FirstName, MiddleName, LastName, MemberStart, MemberEnd, ORNumber, ORReceivedDate) values ('{uid}','{firstname}', '{middlename}','{lastname}', '{MemberStart}', '{MemberEnd}','{ORNumber}','{dt}')");
                }
                MessageBox.Show("The specified OR Number has been inserted successfully.");
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
                catch (Exception ex)
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
            public void UpdateMember(String id, String uid, String fname, String mname, String lname, String Organization, String Address, String EmailAddress, String ContactNo, String MemberStart, String MemberEnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try{
                    var output = connection.Execute($"update member_id_info set COCPL_UID = '{uid}', FirstName = '{fname}', MiddleName = '{mname}', LastName = '{lname}', Organization = '{Organization}', Address = '{Address}', EmailAddress = '{EmailAddress}', ContactNo = '{ContactNo}', MemberStart = '{MemberStart}', MemberEnd = '{MemberEnd}' where id = '{id}'");
                    MessageBox.Show("The specified account has been successfully updated.");
                }
                catch (Exception ex){
                    MessageBox.Show("The following error might be avoided by doing some of the suggested options: " +
                        "\n\n1. Please click an account on the table being provided to specify which account is to be updated." +
                        "\n2. Please enter the dates in the format of mm/dd/yyyy.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteMember(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    var output = connection.Execute($"delete from member_id_info where id = '{id}'");
                    MessageBox.Show("The specified account has been successfully deleted.");
                }
                catch (Exception ex) {
                    MessageBox.Show("Please click an account on the table being provided to specify which account is to be deleted.");
                }
            }
        }
    }
}
