using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLBookReturnsCommands
    {
        public List<BookReturnsInfo> LoadBookReturnsData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BookReturnsInfo>($"select *from [Book Returns]").ToList();
                return output;
            }
        }
        public List<getBRColumn> LoadSearchCriteria()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBRColumn>($"SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('Book Returns')").ToList();
                return output;
            }
        }
        public List<getBKBR_Ref_Info> LoadSelectBKBR_Ref_Info()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBR_Ref_Info>($"select *from [BKBR Reference to Book Returns]").ToList();
                return output;
            }
        }
        public List<getBRColumn> LoadSearchCmb_BKBR_RefInfo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBRColumn>($"SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('BKBR Reference to Book Returns')").ToList();
                return output;
            }
        }
        public List<BookReturnsInfo> SearchBookReturnsData(String crit, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BookReturnsInfo>($"select *from [Book Returns] where {crit} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public List<BookReturnsInfo> SearchBookReturnsDataReturnedOn(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BookReturnsInfo>($"select *from [Book Returns] where DATEPART(YYYY, ReturnedOn) like '%{inp}%' OR DATEPART(MM, ReturnedOn) like '%{inp}%' OR DATEPART(dd, ReturnedOn) like '%{inp}%' OR DATEPART(HH, ReturnedOn) like '%{inp}%' OR DATEPART(MINUTE, ReturnedOn) like '%{inp}%' OR DATEPART(ss, ReturnedOn) like '%{inp}%' OR ReturnedOn like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public List<getBKBR_Ref_Info> SearchBKBR_Ref_Info(String crit, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBR_Ref_Info>($"select *from [BKBR Reference to Book Returns] where {crit} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public String getID_BKBR_RefInfo(String uid, String title, String accno, String aut, DateTime dtb, DateTime duedt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                String a = dtb.ToString("yyyy-MM-dd");
                String b = duedt.ToString("yyyy-MM-dd");
                var output = Convert.ToString(connection.ExecuteScalar($"select id from [BKBR Reference to Book Returns] where COCPL_UID  = '{uid}' and BookTitle = '{title}' and AccessionNumber = '{accno}' and BookAuthor = '{aut}' and Date_Borrowed = '{a}' and DueDate = '{b}'"));
                return output;
            }
        }
        public List<getBRColumn> LoadisPaid()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBRColumn>($"SELECT isPaid from BKR_PaymentStatus").ToList();
                return output;
            }
        }
        public String get_Username_id(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.ExecuteScalar($"select id from emp_info_main where username = '{inp}'"));
                return output;
            }
        }
        public String get_isPaid_id(String inp) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.ExecuteScalar($"select id from BKR_PaymentStatus where isPaid = '{inp}'"));
                return output;
            }
        }
        public List<getBRColumn> LoadBKReturnsRemarks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBRColumn>($"SELECT BKReturnsRemarks from BKReturnsRemarks").ToList();
                return output;
            }
        }
        public String getBKRetRem_id(String inp) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = Convert.ToString(connection.ExecuteScalar($"select id from BKReturnsRemarks where BKReturnsRemarks = '{inp}'"));
                return output;
            }
        }
        public void InsertBKReturnsRecords(String bkbr_ref, String rem, String rem_id, String fines, String fines_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    String accno = Convert.ToString(connection.ExecuteScalar($"select AccessionNumber from [Book Borrowing] where id = {bkbr_ref}"));
                    String bktitle = Convert.ToString(connection.ExecuteScalar($"select BookTitle from [Book Borrowing] where id = {bkbr_ref}"));
                    String accno_id = Convert.ToString(connection.ExecuteScalar($"select id from BKINV_BKInfo where AccessionNumber = '{accno}'"));
                    String bkt_id = Convert.ToString(connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '" +
                        $"{bktitle}'"));
                    var e_id = connection.ExecuteScalar($"select id from emp_info_main where username = '{Properties.Settings.Default.loginusername}'");
                    if (e_id.Equals("-1"))
                    {
                        MessageBox.Show(Properties.Settings.Default.loginusername);
                    }
                    else {
                        var ins_br = connection.Execute($"insert into BKReturns values ('{bkbr_ref}','{bkbr_ref}','{bkbr_ref}','{bkbr_ref}','{bkbr_ref}','{bkbr_ref}','{rem}'," +
                            $"'{rem_id}','{fines}','{fines_id}','{e_id}','{e_id}',CURRENT_TIMESTAMP)");
                        var upd_bkinfo = connection.Execute($"update BKINV_BKInfo set Availability = 5 where BookTitle = '{bktitle}' and AccessionNumber = '{accno}'");
                        var upd_bkmain = connection.Execute($"update BKINV_Main set Availability = 5 where BookTitle = '{bkt_id}' and AccessionNumber = '{accno_id}'");
                        var upd_bkbr = connection.Execute($"update BKBorrowingInfo set BKAvailability = 5 where AccessionNo = '{accno_id}'");
                        MessageBox.Show("The specified book returns record has been successfully added.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }
        public void UpdateBKReturnsRecords(String id, String bkbr_ref, String staff, String rem, String rem_id, String fines, String fines_id, DateTime ret)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                String a = ret.ToString("yyyy-MM-dd HH:mm:ss");
                try {
                        var output = connection.Execute($"update BKReturns set " +
                            $"BookRemarksAndConditions = '{rem}', " +
                            $"BKReturnsRemarks = {rem_id}, " +
                            $"ImposedFines = {fines}, " +
                            $"FinesPaymentStatus = {fines_id}, " +
                            $"NotedBy = {staff}, " +
                            $"EmpUsername = {staff}, " +
                            $"ReturnedOn = '{a}' where id = '{id}'");
                        MessageBox.Show("The specified book returns record has been successfully updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 catch (Exception ex)
                {
                    MessageBox.Show("The following error might be caused on one of the following conditions:" +
                        "\n1. No row was selected from the table provided." +
                        "\n2. Inappropriate values were detected in the 'Returned On' text field" +
                        "\n3. A valid selection has not been made in the Information of Book to be Returned and/or Staff Authorization sections.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void DeleteBKReturnsRecords(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    String uid = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from [Book Returns] where id = {id}"));
                    String bktitle = Convert.ToString(connection.ExecuteScalar($"select BookTitle from [Book Returns] where id = {id}"));
                    String accno = Convert.ToString(connection.ExecuteScalar($"select AccessionNumber from [Book Returns] where id = {id}"));
                    String aut = Convert.ToString(connection.ExecuteScalar($"select BookAuthor from [Book Returns] where id = {id}"));
                    String dtbr = Convert.ToString(connection.ExecuteScalar($"select Date_Borrowed from [Book Returns] where id = {id}"));
                    String duedt = Convert.ToString(connection.ExecuteScalar($"select DueDate from [Book Returns] where id = {id}"));
                    String ntb = Convert.ToString(connection.ExecuteScalar($"select NotedBy from [Book Returns] where id = {id}"));
                    String un = Convert.ToString(connection.ExecuteScalar($"select Staff_Username from [Book Returns] where id = {id}"));
                    String bkr = Convert.ToString(connection.ExecuteScalar($"select BookRemarksAndConditions from [Book Returns] where id = {id}"));
                    String ret = Convert.ToString(connection.ExecuteScalar($"select ReturnedOn from [Book Returns] where id = {id}"));
                    String bkrm = Convert.ToString(connection.ExecuteScalar($"select BKReturnsRemarks from [Book Returns] where id = {id}"));
                    String fin = Convert.ToString(connection.ExecuteScalar($"select ImposedFines from [Book Returns] where id = {id}"));
                    String pms = Convert.ToString(connection.ExecuteScalar($"select FinesPaymentStatus from [Book Returns] where id = {id}"));

                    var dlg = MessageBox.Show("Please double-check the following information before proceeding to delete the specified record.\n\n"
                    + "\nBook Returns Record ID:" + id
                    + "\nCOCPL UID: " + uid
                    + "\nBook Title: " + bktitle
                    + "\nAccession No.: " + accno
                    + "\nAuthor: " + aut
                    + "\nDate Borrowed: " + dtbr
                    + "\nDue Date: " + duedt
                    + "\nNoted By: " + ntb
                    + "\nStaff Username: " + un
                    + "\nBook Remarks: " + bkr 
                    + "\nReturned On: " + ret
                    + "\nBook Returns Remarks: " + bkrm
                    + "\nImposed Fines (in Php): " + fin
                    + "\nPayment Status: " + pms
                    + "\n\nDo you wish to proceed in deleting this record with the following values?", "Confirmation for deleting book returns record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dlg == DialogResult.Yes) {
                        var output = connection.Execute($"delete from BKReturns where id = '{id}'");
                        MessageBox.Show("The specified book returns record has been successfully deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Please select first an option from the table provided.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
