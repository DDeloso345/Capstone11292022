using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLBKBorrowerInfoCommands
    {
        public List<ApprovedNotifs> LoadIndBKBR_Cmb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<ApprovedNotifs>($"select COCPL_UID from member_id_info").ToList();
                return output;
            }
        }
        public List<BKBR_Ind_Rec> LoadIndBKBRData_DGV(String uid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BKBR_Ind_Rec>($"select *from [Book Borrowing Individual Member Records] where COCPL_UID = '{uid}'").ToList();
                return output;
            }
        }
        public String getFullName(String uid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select FirstName + ' ' + MiddleName + ' ' + LastName from member_id_info where COCPL_UID = '{uid}'");
                return Convert.ToString(output);
            }
        }
        public String getSuffix(String uid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select Suffix from [Member Data] where COCPL_UID = '{uid}'");
                return Convert.ToString(output);
            }
        }
        public List<BKBR_Ind_Rec> SearchIndDetails(String uid, String crit, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BKBR_Ind_Rec>($"select *from [Book Borrowing Individual Member Records] where {crit} like '%{inp}%' and COCPL_UID like '%{uid}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;

            }
        }
        public List<BKBR_Ind_Rec> SearchApprovedOn(String uid, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BKBR_Ind_Rec>($"select *from [Book Borrowing Individual Member Records] where COCPL_UID like '%{uid}%' and DATEPART(YYYY, ApprovedOn) like '%{inp}%' OR COCPL_UID like '%{uid}%' and DATEPART(MM, ApprovedOn) like '%{inp}%' OR COCPL_UID like '%{uid}%' and DATEPART(dd, ApprovedOn) like '%{inp}%' OR COCPL_UID like '%{uid}%' and DATEPART(HH, ApprovedOn) like '%{inp}%' ORCOCPL_UID like '%{uid}%' and DATEPART(MINUTE, ApprovedOn) like '%{inp}%' OR COCPL_UID like '%{uid}%' and DATEPART(ss, ApprovedOn) like '%{inp}%' OR COCPL_UID like '%{uid}%' and ApprovedOn like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public void DeleteBKBR_Ind_Rec(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"delete from BKBorrowingInfo where id = {inp}");
                MessageBox.Show("The specified record has been deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
