using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Admin_BKBR_ApprovedNotifs : Form
    {
        SQLBookBorrowingCommands bc = new SQLBookBorrowingCommands();
        List<ApprovedNotifs> app = new List<ApprovedNotifs>();
        public Admin_BKBR_ApprovedNotifs()
        {
            InitializeComponent();
        }

        private void Admin_BKBR_ApprovedNotifs_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            ComboBoxSel();
        }
        public void UpdateBinding()
        {
            app = bc.LoadApprovedNotifs();
            dgv_approvednotifs.DataSource = app;
        }
        public void ComboBoxSel()
        {
            List<getBKBRColumn> brc = new List<getBKBRColumn>();
            brc = bc.LoadApprovedNotifsCriteria();
            cmb_crit.DataSource = brc;
            cmb_crit.DisplayMember = "name";

            cmb_crit.SelectedIndex = 0;
        }
        private void dgv_approvednotifs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_approvednotifs.Rows.Count >= 0)
                {
                    DataGridViewRow row = this.dgv_approvednotifs.Rows[e.RowIndex];
                    String notif = dgv_approvednotifs.Rows[e.RowIndex].Cells["NotificationMsg"].Value.ToString();
                    String datepos = dgv_approvednotifs.Rows[e.RowIndex].Cells["DatePosted"].Value.ToString();
                    String dateapp = dgv_approvednotifs.Rows[e.RowIndex].Cells["DateApproved"].Value.ToString();
                    String title = dgv_approvednotifs.Rows[e.RowIndex].Cells["BookTitle"].Value.ToString();
                    String uid = dgv_approvednotifs.Rows[e.RowIndex].Cells["COCPL_UID"].Value.ToString();
                    String src = dgv_approvednotifs.Rows[e.RowIndex].Cells["Source"].Value.ToString();
                    var del = MessageBox.Show("The following notification has the message:" + "\n\n" + bc.GetAndDisplayMsgApprovedNotif(notif).ToString() + "\n\nWould you like to delete this notification?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (bc.GetAndDisplayMsgApprovedNotif(notif).StartsWith("A member with the following UID"))
                    {
                        if (del == DialogResult.Yes)
                        {
                            bc.DeleteApprovedRequests(notif);
                            UpdateBinding();
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchinp_TextChanged(object sender, EventArgs e)
        {

        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            if (cmb_crit.Text.Equals("id"))
            {
                app = bc.SearchApprovedBookBorrowingRecords("id", searchinp.Text);
                dgv_approvednotifs.DataSource = app;
            }
            else if (cmb_crit.Text.Equals("NotificationMsg"))
            {
                app = bc.SearchApprovedBookBorrowingRecords("NotificationMsg", searchinp.Text);
                dgv_approvednotifs.DataSource = app;
            }
            else if (cmb_crit.Text.Equals("DatePosted"))
            {
                if (searchinp.Text.StartsWith("0"))
                {
                    app = bc.SearchApprovedBookBorrowingRecordsDA("DatePosted", searchinp.Text.Replace("0", ""));
                    dgv_approvednotifs.DataSource = app;
                }
                else
                {
                    app = bc.SearchApprovedBookBorrowingRecordsDA("DatePosted", searchinp.Text);
                    dgv_approvednotifs.DataSource = app;
                }
            }
            else if (cmb_crit.Text.Equals("DateApproved"))
            {
                if (searchinp.Text.StartsWith("0"))
                {
                    app = bc.SearchApprovedBookBorrowingRecordsDA("DateApproved", searchinp.Text.Replace("0", ""));
                    dgv_approvednotifs.DataSource = app;
                }
                else
                {
                    app = bc.SearchApprovedBookBorrowingRecordsDA("DateApproved", searchinp.Text);
                    dgv_approvednotifs.DataSource = app;
                }
            }
            else if (cmb_crit.Text.Equals("BookTitle"))
            {
                app = bc.SearchApprovedBookBorrowingRecords("BookTitle", searchinp.Text);
                dgv_approvednotifs.DataSource = app;
            }
            else if (cmb_crit.Text.Equals("COCPL_UID"))
            {
                app = bc.SearchApprovedBookBorrowingRecords("COCPL_UID", searchinp.Text);
                dgv_approvednotifs.DataSource = app;
            }
            else if (cmb_crit.Text.Equals("Source"))
            {
                app = bc.SearchApprovedBookBorrowingRecords("Source", searchinp.Text);
                dgv_approvednotifs.DataSource = app;
            }
        }

        private void cmb_crit_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
            if (cmb_crit.Text.Equals("DatePosted"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmb_crit.Text.Equals("DateApproved"))
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
