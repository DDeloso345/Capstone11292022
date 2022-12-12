
namespace Capstone
{
    partial class SelectBKINVPublisher_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.refbtn = new System.Windows.Forms.PictureBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.orgid = new System.Windows.Forms.Label();
            this.pubinp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dgv_sel_org = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sel_org)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 27);
            this.label2.TabIndex = 128;
            this.label2.Text = "SELECT BOOK PUBLISHER";
            // 
            // refbtn
            // 
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(542, 40);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 126;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(446, 300);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(68, 23);
            this.clearbtn.TabIndex = 125;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Enabled = false;
            this.delbtn.Location = new System.Drawing.Point(317, 300);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(123, 23);
            this.delbtn.TabIndex = 124;
            this.delbtn.Text = "Delete Book Publisher";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.Enabled = false;
            this.updbtn.Location = new System.Drawing.Point(170, 300);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(141, 23);
            this.updbtn.TabIndex = 123;
            this.updbtn.Text = "Update Book Publisher";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(19, 300);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(145, 23);
            this.insertbtn.TabIndex = 122;
            this.insertbtn.Text = "Insert New Book Publisher";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // orgid
            // 
            this.orgid.AutoSize = true;
            this.orgid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgid.Location = new System.Drawing.Point(145, 78);
            this.orgid.Name = "orgid";
            this.orgid.Size = new System.Drawing.Size(87, 22);
            this.orgid.TabIndex = 121;
            this.orgid.Text = "[BKPUB ID]";
            // 
            // pubinp
            // 
            this.pubinp.Location = new System.Drawing.Point(237, 79);
            this.pubinp.MaxLength = 32625;
            this.pubinp.Name = "pubinp";
            this.pubinp.Size = new System.Drawing.Size(330, 20);
            this.pubinp.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 119;
            this.label1.Text = "Publisher ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 22);
            this.label12.TabIndex = 118;
            this.label12.Text = "Search Book Publisher...";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(468, 40);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(68, 23);
            this.searchbtn.TabIndex = 117;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(237, 42);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(225, 20);
            this.searchtxt.TabIndex = 116;
            // 
            // dgv_sel_org
            // 
            this.dgv_sel_org.AllowUserToAddRows = false;
            this.dgv_sel_org.AllowUserToDeleteRows = false;
            this.dgv_sel_org.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sel_org.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sel_org.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sel_org.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sel_org.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sel_org.Location = new System.Drawing.Point(21, 110);
            this.dgv_sel_org.Name = "dgv_sel_org";
            this.dgv_sel_org.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sel_org.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sel_org.Size = new System.Drawing.Size(546, 183);
            this.dgv_sel_org.TabIndex = 115;
            this.dgv_sel_org.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sel_org_CellClick);
            this.dgv_sel_org.DoubleClick += new System.EventHandler(this.dgv_sel_org_DoubleClick);
            // 
            // SelectBKINVPublisher_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.orgid);
            this.Controls.Add(this.pubinp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dgv_sel_org);
            this.MaximumSize = new System.Drawing.Size(600, 380);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "SelectBKINVPublisher_Admin";
            this.Text = "Select Book Publisher";
            this.Load += new System.EventHandler(this.SelectBKINVPublisher_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sel_org)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Label orgid;
        private System.Windows.Forms.TextBox pubinp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dgv_sel_org;
    }
}