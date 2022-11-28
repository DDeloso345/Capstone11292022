
namespace Capstone
{
    partial class Admin_BookReturns
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.cmbcriteria = new System.Windows.Forms.ComboBox();
            this.searchinp = new System.Windows.Forms.TextBox();
            this.dgv_bookreturns = new System.Windows.Forms.DataGridView();
            this.brrid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clrbtn = new System.Windows.Forms.Button();
            this.bkr_timer = new System.Windows.Forms.Timer(this.components);
            this.bkr_pnl = new System.Windows.Forms.Panel();
            this.finespnl = new System.Windows.Forms.Panel();
            this.paid_id = new System.Windows.Forms.Label();
            this.selpaid = new System.Windows.Forms.ComboBox();
            this.finestxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bkret_remarks_cmb_id = new System.Windows.Forms.Label();
            this.bkret_remarks_cmb = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.bkremarks = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.returnedon = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.br_staffinfopnl = new System.Windows.Forms.Panel();
            this.un = new System.Windows.Forms.TextBox();
            this.sel_staff = new System.Windows.Forms.Button();
            this.empname = new System.Windows.Forms.TextBox();
            this.un_id = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.bkr_bkbrinfopnl = new System.Windows.Forms.Panel();
            this.bkbr_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.duedt = new System.Windows.Forms.DateTimePicker();
            this.dtborrowed = new System.Windows.Forms.DateTimePicker();
            this.bkaut = new System.Windows.Forms.TextBox();
            this.accno = new System.Windows.Forms.TextBox();
            this.bktitle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.btn_bkbrinfo = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.refbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookreturns)).BeginInit();
            this.bkr_pnl.SuspendLayout();
            this.finespnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.br_staffinfopnl.SuspendLayout();
            this.bkr_bkbrinfopnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            this.SuspendLayout();
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
            this.label12.TabIndex = 204;
            this.label12.Text = "BOOK RETURNS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(84, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 22);
            this.label11.TabIndex = 203;
            this.label11.Text = "Search according to...";
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchbtn.Location = new System.Drawing.Point(883, 54);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(59, 23);
            this.searchbtn.TabIndex = 202;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.Enabled = false;
            this.updbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updbtn.Location = new System.Drawing.Point(242, 566);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(186, 23);
            this.updbtn.TabIndex = 201;
            this.updbtn.Text = "Update Book Returns Record";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Enabled = false;
            this.delbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delbtn.Location = new System.Drawing.Point(9, 595);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(190, 23);
            this.delbtn.TabIndex = 200;
            this.delbtn.Text = "Delete Book Returns Record";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insertbtn.Location = new System.Drawing.Point(8, 566);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(191, 23);
            this.insertbtn.TabIndex = 199;
            this.insertbtn.Text = "Insert Book Returns Record";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // cmbcriteria
            // 
            this.cmbcriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcriteria.FormattingEnabled = true;
            this.cmbcriteria.Location = new System.Drawing.Point(265, 57);
            this.cmbcriteria.Name = "cmbcriteria";
            this.cmbcriteria.Size = new System.Drawing.Size(174, 21);
            this.cmbcriteria.TabIndex = 198;
            this.cmbcriteria.SelectedIndexChanged += new System.EventHandler(this.cmbcriteria_SelectedIndexChanged);
            // 
            // searchinp
            // 
            this.searchinp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchinp.Location = new System.Drawing.Point(445, 57);
            this.searchinp.Name = "searchinp";
            this.searchinp.Size = new System.Drawing.Size(432, 20);
            this.searchinp.TabIndex = 197;
            // 
            // dgv_bookreturns
            // 
            this.dgv_bookreturns.AllowUserToDeleteRows = false;
            this.dgv_bookreturns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bookreturns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_bookreturns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_bookreturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookreturns.Location = new System.Drawing.Point(445, 83);
            this.dgv_bookreturns.Name = "dgv_bookreturns";
            this.dgv_bookreturns.ReadOnly = true;
            this.dgv_bookreturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bookreturns.Size = new System.Drawing.Size(532, 477);
            this.dgv_bookreturns.TabIndex = 196;
            this.dgv_bookreturns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bookreturns_CellClick);
            // 
            // brrid
            // 
            this.brrid.AutoSize = true;
            this.brrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brrid.Location = new System.Drawing.Point(260, 84);
            this.brrid.Name = "brrid";
            this.brrid.Size = new System.Drawing.Size(80, 25);
            this.brrid.TabIndex = 207;
            this.brrid.Text = "[ID Txt]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 27);
            this.label1.TabIndex = 206;
            this.label1.Text = "Book Returns Record ID:";
            // 
            // clrbtn
            // 
            this.clrbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clrbtn.Location = new System.Drawing.Point(326, 595);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(102, 23);
            this.clrbtn.TabIndex = 208;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // bkr_timer
            // 
            this.bkr_timer.Tick += new System.EventHandler(this.bkr_timer_Tick);
            // 
            // bkr_pnl
            // 
            this.bkr_pnl.AutoScroll = true;
            this.bkr_pnl.Controls.Add(this.finespnl);
            this.bkr_pnl.Controls.Add(this.panel2);
            this.bkr_pnl.Controls.Add(this.br_staffinfopnl);
            this.bkr_pnl.Controls.Add(this.label24);
            this.bkr_pnl.Controls.Add(this.bkr_bkbrinfopnl);
            this.bkr_pnl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bkr_pnl.Location = new System.Drawing.Point(8, 113);
            this.bkr_pnl.Name = "bkr_pnl";
            this.bkr_pnl.Size = new System.Drawing.Size(420, 447);
            this.bkr_pnl.TabIndex = 215;
            // 
            // finespnl
            // 
            this.finespnl.Controls.Add(this.paid_id);
            this.finespnl.Controls.Add(this.selpaid);
            this.finespnl.Controls.Add(this.finestxt);
            this.finespnl.Controls.Add(this.label6);
            this.finespnl.Controls.Add(this.label7);
            this.finespnl.Controls.Add(this.label8);
            this.finespnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.finespnl.Location = new System.Drawing.Point(0, 487);
            this.finespnl.Name = "finespnl";
            this.finespnl.Size = new System.Drawing.Size(403, 88);
            this.finespnl.TabIndex = 260;
            // 
            // paid_id
            // 
            this.paid_id.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_id.Location = new System.Drawing.Point(328, 57);
            this.paid_id.Name = "paid_id";
            this.paid_id.Size = new System.Drawing.Size(48, 22);
            this.paid_id.TabIndex = 258;
            this.paid_id.Text = "[ID]";
            this.paid_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selpaid
            // 
            this.selpaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selpaid.FormattingEnabled = true;
            this.selpaid.Location = new System.Drawing.Point(199, 59);
            this.selpaid.Name = "selpaid";
            this.selpaid.Size = new System.Drawing.Size(121, 21);
            this.selpaid.TabIndex = 257;
            this.selpaid.SelectedIndexChanged += new System.EventHandler(this.selpaid_SelectedIndexChanged);
            // 
            // finestxt
            // 
            this.finestxt.Location = new System.Drawing.Point(199, 34);
            this.finestxt.MaxLength = 3;
            this.finestxt.Name = "finestxt";
            this.finestxt.Size = new System.Drawing.Size(189, 20);
            this.finestxt.TabIndex = 255;
            this.finestxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.finestxt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 254;
            this.label6.Text = "Imposed Fines (in Php):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(7, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 252;
            this.label7.Text = "Payment Status:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aquamarine;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(403, 30);
            this.label8.TabIndex = 242;
            this.label8.Text = "FINES";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bkret_remarks_cmb_id);
            this.panel2.Controls.Add(this.bkret_remarks_cmb);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.bkremarks);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.returnedon);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 116);
            this.panel2.TabIndex = 259;
            // 
            // bkret_remarks_cmb_id
            // 
            this.bkret_remarks_cmb_id.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkret_remarks_cmb_id.Location = new System.Drawing.Point(328, 83);
            this.bkret_remarks_cmb_id.Name = "bkret_remarks_cmb_id";
            this.bkret_remarks_cmb_id.Size = new System.Drawing.Size(48, 22);
            this.bkret_remarks_cmb_id.TabIndex = 258;
            this.bkret_remarks_cmb_id.Text = "[ID]";
            this.bkret_remarks_cmb_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bkret_remarks_cmb
            // 
            this.bkret_remarks_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bkret_remarks_cmb.FormattingEnabled = true;
            this.bkret_remarks_cmb.Location = new System.Drawing.Point(199, 85);
            this.bkret_remarks_cmb.Name = "bkret_remarks_cmb";
            this.bkret_remarks_cmb.Size = new System.Drawing.Size(121, 21);
            this.bkret_remarks_cmb.TabIndex = 257;
            this.bkret_remarks_cmb.SelectedIndexChanged += new System.EventHandler(this.bkret_remarks_cmb_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(7, 85);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(179, 20);
            this.label30.TabIndex = 256;
            this.label30.Text = "Book Returns Remarks:";
            // 
            // bkremarks
            // 
            this.bkremarks.Location = new System.Drawing.Point(199, 34);
            this.bkremarks.Name = "bkremarks";
            this.bkremarks.Size = new System.Drawing.Size(189, 20);
            this.bkremarks.TabIndex = 255;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(6, 34);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(118, 20);
            this.label29.TabIndex = 254;
            this.label29.Text = "Book Remarks:";
            // 
            // returnedon
            // 
            this.returnedon.Location = new System.Drawing.Point(199, 59);
            this.returnedon.Name = "returnedon";
            this.returnedon.Size = new System.Drawing.Size(189, 20);
            this.returnedon.TabIndex = 253;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(7, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 20);
            this.label20.TabIndex = 252;
            this.label20.Text = "Returned On:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 30);
            this.label3.TabIndex = 242;
            this.label3.Text = "BOOK REMARKS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // br_staffinfopnl
            // 
            this.br_staffinfopnl.Controls.Add(this.un);
            this.br_staffinfopnl.Controls.Add(this.sel_staff);
            this.br_staffinfopnl.Controls.Add(this.empname);
            this.br_staffinfopnl.Controls.Add(this.un_id);
            this.br_staffinfopnl.Controls.Add(this.label17);
            this.br_staffinfopnl.Controls.Add(this.label21);
            this.br_staffinfopnl.Controls.Add(this.label2);
            this.br_staffinfopnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.br_staffinfopnl.Location = new System.Drawing.Point(0, 284);
            this.br_staffinfopnl.Name = "br_staffinfopnl";
            this.br_staffinfopnl.Size = new System.Drawing.Size(403, 87);
            this.br_staffinfopnl.TabIndex = 258;
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(200, 61);
            this.un.Name = "un";
            this.un.ReadOnly = true;
            this.un.Size = new System.Drawing.Size(125, 20);
            this.un.TabIndex = 262;
            // 
            // sel_staff
            // 
            this.sel_staff.Location = new System.Drawing.Point(331, 62);
            this.sel_staff.Name = "sel_staff";
            this.sel_staff.Size = new System.Drawing.Size(52, 20);
            this.sel_staff.TabIndex = 261;
            this.sel_staff.Text = "Choose";
            this.sel_staff.UseVisualStyleBackColor = true;
            this.sel_staff.Click += new System.EventHandler(this.sel_staff_Click);
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(200, 34);
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            this.empname.Size = new System.Drawing.Size(125, 20);
            this.empname.TabIndex = 260;
            // 
            // un_id
            // 
            this.un_id.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un_id.Location = new System.Drawing.Point(328, 30);
            this.un_id.Name = "un_id";
            this.un_id.Size = new System.Drawing.Size(48, 22);
            this.un_id.TabIndex = 259;
            this.un_id.Text = "[ID]";
            this.un_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(7, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 20);
            this.label17.TabIndex = 258;
            this.label17.Text = "Staff Username:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(7, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 20);
            this.label21.TabIndex = 257;
            this.label21.Text = "Noted By:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 30);
            this.label2.TabIndex = 241;
            this.label2.Text = "STAFF AUTHORIZATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(45, 373);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 20);
            this.label24.TabIndex = 195;
            // 
            // bkr_bkbrinfopnl
            // 
            this.bkr_bkbrinfopnl.Controls.Add(this.bkbr_id);
            this.bkr_bkbrinfopnl.Controls.Add(this.label4);
            this.bkr_bkbrinfopnl.Controls.Add(this.label22);
            this.bkr_bkbrinfopnl.Controls.Add(this.label23);
            this.bkr_bkbrinfopnl.Controls.Add(this.duedt);
            this.bkr_bkbrinfopnl.Controls.Add(this.dtborrowed);
            this.bkr_bkbrinfopnl.Controls.Add(this.bkaut);
            this.bkr_bkbrinfopnl.Controls.Add(this.accno);
            this.bkr_bkbrinfopnl.Controls.Add(this.bktitle);
            this.bkr_bkbrinfopnl.Controls.Add(this.label15);
            this.bkr_bkbrinfopnl.Controls.Add(this.label25);
            this.bkr_bkbrinfopnl.Controls.Add(this.label27);
            this.bkr_bkbrinfopnl.Controls.Add(this.label28);
            this.bkr_bkbrinfopnl.Controls.Add(this.uid);
            this.bkr_bkbrinfopnl.Controls.Add(this.btn_bkbrinfo);
            this.bkr_bkbrinfopnl.Controls.Add(this.label26);
            this.bkr_bkbrinfopnl.Controls.Add(this.label19);
            this.bkr_bkbrinfopnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bkr_bkbrinfopnl.Location = new System.Drawing.Point(0, 0);
            this.bkr_bkbrinfopnl.Name = "bkr_bkbrinfopnl";
            this.bkr_bkbrinfopnl.Size = new System.Drawing.Size(403, 284);
            this.bkr_bkbrinfopnl.TabIndex = 257;
            // 
            // bkbr_id
            // 
            this.bkbr_id.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkbr_id.Location = new System.Drawing.Point(211, 40);
            this.bkbr_id.Name = "bkbr_id";
            this.bkbr_id.Size = new System.Drawing.Size(177, 22);
            this.bkbr_id.TabIndex = 259;
            this.bkbr_id.Text = "[ID]";
            this.bkbr_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 258;
            this.label4.Text = "Book Borrowing Record ID:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(7, 203);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 20);
            this.label22.TabIndex = 257;
            this.label22.Text = "Due Date:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(7, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 20);
            this.label23.TabIndex = 256;
            this.label23.Text = "Date Borrowed:";
            // 
            // duedt
            // 
            this.duedt.Enabled = false;
            this.duedt.Location = new System.Drawing.Point(150, 202);
            this.duedt.Name = "duedt";
            this.duedt.Size = new System.Drawing.Size(238, 20);
            this.duedt.TabIndex = 255;
            // 
            // dtborrowed
            // 
            this.dtborrowed.Enabled = false;
            this.dtborrowed.Location = new System.Drawing.Point(150, 176);
            this.dtborrowed.Name = "dtborrowed";
            this.dtborrowed.Size = new System.Drawing.Size(238, 20);
            this.dtborrowed.TabIndex = 254;
            // 
            // bkaut
            // 
            this.bkaut.Location = new System.Drawing.Point(150, 150);
            this.bkaut.Name = "bkaut";
            this.bkaut.ReadOnly = true;
            this.bkaut.Size = new System.Drawing.Size(238, 20);
            this.bkaut.TabIndex = 253;
            // 
            // accno
            // 
            this.accno.Location = new System.Drawing.Point(150, 123);
            this.accno.Name = "accno";
            this.accno.ReadOnly = true;
            this.accno.Size = new System.Drawing.Size(238, 20);
            this.accno.TabIndex = 251;
            // 
            // bktitle
            // 
            this.bktitle.Location = new System.Drawing.Point(150, 96);
            this.bktitle.Name = "bktitle";
            this.bktitle.ReadOnly = true;
            this.bktitle.Size = new System.Drawing.Size(238, 20);
            this.bktitle.TabIndex = 249;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 49);
            this.label15.TabIndex = 248;
            this.label15.Text = "Select Book Borrowing Record to be Updated";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(7, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 20);
            this.label25.TabIndex = 247;
            this.label25.Text = "Book Title:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(7, 124);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(146, 20);
            this.label27.TabIndex = 246;
            this.label27.Text = "Accession Number:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(7, 151);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(102, 20);
            this.label28.TabIndex = 245;
            this.label28.Text = "Book Author:";
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(151, 68);
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Size = new System.Drawing.Size(237, 20);
            this.uid.TabIndex = 244;
            // 
            // btn_bkbrinfo
            // 
            this.btn_bkbrinfo.Location = new System.Drawing.Point(215, 236);
            this.btn_bkbrinfo.Name = "btn_bkbrinfo";
            this.btn_bkbrinfo.Size = new System.Drawing.Size(168, 34);
            this.btn_bkbrinfo.TabIndex = 243;
            this.btn_bkbrinfo.Text = "Choose";
            this.btn_bkbrinfo.UseVisualStyleBackColor = true;
            this.btn_bkbrinfo.Click += new System.EventHandler(this.btn_bkbrinfo_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(7, 69);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 20);
            this.label26.TabIndex = 241;
            this.label26.Text = "COCPL UID:";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.SteelBlue;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Aquamarine;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(403, 30);
            this.label19.TabIndex = 240;
            this.label19.Text = "INFORMATION OF BOOK TO BE RETURNED";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refbtn
            // 
            this.refbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(948, 53);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 205;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // Admin_BookReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.bkr_pnl);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.brrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.cmbcriteria);
            this.Controls.Add(this.searchinp);
            this.Controls.Add(this.dgv_bookreturns);
            this.Controls.Add(this.refbtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Admin_BookReturns";
            this.Text = "Book Returns";
            this.Load += new System.EventHandler(this.Admin_BookReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookreturns)).EndInit();
            this.bkr_pnl.ResumeLayout(false);
            this.bkr_pnl.PerformLayout();
            this.finespnl.ResumeLayout(false);
            this.finespnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.br_staffinfopnl.ResumeLayout(false);
            this.br_staffinfopnl.PerformLayout();
            this.bkr_bkbrinfopnl.ResumeLayout(false);
            this.bkr_bkbrinfopnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.ComboBox cmbcriteria;
        private System.Windows.Forms.TextBox searchinp;
        private System.Windows.Forms.DataGridView dgv_bookreturns;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Label brrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Timer bkr_timer;
        private System.Windows.Forms.Panel bkr_pnl;
        private System.Windows.Forms.Panel finespnl;
        private System.Windows.Forms.Label paid_id;
        private System.Windows.Forms.ComboBox selpaid;
        public System.Windows.Forms.TextBox finestxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bkret_remarks_cmb_id;
        private System.Windows.Forms.ComboBox bkret_remarks_cmb;
        private System.Windows.Forms.Label label30;
        public System.Windows.Forms.TextBox bkremarks;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox returnedon;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel br_staffinfopnl;
        public System.Windows.Forms.TextBox un;
        private System.Windows.Forms.Button sel_staff;
        public System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.Label un_id;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel bkr_bkbrinfopnl;
        private System.Windows.Forms.Label bkbr_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker duedt;
        private System.Windows.Forms.DateTimePicker dtborrowed;
        public System.Windows.Forms.TextBox bkaut;
        public System.Windows.Forms.TextBox accno;
        public System.Windows.Forms.TextBox bktitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Button btn_bkbrinfo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label19;
    }
}