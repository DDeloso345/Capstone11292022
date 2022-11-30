
namespace Capstone
{
    partial class Admin_BookBorrowing
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
            this.components = new System.ComponentModel.Container();
            this.notifpnl = new System.Windows.Forms.Panel();
            this.notifbtn = new System.Windows.Forms.CheckBox();
            this.notifcounter = new System.Windows.Forms.Label();
            this.dgv_bookborrowing = new System.Windows.Forms.DataGridView();
            this.bookbrpanel = new System.Windows.Forms.Panel();
            this.appby = new System.Windows.Forms.TextBox();
            this.uidid = new System.Windows.Forms.Label();
            this.cocpluid = new System.Windows.Forms.TextBox();
            this.seluid = new System.Windows.Forms.Button();
            this.autid = new System.Windows.Forms.Label();
            this.bkauthor = new System.Windows.Forms.TextBox();
            this.sel_emp = new System.Windows.Forms.Button();
            this.empname = new System.Windows.Forms.TextBox();
            this.empunid = new System.Windows.Forms.Label();
            this.accno = new System.Windows.Forms.TextBox();
            this.selbkinfo = new System.Windows.Forms.Button();
            this.bktitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.titleid = new System.Windows.Forms.Label();
            this.approvedon = new System.Windows.Forms.TextBox();
            this.bkbrinfolbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.duedt = new System.Windows.Forms.DateTimePicker();
            this.dtborrowed = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bookbrid = new System.Windows.Forms.Label();
            this.searchinp = new System.Windows.Forms.TextBox();
            this.cmbcriteria = new System.Windows.Forms.ComboBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.showappbtn = new System.Windows.Forms.Button();
            this.bkbrtimer = new System.Windows.Forms.Timer(this.components);
            this.refbtn = new System.Windows.Forms.PictureBox();
            this.viewbkbrindbtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.notifdgv = new System.Windows.Forms.DataGridView();
            this.notifpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookborrowing)).BeginInit();
            this.bookbrpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // notifpnl
            // 
            this.notifpnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifpnl.Controls.Add(this.notifbtn);
            this.notifpnl.Controls.Add(this.notifcounter);
            this.notifpnl.Location = new System.Drawing.Point(748, 48);
            this.notifpnl.Name = "notifpnl";
            this.notifpnl.Size = new System.Drawing.Size(225, 41);
            this.notifpnl.TabIndex = 180;
            // 
            // notifbtn
            // 
            this.notifbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.notifbtn.AutoSize = true;
            this.notifbtn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifbtn.Location = new System.Drawing.Point(25, 0);
            this.notifbtn.Name = "notifbtn";
            this.notifbtn.Size = new System.Drawing.Size(162, 37);
            this.notifbtn.TabIndex = 181;
            this.notifbtn.Text = "NOTIFICATIONS";
            this.notifbtn.UseVisualStyleBackColor = true;
            this.notifbtn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // notifcounter
            // 
            this.notifcounter.AutoSize = true;
            this.notifcounter.BackColor = System.Drawing.Color.Green;
            this.notifcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifcounter.Location = new System.Drawing.Point(193, 9);
            this.notifcounter.Name = "notifcounter";
            this.notifcounter.Size = new System.Drawing.Size(25, 25);
            this.notifcounter.TabIndex = 177;
            this.notifcounter.Text = "0";
            // 
            // dgv_bookborrowing
            // 
            this.dgv_bookborrowing.AllowUserToDeleteRows = false;
            this.dgv_bookborrowing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bookborrowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_bookborrowing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_bookborrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookborrowing.Location = new System.Drawing.Point(416, 133);
            this.dgv_bookborrowing.Name = "dgv_bookborrowing";
            this.dgv_bookborrowing.ReadOnly = true;
            this.dgv_bookborrowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bookborrowing.Size = new System.Drawing.Size(561, 354);
            this.dgv_bookborrowing.TabIndex = 182;
            this.dgv_bookborrowing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bookborrowing_CellClick);
            // 
            // bookbrpanel
            // 
            this.bookbrpanel.Controls.Add(this.appby);
            this.bookbrpanel.Controls.Add(this.uidid);
            this.bookbrpanel.Controls.Add(this.cocpluid);
            this.bookbrpanel.Controls.Add(this.seluid);
            this.bookbrpanel.Controls.Add(this.autid);
            this.bookbrpanel.Controls.Add(this.bkauthor);
            this.bookbrpanel.Controls.Add(this.sel_emp);
            this.bookbrpanel.Controls.Add(this.empname);
            this.bookbrpanel.Controls.Add(this.empunid);
            this.bookbrpanel.Controls.Add(this.accno);
            this.bookbrpanel.Controls.Add(this.selbkinfo);
            this.bookbrpanel.Controls.Add(this.bktitle);
            this.bookbrpanel.Controls.Add(this.label13);
            this.bookbrpanel.Controls.Add(this.titleid);
            this.bookbrpanel.Controls.Add(this.approvedon);
            this.bookbrpanel.Controls.Add(this.bkbrinfolbl);
            this.bookbrpanel.Controls.Add(this.label10);
            this.bookbrpanel.Controls.Add(this.label9);
            this.bookbrpanel.Controls.Add(this.label8);
            this.bookbrpanel.Controls.Add(this.label7);
            this.bookbrpanel.Controls.Add(this.label6);
            this.bookbrpanel.Controls.Add(this.label5);
            this.bookbrpanel.Controls.Add(this.label4);
            this.bookbrpanel.Controls.Add(this.label3);
            this.bookbrpanel.Controls.Add(this.label2);
            this.bookbrpanel.Controls.Add(this.duedt);
            this.bookbrpanel.Controls.Add(this.dtborrowed);
            this.bookbrpanel.Location = new System.Drawing.Point(17, 159);
            this.bookbrpanel.Name = "bookbrpanel";
            this.bookbrpanel.Size = new System.Drawing.Size(393, 302);
            this.bookbrpanel.TabIndex = 183;
            // 
            // appby
            // 
            this.appby.Location = new System.Drawing.Point(150, 229);
            this.appby.Name = "appby";
            this.appby.ReadOnly = true;
            this.appby.Size = new System.Drawing.Size(174, 20);
            this.appby.TabIndex = 222;
            // 
            // uidid
            // 
            this.uidid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidid.Location = new System.Drawing.Point(327, 121);
            this.uidid.Name = "uidid";
            this.uidid.Size = new System.Drawing.Size(48, 22);
            this.uidid.TabIndex = 219;
            this.uidid.Text = "[ID]";
            this.uidid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cocpluid
            // 
            this.cocpluid.Location = new System.Drawing.Point(150, 121);
            this.cocpluid.Name = "cocpluid";
            this.cocpluid.ReadOnly = true;
            this.cocpluid.Size = new System.Drawing.Size(113, 20);
            this.cocpluid.TabIndex = 221;
            // 
            // seluid
            // 
            this.seluid.Location = new System.Drawing.Point(269, 122);
            this.seluid.Name = "seluid";
            this.seluid.Size = new System.Drawing.Size(52, 20);
            this.seluid.TabIndex = 220;
            this.seluid.Text = "Choose";
            this.seluid.UseVisualStyleBackColor = true;
            this.seluid.Click += new System.EventHandler(this.seluid_Click);
            // 
            // autid
            // 
            this.autid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autid.Location = new System.Drawing.Point(327, 94);
            this.autid.Name = "autid";
            this.autid.Size = new System.Drawing.Size(48, 22);
            this.autid.TabIndex = 216;
            this.autid.Text = "[ID]";
            this.autid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bkauthor
            // 
            this.bkauthor.Location = new System.Drawing.Point(150, 94);
            this.bkauthor.Name = "bkauthor";
            this.bkauthor.ReadOnly = true;
            this.bkauthor.Size = new System.Drawing.Size(174, 20);
            this.bkauthor.TabIndex = 218;
            // 
            // sel_emp
            // 
            this.sel_emp.Location = new System.Drawing.Point(327, 229);
            this.sel_emp.Name = "sel_emp";
            this.sel_emp.Size = new System.Drawing.Size(52, 20);
            this.sel_emp.TabIndex = 214;
            this.sel_emp.Text = "Choose";
            this.sel_emp.UseVisualStyleBackColor = true;
            this.sel_emp.Click += new System.EventHandler(this.sel_emp_Click);
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(150, 202);
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            this.empname.Size = new System.Drawing.Size(174, 20);
            this.empname.TabIndex = 213;
            // 
            // empunid
            // 
            this.empunid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empunid.Location = new System.Drawing.Point(327, 202);
            this.empunid.Name = "empunid";
            this.empunid.Size = new System.Drawing.Size(48, 22);
            this.empunid.TabIndex = 212;
            this.empunid.Text = "[ID]";
            this.empunid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accno
            // 
            this.accno.Location = new System.Drawing.Point(150, 67);
            this.accno.Name = "accno";
            this.accno.ReadOnly = true;
            this.accno.Size = new System.Drawing.Size(174, 20);
            this.accno.TabIndex = 200;
            // 
            // selbkinfo
            // 
            this.selbkinfo.Location = new System.Drawing.Point(327, 68);
            this.selbkinfo.Name = "selbkinfo";
            this.selbkinfo.Size = new System.Drawing.Size(52, 20);
            this.selbkinfo.TabIndex = 199;
            this.selbkinfo.Text = "Choose";
            this.selbkinfo.UseVisualStyleBackColor = true;
            this.selbkinfo.Click += new System.EventHandler(this.selbkinfo_Click);
            // 
            // bktitle
            // 
            this.bktitle.Location = new System.Drawing.Point(150, 40);
            this.bktitle.Name = "bktitle";
            this.bktitle.ReadOnly = true;
            this.bktitle.Size = new System.Drawing.Size(174, 20);
            this.bktitle.TabIndex = 198;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 211;
            this.label13.Text = "Staff Username:";
            // 
            // titleid
            // 
            this.titleid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleid.Location = new System.Drawing.Point(327, 40);
            this.titleid.Name = "titleid";
            this.titleid.Size = new System.Drawing.Size(48, 22);
            this.titleid.TabIndex = 197;
            this.titleid.Text = "[ID]";
            this.titleid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // approvedon
            // 
            this.approvedon.Location = new System.Drawing.Point(150, 255);
            this.approvedon.Name = "approvedon";
            this.approvedon.Size = new System.Drawing.Size(238, 20);
            this.approvedon.TabIndex = 205;
            // 
            // bkbrinfolbl
            // 
            this.bkbrinfolbl.BackColor = System.Drawing.Color.SteelBlue;
            this.bkbrinfolbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bkbrinfolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkbrinfolbl.ForeColor = System.Drawing.Color.Aquamarine;
            this.bkbrinfolbl.Location = new System.Drawing.Point(0, 0);
            this.bkbrinfolbl.Name = "bkbrinfolbl";
            this.bkbrinfolbl.Size = new System.Drawing.Size(393, 30);
            this.bkbrinfolbl.TabIndex = 193;
            this.bkbrinfolbl.Text = "BOOK BORROWING RECORD INFORMATION";
            this.bkbrinfolbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 204;
            this.label10.Text = "Approved On:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 203;
            this.label9.Text = "Approved By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 203;
            this.label8.Text = "Due Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 196;
            this.label7.Text = "Date Borrowed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 195;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "COCPL UID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 193;
            this.label4.Text = "Book Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 191;
            this.label3.Text = "Accession Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 186;
            this.label2.Text = "Book Author:";
            // 
            // duedt
            // 
            this.duedt.Location = new System.Drawing.Point(150, 174);
            this.duedt.Name = "duedt";
            this.duedt.Size = new System.Drawing.Size(238, 20);
            this.duedt.TabIndex = 189;
            // 
            // dtborrowed
            // 
            this.dtborrowed.Location = new System.Drawing.Point(150, 148);
            this.dtborrowed.Name = "dtborrowed";
            this.dtborrowed.Size = new System.Drawing.Size(238, 20);
            this.dtborrowed.TabIndex = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 27);
            this.label1.TabIndex = 184;
            this.label1.Text = "Book Borrowing Record ID:";
            // 
            // bookbrid
            // 
            this.bookbrid.AutoSize = true;
            this.bookbrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookbrid.Location = new System.Drawing.Point(293, 129);
            this.bookbrid.Name = "bookbrid";
            this.bookbrid.Size = new System.Drawing.Size(80, 25);
            this.bookbrid.TabIndex = 185;
            this.bookbrid.Text = "[ID Txt]";
            // 
            // searchinp
            // 
            this.searchinp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchinp.Location = new System.Drawing.Point(347, 107);
            this.searchinp.Name = "searchinp";
            this.searchinp.Size = new System.Drawing.Size(530, 20);
            this.searchinp.TabIndex = 186;
            // 
            // cmbcriteria
            // 
            this.cmbcriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcriteria.FormattingEnabled = true;
            this.cmbcriteria.Location = new System.Drawing.Point(193, 107);
            this.cmbcriteria.Name = "cmbcriteria";
            this.cmbcriteria.Size = new System.Drawing.Size(148, 21);
            this.cmbcriteria.TabIndex = 187;
            this.cmbcriteria.SelectedIndexChanged += new System.EventHandler(this.cmbcriteria_SelectedIndexChanged);
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(8, 467);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(191, 23);
            this.insertbtn.TabIndex = 188;
            this.insertbtn.Text = "Insert Book Borrowing Record";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Enabled = false;
            this.delbtn.Location = new System.Drawing.Point(8, 496);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(190, 23);
            this.delbtn.TabIndex = 189;
            this.delbtn.Text = "Delete  Book Borrowing Record";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.Enabled = false;
            this.updbtn.Location = new System.Drawing.Point(220, 467);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(186, 23);
            this.updbtn.TabIndex = 190;
            this.updbtn.Text = "Update Book Borrowing Record";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.Location = new System.Drawing.Point(883, 104);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(59, 23);
            this.searchbtn.TabIndex = 191;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 22);
            this.label11.TabIndex = 192;
            this.label11.Text = "Search according to...";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Aquamarine;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(984, 45);
            this.label12.TabIndex = 193;
            this.label12.Text = "BOOK BORROWING";
            // 
            // showappbtn
            // 
            this.showappbtn.Location = new System.Drawing.Point(416, 525);
            this.showappbtn.Name = "showappbtn";
            this.showappbtn.Size = new System.Drawing.Size(185, 23);
            this.showappbtn.TabIndex = 194;
            this.showappbtn.Text = "Show Approved Requests";
            this.showappbtn.UseVisualStyleBackColor = true;
            this.showappbtn.Visible = false;
            this.showappbtn.Click += new System.EventHandler(this.showappbtn_Click);
            // 
            // bkbrtimer
            // 
            this.bkbrtimer.Tick += new System.EventHandler(this.bkbrtimer_Tick);
            // 
            // refbtn
            // 
            this.refbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(948, 103);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 195;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // viewbkbrindbtn
            // 
            this.viewbkbrindbtn.Location = new System.Drawing.Point(220, 496);
            this.viewbkbrindbtn.Name = "viewbkbrindbtn";
            this.viewbkbrindbtn.Size = new System.Drawing.Size(221, 23);
            this.viewbkbrindbtn.TabIndex = 196;
            this.viewbkbrindbtn.Text = "View Member\'s Book Borrowing Information";
            this.viewbkbrindbtn.UseVisualStyleBackColor = true;
            this.viewbkbrindbtn.Click += new System.EventHandler(this.viewbkbrindbtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(12, 525);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(119, 23);
            this.clrbtn.TabIndex = 197;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // notifdgv
            // 
            this.notifdgv.AllowUserToAddRows = false;
            this.notifdgv.AllowUserToDeleteRows = false;
            this.notifdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notifdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.notifdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifdgv.Location = new System.Drawing.Point(606, 85);
            this.notifdgv.Name = "notifdgv";
            this.notifdgv.ReadOnly = true;
            this.notifdgv.Size = new System.Drawing.Size(367, 206);
            this.notifdgv.TabIndex = 181;
            this.notifdgv.Visible = false;
            this.notifdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notifdgv_CellClick);
            // 
            // Admin_BookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.notifdgv);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.viewbkbrindbtn);
            this.Controls.Add(this.showappbtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.cmbcriteria);
            this.Controls.Add(this.searchinp);
            this.Controls.Add(this.bookbrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookbrpanel);
            this.Controls.Add(this.notifpnl);
            this.Controls.Add(this.dgv_bookborrowing);
            this.Controls.Add(this.refbtn);
            this.Name = "Admin_BookBorrowing";
            this.Text = "Book Borrowing";
            this.Load += new System.EventHandler(this.Admin_BookBorrowing_Load);
            this.notifpnl.ResumeLayout(false);
            this.notifpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookborrowing)).EndInit();
            this.bookbrpanel.ResumeLayout(false);
            this.bookbrpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel notifpnl;
        private System.Windows.Forms.Label notifcounter;
        private System.Windows.Forms.DataGridView dgv_bookborrowing;
        private System.Windows.Forms.CheckBox notifbtn;
        private System.Windows.Forms.Panel bookbrpanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker duedt;
        private System.Windows.Forms.DateTimePicker dtborrowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookbrid;
        private System.Windows.Forms.TextBox searchinp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbcriteria;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Label bkbrinfolbl;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox approvedon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button showappbtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer bkbrtimer;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Button viewbkbrindbtn;
        private System.Windows.Forms.Label uidid;
        public System.Windows.Forms.TextBox cocpluid;
        private System.Windows.Forms.Button seluid;
        public System.Windows.Forms.TextBox bkauthor;
        private System.Windows.Forms.Button sel_emp;
        public System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.Label empunid;
        public System.Windows.Forms.TextBox accno;
        private System.Windows.Forms.Button selbkinfo;
        public System.Windows.Forms.TextBox bktitle;
        private System.Windows.Forms.Label titleid;
        public System.Windows.Forms.TextBox appby;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Label autid;
        private System.Windows.Forms.DataGridView notifdgv;
    }
}