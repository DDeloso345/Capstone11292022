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
    public partial class BKBR_SelectUID : Form
    {
        SQLBookBorrowingCommands bk = new SQLBookBorrowingCommands();
        List<getCOCPLUID> d = new List<getCOCPLUID>();
        public BKBR_SelectUID()
        {
            InitializeComponent();
        }

        private void BKBR_SelectUID_Load(object sender, EventArgs e)
        {
            UpdateBinding();
        }
        public void UpdateBinding() {
            d = bk.LoadCOCPL_UID();
            dgv_bkbr.DataSource = d;
        }

        private void dgv_bkbr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bkbr.SelectedRows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_bkbr.Rows[e.RowIndex];
                    bkbr_ui_details.Text = row.Cells["COCPL_UID"].Value.ToString();

                    Properties.Settings.Default.bkbr_uid = bkbr_ui_details.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception) { }
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            bkbr_ui_details.Text = "[Book Author]";
            searchtxt.Text = "";
            UpdateBinding();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            d = bk.SearchCOCPL_UID(searchtxt.Text);
            dgv_bkbr.DataSource = d;
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void dgv_bkbr_DoubleClick(object sender, EventArgs e)
        {
            Admin_BookBorrowing.COCPL_UID = Properties.Settings.Default.bkbr_uid;
            Staff_BookBorrowing.COCPL_UID = Properties.Settings.Default.bkbr_uid;
            this.Close();
        }
    }
}
