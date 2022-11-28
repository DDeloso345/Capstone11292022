
namespace Capstone
{
    partial class BKBR_SelectBookInfo
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
            this.clrbtn = new System.Windows.Forms.Button();
            this.refbtn = new System.Windows.Forms.PictureBox();
            this.bkbr_accno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_bkbr = new System.Windows.Forms.DataGridView();
            this.bktitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crit_cmb = new System.Windows.Forms.ComboBox();
            this.bkbr_ui_details = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkbr)).BeginInit();
            this.SuspendLayout();
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(12, 353);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(158, 23);
            this.clrbtn.TabIndex = 116;
            this.clrbtn.Text = "Clear Selection";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // refbtn
            // 
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(647, 30);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 115;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // bkbr_accno
            // 
            this.bkbr_accno.AutoSize = true;
            this.bkbr_accno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkbr_accno.Location = new System.Drawing.Point(224, 68);
            this.bkbr_accno.Name = "bkbr_accno";
            this.bkbr_accno.Size = new System.Drawing.Size(198, 22);
            this.bkbr_accno.TabIndex = 114;
            this.bkbr_accno.Text = "[Book\'s Accession Number]";
            this.bkbr_accno.Click += new System.EventHandler(this.bkbr_accno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "Book\'s Accession Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 22);
            this.label12.TabIndex = 112;
            this.label12.Text = "Search according to...";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(573, 30);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(68, 23);
            this.searchbtn.TabIndex = 111;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(342, 32);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(225, 20);
            this.searchtxt.TabIndex = 110;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
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
            this.label2.TabIndex = 109;
            this.label2.Text = "SELECT BOOK INFORMATION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_bkbr
            // 
            this.dgv_bkbr.AllowUserToAddRows = false;
            this.dgv_bkbr.AllowUserToDeleteRows = false;
            this.dgv_bkbr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bkbr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bkbr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_bkbr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bkbr.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_bkbr.Location = new System.Drawing.Point(12, 167);
            this.dgv_bkbr.Name = "dgv_bkbr";
            this.dgv_bkbr.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bkbr.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_bkbr.Size = new System.Drawing.Size(660, 183);
            this.dgv_bkbr.TabIndex = 108;
            this.dgv_bkbr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bkbr_CellClick);
            this.dgv_bkbr.DoubleClick += new System.EventHandler(this.dgv_bkbr_DoubleClick);
            // 
            // bktitle
            // 
            this.bktitle.AutoSize = true;
            this.bktitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bktitle.Location = new System.Drawing.Point(224, 105);
            this.bktitle.Name = "bktitle";
            this.bktitle.Size = new System.Drawing.Size(94, 22);
            this.bktitle.TabIndex = 118;
            this.bktitle.Text = "[Book Title]";
            this.bktitle.Click += new System.EventHandler(this.bktitle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 117;
            this.label4.Text = "Book Title:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // crit_cmb
            // 
            this.crit_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crit_cmb.FormattingEnabled = true;
            this.crit_cmb.Items.AddRange(new object[] {
            "AccessionNumber",
            "BookTitle",
            "BookAuthor"});
            this.crit_cmb.Location = new System.Drawing.Point(188, 31);
            this.crit_cmb.Name = "crit_cmb";
            this.crit_cmb.Size = new System.Drawing.Size(148, 21);
            this.crit_cmb.TabIndex = 198;
            this.crit_cmb.SelectedIndexChanged += new System.EventHandler(this.crit_cmb_SelectedIndexChanged);
            // 
            // bkbr_ui_details
            // 
            this.bkbr_ui_details.AutoSize = true;
            this.bkbr_ui_details.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkbr_ui_details.Location = new System.Drawing.Point(224, 142);
            this.bkbr_ui_details.Name = "bkbr_ui_details";
            this.bkbr_ui_details.Size = new System.Drawing.Size(108, 22);
            this.bkbr_ui_details.TabIndex = 200;
            this.bkbr_ui_details.Text = "[Book Author]";
            this.bkbr_ui_details.Click += new System.EventHandler(this.bkbr_ui_details_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 199;
            this.label3.Text = "Book Author:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BKBR_SelectBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.bkbr_ui_details);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crit_cmb);
            this.Controls.Add(this.bktitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.bkbr_accno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_bkbr);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 420);
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "BKBR_SelectBookInfo";
            this.Text = "Select Book Information";
            this.Load += new System.EventHandler(this.BKBR_SelectBookInfo_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Label bkbr_accno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_bkbr;
        private System.Windows.Forms.Label bktitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox crit_cmb;
        private System.Windows.Forms.Label bkbr_ui_details;
        private System.Windows.Forms.Label label3;
    }
}