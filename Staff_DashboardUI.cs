using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Staff_DashboardUI : Form
    {
        public Staff_DashboardUI()
        {
            InitializeComponent();
        }

        String username = Convert.ToString(Properties.Settings.Default.loginusername);
        String password = Convert.ToString(Properties.Settings.Default.loginpassword);
        DashboardDataAccess adda = new DashboardDataAccess();
        private void Staff_DashboardUI_Load(object sender, EventArgs e)
        {
            Display();
            Notif();
        }
        public void Notif()
        {
            DateTime a = DateTime.Now;
            String con = a.ToString("yyyy-MM");
            String date = a.ToString("yyyy-MM-dd");

            month_bkbr.Text = adda.SelectMonthBKBR(con);
            if (month_bkbr.Text.Equals(""))
            {
                month_bkbr.Text = "0";
            }
            totalbkbr.Text = adda.SelectTotalBKBR();
            if (totalbkbr.Text.Equals(""))
            {
                totalbkbr.Text = "0";
            }
            missingbk.Text = adda.SelectMissingBooks();
            if (missingbk.Text.Equals(""))
            {
                missingbk.Text = "0";
            }
            curr_availbk.Text = adda.SelectAvailableBooks();
            if (curr_availbk.Text.Equals(""))
            {
                curr_availbk.Text = "0";
            }
            expmemb.Text = adda.SelectTotalExpMemb(a.ToString("yyyy-MM-dd"));
            if (expmemb.Text.Equals(""))
            {
                expmemb.Text = "0";
            }
            logbook.Text = adda.SelectTotalLogbook();
            if (logbook.Text.Equals(""))
            {
                logbook.Text = "0";
            }
            lgbk_now.Text = adda.SelectTodayLogbook(date);
            if (lgbk_now.Text.Equals(""))
            {
                lgbk_now.Text = "0";
            }
        }
        public void SetPic()
        {
            SQLAccountManagementCommands sql = new SQLAccountManagementCommands();
            String path = sql.SetDashboardProfilePic(username, password);
            try
            {
                Bitmap img = new Bitmap(path);
                profimg.Image = (Image)img;
            }
            catch (Exception)
            {
                MessageBox.Show("The path specified for the image intended for this account\neither does not exist or is corrupted." +
                    " Please update the image path for this account to fix this issue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Display()
        {
            usernametxt.Text = Properties.Settings.Default.loginusername;
            GetFirstName(username, password);
            GetMiddleName(username, password);
            GetLastName(username, password);
            GetPosition(username, password);
            GetHierarchyLvl(username, password);
            GetEmail(username, password);
            SetPic();
        }
        public void GetFirstName(string username, string password)
        {
            adda.FirstName(username, password);
            firstnametxt.Text = Properties.Settings.Default.staff_dash_firstname;
        }
        public void GetMiddleName(string username, string password)
        {
            adda.MiddleName(username, password);
            middlenametxt.Text = Properties.Settings.Default.staff_dash_middlename;
        }
        public void GetLastName(string username, string password)
        {
            adda.LastName(username, password);
            lastnametxt.Text = Properties.Settings.Default.staff_dash_lastname;
        }
        public void GetPosition(string username, string password)
        {
            adda.Position(username, password);
            if (Properties.Settings.Default.ad_dash_position.Equals("1"))
            {
                positiontxt.Text = "Librarian I";
            }
            else if (Properties.Settings.Default.ad_dash_position.Equals("2"))
            {
                positiontxt.Text = "Librarian II";
            }
            else if (Properties.Settings.Default.ad_dash_position.Equals("3"))
            {
                positiontxt.Text = "Librarian III";
            }
            else if (Properties.Settings.Default.ad_dash_position.Equals("4"))
            {
                positiontxt.Text = "Librarian IV";
            }
        }
        public void GetHierarchyLvl(string username, string password)
        {
            adda.HierarchyLvl(username, password);
            if (Properties.Settings.Default.ad_dash_hierarchylvl.Equals("1"))
            {
                hierarchylvltxt.Text = "Administrator";
            }
            else if (Properties.Settings.Default.ad_dash_hierarchylvl.Equals("2"))
            {
                hierarchylvltxt.Text = "Staff";
            }
        }
        public void GetEmail(string username, string password)
        {
            adda.Email(username, password);
            emailtxt.Text = Properties.Settings.Default.staff_dash_emailad;
            Properties.Settings.Default.Save();
        }
    }
}
