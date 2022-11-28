using System;
using System.Windows.Forms;

namespace Capstone
{
    public partial class InsertORNoForm : Form
    {
        SQLAccountManagementCommands acc_cmd = new SQLAccountManagementCommands();
        SQLProcessMemberInfoCommands memb = new SQLProcessMemberInfoCommands();
        public InsertORNoForm()
        {
            InitializeComponent();
        }

        private void InsertORNoForm_Load(object sender, EventArgs e)
        {
            memberuid.Text = Properties.Settings.Default.memberuid;
            MessageBox.Show(memberuid.Text);
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            String dt_end = Properties.Settings.Default.memberend;
            DateTime dt_parse = Convert.ToDateTime(dt_end);
            TimeSpan ts = new TimeSpan(365, 0, 0, 0);
            DateTime dt_end_new = dt_parse.Add(ts);
            String dt_end_str = Convert.ToString(dt_end_new);
            Properties.Settings.Default.memberend = dt_end_str;
            Properties.Settings.Default.Save();
            String id = memb.getMemberID(memberuid.Text);
            String ORNumber = ornumberinput.Text;
            SQLCommandsInsertORNumber or = new SQLCommandsInsertORNumber();
            if (or.CheckORDuplicates(ornumberinput.Text).Count == 0)
            {
                or.InsertMemberOR(id, id, id, id, id, id, id, ORNumber);
                acc_cmd.UpdateMembEnd(Properties.Settings.Default.memberid, Properties.Settings.Default.memberend);
            }
            else if (or.CheckORDuplicates(ornumberinput.Text).Count > 1)
            {
            }
            else if (ornumberinput.Text.Length == 0 || ornumberinput.Text.Length > 8)
            {
                MessageBox.Show("Please enter at least 8 characters.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Admin_Member_Account_Management acc = new Admin_Member_Account_Management();
            Staff_Member_Account_Management acc_st = new Staff_Member_Account_Management();
            acc.UpdateBinding();
            acc_st.UpdateBinding();
            this.Hide();
        }
        public void InsertNewMemberOR()
        {

        }
        public void InsertExistingMemberOR(String id)
        {
            acc_cmd.UpdateMembEnd(Properties.Settings.Default.memberid, Properties.Settings.Default.memberend);
            String ORNumber = ornumberinput.Text;
            SQLCommandsInsertORNumber or = new SQLCommandsInsertORNumber();
            if (or.CheckORDuplicates(ornumberinput.Text).Count == 0)
            {
                or.InsertMemberOR(id, id, id, id, id, id, id, ORNumber);
            }
            else if (or.CheckORDuplicates(ornumberinput.Text).Count > 1)
            {
            }
            else if (ornumberinput.Text.Length == 0 || ornumberinput.Text.Length > 8)
            {
                MessageBox.Show("Please enter at least 8 characters.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Admin_Member_Account_Management acc = new Admin_Member_Account_Management();
            Staff_Member_Account_Management acc_st = new Staff_Member_Account_Management();
            acc.UpdateBinding();
            acc_st.UpdateBinding();
            this.Hide();
        }
        private void InsertORNoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin_Member_Account_Management acc = new Admin_Member_Account_Management();
            Staff_Member_Account_Management acc_st = new Staff_Member_Account_Management();
            acc.UpdateBinding();
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void ornumberinput_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
