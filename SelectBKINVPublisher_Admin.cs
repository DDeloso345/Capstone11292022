using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class SelectBKINVPublisher_Admin : Form
    {

        SQLBookInventoryCommandsClass t = new SQLBookInventoryCommandsClass();
        List<getPublisherInfo> bmc = new List<getPublisherInfo>();
        public SelectBKINVPublisher_Admin()
        {
            InitializeComponent();
        }

        private void SelectBKINVPublisher_Admin_Load(object sender, EventArgs e)
        {
            UpdateBinding();
        }
        public void UpdateBinding()
        {
            bmc = t.LoadPublisher();
            dgv_sel_org.DataSource = bmc;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
            pubinp.Text = "";
            searchtxt.Text = "";
            orgid.Text = "[BKPUB ID]";

            delbtn.Enabled = false;
            updbtn.Enabled = false;
        }

        private void dgv_sel_org_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_sel_org.Rows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_sel_org.Rows[e.RowIndex];
                    pubinp.Text = row.Cells["Publisher"].Value.ToString();
                    orgid.Text = t.getPublisherID(pubinp.Text);
                    Properties.Settings.Default.bkinvpublisher = pubinp.Text;
                    Properties.Settings.Default.Save();

                    updbtn.Enabled = true;
                    delbtn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void setpub_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bkinvpublisher = pubinp.Text;
            Properties.Settings.Default.Save();
            Admin_BookInventory.Publisher = Properties.Settings.Default.bkinvpublisher;
            this.Close();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            t.CompareAndInsertPublisher(pubinp.Text);
            UpdateBinding();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            t.UpdatePublisher(pubinp.Text, orgid.Text);
            UpdateBinding();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            t.DeletePublisher(pubinp.Text, orgid.Text);
            UpdateBinding();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            bmc = t.SearchPublisher(searchtxt.Text);
            dgv_sel_org.DataSource = bmc;
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }
    }
}
