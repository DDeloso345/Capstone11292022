using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class BKR_SelectBKBR_Info : Form
    {
        List<getBKBR_Ref_Info> g = new List<getBKBR_Ref_Info>();
        SQLBookReturnsCommands br = new SQLBookReturnsCommands();
        List<getBRColumn> c = new List<getBRColumn>();
        public BKR_SelectBKBR_Info()
        {
            InitializeComponent();
        }

        private void BKR_SelectBKBR_Info_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            ComboBoxSel();
        }
        public void UpdateBinding() {
            g = br.LoadSelectBKBR_Ref_Info();
            dgv_bkr.DataSource = g;
        }
        public void ComboBoxSel() {
            c = br.LoadSearchCmb_BKBR_RefInfo();
            crit_cmb.DataSource = c;
            crit_cmb.DisplayMember = "name";
            crit_cmb.SelectedIndex = 0;
        }
        public void clear() {
            searchtxt.Text = "";
            bkbr_ref_id.Text = "[ID]";
            uid.Text = "[COCPLM UID]";
            accno.Text = "[Book's Accession Number]";
            bktitle.Text = "[Book Title]";
            bkaut.Text = "[Book Author]";
        }

        private void dgv_bkr_Click(object sender, EventArgs e)
        {
            try { }
            catch (Exception) { }
        }

        private void dgv_bkr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (dgv_bkr.SelectedRows.Count >= 0) {
                    DataGridViewRow row = this.dgv_bkr.Rows[e.RowIndex];
                    bkbr_ref_id.Text = row.Cells["ID"].Value.ToString();
                    uid.Text = row.Cells["COCPL_UID"].Value.ToString();
                    bktitle.Text = row.Cells["BookTitle"].Value.ToString();
                    accno.Text = row.Cells["AccessionNumber"].Value.ToString();
                    bkaut.Text = row.Cells["BookAuthor"].Value.ToString();
                    dtborrowed.Text = row.Cells["Date_Borrowed"].Value.ToString();
                    duedt.Text = row.Cells["DueDate"].Value.ToString();

                    Properties.Settings.Default.br_bkbr_id = bkbr_ref_id.Text;
                    Properties.Settings.Default.br_uid = uid.Text;
                    Properties.Settings.Default.br_bktitle = bktitle.Text;
                    Properties.Settings.Default.br_accno = accno.Text;
                    Properties.Settings.Default.br_author = bkaut.Text;
                    Properties.Settings.Default.br_dtbr = dtborrowed.Text;
                    Properties.Settings.Default.br_duedt = duedt.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception) { }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (crit_cmb.Text.Equals("id")) {
                g = br.SearchBKBR_Ref_Info("id",searchtxt.Text);
                dgv_bkr.DataSource = g;
            }
            else if (crit_cmb.Text.Equals("COCPL_UID")) { 
                g = br.SearchBKBR_Ref_Info("COCPL_UID", searchtxt.Text);
                dgv_bkr.DataSource = g;
            }
            else if (crit_cmb.Text.Equals("BookTitle")) {
                g = br.SearchBKBR_Ref_Info("BookTitle", searchtxt.Text);
                dgv_bkr.DataSource = g;
            }
            else if (crit_cmb.Text.Equals("AccessionNumber")) {
                g = br.SearchBKBR_Ref_Info("AccessionNumber", searchtxt.Text);
                dgv_bkr.DataSource = g;
            }
            else if (crit_cmb.Text.Equals("BookAuthor")) {
                g = br.SearchBKBR_Ref_Info("BookAuthor", searchtxt.Text);
                dgv_bkr.DataSource = g;
            }
            else if (crit_cmb.Text.Equals("Date_Borrowed")) {
                g = br.SearchBKBR_Ref_Info("Date_Borrowed", searchtxt.Text.Replace("/", "-"));
                dgv_bkr.DataSource = g;
            }
            else if (crit_cmb.Text.Equals("DueDate")) {
                g = br.SearchBKBR_Ref_Info("DueDate", searchtxt.Text.Replace("/", "-"));
                dgv_bkr.DataSource = g;
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_bkr_DoubleClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.br_bkbr_id = bkbr_ref_id.Text;
            Properties.Settings.Default.br_uid = uid.Text;
            Properties.Settings.Default.br_bktitle = bktitle.Text;
            Properties.Settings.Default.br_accno = accno.Text;
            Properties.Settings.Default.br_author = bkaut.Text;
            Properties.Settings.Default.br_dtbr = dtborrowed.Text;
            Properties.Settings.Default.br_duedt = duedt.Text;
            Properties.Settings.Default.Save();

            Admin_BookReturns.BKBR_ID = Properties.Settings.Default.br_bkbr_id;
            Admin_BookReturns.UID = Properties.Settings.Default.br_uid;
            Admin_BookReturns.BookTitle = Properties.Settings.Default.br_bktitle;
            Admin_BookReturns.AccNo = Properties.Settings.Default.br_accno;
            Admin_BookReturns.Author = Properties.Settings.Default.br_author;
            Admin_BookReturns.DateBorrowed = Properties.Settings.Default.br_dtbr;
            Admin_BookReturns.DueDate = Properties.Settings.Default.br_duedt;

            Staff_BookReturns.BKBR_ID = Properties.Settings.Default.br_bkbr_id;
            Staff_BookReturns.UID = Properties.Settings.Default.br_uid;
            Staff_BookReturns.BookTitle = Properties.Settings.Default.br_bktitle;
            Staff_BookReturns.AccNo = Properties.Settings.Default.br_accno;
            Staff_BookReturns.Author = Properties.Settings.Default.br_author;
            Staff_BookReturns.DateBorrowed = Properties.Settings.Default.br_dtbr;
            Staff_BookReturns.DueDate = Properties.Settings.Default.br_duedt;

            this.Close();
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void crit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
            if (crit_cmb.Text.Equals("Date_Borrowed"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (crit_cmb.Text.Equals("DueDate"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
