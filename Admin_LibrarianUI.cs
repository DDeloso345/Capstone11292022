using System;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Admin_LibrarianUI : Form
    {
        SQLCheckActiveInactiveCommands sqlchk = new SQLCheckActiveInactiveCommands();
        SQLProcessMemberInfoCommands m = new SQLProcessMemberInfoCommands();
        public Admin_LibrarianUI()
        {
            InitializeComponent();
            openChildForm(new Admin_DashboardUI());
            customizeDesign();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            UIFormSubpanel.Controls.Add(childForm);
            UIFormSubpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void hideSubmenu()
        {
            if (act_mngmt_submenu.Visible == true)
                act_mngmt_submenu.Visible = false;
            if (rep_charts_submenu.Visible == true)
                rep_charts_submenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void customizeDesign()
        {
            act_mngmt_submenu.Visible = false;
            rep_charts_submenu.Visible = false;
        }
        private void LibrarianUI_Load(object sender, EventArgs e)
        {
            openChildForm(new Admin_DashboardUI());

        }

        private void lib_side_menu_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_lib_book_mngmt_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new Admin_BookInventory());
        }

        private void btn_lib_dashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_DashboardUI());
        }

        private void backuprestore_btn_sidepanel_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_BackupAndRestore());
        }

        private void LibrarianUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_account_mngmt_Click(object sender, EventArgs e)
        {
            showSubMenu(act_mngmt_submenu);
            int a = Convert.ToInt32(m.CountAllNotif());
            if (a > 0)
            {
                pictureBox1.Visible = true;
            }
        }

        private void repcharts_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(rep_charts_submenu);
        }


        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm lif = new LogInForm();
            lif.Show();
        }

        private void btn_admin_mngmnt_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_Admin_Acc_Management());
        }

        private void btn_staff_mngmnt_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_Staff_Acc_Management());
        }

        private void btn_member_mgmt_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_Member_Account_Management());
        }

        private void UIFormSubpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_bookborrowing_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_BookBorrowing());
        }

        private void bookreturnsbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_BookReturns());
        }

        // REPORTS
        private void BookInvReport_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports.BookInventory.View_BookInventory());
        }

        private void BorrowedBooksReport_Click(object sender, EventArgs e)
        {

        }

        private void MemberFreqReport_Click(object sender, EventArgs e)
        {

        }

        private void ClientLogbookReport_Click(object sender, EventArgs e)
        {

        }
    }
}
