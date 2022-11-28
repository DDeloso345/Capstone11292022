using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLProcessMemberInfoCommands
    {
        public List<AccountDetails_Get_Member> LoadMemberData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Member>($"select mn.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, s.Suffix, o.SchoolOrOrganization, m.Address, m.EMailAddress, m.ContactNo, m.MemberStart, m.MemberEnd, m.ImgPath from member_info_main mn " +
                    $"inner join member_id_info m " +
                    $"on(mn.COCPL_UID = m.id)" +
                    $"inner join name_suffix s " +
                    $"on(mn.Suffix = s.id) " +
                    $"inner join memb_SchoolOrOrg o " +
                    $"on(mn.SchoolOrOrganization = o.id)").ToList();
                return output;
            }
        }
        public List<GetOrgColumn> LoadOrgColumn()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<GetOrgColumn>($"select SchoolOrOrganization from memb_SchoolOrOrg").ToList();
                return output;
            }
        }

        public List<AccountDetails_Get_Member> SearchMemberDetails(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Member>($"select *from [Member Data] where {criteria} like '%{keyword}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public int ConvDate(String keyword)
        {
            int conv = 0;
            try
            {
                conv = Convert.ToInt32(keyword);
                return conv;
            }
            catch (Exception)
            {
                MessageBox.Show("Keyword was not converted successfully to an integer data type.");
                return conv;
            }
        }
        public List<AccountDetails_Get_Member> SearchMembStart(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                List<AccountDetails_Get_Member> nu = new List<AccountDetails_Get_Member>();
                ORHistory oh = new ORHistory();
                try
                {
                    var output = connection.Query<AccountDetails_Get_Member>($"select *from [Member Data] where (DATEPART(YYYY, MemberStart) like '%{keyword}%' OR DATEPART(MM, MemberStart) like '%{keyword}%' OR DATEPART(dd, MemberStart) like '%{keyword}%' OR DATEPART(HH, MemberStart) like '%{keyword}%' OR DATEPART(MINUTE, MemberStart) like '%{keyword}%' OR DATEPART(ss, MemberStart) like '%{keyword}%' OR MemberStart like '%{keyword}%')").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    oh.dgv_or_history.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    MessageBox.Show("Please insert appropriate values in the textbox with the following format: mm - dd - yyyy", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return nu;
                }
                finally
                {
                }
            }
        }
        public List<AccountDetails_Get_Member> SearchMembEnd(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                List<AccountDetails_Get_Member> nu = new List<AccountDetails_Get_Member>();
                ORHistory oh = new ORHistory();
                try
                {
                    var output = connection.Query<AccountDetails_Get_Member>($"select *from [Member Data] where (DATEPART(YYYY, MemberEnd) like '%{keyword}%' OR DATEPART(MM, MemberEnd) like '%{keyword}%' OR DATEPART(dd, MemberEnd) like '%{keyword}%' OR DATEPART(HH, MemberEnd) like '%{keyword}%' OR DATEPART(MINUTE, MemberEnd) like '%{keyword}%' OR DATEPART(ss, MemberEnd) like '%{keyword}%'  OR MemberEnd like '%{keyword}%')").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    oh.dgv_or_history.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    MessageBox.Show("Please insert appropriate values in the textbox with the following format: mm - dd - yyyy", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return nu;
                }
                finally
                {
                }
            }
        }
        public List<GetOrgColumn> SearchOrgCmb(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<GetOrgColumn>($"Select SchoolOrOrganization from memb_SchoolOrOrg where SchoolOrOrganization like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public String getOrganizationID(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var getID = connection.ExecuteScalar($"Select id from memb_SchoolOrOrg where SchoolOrOrganization = '{input}'");
                String a = Convert.ToString(getID);
                return a;
            }
        }
        public List<GetOrgColumn> CompareSameOrg(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var comp = connection.Query<GetOrgColumn>($"select *from memb_SchoolOrOrg where SchoolOrOrganization = '{input}'").ToList();
                if (input.Length == 0)
                {
                    MessageBox.Show("The record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (comp.Count > 0)
                {
                    MessageBox.Show("The specified school/organization has already existed within the system.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (comp.Count == 0 && input.Length > 0)
                {
                    var ins = connection.Execute($"insert into memb_SchoolOrOrg values ('{input}')");
                    MessageBox.Show("A new school/organization has been added successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return comp;
            }
        }
        public void UpdateOrg(String org, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (org.Length == 0 || id.Length == 0)
                {
                    MessageBox.Show("The record to be updated seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to update the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sel = connection.ExecuteScalar($"select SchoolOrOrganization from memb_SchoolOrOrg where id = '{id}'");
                    String con = Convert.ToString(sel);
                    var dlg = MessageBox.Show("Are you sure you want to update the specified old organization record '" + con + "' " + "to the new record '" + org + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"update memb_SchoolOrOrg set SchoolOrOrganization = '{org}' where id = '{id}'");
                        MessageBox.Show("The specified organization record has been updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void DeleteOrg(String org, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (org.Length == 0 || id.Length == 0)
                {
                    MessageBox.Show("The record to be deleted seems to be empty.\nPlease try selecting a record before proceeding to delete the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sel = connection.ExecuteScalar($"select SchoolOrOrganization from memb_SchoolOrOrg where id = '{id}'");
                    String con = Convert.ToString(sel);
                    var dlg = MessageBox.Show("Are you sure you want to delete the specified organization record '" + con + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"delete from memb_SchoolOrOrg where id = '{id}'");
                        MessageBox.Show("The specified organization record has been deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public String getMemberID(String uid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from member_id_info where COCPL_UID = '{uid}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public void InsertMember(string uid, string firstname, string middlename, string lastname, string suffix, string Organization, string Address, string Email, string ContactNo, string MemberStart, string MemberEnd, string imgpath)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Execute($"insert into member_id_info (COCPL_UID, FirstName, MiddleName, LastName, Suffix, SchoolOrOrganization, Address, EmailAddress, ContactNo, MemberStart, MemberEnd, ImgPath) values " +
                        $"('{uid}','{firstname}', '{middlename}','{lastname}','{suffix}','{Organization}', '{Address}', '{Email}','{ContactNo}','{MemberStart}', '{MemberEnd}', '{imgpath}')");
                    var output_mn = connection.Execute($"insert into member_info_main select id, id, id, id, suffix, schoolororganization, id, id, id, id, id, id from member_id_info where COCPL_UID = '{uid}'");
                    if (Properties.Settings.Default.membercatchinvaliddates.Length > 1)
                    {
                        MessageBox.Show("A new member account has been added successfully.");
                        InsertORNoForm or = new InsertORNoForm();
                        or.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error might be solved by applying either of the following suggestions:" +
                        "\n\nPlease select a valid option in the organization table." +
                        "\nPlease insert appropriate values in the 'Membership Start' and 'Membership End' with the following format: mm-dd-yyyy");
                    MessageBox.Show(Convert.ToString(ex));
                }
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
        public List<MemberNotifExpiryDate> SelectAllNotif()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<MemberNotifExpiryDate>($"select NotificationMsg, DatePosted from memb_exp_notifs").ToList();

                return output;
            }
        }
        public String CountAllNotif()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<MemberNotifExpiryDate>($"select NotificationMsg, DatePosted from memb_exp_notifs").ToList();
                String con = Convert.ToString(output.Count);
                return con;
            }
        }
        public String GetMsgNotif(String msg)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select NotificationMsg from memb_exp_notifs where NotificationMsg = '{msg}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String GetTimeStamp(String msg)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select DatePosted from memb_exp_notifs where NotificationMsg = '{msg}'");
                String con = Convert.ToString(output);
                return con;
            }
        }
        public void InsertNotif(String expiring_member, String expdate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"insert into memb_exp_notifs values ('The following account with the COCPL UID {expiring_member} will expire on {expdate}.\nPlease contact the following member to update their status on their membership.',CURRENT_TIMESTAMP)");
            }
        }
        public void InsertNotifExpToday(String expired_member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"insert into memb_exp_notifs values ('The following account with the COCPL UID {expired_member} has expired today.\nPlease contact the following member to update their status on their membership.',CURRENT_TIMESTAMP)");
            }
        }
        public void InsertNotifExpTomorrow(String expired_member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"insert into memb_exp_notifs values ('The following account with the COCPL UID {expired_member} will expire tomorrow. \nPlease contact the following member to update their status on their membership.',CURRENT_TIMESTAMP)");
            }
        }
        public List<AccountDetails_Get_Member> SelectAllPendingExpired(String dateend)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Member>($"select COCPL_UID from member_id_info where MemberEnd = '{dateend}'").ToList();
                return output;
            }
        }

        public List<AccountDetails_Get_Member> SelectAllFromPastWeek(String datestart)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Member>($"select COCPL_UID from member_id_info where MemberEnd between {datestart} and {DateTime.Now.ToString("yyyy-MM-dd")}").ToList();
                return output;
            }
        }
        public List<MemberNotifExpiryDate> GetMsgNotifWLike(String msg, String date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<MemberNotifExpiryDate>($"select NotificationMsg from memb_exp_notifs where NotificationMsg like '%{msg}%' and NotificationMsg like '%{date}%'").ToList();
                return output;
            }
        }
        public void DeleteNotif(String notif)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"delete from memb_exp_notifs where NotificationMsg = '{notif}'");
                MessageBox.Show("Notification successfully deleted!");
            }
        }
    }
}

