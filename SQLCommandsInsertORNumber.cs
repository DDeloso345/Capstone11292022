using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLCommandsInsertORNumber
    {
        public void InsertMemberOR(String UID, String FirstName, String MiddleName, String LastName, string Suffix, String MemberStart, String MemberEnd, String ORNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Execute($"insert into member_receipts values ('{UID}','{FirstName}','{MiddleName}','{LastName}','{ORNumber}', CURRENT_TIMESTAMP)");
            }
        }
        public List<ORHistoryClass> CheckORDuplicates(String number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                DateTime dt = DateTime.Now;
                var com = connection.Query<ORHistoryClass>($"select *from member_receipts where ORNumber = '{number}'").ToList();
                if (com.Count > 0)
                {
                    MessageBox.Show("A duplicate OR number has been detected within the database.\nPlease enter another OR number.");
                }
                else if (com.Count == 0)
                {
                }
                return com;
            }
        }
    }
}
