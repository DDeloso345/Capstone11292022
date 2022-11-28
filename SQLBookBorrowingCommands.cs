using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLBookBorrowingCommands
    {
        public List<BookBorrowingInfo> LoadBookBorrowingData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BookBorrowingInfo>($"select *from [Book Borrowing]").ToList();
                return output;
            }
        }
        public List<ApprovedNotifs> LoadApprovedNotifs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<ApprovedNotifs>($"select* from[Approved Book Borrowing Notifications]").ToList();
                return output;
            }
        }
        public List<getBKBRColumn> LoadApprovedNotifsCriteria()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBRColumn>($"SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('approvedrequests')").ToList();
                return output;
            }
        }
        public List<getBKBRColumn> LoadSearchCriteria()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBRColumn>($"SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('Book Borrowing')").ToList();
                return output;
            }
        }
        public List<BKBRNotifs> LoadNotifs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BKBRNotifs>($"select NotificationMsg, DatePosted from bkbr_notif").ToList();
                return output;
            }
        }
        public List<BKBRNotifs> LoadBkExpNotif() {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BKBRNotifs>($"select n.NotificationMsg, n.DatePosted, s.Source from bkbr_notif_exp n inner join bkbr_notifsrc s on(n.Source = s.id)").ToList();
                return output;
            }
        }
        public String CountNotifs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BKBRNotifs>($"select NotificationMsg, DatePosted from bkbr_notif").ToList();
                String str = Convert.ToString(output.Count);
                return str;
            }
        }

        public String GetAndDisplayMsgNotif(String msg)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select NotificationMsg from bkbr_notif where NotificationMsg = '{msg}'");
                String con = Convert.ToString(output);
                return con;
            }
        }
        public String GetAndDisplayTimestamp(String msg)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select DatePosted from bkbr_notif where NotificationMsg = '{msg}'");
                String con = Convert.ToString(output);
                return con;
            }
        }
        public List<BookBorrowingInfo> SelectAllPendingExpired(String dateend) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BookBorrowingInfo>($"select id from BKBorrowingInfo where DueDate = '{dateend}'").ToList();
                return output;
            }
        }
        public List<BKBRNotifs> GetMsgNotifWLike(String msg, DateTime dt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                String conv = dt.ToString("yyyy-MM-dd");
                var output = connection.Query<BKBRNotifs>($"select NotificationMsg from bkbr_notif where NotificationMsg like '%{msg}%' and NotificationMsg like '%{conv}%'").ToList();
                return output;
            }
        }
        public void AddNotifExpTommorow(String id) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var uid_id = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from BKBorrowingInfo where id = '{id}'"));
                var uid = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = '{uid_id}'"));
                var acn = Convert.ToString(connection.ExecuteScalar($"select AccessionNo from BKBorrowingInfo where id = '{id}'"));
                var bkt = Convert.ToString(connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = '{acn}'"));
                var output = connection.Execute($"insert into bkbr_notif values('The book being borrowed with the title {bkt} borrowed by {uid} will expire tomorrow. \nPlease contact the following member to inform them about the the book they have been borrowing.',CURRENT_TIMESTAMP, '{acn}', '{uid_id}', "+" 2)");
            }
        }
        public void AddNotifExpToday(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var uid_id = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from BKBorrowingInfo where id = '{id}'"));
                var uid = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = '{uid_id}'"));
                var acn = Convert.ToString(connection.ExecuteScalar($"select AccessionNo from BKBorrowingInfo where id = '{id}'"));
                var bkt = Convert.ToString(connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = '{acn}'"));
                var output = connection.Execute($"insert into bkbr_notif values('The book being borrowed with the title {bkt} borrowed by {uid} will expire today. \nPlease contact the following member to inform them about the the book they have been borrowing.',CURRENT_TIMESTAMP, '{acn}', '{uid_id}', " + " 2)");
            }
        }
        public void AddNotif(String id, String expdate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var uid_id = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from BKBorrowingInfo where id = '{id}'"));
                var uid = Convert.ToString(connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = '{uid_id}'"));
                var acn = Convert.ToString(connection.ExecuteScalar($"select AccessionNo from BKBorrowingInfo where id = '{id}'"));
                var bkt = Convert.ToString(connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = '{acn}'"));
                var output = connection.Execute($"insert into bkbr_notif values('The book being borrowed with the title {bkt} borrowed by {uid} will expire on {expdate}. \nPlease contact the following member to inform them about the the book they have been borrowing.',CURRENT_TIMESTAMP, '{acn}', '{uid_id}', " + " 2)");
            }
        }

        public String getAuthorID(String aut)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select id from BKINV_AuthorInfo where BookAuthor = '{aut}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public String setAuthor(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select BookAuthor from BKINV_BKInfo where id = '{id}'");
                String conv = Convert.ToString(op);
                var op2 = connection.ExecuteScalar($"select BookAuthor from BKINV_AuthorInfo where id = '{conv}'");
                String conv2 = Convert.ToString(op2);
                return conv2;
            }
        }
        public List<getBKBRColumn> LoadAccNo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBRColumn>($"select AccessionNumber from [Book Inventory]").ToList();
                return output;
            }
        }
        public String getAccNoID(String AccNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select id from BKINV_BKInfo where AccessionNumber = '{AccNo}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public String setAccNo(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select AccessionNumber from BKINV_BKInfo where id = '{id}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public List<getBKBRColumn> LoadBKTitle()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBRColumn>($"select BookTitle from [Book Inventory]").ToList();
                return output;
            }
        }
        public String getBKTitleID(String title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '{title}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public String setBKTitle(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = '{id}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public List<getBKBRColumn> LoadUID()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBRColumn>($"select COCPL_UID from member_id_info").ToList();
                return output;
            }
        }
        public String getUIDID(String UID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select id from member_id_info where COCPL_UID = '{UID}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public List<getBKBRColumn> LoadApprovedBy()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKBRColumn>($"select username as ApprovedBy from emp_info_main").ToList();
                return output;
            }
        }
        public String setEmpName(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select FirstName + ' '+ LastName from emp_info_main where id = '{id}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public String getEmployeeID(String name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                var op = connection.ExecuteScalar($"select id from emp_info_main where username like '%{name}%'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public String getcurrEmployeeID(String un)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var op = connection.ExecuteScalar($"select id from emp_info_main where Username = '{un}'");
                String conv = Convert.ToString(op);
                return conv;
            }
        }
        public void InsertBKBRRecords(String title, String AccNo, String author, String uid, DateTime dtbr, DateTime dtdue)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    var dup3 = connection.Query<BookBorrowingInfo>($"select *from BKBorrowingInfo where BKAvailability " +
                        $"like '{"1"}' and COCPL_UID = '{uid}'").ToList();
                    var ava = connection.ExecuteScalar($"select Availability from BKINV_BKInfo where id = {title}");
                    String cn = Convert.ToString(ava);
                    if (dup3.Count > 3 || dup3.Count == 3)
                    {
                        MessageBox.Show("The said member has already borrowed the maximum number of books limited for this day.", "Book Borrowing Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (!cn.Equals("5"))
                    {
                        var ava_txt = connection.ExecuteScalar($"select Availability from BKINV_Availability where id = {cn}");
                        String con = Convert.ToString(ava_txt);
                        var bktitle = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = {title}");
                        String t = Convert.ToString(bktitle);
                        MessageBox.Show(t + " cannot be borrowed because it is currently " + con + ".", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String curr_emp = getcurrEmployeeID(Properties.Settings.Default.loginusername);
                        var op = connection.Execute($"insert into BKBorrowingInfo values ('{title}', '{AccNo}', 1, '{author}', '{uid}', '{dtbr}', '{dtdue}', '{curr_emp}', '{curr_emp}', CURRENT_TIMESTAMP, 1)");
                        var bkt = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = {title}");
                        var acc = connection.ExecuteScalar($"select AccessionNumber from BKINV_BKInfo where id = {AccNo}");
                        String con = Convert.ToString(bkt);
                        String con2 = Convert.ToString(acc);
                        var upd_avail = connection.Execute($"update BKINV_BKInfo set Availability = 1 where BookTitle = '{con}' and AccessionNumber = '{con2}'");
                        var updm = connection.Execute($"update BKINV_Main set Availability = 1 where BookTitle = '{title}' and AccessionNumber = '{AccNo}'");
                        MessageBox.Show("The specified book borrowing record has been inserted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception) {
                    MessageBox.Show("The error might have been caused by the following reason:" +
                        "\n1. A valid selection has not been made in the Book Title, Accession Number, Author, and/or COCPL UID text field/s.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        public void UpdateBKBRRecords(String id, String bkt, String acc, String auth, String uid, DateTime dtb, DateTime dtd, String ab, DateTime ao,
                                      String titletxt, String accttxt, String authtxt, String uidtxt, String abtxt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var bki = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = {bkt}");
                    var c1t = Convert.ToString(bki);
                    var acci = connection.ExecuteScalar($"select AccessionNumber from BKINV_BKInfo where id = {acc}");
                    var c2a = Convert.ToString(acci);
                    var au = connection.ExecuteScalar($"select BookAuthor from BKINV_AuthorInfo where id = {auth}");
                    var c3au = Convert.ToString(au);
                    var uidm = connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = {uid}");
                    var c4 = Convert.ToString(uidm);
                    String str = Convert.ToString(dtb);
                    String str1 = Convert.ToString(dtd);
                    var abs = connection.ExecuteScalar($"select FirstName + ' ' + LastName from emp_info_main where id = {ab}");
                    String abs_s = Convert.ToString(abs);
                    var dlg = MessageBox.Show("Please double-check the following information before proceeding to update the specified record.\n\n"
                    + "\nBook Borrowing Record ID:" + id
                    + "\nBook Title: " + titletxt
                    + "\nAccession No.: " + accttxt
                    + "\nAuthor: " + authtxt
                    + "\nCOCPL UID: " + uidtxt
                    + "\nDate Borrowed: " + dtb
                    + "\nDue Date: " + dtd
                    + "\nApproved by: " + abtxt
                    + "\nApproved on: " + ao
                    + "\n\nDo you wish to proceed in updating this record with the following values?", "Confirmation for updating book borrowing record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dlg == DialogResult.Yes)
                    {
                        var op = connection.Execute($"update BKBorrowingInfo set " +
                            $"BookTitle = {bkt}, " +
                            $"AccessionNo = {acc}, " +
                            $"BookAuthor = {auth}, " +
                            $"COCPL_UID = {uid}, " +
                            $"Date_Borrowed = '{dtb}', " +
                            $"DueDate = '{dtd}', " +
                            $"ApprovedBy = {ab}, " +
                            $"EmpUsername = {ab}, " +
                            $"ApprovedOn = '{ao}'" +
                            $" where id = {id}");
                        MessageBox.Show("The specified book borrowing record has now been updated.", "Success!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("The following error might be caused on one of the following conditions:" +
                        "\n1. No row was selected from the table provided." +
                        "\n2. Inappropriate values were detected in the 'Approved On' text field" +
                        "\n3. A valid selection has not been made in the Book Title, Accession Number, Author, Aprroved By, Staff Username, and/or COCPL UID text field/s.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteBKBRRecords(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var bkt = connection.ExecuteScalar($"select BookTitle from BKBorrowingInfo where id = {id}");
                    var c1 = Convert.ToString(bkt);
                    var bki = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = {c1}");
                    var c1t = Convert.ToString(bki);
                    var acc = connection.ExecuteScalar($"select AccessionNo from BKBorrowingInfo where id = {id}");
                    var c2 = Convert.ToString(acc);
                    var acci = connection.ExecuteScalar($"select AccessionNumber from BKINV_BKInfo where id = {c2}");
                    var c2a = Convert.ToString(acci);
                    var aub = connection.ExecuteScalar($"select BookAuthor from BKBorrowingInfo where id = {id}");
                    var c3 = Convert.ToString(aub);
                    var au = connection.ExecuteScalar($"select BookAuthor from BKINV_AuthorInfo where id = {c3}");
                    var c3au = Convert.ToString(au);
                    var uid = connection.ExecuteScalar($"select COCPL_UID from BKBorrowingInfo where id = {id}");
                    var c4m = Convert.ToString(uid);
                    var uidm = connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = {c4m}");
                    var c4 = Convert.ToString(uidm);
                    var dtb = connection.ExecuteScalar($"select Date_Borrowed from BKBorrowingInfo where id = {id}");
                    var dtd = connection.ExecuteScalar($"select DueDate from BKBorrowingInfo where id = {id}");
                    String str = Convert.ToString(dtb);
                    String str1 = Convert.ToString(dtd);
                    var ab = connection.ExecuteScalar($"select ApprovedBy from BKBorrowingInfo where id = {id}");
                    String ab_s = Convert.ToString(ab);
                    var abs = connection.ExecuteScalar($"select FirstName + ' ' + LastName from emp_info_main where id = {ab_s}");
                    String abs_s = Convert.ToString(abs);
                    var ao = connection.ExecuteScalar($"select ApprovedOn from BKBorrowingInfo where id = {id}");
                    String aoi = Convert.ToString(ao);
                    var dlg = MessageBox.Show("Please double-check the following information before proceeding to delete the specified record.\n\n"
                    + "\nBook Borrowing Record ID:" + id
                    + "\nBook Title: " + c1t
                    + "\nAccession No.: " + c2a
                    + "\nAuthor: " + c3au
                    + "\nCOCPL UID: " + c4
                    + "\nDate Borrowed: " + str
                    + "\nDue Date: " + str1
                    + "\nApproved by: " + abs_s
                    + "\nApproved on: " + aoi
                    + "\n\nDo you wish to proceed in deleting this record?", "Confirmation for book borrowing record deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); ;
                    if (dlg == DialogResult.Yes)
                    {
                        var op = connection.Execute($"delete from BKBorrowingInfo where id = {id}");
                        MessageBox.Show("The specified book borrowing record has now been deleted.", "Success!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select first an option from the table provided.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public List<BookBorrowingInfo> SearchBookBorrowingRecords(String criteria, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BookBorrowingInfo>($"select *from [Book Borrowing] where {criteria} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public List<BookBorrowingInfo> SearchBookBorrowingRecordsAO(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BookBorrowingInfo>($"select * from [Book Borrowing] where DATEPART(YYYY, ApprovedOn) like '%{inp}%' OR DATEPART(MM, ApprovedOn) like '%{inp}%' OR DATEPART(dd, ApprovedOn) like '%{inp}%' OR DATEPART(HH, ApprovedOn) like '%{inp}%' OR DATEPART(MINUTE, ApprovedOn) like '%{inp}%' OR DATEPART(ss, ApprovedOn) like '%{inp}%' OR ApprovedOn like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public List<ApprovedNotifs> SearchApprovedBookBorrowingRecords(String criteria, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<ApprovedNotifs>($"select *from [Approved Book Borrowing Notifications] where {criteria} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public List<ApprovedNotifs> SearchApprovedBookBorrowingRecordsDA(String crt, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<ApprovedNotifs>($"select *from [Approved Book Borrowing Notifications] where DATEPART(YYYY, {crt}) like '%{inp}%' OR DATEPART(MM, {crt}) like '%{inp}%' OR DATEPART(dd, {crt}) like '%{inp}%' OR DATEPART(HH, {crt}) like '%{inp}%' OR DATEPART(MINUTE, {crt}) like '%{inp}%' OR DATEPART(ss, {crt}) like '%{inp}%' OR {crt} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public String getAccNoIDFromNotifs(String msg)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select AccessionNo from [Book Borrowing Notifications] where NotificationMsg = '{msg}'");
                String con = Convert.ToString(output);
                return con;
            }
        }
        public String getUID_IDFromNotifs(String msg)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select COCPL_UID from [Book Borrowing Notifications] where NotificationMsg = '{msg}'");
                String con = Convert.ToString(output);
                return con;
            }
        }
        public String GetAndDisplayMsgApprovedNotif(String msg)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select NotificationMsg from approvedrequests where NotificationMsg = '{msg}'");
                String con = Convert.ToString(output);
                return con;
            }
        }
        public void InsertApprovedBKBRFromKiosk(String notif, String bktitle, String uid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var get_uid = connection.ExecuteScalar($"select id from member_id_info where COCPL_UID = '{uid}'");
                var get_title = connection.ExecuteScalar($"select id from BKINV_BKInfo where AccessionNumber = '{bktitle}'");
                var get_aut = connection.ExecuteScalar($"select BookAuthor from BKINV_BKInfo where AccessionNumber = '{bktitle}'");
                var get_st = connection.ExecuteScalar($"select id from emp_info_main where Username = '{Properties.Settings.Default.loginusername}'");
                String _uid = Convert.ToString(get_uid);
                String title = Convert.ToString(get_title);
                String aut = Convert.ToString(get_aut);
                String st = Convert.ToString(get_st);
                var dup3 = connection.Query<BookBorrowingInfo>($"select *from BKBorrowingInfo where BKAvailability " +
                    $"like '%{"1"}%' and COCPL_UID = '{_uid}'").ToList();
                var ava = connection.ExecuteScalar($"select Availability from BKINV_BKInfo where id = {title}");
                String cn = Convert.ToString(ava);
                if (dup3.Count > 3 || dup3.Count == 3)
                {
                    var ok = MessageBox.Show("The said member has already borrowed the maximum number of books.", "Book Borrowing Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (ok == DialogResult.OK)
                    {
                        var del = MessageBox.Show("The following notification has the message:" + "\n\n" + GetAndDisplayMsgNotif(notif).ToString() + "\n\nDo you want to delete the following notification?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (del == DialogResult.Yes)
                        {
                            DeleteNotif(notif);
                        }
                    }
                }
                else if (!cn.Equals("5"))
                {
                    var ava_txt = connection.ExecuteScalar($"select Availability from BKINV_Availability where id = {cn}");
                    String con = Convert.ToString(ava_txt);
                    var bt = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = {title}");
                    String t = Convert.ToString(bt);
                    MessageBox.Show(t + " cannot be borrowed because it is currently " + con + ".", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    var bkt = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = {title}");
                    var acc = connection.ExecuteScalar($"select AccessionNumber from BKINV_BKInfo where id = {title}");
                    String con = Convert.ToString(bkt);
                    String con2 = Convert.ToString(acc);

                    var op = connection.ExecuteScalar($"insert into BKBorrowingInfo " +
                        $"values ('{title}', " +
                        $"'{title}', " +
                        $"1, " +
                        $"'{aut}', " +
                        $"'{_uid}', " +
                        $"CURRENT_TIMESTAMP, " +
                        $"DATEADD(DAY, 7, CURRENT_TIMESTAMP), " +
                        $"'{st}', " +
                        $"'{st}', CURRENT_TIMESTAMP, 2)");

                    var upd_avail = connection.Execute($"update BKINV_BKInfo set Availability = 1 where BookTitle = '{con}' and AccessionNumber = '{con2}'");
                    var updm = connection.Execute($"update BKINV_Main set Availability = 1 where BookTitle = '{title}' and AccessionNumber = '{title}'");


                    String uidnotif = GetAndDisplayMsgNotif(notif).Replace("Would you like to approve the following book borrowing request?", "");
                    var ins_approved = connection.ExecuteScalar($"insert into approvedrequests values ('{uidnotif}', '" + GetAndDisplayTimestamp(notif) + "', CURRENT_TIMESTAMP, '" + title + "' , '" + _uid + "', 2)");

                    var delnotif = connection.Execute($"delete from bkbr_notif where NotificationMsg = '{notif}'");

                    var str_uid = connection.ExecuteScalar($"select COCPL_UID from member_id_info where id = '{_uid}'");
                    String conv_str_uid = Convert.ToString(str_uid);
                    var str_title = connection.ExecuteScalar($"select BookTitle from BKINV_BKInfo where id = '{title}'");
                    String conv_str_title = Convert.ToString(str_title);
                    MessageBox.Show("The book borrowing request by member " + conv_str_uid + " who has borrowed the book " + conv_str_title +
                        "\nhas been successfully approved and added to the system.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void DeleteNotif(String notif)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"delete from bkbr_notif where NotificationMsg = '{notif}'");
                MessageBox.Show("The specified notification has been deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DeleteApprovedRequests(String notif)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"delete from approvedrequests where NotificationMsg = '{notif}'");
                MessageBox.Show("The specified notification has been deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<getBookInfo> LoadBookInfo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBookInfo>($"select * from [BKBR Book Information]").ToList();
                return output;
            }
        }
        public List<getBookInfo> SearchBookInfo(String crit, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBookInfo>($"select * from [BKBR Book Information] where {crit} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public List<getCOCPLUID> LoadCOCPL_UID()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getCOCPLUID>($"select COCPL_UID from member_id_info").ToList();
                return output;
            }
        }
        public List<getCOCPLUID> SearchCOCPL_UID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getCOCPLUID>($"select COCPL_UID from member_id_info where COCPL_UID like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
        public List<getEmpInfo> LoadStaffInfo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getEmpInfo>($"select * from [BKBR Staff Information]").ToList();
                return output;
            }
        }
        public List<getEmpInfo> SearchStaffInfo(String crit, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getEmpInfo>($"select * from [BKBR Staff Information] where {crit} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("The keywords that you have searched for yields no results.\nPlease try a different set of keywords.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return output;
            }
        }
    }
}
