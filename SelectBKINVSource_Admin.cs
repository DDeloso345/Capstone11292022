using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class SelectBKINVSource_Admin : Form
    {
        SQLBookInventoryCommandsClass t = new SQLBookInventoryCommandsClass();
        List<getSpecSourceInfo> bmc = new List<getSpecSourceInfo>();
        public SelectBKINVSource_Admin()
        {
            InitializeComponent();
        }

        private void SelectBKINVSource_Admin_Load(object sender, EventArgs e)
        {
            UpdateBinding();
        }
        public void UpdateBinding()
        {
            bmc = t.LoadSource();
            dgv_sel_org.DataSource = bmc;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
            srcinp.Text = "";
            searchtxt.Text = "";
            srcid.Text = "[BKSRC ID]";

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
                    srcinp.Text = row.Cells["SpecificSource"].Value.ToString();
                    Properties.Settings.Default.bkinvsource = srcinp.Text;
                    srcid.Text = t.getSourceID(srcinp.Text);
                    Properties.Settings.Default.Save();

                    delbtn.Enabled = true;
                    updbtn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void setsrc_Click(object sender, EventArgs e)
        {
            
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            t.CompareAndInsertSource(srcinp.Text);
            UpdateBinding();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            t.UpdateSource(srcinp.Text, srcid.Text);
            UpdateBinding();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            t.DeleteSource(srcinp.Text, srcid.Text);
            UpdateBinding();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            bmc = t.SearchSource(searchtxt.Text);
            dgv_sel_org.DataSource = bmc;
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void dgv_sel_org_DoubleClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.bkinvsource = srcinp.Text;
            Properties.Settings.Default.Save();
            Admin_BookInventory.BookSource = Properties.Settings.Default.bkinvsource;
            this.Close();
        }
    }
}
