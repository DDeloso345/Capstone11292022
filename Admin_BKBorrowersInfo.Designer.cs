
namespace Capstone
{
    partial class Admin_BKBorrowersInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_crit = new System.Windows.Forms.ComboBox();
            this.srchbtn = new System.Windows.Forms.Button();
            this.searchinp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_bkbr_ind = new System.Windows.Forms.DataGridView();
            this.selmemb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.uidtxt = new System.Windows.Forms.Label();
            this.bkbrinfopnl = new System.Windows.Forms.Panel();
            this.refbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkbr_ind)).BeginInit();
            this.bkbrinfopnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search according to...";
            // 
            // cmb_crit
            // 
            this.cmb_crit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_crit.FormattingEnabled = true;
            this.cmb_crit.Items.AddRange(new object[] {
            "BookTitle",
            "AccessionNumber",
            "BookAuthor",
            "DateBorrowed",
            "DueDate",
            "ApprovedBy",
            "ApprovedOn"});
            this.cmb_crit.Location = new System.Drawing.Point(188, 78);
            this.cmb_crit.Name = "cmb_crit";
            this.cmb_crit.Size = new System.Drawing.Size(89, 21);
            this.cmb_crit.TabIndex = 18;
            this.cmb_crit.SelectedIndexChanged += new System.EventHandler(this.cmb_crit_SelectedIndexChanged);
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(466, 77);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(75, 23);
            this.srchbtn.TabIndex = 17;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // searchinp
            // 
            this.searchinp.Location = new System.Drawing.Point(287, 78);
            this.searchinp.Name = "searchinp";
            this.searchinp.Size = new System.Drawing.Size(173, 20);
            this.searchinp.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "BOOKS BORROWED BY AN INDIVIDUAL MEMBER";
            // 
            // dgv_bkbr_ind
            // 
            this.dgv_bkbr_ind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_bkbr_ind.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_bkbr_ind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bkbr_ind.Location = new System.Drawing.Point(19, 59);
            this.dgv_bkbr_ind.Name = "dgv_bkbr_ind";
            this.dgv_bkbr_ind.Size = new System.Drawing.Size(560, 489);
            this.dgv_bkbr_ind.TabIndex = 14;
            this.dgv_bkbr_ind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bkbr_ind_CellContentClick);
            // 
            // selmemb
            // 
            this.selmemb.DropDownHeight = 65;
            this.selmemb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selmemb.FormattingEnabled = true;
            this.selmemb.IntegralHeight = false;
            this.selmemb.Location = new System.Drawing.Point(187, 50);
            this.selmemb.Name = "selmemb";
            this.selmemb.Size = new System.Drawing.Size(273, 21);
            this.selmemb.TabIndex = 21;
            this.selmemb.SelectedIndexChanged += new System.EventHandler(this.selmemb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select COCPL Member:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "COCPL UID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Book Borrower\'s Name: ";
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(197, 36);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(105, 20);
            this.nametxt.TabIndex = 28;
            this.nametxt.Text = "Middle Name:";
            // 
            // uidtxt
            // 
            this.uidtxt.AutoSize = true;
            this.uidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidtxt.Location = new System.Drawing.Point(197, 9);
            this.uidtxt.Name = "uidtxt";
            this.uidtxt.Size = new System.Drawing.Size(90, 20);
            this.uidtxt.TabIndex = 27;
            this.uidtxt.Text = "First Name:";
            // 
            // bkbrinfopnl
            // 
            this.bkbrinfopnl.Controls.Add(this.nametxt);
            this.bkbrinfopnl.Controls.Add(this.uidtxt);
            this.bkbrinfopnl.Controls.Add(this.dgv_bkbr_ind);
            this.bkbrinfopnl.Controls.Add(this.label5);
            this.bkbrinfopnl.Controls.Add(this.label4);
            this.bkbrinfopnl.Location = new System.Drawing.Point(4, 106);
            this.bkbrinfopnl.Name = "bkbrinfopnl";
            this.bkbrinfopnl.Size = new System.Drawing.Size(600, 570);
            this.bkbrinfopnl.TabIndex = 29;
            // 
            // refbtn
            // 
            this.refbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(547, 73);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 20;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // Admin_BKBorrowersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selmemb);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_crit);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.searchinp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bkbrinfopnl);
            this.MaximumSize = new System.Drawing.Size(625, 714);
            this.MinimumSize = new System.Drawing.Size(625, 714);
            this.Name = "Admin_BKBorrowersInfo";
            this.Text = "Individual Member\'s Book Borrowing Records";
            this.Load += new System.EventHandler(this.Admin_BKBorrowersInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkbr_ind)).EndInit();
            this.bkbrinfopnl.ResumeLayout(false);
            this.bkbrinfopnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_crit;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox searchinp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_bkbr_ind;
        private System.Windows.Forms.ComboBox selmemb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label uidtxt;
        private System.Windows.Forms.Panel bkbrinfopnl;
    }
}