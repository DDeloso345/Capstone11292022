using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Staff_Member_Account_Management : Form
    {
        public static String orgTxt = "";
        List<AccountDetails_Get_Member> acc = new List<AccountDetails_Get_Member>();
        SQLAccountManagementCommands acc_cmd = new SQLAccountManagementCommands();
        SQLIDPreviewCommandsClass acc_id = new SQLIDPreviewCommandsClass();
        SQLProcessMemberInfoCommands memb = new SQLProcessMemberInfoCommands();
        ORHistoryStaff orh = new ORHistoryStaff();
        InsertORNoForm or = new InsertORNoForm();
        List<MemberNotifExpiryDate> m = new List<MemberNotifExpiryDate>();
        public Staff_Member_Account_Management()
        {
            InitializeComponent();
            membership_timer.Start();
            InsertNotifs();
        }

        private void Staff_Member_Account_Management_Load(object sender, EventArgs e)
        {
            membership_timer.Start();
            UpdateBinding();
            cmbbox_criteria.SelectedIndex = 0;
            suffixtxt.SelectedIndex = 0;
            ComboBoxSel();
        }
        public void InsertNotifs()
        {
            TimeSpan dt3d = new TimeSpan(3, 0, 0, 0);
            String dtp3 = Convert.ToString(DateTime.Now.Add(dt3d).ToString("yyyy-MM-dd 00:00:00"));

            String conv_tostr = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));

            TimeSpan dt1d = new TimeSpan(1, 0, 0, 0);
            String str_1d = Convert.ToString(DateTime.Now.Add(dt1d).ToString("yyyy-MM-dd 00:00:00"));

            List<AccountDetails_Get_Member> exp_now = memb.SelectAllPendingExpired(conv_tostr);
            List<AccountDetails_Get_Member> exp_day_before = memb.SelectAllPendingExpired(str_1d);
            List<AccountDetails_Get_Member> get = memb.SelectAllPendingExpired(dtp3);

            foreach (var getOne in exp_day_before)
            {
                if (exp_day_before.Count == 0)
                {
                }
                else if (exp_day_before.Count > 0)
                {
                    List<MemberNotifExpiryDate> m = memb.GetMsgNotifWLike(getOne.COCPL_UID, str_1d);
                    if (m.Count > 0)
                    {
                        memb.InsertNotifExpTomorrow(getOne.COCPL_UID);
                        UpdateBinding();
                    }
                    else if (m.Count == 0)
                    {
                        memb.InsertNotifExpTomorrow(getOne.COCPL_UID);
                        UpdateBinding();
                    }
                }
            }
            foreach (var getOne in get)
            {
                if (get.Count == 0)
                {
                }
                else if (get.Count > 0)
                {
                    List<MemberNotifExpiryDate> m = memb.GetMsgNotifWLike(getOne.COCPL_UID, dtp3);
                    if (m.Count > 0)
                    {
                        memb.InsertNotif(getOne.COCPL_UID, dtp3);
                        UpdateBinding();
                    }
                    else if (m.Count == 0)
                    {
                        memb.InsertNotif(getOne.COCPL_UID, dtp3);
                        UpdateBinding();
                    }
                }
            }
            foreach (var getOne in exp_now)
            {
                if (exp_now.Count == 0)
                {
                }
                else if (exp_now.Count > 0)
                {
                    List<MemberNotifExpiryDate> m = memb.GetMsgNotifWLike(getOne.COCPL_UID, conv_tostr);
                    if (m.Count > 0)
                    {
                        memb.InsertNotifExpToday(getOne.COCPL_UID);
                        UpdateBinding();
                    }
                    else if (m.Count == 0)
                    {
                        memb.InsertNotifExpToday(getOne.COCPL_UID);
                        UpdateBinding();
                    }
                }
            }
        }
        public void UpdateBinding()
        {
            acc = memb.LoadMemberData();
            dgv_member_acc_tbl.DataSource = acc;
            m = memb.SelectAllNotif();
            notifdgv.DataSource = m;
            notifcounter.Text = memb.CountAllNotif();
        }
        public void SearchUpdateBinding(String selection)
        {
            acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
            dgv_member_acc_tbl.DataSource = acc;
        }
        public void ComboBoxSel()
        {
        }
        public void clear()
        {

            btn_update.Enabled = false;
            membership_timer.Enabled = false;
            idlbl.Text = "[ID Txt]";
            uidtxt.Text = "COCPLM";
            uidtxt.ReadOnly = false;
            idlbl.Text = "[ID Txt]";
            contactnotxt.Text = "09";
            firstnametxt.Text = "";
            middlenametxt.Text = "";
            lastnametxt.Text = "";
            emailtxt.Text = "";
            addresstxt.Text = "";
            organizationtxt.Text = "";
            membidprev.Enabled = false;
            renew_member.Enabled = false;
            MembershipDateSetter();
        }
        public void MembershipDateSetter()
        {
            DateTime dt = DateTime.Now;
            memberstart_txt.Text = dt.ToString("MM-dd-yyyy");

            TimeSpan dt_1yr = new TimeSpan(365, 0, 0, 0);
            DateTime dt_plus1yr = dt.Add(dt_1yr);
            memberend_txt.Text = dt_plus1yr.ToString("MM-dd-yyyy");
        }
        public void PropertiesSave()
        {
            Properties.Settings.Default.memberid = idlbl.Text;
            Properties.Settings.Default.memberuid = uidtxt.Text;
            Properties.Settings.Default.memberfirstname = firstnametxt.Text;
            Properties.Settings.Default.membermiddlename = middlenametxt.Text;
            Properties.Settings.Default.memberlastname = lastnametxt.Text;
            Properties.Settings.Default.memberorganization = organizationtxt.Text;
            Properties.Settings.Default.memberaddress = addresstxt.Text;
            Properties.Settings.Default.memberemail = emailtxt.Text;
            Properties.Settings.Default.membercontactno = contactnotxt.Text;
            Properties.Settings.Default.memberstart = Convert.ToString(memberstart_txt.Value);
            Properties.Settings.Default.memberend = Convert.ToString(memberend_txt.Value);
            Properties.Settings.Default.memberidimgpath = imgpathtxt.Text;
            Properties.Settings.Default.Save();
        }
        private void firstnametxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                firstnametxt.Text = textInfo.ToTitleCase(firstnametxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void middlenametxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                middlenametxt.Text = textInfo.ToTitleCase(middlenametxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void lastnametxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                lastnametxt.Text = textInfo.ToTitleCase(lastnametxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void addresstxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                addresstxt.Text = textInfo.ToTitleCase(addresstxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void contactnotxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void uidtxt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void membership_timer_Tick(object sender, EventArgs e)
        {
            MembershipDateSetter();
            organizationtxt.Text = orgTxt;
            orgid.Text = memb.getOrganizationID(orgTxt);
            if (orgid.Text.Length == 0)
            {
                orgid.Text = "[ID]";
            }
            membership_timer.Start();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String selection = "";
            if (cmbbox_criteria.Text.Equals("COCPL UID"))
            {
                selection = "COCPL_UID";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("First Name"))
            {
                selection = "FirstName";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Middle Name"))
            {
                selection = "MiddleName";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Last Name"))
            {
                selection = "LastName";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Suffix"))
            {
                acc = memb.SearchMemberDetails("Suffix", inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Organization"))
            {
                selection = "SchoolOrOrganization";
                acc = memb.SearchMemberDetails("Organization", inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Address"))
            {
                selection = "Address";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("E-mail Address"))
            {
                selection = "EMailAddress";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Contact No."))
            {
                selection = "ContactNo";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Membership Start"))
            {
                if (memb.ConvDate(inputsearchbar.Text) >= 0)
                {
                    if (inputsearchbar.Text.StartsWith("0"))
                    {
                        acc = memb.SearchMembStart(inputsearchbar.Text.Replace("0", ""));
                        dgv_member_acc_tbl.DataSource = acc;
                    }
                    else
                    {
                        acc = memb.SearchMembStart(inputsearchbar.Text);
                        dgv_member_acc_tbl.DataSource = acc;
                    }

                }
                else { }
            }
            else if (cmbbox_criteria.Text.Equals("Membership End"))
            {
                if (memb.ConvDate(inputsearchbar.Text) >= 0)
                {
                    if (inputsearchbar.Text.StartsWith("0"))
                    {
                        acc = memb.SearchMembEnd(inputsearchbar.Text.Replace("0", ""));
                        dgv_member_acc_tbl.DataSource = acc;
                    }
                    else
                    {
                        acc = memb.SearchMembEnd(inputsearchbar.Text);
                        dgv_member_acc_tbl.DataSource = acc;
                    }
                }
                else { }
            }
            else if (cmbbox_criteria.Text.Equals("Image Path"))
            {
                selection = "ImgPath";
                acc = memb.SearchMemberDetails(selection, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
            else
            {
                acc = memb.SearchMemberDetails(cmbbox_criteria.Text, inputsearchbar.Text);
                dgv_member_acc_tbl.DataSource = acc;
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (uidtxt.Text.Length == 0 || firstnametxt.Text.Length == 0 || middlenametxt.Text.Length == 0 || lastnametxt.Text.Length == 0 || organizationtxt.Text.Length == 0 || addresstxt.Text.Length == 0 || emailtxt.Text.Length == 0 || contactnotxt.Text.Length == 0 || memberstart_txt.Text.Length == 0 || memberend_txt.Text.Length == 0 || imgpathtxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left blank.\nPlease fill in the blank fields to successfully add a library member account.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (uidtxt.Text.Length > 0 && contactnotxt.Text.Length > 0)
            {
                try
                {
                    var test = memb.CompareSameMemberUID(uidtxt.Text);
                    Properties.Settings.Default.memberstart = memberstart_txt.Text;
                    Properties.Settings.Default.memberend = memberend_txt.Text;
                    if (test.Count == 0 && memberstart_txt.Text.Equals(Properties.Settings.Default.memberstart) && contactnotxt.Text.StartsWith("09") && contactnotxt.TextLength == 11 && uidtxt.TextLength == 14)
                    {
                        String org_id = memb.getOrganizationID(organizationtxt.Text);
                        if (!org_id.Equals(null))
                        {
                            ComboBoxSel();
                            Properties.Settings.Default.memberuid = uidtxt.Text;
                            Properties.Settings.Default.memberfirstname = firstnametxt.Text;
                            Properties.Settings.Default.memberlastname = lastnametxt.Text;
                            String uid = uidtxt.Text;
                            String fn = firstnametxt.Text;
                            String mn = middlenametxt.Text;
                            String ln = lastnametxt.Text;
                            String suf = suffixtxt.Text;
                            String add = addresstxt.Text;
                            String org = organizationtxt.Text;
                            String email = emailtxt.Text;
                            String numb = contactnotxt.Text;
                            String st = Convert.ToString(memberstart_txt.Value);
                            String end = Convert.ToString(memberend_txt.Value);

                            var dlg = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to insert the specified record.\n\n" + "\nUID: COCPLM" + uid + "\nFirst Name: " + fn + "\nMiddle Name: " + mn + "\nLast Name: " + ln + "\nSuffix: " + suf + "\nAddress: " + add + "\nOrganization: " + org + "\nE-mail Address: " + email + "\nContact Number: " + numb + "\nMembership Start: " + st + "\nMembership End: " + end + "\nImage Path: " + imgpathtxt.Text + "\n\nAre the following information correct?", "Confirmation for member account entries", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (dlg == DialogResult.Yes)
                            {
                                String sfx;
                                if (suffixtxt.Text.Equals("N/A"))
                                {
                                    sfx = "1";
                                    memb.InsertMember(uidtxt.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, orgid.Text, addresstxt.Text, emailtxt.Text, contactnotxt.Text, st, end, imgpathtxt.Text);
                                    clear();
                                    UpdateBinding();
                                }
                                else if (suffixtxt.Text.Equals("Sr."))
                                {
                                    sfx = "2";
                                    memb.InsertMember(uidtxt.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, orgid.Text, addresstxt.Text, emailtxt.Text, contactnotxt.Text, st, end, imgpathtxt.Text);
                                    clear();
                                    UpdateBinding();
                                }
                                else if (suffixtxt.Text.Equals("Jr."))
                                {
                                    sfx = "3";
                                    memb.InsertMember(uidtxt.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, orgid.Text, addresstxt.Text, emailtxt.Text, contactnotxt.Text, st, end, imgpathtxt.Text);
                                    clear();
                                    UpdateBinding();
                                }
                            }
                            else { }
                        }
                        else { }
                    }
                    else if (!contactnotxt.Text.StartsWith("09"))
                    {
                        MessageBox.Show("The following phone number does not start with the following numbers: 09.");
                    }
                    else if (contactnotxt.TextLength < 11)
                    {
                        MessageBox.Show("The following phone number did not reach the 11-digit requirement.");
                    }
                    else if (!uidtxt.Text.StartsWith("COCPLM"))
                    {
                        MessageBox.Show("The assigned UID does not have the COCPLM prefix.\nPlease add the specified prefix before adding another member account.");
                    }
                    else if (uidtxt.TextLength < 14)
                    {
                        MessageBox.Show("The assigned UID did not reach the 8-digit numerical character requirement.\nPlease add the specified criteria before adding another member account.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (uidtxt.Text.Length == 0 || firstnametxt.Text.Length == 0 || middlenametxt.Text.Length == 0 || lastnametxt.Text.Length == 0 || organizationtxt.Text.Length == 0 || addresstxt.Text.Length == 0 || emailtxt.Text.Length == 0 || contactnotxt.Text.Length == 0 || memberstart_txt.Text.Length == 0 || memberend_txt.Text.Length == 0 || imgpathtxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left blank.\nPlease fill in the blank fields to successfully update a library member account.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (uidtxt.Text.Length > 0 && contactnotxt.Text.Length > 0)
            {
                try
                {
                    Properties.Settings.Default.memberstart = memberstart_txt.Text;
                    Properties.Settings.Default.Save();
                    if (memberstart_txt.Text.Equals(Properties.Settings.Default.memberstart) && contactnotxt.Text.StartsWith("09") && contactnotxt.TextLength == 11 && uidtxt.TextLength == 14)
                    {
                        String uid = uidtxt.Text;
                        String fn = firstnametxt.Text;
                        String mn = middlenametxt.Text;
                        String ln = lastnametxt.Text;
                        String add = addresstxt.Text;
                        String org = organizationtxt.Text;
                        String email = emailtxt.Text;
                        String numb = contactnotxt.Text;
                        String st = memberstart_txt.Value.ToString("yyyy-MM-dd");
                        String end = memberend_txt.Value.ToString("yyyy-MM-dd");
                        String img = imgpathtxt.Text;

                        var dlg = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to update the specified record.\n\n" + "\nUID: " + uid + "\nFirst Name: " + fn + "\nMiddle Name: " + mn + "\nLast Name: " + ln + "\nAddress: " + add + "\nOrganization: " + org + "\nE-mail Address: " + email + "\nContact Number: " + numb + "\nMembership Start: " + st + "\nMembership End: " + end + "\nImage Path: " + img + "\n\nAre the following information correct?", "Confirmation for member account updates", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dlg == DialogResult.Yes)
                        {
                            if (suffixtxt.Text.Equals("N/A"))
                            {
                                String suf = "1";
                                acc_cmd.UpdateMember(idlbl.Text, uidtxt.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, suf, orgid.Text, addresstxt.Text, emailtxt.Text, contactnotxt.Text, st, end, imgpathtxt.Text);
                                PropertiesSave();
                                UpdateBinding();
                                clear();
                            }
                            else if (suffixtxt.Text.Equals("Sr."))
                            {
                                String suf = "2";
                                acc_cmd.UpdateMember(idlbl.Text, uidtxt.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, suf, orgid.Text, addresstxt.Text, emailtxt.Text, contactnotxt.Text, st, end, imgpathtxt.Text);
                                PropertiesSave();
                                UpdateBinding();
                                clear();
                            }
                            else if (suffixtxt.Text.Equals("Jr."))
                            {
                                String suf = "3";
                                acc_cmd.UpdateMember(idlbl.Text, uidtxt.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, suf, orgid.Text, addresstxt.Text, emailtxt.Text, contactnotxt.Text, st, end, imgpathtxt.Text);
                                PropertiesSave();
                                UpdateBinding();
                                clear();
                            }
                        }
                        else { }
                    }
                    else if (!contactnotxt.Text.StartsWith("09"))
                    {
                        MessageBox.Show("The following phone number does not start with the following numbers: 09.");
                    }
                    else if (contactnotxt.TextLength < 11)
                    {
                        MessageBox.Show("The following phone number did not reach the 11-digit requirement.");
                    }
                    else if (!uidtxt.Text.StartsWith("COCPLM"))
                    {
                        MessageBox.Show("The assigned UID does not have the COCPLM prefix.\nPlease add the specified prefix before adding another member account.");
                    }
                    else if (uidtxt.TextLength < 14)
                    {
                        MessageBox.Show("The assigned UID did not reach the 8-digit numerical character requirement.\nPlease add the specified criteria before adding another member account.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("An invalid set of characters has been detected in the text fields that contain dates.\nPlease try to use numeric characters only in the following format: mm/dd/yyyy.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void renew_member_Click(object sender, EventArgs e)
        {
            PropertiesSave();
            DateTime dt = DateTime.Now;
            TimeSpan dt_1yr = new TimeSpan(365, 0, 0, 0);
            DateTime dt_plus1yr = dt.Add(dt_1yr);
            memberend_txt.Text = dt_plus1yr.ToString("MM/dd/yyyy");
            or.Show();
        }

        private void membidprev_Click(object sender, EventArgs e)
        {
            MemberIDPreview prev = new MemberIDPreview();
            PropertiesSave();
            acc_id.Name(idlbl.Text);
            prev.Show();
            prev.SetLabels();
        }

        private void orhistory_Click(object sender, EventArgs e)
        {
            try
            {
                PropertiesSave();
                orh.Show();
                orh.UpdateBinding();
            }
            catch (Exception)
            {
                MessageBox.Show("The following information displayed in the text fields does not exist in the database.\nPlease enter the exact values in their respective text fields.");
            }
        }

        private void dgv_member_acc_tbl_Leave(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void btn_imgbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = ".JPEG Files (*.jpeg)|*.jpeg|.JPG Files (*.jpg)|*.jpg|.JFIF Files (*.jfif)|*.jfif|.PNG Files (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                String imgpath = openFileDialog1.FileName;
                imgpathtxt.Text = imgpath;
                Properties.Settings.Default.memberidimgpath = imgpath;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("No file has been selected.");
            }

            if (imgpathtxt.Text.Length == 0)
            {
                MessageBox.Show("Please provide an image path.");
            }
            else { }
        }

        private void cmbbox_criteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
            if (cmbbox_criteria.Text.Equals("Contact No."))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbbox_criteria.Text.Equals("Membership Start"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbbox_criteria.Text.Equals("Membership End"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void organizationtxt_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                organizationtxt.Text = textInfo.ToTitleCase(organizationtxt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void selaction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notifbtn_CheckedChanged(object sender, EventArgs e)
        {
            isChk = notifbtn.Checked;
        }
        bool isChk = false;
        private void notifbtn_Click(object sender, EventArgs e)
        {
            if (notifbtn.Checked && !isChk)
            {
                notifbtn.Checked = false;
                notifdgv.Visible = false;
            }
            else
            {
                notifbtn.Checked = true;
                isChk = false;
                notifdgv.Visible = true;
            }
        }

        private void notifdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (notifdgv.Rows.Count >= 0)
            {
                DataGridViewRow row = this.notifdgv.Rows[e.RowIndex];
                String notif = notifdgv.Rows[e.RowIndex].Cells["NotificationMsg"].Value.ToString();
                String datepos = notifdgv.Rows[e.RowIndex].Cells["DatePosted"].Value.ToString();
                MessageBox.Show("The following notification has the message:" + "\n\n" + memb.GetMsgNotif(notif) + "\n\nThis notification was posted at " + memb.GetTimeStamp(notif), "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void notifpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifcounter_Click(object sender, EventArgs e)
        {

        }

        private void organizationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            orgid.Text = memb.getOrganizationID(organizationtxt.Text);
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void selorg_Click(object sender, EventArgs e)
        {
            membership_timer.Start();
            SelectOrganization_Staff o = new SelectOrganization_Staff();
            o.Show();
        }

        private void dgv_member_acc_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;

            try
            {
                if (dgv_member_acc_tbl.Rows.Count >= 0)
                {
                    DataGridViewRow row = this.dgv_member_acc_tbl.Rows[e.RowIndex];
                    membership_timer.Stop();
                    idlbl.Text = row.Cells["id"].Value.ToString();
                    uidtxt.Text = "";
                    uidtxt.Text = row.Cells["COCPL_UID"].Value.ToString();
                    firstnametxt.Text = row.Cells["FirstName"].Value.ToString();
                    middlenametxt.Text = row.Cells["MiddleName"].Value.ToString();
                    lastnametxt.Text = row.Cells["LastName"].Value.ToString();
                    suffixtxt.Text = row.Cells["Suffix"].Value.ToString();
                    addresstxt.Text = row.Cells["Address"].Value.ToString();
                    organizationtxt.Text = row.Cells["SchoolOrOrganization"].Value.ToString();
                    orgid.Text = memb.getOrganizationID(organizationtxt.Text);
                    emailtxt.Text = row.Cells["EMailAddress"].Value.ToString();
                    contactnotxt.Text = row.Cells["ContactNo"].Value.ToString();
                    memberstart_txt.Text = row.Cells["MemberStart"].Value.ToString();
                    memberstart_txt.Text = memberstart_txt.Text.Replace("00:00:00", "");
                    memberend_txt.Text = row.Cells["MemberEnd"].Value.ToString();
                    imgpathtxt.Text = row.Cells["ImgPath"].Value.ToString();
                    memberend_txt.Text = memberend_txt.Text.Replace("00:00:00", "");
                    uidtxt.ReadOnly = true;
                    renew_member.Enabled = true;
                    membidprev.Enabled = true;
                    orhistory.Enabled = true;
                    Properties.Settings.Default.memberuid = uidtxt.Text;
                    Properties.Settings.Default.memberfirstname = firstnametxt.Text;
                    Properties.Settings.Default.membermiddlename = middlenametxt.Text;
                    Properties.Settings.Default.memberlastname = lastnametxt.Text;
                    Properties.Settings.Default.memberidimgpath = imgpathtxt.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception) { }
        }
    }
}
