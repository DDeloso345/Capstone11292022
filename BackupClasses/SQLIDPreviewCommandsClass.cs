using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Dapper;

namespace Capstone
{
    public class SQLIDPreviewCommandsClass
    {
        public void Name(String id){
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    var fn = connection.ExecuteScalar($"select FirstName from member_id_info where id = '{id}'");
                    String fn_str = Convert.ToString(fn);
                    fn_str = Properties.Settings.Default.memberfirstname;
                    var mn = connection.ExecuteScalar($"select MiddleName from member_id_info where id = '{id}'");
                    String mn_str = Convert.ToString(mn);
                    mn_str = Properties.Settings.Default.membermiddlename;
                    var ln = connection.ExecuteScalar($"select LastName from member_id_info where id = '{id}'");
                    String ln_str = Convert.ToString(ln);
                    ln_str = Properties.Settings.Default.memberlastname;
                    var uid = connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = '{id}'");
                    String uid_str = Convert.ToString(uid);
                    uid_str = Properties.Settings.Default.memberuid;
                    Properties.Settings.Default.Save();
                }
                catch (Exception) {
                    MessageBox.Show("The system has detected invalid parameters.\nPlease try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        public void TableName(String ID) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
            try { 
                var fn = connection.ExecuteScalar($"select FirstName from member_id_info where id = '{ID}'");
                String fn_str = Convert.ToString(fn);
                fn_str = Properties.Settings.Default.memberfirstname;
                var ln = connection.ExecuteScalar($"select LastName from member_id_info where id = '{ID}'");
                String ln_str = Convert.ToString(ln);
                ln_str = Properties.Settings.Default.memberlastname;
                var uid = connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = '{ID}'");
                String uid_str = Convert.ToString(uid);
                uid_str = Properties.Settings.Default.memberuid;
                Properties.Settings.Default.Save();
            }
                catch (Exception)
            {
                MessageBox.Show("The system has detected invalid parameters.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
        public void Miscellaneous(String id) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
            try { 
                var org = connection.ExecuteScalar($"select Organization from member_id_info where id = '{id}'");
                String org_str = Convert.ToString(org);
                org_str = Properties.Settings.Default.memberfirstname;
                var address = connection.ExecuteScalar($"select Address from member_id_info where id = '{id}'");
                String address_str = Convert.ToString(address);
                address_str = Properties.Settings.Default.memberaddress;
                var email = connection.ExecuteScalar($"select EMailAddress from member_id_info where id = '{id}'");
                String email_str = Convert.ToString(email);
                email_str = Properties.Settings.Default.memberemail;
                var contact = connection.ExecuteScalar($"select ContactNo from member_id_info where id = '{id}'");
                String contact_str = Convert.ToString(contact);
                contact_str = Properties.Settings.Default.membercontactno;
                id = Properties.Settings.Default.memberuid;
                Properties.Settings.Default.Save();
            }
                catch (Exception)
            {
                MessageBox.Show("The system has detected invalid parameters.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
        public List<ORHistoryClass> Display(String uid, String fn, String ln) {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
                {
                    var output = connection.Query<ORHistoryClass>($"select COCPL_UID, FirstName, MiddleName, LastName, MemberStart, MemberEnd, ORNumber, ORReceivedDate from {uid}{fn}{ln}").ToList();
                    return output;
                }
            }
        }
        public void RenameORHistoryTbl(String olduid, String oldfn, String oldln, String newuid, String newfn, String newln) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    var output = connection.Execute($"exec sp_rename '{olduid}{oldfn}{oldln}', '{newuid}{newfn}{newln}'");
                }
                catch (Exception) { }
            }
        }
    }
}
