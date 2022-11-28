using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class SelectOrganization_Staff : Form
    {
        SQLProcessMemberInfoCommands memb = new SQLProcessMemberInfoCommands();
        public SelectOrganization_Staff()
        {
            InitializeComponent();
        }

        private void SelectOrganization_Staff_Load(object sender, EventArgs e)
        {
            UpdateBinding();
        }
        public void UpdateBinding()
        {
            List<GetOrgColumn> orc = new List<GetOrgColumn>();
            orc = memb.LoadOrgColumn();
            dgv_sel_org.DataSource = orc;
        }

        private void setorg_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.memberorganization = orginp.Text;
            Properties.Settings.Default.Save();
            Staff_Member_Account_Management.orgTxt = Properties.Settings.Default.memberorganization;
            this.Close();
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

        private void clearbtn_Click(object sender, EventArgs e)
        {
            orginp.Text = "";
            orgid.Text = "[Org ID]";
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

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            orginp.Text = "";
            searchtxt.Text = "";
            updbtn.Enabled = false;
            orgid.Text = "[Org ID]";
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
                    updbtn.Enabled = true;
                    Properties.Settings.Default.memberorganization = orginp.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception) { }
            }
        }
    }
}
