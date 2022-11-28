using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLCommandsModifyORHistory
    {
        public void UpdateORRecord(String id, String number, string rec)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var com = connection.Query<ORHistoryClass>($"select *from member_receipts where ORNumber = '{number}'").ToList();
                    if (com.Count > 0)
                    {
                        MessageBox.Show("A duplicate OR number has been detected within the database.\nPlease enter another OR number.");
                    }
                    else if (com.Count == 0)
                    {
                        var output = connection.Execute($"update member_receipts set ORNumber = '{number}', ORReceivedDate = '{rec}' where id = {id}");
                        MessageBox.Show("The specified record has been updated successfully!");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("The following error might be caused by either one or some of these problems." +
                        "\n\n1. One or more of the fields have been left blank. Please insert the appropriate values accordingly." +
                        "\n2. An invalid format one the 'Date and time received' section has been placed. Please " +
                        "\ninsert values that would adhere to the specified format.'", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteORRecord(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Execute($"delete from member_receipts" +
                        $" where id = {id}");
                    MessageBox.Show("The specified record has been deleted successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("The record to be deleted was not specified by its ID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public List<ORHColumnName> getColumns()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                var output = connection.Query<ORHColumnName>($"SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('member_receipts')").ToList();
                return output;
            }
        }
        public List<ORHistoryClass> SearchORHistoryID(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                var output = connection.Query<ORHistoryClass>($"SELECT mr.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, m.MemberStart, m.MemberEnd, mr.ORNumber, mr.ORReceivedDate FROM member_receipts mr INNER JOIN member_id_info m ON(mr.FirstName = m.id) where mr.id like '%{keyword}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<ORHistoryClass> SearchORHistory(String criteria, String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                var output = connection.Query<ORHistoryClass>($"SELECT mr.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, m.MemberStart, m.MemberEnd, mr.ORNumber, mr.ORReceivedDate FROM member_receipts mr INNER JOIN member_id_info m ON(mr.FirstName = m.id) where m.{criteria} like '%{keyword}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public int ConvDateRecResult(String keyword)
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
        public List<ORHistoryClass> SearchORNum(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                var output = connection.Query<ORHistoryClass>($"SELECT mr.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, m.MemberStart, m.MemberEnd, mr.ORNumber, mr.ORReceivedDate FROM member_receipts mr INNER JOIN member_id_info m ON(mr.FirstName = m.id) where mr.ORNumber like '%{keyword}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<ORHistoryClass> SearchORDateRec(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                List<ORHistoryClass> nu = new List<ORHistoryClass>();
                ORHistory oh = new ORHistory();
                try
                {
                    var output = connection.Query<ORHistoryClass>($"SELECT mr.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, mr.ORNumber, mr.ORReceivedDate FROM member_receipts mr INNER JOIN member_id_info m ON(mr.FirstName = m.id) where (DATEPART(YYYY, ORReceivedDate) = {keyword} OR DATEPART(MM, ORReceivedDate) = {keyword} OR DATEPART(dd, ORReceivedDate) = {keyword} OR DATEPART(HH, ORReceivedDate) = {keyword} OR DATEPART(MINUTE, ORReceivedDate) = {keyword} OR DATEPART(ss, ORReceivedDate) = {keyword})").ToList();
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


        public String getORHistoryID(String keyword)
        {
            List<ORHistoryClass> nu = new List<ORHistoryClass>();
            ORHistory oh = new ORHistory();
            String n = "";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.ExecuteScalar($"SELECT id from member_receipts where id like '%{keyword}%'");
                    String con = Convert.ToString(output);
                    return con;
                }
                catch (Exception)
                {
                    oh.clear();
                    return n;
                }
                finally { }
            }
        }
        public String getEmpInfoID(String criteria, String keyword)
        {
            List<ORHistoryClass> nu = new List<ORHistoryClass>();
            ORHistory oh = new ORHistory();
            String n = "";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.ExecuteScalar($"SELECT id from member_id_info where {criteria} like '%{keyword}%'");
                    String con = Convert.ToString(output);
                    return con;
                }
                catch (Exception)
                {
                    oh.clear();
                    return n;
                }
                finally
                {
                }

            }
        }
    }
}
