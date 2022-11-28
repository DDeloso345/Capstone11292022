using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Staff_Librarian_Account_Management : Form
    {

        List<AccountDetails_Get_Staff> staff_acc = new List<AccountDetails_Get_Staff>();
        SQLAccountManagementCommands acc_cmd = new SQLAccountManagementCommands();
        SQLStaffCommandsClass staff_cmd = new SQLStaffCommandsClass();
        public Staff_Librarian_Account_Management()
        {
            InitializeComponent();
        }
        private void Staff_Librarian_Account_Management_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            cmbbox_criteria.SelectedIndex = 0;
            positioncombobox.SelectedIndex = 0;
            suffixtxt.SelectedIndex = 0;
        }
        public void UpdateBinding()
        {
            staff_acc = staff_cmd.LoadStaffData();
            dgv_admin_acc_tbl.DataSource = staff_acc;
        }
        public void SearchUpdateBinding(String selection)
        {
            staff_acc = acc_cmd.SearchStaff(selection, inputsearchbar.Text);
            dgv_admin_acc_tbl.DataSource = staff_acc;
        }
        public void clear()
        {

            btn_update.Enabled = false;
            idlbl.Text = "[ID Txt]";
            firstnametxt.Text = "";
            middlenametxt.Text = "";
            lastnametxt.Text = "";
            emailtxt.Text = "";
            contactnotxt.Text = "";
            usernametxt.Text = "";
            passwordtxt.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text.Length == 0 || middlenametxt.Text.Length == 0 || lastnametxt.Text.Length == 0 || emailtxt.Text.Length == 0 || contactnotxt.Text.Length == 0 || usernametxt.Text.Length == 0 || passwordtxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left blank.\nPlease fill in the blank fields to successfully add a staff account.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (contactnotxt.Text.Length > 0)
            {
                String fn = firstnametxt.Text;
                String mn = middlenametxt.Text;
                String ln = lastnametxt.Text;
                String suf = suffixtxt.Text;
                String pos1 = positioncombobox.Text;
                String hier1 = hierarchylvltxt.Text;
                String numb = contactnotxt.Text;
                String email = emailtxt.Text;
                String un = usernametxt.Text;
                String pw = passwordtxt.Text;
                String img = imgpathtxt.Text;
                var dlg = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to update the specified record.\n\nFirst Name: " + fn + "\nMiddle Name: " + mn + "\nLast Name: " + ln + "\nSuffix: " + suf + "\nPosition: " + pos1 + "\nHierarchy Level: " + hier1 + "\nE-mail Address: " + email + "\nContact Number: " + numb + "\nUsername: " + un + "\nPassword: " + pw + "\nImage Path: " + img + "\n\nAre the following information correct?", "Confirmation for staff account updates", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                try
                {
                    if (hierarchylvltxt.Text.Equals("Staff"))
                    {
                        String hier = "2";
                        if (positioncombobox.Text.Equals("Librarian I"))
                        {
                            String pos = "1";
                            try
                            {
                                var test = acc_cmd.CompareSameUsernameStaff(usernametxt.Text);
                                if (test.Count == 0)
                                {
                                    if (dlg == DialogResult.Yes)
                                    {
                                        String sfx;
                                        if (suffixtxt.Text.Equals("N/A"))
                                        {
                                            sfx = "1";
                                            acc_cmd.Insert(firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text);
                                            clear();
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Sr."))
                                        {
                                            sfx = "2";
                                            acc_cmd.Insert(firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text);
                                            clear();
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Jr."))
                                        {
                                            sfx = "3";
                                            acc_cmd.Insert(firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text);
                                            clear();
                                            UpdateBinding();
                                        }
                                    }
                                    else { }
                                }
                                else
                                {
                                }
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (positioncombobox.Text.Equals("Librarian II"))
                        {
                            String pos = "2";
                            try
                            {
                                var test = acc_cmd.CompareSameUsernameStaff(usernametxt.Text);
                                if (test.Count == 0)
                                {
                                    if (dlg == DialogResult.Yes)
                                    {
                                        String sfx;
                                        if (suffixtxt.Text.Equals("N/A"))
                                        {
                                            sfx = "1";
                                            acc_cmd.Insert(firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                            clear();
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Sr."))
                                        {
                                            sfx = "2";
                                            acc_cmd.Insert(firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                            clear();
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Jr."))
                                        {
                                            sfx = "3";
                                            acc_cmd.Insert(firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                            clear();
                                            UpdateBinding();
                                        }
                                    }
                                    else { }
                                }
                                else if (test.Count > 0 && Properties.Settings.Default.membercatchinvaliddates.Length > 0)
                                {
                                }
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!contactnotxt.Text.StartsWith("09"))
            {
                MessageBox.Show("The following phone number does not start with the following numbers: 09.");
            }
            else if (contactnotxt.TextLength < 11)
            {
                MessageBox.Show("The following phone number did not reach the 11-digit requirement.");
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String selection = "";
            String newkey = "";
            if (cmbbox_criteria.Text.Equals("First Name"))
            {
                selection = "FirstName";
                staff_acc = acc_cmd.SearchStaff(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }

            else if (cmbbox_criteria.Text.Equals("Last Name"))
            {
                selection = "LastName";
                staff_acc = acc_cmd.SearchStaff(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }

            else if (cmbbox_criteria.Text.Equals("Suffix"))
            {
                staff_acc = acc_cmd.SearchStaff("Suffix", inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }

            else if (cmbbox_criteria.Text.Equals("Position"))
            {
                staff_acc = acc_cmd.SearchStaff("Suffix", inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }

            else if (cmbbox_criteria.Text.Equals("E-mail Address"))
            {
                selection = "EMailAddress";
                staff_acc = acc_cmd.SearchStaff(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }

            else if (cmbbox_criteria.Text.Equals("Contact No."))
            {
                selection = "ContactNo";
                staff_acc = acc_cmd.SearchStaff(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }

            else if (cmbbox_criteria.Text.Equals("Username"))
            {
                selection = "username";
                staff_acc = acc_cmd.SearchStaff(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }

            else if (cmbbox_criteria.Text.Equals("Active Status"))
            {
                staff_acc = acc_cmd.SearchStaff("ActiveStatus", inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }
            if (cmbbox_criteria.SelectedIndex == 1)
            {
                selection = "MiddleName";
                String inp = inputsearchbar.Text;
                staff_acc = acc_cmd.SearchStaff(selection, inp);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }
            else if (cmbbox_criteria.SelectedIndex == 9)
            {
                selection = "ImgPath";
                String inp = inputsearchbar.Text;
                staff_acc = acc_cmd.SearchStaff(selection, inp);
                dgv_admin_acc_tbl.DataSource = staff_acc;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text.Length == 0 || middlenametxt.Text.Length == 0 || lastnametxt.Text.Length == 0 || emailtxt.Text.Length == 0 || contactnotxt.Text.Length == 0 || usernametxt.Text.Length == 0 || imgpathtxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left blank.\nPlease fill in the blank fields to successfully update a staff account.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (contactnotxt.Text.Length > 0)
            {
                String fn = firstnametxt.Text;
                String mn = middlenametxt.Text;
                String ln = lastnametxt.Text;
                String suf = suffixtxt.Text;
                String pos1 = positioncombobox.Text;
                String hier1 = hierarchylvltxt.Text;
                String numb = contactnotxt.Text;
                String email = emailtxt.Text;
                String un = usernametxt.Text;
                String pw = passwordtxt.Text;
                String img = imgpathtxt.Text;

                try
                {
                    String sfx;
                    if (passwordtxt.Text.Length == 0)
                    {
                        var dlg = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to update the specified record.\n\nFirst Name: " + fn + "\nMiddle Name: " + mn + "\nLast Name: " + ln + "\nSuffix: " + suf + "\nPosition: " + pos1 + "\nHierarchy Level: " + hier1 + "\nE-mail Address: " + email + "\nContact Number: " + numb + "\nUsername: " + un + "\nImage Path: " + img + "\n\nAre the following information correct?", "Confirmation for staff account updates", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dlg == DialogResult.Yes)
                        {
                            if (hierarchylvltxt.Text.Equals("Staff"))
                            {
                                String hier = "2";
                                if (positioncombobox.Text.Equals("Librarian I"))
                                {
                                    String pos = "1";
                                    if (dlg == DialogResult.Yes)
                                    {
                                        var test = acc_cmd.CompareSameUsernameStaff(usernametxt.Text);
                                        if (test.Count == 0) { }
                                        else { }
                                        if (suffixtxt.Text.Equals("N/A"))
                                        {
                                            sfx = "1";
                                            acc_cmd.UpdateStaff(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, imgpathtxt.Text);
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Sr."))
                                        {
                                            sfx = "2";
                                            acc_cmd.UpdateStaff(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, imgpathtxt.Text);
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Jr."))
                                        {
                                            sfx = "3";
                                            acc_cmd.UpdateStaff(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, imgpathtxt.Text);
                                            UpdateBinding();
                                        }
                                    }
                                    else { }
                                }
                                else if (positioncombobox.Text.Equals("Librarian II"))
                                {
                                    String pos = "2";
                                    if (dlg == DialogResult.Yes)
                                    {
                                        if (suffixtxt.Text.Equals("N/A"))
                                        {
                                            sfx = "1";
                                            acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Sr."))
                                        {
                                            sfx = "2";
                                            acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                            UpdateBinding();
                                        }
                                        else if (suffixtxt.Text.Equals("Jr."))
                                        {
                                            sfx = "3";
                                            acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                            UpdateBinding();
                                        }
                                    }
                                    else { }
                                }
                            }
                        }
                        else { }
                    }
                    else if (passwordtxt.Text.Length >= 8)
                    {
                        var dlg1 = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to update the specified record.\n\nFirst Name: " + fn + "\nMiddle Name: " + mn + "\nLast Name: " + ln + "\nPosition: " + pos1 + "\nHierarchy Level: " + hier1 + "\nE-mail Address: " + email + "\nContact Number: " + numb + "\nUsername: " + un + "\nPassword: " + pw + "\nImage Path: " + img + "\n\nAre the following information correct?", "Confirmation for staff account updates", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (hierarchylvltxt.Text.Equals("Staff"))
                        {
                            String hier = "2";
                            if (positioncombobox.Text.Equals("Librarian I"))
                            {
                                String pos = "1";
                                if (dlg1 == DialogResult.Yes)
                                {
                                    if (suffixtxt.Text.Equals("N/A"))
                                    {
                                        sfx = "1";
                                        acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                        UpdateBinding();
                                    }
                                    else if (suffixtxt.Text.Equals("Sr."))
                                    {
                                        sfx = "2";
                                        acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                        UpdateBinding();
                                    }
                                    else if (suffixtxt.Text.Equals("Jr."))
                                    {
                                        sfx = "3";
                                        acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                        UpdateBinding();
                                    }
                                }
                                else { }
                            }
                            else if (positioncombobox.Text.Equals("Librarian II"))
                            {
                                String pos = "2";
                                if (dlg1 == DialogResult.Yes)
                                {
                                    if (suffixtxt.Text.Equals("N/A"))
                                    {
                                        sfx = "1";
                                        acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                        UpdateBinding();
                                    }
                                    else if (suffixtxt.Text.Equals("Sr."))
                                    {
                                        sfx = "2";
                                        acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                        UpdateBinding();
                                    }
                                    else if (suffixtxt.Text.Equals("Jr."))
                                    {
                                        sfx = "3";
                                        acc_cmd.Update(idlbl.Text, firstnametxt.Text, middlenametxt.Text, lastnametxt.Text, sfx, pos, hier, emailtxt.Text, contactnotxt.Text, usernametxt.Text, passwordtxt.Text, imgpathtxt.Text, "2");
                                        UpdateBinding();
                                    }
                                }
                                else { }
                            }
                        }
                    }
                    else if (passwordtxt.Text.Length < 8)
                    {
                        MessageBox.Show("Please enter a password that is more than 8 characters.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!contactnotxt.Text.StartsWith("09"))
            {
                MessageBox.Show("The following phone number does not start with the following numbers: 09.");
            }
            else if (contactnotxt.TextLength < 11)
            {
                MessageBox.Show("The following phone number did not reach the 11-digit requirement.");
            }
            else
            {
                MessageBox.Show("This record of the system may not be able to proceed in updating due to either " +
                    "\none or some of the following reasons.\n\n" +
                    "1. An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only." +
                    "\n2. Enter a password that has more than 8 characters." +
                    "\n3. The following phone number does not start with the following numbers: 09." +
                    "\n4. The following phone number did not reach the 11-digit requirement.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            contactnotxt.Text = "09";
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
        }

        private void dgv_admin_acc_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;
            try
            {
                DataGridViewRow row = this.dgv_admin_acc_tbl.Rows[e.RowIndex];
                if (Properties.Settings.Default.loginusername.Equals(row.Cells["Username"].Value.ToString()))
                {
                    if (dgv_admin_acc_tbl.SelectedRows.Count >= 0)
                    {
                        idlbl.Text = row.Cells["id"].Value.ToString();
                        firstnametxt.Text = row.Cells["FirstName"].Value.ToString();
                        middlenametxt.Text = row.Cells["MiddleName"].Value.ToString();
                        lastnametxt.Text = row.Cells["LastName"].Value.ToString();
                        suffixtxt.Text = row.Cells["Suffix"].Value.ToString();
                        positioncombobox.Text = row.Cells["Position"].Value.ToString();
                        hierarchylvltxt.Text = row.Cells["EmpRoles"].Value.ToString();
                        emailtxt.Text = row.Cells["EmailAddress"].Value.ToString();
                        contactnotxt.Text = row.Cells["ContactNo"].Value.ToString();
                        usernametxt.Text = row.Cells["Username"].Value.ToString();
                        imgpathtxt.Text = row.Cells["ImgPath"].Value.ToString();
                    }
                }
                else
                {
                    clear();
                }
            }
            catch (Exception) { }
        }
    }
}

