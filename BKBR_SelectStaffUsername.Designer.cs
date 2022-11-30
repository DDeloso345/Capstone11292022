
namespace Capstone
{
    partial class BKBR_SelectStaffUsername
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
            this.crit_cmb = new System.Windows.Forms.ComboBox();
            this.un = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clrbtn = new System.Windows.Forms.Button();
            this.refbtn = new System.Windows.Forms.PictureBox();
            this.bkbr_staffname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_bkbr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkbr)).BeginInit();
            this.SuspendLayout();
            // 
            // crit_cmb
            // 
            this.crit_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crit_cmb.FormattingEnabled = true;
            this.crit_cmb.Items.AddRange(new object[] {
            "Staff_Name",
            "Username"});
            this.crit_cmb.Location = new System.Drawing.Point(188, 38);
            this.crit_cmb.Name = "crit_cmb";
            this.crit_cmb.Size = new System.Drawing.Size(148, 21);
            this.crit_cmb.TabIndex = 210;
            this.crit_cmb.SelectedIndexChanged += new System.EventHandler(this.crit_cmb_SelectedIndexChanged);
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.Location = new System.Drawing.Point(224, 112);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(97, 22);
            this.un.TabIndex = 209;
            this.un.Text = "[USERNAME]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 208;
            this.label4.Text = "Username";
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(12, 330);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(150, 23);
            this.clrbtn.TabIndex = 207;
            this.clrbtn.Text = "Clear Selection";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // refbtn
            // 
            this.refbtn.Image = global::Capstone.Properties.Resources.pngwing_com;
            this.refbtn.Location = new System.Drawing.Point(647, 37);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(25, 25);
            this.refbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refbtn.TabIndex = 206;
            this.refbtn.TabStop = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // bkbr_staffname
            // 
            this.bkbr_staffname.AutoSize = true;
            this.bkbr_staffname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkbr_staffname.Location = new System.Drawing.Point(224, 75);
            this.bkbr_staffname.Name = "bkbr_staffname";
            this.bkbr_staffname.Size = new System.Drawing.Size(106, 22);
            this.bkbr_staffname.TabIndex = 205;
            this.bkbr_staffname.Text = "[STAFF NAME]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 204;
            this.label1.Text = "Staff\'s Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 22);
            this.label12.TabIndex = 203;
            this.label12.Text = "Search according to...";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(573, 37);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(68, 23);
            this.searchbtn.TabIndex = 202;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(342, 39);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(225, 20);
            this.searchtxt.TabIndex = 201;
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
            this.label2.TabIndex = 200;
            this.label2.Text = "SELECT STAFF INFORMATION";
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
            this.dgv_bkbr.Location = new System.Drawing.Point(12, 141);
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
            this.dgv_bkbr.TabIndex = 199;
            this.dgv_bkbr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bkbr_CellClick);
            this.dgv_bkbr.DoubleClick += new System.EventHandler(this.dgv_bkbr_DoubleClick);
            // 
            // BKBR_SelectStaffUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.crit_cmb);
            this.Controls.Add(this.un);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.bkbr_staffname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_bkbr);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "BKBR_SelectStaffUsername";
            this.Text = "Select Staff\'s Information";
            this.Load += new System.EventHandler(this.BKBR_SelectStaffUsername_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox crit_cmb;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.PictureBox refbtn;
        private System.Windows.Forms.Label bkbr_staffname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_bkbr;
    }
}