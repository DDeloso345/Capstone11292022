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
    public partial class BKBR_SelectBookInfo : Form
    {
        SQLBookBorrowingCommands bk = new SQLBookBorrowingCommands();
        List<getBookInfo> d = new List<getBookInfo>();
        public BKBR_SelectBookInfo()
        {
            InitializeComponent();
        }

        private void BKBR_SelectBookInfo_Admin_Load(object sender, EventArgs e)
        {
            UpdateBinding();
        }
        public void UpdateBinding() {
            d = bk.LoadBookInfo();
            dgv_bkbr.DataSource = d;
            crit_cmb.SelectedIndex = 0;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (crit_cmb.Text.Equals("AccessionNumber"))
            {
                d = bk.SearchBookInfo("AccessionNumber", searchtxt.Text);
                dgv_bkbr.DataSource = d;
            }
            else if (crit_cmb.Text.Equals("BookTitle"))
            {
                d = bk.SearchBookInfo("BookTitle", searchtxt.Text);
                dgv_bkbr.DataSource = d;
            }
            else if (crit_cmb.Text.Equals("BookAuthor")) {
                d = bk.SearchBookInfo("BookAuthor", searchtxt.Text);
                dgv_bkbr.DataSource = d;
            }
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            bkbr_accno.Text = "[Book's Accession Number]";
            bktitle.Text = "[Book Title]";
            bkbr_ui_details.Text = "[Book Author]";
            searchtxt.Text = "";
            UpdateBinding();
        }

        private void dgv_bkbr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bkbr.SelectedRows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_bkbr.Rows[e.RowIndex];
                    bkbr_accno.Text = row.Cells["AccessionNumber"].Value.ToString();
                    bktitle.Text = row.Cells["BookTitle"].Value.ToString();
                    bkbr_ui_details.Text = row.Cells["BookAuthor"].Value.ToString();

                    Properties.Settings.Default.bkbr_accno = bkbr_accno.Text;
                    Properties.Settings.Default.bkbr_bktitle = bktitle.Text;
                    Properties.Settings.Default.bkbr_aut = bkbr_ui_details.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception) { }
            }
        }

        private void dgv_bkbr_DoubleClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.bkbr_accno = bkbr_accno.Text;
            Properties.Settings.Default.bkbr_aut = bkbr_ui_details.Text;
            Properties.Settings.Default.bkbr_bktitle = bktitle.Text;
            Properties.Settings.Default.Save();

            Admin_BookBorrowing.AccessionNo = Properties.Settings.Default.bkbr_accno;
            Admin_BookBorrowing.BookTitle = Properties.Settings.Default.bkbr_bktitle;
            Admin_BookBorrowing.Author = Properties.Settings.Default.bkbr_aut;

            Staff_BookBorrowing.BookTitle = Properties.Settings.Default.bkbr_bktitle;
            Staff_BookBorrowing.AccessionNo = Properties.Settings.Default.bkbr_accno;
            Staff_BookBorrowing.Author = Properties.Settings.Default.bkbr_aut;

            this.Close();
            /*
            
            */
        }

        private void crit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void bkbr_accno_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bktitle_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bkbr_ui_details_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
