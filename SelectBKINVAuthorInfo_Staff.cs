using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class SelectBKINVAuthorInfo_Staff : Form
    {

        SQLBookInventoryCommandsClass t = new SQLBookInventoryCommandsClass();
        List<getAuthorInfo> bmc = new List<getAuthorInfo>();
        public SelectBKINVAuthorInfo_Staff()
        {
            InitializeComponent();
        }

        private void SelectBKINVAuthorInfo_Staff_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            crit_cmb.SelectedIndex = 0;
        }
        public void UpdateBinding()
        {
            bmc = t.LoadAuthorInfo();
            dgv_sel_org.DataSource = bmc;
        }

        private void setaut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bkinvauthorno = autnotxt.Text;
            Properties.Settings.Default.bkinvbkauthor = auttxt.Text;
            Properties.Settings.Default.Save();
            Staff_BookInventory.AuthorNo = Properties.Settings.Default.bkinvauthorno;
            Staff_BookInventory.Author = Properties.Settings.Default.bkinvbkauthor;
            this.Close();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
            auttxt.Text = "";
            autnotxt.Text = "";
            orgid.Text = "[AUT ID]";

            updbtn.Enabled = false;
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            List<getBKInvColumns> bi = new List<getBKInvColumns>();
            bi = t.CompareAndInsertAuth(auttxt.Text, autnotxt.Text);
            UpdateBinding();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            List<getBKInvColumns> bi = new List<getBKInvColumns>();
            t.UpdateAuth(auttxt.Text, autnotxt.Text, orgid.Text);
            UpdateBinding();
        }

        private void dgv_sel_org_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_sel_org.Rows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_sel_org.Rows[e.RowIndex];
                    auttxt.Text = row.Cells["BookAuthor"].Value.ToString();
                    autnotxt.Text = row.Cells["AuthorNo"].Value.ToString();
                    orgid.Text = t.getAuthorNoID(autnotxt.Text);
                    Properties.Settings.Default.bkinvauthorno = autnotxt.Text;
                    Properties.Settings.Default.bkinvbkauthor = auttxt.Text;
                    Properties.Settings.Default.Save();

                    updbtn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (crit_cmb.Text.Equals("BookAuthor"))
            {
                bmc = t.SearchAuthorInfo("BookAuthor", searchtxt.Text);
                dgv_sel_org.DataSource = bmc;
            }
            else if (crit_cmb.Text.Equals("AuthorNo"))
            {
                bmc = t.SearchAuthorInfo("AuthorNo", searchtxt.Text);
                dgv_sel_org.DataSource = bmc;
            }
        }

        private void crit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }
    }
}
