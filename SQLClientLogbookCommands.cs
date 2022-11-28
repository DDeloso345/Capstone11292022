using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLClientLogbookCommands
    {
        public List<ClientWalkInLogbookInfo> LoadLogbookData() {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<ClientWalkInLogbookInfo>($"select *from [Client Logbook]").ToList();
                return output;
            }
        }
        public List<getLogbookColumns> LoadLogbookCmb() {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getLogbookColumns>($"SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('clientlogbook')").ToList();
                return output;
            }
        }
        public List<ClientWalkInLogbookInfo> SearchLogbookData(String crit, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<ClientWalkInLogbookInfo>($"select *from [Client Logbook] where [{crit}] like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public void UpdateLogbookData(String id, String fn, String mn, String ln, String ad, String con, String dt) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                        var output = connection.Execute($"update clientlogbook set " +
                           $"FirstName = '{fn}', " +
                           $"MiddleName = '{mn}', " +
                           $"LastName = '{ln}', " +
                           $"Address = '{ad}', " +
                           $"ContactNo = '{con}', " +
                           $"Date = '{dt}' where id = '{id}'");
                        MessageBox.Show("The specified client logbook record has been successfully updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception) { 
                
                }
            }
        }
        public void DeleteLogbookData(String id) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    String fn = Convert.ToString(connection.ExecuteScalar($"select FirstName from clientlogbook where id = '{id}'"));
                    String mn = Convert.ToString(connection.ExecuteScalar($"select MiddleName from clientlogbook where id = '{id}'"));
                    String ln = Convert.ToString(connection.ExecuteScalar($"select LastName from clientlogbook where id = '{id}'"));
                    String ad = Convert.ToString(connection.ExecuteScalar($"select Address from clientlogbook where id = '{id}'"));
                    String con = Convert.ToString(connection.ExecuteScalar($"select ContactNo from clientlogbook where id = '{id}'"));
                    String dt = Convert.ToString(connection.ExecuteScalar($"select Date from clientlogbook where id = '{id}'"));
                    String tm = Convert.ToString(connection.ExecuteScalar($"select Time from clientlogbook where id = '{id}'"));
                    var dlg = MessageBox.Show("Please double-check the following information before proceeding to delete the specified record.\n\n"
                        + "\nClient Logbook Record ID:" + id
                        + "\nFirst Name: " + fn
                        + "\nMiddle Name: " + mn
                        + "\nLast Name: " + ln
                        + "\nAddress: " + ad
                        + "\nContact Number: " + con
                        + "\nDate: " + dt
                        + "\n\nDo you wish to proceed in updating this record with the following values?", "Confirmation for deleting client logbook records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes) {

                        var output = connection.Execute($"delete from clientlogbook where id = '{id}'");
                        MessageBox.Show("The specified client logbook record has been successfully deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
