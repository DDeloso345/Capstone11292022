
namespace Capstone
{
    partial class Staff_BKBR_ApprovedNotifs
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
            this.dgv_approvednotifs = new System.Windows.Forms.DataGridView();
            this.refbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_approvednotifs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search according to...";
            // 
            // cmb_crit
            // 
            this.cmb_crit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_crit.FormattingEnabled = true;
            this.cmb_crit.Location = new System.Drawing.Point(173, 34);
            this.cmb_crit.Name = "cmb_crit";
            this.cmb_crit.Size = new System.Drawing.Size(89, 21);
            this.cmb_crit.TabIndex = 16;
            this.cmb_crit.SelectedIndexChanged += new System.EventHandler(this.cmb_crit_SelectedIndexChanged);
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(466, 33);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(75, 23);
            this.srchbtn.TabIndex = 15;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // searchinp
            // 
            this.searchinp.Location = new System.Drawing.Point(268, 35);
            this.searchinp.Name = "searchinp";
            this.searchinp.Size = new System.Drawing.Size(192, 20);
            this.searchinp.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "APPROVED BOOK BORROWING NOTIFICATIONS FROM KIOSK";
            // 
            // dgv_approvednotifs
            // 
            this.dgv_approvednotifs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_approvednotifs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_approvednotifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_approvednotifs.Location = new System.Drawing.Point(12, 61);
            this.dgv_approvednotifs.Name = "dgv_approvednotifs";
            this.dgv_approvednotifs.Size = new System.Drawing.Size(560, 490);
            this.dgv_approvednotifs.TabIndex = 12;
            this.dgv_approvednotifs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_approvednotifs_CellContentClick);
            // 
            // refbtn
            // 
            this.refbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(547, 30);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 18;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // Staff_BKBR_ApprovedNotifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_crit);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.searchinp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_approvednotifs);
            this.Name = "Staff_BKBR_ApprovedNotifs";
            this.Text = "Approved Kiosk Notifications (Book Borrowing)";
            this.Load += new System.EventHandler(this.Staff_BKBR_ApprovedNotifs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_approvednotifs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_crit;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox searchinp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_approvednotifs;
        private System.Windows.Forms.PictureBox refbtn;
    }
}