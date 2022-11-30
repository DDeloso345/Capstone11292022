using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class LogInForm : Form
    {
        List<LogInCredentials> login_admin = new List<LogInCredentials>();
        List<LogInCredentials> login_staff = new List<LogInCredentials>();
        SQLCheckActiveInactiveCommands sqlchk = new SQLCheckActiveInactiveCommands();
        //DashboardDataAccess adda = new DashboardDataAccess();
        public LogInForm()
        {
            InitializeComponent();
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            LogInCredentialsDataAccess login_DA = new LogInCredentialsDataAccess();
            login_admin = login_DA.AdminLogInCredentials(txtbox_username.Text, txtbox_password.Text);
            login_staff = login_DA.StaffLogInCredentials(txtbox_username.Text, txtbox_password.Text);
            if (login_admin.Count == 1)
            {
                MessageBox.Show("Logged in Successfully as Administrator");
                this.Hide();
                Admin_LibrarianUI lib_ui = new Admin_LibrarianUI();
                Properties.Settings.Default.loginusername = txtbox_username.Text;
                Properties.Settings.Default.loginpassword = txtbox_password.Text;
                Properties.Settings.Default.Save();
                lib_ui.Show();
            }
            else if (login_staff.Count == 1)
            {
                MessageBox.Show("Logged in Successfully as Staff");
                this.Hide();
                Staff_LibrarianUI staffui = new Staff_LibrarianUI();
                Properties.Settings.Default.loginusername = txtbox_username.Text;
                Properties.Settings.Default.loginpassword = txtbox_password.Text;
                Properties.Settings.Default.Save();
                staffui.Show();
            }
            else if (txtbox_username.Text == String.Empty || txtbox_password.Text == String.Empty)
            {
                MessageBox.Show("Username and/or password fields does not contain any credentials. Please log in your credentials again.");
            }
            else
            {
                MessageBox.Show("Username or password error. Please try to login again.");
                this.Hide();
                this.Show();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void txtbox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
