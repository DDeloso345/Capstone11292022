
namespace Capstone
{
    partial class Staff_BackupAndRestore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbox_bckup_loc5 = new System.Windows.Forms.CheckBox();
            this.checkbox_bckup_loc4 = new System.Windows.Forms.CheckBox();
            this.checkbox_bckup_loc3 = new System.Windows.Forms.CheckBox();
            this.restore_btn = new System.Windows.Forms.Button();
            this.restore_browse_Btn = new System.Windows.Forms.Button();
            this.txtbox_restore_db_directory = new System.Windows.Forms.TextBox();
            this.btn_mnlbackup5 = new System.Windows.Forms.Button();
            this.btn_backupbrowse5 = new System.Windows.Forms.Button();
            this.backup_directory_txtbox5 = new System.Windows.Forms.TextBox();
            this.btn_mnlbackup4 = new System.Windows.Forms.Button();
            this.btn_backupbrowse4 = new System.Windows.Forms.Button();
            this.backup_directory_txtbox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.backup_directory_txtbox3 = new System.Windows.Forms.TextBox();
            this.backup_directory_txtbox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backup_directory_txtbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mnlbackup3 = new System.Windows.Forms.Button();
            this.btn_backupbrowse3 = new System.Windows.Forms.Button();
            this.btn_mnlbackup2 = new System.Windows.Forms.Button();
            this.btn_backupbrowse2 = new System.Windows.Forms.Button();
            this.btn_mnlbackup1 = new System.Windows.Forms.Button();
            this.btn_backupbrowse1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbox_bckup_loc5
            // 
            this.checkbox_bckup_loc5.AutoSize = true;
            this.checkbox_bckup_loc5.Location = new System.Drawing.Point(19, 289);
            this.checkbox_bckup_loc5.Name = "checkbox_bckup_loc5";
            this.checkbox_bckup_loc5.Size = new System.Drawing.Size(123, 17);
            this.checkbox_bckup_loc5.TabIndex = 101;
            this.checkbox_bckup_loc5.Text = "Backup Location #5";
            this.checkbox_bckup_loc5.UseVisualStyleBackColor = true;
            this.checkbox_bckup_loc5.CheckedChanged += new System.EventHandler(this.checkbox_bckup_loc5_CheckedChanged);
            // 
            // checkbox_bckup_loc4
            // 
            this.checkbox_bckup_loc4.AutoSize = true;
            this.checkbox_bckup_loc4.Location = new System.Drawing.Point(19, 249);
            this.checkbox_bckup_loc4.Name = "checkbox_bckup_loc4";
            this.checkbox_bckup_loc4.Size = new System.Drawing.Size(123, 17);
            this.checkbox_bckup_loc4.TabIndex = 100;
            this.checkbox_bckup_loc4.Text = "Backup Location #4";
            this.checkbox_bckup_loc4.UseVisualStyleBackColor = true;
            this.checkbox_bckup_loc4.CheckedChanged += new System.EventHandler(this.checkbox_bckup_loc4_CheckedChanged);
            // 
            // checkbox_bckup_loc3
            // 
            this.checkbox_bckup_loc3.AutoSize = true;
            this.checkbox_bckup_loc3.Location = new System.Drawing.Point(19, 208);
            this.checkbox_bckup_loc3.Name = "checkbox_bckup_loc3";
            this.checkbox_bckup_loc3.Size = new System.Drawing.Size(123, 17);
            this.checkbox_bckup_loc3.TabIndex = 99;
            this.checkbox_bckup_loc3.Text = "Backup Location #3";
            this.checkbox_bckup_loc3.UseVisualStyleBackColor = true;
            this.checkbox_bckup_loc3.CheckedChanged += new System.EventHandler(this.checkbox_bckup_loc3_CheckedChanged);
            // 
            // restore_btn
            // 
            this.restore_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restore_btn.Location = new System.Drawing.Point(885, 395);
            this.restore_btn.Name = "restore_btn";
            this.restore_btn.Size = new System.Drawing.Size(80, 35);
            this.restore_btn.TabIndex = 96;
            this.restore_btn.Text = "Restore";
            this.restore_btn.UseVisualStyleBackColor = true;
            this.restore_btn.Click += new System.EventHandler(this.restore_btn_Click);
            // 
            // restore_browse_Btn
            // 
            this.restore_browse_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restore_browse_Btn.Location = new System.Drawing.Point(787, 395);
            this.restore_browse_Btn.Name = "restore_browse_Btn";
            this.restore_browse_Btn.Size = new System.Drawing.Size(80, 35);
            this.restore_browse_Btn.TabIndex = 95;
            this.restore_browse_Btn.Text = "Browse...";
            this.restore_browse_Btn.UseVisualStyleBackColor = true;
            this.restore_browse_Btn.Click += new System.EventHandler(this.restore_browse_Btn_Click);
            // 
            // txtbox_restore_db_directory
            // 
            this.txtbox_restore_db_directory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_restore_db_directory.Location = new System.Drawing.Point(144, 403);
            this.txtbox_restore_db_directory.Name = "txtbox_restore_db_directory";
            this.txtbox_restore_db_directory.Size = new System.Drawing.Size(635, 20);
            this.txtbox_restore_db_directory.TabIndex = 94;
            // 
            // btn_mnlbackup5
            // 
            this.btn_mnlbackup5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mnlbackup5.Location = new System.Drawing.Point(885, 279);
            this.btn_mnlbackup5.Name = "btn_mnlbackup5";
            this.btn_mnlbackup5.Size = new System.Drawing.Size(80, 35);
            this.btn_mnlbackup5.TabIndex = 93;
            this.btn_mnlbackup5.Text = "Backup";
            this.btn_mnlbackup5.UseVisualStyleBackColor = true;
            this.btn_mnlbackup5.Click += new System.EventHandler(this.btn_mnlbackup5_Click);
            // 
            // btn_backupbrowse5
            // 
            this.btn_backupbrowse5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backupbrowse5.Location = new System.Drawing.Point(787, 279);
            this.btn_backupbrowse5.Name = "btn_backupbrowse5";
            this.btn_backupbrowse5.Size = new System.Drawing.Size(80, 35);
            this.btn_backupbrowse5.TabIndex = 92;
            this.btn_backupbrowse5.Text = "Browse...";
            this.btn_backupbrowse5.UseVisualStyleBackColor = true;
            this.btn_backupbrowse5.Click += new System.EventHandler(this.btn_backupbrowse5_Click);
            // 
            // backup_directory_txtbox5
            // 
            this.backup_directory_txtbox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_directory_txtbox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backup_directory_txtbox5.Location = new System.Drawing.Point(144, 287);
            this.backup_directory_txtbox5.Name = "backup_directory_txtbox5";
            this.backup_directory_txtbox5.ReadOnly = true;
            this.backup_directory_txtbox5.Size = new System.Drawing.Size(635, 20);
            this.backup_directory_txtbox5.TabIndex = 91;
            // 
            // btn_mnlbackup4
            // 
            this.btn_mnlbackup4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mnlbackup4.Location = new System.Drawing.Point(885, 238);
            this.btn_mnlbackup4.Name = "btn_mnlbackup4";
            this.btn_mnlbackup4.Size = new System.Drawing.Size(80, 35);
            this.btn_mnlbackup4.TabIndex = 90;
            this.btn_mnlbackup4.Text = "Backup";
            this.btn_mnlbackup4.UseVisualStyleBackColor = true;
            this.btn_mnlbackup4.Click += new System.EventHandler(this.btn_mnlbackup4_Click);
            // 
            // btn_backupbrowse4
            // 
            this.btn_backupbrowse4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backupbrowse4.Location = new System.Drawing.Point(787, 238);
            this.btn_backupbrowse4.Name = "btn_backupbrowse4";
            this.btn_backupbrowse4.Size = new System.Drawing.Size(80, 35);
            this.btn_backupbrowse4.TabIndex = 89;
            this.btn_backupbrowse4.Text = "Browse...";
            this.btn_backupbrowse4.UseVisualStyleBackColor = true;
            this.btn_backupbrowse4.Click += new System.EventHandler(this.btn_backupbrowse4_Click);
            // 
            // backup_directory_txtbox4
            // 
            this.backup_directory_txtbox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_directory_txtbox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backup_directory_txtbox4.Location = new System.Drawing.Point(144, 246);
            this.backup_directory_txtbox4.Name = "backup_directory_txtbox4";
            this.backup_directory_txtbox4.ReadOnly = true;
            this.backup_directory_txtbox4.Size = new System.Drawing.Size(635, 20);
            this.backup_directory_txtbox4.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "RESTORE DATABASE:";
            // 
            // backup_directory_txtbox3
            // 
            this.backup_directory_txtbox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_directory_txtbox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backup_directory_txtbox3.Location = new System.Drawing.Point(144, 205);
            this.backup_directory_txtbox3.Name = "backup_directory_txtbox3";
            this.backup_directory_txtbox3.ReadOnly = true;
            this.backup_directory_txtbox3.Size = new System.Drawing.Size(635, 20);
            this.backup_directory_txtbox3.TabIndex = 86;
            // 
            // backup_directory_txtbox2
            // 
            this.backup_directory_txtbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_directory_txtbox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backup_directory_txtbox2.Location = new System.Drawing.Point(144, 164);
            this.backup_directory_txtbox2.Name = "backup_directory_txtbox2";
            this.backup_directory_txtbox2.ReadOnly = true;
            this.backup_directory_txtbox2.Size = new System.Drawing.Size(635, 20);
            this.backup_directory_txtbox2.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Backup Location #2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Restore Backup File:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Backup Location #1";
            // 
            // backup_directory_txtbox1
            // 
            this.backup_directory_txtbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backup_directory_txtbox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backup_directory_txtbox1.Location = new System.Drawing.Point(144, 123);
            this.backup_directory_txtbox1.Name = "backup_directory_txtbox1";
            this.backup_directory_txtbox1.ReadOnly = true;
            this.backup_directory_txtbox1.Size = new System.Drawing.Size(635, 20);
            this.backup_directory_txtbox1.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "BACKUP DATABASE:";
            // 
            // btn_mnlbackup3
            // 
            this.btn_mnlbackup3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mnlbackup3.Location = new System.Drawing.Point(885, 197);
            this.btn_mnlbackup3.Name = "btn_mnlbackup3";
            this.btn_mnlbackup3.Size = new System.Drawing.Size(80, 35);
            this.btn_mnlbackup3.TabIndex = 79;
            this.btn_mnlbackup3.Text = "Backup";
            this.btn_mnlbackup3.UseVisualStyleBackColor = true;
            this.btn_mnlbackup3.Click += new System.EventHandler(this.btn_mnlbackup3_Click);
            // 
            // btn_backupbrowse3
            // 
            this.btn_backupbrowse3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backupbrowse3.Location = new System.Drawing.Point(787, 197);
            this.btn_backupbrowse3.Name = "btn_backupbrowse3";
            this.btn_backupbrowse3.Size = new System.Drawing.Size(80, 35);
            this.btn_backupbrowse3.TabIndex = 78;
            this.btn_backupbrowse3.Text = "Browse...";
            this.btn_backupbrowse3.UseVisualStyleBackColor = true;
            this.btn_backupbrowse3.Click += new System.EventHandler(this.btn_backupbrowse3_Click);
            // 
            // btn_mnlbackup2
            // 
            this.btn_mnlbackup2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mnlbackup2.Location = new System.Drawing.Point(885, 156);
            this.btn_mnlbackup2.Name = "btn_mnlbackup2";
            this.btn_mnlbackup2.Size = new System.Drawing.Size(80, 35);
            this.btn_mnlbackup2.TabIndex = 77;
            this.btn_mnlbackup2.Text = "Backup";
            this.btn_mnlbackup2.UseVisualStyleBackColor = true;
            this.btn_mnlbackup2.Click += new System.EventHandler(this.btn_mnlbackup2_Click);
            // 
            // btn_backupbrowse2
            // 
            this.btn_backupbrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backupbrowse2.Location = new System.Drawing.Point(787, 156);
            this.btn_backupbrowse2.Name = "btn_backupbrowse2";
            this.btn_backupbrowse2.Size = new System.Drawing.Size(80, 35);
            this.btn_backupbrowse2.TabIndex = 76;
            this.btn_backupbrowse2.Text = "Browse...";
            this.btn_backupbrowse2.UseVisualStyleBackColor = true;
            this.btn_backupbrowse2.Click += new System.EventHandler(this.btn_backupbrowse2_Click);
            // 
            // btn_mnlbackup1
            // 
            this.btn_mnlbackup1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mnlbackup1.Location = new System.Drawing.Point(885, 112);
            this.btn_mnlbackup1.Name = "btn_mnlbackup1";
            this.btn_mnlbackup1.Size = new System.Drawing.Size(80, 40);
            this.btn_mnlbackup1.TabIndex = 75;
            this.btn_mnlbackup1.Text = "Backup";
            this.btn_mnlbackup1.UseVisualStyleBackColor = true;
            this.btn_mnlbackup1.Click += new System.EventHandler(this.btn_mnlbackup1_Click);
            // 
            // btn_backupbrowse1
            // 
            this.btn_backupbrowse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backupbrowse1.Location = new System.Drawing.Point(787, 112);
            this.btn_backupbrowse1.Name = "btn_backupbrowse1";
            this.btn_backupbrowse1.Size = new System.Drawing.Size(80, 40);
            this.btn_backupbrowse1.TabIndex = 74;
            this.btn_backupbrowse1.Text = "Browse...";
            this.btn_backupbrowse1.UseVisualStyleBackColor = true;
            this.btn_backupbrowse1.Click += new System.EventHandler(this.btn_backupbrowse1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(984, 46);
            this.label2.TabIndex = 102;
            this.label2.Text = "BACKUP AND RESTORE";
            // 
            // Staff_BackupAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkbox_bckup_loc5);
            this.Controls.Add(this.checkbox_bckup_loc4);
            this.Controls.Add(this.checkbox_bckup_loc3);
            this.Controls.Add(this.restore_btn);
            this.Controls.Add(this.restore_browse_Btn);
            this.Controls.Add(this.txtbox_restore_db_directory);
            this.Controls.Add(this.btn_mnlbackup5);
            this.Controls.Add(this.btn_backupbrowse5);
            this.Controls.Add(this.backup_directory_txtbox5);
            this.Controls.Add(this.btn_mnlbackup4);
            this.Controls.Add(this.btn_backupbrowse4);
            this.Controls.Add(this.backup_directory_txtbox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.backup_directory_txtbox3);
            this.Controls.Add(this.backup_directory_txtbox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backup_directory_txtbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mnlbackup3);
            this.Controls.Add(this.btn_backupbrowse3);
            this.Controls.Add(this.btn_mnlbackup2);
            this.Controls.Add(this.btn_backupbrowse2);
            this.Controls.Add(this.btn_mnlbackup1);
            this.Controls.Add(this.btn_backupbrowse1);
            this.Name = "Staff_BackupAndRestore";
            this.Text = "Backup and Restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_BackupAndRestore_FormClosing);
            this.Load += new System.EventHandler(this.Staff_BackupAndRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkbox_bckup_loc5;
        private System.Windows.Forms.CheckBox checkbox_bckup_loc4;
        private System.Windows.Forms.CheckBox checkbox_bckup_loc3;
        private System.Windows.Forms.Button restore_btn;
        private System.Windows.Forms.Button restore_browse_Btn;
        private System.Windows.Forms.TextBox txtbox_restore_db_directory;
        private System.Windows.Forms.Button btn_mnlbackup5;
        private System.Windows.Forms.Button btn_backupbrowse5;
        private System.Windows.Forms.TextBox backup_directory_txtbox5;
        private System.Windows.Forms.Button btn_mnlbackup4;
        private System.Windows.Forms.Button btn_backupbrowse4;
        private System.Windows.Forms.TextBox backup_directory_txtbox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox backup_directory_txtbox3;
        private System.Windows.Forms.TextBox backup_directory_txtbox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox backup_directory_txtbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mnlbackup3;
        private System.Windows.Forms.Button btn_backupbrowse3;
        private System.Windows.Forms.Button btn_mnlbackup2;
        private System.Windows.Forms.Button btn_backupbrowse2;
        private System.Windows.Forms.Button btn_mnlbackup1;
        private System.Windows.Forms.Button btn_backupbrowse1;
        private System.Windows.Forms.Label label2;
    }
}