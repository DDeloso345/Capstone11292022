
namespace Capstone
{
    partial class ORHistoryStaff
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
            this.orreceived = new System.Windows.Forms.TextBox();
            this.clr_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.ornumbtxt = new System.Windows.Forms.TextBox();
            this.dgv_or_history = new System.Windows.Forms.DataGridView();
            this.uidlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbfilter = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_or_history)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orreceived
            // 
            this.orreceived.Location = new System.Drawing.Point(185, 116);
            this.orreceived.Name = "orreceived";
            this.orreceived.Size = new System.Drawing.Size(219, 20);
            this.orreceived.TabIndex = 36;
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(987, 219);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(75, 23);
            this.clr_btn.TabIndex = 35;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date and time received:";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(182, 9);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(58, 16);
            this.idlbl.TabIndex = 33;
            this.idlbl.Text = "[ID Txt]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "OR Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID:";
            // 
            // update_btn
            // 
            this.update_btn.Enabled = false;
            this.update_btn.Location = new System.Drawing.Point(907, 219);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 28;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // ornumbtxt
            // 
            this.ornumbtxt.Location = new System.Drawing.Point(185, 77);
            this.ornumbtxt.MaxLength = 8;
            this.ornumbtxt.Name = "ornumbtxt";
            this.ornumbtxt.Size = new System.Drawing.Size(219, 20);
            this.ornumbtxt.TabIndex = 24;
            // 
            // dgv_or_history
            // 
            this.dgv_or_history.AllowUserToAddRows = false;
            this.dgv_or_history.AllowUserToDeleteRows = false;
            this.dgv_or_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_or_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_or_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_or_history.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_or_history.Location = new System.Drawing.Point(11, 68);
            this.dgv_or_history.Name = "dgv_or_history";
            this.dgv_or_history.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_or_history.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_or_history.Size = new System.Drawing.Size(630, 278);
            this.dgv_or_history.TabIndex = 21;
            this.dgv_or_history.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_or_history_CellClick);
            // 
            // uidlbl
            // 
            this.uidlbl.AutoSize = true;
            this.uidlbl.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidlbl.Location = new System.Drawing.Point(182, 42);
            this.uidlbl.Name = "uidlbl";
            this.uidlbl.Size = new System.Drawing.Size(89, 16);
            this.uidlbl.TabIndex = 38;
            this.uidlbl.Text = "COCPL UID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "COCPL UID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "OR Receipt Records";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orreceived);
            this.panel1.Controls.Add(this.ornumbtxt);
            this.panel1.Controls.Add(this.uidlbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.idlbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(647, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 143);
            this.panel1.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Search according to:";
            // 
            // cmbfilter
            // 
            this.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfilter.FormattingEnabled = true;
            this.cmbfilter.Location = new System.Drawing.Point(183, 44);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(99, 21);
            this.cmbfilter.TabIndex = 43;
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(573, 42);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(68, 23);
            this.searchbtn.TabIndex = 42;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(288, 45);
            this.searchtxt.MaxLength = 8;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(280, 20);
            this.searchtxt.TabIndex = 41;
            // 
            // ORHistoryStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1064, 361);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.dgv_or_history);
            this.MaximumSize = new System.Drawing.Size(1080, 400);
            this.MinimumSize = new System.Drawing.Size(1080, 400);
            this.Name = "ORHistoryStaff";
            this.Text = "Official Receipts History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ORHistoryStaff_FormClosing);
            this.Load += new System.EventHandler(this.ORHistoryStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_or_history)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orreceived;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox ornumbtxt;
        private System.Windows.Forms.DataGridView dgv_or_history;
        private System.Windows.Forms.Label uidlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbfilter;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
    }
}