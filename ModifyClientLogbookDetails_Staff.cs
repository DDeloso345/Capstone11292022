using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Capstone
{
    public partial class ModifyClientLogbookDetails_Staff : Form
    {
        List<ClientWalkInLogbookInfo> c = new List<ClientWalkInLogbookInfo>();
        List<getLogbookColumns> col = new List<getLogbookColumns>();
        SQLClientLogbookCommands sql = new SQLClientLogbookCommands();
        public ModifyClientLogbookDetails_Staff()
        {
            InitializeComponent();
        }

        private void ModifyClientLogbookDetails_Staff_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            ComboBoxSel();
        }
        public void UpdateBinding()
        {
            c = sql.LoadLogbookData();
            dgv_clientlogbook.DataSource = c;
        }
        public void ComboBoxSel()
        {
            col = sql.LoadLogbookCmb();
            crit_cmb.DataSource = col;
            crit_cmb.DisplayMember = "name";
        }
        public void clear()
        {
            idtxt.Text = "[ID Txt]";
            logbk_fntxt.Text = "";
            logbk_mntxt.Text = "";
            logbk_lntxt.Text = "";
            logbk_addresstxt.Text = "";
            logbk_numb.Text = "09";
            logbk_datetxt.Text = "";
            logbk_timetxt.Text = "[Time Details Placeholder]";

            logbk_upd_btn.Enabled = false;
        }
        private void dgv_clientlogbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_clientlogbook.SelectedRows.Count >= 0)
                {
                    logbk_upd_btn.Enabled = true;

                    DataGridViewRow row = this.dgv_clientlogbook.Rows[e.RowIndex];
                    idtxt.Text = row.Cells["ID"].Value.ToString();
                    logbk_fntxt.Text = row.Cells["FirstName"].Value.ToString();
                    logbk_mntxt.Text = row.Cells["MiddleName"].Value.ToString();
                    logbk_lntxt.Text = row.Cells["LastName"].Value.ToString();
                    logbk_addresstxt.Text = row.Cells["Address"].Value.ToString();
                    logbk_numb.Text = row.Cells["ContactNo"].Value.ToString();
                    logbk_datetxt.Text = row.Cells["Date"].Value.ToString().Replace("00:00:00", "");
                    logbk_timetxt.Text = row.Cells["Time"].Value.ToString().Remove(8, 8);
                }
            }
            catch (Exception)
            { }
        }

        private void crit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (crit_cmb.Text.Equals("id"))
            {
                c = sql.SearchLogbookData("id", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
            else if (crit_cmb.Text.Equals("FirstName"))
            {
                c = sql.SearchLogbookData("FirstName", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
            else if (crit_cmb.Text.Equals("MiddleName"))
            {
                c = sql.SearchLogbookData("MiddleName", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
            else if (crit_cmb.Text.Equals("LastName"))
            {
                c = sql.SearchLogbookData("LastName", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
            else if (crit_cmb.Text.Equals("Address"))
            {
                c = sql.SearchLogbookData("Address", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
            else if (crit_cmb.Text.Equals("ContactNo"))
            {
                c = sql.SearchLogbookData("ContactNo", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
            else if (crit_cmb.Text.Equals("Date"))
            {
                c = sql.SearchLogbookData("Date", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
            else if (crit_cmb.Text.Equals("Time"))
            {
                c = sql.SearchLogbookData("Time", searchtxt.Text);
                dgv_clientlogbook.DataSource = c;
            }
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void logbk_upd_btn_Click(object sender, EventArgs e)
        {
            String dt = Convert.ToString(logbk_datetxt.Value.ToString("yyyy-MM-dd"));
            try
            {
                if (idtxt.Text.Equals("[ID Txt]") || idtxt.Text.Length == 0 ||
                    logbk_fntxt.Text.Length == 0 || logbk_mntxt.Text.Length == 0 ||
                    logbk_lntxt.Text.Length == 0 || logbk_addresstxt.Text.Length == 0 ||
                    logbk_numb.Text.Length == 0 || logbk_timetxt.Equals("[Time Details Placeholder]") ||
                    logbk_timetxt.Text.Length == 0)
                {
                    MessageBox.Show("One or more of the fields have been left empty.\nPlease enter or select valid choices and/or characters from the fields provided.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var dlg = MessageBox.Show("Please double-check the following information before proceeding to update the specified record.\n\n"
                        + "\nClient Logbook Record ID:" + idtxt.Text
                        + "\nFirst Name: " + logbk_fntxt.Text
                        + "\nMiddle Name: " + logbk_mntxt.Text
                        + "\nLast Name: " + logbk_lntxt.Text
                        + "\nAddress: " + logbk_addresstxt.Text
                        + "\nContact Number: " + logbk_numb.Text
                        + "\nDate: " + logbk_datetxt.Value.ToShortDateString()
                        + "\n\nDo you wish to proceed in updating this record with the following values?", "Confirmation for updating client logbook records", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlg == DialogResult.Yes)
                    {
                        sql.UpdateLogbookData(idtxt.Text, logbk_fntxt.Text, logbk_mntxt.Text, logbk_lntxt.Text, logbk_addresstxt.Text, logbk_numb.Text, dt);
                        UpdateBinding();
                        clear();
                    }
                }
            }
            catch (Exception) { }
        }

        private void logbk_clr_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void logbk_numb_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;
            int keyvalue = (int)e.KeyChar;
            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            e.Handled = true;
        }

        private void logbk_fntxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                logbk_fntxt.Text = textInfo.ToTitleCase(logbk_fntxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void logbk_mntxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                logbk_mntxt.Text = textInfo.ToTitleCase(logbk_mntxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void logbk_lntxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                logbk_lntxt.Text = textInfo.ToTitleCase(logbk_lntxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void logbk_addresstxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                logbk_addresstxt.Text = textInfo.ToTitleCase(logbk_addresstxt.Text);
            }
            catch (Exception)
            {
            }
        }
    }
}
