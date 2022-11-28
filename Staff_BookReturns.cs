using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Staff_BookReturns : Form
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
        public Staff_BookReturns()
        {
            InitializeComponent();
        }

        private void Staff_BookReturns_Load(object sender, System.EventArgs e)
        {
            UpdateBinding();
            ComboBoxSel();
        }
        public void UpdateBinding()
        {
            br = sql.LoadBookReturnsData();
            dgv_bookreturns.DataSource = br;
        }
        public void ComboBoxSel()
        {
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
        public void clear()
        {
            brrid.Text = "[ID Txt]";
            bkbr_id.Text = "[ID]";
            un_id.Text = "[ID]";
            bkret_remarks_cmb_id.Text = sql.getBKRetRem_id(bkret_remarks_cmb.Text);
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

        private void sel_staff_Click(object sender, EventArgs e)
        {

        }

        private void bkret_remarks_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_bkbrinfo_Click(object sender, EventArgs e)
        {

        }

        private void refbtn_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {

        }

        private void cmbcriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_bookreturns_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selpaid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
