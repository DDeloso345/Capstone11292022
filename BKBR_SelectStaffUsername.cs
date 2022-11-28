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
    public partial class BKBR_SelectStaffUsername : Form
    {
        SQLBookBorrowingCommands bk = new SQLBookBorrowingCommands();
        List<getEmpInfo> d = new List<getEmpInfo>();
        public BKBR_SelectStaffUsername()
        {
            InitializeComponent();
        }

        private void BKBR_SelectStaffUsername_Admin_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            crit_cmb.SelectedIndex = 0;
        }
        public void UpdateBinding()
        {
            d = bk.LoadStaffInfo();
            dgv_bkbr.DataSource = d;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (crit_cmb.Text.Equals("Staff_Name")) {
                d = bk.SearchStaffInfo("Staff_Name", searchtxt.Text);
                dgv_bkbr.DataSource = d;
            }
            else if(crit_cmb.Text.Equals("Username")) {
                d = bk.SearchStaffInfo("Username", searchtxt.Text);
                dgv_bkbr.DataSource = d;
            }
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void dgv_bkbr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bkbr.SelectedRows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_bkbr.Rows[e.RowIndex];
                    bkbr_staffname.Text = row.Cells["Staff_Name"].Value.ToString();
                    un.Text = row.Cells["Username"].Value.ToString();

                    Properties.Settings.Default.bkbr_username = un.Text;
                    Properties.Settings.Default.bkbr_staffname = bkbr_staffname.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception) { }
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            bkbr_staffname.Text = "[STAFF NAME]";
            un.Text = "[USERNAME]";
            searchtxt.Text = "";
            UpdateBinding();
        }

        private void dgv_bkbr_DoubleClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.bkbr_staffname = bkbr_staffname.Text;
            Properties.Settings.Default.bkbr_username = un.Text;
            Properties.Settings.Default.Save();

            Admin_BookBorrowing.ApprovedBy = Properties.Settings.Default.bkbr_staffname;
            Admin_BookBorrowing.StaffUsername = Properties.Settings.Default.bkbr_username;

            Staff_BookBorrowing.ApprovedBy = Properties.Settings.Default.bkbr_staffname;
            Staff_BookBorrowing.StaffUsername = Properties.Settings.Default.bkbr_username;

            Admin_BookReturns.NotedBy = Properties.Settings.Default.bkbr_staffname;
            Admin_BookReturns.StaffUsername = Properties.Settings.Default.bkbr_username;

            Staff_BookReturns.NotedBy = Properties.Settings.Default.bkbr_staffname;
            Staff_BookReturns.StaffUsername = Properties.Settings.Default.bkbr_username;

            this.Close();
        }

        private void crit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
        }
    }
}
