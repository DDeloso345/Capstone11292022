using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class ORHistoryStaff : Form
    {

        List<ORHistoryClass> ohc = new List<ORHistoryClass>();
        SQLIDPreviewCommandsClass acc_cmd = new SQLIDPreviewCommandsClass();
        SQLCommandsModifyORHistory sql = new SQLCommandsModifyORHistory();
        List<ORHColumnName> or = new List<ORHColumnName>();
        public ORHistoryStaff()
        {
            InitializeComponent();
        }

        private void ORHistoryStaff_Load(object sender, EventArgs e)
        {
            ComboBoxSel();
            cmbfilter.SelectedIndex = 0;
            UpdateBinding();
        }
        public void ComboBoxSel()
        {
            or = sql.getColumns();
            cmbfilter.DataSource = or;
            cmbfilter.DisplayMember = "name";
        }
        public void UpdateBinding()
        {
            ohc = acc_cmd.Display();
            try
            {
                dgv_or_history.DataSource = ohc;
            }
            catch (Exception)
            {
                MessageBox.Show("The following window is unavailable due to having mismatched data.\nPlease try again later.");
                this.Hide();
            }
        }
        public void clear()
        {
            update_btn.Enabled = false;
            idlbl.Text = "[ID Txt]";
            uidlbl.Text = "[UID Txt]";
            orreceived.Text = "";
            ornumbtxt.Text = "";
        }

        private void ORHistoryStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("The following record with the ID: " + idlbl.Text + " will be updated." +
                "\nAre you sure to update this record?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dlg == DialogResult.Yes)
            {
                sql.UpdateORRecord(idlbl.Text, ornumbtxt.Text, orreceived.Text);
                UpdateBinding();
                clear();
            }
            else { }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
            if (cmbfilter.Text.Equals("ORReceivedDate"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String srchtxt = searchtxt.Text;
            String id = "";
            if (cmbfilter.SelectedIndex == 0)
            {
                id = sql.getORHistoryID(srchtxt);
                if (!id.Equals(null))
                {
                    ohc = sql.SearchORHistoryID(id);
                    dgv_or_history.DataSource = ohc;
                }
            }
            else if (cmbfilter.Text.Equals("COCPL_UID") || cmbfilter.Text.Equals("FirstName") || cmbfilter.Text.Equals("MiddleName") || cmbfilter.Text.Equals("LastName"))
            {
                String fil = cmbfilter.Text;
                MessageBox.Show(fil);
                ohc = sql.SearchORHistory(fil, srchtxt);
                dgv_or_history.DataSource = ohc;
            }
            else if (cmbfilter.SelectedIndex == 5)
            {
                ohc = sql.SearchORNum(srchtxt);
                dgv_or_history.DataSource = ohc;
            }
            else if (cmbfilter.SelectedIndex == 6)
            {
                String fil = cmbfilter.Text;
                searchtxt.MaxLength = 23;
                if (sql.ConvDateRecResult(srchtxt) >= 0)
                {
                    ohc = sql.SearchORDateRec(srchtxt);
                    dgv_or_history.DataSource = ohc;
                }
                else
                {
                    MessageBox.Show("Please insert appropriate values in the textbox with the following format: mm - dd - yyyy", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_or_history_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            update_btn.Enabled = true;
            try
            {
                DataGridViewRow row = this.dgv_or_history.Rows[e.RowIndex];
                idlbl.Text = row.Cells["id"].Value.ToString();
                uidlbl.Text = row.Cells["COCPL_UID"].Value.ToString();
                ornumbtxt.Text = row.Cells["ORNumber"].Value.ToString();
                orreceived.Text = row.Cells["ORReceivedDate"].Value.ToString();
            }
            catch (Exception) { }
        }
    }
}
