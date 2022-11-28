using Dapper;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLCheckActiveInactiveCommands
    {
        public void ActiveAcc(String un, String pw)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Execute($"update emp_info_main set ActiveStatus = '1' where username = '{un}' and password = '{pw}'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has been detected in the database. Please read the following text below for more information." +
                        "\n" + Convert.ToString(ex));
                }
            }
        }
        public void InactiveAcc(String un, String pw)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Execute($"update emp_info_main set ActiveStatus = '2' where username = '{un}' and password = '{pw}'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has been detected in the database. Please read the following text below for more information." +
                        "\n" + Convert.ToString(ex));
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
                    var output = connection.Execute($"insert into member_receipts values ('{ORNumber}','{dt}')");
                    var upd = connection.Execute($"update member_id_info set MemberEnd = '{dt_plus1yr}' where uid = '{uid}'");
                }
                catch (Exception)
                {
                    String membstart = Properties.Settings.Default.memberstart;
                    var input = connection.Execute($"insert into {uid}{firstname}{lastname} (ORNumber, ORReceivedDate) values ('{MemberStart}', '{MemberEnd}','{ORNumber}','{dt}')");
                }
                MessageBox.Show("The specified OR Number has been inserted successfully.");
            }
        }
    }
}
