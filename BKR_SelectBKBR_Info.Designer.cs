
namespace Capstone
{
    partial class BKR_SelectBKBR_Info
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bkaut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crit_cmb = new System.Windows.Forms.ComboBox();
            this.bktitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clrbtn = new System.Windows.Forms.Button();
            this.refbtn = new System.Windows.Forms.PictureBox();
            this.accno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_bkr = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.duedt = new System.Windows.Forms.DateTimePicker();
            this.dtborrowed = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bkbr_ref_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkr)).BeginInit();
            this.SuspendLayout();
            // 
            // bkaut
            // 
            this.bkaut.AutoSize = true;
            this.bkaut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkaut.Location = new System.Drawing.Point(224, 208);
            this.bkaut.Name = "bkaut";
            this.bkaut.Size = new System.Drawing.Size(108, 22);
            this.bkaut.TabIndex = 214;
            this.bkaut.Text = "[Book Author]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 213;
            this.label3.Text = "Book Author:";
            // 
            // crit_cmb
            // 
            this.crit_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crit_cmb.FormattingEnabled = true;
            this.crit_cmb.Items.AddRange(new object[] {
            "AccessionNumber",
            "BookTitle",
            "BookAuthor"});
            this.crit_cmb.Location = new System.Drawing.Point(188, 33);
            this.crit_cmb.Name = "crit_cmb";
            this.crit_cmb.Size = new System.Drawing.Size(148, 21);
            this.crit_cmb.TabIndex = 212;
            this.crit_cmb.SelectedIndexChanged += new System.EventHandler(this.crit_cmb_SelectedIndexChanged);
            // 
            // bktitle
            // 
            this.bktitle.AutoSize = true;
            this.bktitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bktitle.Location = new System.Drawing.Point(224, 171);
            this.bktitle.Name = "bktitle";
            this.bktitle.Size = new System.Drawing.Size(94, 22);
            this.bktitle.TabIndex = 211;
            this.bktitle.Text = "[Book Title]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 210;
            this.label4.Text = "Book Title:";
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(12, 529);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(145, 23);
            this.clrbtn.TabIndex = 209;
            this.clrbtn.Text = "Clear Selection";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // refbtn
            // 
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(647, 32);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 208;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // accno
            // 
            this.accno.AutoSize = true;
            this.accno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accno.Location = new System.Drawing.Point(224, 134);
            this.accno.Name = "accno";
            this.accno.Size = new System.Drawing.Size(198, 22);
            this.accno.TabIndex = 207;
            this.accno.Text = "[Book\'s Accession Number]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 206;
            this.label1.Text = "Book\'s Accession Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 22);
            this.label12.TabIndex = 205;
            this.label12.Text = "Search according to...";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(573, 32);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(68, 23);
            this.searchbtn.TabIndex = 204;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(342, 34);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(225, 20);
            this.searchtxt.TabIndex = 203;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 27);
            this.label2.TabIndex = 202;
            this.label2.Text = "SELECT BOOK BORROWING RECORD";
            // 
            // dgv_bkr
            // 
            this.dgv_bkr.AllowUserToAddRows = false;
            this.dgv_bkr.AllowUserToDeleteRows = false;
            this.dgv_bkr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bkr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bkr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_bkr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bkr.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_bkr.Location = new System.Drawing.Point(12, 315);
            this.dgv_bkr.Name = "dgv_bkr";
            this.dgv_bkr.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bkr.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_bkr.Size = new System.Drawing.Size(660, 208);
            this.dgv_bkr.TabIndex = 201;
            this.dgv_bkr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bkr_CellClick);
            this.dgv_bkr.Click += new System.EventHandler(this.dgv_bkr_Click);
            this.dgv_bkr.DoubleClick += new System.EventHandler(this.dgv_bkr_DoubleClick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(10, 282);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 22);
            this.label22.TabIndex = 261;
            this.label22.Text = "Due Date:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(10, 245);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 22);
            this.label23.TabIndex = 260;
            this.label23.Text = "Date Borrowed:";
            // 
            // duedt
            // 
            this.duedt.Enabled = false;
            this.duedt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedt.Location = new System.Drawing.Point(228, 282);
            this.duedt.Name = "duedt";
            this.duedt.Size = new System.Drawing.Size(277, 26);
            this.duedt.TabIndex = 259;
            // 
            // dtborrowed
            // 
            this.dtborrowed.Enabled = false;
            this.dtborrowed.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtborrowed.Location = new System.Drawing.Point(228, 241);
            this.dtborrowed.Name = "dtborrowed";
            this.dtborrowed.Size = new System.Drawing.Size(277, 26);
            this.dtborrowed.TabIndex = 258;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 262;
            this.label5.Text = "COCPL UID:";
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid.Location = new System.Drawing.Point(224, 97);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(110, 22);
            this.uid.TabIndex = 263;
            this.uid.Text = "[COCPLM UID]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 22);
            this.label7.TabIndex = 264;
            this.label7.Text = "Book Borrowing Record ID:";
            // 
            // bkbr_ref_id
            // 
            this.bkbr_ref_id.AutoSize = true;
            this.bkbr_ref_id.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkbr_ref_id.Location = new System.Drawing.Point(224, 64);
            this.bkbr_ref_id.Name = "bkbr_ref_id";
            this.bkbr_ref_id.Size = new System.Drawing.Size(36, 22);
            this.bkbr_ref_id.TabIndex = 265;
            this.bkbr_ref_id.Text = "[ID]";
            // 
            // BKR_SelectBKBR_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.bkbr_ref_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.duedt);
            this.Controls.Add(this.dtborrowed);
            this.Controls.Add(this.bkaut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crit_cmb);
            this.Controls.Add(this.bktitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.accno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_bkr);
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "BKR_SelectBKBR_Info";
            this.Text = "BKR_SelectBKBR_Info";
            this.Load += new System.EventHandler(this.BKR_SelectBKBR_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bkaut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox crit_cmb;
        private System.Windows.Forms.Label bktitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Label accno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_bkr;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker duedt;
        private System.Windows.Forms.DateTimePicker dtborrowed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bkbr_ref_id;
    }
}