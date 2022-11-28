
namespace Capstone
{
    partial class Admin_Staff_Acc_Management
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
            this.idlbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.positioncombobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contactnotxt = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmbbox_criteria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.inputsearchbar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.middlenametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.hierarchylvltxt = new System.Windows.Forms.ComboBox();
            this.btn_imgbrowse = new System.Windows.Forms.Button();
            this.imgpathtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_admin_acc_tbl = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.suffixtxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_acc_tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(183, 134);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(64, 22);
            this.idlbl.TabIndex = 120;
            this.idlbl.Text = "[ID Txt]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 22);
            this.label11.TabIndex = 119;
            this.label11.Text = "ID:";
            // 
            // positioncombobox
            // 
            this.positioncombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positioncombobox.FormattingEnabled = true;
            this.positioncombobox.Items.AddRange(new object[] {
            "Librarian I",
            "Librarian II",
            "Librarian III",
            "Librarian IV"});
            this.positioncombobox.Location = new System.Drawing.Point(187, 461);
            this.positioncombobox.Name = "positioncombobox";
            this.positioncombobox.Size = new System.Drawing.Size(219, 21);
            this.positioncombobox.TabIndex = 118;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 117;
            this.label10.Text = "Contact No.:";
            // 
            // contactnotxt
            // 
            this.contactnotxt.Location = new System.Drawing.Point(187, 331);
            this.contactnotxt.MaxLength = 11;
            this.contactnotxt.Name = "contactnotxt";
            this.contactnotxt.Size = new System.Drawing.Size(219, 20);
            this.contactnotxt.TabIndex = 116;
            this.contactnotxt.Text = "09";
            this.contactnotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactnotxt_KeyPress);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(253, 530);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 35);
            this.btn_clear.TabIndex = 115;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cmbbox_criteria
            // 
            this.cmbbox_criteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_criteria.FormattingEnabled = true;
            this.cmbbox_criteria.Items.AddRange(new object[] {
            "First Name",
            "Middle Name ",
            "Last Name",
            "Suffix",
            "Position",
            "E-mail Address",
            "Contact No.",
            "Username",
            "Password",
            "Image Path",
            "Active Status"});
            this.cmbbox_criteria.Location = new System.Drawing.Point(187, 105);
            this.cmbbox_criteria.Name = "cmbbox_criteria";
            this.cmbbox_criteria.Size = new System.Drawing.Size(149, 21);
            this.cmbbox_criteria.TabIndex = 114;
            this.cmbbox_criteria.SelectedIndexChanged += new System.EventHandler(this.cmbbox_criteria_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 22);
            this.label9.TabIndex = 113;
            this.label9.Text = "Search according to:";
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.Location = new System.Drawing.Point(902, 104);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 112;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // inputsearchbar
            // 
            this.inputsearchbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputsearchbar.Location = new System.Drawing.Point(342, 106);
            this.inputsearchbar.Name = "inputsearchbar";
            this.inputsearchbar.Size = new System.Drawing.Size(554, 20);
            this.inputsearchbar.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 110;
            this.label8.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 109;
            this.label7.Text = "Hierarchy Lvl:";
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btn_delete.Location = new System.Drawing.Point(172, 530);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 35);
            this.btn_delete.TabIndex = 108;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(91, 530);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 35);
            this.btn_update.TabIndex = 107;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(187, 396);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(219, 20);
            this.passwordtxt.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 105;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 104;
            this.label5.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 103;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 102;
            this.label3.Text = "Last Name:";
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(187, 169);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(219, 20);
            this.firstnametxt.TabIndex = 101;
            this.firstnametxt.Leave += new System.EventHandler(this.firstnametxt_Leave);
            // 
            // middlenametxt
            // 
            this.middlenametxt.Location = new System.Drawing.Point(187, 199);
            this.middlenametxt.Name = "middlenametxt";
            this.middlenametxt.Size = new System.Drawing.Size(219, 20);
            this.middlenametxt.TabIndex = 100;
            this.middlenametxt.Leave += new System.EventHandler(this.middlenametxt_Leave);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(187, 299);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(219, 20);
            this.emailtxt.TabIndex = 99;
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(187, 230);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(219, 20);
            this.lastnametxt.TabIndex = 98;
            this.lastnametxt.Leave += new System.EventHandler(this.lastnametxt_Leave);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(187, 364);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(219, 20);
            this.usernametxt.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 96;
            this.label2.Text = "Middle Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 94;
            this.label1.Text = "First Name:";
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(5, 530);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 35);
            this.btn_insert.TabIndex = 93;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Aquamarine;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(984, 46);
            this.label12.TabIndex = 122;
            this.label12.Text = "STAFF ACCOUNT MANAGEMENT";
            // 
            // hierarchylvltxt
            // 
            this.hierarchylvltxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hierarchylvltxt.FormattingEnabled = true;
            this.hierarchylvltxt.Items.AddRange(new object[] {
            "Administrator",
            "Staff"});
            this.hierarchylvltxt.Location = new System.Drawing.Point(187, 429);
            this.hierarchylvltxt.Name = "hierarchylvltxt";
            this.hierarchylvltxt.Size = new System.Drawing.Size(219, 21);
            this.hierarchylvltxt.TabIndex = 123;
            this.hierarchylvltxt.SelectedIndexChanged += new System.EventHandler(this.hierarchylvltxt_SelectedIndexChanged);
            // 
            // btn_imgbrowse
            // 
            this.btn_imgbrowse.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imgbrowse.Location = new System.Drawing.Point(342, 494);
            this.btn_imgbrowse.Name = "btn_imgbrowse";
            this.btn_imgbrowse.Size = new System.Drawing.Size(64, 20);
            this.btn_imgbrowse.TabIndex = 171;
            this.btn_imgbrowse.Text = "Browse";
            this.btn_imgbrowse.UseVisualStyleBackColor = true;
            this.btn_imgbrowse.Click += new System.EventHandler(this.btn_imgbrowse_Click);
            // 
            // imgpathtxt
            // 
            this.imgpathtxt.Location = new System.Drawing.Point(186, 494);
            this.imgpathtxt.MaxLength = 10;
            this.imgpathtxt.Name = "imgpathtxt";
            this.imgpathtxt.ReadOnly = true;
            this.imgpathtxt.Size = new System.Drawing.Size(150, 20);
            this.imgpathtxt.TabIndex = 170;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 494);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 169;
            this.label14.Text = "Image Path:";
            // 
            // dgv_admin_acc_tbl
            // 
            this.dgv_admin_acc_tbl.AllowUserToDeleteRows = false;
            this.dgv_admin_acc_tbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_admin_acc_tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_admin_acc_tbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_admin_acc_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_acc_tbl.Location = new System.Drawing.Point(412, 132);
            this.dgv_admin_acc_tbl.Name = "dgv_admin_acc_tbl";
            this.dgv_admin_acc_tbl.ReadOnly = true;
            this.dgv_admin_acc_tbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_admin_acc_tbl.Size = new System.Drawing.Size(560, 503);
            this.dgv_admin_acc_tbl.TabIndex = 95;
            this.dgv_admin_acc_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admin_acc_tbl_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 22);
            this.label13.TabIndex = 173;
            this.label13.Text = "Suffix";
            // 
            // suffixtxt
            // 
            this.suffixtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suffixtxt.FormattingEnabled = true;
            this.suffixtxt.Items.AddRange(new object[] {
            "N/A",
            "Sr.",
            "Jr."});
            this.suffixtxt.Location = new System.Drawing.Point(187, 263);
            this.suffixtxt.Name = "suffixtxt";
            this.suffixtxt.Size = new System.Drawing.Size(220, 21);
            this.suffixtxt.TabIndex = 172;
            // 
            // Admin_Staff_Acc_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 644);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.suffixtxt);
            this.Controls.Add(this.btn_imgbrowse);
            this.Controls.Add(this.imgpathtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.hierarchylvltxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.positioncombobox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.contactnotxt);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmbbox_criteria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.inputsearchbar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.middlenametxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_admin_acc_tbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_insert);
            this.Name = "Admin_Staff_Acc_Management";
            this.Text = "Staff Account Management";
            this.Load += new System.EventHandler(this.Admin_Staff_Acc_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_acc_tbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox positioncombobox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox contactnotxt;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmbbox_criteria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox inputsearchbar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.TextBox middlenametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox hierarchylvltxt;
        private System.Windows.Forms.Button btn_imgbrowse;
        private System.Windows.Forms.TextBox imgpathtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_admin_acc_tbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox suffixtxt;
    }
}