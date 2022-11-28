using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Admin_BookReturns : Form
    {
        public static String BKBR_ID = "";
        public static String UID = "";
        public static String BookTitle = "";
        public static String AccNo = "";
        public static String Author = "";
        public static String DateBorrowed = "";
        public static String DueDate = "";
        public static String NotedBy = "";
        public static String StaffUsername = "";

        List<BookReturnsInfo> br = new List<BookReturnsInfo>();
        List<getBRColumn> c = new List<getBRColumn>();
        SQLBookReturnsCommands sql = new SQLBookReturnsCommands();
        SQLBookBorrowingCommands b = new SQLBookBorrowingCommands();
        public Admin_BookReturns()
        {
            InitializeComponent();
        }

        private void Admin_BookReturns_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            ComboBoxSel();  
        }
        public void UpdateBinding() {
            br = sql.LoadBookReturnsData();
            dgv_bookreturns.DataSource = br;
        }
        public void ComboBoxSel() {
            c = sql.LoadSearchCriteria();
            cmbcriteria.DataSource = c;
            cmbcriteria.DisplayMember = "name";

            c = sql.LoadisPaid();
            selpaid.DataSource = c;
            selpaid.DisplayMember = "isPaid";
            selpaid.SelectedIndex = 0;

            c = sql.LoadBKReturnsRemarks();
            bkret_remarks_cmb.DataSource = c;
            bkret_remarks_cmb.DisplayMember = "BKReturnsRemarks";
            bkret_remarks_cmb.SelectedIndex = 0;
        }
        public void clear() {
            brrid.Text = "[ID Txt]";
            bkbr_id.Text = "[ID]";
            un_id.Text = "[ID]";
            bkret_remarks_cmb_id.Text = sql.getBKRetRem_id(bkret_remarks_cmb.Text) ;
            paid_id.Text = sql.get_isPaid_id(selpaid.Text);
            uid.Text = "";
            bktitle.Text = "";
            accno.Text = "";
            bkaut.Text = "";
            empname.Text = "";
            un.Text = "";
            bkremarks.Text = "";
            returnedon.Text = "";
            finestxt.Text = "";

            updbtn.Enabled = false;
            delbtn.Enabled = false;
            btn_bkbrinfo.Enabled = true;
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (cmbcriteria.Text.Equals("id")) {
                br = sql.SearchBookReturnsData("id", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("COCPL_UID")) {
                br = sql.SearchBookReturnsData("COCPL_UID", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("BookTitle")) {
                br = sql.SearchBookReturnsData("BookTitle", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("AccessionNumber")) {
                br = sql.SearchBookReturnsData("AccessionNumber", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("BookAuthor")) {
                br = sql.SearchBookReturnsData("BookAuthor", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("Date_Borrowed")) {
                br = sql.SearchBookReturnsData("Date_Borrowed", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("DueDate")) {
                br = sql.SearchBookReturnsData("DueDate", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("BookRemarksAndConditions")) {
                br = sql.SearchBookReturnsData("BookRemarksAndConditions", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("BKReturnsRemarks")) {
                br = sql.SearchBookReturnsData("BKReturnsRemarks", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("ImposedFines")) {
                br = sql.SearchBookReturnsData("ImposedFines", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("FinesPaymentStatus")) {
                br = sql.SearchBookReturnsData("FinesPaymentStatus", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("NotedBy")) {
                br = sql.SearchBookReturnsData("NotedBy", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("EmpUsername")) {
                br = sql.SearchBookReturnsData("EmpUsername", searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
            else if (cmbcriteria.Text.Equals("ReturnedOn")) {
                br = sql.SearchBookReturnsDataReturnedOn(searchinp.Text);
                dgv_bookreturns.DataSource = br;
            }
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (uid.Text.Length == 0 || bktitle.Text.Length == 0 ||
               accno.Text.Length == 0 || bkaut.Text.Length == 0 ||
               bkremarks.Text.Length == 0 || finestxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left empty.\nPlease enter or select valid choices from the options provided.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                var d = MessageBox.Show("You CANNOT update the information of the returned book within the 'Information of Book to be returned' section" +
                "'\non the 'Book Returns' user interface after proceeding to insert this record." +
                "\n\nDo you wish to continue adding this record to the system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes) {
                    var dlg = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to insert the specified record.\n\n"
                + "\nCOCPL UID: " + uid.Text
                + "\nBook Title: " + bktitle.Text
                + "\nAccession No.: " + accno.Text
                + "\nAuthor: " + bkaut.Text
                + "\nDate Borrowed: " + dtborrowed.Value.ToShortDateString()
                + "\nDue Date: " + duedt.Value.ToShortDateString()
                + "\nNoted By: " + empname.Text
                + "\nStaff Username: " + un.Text
                + "\nBook Remarks: " + bkremarks.Text
                + "\nReturned On: " + returnedon.Text
                + "\nBook Returns Remarks: " + bkret_remarks_cmb.Text
                + "\nImposed Fines (in Php): " + finestxt.Text
                + "\nPayment Status: " + selpaid.Text + "\n\nAre the following information correct?", "Confirmation for adding book returns record entries", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dlg == DialogResult.Yes)
                    {
                        sql.InsertBKReturnsRecords(bkbr_id.Text, bkremarks.Text, bkret_remarks_cmb_id.Text, finestxt.Text, paid_id.Text);
                        UpdateBinding();
                        clear();
                    }
                }
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            try {
                if (uid.Text.Length == 0 || bktitle.Text.Length == 0 ||
                accno.Text.Length == 0 || bkaut.Text.Length == 0 ||
                empname.Text.Length == 0 || un.Text.Length == 0 ||
                bkremarks.Text.Length == 0 || returnedon.Text.Length == 0 ||
                finestxt.Text.Length == 0)
                {
                    MessageBox.Show("One or more of the fields have been left empty.\nPlease enter or select valid choices from the options provided.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    var dlg = MessageBox.Show("Please double-check the following information before proceeding to update the specified record.\n\n"
                    + "\nBook Returns Record ID:" + brrid.Text
                    + "\nCOCPL UID: " + uid.Text
                    + "\nBook Title: " + bktitle.Text
                    + "\nAccession No.: " + accno.Text
                    + "\nAuthor: " + bkaut.Text
                    + "\nDate Borrowed: " + dtborrowed.Value.ToShortDateString()
                    + "\nDue Date: " + duedt.Value.ToShortDateString()
                    + "\nNoted By: " + empname.Text
                    + "\nStaff Username: " + un.Text
                    + "\nBook Remarks: " + bkremarks.Text
                    + "\nReturned On: " + returnedon.Text
                    + "\nBook Returns Remarks: " + bkret_remarks_cmb_id.Text
                    + "\nImposed Fines (in Php): " + finestxt.Text
                    + "\nPayment Status: " + selpaid.Text
                    + "\n\nDo you wish to proceed in updating this record with the following values?", "Confirmation for updating book returns record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dlg == DialogResult.Yes) {
                        sql.UpdateBKReturnsRecords(brrid.Text, bkbr_id.Text, un_id.Text, bkremarks.Text, bkret_remarks_cmb_id.Text, finestxt.Text, paid_id.Text, Convert.ToDateTime(returnedon.Text));
                        UpdateBinding();
                        clear();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("The following error might be caused on one of the following conditions:" +
              "\n1. No row was selected from the table provided." +
              "\n2. Inappropriate values were detected in the 'Returned On' text field" +
              "\n3. A valid selection has not been made in the Information of Book to be Returned and/or Staff Authorization sections.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            sql.DeleteBKReturnsRecords(brrid.Text);
            UpdateBinding();
            clear();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            clear();
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
            else if (cmbcriteria.Text.Equals("ReturnedOn"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_bookreturns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bkr_timer.Enabled = false;
            try {
                if (dgv_bookreturns.SelectedRows.Count >= 0) {

                    DataGridViewRow row = this.dgv_bookreturns.Rows[e.RowIndex];
                    brrid.Text = row.Cells["ID"].Value.ToString();
                    uid.Text = row.Cells["COCPL_UID"].Value.ToString();
                    bktitle.Text = row.Cells["BookTitle"].Value.ToString();
                    accno.Text = row.Cells["AccessionNumber"].Value.ToString();
                    bkaut.Text = row.Cells["BookAuthor"].Value.ToString();
                    dtborrowed.Text = row.Cells["Date_Borrowed"].Value.ToString();
                    duedt.Text = row.Cells["DueDate"].Value.ToString();
                    empname.Text = row.Cells["NotedBy"].Value.ToString();
                    un.Text = row.Cells["Staff_Username"].Value.ToString();
                    bkremarks.Text = row.Cells["BookRemarksAndConditions"].Value.ToString();
                    returnedon.Text = row.Cells["ReturnedOn"].Value.ToString();
                    bkret_remarks_cmb.Text = row.Cells["BKReturnsRemarks"].Value.ToString();
                    finestxt.Text = row.Cells["ImposedFines"].Value.ToString();
                    selpaid.Text = row.Cells["FinesPaymentStatus"].Value.ToString();

                    bkbr_id.Text = "[UNAVAILABLE]";
                    un_id.Text = sql.get_Username_id(un.Text);
                    bkret_remarks_cmb_id.Text = sql.getBKRetRem_id(bkret_remarks_cmb.Text);
                    paid_id.Text = sql.get_isPaid_id(selpaid.Text);

                    btn_bkbrinfo.Enabled = false;

                    updbtn.Enabled = true;
                    delbtn.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        private void bkr_timer_Tick(object sender, EventArgs e)
        {
            SQLBookBorrowingCommands u = new SQLBookBorrowingCommands();
            SQLBookReturnsCommands bkr = new SQLBookReturnsCommands();

            if (BKBR_ID.Length == 0 && UID.Length == 0 && BookTitle.Length == 0 && AccNo.Length == 0 && Author.Length == 0 && DateBorrowed.Length == 0 && DueDate.Length == 0) { }
            else if (BKBR_ID.Length > 0 && UID.Length > 0 && BookTitle.Length > 0 && AccNo.Length > 0 && Author.Length > 0 && DateBorrowed.Length > 0 && DueDate.Length > 0) {
                bkbr_id.Text = BKBR_ID;
                uid.Text = UID;
                bktitle.Text = BookTitle;
                accno.Text = AccNo;
                bkaut.Text = Author;
                dtborrowed.Text = DateBorrowed;
                duedt.Text = DueDate;
                if (bkbr_id.Text.Length == 0) {
                    bkbr_id.Text = "[ID]";
                }
                bkr_timer.Start();
            }

            if (NotedBy.Length == 0 && StaffUsername.Length == 0) { }
            else if (NotedBy.Length > 0 && StaffUsername.Length > 0)
            {
                empname.Text = NotedBy;
                un.Text = StaffUsername;
                un_id.Text = u.getEmployeeID(un.Text);
                if (un_id.Text.Length == 0) { 
                    un_id.Text = "[ID]";
                    bkr_timer.Start();
                }
            }
        }

        private void sel_staff_Click(object sender, EventArgs e)
        {
            bkr_timer.Start();
            BKBR_SelectStaffUsername b = new BKBR_SelectStaffUsername();
            b.Show();
        }

        private void btn_bkbrinfo_Click(object sender, EventArgs e)
        {
            bkr_timer.Start();
            BKR_SelectBKBR_Info b = new BKR_SelectBKBR_Info();
            b.Show();
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void finestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;
            int keyvalue = (int)e.KeyChar;
            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            e.Handled = true;
        }

        private void bkret_remarks_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bkret_remarks_cmb_id.Text = sql.getBKRetRem_id(bkret_remarks_cmb.Text);
        }

        private void selpaid_SelectedIndexChanged(object sender, EventArgs e)
        {
           paid_id.Text = sql.get_isPaid_id(selpaid.Text);
        }
    }
}
