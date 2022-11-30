using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class SelectOrganization_Admin : Form
    {
        SQLProcessMemberInfoCommands memb = new SQLProcessMemberInfoCommands();
        public SelectOrganization_Admin()
        {
            InitializeComponent();
        }

        private void SelectOrganization_Admin_Load(object sender, EventArgs e)
        {
            UpdateBinding();
        }
        public void UpdateBinding()
        {
            List<GetOrgColumn> orc = new List<GetOrgColumn>();
            orc = memb.LoadOrgColumn();
            dgv_sel_org.DataSource = orc;
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            memb.CompareSameOrg(orginp.Text);
            UpdateBinding();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            memb.UpdateOrg(orginp.Text, orgid.Text);
            UpdateBinding();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            memb.DeleteOrg(orginp.Text, orgid.Text);
            UpdateBinding();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            delbtn.Enabled = false;
            updbtn.Enabled = false;
            orginp.Text = "";
            searchtxt.Text = "";
            orgid.Text = "[Org ID]";
        }

        private void setorg_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.memberorganization = orginp.Text;
            Properties.Settings.Default.Save();
            Admin_Member_Account_Management.orgTxt = Properties.Settings.Default.memberorganization;
            this.Close();
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            List<GetOrgColumn> or = new List<GetOrgColumn>();
            or = memb.SearchOrgCmb(searchtxt.Text);
            dgv_sel_org.DataSource = or;
        }

        private void dgv_sel_org_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_sel_org.Rows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_sel_org.Rows[e.RowIndex];
                    orginp.Text = row.Cells["SchoolOrOrganization"].Value.ToString();
                    orgid.Text = memb.getOrganizationID(orginp.Text);
                    delbtn.Enabled = true;
                    updbtn.Enabled = true;
                    Properties.Settings.Default.memberorganization = orginp.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception) { }
            }
        }
    }
}
