using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLBookInventoryCommandsClass
    {

        List<BKINV_DBRecords> bkinv = new List<BKINV_DBRecords>();
        public List<getBKInvColumns> LoadFilterCombobox()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('BKINV_Main')").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadDeweyDecimalRange()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select deweydecimalrange + ' ' + deweydecimalgroup as DeweyDecimalRange from BKINV_DeweyDecimalClassification").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadBookshelfNo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select BookshelfNo from BKINV_BKshelfNo").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadBookshelfLvl()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select BookshelfLvl from BKINV_BookshelfLvl").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadIncBiblio()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select IncludesBiblio from BKINV_IncludesBiblio").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadIncGloss()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select IncludesGlossary from BKINV_IncludesGlossary").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadIncIndex()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select IncludesIndex from BKINV_IncludesIndex").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadIncIllus()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select IncludesIllustrations from BKINV_IncludesIllustrations").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadAvailability()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select Availability from BKINV_Availability").ToList();
                return output;
            }
        }
        public List<getBKInvColumns> LoadBookSection()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select BookSection from BKINV_BookSection").ToList();
                return output;
            }
        }
        public int ConvDate(String keyword)
        {
            int conv = 0;
            try
            {
                conv = Convert.ToInt32(keyword);
                return conv;
            }
            catch (Exception)
            {
                MessageBox.Show("Keyword was not converted successfully to an integer data type.");
                return conv;
            }
        }
        public List<BKINV_DBRecords> SearchBKINVDetails(String crit, String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select *from [Book Inventory] where {crit} like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchDateAcq(String keyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {

                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where (DATEPART(YYYY, bi.DateAcquired) = {keyword} OR DATEPART(MM, bi.DateAcquired) = {keyword} OR DATEPART(dd, bi.DateAcquired) = {keyword} OR DATEPART(HH, bi.DateAcquired) = {keyword} OR DATEPART(MINUTE, bi.DateAcquired) = {keyword} OR DATEPART(ss, bi.DateAcquired) = {keyword})").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Please insert appropriate values in the textbox with the following format: mm - dd - yyyy", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return nu;
                }
                finally
                { }
            }
        }
        /*public List<BKINV_DBRecords> SearchAccNo(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bi.AccessionNumber like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchTitle (String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bi.BookTitle like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchAuthor(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where ba.BookAuthor like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchAuthorNo(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where ba.AuthorNo like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchPublisher(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bp.Publisher like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchISBN(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bi.ISBN like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchCopyright(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bi.Copyright like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchPages(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bi.TotalPages like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchPrice(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bi.RetailPrice like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchBookSec(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bs.BookSection like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchDeweyDec(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where d.DeweyDecimalRange like '%{input}%'").ToList();
                    var output2 = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where d.DeweyDecimalGroup like '%{input}%'").ToList();
                    if (output.Count == 0 && output2.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (output2.Count > 0) {
                        return output2;
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchIncBib(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where ib.IncludesBiblio like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchIncGls(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where ig.IncludesGlossary like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchIncInd(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where inc.IncludesIndex like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchIncIls (String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where il.IncludesIllustrations like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchBookshelfNo(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bn.BookshelfNo like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchBookshelfLvl(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bl.BookshelfLvl like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchSpecSource(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where s.SpecificSource like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchAvail(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where a.Availability like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return nu;
                }
                finally
                { }
            }
        }
        public List<BKINV_DBRecords> SearchGeneral(String criteria, String input) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                List<BKINV_DBRecords> nu = new List<BKINV_DBRecords>();
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bm.{criteria} like '%{input}%'").ToList();
                    if (output.Count == 0)
                    {
                        MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return output;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Please insert appropriate values in the textbox with the following format: mm - dd - yyyy", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return nu;
                }
                finally
                { }
            }
        }*/
        public List<BKINV_DBRecords> LoadBookInventoryData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try
                {
                    var output = connection.Query<BKINV_DBRecords>($"select *from [Book Inventory]").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    List<BKINV_DBRecords> a = new List<BKINV_DBRecords>();
                    return a;
                }

            }
        }
        public String setAuthorNo(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select AuthorNo from BKINV_AuthorInfo where id = '{id}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String setAuthor(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select BookAuthor from BKINV_AuthorInfo where id = '{id}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }

        public String getBookInfoID(String book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '{book}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getAuthorID(String auth)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_AuthorInfo where BookAuthor = '{auth}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getAuthorNoID(String auth)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_AuthorInfo where AuthorNo = '{auth}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getPublisherID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_Publisher where Publisher = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getBookSecID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_BookSection where BookSection = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getDeweyID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                StringBuilder sb = new StringBuilder(inp);
                sb.Remove(0, 8);
                String a = sb.ToString();
                var output = connection.ExecuteScalar($"select id from BKINV_DeweyDecimalClassification where DeweyDecimalGroup = '{a}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getBKShelfNoID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_BKShelfNo where BookshelfNo = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getBKShelfLvlID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_BookshelfLvl where BookshelfLvl = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getBiblioID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_IncludesBiblio where IncludesBiblio = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getGlossaryID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_IncludesGlossary where IncludesGlossary = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getIllusID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_IncludesIllustrations where IncludesIllustrations = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getIndexID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_IncludesIndex where IncludesIndex = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getSourceID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_Source where SpecificSource = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public String getAvailID(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.ExecuteScalar($"select id from BKINV_Availability where Availability = '{inp}'");
                String conv = Convert.ToString(output);
                return conv;
            }
        }
        public List<getBKInvColumns> CompareAccessionNumber(String acc)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getBKInvColumns>($"select *from BKINV_BKInfo where AccessionNumber = '{acc}'").ToList();
                if (acc.Length == 0)
                {
                    MessageBox.Show("The record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (output.Count > 0)
                {

                }
                else { }
                return output;
            }
        }
        public void CompareAndInsertBookEntry(String accessno, String title, String author, String authorno, String pub, String isbn, String copyright, String totalpages, String price, String dateacq, String booksec, String dewey, String biblio, String gloss, String index, String illus, String bookshelfno, String bookshelflvl, String source, String avail)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    var output = connection.Query<getBKInvColumns>($"select *from BKINV_BKInfo where BookTitle = '{title}'").ToList();
                    var output2 = connection.Query<getBKInvColumns>($"select *from BKINV_BKInfo where AccessionNumber = '{accessno}'").ToList();
                    List<getBKInvColumns> nu = new List<getBKInvColumns>();

                    if (accessno.Length == 0 || title.Length == 0 || author.Length == 0 || authorno.Length == 0 || pub.Length == 0 || isbn.Length == 0 || copyright.Length == 0 || totalpages.Length == 0 || price.Length == 0 || dateacq.Length == 0 || booksec.Length == 0 || dewey.Length == 0 || biblio.Length == 0 || gloss.Length == 0 || index.Length == 0 || illus.Length == 0 || bookshelfno.Length == 0 || bookshelflvl.Length == 0 || source.Length == 0 || avail.Length == 0)
                    {
                        MessageBox.Show("One or both of the required fields of the said record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (//output.Count > 0 || 
                            output2.Count > 0)
                        {
                            MessageBox.Show("The accession number of the said book has already had the exact same entry within the database.");
                        }
                        else if (//output.Count == 0 && 
                            output2.Count == 0)
                        {
                            if (bookshelfno.Equals("1") || bookshelfno.Equals("2") ||
                                bookshelfno.Equals("3") || bookshelfno.Equals("4") ||
                                bookshelfno.Equals("5") || bookshelfno.Equals("6") ||
                                bookshelfno.Equals("7"))
                            {
                                var ins = connection.Execute($"insert into BKINV_BKInfo values ('{accessno}','{title}','{isbn}','{copyright}'," +
                                $"'{totalpages}','{price}','{dateacq}','{author}','{authorno}','{pub}'," +
                                $"'{booksec}','{dewey}','{biblio}','{gloss}','{index}','{illus}'," +
                                $"'{bookshelfno}','{bookshelflvl}','{source}','{avail}')");
                                var id = connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '{title}'");
                                var insert = connection.Execute($"insert into BKINV_Main values ('{id}','{id}','{author}','{authorno}'," +
                                    $"'{pub}','{id}','{id}','{id}','{id}'," +
                                    $"'{id}','{booksec}','{dewey}','{biblio}','{gloss}','{index}'," +
                                    $"'{illus}','{bookshelfno}','{bookshelflvl}','{source}','{avail}')");
                                MessageBox.Show("The specified book record has been added successfully in the system.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                var ins = connection.Execute($"insert into BKINV_BKInfo values ('{accessno}','{title}','{isbn}','{copyright}'," +
                                    $"'{totalpages}','{price}','{dateacq}','{author}','{authorno}','{pub}'," +
                                    $"'{booksec}','{dewey}','{biblio}','{gloss}','{index}','{illus}'," +
                                    $"'{bookshelfno}','{bookshelflvl}','{source}','{avail}')");
                                var id = connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '{title}'");
                                var insert = connection.Execute($"insert into BKINV_Main values ('{id}','{id}','{author}','{authorno}'," +
                                    $"'{pub}','{id}','{id}','{id}','{id}'," +
                                    $"'{id}','{booksec}','{dewey}','{biblio}','{gloss}','{index}'," +
                                    $"'{illus}','{"8"}','{"4"}','{source}','{avail}')");
                                MessageBox.Show("The specified book record has been added successfully in the system.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception) {
                    MessageBox.Show("The error might have been caused by the following reason:" +
                        "\n1. A valid selection has not been made in the Author, Publisher, and/or Book's Specific Source text field/s.", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        public void UpdateBookEntry(String id, String accessno, String title, String author, String authorno, String pub, String isbn, String copyright, String totalpages, String price, String dateacq, String booksec, String dewey, String biblio, String gloss, String index, String illus, String bookshelfno, String bookshelflvl, String source, String avail)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                try {
                    String con_bkid = Convert.ToString(connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '{title}'"));
                    var sel = connection.ExecuteScalar($"select id from BKINV_Main where id = '{id}'");
                    String con = Convert.ToString(sel);
                    if (id.Length == 0)
                    {
                        MessageBox.Show("The record to be deleted seems to be empty.\nPlease try selecting a record before proceeding to delete the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (bookshelfno.Equals("1") || bookshelfno.Equals("2") ||
                                bookshelfno.Equals("3") || bookshelfno.Equals("4") ||
                                bookshelfno.Equals("5") || bookshelfno.Equals("6") ||
                                bookshelfno.Equals("7"))
                        {
                            var upd_avai = connection.ExecuteScalar($"update BKBorrowingInfo set BKAvailability = '{avail}' where AccessionNo = '{con_bkid}'");
                            var output = connection.Execute($"update BKINV_BKInfo set AccessionNumber = '{accessno}', " +
                                $"BookTitle = '{title}', ISBN = '{isbn}', Copyright = '{copyright}', TotalPages = '{totalpages}', RetailPrice = '{price}', " +
                                $"DateAcquired = '{dateacq}', BookAuthor = '{author}', AuthorNo = '{authorno}', Publisher = '{pub}', " +
                                $"DeweyDecimalRange = '{dewey}', IncludesBiblio = '{biblio}', IncludesGlossary = '{gloss}', " +
                                $"IncludesIndex = '{index}', IncludesIllustrations  = '{illus}', BookshelfNo = '{bookshelfno}', BookshelfLvl = '{bookshelflvl}', " +
                                $"SpecificSource = '{source}', Availability = '{avail}'  where id = '{id}'");
                            var bkid = connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '{title}'");
                            var upd = connection.Execute($"update BKINV_Main set AccessionNumber = '{bkid}', " +
                                $"BookTitle = '{bkid}', ISBN = '{bkid}', Copyright = '{bkid}', TotalPages = '{bkid}', RetailPrice = '{bkid}', " +
                                $"DateAcquired = '{bkid}', BookAuthor = '{author}', AuthorNo = '{authorno}', Publisher = '{pub}', " +
                                $"DeweyDecimalRange = '{dewey}', IncludesBiblio = '{biblio}', IncludesGlossary = '{gloss}', " +
                                $"IncludesIndex = '{index}', IncludesIllustrations  = '{illus}', BookshelfNo = '{bookshelfno}', BookshelfLvl = '{bookshelflvl}', " +
                                $"SpecificSource = '{source}', Availability = '{avail}'  where id = '{id}'");
                            MessageBox.Show("The specified book record has been updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            var upd_avai = connection.Execute($"update BKBorrowingInfo set BKAvailability = '{avail}' where BookTitle = '{con_bkid}'");
                            var output = connection.Execute($"update BKINV_BKInfo set AccessionNumber = '{accessno}', " +
                                $"BookTitle = '{title}', ISBN = '{isbn}', Copyright = '{copyright}', TotalPages = '{totalpages}', RetailPrice = '{price}', " +
                                $"DateAcquired = '{dateacq}', BookAuthor = '{author}', AuthorNo = '{authorno}', Publisher = '{pub}', " +
                                $"DeweyDecimalRange = '{dewey}', IncludesBiblio = '{biblio}', IncludesGlossary = '{gloss}', " +
                                $"IncludesIndex = '{index}', IncludesIllustrations  = '{illus}', BookshelfNo = '{"8"}', BookshelfLvl = '{"4"}', " +
                                $"SpecificSource = '{source}', Availability = '{avail}'  where id = '{id}'");
                            var bkid = connection.ExecuteScalar($"select id from BKINV_BKInfo where BookTitle = '{title}'");
                            var upd = connection.Execute($"update BKINV_Main set AccessionNumber = '{bkid}', " +
                                $"BookTitle = '{bkid}', ISBN = '{bkid}', Copyright = '{bkid}', TotalPages = '{bkid}', RetailPrice = '{bkid}', " +
                                $"DateAcquired = '{bkid}', BookAuthor = '{author}', AuthorNo = '{authorno}', Publisher = '{pub}', " +
                                $"DeweyDecimalRange = '{dewey}', IncludesBiblio = '{biblio}', IncludesGlossary = '{gloss}', " +
                                $"IncludesIndex = '{index}', IncludesIllustrations  = '{illus}', BookshelfNo = '{"8"}', BookshelfLvl = '{"4"}', " +
                                $"SpecificSource = '{source}', Availability = '{avail}'  where id = '{id}'");
                            MessageBox.Show("The specified book record has been updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("The error might have been caused by the following reason:" +
                        "\n1. A valid selection has not been made in the Author, Publisher, and/or Book's Specific Source text field/s.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteBookEntry(String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var sel = connection.ExecuteScalar($"select id from BKINV_Main where id = '{id}'");
                String con = Convert.ToString(sel);
                if (id.Length == 0)
                {
                    MessageBox.Show("The record to be deleted seems to be empty.\nPlease try selecting a record before proceeding to delete the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var output1 = connection.Execute($"delete from BKINV_BKInfo where id = '{id}'");
                    var output = connection.Execute($"delete from BKINV_Main where id = '{id}'");
                    MessageBox.Show("The specified book record has been deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public List<getBKInvColumns> CompareAndInsertAuth(String auth, String authno)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var comp = connection.Query<getBKInvColumns>($"select *from BKINV_AuthorInfo where AuthorNo = '{authno}'").ToList();
                var comp2 = connection.Query<getBKInvColumns>($"select *from BKINV_AuthorInfo where BookAuthor = '{auth}'").ToList();
                if (auth.Length == 0 || authno.Length == 0)
                {
                    MessageBox.Show("One or both of the required fields of the said record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (comp.Count > 1 && comp.Count > 1)
                    {
                        MessageBox.Show("The specified author record has already existed within the system.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comp.Count == 0 && comp2.Count == 0)
                    {
                        var output = connection.Execute($"insert into BKINV_AuthorInfo values ('{authno}','{auth}')");
                        MessageBox.Show("A new author record has been added successfully to the database.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return comp;
            }
        }
        public List<getBKInvColumns> CompareAndInsertPublisher(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var comp = connection.Query<getBKInvColumns>($"select *from BKINV_Publisher where Publisher = '{input}'").ToList();
                if (input.Length == 0)
                {
                    MessageBox.Show("The record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (comp.Count > 1)
                {
                    MessageBox.Show("The specified publisher record has already existed within the system.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (comp.Count == 0 && input.Length > 0)
                {
                    var output = connection.Execute($"insert into BKINV_Publisher values ('{input}')");
                    MessageBox.Show("A new publisher record has been added successfully to the database.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return comp;
            }
        }
        public List<getBKInvColumns> CompareAndInsertSource(String input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var comp = connection.Query<getBKInvColumns>($"select *from BKINV_Source where SpecificSource = '{input}'").ToList();
                if (input.Length == 0)
                {
                    MessageBox.Show("The record to be added seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to insert the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (comp.Count > 1)
                {
                    MessageBox.Show("The specified book source record has already existed within the system.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (comp.Count == 0 && input.Length > 0)
                {
                    var output = connection.Execute($"insert into BKINV_Source values ('{input}')");
                    MessageBox.Show("A new book source record has been added successfully to the database.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return comp;
            }
        }
        public void UpdateAuth(String auth, String authno, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (auth.Length == 0 || authno.Length == 0 || id.Length == 0)
                {
                    MessageBox.Show("One or both of the required fields of the said record to be updated seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to update the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sel = connection.ExecuteScalar($"select AuthorNo from BKINV_AuthorInfo where id = '{id}'");
                    var sel2 = connection.ExecuteScalar($"select BookAuthor from BKINV_AuthorInfo where id = '{id}'");
                    String con = Convert.ToString(sel);
                    String con2 = Convert.ToString(sel2);
                    var dlg = MessageBox.Show("Are you sure you want to update the specified old author number '" + con + "' to the new author number '" + authno + "'\n and the old book author '" + con2 + "' to the new book author '" + auth + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"update BKINV_AuthorInfo set AuthorNo = '{authno}', BookAuthor = '{auth}' where id = {id}");
                        MessageBox.Show("The specified author record has been updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void UpdatePublisher(String input, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (input.Length == 0 || id.Length == 0)
                {
                    MessageBox.Show("The record to be updated seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to update the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (input.Length > 0 && id.Length > 0)
                {
                    var sel = connection.ExecuteScalar($"select Publisher from BKINV_Publisher where id = '{id}'");
                    String con = Convert.ToString(sel);
                    var dlg = MessageBox.Show("Are you sure you want to update the specified old publisher record '" + con + "' " + "to the new record '" + input + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"update BKINV_Publisher set Publisher = '{input}' where id = {id}");
                        MessageBox.Show("The specified publisher record has been updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
        public void UpdateSource(String input, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (input.Length == 0 || id.Length == 0)
                {
                    MessageBox.Show("The record to be updated seems to be empty.\nPlease try typing in a certain amount of characters before proceeding to update the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (input.Length > 0 && id.Length > 0)
                {
                    var sel = connection.ExecuteScalar($"select SpecificSource from BKINV_Source where id = '{id}'");
                    String con = Convert.ToString(sel);
                    var dlg = MessageBox.Show("Are you sure you want to update the specified old book source record '" + con + "' " + "to the new record '" + input + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"update BKINV_Source set SpecificSource = '{input}' where id = {id}");
                        MessageBox.Show("The specified book source record has been updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void DeleteAuth(String authno, String auth, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (auth.Length == 0 || authno.Length == 0)
                {
                    MessageBox.Show("One or both of the required fields of the said record to be deleted seems to be empty.\nPlease try selecting a record before proceeding to delete the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sel = connection.ExecuteScalar($"select AuthorNo from BKINV_AuthorInfo where id = '{id}'");
                    var sel2 = connection.ExecuteScalar($"select BookAuthor from BKINV_AuthorInfo where id = '{id}'");
                    String con = Convert.ToString(sel);
                    String con2 = Convert.ToString(sel2);
                    var dlg = MessageBox.Show("Are you sure you want to delete the specified author record with the Author number '" + con + "'\n and author(s) '" + con2 + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"delete from BKINV_AuthorInfo where id = {id}");
                        MessageBox.Show("The specified book source record has been deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void DeletePublisher(String input, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (input.Length == 0 || id.Length == 0)
                {
                    MessageBox.Show("The record to be deleted seems to be empty.\nPlease try selecting a record before proceeding to delete the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sel = connection.ExecuteScalar($"select Publisher from BKINV_Publisher where id = '{id}'");
                    String con = Convert.ToString(sel);
                    var dlg = MessageBox.Show("Are you sure you want to delete the specified publisher record '" + con + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"delete from BKINV_Publisher where id = '{id}'");
                        MessageBox.Show("The specified publisher record has been deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void DeleteSource(String input, String id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                if (input.Length == 0 || id.Length == 0)
                {
                    MessageBox.Show("The record to be deleted seems to be empty.\nPlease try selecting a record before proceeding to delete the data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sel = connection.ExecuteScalar($"select SpecificSource from BKINV_Source where id = '{id}'");
                    String con = Convert.ToString(sel);
                    var dlg = MessageBox.Show("Are you sure you want to delete the specified book source record '" + con + "' with the ID " + id + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        var output = connection.Execute($"delete from BKINV_Source where id = '{id}'");
                        MessageBox.Show("The specified book source record has been deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public List<getAuthorInfo> LoadAuthorInfo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getAuthorInfo>($"select AuthorNo, BookAuthor from BKINV_AuthorInfo").ToList();
                return output;
            }
        }
        public List<getPublisherInfo> LoadPublisher()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getPublisherInfo>($"select Publisher from BKINV_Publisher").ToList();
                return output;
            }
        }
        public List<getSpecSourceInfo> LoadSource()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getSpecSourceInfo>($"select SpecificSource from BKINV_Source").ToList();
                return output;
            }
        }
        public List<getAuthorInfo> SearchAuthorInfo(String crit, String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getAuthorInfo>($"select AuthorNo, BookAuthor from BKINV_AuthorInfo where {crit} like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<getPublisherInfo> SearchPublisher(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getPublisherInfo>($"select Publisher from BKINV_Publisher where Publisher like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }
        public List<getSpecSourceInfo> SearchSource(String inp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<getSpecSourceInfo>($"select SpecificSource from BKINV_Source where SpecificSource like '%{inp}%'").ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No results for your search keywords have been found.\nPlease enter the exact keywords of the records that you are looking for.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return output;
            }
        }

    }
}
