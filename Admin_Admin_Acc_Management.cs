using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Admin_Admin_Acc_Management : Form
    {
        public Admin_Admin_Acc_Management()
        {
            InitializeComponent();
        }
        List<AccountDetails_Get> acc = new List<AccountDetails_Get>();
        SQLAccountManagementCommands acc_cmd = new SQLAccountManagementCommands();
        SQLAdminCommandsClass admin_cmd = new SQLAdminCommandsClass();

        private void Admin_Admin_Acc_Management_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            suffixtxt.SelectedIndex = 0;
            cmbbox_criteria.SelectedIndex = 0;
            positioncombobox.SelectedIndex = 0;
            hierarchylvltxt.SelectedIndex = 0;
        }
        public void ComboBoxSel()
        {
            if (hierarchylvltxt.Text.Equals("Administrator"))
            {
                positioncombobox.Items.Clear();
                String[] list = new String[2];
                list[0] = "Librarian III";
                list[1] = "Librarian IV";
                positioncombobox.Items.AddRange(list);
            }
            else if (hierarchylvltxt.Text.Equals("Staff"))
            {
                positioncombobox.Items.Clear();
                String[] list = new String[2];
                list[0] = "Librarian I";
                list[1] = "Librarian II";
                positioncombobox.Items.AddRange(list);
            }
        }
        public void UpdateBinding()
        {
            acc = admin_cmd.LoadAdminData();
            dgv_admin_acc_tbl.DataSource = acc;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            btn_update.Enabled = false;
            btn_delete.Enabled = false;

            idlbl.Text = "[ID Txt]";
            firstnametxt.Text = "";
            middlenametxt.Text = "";
            lastnametxt.Text = "";
            emailtxt.Text = "";
            contactnotxt.Text = "09";
            usernametxt.Text = "";
            passwordtxt.Text = "";
        }
        public void DisableBtnAdmin()
        {
            if (idlbl.Text.Equals("1"))
            {
                btn_insert.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
            else
            {
                btn_insert.Enabled = true;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text.Length == 0 || middlenametxt.Text.Length == 0 || lastnametxt.Text.Length == 0 || emailtxt.Text.Length == 0 || contactnotxt.Text.Length == 0 || usernametxt.Text.Length == 0 || passwordtxt.Text.Length == 0 || imgpathtxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left blank.\nPlease fill in the blank fields to successfully add an administrator account.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (contactnotxt.Text.Length > 0)
            {
                String fn = firstnametxt.Text;
                String mn = middlenametxt.Text;
                String ln = lastnametxt.Text;
                String suf = suffixtxt.Text;
                String numb = contactnotxt.Text;
                String email = emailtxt.Text;
                String pos1 = positioncombobox.Text;
                String hier1 = hierarchylvltxt.Text;
                String un = usernametxt.Text;
                String pw = passwordtxt.Text;
                String imgpath = imgpathtxt.Text;
                var dlg = MessageBox.Show("Please check the following information for any errors\nbefore proceeding to insert the specified record.\n\nFirst Name: " + fn + "\nMiddle Name: " + mn + "\nLast Name: " + ln + "\nSuffix: " + suf + "\nPosition: " + pos1 + "\nHierarchy Level: " + hier1 + "\nE-mail Address: " + email + "\nContact Number: " + numb + "\nUsername: " + un + "\nPassword: " + pw + "\nImage Path: " + imgpath + "\n\nAre the following information correct?", "Confirmation for administrator account entries", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (hierarchylvltxt.Text.Equals("Administrator"))
                {
                    String hier = "1";

                    if (positioncombobox.Text.Equals("Librarian III"))
                    {
                        String pos = "3";
                        try
                        {
                            var test = acc_cmd.CompareSameUsernameAdmin(usernametxt.Text);
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
                            else
                            {
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (positioncombobox.Text.Equals("Librarian IV"))
                    {
                        String pos = "4";
                        try
                        {
                            var test = acc_cmd.CompareSameUsernameAdmin(usernametxt.Text);
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
                            else
                            {
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (hierarchylvltxt.Text.Equals("Staff"))
                {
                    String hier = "2";
                    if (positioncombobox.Text.Equals("Librarian I"))
                    {
                        String pos = "1";
                        try
                        {
                            var test = acc_cmd.CompareSameUsernameAdmin(usernametxt.Text);
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
                    else if (positioncombobox.Text.Equals("Librarian II"))
                    {
                        String pos = "2";
                        try
                        {
                            var test = acc_cmd.CompareSameUsernameAdmin(usernametxt.Text);
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
                            else
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
                acc = acc_cmd.SearchAdmin(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }

            else if (cmbbox_criteria.Text.Equals("Last Name"))
            {
                selection = "LastName";
                acc = acc_cmd.SearchAdmin(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }

            else if (cmbbox_criteria.Text.Equals("Suffix"))
            {
                acc = acc_cmd.SearchAdmin("Suffix", inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Position"))
            {
                acc = acc_cmd.SearchAdmin("Position", inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("E-mail Address"))
            {
                selection = "EMailAddress";
                acc = acc_cmd.SearchAdmin(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Contact No."))
            {
                selection = "ContactNo";
                acc = acc_cmd.SearchAdmin(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Username"))
            {
                selection = "username";
                acc = acc_cmd.SearchAdmin(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Password"))
            {
                selection = "password";
                acc = acc_cmd.SearchAdmin(selection, inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }

            else if (cmbbox_criteria.Text.Equals("Active Status"))
            {
                acc = acc_cmd.SearchAdmin("ActiveStatus", inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }

            if (cmbbox_criteria.SelectedIndex == 1)
            {
                selection = "MiddleName";
                String inp = inputsearchbar.Text;
                acc = acc_cmd.SearchAdmin(selection, inp);
                dgv_admin_acc_tbl.DataSource = acc;
            }
            else if (cmbbox_criteria.Text.Equals("Image Path"))
            {
                selection = "ImgPath";
                String inp = inputsearchbar.Text;
                acc = acc_cmd.SearchAdmin("ImgPath", inputsearchbar.Text);
                dgv_admin_acc_tbl.DataSource = acc;
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text.Length == 0 || middlenametxt.Text.Length == 0 || lastnametxt.Text.Length == 0 || emailtxt.Text.Length == 0 || contactnotxt.Text.Length == 0 || usernametxt.Text.Length == 0 || passwordtxt.TextLength == 0 || imgpathtxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left blank.\nPlease fill in the blank fields to successfully delete an administrator account.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (contactnotxt.TextLength > 0)
            {
                try
                {
                    String fn = firstnametxt.Text;
                    String mn = middlenametxt.Text;
                    String ln = lastnametxt.Text;
                    String suf = suffixtxt.Text;
                    String pos = positioncombobox.Text;
                    String hier = hierarchylvltxt.Text;
                    String numb = contactnotxt.Text;
                    String email = emailtxt.Text;
                    String un = usernametxt.Text;
                    String pw = passwordtxt.Text;
                    DialogResult dialog = MessageBox.Show("Please check the following information if it is to be deleted.\n\nFirst Name: " + fn + "\nMiddle Name: " + mn + "\nLast Name: " + ln + "\nSuffix: " + suf + "\nPosition: " + pos + "\nHierarchy Level: " + hier + "\nE-mail Address: " + email + "\nContact Number: " + numb + "\nUsername: " + un + "\nPassword: " + pw + "\n\nAre the following information correct?", "Confirmation for administrator account deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        acc_cmd.Delete(idlbl.Text);
                        clear();
                        UpdateBinding();
                    }
                    else
                    {
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

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text.Length == 0 || middlenametxt.Text.Length == 0 || lastnametxt.Text.Length == 0 || emailtxt.Text.Length == 0 || contactnotxt.Text.Length == 0 || usernametxt.Text.Length == 0 || imgpathtxt.Text.Length == 0)
            {
                MessageBox.Show("One or more of the fields have been left blank.\nPlease fill in the blank fields to successfully update an administrator account.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (contactnotxt.Text.Length > 0 && passwordtxt.Text.Length > 8)
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
                    String sfx;
                    if (hierarchylvltxt.Text.Equals("Administrator"))
                    {
                        String hier = "1";
                        if (positioncombobox.Text.Equals("Librarian III"))
                        {
                            String pos = "3";
                            if (dlg == DialogResult.Yes)
                            {
                                var test = acc_cmd.Upd_CompareSameUsernameAdmin(idlbl.Text, usernametxt.Text);
                                if (test.Count == 0)
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
                            else { }
                        }
                        else if (positioncombobox.Text.Equals("Librarian IV"))
                        {
                            String pos = "4";
                            if (dlg == DialogResult.Yes)
                            {
                                var test = acc_cmd.Upd_CompareSameUsernameAdmin(idlbl.Text, usernametxt.Text);
                                if (test.Count == 0)
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
                            else { }
                        }
                    }
                    else if (hierarchylvltxt.Text.Equals("Staff"))
                    {
                        String hier = "2";
                        if (positioncombobox.Text.Equals("Librarian I"))
                        {
                            String pos = "1";
                            if (dlg == DialogResult.Yes)
                            {
                                var test = acc_cmd.Upd_CompareSameUsernameAdmin(idlbl.Text, usernametxt.Text);
                                if (test.Count == 0)
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
                            else { }
                        }
                        else if (positioncombobox.Text.Equals("Librarian II"))
                        {
                            String pos = "2";
                            if (dlg == DialogResult.Yes)
                            {
                                var test = acc_cmd.Upd_CompareSameUsernameAdmin(idlbl.Text, usernametxt.Text);
                                if (test.Count == 0)
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
                            else { }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only.\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (passwordtxt.Text.Length < 8)
            {
                MessageBox.Show("Please enter a password that has more than 8 characters.");
            }
            else if (!contactnotxt.Text.StartsWith("09"))
            {
                MessageBox.Show("The following phone number does not start with the following numbers: 09.");
            }
            else if (contactnotxt.TextLength < 11)
            {
                MessageBox.Show("The following phone number did not reach the 11-digit requirement.");
            }
            /*else {
                MessageBox.Show("This record of the system may not be able to proceed in updating due to either " +
                    "\none or some of the following reasons.\n\n" +
                    "1. An invalid character has been detected in the contact number text field.\nPlease try to use numeric characters only." +
                    "\n2. Enter a password that has more than 8 characters." +
                    "\n3. The following phone number does not start with the following numbers: 09." +
                    "\n4. The following phone number did not reach the 11-digit requirement.", "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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

        private void cmbbox_criteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
            if (cmbbox_criteria.Text.Equals("Contact No."))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void inputsearchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void hierarchylvltxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            positioncombobox.SelectedIndex = 0;
            ComboBoxSel();
            positioncombobox.SelectedIndex = 0;
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

        private void dgv_admin_acc_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            if (dgv_admin_acc_tbl.SelectedRows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgv_admin_acc_tbl.Rows[e.RowIndex];
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
                    passwordtxt.Text = row.Cells["Password"].Value.ToString();
                    imgpathtxt.Text = row.Cells["ImgPath"].Value.ToString();
                    DisableBtnAdmin();
                }
                catch (Exception) { }
            }
        }
    }
}
