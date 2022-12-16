
namespace Capstone
{
    partial class LogInForm
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.pw_lbl = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(72, 156);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(77, 17);
            this.username_lbl.TabIndex = 4;
            this.username_lbl.Text = "Username:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(433, 246);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 28);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(176, 153);
            this.txtbox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(477, 22);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_username_KeyDown);
            // 
            // pw_lbl
            // 
            this.pw_lbl.AutoSize = true;
            this.pw_lbl.Location = new System.Drawing.Point(72, 208);
            this.pw_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pw_lbl.Name = "pw_lbl";
            this.pw_lbl.Size = new System.Drawing.Size(73, 17);
            this.pw_lbl.TabIndex = 5;
            this.pw_lbl.Text = "Password:";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(176, 204);
            this.txtbox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(477, 22);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.UseSystemPasswordChar = true;
            this.txtbox_password.TextChanged += new System.EventHandler(this.txtbox_password_TextChanged);
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_password_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(555, 246);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.Location = new System.Drawing.Point(157, 79);
            this.login_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(486, 64);
            this.login_lbl.TabIndex = 6;
            this.login_lbl.Text = "Cagayan De Oro City Public Library \r\nInformation Management System";
            this.login_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capstone.Properties.Resources.cancel_1294426_1280;
            this.pictureBox2.Location = new System.Drawing.Point(627, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capstone.Properties.Resources.Cagayan_de_Oro_official_seal_2C_2014_png__77847__thumb;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(675, 300);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.pw_lbl);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.username_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogInForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label pw_lbl;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label login_lbl;
        public System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}