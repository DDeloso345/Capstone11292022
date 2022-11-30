
namespace Capstone
{
    partial class InsertORNoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.ornumberinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberuid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert OR Number from client\'s receipt:";
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(347, 76);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 2;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // ornumberinput
            // 
            this.ornumberinput.Location = new System.Drawing.Point(206, 32);
            this.ornumberinput.MaxLength = 8;
            this.ornumberinput.Name = "ornumberinput";
            this.ornumberinput.Size = new System.Drawing.Size(170, 20);
            this.ornumberinput.TabIndex = 3;
            this.ornumberinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ornumberinput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Member\'s UID:";
            // 
            // memberuid
            // 
            this.memberuid.AutoSize = true;
            this.memberuid.Location = new System.Drawing.Point(203, 61);
            this.memberuid.Name = "memberuid";
            this.memberuid.Size = new System.Drawing.Size(79, 13);
            this.memberuid.TabIndex = 5;
            this.memberuid.Text = "Member Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "COCPL MEMBERSHIP RENEWAL FORM";
            // 
            // InsertORNoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 111);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memberuid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ornumberinput);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(450, 150);
            this.MinimumSize = new System.Drawing.Size(450, 150);
            this.Name = "InsertORNoForm";
            this.Text = "Insert Official Receipt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertORNoForm_FormClosing);
            this.Load += new System.EventHandler(this.InsertORNoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox ornumberinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label memberuid;
        private System.Windows.Forms.Label label3;
    }
}