using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Admin_BackupAndRestore : Form
    {
        public Admin_BackupAndRestore()
        {
            InitializeComponent();
            CheckBoxEnableDisable();
        }


        private void BackupAndRestore_Load(object sender, EventArgs e)
        {
            backup_directory_txtbox1.Text = Properties.Settings.Default.backupdirectory1;
            backup_directory_txtbox2.Text = Properties.Settings.Default.backupdirectory2;
            if (backup_directory_txtbox1.Text == String.Empty)
            {
                backup_directory_txtbox1.Text = @"C:\LIS Backup Directory 1\";
                DirectoryInfo dir_txtbox1 = new DirectoryInfo(@"C:\LIS Backup Directory 1\");
                try
                {
                    if (!dir_txtbox1.Exists)
                    {
                        dir_txtbox1.Create();
                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Folder cannot be created due to " + Convert.ToString(ex));
                }
            }
            if (backup_directory_txtbox2.Text == String.Empty)
            {
                backup_directory_txtbox2.Text = @"C:\LIS Backup Directory 2\";
                DirectoryInfo dir_txtbox2 = new DirectoryInfo(@"C:\LIS Backup Directory 2\");
                try
                {
                    if (!dir_txtbox2.Exists)
                    {
                        dir_txtbox2.Create();
                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Folder cannot be created due to " + ex);
                }
            }

            backup_directory_txtbox3.Text = Properties.Settings.Default.admin_backupdirectory3;
            backup_directory_txtbox4.Text = Properties.Settings.Default.admin_backupdirectory4;
            backup_directory_txtbox5.Text = Properties.Settings.Default.admin_backupdirectory5;
            checkbox_bckup_loc3.Checked = Properties.Settings.Default.admin_chkboxbackupdir3;
            checkbox_bckup_loc4.Checked = Properties.Settings.Default.admin_chkboxbackupdir4;
            checkbox_bckup_loc5.Checked = Properties.Settings.Default.admin_chkboxbackupdir5;
        }
        private void CheckBoxEnableDisable()
        {
            if (checkbox_bckup_loc3.Checked)
            {
                btn_backupbrowse3.Enabled = true;
                btn_mnlbackup3.Enabled = true;
            }
            else if (!checkbox_bckup_loc3.Checked)
            {
                btn_backupbrowse3.Enabled = false;
                btn_mnlbackup3.Enabled = false;
            }
            if (checkbox_bckup_loc4.Checked)
            {
                btn_backupbrowse4.Enabled = true;
                btn_mnlbackup4.Enabled = true;
            }
            else if (!checkbox_bckup_loc4.Checked)
            {
                btn_backupbrowse4.Enabled = false;
                btn_mnlbackup4.Enabled = false;
            }
            if (checkbox_bckup_loc5.Checked)
            {
                btn_backupbrowse5.Enabled = true;
                btn_mnlbackup5.Enabled = true;
            }
            else if (!checkbox_bckup_loc5.Checked)
            {
                btn_backupbrowse5.Enabled = false;
                btn_mnlbackup5.Enabled = false;
            }
        }
        private void checkbox_bckup_loc3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_bckup_loc3.Checked)
            {
                btn_backupbrowse3.Enabled = false;
                btn_mnlbackup3.Enabled = false;
            }
            else
            {
                btn_backupbrowse3.Enabled = true;
                btn_mnlbackup3.Enabled = true;
            }
        }

        private void checkbox_bckup_loc4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_bckup_loc4.Checked)
            {
                btn_backupbrowse4.Enabled = false;
                btn_mnlbackup4.Enabled = false;
            }
            else
            {
                btn_backupbrowse4.Enabled = true;
                btn_mnlbackup4.Enabled = true;
            }
        }

        private void checkbox_bckup_loc5_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_bckup_loc5.Checked)
            {
                btn_backupbrowse5.Enabled = false;
                btn_mnlbackup5.Enabled = false;
            }
            else
            {
                btn_backupbrowse5.Enabled = true;
                btn_mnlbackup5.Enabled = true;
            }
        }

        private void BackupAndRestore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.admin_backupdirectory1 = backup_directory_txtbox1.Text;
            Properties.Settings.Default.admin_backupdirectory2 = backup_directory_txtbox2.Text;
            Properties.Settings.Default.admin_backupdirectory3 = backup_directory_txtbox3.Text;
            Properties.Settings.Default.admin_backupdirectory4 = backup_directory_txtbox4.Text;
            Properties.Settings.Default.admin_backupdirectory5 = backup_directory_txtbox5.Text;
            Properties.Settings.Default.admin_chkboxbackupdir3 = checkbox_bckup_loc3.Checked;
            Properties.Settings.Default.admin_chkboxbackupdir4 = checkbox_bckup_loc4.Checked;
            Properties.Settings.Default.admin_chkboxbackupdir5 = checkbox_bckup_loc5.Checked;
            Properties.Settings.Default.Save();
        }

        private void btn_backupbrowse1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                backup_directory_txtbox1.Text = dialog.FileName + @"\";
            }
        }

        private void btn_backupbrowse2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                backup_directory_txtbox2.Text = dialog.FileName + @"\";
            }
        }

        private void btn_backupbrowse3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                backup_directory_txtbox3.Text = dialog.FileName + @"\";
            }
        }

        private void btn_backupbrowse4_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                backup_directory_txtbox4.Text = dialog.FileName + @"\";
            }
        }

        private void btn_backupbrowse5_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                backup_directory_txtbox5.Text = dialog.FileName + @"\";
            }
        }

        private void btn_mnlbackup1_Click(object sender, EventArgs e)
        {
            String date_time_now = Convert.ToString(DateTime.Now);
            String newStr = date_time_now.Replace("/", "-").Replace(":", ".");
            DirectoryInfo dir_txtbox1 = new DirectoryInfo(backup_directory_txtbox1.Text + newStr);

            String newDir_1 = backup_directory_txtbox1.Text + newStr + @"\";
            SQLBackupAndRestoreCommandsClass cmd = new SQLBackupAndRestoreCommandsClass();

            if (backup_directory_txtbox1.Text == String.Empty)
            {
                MessageBox.Show("Please specify the directory of the database before proceeding to back up the current instance of the database.");
            }
            else
            {
                dir_txtbox1.Create();
                cmd.ManualBackUpButton(newDir_1);
                MessageBox.Show("Succesfully backed up the said instance of the database in the specified directory.");
            }
        }

        private void btn_mnlbackup2_Click(object sender, EventArgs e)
        {
            String date_time_now = Convert.ToString(DateTime.Now);
            String newStr = date_time_now.Replace("/", "-").Replace(":", ".");
            DirectoryInfo dir_txtbox2 = new DirectoryInfo(backup_directory_txtbox2.Text + newStr);

            String newDir_2 = backup_directory_txtbox2.Text + newStr + @"\";
            SQLBackupAndRestoreCommandsClass cmd = new SQLBackupAndRestoreCommandsClass();
            if (backup_directory_txtbox2.Text == String.Empty)
            {
                MessageBox.Show("Please specify the directory of the database before proceeding to back up the current instance of the database.");
            }
            else
            {
                dir_txtbox2.Create();
                cmd.ManualBackUpButton(newDir_2);
                MessageBox.Show("Succesfully backed up the said instance of the database in the specified directory.");
            }
        }

        private void btn_mnlbackup3_Click(object sender, EventArgs e)
        {
            String date_time_now = Convert.ToString(DateTime.Now);
            String newStr = date_time_now.Replace("/", "-").Replace(":", ".");
            DirectoryInfo dir_txtbox3 = new DirectoryInfo(backup_directory_txtbox3.Text + newStr);

            String newDir_3 = backup_directory_txtbox3.Text + newStr + @"\";
            SQLBackupAndRestoreCommandsClass cmd = new SQLBackupAndRestoreCommandsClass();
            if (backup_directory_txtbox3.Text == String.Empty)
            {
                MessageBox.Show("Please specify the directory of the database before proceeding to back up the current instance of the database.");
            }
            else
            {
                dir_txtbox3.Create();
                cmd.ManualBackUpButton(newDir_3);
                MessageBox.Show("Succesfully backed up the said instance of the database in the specified directory.");
            }
        }

        private void btn_mnlbackup4_Click(object sender, EventArgs e)
        {
            String date_time_now = Convert.ToString(DateTime.Now);
            String newStr = date_time_now.Replace("/", "-").Replace(":", ".");
            DirectoryInfo dir_txtbox4 = new DirectoryInfo(backup_directory_txtbox4.Text + newStr);

            String newDir_4 = backup_directory_txtbox4.Text + newStr + @"\";
            SQLBackupAndRestoreCommandsClass cmd = new SQLBackupAndRestoreCommandsClass();
            if (backup_directory_txtbox4.Text == String.Empty)
            {
                MessageBox.Show("Please specify the directory of the database before proceeding to back up the current instance of the database.");
            }
            else
            {
                dir_txtbox4.Create();
                cmd.ManualBackUpButton(newDir_4);
                MessageBox.Show("Succesfully backed up the said instance of the database in the specified directory.");
            }
        }

        private void btn_mnlbackup5_Click(object sender, EventArgs e)
        {
            String date_time_now = Convert.ToString(DateTime.Now);
            String newStr = date_time_now.Replace("/", "-").Replace(":", ".");
            DirectoryInfo dir_txtbox5 = new DirectoryInfo(backup_directory_txtbox5.Text + newStr);

            String newDir_5 = backup_directory_txtbox5.Text + newStr + @"\";
            SQLBackupAndRestoreCommandsClass cmd = new SQLBackupAndRestoreCommandsClass();
            if (backup_directory_txtbox5.Text == String.Empty)
            {
                MessageBox.Show("Please specify the directory of the database before proceeding to back up the current instance of the database.");
            }
            else
            {
                dir_txtbox5.Create();
                cmd.ManualBackUpButton(newDir_5);
                MessageBox.Show("Succesfully backed up the said instance of the database in the specified directory.");
            }
        }

        private void restore_browse_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All Files (*.*)|*.*|.Bak Files (*.bak)|*.bak";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                txtbox_restore_db_directory.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("No file has been selected.");
            }
        }

        private void restore_btn_Click(object sender, EventArgs e)
        {
            var confirmDialog = MessageBox.Show("Are you sure to restore the said instance of the database specified in the directory without backing up the current instance?", "Restore Confirmation", MessageBoxButtons.YesNo);
            CommonOpenFileDialog backupCurrentInstance = new CommonOpenFileDialog();
            backupCurrentInstance.IsFolderPicker = true;
            if (confirmDialog == DialogResult.Yes)
            {
                try
                {
                    if (txtbox_restore_db_directory.Text == String.Empty)
                    {
                        MessageBox.Show("Please navigate select the file of the database to be restored.");
                    }
                    String date_time_now = Convert.ToString(DateTime.Now);
                    String newStr = date_time_now.Replace("/", "-").Replace(":", ".");
                    DirectoryInfo dir_txtbox1 = new DirectoryInfo(txtbox_restore_db_directory.Text + newStr);

                    String restoreDir = txtbox_restore_db_directory.Text + newStr + @"\";
                    SQLBackupAndRestoreCommandsClass cmd = new SQLBackupAndRestoreCommandsClass();
                    cmd.RestoreBackupButton(txtbox_restore_db_directory.Text);
                    MessageBox.Show("The selected database backup has been restored successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            else if (confirmDialog == DialogResult.No)
            {
                MessageBox.Show("no");
            }
        }


    }
}
