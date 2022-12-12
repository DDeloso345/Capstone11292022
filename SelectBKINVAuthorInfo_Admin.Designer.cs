
namespace Capstone
{
    partial class SelectBKINVAuthorInfo_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.auttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crit_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refbtn = new System.Windows.Forms.PictureBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.orgid = new System.Windows.Forms.Label();
            this.autnotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dgv_sel_org = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sel_org)).BeginInit();
            this.SuspendLayout();
            // 
            // auttxt
            // 
            this.auttxt.Location = new System.Drawing.Point(195, 152);
            this.auttxt.MaxLength = 32625;
            this.auttxt.Name = "auttxt";
            this.auttxt.Size = new System.Drawing.Size(458, 20);
            this.auttxt.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 163;
            this.label4.Text = "Author Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 162;
            this.label3.Text = "Author(s):";
            // 
            // crit_cmb
            // 
            this.crit_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crit_cmb.FormattingEnabled = true;
            this.crit_cmb.Items.AddRange(new object[] {
            "AuthorNo",
            "BookAuthor"});
            this.crit_cmb.Location = new System.Drawing.Point(195, 43);
            this.crit_cmb.Name = "crit_cmb";
            this.crit_cmb.Size = new System.Drawing.Size(121, 21);
            this.crit_cmb.TabIndex = 161;
            this.crit_cmb.SelectedIndexChanged += new System.EventHandler(this.crit_cmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 27);
            this.label2.TabIndex = 160;
            this.label2.Text = "SELECT BOOK AUTHOR\'S INFORMATION";
            // 
            // refbtn
            // 
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(627, 42);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 158;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(542, 380);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(68, 23);
            this.clearbtn.TabIndex = 157;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Enabled = false;
            this.delbtn.Location = new System.Drawing.Point(373, 380);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(163, 23);
            this.delbtn.TabIndex = 156;
            this.delbtn.Text = "Delete Author\'s Information";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.Enabled = false;
            this.updbtn.Location = new System.Drawing.Point(209, 380);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(158, 23);
            this.updbtn.TabIndex = 155;
            this.updbtn.Text = "Update Author\'s Information";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(19, 380);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(186, 23);
            this.insertbtn.TabIndex = 154;
            this.insertbtn.Text = "Insert New Author\'s Information";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // orgid
            // 
            this.orgid.AutoSize = true;
            this.orgid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgid.Location = new System.Drawing.Point(203, 78);
            this.orgid.Name = "orgid";
            this.orgid.Size = new System.Drawing.Size(69, 22);
            this.orgid.TabIndex = 153;
            this.orgid.Text = "[AUT ID]";
            // 
            // autnotxt
            // 
            this.autnotxt.Location = new System.Drawing.Point(195, 115);
            this.autnotxt.MaxLength = 32625;
            this.autnotxt.Name = "autnotxt";
            this.autnotxt.Size = new System.Drawing.Size(458, 20);
            this.autnotxt.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 151;
            this.label1.Text = "Author\'s Information ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 22);
            this.label12.TabIndex = 150;
            this.label12.Text = "Search according to...";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(553, 42);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(68, 23);
            this.searchbtn.TabIndex = 149;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(322, 44);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(225, 20);
            this.searchtxt.TabIndex = 148;
            // 
            // dgv_sel_org
            // 
            this.dgv_sel_org.AllowUserToAddRows = false;
            this.dgv_sel_org.AllowUserToDeleteRows = false;
            this.dgv_sel_org.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sel_org.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sel_org.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_sel_org.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sel_org.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_sel_org.Location = new System.Drawing.Point(19, 190);
            this.dgv_sel_org.Name = "dgv_sel_org";
            this.dgv_sel_org.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sel_org.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_sel_org.Size = new System.Drawing.Size(634, 183);
            this.dgv_sel_org.TabIndex = 147;
            this.dgv_sel_org.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sel_org_CellClick);
            this.dgv_sel_org.DoubleClick += new System.EventHandler(this.dgv_sel_org_DoubleClick);
            // 
            // SelectBKINVAuthorInfo_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.auttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crit_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.orgid);
            this.Controls.Add(this.autnotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dgv_sel_org);
            this.MaximumSize = new System.Drawing.Size(700, 470);
            this.MinimumSize = new System.Drawing.Size(700, 470);
            this.Name = "SelectBKINVAuthorInfo_Admin";
            this.Text = "Select Author Information";
            this.Load += new System.EventHandler(this.SelectBKINVAuthorInfo_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sel_org)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox auttxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox crit_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Label orgid;
        private System.Windows.Forms.TextBox autnotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dgv_sel_org;
    }
}