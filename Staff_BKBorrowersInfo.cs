using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Staff_BKBorrowersInfo : Form
    {
        List<BKBR_Ind_Rec> ind = new List<BKBR_Ind_Rec>();
        List<getBKBRColumn> bk = new List<getBKBRColumn>();
        List<ApprovedNotifs> app = new List<ApprovedNotifs>();
        SQLBKBorrowerInfoCommands br = new SQLBKBorrowerInfoCommands();
        public Staff_BKBorrowersInfo()
        {
            InitializeComponent();
        }

        private void Staff_BKBorrowersInfo_Load(object sender, EventArgs e)
        {
            ComboBoxSel();
            UpdateBinding();
        }
        public void UpdateBinding()
        {
            ind = br.LoadIndBKBRData_DGV(selmemb.Text);
            dgv_bkbr_ind.DataSource = ind;
        }
        public void ComboBoxSel()
        {
            app = br.LoadIndBKBR_Cmb();
            selmemb.DataSource = app;
            selmemb.DisplayMember = "COCPL_UID";

            cmb_crit.SelectedIndex = 0;
        }

        private void dgv_bkbr_ind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_bkbr_ind.SelectedRows.Count >= 0)
                {
                    DataGridViewRow row = this.dgv_bkbr_ind.Rows[e.RowIndex];
                    String id = row.Cells["ID"].Value.ToString();
                    String bkt = row.Cells["BookTitle"].Value.ToString();
                    String acc = row.Cells["AccessionNumber"].Value.ToString();
                    String aut = row.Cells["BookAuthor"].Value.ToString();
                    String duedt = row.Cells["DueDate"].Value.ToString();
                    String dtb = row.Cells["Date_Borrowed"].Value.ToString();
                    String appby = row.Cells["EmpUsername"].Value.ToString();
                    String appon = row.Cells["ApprovedOn"].Value.ToString();

                    var del = MessageBox.Show("This particular book borrowing record of Mr./Ms. " + nametxt.Text + " who has the UID " + uidtxt.Text
                    + "\n and has the record id " + id + "has the following information attached below:\n\n"
                    + "\nBook Title: " + bkt
                    + "\nAccession Number: " + acc
                    + "\nBook Author: " + aut
                    + "\nDate Borrowed: " + dtb
                    + "\nDue Date: " + duedt
                    + "\nApproved By: " + appby
                    + "\nApproved On: " + appon
                    , "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            if (cmb_crit.Text.Equals("BookTitle"))
            {
                ind = br.SearchIndDetails(uidtxt.Text, "BookTitle", searchinp.Text);
                dgv_bkbr_ind.DataSource = ind;
            }
            else if (cmb_crit.Text.Equals("AccessionNumber"))
            {
                ind = br.SearchIndDetails(uidtxt.Text, "AccessionNumber", searchinp.Text);
                dgv_bkbr_ind.DataSource = ind;
            }
            else if (cmb_crit.Text.Equals("BookAuthor"))
            {

                ind = br.SearchIndDetails(uidtxt.Text, "BookAuthor", searchinp.Text);
                dgv_bkbr_ind.DataSource = ind;
            }
            else if (cmb_crit.Text.Equals("DateBorrowed"))
            {
                String a = "Date_Borrowed";
                ind = br.SearchIndDetails(uidtxt.Text, a, searchinp.Text.Replace("/", "-"));
                dgv_bkbr_ind.DataSource = ind;
            }
            else if (cmb_crit.Text.Equals("DueDate"))
            {
                ind = br.SearchIndDetails(uidtxt.Text, "DueDate", searchinp.Text.Replace("/", "-"));
                dgv_bkbr_ind.DataSource = ind;
            }
            else if (cmb_crit.Text.Equals("ApprovedBy"))
            {
                ind = br.SearchIndDetails(uidtxt.Text, "ApprovedBy", searchinp.Text);
                dgv_bkbr_ind.DataSource = ind;
            }
            else if (cmb_crit.Text.Equals("ApprovedOn"))
            {
                ind = br.SearchApprovedOn(uidtxt.Text, searchinp.Text);
                dgv_bkbr_ind.DataSource = ind;
            }
        }

        private void selmemb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
            uidtxt.Text = selmemb.Text;
            if (br.getSuffix(selmemb.Text).Equals("N/A"))
            {
                nametxt.Text = br.getFullName(selmemb.Text) + " " + br.getSuffix(selmemb.Text).Replace("N/A", "");
            }
            else
            {
                nametxt.Text = br.getFullName(selmemb.Text) + " " + br.getSuffix(selmemb.Text);
            }
            if (cmb_crit.Text.Equals("Date_Borrowed"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (cmb_crit.Text.Equals("DueDate"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmb_crit.Text.Equals("ApprovedOn"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_crit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_crit.Text.Equals("DateBorrowed"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmb_crit.Text.Equals("DueDate"))
            {
                MessageBox.Show("When searching for a particular date on this criteria, please follow the format below on your search keywords:" +
                    "\n\n(yyyy-mm-dd) or (yyyy/mm/dd)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmb_crit.Text.Equals("ApprovedOn"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }
    }
}
