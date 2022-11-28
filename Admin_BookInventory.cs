using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Admin_BookInventory : Form
    {
        public static String Author = "";
        public static String AuthorNo = "";
        public static String Publisher = "";
        public static String BookSource = "";

        List<BKINV_DBRecords> bkinv = new List<BKINV_DBRecords>();
        SQLBookInventoryCommandsClass bi_cmd = new SQLBookInventoryCommandsClass();
        public Admin_BookInventory()
        {
            InitializeComponent();
            SetCmbInfo();
        }

        private void Admin_BookInventory_Load(object sender, EventArgs e)
        {
            UpdateBinding();
            ComboBoxSel();
            DefaultSelectedIndex();
        }
        public void ComboBoxSel()
        {
            SQLBookInventoryCommandsClass t = new SQLBookInventoryCommandsClass();
            List<getBKInvColumns> bmc = new List<getBKInvColumns>();

            bmc = t.LoadFilterCombobox();
            filtercmb.DataSource = bmc;
            filtercmb.DisplayMember = "name";

            bmc = t.LoadDeweyDecimalRange();
            classnotxt.DataSource = bmc;
            classnotxt.DisplayMember = "DeweyDecimalRange";

            bmc = t.LoadBookSection();
            bksectiontxt.DataSource = bmc;
            bksectiontxt.DisplayMember = "BookSection";

            bmc = t.LoadBookshelfNo();
            bookshelfno.DataSource = bmc;
            bookshelfno.DisplayMember = "BookshelfNo";

            bmc = t.LoadBookshelfLvl();
            bookshelflvl.DataSource = bmc;
            bookshelflvl.DisplayMember = "BookshelfLvl";

            bmc = t.LoadIncBiblio();
            incbiblio.DataSource = bmc;
            incbiblio.DisplayMember = "IncludesBiblio";

            bmc = t.LoadIncGloss();
            incglossary.DataSource = bmc;
            incglossary.DisplayMember = "IncludesGlossary";

            bmc = t.LoadIncIllus();
            incillus.DataSource = bmc;
            incillus.DisplayMember = "IncludesIllustrations";

            bmc = t.LoadIncIndex();
            incindex.DataSource = bmc;
            incindex.DisplayMember = "IncludesIndex";

            bmc = t.LoadAvailability();
            availabilitytxt.DataSource = bmc;
            availabilitytxt.DisplayMember = "Availability";
        }
        public void clear()
        {
            bkinvtimer.Enabled = false;
            idlbl.Text = "[ID Txt]";
            booktitle.Text = "";
            accessionno.Text = "";
            isbntxt.Clear();
            totalptxt.Text = "";
            copyrighttxt.Text = "";
            pricetxt.Text = "";

            authnoid.Text = "";
            authornotxt.Text = "";
            authortxt.Text = "";
            pubid.Text = "";
            publishertxt.Text = "";
            specsourcetxt.Text = "";
            bksrcid.Text = "";

            authnoid.Text = "[ID]";
            bksrcid.Text = "[ID]";
            pubid.Text = "[ID]";

            bkinvtimer.Start();

            dateacqtxt.Text = Convert.ToString(DateTime.Today);
            bookshelfno.SelectedIndex = 0;
            bookshelflvl.SelectedIndex = 0;
            incbiblio.SelectedIndex = 0;
            incglossary.SelectedIndex = 0;
            incillus.SelectedIndex = 0;
            incindex.SelectedIndex = 0;
            availabilitytxt.SelectedIndex = 0;
            del_btn.Enabled = false;
            btn_updbook.Enabled = false;
            UpdateBinding();
        }
        public void Methods()
        {
            /*
            compareSameAccessionNo()
            compareSameTitle()

            if(){
            
            }
            else if(){
            
            }
            else if(){
            
            }
            else if(){
            
            }


             */
        }
        public void DefaultSelectedIndex()
        {
            bksectiontxt.SelectedIndex = 0;
            classnotxt.SelectedIndex = 0;
            incbiblio.SelectedIndex = 0;
            incglossary.SelectedIndex = 0;
            incillus.SelectedIndex = 0;
            incindex.SelectedIndex = 0;
        }
        public void SetCmbInfo()
        {

        }
        public void UpdateBinding()
        {
            bkinv = bi_cmd.LoadBookInventoryData();
            BKINV_ListDisplay.DataSource = bkinv;
            BKINV_ListDisplay.AutoSize = false;
        }
        private void bookinfo_Click(object sender, EventArgs e)
        {
        }

        private void authorinfobtn_Click(object sender, EventArgs e)
        {
            //authnoid.Text = bi_cmd.getAuthorID(authortxt.Text);
            //auth_selaction.SelectedIndex = 0;
        }

        private void bookcategbtn_Click(object sender, EventArgs e)
        {
        }

        private void pubcrbtn_Click(object sender, EventArgs e)
        {
            pubid.Text = bi_cmd.getPublisherID(publishertxt.Text);
        }

        private void bknotesbtn_Click(object sender, EventArgs e)
        {
        }

        private void bklocbtn_Click(object sender, EventArgs e)
        {
        }

        private void bkaddinfobtn_Click(object sender, EventArgs e)
        {
            //bksrcid.Text = bi_cmd.getSourceID(specsourcetxt.Text);
            //bksrc_selaction.SelectedIndex = 0;
        }

        private void authortxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            authnoid.Text = bi_cmd.getAuthorID(authortxt.Text);
            authornotxt.Text = bi_cmd.setAuthorNo(authnoid.Text);
        }
        private void authornotxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            authnoid.Text = bi_cmd.getAuthorNoID(authornotxt.Text);
            authortxt.Text = bi_cmd.setAuthor(authnoid.Text);
        }

        private void btn_insertnewbook_Click(object sender, EventArgs e)
        {
            String title = booktitle.Text;
            String accno = accessionno.Text;
            String _isbn = isbn.Text + " " + isbntxt.Text;
            String pg = totalptxt.Text;
            String cpr = copyrighttxt.Text;
            String pr = pricetxt.Text;
            String dtacq = Convert.ToString(dateacqtxt.Value);
            String auth = bi_cmd.getAuthorID(authortxt.Text);
            String authno = bi_cmd.getAuthorNoID(authornotxt.Text);
            String pub = bi_cmd.getPublisherID(publishertxt.Text);
            String bksec = bi_cmd.getBookSecID(bksectiontxt.Text);
            String dewey = bi_cmd.getDeweyID(classnotxt.Text);
            String s_no = bi_cmd.getBKShelfNoID(bookshelfno.Text);
            String s_lvl = bi_cmd.getBKShelfLvlID(bookshelflvl.Text);
            String bib = bi_cmd.getBiblioID(incbiblio.Text);
            String gls = bi_cmd.getGlossaryID(incglossary.Text);
            String ils = bi_cmd.getIllusID(incillus.Text);
            String ind = bi_cmd.getIndexID(incindex.Text);
            String src = bi_cmd.getSourceID(specsourcetxt.Text);
            String avail = bi_cmd.getAvailID(availabilitytxt.Text);
            if (accessionno.TextLength == 0 || booktitle.TextLength == 0 || isbntxt.TextLength == 0 || totalptxt.TextLength == 0 || copyrighttxt.TextLength == 0 || pricetxt.TextLength == 0 || dateacqtxt.Text.Equals("") || authornotxt.Text.Length == 0 || authortxt.Text.Length == 0 || publishertxt.Text.Length == 0 || specsourcetxt.Text.Length == 0 || bksectiontxt.Text.Length == 0 || classnotxt.Text.Length == 0 || incbiblio.Text.Length == 0 || incglossary.Text.Length == 0 || incindex.Text.Length == 0 || incillus.Text.Length == 0 || bookshelfno.Text.Length == 0 || bookshelflvl.Text.Length == 0)
            {
                MessageBox.Show("One or both of the required fields of the specified record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dlg = MessageBox.Show("The following book record will be added in the system: \nAccession Number: " + accessionno.Text + "\nBook Title: " + booktitle.Text + "\nBook Author: " + authortxt.Text
                                + "\nPublisher: " + publishertxt.Text + "\nISBN: " + isbn + " " + isbntxt.Text + "\nCopyright: " + copyrighttxt.Text + "\nTotal Pages: " + totalptxt.Text + "\nPrice: " + pricetxt.Text + "\nDate Acquired: " + dateacqtxt.Text + "\nBook Section: "
                                 + bksectiontxt.Text + "\nDewey Decimal Range: " + classnotxt.Text + "\nIncludes Bibliography: " + incbiblio.Text + "\nIncludes Glossary: " + incglossary.Text + "\nIncludes Index: " + incindex.Text + "\nIncludes Illustrations: " + incillus.Text +
                                  "\nBookshelf Number: " + bookshelfno.Text + "\nBookshelf Level: " + bookshelflvl.Text + "\nBook Source: " + specsourcetxt.Text + "\nAvailability: " + availabilitytxt.Text + "\n\nAre you sure you want to add this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlg == DialogResult.Yes)
                {
                    bi_cmd.CompareAndInsertBookEntry(accno, title, auth, authno, pub, _isbn, cpr, pg, pr, dtacq, bksec, dewey, bib, gls, ind, ils, s_no, s_lvl, src, avail);
                    UpdateBinding();
                    clear();
                }
                else { }
            }
        }

        private void auth_selaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (auth_selaction.SelectedIndex == 0)
            {
                //standby
            }
            else if (auth_selaction.SelectedIndex == 1)
            {
                bi_cmd.CompareAndInsertAuth(authortxt.Text, authornotxt.Text);
                auth_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            else if (auth_selaction.SelectedIndex == 2)
            {
                bi_cmd.UpdateAuth(authornotxt.Text, authortxt.Text, authnoid.Text);
                auth_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            else if (auth_selaction.SelectedIndex == 3)
            {
                bi_cmd.DeleteAuth(authornotxt.Text, authortxt.Text, authnoid.Text);
                auth_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            */
        }

        private void pub_selaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (pub_selaction.SelectedIndex == 0)
            {
                //standby
            }
            else if (pub_selaction.SelectedIndex == 1)
            {
                bi_cmd.CompareAndInsertPublisher(publishertxt.Text);
                pub_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            else if (pub_selaction.SelectedIndex == 2)
            {
                bi_cmd.UpdatePublisher(publishertxt.Text, pubid.Text);
                pub_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            else if (pub_selaction.SelectedIndex == 3)
            {
                bi_cmd.DeletePublisher(publishertxt.Text, pubid.Text);
                pub_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            */
        }

        private void bksrc_selaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (bksrc_selaction.SelectedIndex == 0)
            {
                //standby
            }
            else if (bksrc_selaction.SelectedIndex == 1)
            {
                bi_cmd.CompareAndInsertSource(specsourcetxt.Text);
                bksrc_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            else if (bksrc_selaction.SelectedIndex == 2)
            {
                bi_cmd.UpdateSource(specsourcetxt.Text, bksrcid.Text);
                bksrc_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            else if (bksrc_selaction.SelectedIndex == 3)
            {
                bi_cmd.DeleteSource(specsourcetxt.Text, bksrcid.Text);
                bksrc_selaction.SelectedIndex = 0;
                ComboBoxSel();
            }
            */
        }

        private void specsourcetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            bksrcid.Text = bi_cmd.getSourceID(specsourcetxt.Text);
        }

        private void publishertxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            pubid.Text = bi_cmd.getPublisherID(publishertxt.Text);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String fil = filtercmb.Text;
            if (fil.Equals("id"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("id", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("AccessionNumber"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("AccessionNumber", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("BookTitle"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("BookTitle", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("BookAuthor"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("BookAuthor", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("AuthorNo"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("AuthorNo", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("Publisher"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("Publisher", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("ISBN"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("ISBN", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("Copyright"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("Copyright", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("TotalPages"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("TotalPages", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("RetailPrice"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("DateAcquired"))
            {
                if (bi_cmd.ConvDate(inputsearchbar.Text) >= 0)
                {
                    bkinv = bi_cmd.SearchDateAcq(inputsearchbar.Text);
                    BKINV_ListDisplay.DataSource = bkinv;
                }
                else { }
            }
            else if (fil.Equals("BookSection"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("BookSection", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("DeweyDecimalRange"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("DeweyDecimalRange", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("IncludesBiblio"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("IncludesBiblio", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("IncludesGlossary"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("IncludesGlossary", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("IncludesIndex"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("IncludesIndex", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("IncludesIllustrations"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("IncludesIllustrations", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("BookshelfNo"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("BookshelfNo", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("BookshelfLvl"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("BookshelfLvl", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("SpecificSource"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("SpecificSource", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
            else if (fil.Equals("Availability"))
            {
                bkinv = bi_cmd.SearchBKINVDetails("Availability", inputsearchbar.Text);
                BKINV_ListDisplay.DataSource = bkinv;
            }
        }

        private void isbntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            const int dash = 45;
            const int NOT_FOUND = -1;
            int keyvalue = (int)e.KeyChar;
            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)) ||
            ((keyvalue == dash)))
                return;
            e.Handled = true;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("The following book record will be deleted in the system: \nAccession Number: " + accessionno.Text + "\nBook Title: " + booktitle.Text + "\nBook Author: " + authortxt.Text
                                + "\nPublisher: " + publishertxt.Text + "\nISBN: " + isbn + " " + isbntxt.Text + "\nCopyright: " + copyrighttxt.Text + "\nTotal Pages: " + totalptxt.Text + "\nPrice: " + pricetxt.Text + "\nDate Acquired: " + dateacqtxt.Text + "\nBook Section: "
                                 + bksectiontxt.Text + "\nDewey Decimal Range: " + classnotxt.Text + "\nIncludes Bibliography: " + incbiblio.Text + "\nIncludes Glossary: " + incglossary.Text + "\nIncludes Index: " + incindex.Text + "\nIncludes Illustrations: " + incillus.Text +
                                  "\nBookshelf Number: " + bookshelfno.Text + "\nBookshelf Level: " + bookshelflvl.Text + "\nBook Source: " + specsourcetxt.Text + "\nAvailability: " + availabilitytxt.Text + "\n\nAre you sure you want to delete this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlg == DialogResult.Yes)
            {
                bi_cmd.DeleteBookEntry(idlbl.Text);
                UpdateBinding();
            }
        }

        private void btn_updbook_Click(object sender, EventArgs e)
        {
            String title = booktitle.Text;
            String accno = accessionno.Text;
            String _isbn = isbn.Text + " " + isbntxt.Text;
            String pg = totalptxt.Text;
            String cpr = copyrighttxt.Text;
            String pr = pricetxt.Text;
            String dtacq = Convert.ToString(dateacqtxt.Value);
            String auth = bi_cmd.getAuthorID(authortxt.Text);
            String authno = bi_cmd.getAuthorNoID(authornotxt.Text);
            String pub = bi_cmd.getPublisherID(publishertxt.Text);
            String bksec = bi_cmd.getBookSecID(bksectiontxt.Text);
            String dewey = bi_cmd.getDeweyID(classnotxt.Text);
            String s_no = bi_cmd.getBKShelfNoID(bookshelfno.Text);
            String s_lvl = bi_cmd.getBKShelfLvlID(bookshelflvl.Text);
            String bib = bi_cmd.getBiblioID(incbiblio.Text);
            String gls = bi_cmd.getGlossaryID(incglossary.Text);
            String ils = bi_cmd.getIllusID(incillus.Text);
            String ind = bi_cmd.getIndexID(incindex.Text);
            String src = bi_cmd.getSourceID(specsourcetxt.Text);
            String avail = bi_cmd.getAvailID(availabilitytxt.Text);
            if (accessionno.TextLength == 0 || booktitle.TextLength == 0 || isbntxt.TextLength == 0 || totalptxt.TextLength == 0 || copyrighttxt.TextLength == 0 || pricetxt.TextLength == 0 || dateacqtxt.Text.Equals("") || authornotxt.Text.Length == 0 || authortxt.Text.Length == 0 || publishertxt.Text.Length == 0 || specsourcetxt.Text.Length == 0 || bksectiontxt.Text.Length == 0 || classnotxt.Text.Length == 0 || incbiblio.Text.Length == 0 || incglossary.Text.Length == 0 || incindex.Text.Length == 0 || incillus.Text.Length == 0 || bookshelfno.Text.Length == 0 || bookshelflvl.Text.Length == 0)
            {
                MessageBox.Show("One or both of the required fields of the specified record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var dlg = MessageBox.Show("The following book record will be updated in the system: \nAccession Number: " + accessionno.Text + "\nBook Title: " + booktitle.Text + "\nBook Author: " + authortxt.Text
                                + "\nPublisher: " + publishertxt.Text + "\nISBN: " + isbn + " " + isbntxt.Text + "\nCopyright: " + copyrighttxt.Text + "\nTotal Pages: " + totalptxt.Text + "\nPrice: " + pricetxt.Text + "\nDate Acquired: " + dateacqtxt.Text + "\nBook Section: "
                                 + bksectiontxt.Text + "\nDewey Decimal Range: " + classnotxt.Text + "\nIncludes Bibliography: " + incbiblio.Text + "\nIncludes Glossary: " + incglossary.Text + "\nIncludes Index: " + incindex.Text + "\nIncludes Illustrations: " + incillus.Text +
                                  "\nBookshelf Number: " + bookshelfno.Text + "\nBookshelf Level: " + bookshelflvl.Text + "\nBook Source: " + specsourcetxt.Text + "\nAvailability: " + availabilitytxt.Text + "\n\nAre you sure you want to update this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlg == DialogResult.Yes)
            {
                bi_cmd.UpdateBookEntry(idlbl.Text, accno, title, auth, authno, pub, _isbn, cpr, pg, pr, dtacq, bksec, dewey, bib, gls, ind, ils, s_no, s_lvl, src, avail);
                UpdateBinding();
                clear();
            }
        }

        private void totalptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            const int dash = 45;
            const int NOT_FOUND = -1;
            int keyvalue = (int)e.KeyChar;
            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)))
                return;
            e.Handled = true;
        }

        private void copyrighttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            const int dash = 45;
            const int NOT_FOUND = -1;
            int keyvalue = (int)e.KeyChar;
            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)))
                return;
            e.Handled = true;
        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            const int dash = 45;
            const int NOT_FOUND = -1;
            int keyvalue = (int)e.KeyChar;
            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)))
                return;
            e.Handled = true;
        }


        private void filtercmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateBinding();
            String fil = filtercmb.Text;
            if (fil.Equals("DateAcquired"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fil.Equals("Copyright"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fil.Equals("TotalPages"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fil.Equals("RetailPrice"))
            {
                MessageBox.Show("When searching on this criteria, please enter only numerical characters on your search keywords.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void selauthinfo_Click(object sender, EventArgs e)
        {
            bkinvtimer.Start();
            SelectBKINVAuthorInfo_Admin a = new SelectBKINVAuthorInfo_Admin();
            a.Show();
        }

        private void selpub_Click(object sender, EventArgs e)
        {
            bkinvtimer.Start();
            SelectBKINVPublisher_Admin a = new SelectBKINVPublisher_Admin();
            a.Show();
        }

        private void selsource_Click(object sender, EventArgs e)
        {
            bkinvtimer.Start();
            SelectBKINVSource_Admin a = new SelectBKINVSource_Admin();
            a.Show();
        }

        private void BKINV_ListDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bkinvtimer.Enabled = false;
            if (BKINV_ListDisplay.Rows.Count >= 0)
            {
                try
                {
                    DataGridViewRow row = this.BKINV_ListDisplay.Rows[e.RowIndex];
                    idlbl.Text = row.Cells["ID"].Value.ToString();
                    booktitle.Text = row.Cells["BookTitle"].Value.ToString();
                    accessionno.Text = row.Cells["AccessionNumber"].Value.ToString();
                    isbntxt.Text = row.Cells["ISBN"].Value.ToString().Replace("ISBN ","");
                    totalptxt.Text = row.Cells["TotalPages"].Value.ToString();
                    copyrighttxt.Text = row.Cells["Copyright"].Value.ToString();
                    pricetxt.Text = row.Cells["RetailPrice"].Value.ToString();
                    dateacqtxt.Text = row.Cells["DateAcquired"].Value.ToString();
                    authornotxt.Text = row.Cells["AuthorNo"].Value.ToString();
                    authortxt.Text = row.Cells["BookAuthor"].Value.ToString();
                    publishertxt.Text = row.Cells["Publisher"].Value.ToString();
                    bksectiontxt.Text = row.Cells["BookSection"].Value.ToString();
                    classnotxt.Text = row.Cells["DeweyDecimalRange"].Value.ToString();
                    bookshelfno.Text = row.Cells["BookshelfNo"].Value.ToString();
                    bookshelflvl.Text = row.Cells["BookshelfLvl"].Value.ToString();
                    incbiblio.Text = row.Cells["IncludesBiblio"].Value.ToString();
                    incglossary.Text = row.Cells["IncludesGlossary"].Value.ToString();
                    incillus.Text = row.Cells["IncludesIllustrations"].Value.ToString();
                    incindex.Text = row.Cells["IncludesIndex"].Value.ToString();
                    specsourcetxt.Text = row.Cells["SpecificSource"].Value.ToString();
                    availabilitytxt.Text = row.Cells["Availability"].Value.ToString();

                    authnoid.Text = bi_cmd.getAuthorNoID(authornotxt.Text);
                    pubid.Text = bi_cmd.getPublisherID(publishertxt.Text);
                    bksrcid.Text = bi_cmd.getSourceID(specsourcetxt.Text);

                    btn_updbook.Enabled = true;
                    del_btn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void BKINV_ListDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bkinvtimer_Tick(object sender, EventArgs e)
        {
            SQLBookInventoryCommandsClass t = new SQLBookInventoryCommandsClass();

            if (Author.Length == 0 && AuthorNo.Length == 0 && authnoid.Text.Length == 0) { }
            else if (Author.Length > 0 && AuthorNo.Length > 0 && authnoid.Text.Length > 0)
            {
                authornotxt.Text = AuthorNo;
                authortxt.Text = Author;
                authnoid.Text = t.getAuthorNoID(authornotxt.Text);
                if (authnoid.Text.Length == 0) {
                    authnoid.Text = "[ID]";
                }
                bkinvtimer.Start();
            }

            if (Publisher.Length == 0 && pubid.Text.Length == 0) { }
            else if (Publisher.Length > 0 && pubid.Text.Length > 0)
            {
                bkinvtimer.Start();
                publishertxt.Text = Publisher;
                pubid.Text = t.getPublisherID(publishertxt.Text);
                if (pubid.Text.Length == 0) { 
                    pubid.Text = "[ID]";
                }
            }

            if (BookSource.Length == 0 && bksrcid.Text.Length == 0) { }
            else if (BookSource.Length > 0 && bksrcid.Text.Length > 0)
            {
                bkinvtimer.Start();
                specsourcetxt.Text = BookSource;
                bksrcid.Text = t.getSourceID(specsourcetxt.Text);
                if (bksrcid.Text.Length == 0) { 
                    bksrcid.Text = "[ID]";
                }
            }
        }
    }
    public class getBKInvColumns
    {
        public String name { get; set; }
        public String BookSection { get; set; }
        public String DeweyDecimalRange { get; set; }
        public String BookshelfNo { get; set; }
        public String BookshelfLvl { get; set; }
        public String IncludesBiblio { get; set; }
        public String IncludesGlossary { get; set; }
        public String IncludesIndex { get; set; }
        public String IncludesIllustrations { get; set; }
        public String Availability { get; set; }
        public String AuthorNo { get; set; }
        public String BookAuthor { get; set; }
        public String Publisher { get; set; }
        public String SpecificSource { get; set; }
    }
    public class getAuthorInfo
    {
        public String AuthorNo { get; set; }
        public String BookAuthor { get; set; }
    }
    public class getPublisherInfo
    {
        public String Publisher { get; set; }
    }
    public class getSpecSourceInfo
    {
        public String SpecificSource { get; set; }
    }
}
