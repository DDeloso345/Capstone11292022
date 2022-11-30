using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Staff_BookBorrowing : Form
    {
        public static String BookTitle = "";
        public static String AccessionNo = "";
        public static String Author = "";
        public static String COCPL_UID = "";
        public static String ApprovedBy = "";
        public static String StaffUsername = "";
        public Staff_BookBorrowing()
        {
            InitializeComponent();
            InsertNotifs();
        }
        SQLBookBorrowingCommands bc = new SQLBookBorrowingCommands();
        List<BookBorrowingInfo> bbi = new List<BookBorrowingInfo>();

        private void Staff_BookBorrowing_Load(object sender, System.EventArgs e)
        {
            UpdateBinding();
            ComboBoxSel();
        }

        public void UpdateBinding()
        {
            List<BKBRNotifs> n = new List<BKBRNotifs>();

            bbi = bc.LoadBookBorrowingData();
            dgv_bookborrowing.DataSource = bbi;

            DateTime dt = DateTime.Now;
            dtborrowed.Text = dt.ToString("MM-dd-yyyy");

            TimeSpan dt_1wk = new TimeSpan(7, 0, 0, 0);
            DateTime dt_plus1wk = dt.Add(dt_1wk);
            duedt.Text = dt_plus1wk.ToString("MM-dd-yyyy");

            n = bc.LoadNotifs();
            notifdgv.DataSource = n;
            notifcounter.Text = bc.CountNotifs();
        }
        public void clear()
        {
            bktitle.Text = "";
            accno.Text = "";
            bkauthor.Text = "";
            cocpluid.Text = "";
            appby.Text = "";
            empname.Text = "";
            approvedon.Text = "";

            titleid.Text = "[ID]";
            autid.Text = "[ID]";
            uidid.Text = "[ID]";
            empunid.Text = "[ID]";
        }
        public void ComboBoxSel()
        {
            SQLBookBorrowingCommands br = new SQLBookBorrowingCommands();
            List<getBKBRColumn> brc = new List<getBKBRColumn>();

            brc = bc.LoadSearchCriteria();
            cmbcriteria.DataSource = brc;
            cmbcriteria.DisplayMember = "name";
            /*
            brc = br.LoadBKTitle();
            bktitle.DataSource = brc;
            bktitle.DisplayMember = "BookTitle";

            brc = br.LoadAccNo();
            accno.DataSource = brc;
            accno.DisplayMember = "AccessionNumber";

            brc = br.LoadAuthor();
            bkauthor.DataSource = brc;
            bkauthor.DisplayMember = "BookAuthor";

            brc = br.LoadUID();
            cocpluid.DataSource = brc;

            cocpluid.DisplayMember = "COCPL_UID";

            brc = br.LoadApprovedBy();
            approvedby.DataSource = brc;
            approvedby.DisplayMember = "ApprovedBy";
            */
        }
        public void InsertNotifs()
        {
            TimeSpan dt3d = new TimeSpan(3, 0, 0, 0);
            DateTime a = DateTime.Now.Add(dt3d);
            String dtp3 = Convert.ToString(a.ToString("yyyy-MM-dd 00:00:00"));

            DateTime b = DateTime.Now;
            String conv_tostr = Convert.ToString(b.ToString("yyyy-MM-dd 00:00:00"));

            TimeSpan dt1d = new TimeSpan(1, 0, 0, 0);
            DateTime c = DateTime.Now.Add(dt1d);
            String str_1d = Convert.ToString(c.ToString("yyyy-MM-dd 00:00:00"));

            List<BookBorrowingInfo> exp_now = bc.SelectAllPendingExpired(conv_tostr);
            List<BookBorrowingInfo> exp_day_before = bc.SelectAllPendingExpired(str_1d);
            List<BookBorrowingInfo> exp3 = bc.SelectAllPendingExpired(dtp3);
            foreach (var getOne in exp_day_before)
            {
                if (exp_day_before.Count == 0) { }
                else if (exp_day_before.Count > 0)
                {
                    List<BKBRNotifs> b1 = bc.GetMsgNotifWLike(getOne.id, c);
                    if (b1.Count > 0)
                    {

                    }
                    else if (b1.Count == 0)
                    {
                        bc.AddNotifExpTommorow(getOne.id);
                        UpdateBinding();
                    }
                }
            }
            foreach (var getOne in exp3)
            {
                if (exp3.Count == 0) { }
                else if (exp3.Count > 0)
                {
                    List<BKBRNotifs> b1 = bc.GetMsgNotifWLike(getOne.id, a);
                    if (b1.Count > 0)
                    {
                        bc.AddNotif(getOne.id, dtp3);
                        UpdateBinding();
                    }
                    else if (b1.Count == 0)
                    {
                        bc.AddNotif(getOne.id, dtp3);
                        UpdateBinding();
                    }
                }
            }
            foreach (var getOne in exp_now)
            {
                if (exp_now.Count == 0) { }
                else if (exp_now.Count > 0)
                {
                    List<BKBRNotifs> b1 = bc.GetMsgNotifWLike(getOne.id, b);
                    if (b1.Count > 0)
                    {

                    }
                    else if (b1.Count == 0)
                    {
                        bc.AddNotifExpToday(getOne.id);
                        UpdateBinding();
                    }
                }
            }
        }
        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (cmbcriteria.Text.Equals("id"))
            {
                bbi = bc.SearchBookBorrowingRecords("id", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("BookTitle"))
            {
                bbi = bc.SearchBookBorrowingRecords("BookTitle", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("AccessionNo"))
            {
                bbi = bc.SearchBookBorrowingRecords("AccessionNumber", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("BookAuthor"))
            {
                bbi = bc.SearchBookBorrowingRecords("BookAuthor", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("COCPL_UID"))
            {
                bbi = bc.SearchBookBorrowingRecords("COCPL_UID", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }

            else if (cmbcriteria.Text.Equals("FirstName"))
            {
                bbi = bc.SearchBookBorrowingRecords("FirstName", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("MiddleName"))
            {
                bbi = bc.SearchBookBorrowingRecords("MiddleName", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("LastName"))
            {
                bbi = bc.SearchBookBorrowingRecords("LastName", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("Suffix"))
            {
                bbi = bc.SearchBookBorrowingRecords("Suffix", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("Date_Borrowed"))
            {
                bbi = bc.SearchBookBorrowingRecords("Date_Borrowed", searchinp.Text.Replace("/", "-"));
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("DueDate"))
            {
                bbi = bc.SearchBookBorrowingRecords("DueDate", searchinp.Text.Replace("/", "-"));
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("ApprovedBy"))
            {
                bbi = bc.SearchBookBorrowingRecords("ApprovedBy", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("EmpUsername"))
            {
                bbi = bc.SearchBookBorrowingRecords("EmpUsername", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("ApprovedOn"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bbi = bc.SearchBookBorrowingRecordsAO(searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
            else if (cmbcriteria.Text.Equals("PCSource"))
            {
                bbi = bc.SearchBookBorrowingRecords("Source", searchinp.Text);
                dgv_bookborrowing.DataSource = bbi;
            }
        }

        private void cmbcriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
            if (cmbcriteria.Text.Equals("Date_Borrowed"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (cmbcriteria.Text.Equals("DueDate"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbcriteria.Text.Equals("ApprovedOn"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void notifbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (notifbtn.Checked == true)
            {
                notifdgv.Visible = true;

            }
            else
            {
                notifdgv.Visible = false;
            }
        }

        private void dgv_bookborrowing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bkbrtimer.Enabled = false;
            if (dgv_bookborrowing.SelectedRows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_bookborrowing.Rows[e.RowIndex];
                    bookbrid.Text = row.Cells["ID"].Value.ToString();
                    bktitle.Text = row.Cells["BookTitle"].Value.ToString();
                    accno.Text = row.Cells["AccessionNumber"].Value.ToString();
                    bkauthor.Text = row.Cells["BookAuthor"].Value.ToString();
                    cocpluid.Text = row.Cells["COCPL_UID"].Value.ToString();
                    duedt.Text = row.Cells["DueDate"].Value.ToString();
                    dtborrowed.Text = row.Cells["Date_Borrowed"].Value.ToString();
                    empname.Text = row.Cells["ApprovedBy"].Value.ToString();
                    appby.Text = row.Cells["EmpUsername"].Value.ToString();
                    approvedon.Text = row.Cells["ApprovedOn"].Value.ToString();

                    titleid.Text = bc.getBKTitleID(bktitle.Text);
                    autid.Text = bc.getAuthorID(bkauthor.Text);
                    uidid.Text = bc.getUIDID(cocpluid.Text);
                    empunid.Text = bc.getEmployeeID(appby.Text);

                    updbtn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void selbkinfo_Click(object sender, EventArgs e)
        {
            bkbrtimer.Start();
            BKBR_SelectBookInfo bk = new BKBR_SelectBookInfo();
            bk.Show();
        }

        private void seluid_Click(object sender, EventArgs e)
        {
            bkbrtimer.Start();
            BKBR_SelectUID bk = new BKBR_SelectUID();
            bk.Show();
        }

        private void sel_emp_Click(object sender, EventArgs e)
        {
            bkbrtimer.Start();
            BKBR_SelectStaffUsername bk = new BKBR_SelectStaffUsername();
            bk.Show();
        }

        private void showappbtn_Click(object sender, EventArgs e)
        {
            Staff_BKBR_ApprovedNotifs a = new Staff_BKBR_ApprovedNotifs();
            a.Show();
        }

        private void viewbkbrindbtn_Click(object sender, EventArgs e)
        {
            Staff_BKBorrowersInfo ad = new Staff_BKBorrowersInfo();
            ad.Show();
        }

        private void bkbrtimer_Tick(object sender, EventArgs e)
        {
            SQLBookBorrowingCommands br = new SQLBookBorrowingCommands();

            if (Author.Length == 0 && BookTitle.Length == 0 && AccessionNo.Length == 0) { }
            else if (Author.Length > 0 && BookTitle.Length > 0 && AccessionNo.Length > 0)
            {
                bktitle.Text = BookTitle;
                accno.Text = AccessionNo;
                bkauthor.Text = Author;
                titleid.Text = br.getBKTitleID(bktitle.Text);
                autid.Text = br.getAuthorID(bkauthor.Text);
                bkbrtimer.Start();
                if (autid.Text.Length == 0)
                {
                    autid.Text = "[ID]";
                }
                if (titleid.Text.Length == 0)
                {
                    titleid.Text = "[ID]";
                }
            }

            if (COCPL_UID.Length == 0) { }
            else if (COCPL_UID.Length > 0)
            {
                bkbrtimer.Start();
                cocpluid.Text = COCPL_UID;
                uidid.Text = br.getUIDID(cocpluid.Text);
                if (uidid.Text.Length == 0)
                {
                    uidid.Text = "[ID]";
                }
            }

            if (ApprovedBy.Length == 0 && StaffUsername.Length == 0) { }
            else if (ApprovedBy.Length > 0 && StaffUsername.Length > 0)
            {
                bkbrtimer.Start();
                empname.Text = ApprovedBy;
                appby.Text = StaffUsername;
                empunid.Text = br.getEmployeeID(appby.Text);
                if (empunid.Text.Length == 0)
                {
                    empunid.Text = "[ID]";
                }
            }
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (bktitle.Text.Length == 0 ||
                accno.Text.Length == 0 ||
                bkauthor.Text.Length == 0 ||
                cocpluid.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left empty.\nPlease enter or select valid choices from the options provided.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var dlg = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to insert the specified record.\n\n"
                + "\nBook Title: " + bktitle.Text
                + "\nAccession No.: " + accno.Text
                + "\nAuthor: " + bkauthor.Text
                + "\nCOCPL UID: " + cocpluid.Text
                + "\nApproved by: " + empname.Text
                + "\nStaff Username: " + appby.Text
                + "\nDate Borrowed: " + dtborrowed.Value.ToShortDateString()
                + "\nDue Date: " + duedt.Value.ToShortDateString() + "\n\nAre the following information correct?", "Confirmation for book borrowing record entries", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dlg == DialogResult.Yes)
                {
                    DateTime a = dtborrowed.Value;
                    DateTime b = duedt.Value;
                    bc.InsertBKBRRecords(titleid.Text, titleid.Text, autid.Text, uidid.Text, a, b);
                    UpdateBinding();
                    ComboBoxSel();
                    clear();
                }
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bktitle.Text.Length == 0 ||
                accno.Text.Length == 0 ||
                bkauthor.Text.Length == 0 ||
                cocpluid.Text.Length == 0 ||
                empname.Text.Length == 0 ||
                appby.Text.Length == 0 ||
                approvedon.Text.Length == 0)
                {
                    MessageBox.Show("One or more of the fields have been left empty.\nPlease enter or select valid choices from the options provided.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    bc.UpdateBKBRRecords(bookbrid.Text, titleid.Text, titleid.Text, autid.Text, uidid.Text, dtborrowed.Value, duedt.Value, empunid.Text, Convert.ToDateTime(approvedon.Text), bktitle.Text, accno.Text, bkauthor.Text, cocpluid.Text, appby.Text);
                    UpdateBinding();
                    ComboBoxSel();
                    clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The following error might be caused on one of the following conditions:" +
                    "\n1. No row was selected from the table provided." +
                    "\n2. Inappropriate values were detected in the 'Approved On' text field", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewbkreq_Click(object sender, EventArgs e)
        {
            List<BKBRNotifs> a = new List<BKBRNotifs>();
            a = bc.LoadNotifs();
            notifdgv.DataSource = a;
        }

        private void viewbkexp_Click(object sender, EventArgs e)
        {
            List<BKBRNotifs> a = new List<BKBRNotifs>();
            a = bc.LoadBkExpNotif();
            notifdgv.DataSource = a;
        }

        private void notifdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (notifdgv.Rows.Count >= 0)
                {
                    DataGridViewRow row = this.notifdgv.Rows[e.RowIndex];
                    String notif = notifdgv.Rows[e.RowIndex].Cells["NotificationMsg"].Value.ToString();
                    String datepos = notifdgv.Rows[e.RowIndex].Cells["DatePosted"].Value.ToString();
                    String src = notifdgv.Rows[e.RowIndex].Cells["Source"].Value.ToString();
                    String title = bc.getAccNoIDFromNotifs(notif);
                    String uid = bc.getUID_IDFromNotifs(notif);
                    if (notif.StartsWith("The book being borrowed with the title "))
                    {
                        var ntf = MessageBox.Show("The following notification has the message:" + "\n\n" + bc.GetAndDisplayMsgNotif(notif).ToString() + "\n\nThis notification was posted on " + bc.GetAndDisplayTimestamp(notif) + ".", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (ntf == DialogResult.OK)
                        {
                        }
                    }
                    else if (notif.StartsWith("A member with the following UID"))
                    {
                        var ntf = MessageBox.Show("The following notification has the message:" + "\n\n" + bc.GetAndDisplayMsgNotif(notif).ToString() + "\n\nThis notification was posted on " + bc.GetAndDisplayTimestamp(notif) + ".", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (ntf == DialogResult.Yes)
                        {
                            bc.InsertApprovedBKBRFromKiosk(notif, title, uid);
                            UpdateBinding();

                        }
                        else if (ntf == DialogResult.No)
                        {
                        }
                    }

                }
            }
            catch (Exception) { }
        }
    }
}
