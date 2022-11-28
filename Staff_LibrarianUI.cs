using System;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Staff_LibrarianUI : Form
    {
        SQLCheckActiveInactiveCommands sqlchk = new SQLCheckActiveInactiveCommands();
        public Staff_LibrarianUI()
        {
            InitializeComponent();
            customizeDesign();
            openChildForm(new Staff_DashboardUI());
        }

        private void LibrarianStaff_DashboardUI_Load(object sender, EventArgs e)
        {
            openChildForm(new Staff_DashboardUI());
        }

        private void customizeDesign()
        {
            act_mngmt_submenu.Visible = false;
            rep_charts_submenu.Visible = false;
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
            LibrarianStaff_UISubPanel.Controls.Add(childForm);
            LibrarianStaff_UISubPanel.Tag = childForm;
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

        private void btn_account_mngmt_Click(object sender, EventArgs e)
        {
            showSubMenu(act_mngmt_submenu);
        }

        private void repcharts_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(rep_charts_submenu);
        }

        private void btn_lib_dashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_DashboardUI());
        }
        private void Staff_LibrarianUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm lif = new LogInForm();
            lif.Show();
        }

        private void btn_client_mgmt_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_Librarian_Account_Management());
        }

        private void btn_member_mgmt_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_Member_Account_Management());
        }

        private void backuprestore_btn_sidepanel_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_BackupAndRestore());
        }

        private void LibrarianStaff_UISubPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_bkborrow_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_BookBorrowing());
        }

        private void bookreturnsbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_BookReturns());
        }

        private void btn_lib_book_mngmt_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_BookInventory());
        }
    }
}
