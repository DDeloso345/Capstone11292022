
namespace Capstone
{
    partial class Staff_LibrarianUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_LibrarianUI));
            this.LibrarianStaff_UISubPanel = new System.Windows.Forms.Panel();
            this.act_mngmt_submenu = new System.Windows.Forms.Panel();
            this.btn_member_mgmt = new System.Windows.Forms.Button();
            this.btn_client_mgmt = new System.Windows.Forms.Button();
            this.btn_lib_dashboard = new System.Windows.Forms.Button();
            this.btn_lib_book_mngmt = new System.Windows.Forms.Button();
            this.btn_bkborrow = new System.Windows.Forms.Button();
            this.btn_account_mngmt = new System.Windows.Forms.Button();
            this.picturebox_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.librarianstaff_sidepanel = new System.Windows.Forms.Panel();
            this.rep_charts_submenu = new System.Windows.Forms.Panel();
            this.ClientLogbookReport = new System.Windows.Forms.Button();
            this.BookInvReport = new System.Windows.Forms.Button();
            this.BorrowedBooksReport = new System.Windows.Forms.Button();
            this.MemberFreqReport = new System.Windows.Forms.Button();
            this.repcharts_btn = new System.Windows.Forms.Button();
            this.backuprestore_btn_sidepanel = new System.Windows.Forms.Button();
            this.bookreturnsbtn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.act_mngmt_submenu.SuspendLayout();
            this.picturebox_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.librarianstaff_sidepanel.SuspendLayout();
            this.rep_charts_submenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibrarianStaff_UISubPanel
            // 
            this.LibrarianStaff_UISubPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LibrarianStaff_UISubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibrarianStaff_UISubPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LibrarianStaff_UISubPanel.Location = new System.Drawing.Point(180, 0);
            this.LibrarianStaff_UISubPanel.Name = "LibrarianStaff_UISubPanel";
            this.LibrarianStaff_UISubPanel.Size = new System.Drawing.Size(1004, 661);
            this.LibrarianStaff_UISubPanel.TabIndex = 1;
            this.LibrarianStaff_UISubPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LibrarianStaff_UISubPanel_Paint);
            // 
            // act_mngmt_submenu
            // 
            this.act_mngmt_submenu.Controls.Add(this.btn_member_mgmt);
            this.act_mngmt_submenu.Controls.Add(this.btn_client_mgmt);
            this.act_mngmt_submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.act_mngmt_submenu.Location = new System.Drawing.Point(0, 240);
            this.act_mngmt_submenu.Name = "act_mngmt_submenu";
            this.act_mngmt_submenu.Size = new System.Drawing.Size(180, 70);
            this.act_mngmt_submenu.TabIndex = 5;
            // 
            // btn_member_mgmt
            // 
            this.btn_member_mgmt.FlatAppearance.BorderSize = 0;
            this.btn_member_mgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member_mgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_member_mgmt.ForeColor = System.Drawing.Color.PaleGreen;
            this.btn_member_mgmt.Location = new System.Drawing.Point(0, 36);
            this.btn_member_mgmt.Name = "btn_member_mgmt";
            this.btn_member_mgmt.Size = new System.Drawing.Size(176, 30);
            this.btn_member_mgmt.TabIndex = 12;
            this.btn_member_mgmt.Text = "Member Account Management";
            this.btn_member_mgmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_member_mgmt.UseVisualStyleBackColor = true;
            this.btn_member_mgmt.Click += new System.EventHandler(this.btn_member_mgmt_Click);
            // 
            // btn_client_mgmt
            // 
            this.btn_client_mgmt.FlatAppearance.BorderSize = 0;
            this.btn_client_mgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client_mgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client_mgmt.ForeColor = System.Drawing.Color.PaleGreen;
            this.btn_client_mgmt.Location = new System.Drawing.Point(1, 0);
            this.btn_client_mgmt.Name = "btn_client_mgmt";
            this.btn_client_mgmt.Size = new System.Drawing.Size(176, 30);
            this.btn_client_mgmt.TabIndex = 11;
            this.btn_client_mgmt.Text = "Staff Account Management";
            this.btn_client_mgmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client_mgmt.UseVisualStyleBackColor = true;
            this.btn_client_mgmt.Click += new System.EventHandler(this.btn_client_mgmt_Click);
            // 
            // btn_lib_dashboard
            // 
            this.btn_lib_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lib_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_lib_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lib_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lib_dashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_lib_dashboard.Location = new System.Drawing.Point(0, 180);
            this.btn_lib_dashboard.Name = "btn_lib_dashboard";
            this.btn_lib_dashboard.Size = new System.Drawing.Size(180, 30);
            this.btn_lib_dashboard.TabIndex = 3;
            this.btn_lib_dashboard.Text = "Home/Dashboard";
            this.btn_lib_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lib_dashboard.UseVisualStyleBackColor = true;
            this.btn_lib_dashboard.Click += new System.EventHandler(this.btn_lib_dashboard_Click);
            // 
            // btn_lib_book_mngmt
            // 
            this.btn_lib_book_mngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lib_book_mngmt.FlatAppearance.BorderSize = 0;
            this.btn_lib_book_mngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lib_book_mngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lib_book_mngmt.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_lib_book_mngmt.Location = new System.Drawing.Point(0, 310);
            this.btn_lib_book_mngmt.Name = "btn_lib_book_mngmt";
            this.btn_lib_book_mngmt.Size = new System.Drawing.Size(180, 30);
            this.btn_lib_book_mngmt.TabIndex = 7;
            this.btn_lib_book_mngmt.Text = "Book Inventory Management";
            this.btn_lib_book_mngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lib_book_mngmt.UseVisualStyleBackColor = true;
            this.btn_lib_book_mngmt.Click += new System.EventHandler(this.btn_lib_book_mngmt_Click);
            // 
            // btn_bkborrow
            // 
            this.btn_bkborrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bkborrow.FlatAppearance.BorderSize = 0;
            this.btn_bkborrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bkborrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bkborrow.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_bkborrow.Location = new System.Drawing.Point(0, 340);
            this.btn_bkborrow.Name = "btn_bkborrow";
            this.btn_bkborrow.Size = new System.Drawing.Size(180, 30);
            this.btn_bkborrow.TabIndex = 8;
            this.btn_bkborrow.Text = "Book Borrowing";
            this.btn_bkborrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bkborrow.UseVisualStyleBackColor = true;
            this.btn_bkborrow.Click += new System.EventHandler(this.btn_bkborrow_Click);
            // 
            // btn_account_mngmt
            // 
            this.btn_account_mngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account_mngmt.FlatAppearance.BorderSize = 0;
            this.btn_account_mngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account_mngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_account_mngmt.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_account_mngmt.Location = new System.Drawing.Point(0, 210);
            this.btn_account_mngmt.Name = "btn_account_mngmt";
            this.btn_account_mngmt.Size = new System.Drawing.Size(180, 30);
            this.btn_account_mngmt.TabIndex = 4;
            this.btn_account_mngmt.Text = "Account Management";
            this.btn_account_mngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account_mngmt.UseVisualStyleBackColor = true;
            this.btn_account_mngmt.Click += new System.EventHandler(this.btn_account_mngmt_Click);
            // 
            // picturebox_pnl
            // 
            this.picturebox_pnl.Controls.Add(this.label1);
            this.picturebox_pnl.Controls.Add(this.pictureBox1);
            this.picturebox_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturebox_pnl.Location = new System.Drawing.Point(0, 0);
            this.picturebox_pnl.Name = "picturebox_pnl";
            this.picturebox_pnl.Size = new System.Drawing.Size(180, 180);
            this.picturebox_pnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "COCPL\r\nINFORMATION SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // librarianstaff_sidepanel
            // 
            this.librarianstaff_sidepanel.BackColor = System.Drawing.Color.DarkGreen;
            this.librarianstaff_sidepanel.Controls.Add(this.rep_charts_submenu);
            this.librarianstaff_sidepanel.Controls.Add(this.repcharts_btn);
            this.librarianstaff_sidepanel.Controls.Add(this.backuprestore_btn_sidepanel);
            this.librarianstaff_sidepanel.Controls.Add(this.bookreturnsbtn);
            this.librarianstaff_sidepanel.Controls.Add(this.logout_btn);
            this.librarianstaff_sidepanel.Controls.Add(this.btn_bkborrow);
            this.librarianstaff_sidepanel.Controls.Add(this.btn_lib_book_mngmt);
            this.librarianstaff_sidepanel.Controls.Add(this.act_mngmt_submenu);
            this.librarianstaff_sidepanel.Controls.Add(this.btn_account_mngmt);
            this.librarianstaff_sidepanel.Controls.Add(this.btn_lib_dashboard);
            this.librarianstaff_sidepanel.Controls.Add(this.picturebox_pnl);
            this.librarianstaff_sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.librarianstaff_sidepanel.Location = new System.Drawing.Point(0, 0);
            this.librarianstaff_sidepanel.Name = "librarianstaff_sidepanel";
            this.librarianstaff_sidepanel.Size = new System.Drawing.Size(180, 661);
            this.librarianstaff_sidepanel.TabIndex = 0;
            // 
            // rep_charts_submenu
            // 
            this.rep_charts_submenu.Controls.Add(this.ClientLogbookReport);
            this.rep_charts_submenu.Controls.Add(this.BookInvReport);
            this.rep_charts_submenu.Controls.Add(this.BorrowedBooksReport);
            this.rep_charts_submenu.Controls.Add(this.MemberFreqReport);
            this.rep_charts_submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.rep_charts_submenu.Location = new System.Drawing.Point(0, 460);
            this.rep_charts_submenu.Name = "rep_charts_submenu";
            this.rep_charts_submenu.Size = new System.Drawing.Size(180, 139);
            this.rep_charts_submenu.TabIndex = 2;
            // 
            // ClientLogbookReport
            // 
            this.ClientLogbookReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientLogbookReport.FlatAppearance.BorderSize = 0;
            this.ClientLogbookReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientLogbookReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLogbookReport.ForeColor = System.Drawing.Color.PaleGreen;
            this.ClientLogbookReport.Location = new System.Drawing.Point(0, 100);
            this.ClientLogbookReport.Name = "ClientLogbookReport";
            this.ClientLogbookReport.Size = new System.Drawing.Size(180, 30);
            this.ClientLogbookReport.TabIndex = 15;
            this.ClientLogbookReport.Text = "Client Logbook Report";
            this.ClientLogbookReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientLogbookReport.UseVisualStyleBackColor = true;
            // 
            // BookInvReport
            // 
            this.BookInvReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookInvReport.FlatAppearance.BorderSize = 0;
            this.BookInvReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookInvReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookInvReport.ForeColor = System.Drawing.Color.PaleGreen;
            this.BookInvReport.Location = new System.Drawing.Point(0, 70);
            this.BookInvReport.Name = "BookInvReport";
            this.BookInvReport.Size = new System.Drawing.Size(180, 30);
            this.BookInvReport.TabIndex = 14;
            this.BookInvReport.Text = "Book Inventory Report";
            this.BookInvReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookInvReport.UseVisualStyleBackColor = true;
            // 
            // BorrowedBooksReport
            // 
            this.BorrowedBooksReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorrowedBooksReport.FlatAppearance.BorderSize = 0;
            this.BorrowedBooksReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowedBooksReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedBooksReport.ForeColor = System.Drawing.Color.PaleGreen;
            this.BorrowedBooksReport.Location = new System.Drawing.Point(0, 30);
            this.BorrowedBooksReport.Name = "BorrowedBooksReport";
            this.BorrowedBooksReport.Size = new System.Drawing.Size(180, 40);
            this.BorrowedBooksReport.TabIndex = 12;
            this.BorrowedBooksReport.Text = "Member\'s Borrowed Books Report";
            this.BorrowedBooksReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowedBooksReport.UseVisualStyleBackColor = true;
            // 
            // MemberFreqReport
            // 
            this.MemberFreqReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberFreqReport.FlatAppearance.BorderSize = 0;
            this.MemberFreqReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberFreqReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberFreqReport.ForeColor = System.Drawing.Color.PaleGreen;
            this.MemberFreqReport.Location = new System.Drawing.Point(0, 0);
            this.MemberFreqReport.Name = "MemberFreqReport";
            this.MemberFreqReport.Size = new System.Drawing.Size(180, 30);
            this.MemberFreqReport.TabIndex = 13;
            this.MemberFreqReport.Text = "Membership Frequency Report";
            this.MemberFreqReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MemberFreqReport.UseVisualStyleBackColor = true;
            // 
            // repcharts_btn
            // 
            this.repcharts_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.repcharts_btn.FlatAppearance.BorderSize = 0;
            this.repcharts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repcharts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repcharts_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.repcharts_btn.Location = new System.Drawing.Point(0, 430);
            this.repcharts_btn.Name = "repcharts_btn";
            this.repcharts_btn.Size = new System.Drawing.Size(180, 30);
            this.repcharts_btn.TabIndex = 10;
            this.repcharts_btn.Text = "Reports and Charts";
            this.repcharts_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.repcharts_btn.UseVisualStyleBackColor = true;
            this.repcharts_btn.Click += new System.EventHandler(this.repcharts_btn_Click);
            // 
            // backuprestore_btn_sidepanel
            // 
            this.backuprestore_btn_sidepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backuprestore_btn_sidepanel.FlatAppearance.BorderSize = 0;
            this.backuprestore_btn_sidepanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backuprestore_btn_sidepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backuprestore_btn_sidepanel.ForeColor = System.Drawing.SystemColors.Control;
            this.backuprestore_btn_sidepanel.Location = new System.Drawing.Point(0, 400);
            this.backuprestore_btn_sidepanel.Name = "backuprestore_btn_sidepanel";
            this.backuprestore_btn_sidepanel.Size = new System.Drawing.Size(180, 30);
            this.backuprestore_btn_sidepanel.TabIndex = 10;
            this.backuprestore_btn_sidepanel.Text = "Backup and Restore";
            this.backuprestore_btn_sidepanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backuprestore_btn_sidepanel.UseVisualStyleBackColor = true;
            this.backuprestore_btn_sidepanel.Click += new System.EventHandler(this.backuprestore_btn_sidepanel_Click);
            // 
            // bookreturnsbtn
            // 
            this.bookreturnsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookreturnsbtn.FlatAppearance.BorderSize = 0;
            this.bookreturnsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookreturnsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookreturnsbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.bookreturnsbtn.Location = new System.Drawing.Point(0, 370);
            this.bookreturnsbtn.Name = "bookreturnsbtn";
            this.bookreturnsbtn.Size = new System.Drawing.Size(180, 30);
            this.bookreturnsbtn.TabIndex = 11;
            this.bookreturnsbtn.Text = "Book Returns";
            this.bookreturnsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookreturnsbtn.UseVisualStyleBackColor = true;
            this.bookreturnsbtn.Click += new System.EventHandler(this.bookreturnsbtn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.logout_btn.Location = new System.Drawing.Point(0, 631);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(180, 30);
            this.logout_btn.TabIndex = 11;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Staff_LibrarianUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.LibrarianStaff_UISubPanel);
            this.Controls.Add(this.librarianstaff_sidepanel);
            this.Name = "Staff_LibrarianUI";
            this.Text = "COCPL Information System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_LibrarianUI_FormClosing);
            this.Load += new System.EventHandler(this.LibrarianStaff_DashboardUI_Load);
            this.act_mngmt_submenu.ResumeLayout(false);
            this.picturebox_pnl.ResumeLayout(false);
            this.picturebox_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.librarianstaff_sidepanel.ResumeLayout(false);
            this.rep_charts_submenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LibrarianStaff_UISubPanel;
        private System.Windows.Forms.Panel act_mngmt_submenu;
        private System.Windows.Forms.Button btn_bkborrow;
        private System.Windows.Forms.Button btn_lib_book_mngmt;
        private System.Windows.Forms.Button btn_member_mgmt;
        private System.Windows.Forms.Button btn_client_mgmt;
        private System.Windows.Forms.Button btn_account_mngmt;
        private System.Windows.Forms.Button btn_lib_dashboard;
        private System.Windows.Forms.Panel picturebox_pnl;
        private System.Windows.Forms.Panel librarianstaff_sidepanel;
        private System.Windows.Forms.Panel rep_charts_submenu;
        private System.Windows.Forms.Button ClientLogbookReport;
        private System.Windows.Forms.Button BookInvReport;
        private System.Windows.Forms.Button BorrowedBooksReport;
        private System.Windows.Forms.Button MemberFreqReport;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button repcharts_btn;
        private System.Windows.Forms.Button backuprestore_btn_sidepanel;
        private System.Windows.Forms.Button bookreturnsbtn;
    }
}