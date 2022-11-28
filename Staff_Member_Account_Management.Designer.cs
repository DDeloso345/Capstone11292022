
namespace Capstone
{
    partial class Staff_Member_Account_Management
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
            this.cmbbox_criteria = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.inputsearchbar = new System.Windows.Forms.TextBox();
            this.orhistory = new System.Windows.Forms.Button();
            this.membidprev = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_member_acc_tbl = new System.Windows.Forms.DataGridView();
            this.uidtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contactnotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.middlenametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.membership_timer = new System.Windows.Forms.Timer(this.components);
            this.renew_member = new System.Windows.Forms.Button();
            this.btn_imgbrowse = new System.Windows.Forms.Button();
            this.imgpathtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.memberend_txt = new System.Windows.Forms.DateTimePicker();
            this.memberstart_txt = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.suffixtxt = new System.Windows.Forms.ComboBox();
            this.notifdgv = new System.Windows.Forms.DataGridView();
            this.notifpnl = new System.Windows.Forms.Panel();
            this.notifbtn = new System.Windows.Forms.RadioButton();
            this.notifcounter = new System.Windows.Forms.Label();
            this.refbtn = new System.Windows.Forms.PictureBox();
            this.selorg = new System.Windows.Forms.Button();
            this.organizationtxt = new System.Windows.Forms.TextBox();
            this.orgid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member_acc_tbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifdgv)).BeginInit();
            this.notifpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbox_criteria
            // 
            this.cmbbox_criteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_criteria.FormattingEnabled = true;
            this.cmbbox_criteria.Items.AddRange(new object[] {
            "COCPL UID",
            "First Name",
            "Middle Name ",
            "Last Name",
            "Suffix",
            "Address",
            "Organization",
            "E-mail Address",
            "Contact No.",
            "Membership Start",
            "Membership End",
            "Image Path"});
            this.cmbbox_criteria.Location = new System.Drawing.Point(186, 105);
            this.cmbbox_criteria.Name = "cmbbox_criteria";
            this.cmbbox_criteria.Size = new System.Drawing.Size(149, 21);
            this.cmbbox_criteria.TabIndex = 199;
            this.cmbbox_criteria.SelectedIndexChanged += new System.EventHandler(this.cmbbox_criteria_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 22);
            this.label13.TabIndex = 198;
            this.label13.Text = "Search according to:";
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(872, 104);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 197;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // inputsearchbar
            // 
            this.inputsearchbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputsearchbar.Location = new System.Drawing.Point(341, 106);
            this.inputsearchbar.Name = "inputsearchbar";
            this.inputsearchbar.Size = new System.Drawing.Size(525, 20);
            this.inputsearchbar.TabIndex = 196;
            // 
            // orhistory
            // 
            this.orhistory.Location = new System.Drawing.Point(256, 570);
            this.orhistory.Name = "orhistory";
            this.orhistory.Size = new System.Drawing.Size(155, 23);
            this.orhistory.TabIndex = 195;
            this.orhistory.Text = "View Member\'s OR History";
            this.orhistory.UseVisualStyleBackColor = true;
            this.orhistory.Click += new System.EventHandler(this.orhistory_Click);
            // 
            // membidprev
            // 
            this.membidprev.Enabled = false;
            this.membidprev.Location = new System.Drawing.Point(35, 570);
            this.membidprev.Name = "membidprev";
            this.membidprev.Size = new System.Drawing.Size(111, 23);
            this.membidprev.TabIndex = 194;
            this.membidprev.Text = "Member ID Preview";
            this.membidprev.UseVisualStyleBackColor = true;
            this.membidprev.Click += new System.EventHandler(this.membidprev_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SeaGreen;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Aquamarine;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(984, 46);
            this.label12.TabIndex = 193;
            this.label12.Text = "MEMBER ACCOUNT MANAGEMENT";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(198, 529);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 35);
            this.btn_update.TabIndex = 191;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(279, 530);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 35);
            this.btn_clear.TabIndex = 190;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(191, 325);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(220, 20);
            this.addresstxt.TabIndex = 187;
            this.addresstxt.Leave += new System.EventHandler(this.addresstxt_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 22);
            this.label9.TabIndex = 185;
            this.label9.Text = "Contact Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 184;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 183;
            this.label7.Text = "Organization:";
            // 
            // dgv_member_acc_tbl
            // 
            this.dgv_member_acc_tbl.AllowUserToDeleteRows = false;
            this.dgv_member_acc_tbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_member_acc_tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_member_acc_tbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_member_acc_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_member_acc_tbl.Location = new System.Drawing.Point(417, 132);
            this.dgv_member_acc_tbl.Name = "dgv_member_acc_tbl";
            this.dgv_member_acc_tbl.ReadOnly = true;
            this.dgv_member_acc_tbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_member_acc_tbl.Size = new System.Drawing.Size(560, 480);
            this.dgv_member_acc_tbl.TabIndex = 182;
            this.dgv_member_acc_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_member_acc_tbl_CellClick);
            this.dgv_member_acc_tbl.Leave += new System.EventHandler(this.dgv_member_acc_tbl_Leave);
            // 
            // uidtxt
            // 
            this.uidtxt.Location = new System.Drawing.Point(191, 167);
            this.uidtxt.MaxLength = 14;
            this.uidtxt.Name = "uidtxt";
            this.uidtxt.Size = new System.Drawing.Size(220, 20);
            this.uidtxt.TabIndex = 181;
            this.uidtxt.Text = "COCPLM";
            this.uidtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uidtxt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 180;
            this.label6.Text = "COCPL UID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 177;
            this.label5.Text = "Membership End:";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(187, 131);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(64, 22);
            this.idlbl.TabIndex = 176;
            this.idlbl.Text = "[ID Txt]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 22);
            this.label11.TabIndex = 175;
            this.label11.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 22);
            this.label10.TabIndex = 174;
            this.label10.Text = "Membership Start:";
            // 
            // contactnotxt
            // 
            this.contactnotxt.Location = new System.Drawing.Point(191, 413);
            this.contactnotxt.MaxLength = 11;
            this.contactnotxt.Name = "contactnotxt";
            this.contactnotxt.Size = new System.Drawing.Size(220, 20);
            this.contactnotxt.TabIndex = 173;
            this.contactnotxt.Text = "09";
            this.contactnotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactnotxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 172;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 171;
            this.label3.Text = "Last Name:";
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(191, 197);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(220, 20);
            this.firstnametxt.TabIndex = 170;
            this.firstnametxt.Leave += new System.EventHandler(this.firstnametxt_Leave);
            // 
            // middlenametxt
            // 
            this.middlenametxt.Location = new System.Drawing.Point(191, 227);
            this.middlenametxt.Name = "middlenametxt";
            this.middlenametxt.Size = new System.Drawing.Size(220, 20);
            this.middlenametxt.TabIndex = 169;
            this.middlenametxt.Leave += new System.EventHandler(this.middlenametxt_Leave);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(191, 384);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(220, 20);
            this.emailtxt.TabIndex = 168;
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(191, 258);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(220, 20);
            this.lastnametxt.TabIndex = 167;
            this.lastnametxt.Leave += new System.EventHandler(this.lastnametxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 166;
            this.label2.Text = "Middle Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 165;
            this.label1.Text = "First Name:";
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(117, 530);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 35);
            this.insert_btn.TabIndex = 164;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // membership_timer
            // 
            this.membership_timer.Tick += new System.EventHandler(this.membership_timer_Tick);
            // 
            // renew_member
            // 
            this.renew_member.Enabled = false;
            this.renew_member.Location = new System.Drawing.Point(152, 570);
            this.renew_member.Name = "renew_member";
            this.renew_member.Size = new System.Drawing.Size(98, 23);
            this.renew_member.TabIndex = 163;
            this.renew_member.Text = "Renew Member";
            this.renew_member.UseVisualStyleBackColor = true;
            this.renew_member.Click += new System.EventHandler(this.renew_member_Click);
            // 
            // btn_imgbrowse
            // 
            this.btn_imgbrowse.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imgbrowse.Location = new System.Drawing.Point(347, 504);
            this.btn_imgbrowse.Name = "btn_imgbrowse";
            this.btn_imgbrowse.Size = new System.Drawing.Size(64, 20);
            this.btn_imgbrowse.TabIndex = 202;
            this.btn_imgbrowse.Text = "Browse";
            this.btn_imgbrowse.UseVisualStyleBackColor = true;
            this.btn_imgbrowse.Click += new System.EventHandler(this.btn_imgbrowse_Click);
            // 
            // imgpathtxt
            // 
            this.imgpathtxt.Location = new System.Drawing.Point(191, 504);
            this.imgpathtxt.MaxLength = 10;
            this.imgpathtxt.Name = "imgpathtxt";
            this.imgpathtxt.ReadOnly = true;
            this.imgpathtxt.Size = new System.Drawing.Size(150, 20);
            this.imgpathtxt.TabIndex = 201;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 200;
            this.label14.Text = "Image Path:";
            // 
            // memberend_txt
            // 
            this.memberend_txt.Location = new System.Drawing.Point(191, 470);
            this.memberend_txt.Name = "memberend_txt";
            this.memberend_txt.Size = new System.Drawing.Size(220, 20);
            this.memberend_txt.TabIndex = 204;
            // 
            // memberstart_txt
            // 
            this.memberstart_txt.Location = new System.Drawing.Point(191, 441);
            this.memberstart_txt.Name = "memberstart_txt";
            this.memberstart_txt.Size = new System.Drawing.Size(220, 20);
            this.memberstart_txt.TabIndex = 203;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 22);
            this.label15.TabIndex = 206;
            this.label15.Text = "Suffix";
            // 
            // suffixtxt
            // 
            this.suffixtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suffixtxt.FormattingEnabled = true;
            this.suffixtxt.Items.AddRange(new object[] {
            "N/A",
            "Sr.",
            "Jr."});
            this.suffixtxt.Location = new System.Drawing.Point(191, 291);
            this.suffixtxt.Name = "suffixtxt";
            this.suffixtxt.Size = new System.Drawing.Size(220, 21);
            this.suffixtxt.TabIndex = 205;
            // 
            // notifdgv
            // 
            this.notifdgv.AllowUserToAddRows = false;
            this.notifdgv.AllowUserToDeleteRows = false;
            this.notifdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notifdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifdgv.Location = new System.Drawing.Point(629, 85);
            this.notifdgv.Name = "notifdgv";
            this.notifdgv.ReadOnly = true;
            this.notifdgv.Size = new System.Drawing.Size(344, 181);
            this.notifdgv.TabIndex = 211;
            this.notifdgv.Visible = false;
            this.notifdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notifdgv_CellContentClick);
            // 
            // notifpnl
            // 
            this.notifpnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifpnl.Controls.Add(this.notifbtn);
            this.notifpnl.Controls.Add(this.notifcounter);
            this.notifpnl.Location = new System.Drawing.Point(748, 48);
            this.notifpnl.Name = "notifpnl";
            this.notifpnl.Size = new System.Drawing.Size(225, 41);
            this.notifpnl.TabIndex = 210;
            this.notifpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.notifpnl_Paint);
            // 
            // notifbtn
            // 
            this.notifbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.notifbtn.AutoSize = true;
            this.notifbtn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifbtn.Location = new System.Drawing.Point(25, 1);
            this.notifbtn.Name = "notifbtn";
            this.notifbtn.Size = new System.Drawing.Size(162, 37);
            this.notifbtn.TabIndex = 180;
            this.notifbtn.TabStop = true;
            this.notifbtn.Text = "NOTIFICATIONS";
            this.notifbtn.UseVisualStyleBackColor = true;
            this.notifbtn.CheckedChanged += new System.EventHandler(this.notifbtn_CheckedChanged);
            this.notifbtn.Click += new System.EventHandler(this.notifbtn_Click);
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
            this.notifcounter.Click += new System.EventHandler(this.notifcounter_Click);
            // 
            // refbtn
            // 
            this.refbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(952, 102);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 212;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // selorg
            // 
            this.selorg.Location = new System.Drawing.Point(305, 351);
            this.selorg.Name = "selorg";
            this.selorg.Size = new System.Drawing.Size(52, 23);
            this.selorg.TabIndex = 215;
            this.selorg.Text = "Choose";
            this.selorg.UseVisualStyleBackColor = true;
            this.selorg.Click += new System.EventHandler(this.selorg_Click);
            // 
            // organizationtxt
            // 
            this.organizationtxt.Location = new System.Drawing.Point(191, 353);
            this.organizationtxt.Name = "organizationtxt";
            this.organizationtxt.ReadOnly = true;
            this.organizationtxt.Size = new System.Drawing.Size(108, 20);
            this.organizationtxt.TabIndex = 214;
            // 
            // orgid
            // 
            this.orgid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgid.Location = new System.Drawing.Point(363, 352);
            this.orgid.Name = "orgid";
            this.orgid.Size = new System.Drawing.Size(48, 22);
            this.orgid.TabIndex = 208;
            this.orgid.Text = "label16";
            this.orgid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Staff_Member_Account_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.selorg);
            this.Controls.Add(this.organizationtxt);
            this.Controls.Add(this.notifdgv);
            this.Controls.Add(this.notifpnl);
            this.Controls.Add(this.orgid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.suffixtxt);
            this.Controls.Add(this.memberend_txt);
            this.Controls.Add(this.memberstart_txt);
            this.Controls.Add(this.btn_imgbrowse);
            this.Controls.Add(this.imgpathtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbbox_criteria);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.inputsearchbar);
            this.Controls.Add(this.orhistory);
            this.Controls.Add(this.membidprev);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_member_acc_tbl);
            this.Controls.Add(this.uidtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.contactnotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.middlenametxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.renew_member);
            this.Controls.Add(this.refbtn);
            this.Name = "Staff_Member_Account_Management";
            this.Text = "Member Account Management";
            this.Load += new System.EventHandler(this.Staff_Member_Account_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member_acc_tbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifdgv)).EndInit();
            this.notifpnl.ResumeLayout(false);
            this.notifpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbox_criteria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox inputsearchbar;
        private System.Windows.Forms.Button orhistory;
        private System.Windows.Forms.Button membidprev;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_member_acc_tbl;
        private System.Windows.Forms.TextBox uidtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox contactnotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.TextBox middlenametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Timer membership_timer;
        private System.Windows.Forms.Button renew_member;
        private System.Windows.Forms.Button btn_imgbrowse;
        private System.Windows.Forms.TextBox imgpathtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker memberend_txt;
        private System.Windows.Forms.DateTimePicker memberstart_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox suffixtxt;
        private System.Windows.Forms.DataGridView notifdgv;
        private System.Windows.Forms.Panel notifpnl;
        private System.Windows.Forms.RadioButton notifbtn;
        private System.Windows.Forms.Label notifcounter;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Button selorg;
        public System.Windows.Forms.TextBox organizationtxt;
        private System.Windows.Forms.Label orgid;
    }
}