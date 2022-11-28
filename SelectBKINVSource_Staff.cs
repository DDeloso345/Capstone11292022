﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class SelectBKINVSource_Staff : Form
    {
        SQLBookInventoryCommandsClass t = new SQLBookInventoryCommandsClass();
        List<getSpecSourceInfo> bmc = new List<getSpecSourceInfo>();
        public SelectBKINVSource_Staff()
        {
            InitializeComponent();
        }

        private void SelectBKINVSource_Staff_Load(object sender, EventArgs e)
        {
            UpdateBinding();
        }
        public void UpdateBinding()
        {
            bmc = t.LoadSource();
            dgv_sel_org.DataSource = bmc;
        }

        private void dgv_sel_org_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    updbtn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
            srcinp.Text = "";
            searchtxt.Text = "";
            srcid.Text = "[BKSRC ID]";

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

                    updbtn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void setsrc_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bkinvsource = srcinp.Text;
            Properties.Settings.Default.Save();
            Staff_BookInventory.BookSource = Properties.Settings.Default.bkinvsource;
            this.Close();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            t.UpdateSource(srcinp.Text, srcid.Text);
            UpdateBinding();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            t.CompareAndInsertSource(srcinp.Text);
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
    }
}
