using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capstone
{
    public partial class MemberIDPreview : Form
    {
        public MemberIDPreview()
        {
            InitializeComponent();

        }
        SQLIDPreviewCommandsClass memb_get = new SQLIDPreviewCommandsClass();
        private void MemberIDPreview_Load(object sender, EventArgs e)
        {
            SetLabels();
            SetImg();

        }
        public void SetImg()
        {
            String imgpath = Properties.Settings.Default.memberidimgpath;
            try
            {
                Bitmap img = new Bitmap(imgpath);
                selectmemberimg.Image = (Image)img;
            }
            catch (Exception)
            {
                MessageBox.Show("The path specified for the image intended for this account\neither does not exist or is corrupted." +
                "Please update the image path for this account to fix this issue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetLabels()
        {
            memb_get.Name(Properties.Settings.Default.memberid);
            uidtxt.Text = Properties.Settings.Default.memberuid;
            fnlbl.Text = Properties.Settings.Default.memberfirstname;
            mnlbl.Text = Properties.Settings.Default.membermiddlename;
            lnlbl.Text = Properties.Settings.Default.memberlastname;
            addtxt.Text = Properties.Settings.Default.memberaddress;
            orgtxt.Text = Properties.Settings.Default.memberorganization;
            numbtxt.Text = Properties.Settings.Default.membercontactno;
            emailtxt.Text = Properties.Settings.Default.memberemail;
            String remstart = Properties.Settings.Default.memberstart.Replace("00:00:00", "");
            starttxt.Text = remstart;
            String remend = Properties.Settings.Default.memberend.Replace("00:00:00", "");
            endtxt.Text = remend;
            if (addtxt.Text.Length > 35)
            {
                int cn = addtxt.Text.Length - 35;
                String spl_str = addtxt.Text.Substring(0, 35);
                String spl_str2 = addtxt.Text.Substring(35, cn);
                addtxt.Text = spl_str + "\n" + spl_str2;
            }
            else if (addtxt.Text.Length > 70)
            {
                int cn = addtxt.Text.Length - 35;
                String spl_str = addtxt.Text.Substring(0, 20);
                String spl_str2 = addtxt.Text.Substring(35, 70);
                String spl_str3 = addtxt.Text.Substring(70, cn);
                addtxt.Text = spl_str + "\n" + spl_str2 + "\n" + spl_str;
            }
        }
        private void MemberIDPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            /*this.Hide();
            this.Parent = null;
            e.Cancel = true;*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addtxt_Click(object sender, EventArgs e)
        {

        }

        private void selectmemberimg_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numbtxt_Click(object sender, EventArgs e)
        {

        }

        private void selectmemberimg_Click_1(object sender, EventArgs e)
        {

        }
    }
}
