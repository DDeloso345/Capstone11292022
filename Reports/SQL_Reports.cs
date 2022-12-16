using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capstone.Reports
{
    class SQL_Reports
    {

        #region UTILITIES
        public DataSet QueryData(String Q)
        {
            //MessageBox.Show(Q);
            using (SqlConnection DB = new SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                DataSet dataSet = new DataSet();
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Q, DB);
                    dataAdapter.Fill(dataSet);
                    return dataSet;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return dataSet;
                }
            }
        }
        public bool ExecuteQuery(String Q)
        {
            using (SqlConnection DB = new SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                SqlCommand CMD = new SqlCommand();
                CMD.CommandText = String.Format(Q);
            }
            return false;
        }
        #endregion

        #region BOOK INVENTORY
        // BOOK INVENTORY
        public DataSet GetBookInventoryByAvailability(bool tabular = true, bool narrative = false, String filter = "MISSING")
        {
            String Q = "SELECT 'Book Inventory Report' AS Title, 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' book(s) accounted for this Book Inventory Report' AS Narrative FROM [Book Inventory];";

            if (tabular && narrative)
                switch (filter)
                {
                    case "MISSING":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE Availability = 'MISSING'; " +
                                 "SELECT(CASE WHEN B.Narrative IS NULL THEN A.Narrative ELSE B.Narrative END) AS Narrative " +
                                 "FROM " +
                                 "(SELECT 'No missing books were accounted for this Book Inventory Report' AS Narrative, 'MISSING' AS Availability) AS A " +
                                 "LEFT JOIN " +
                                 "(SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' missing book(s) that were accounted for this Book Inventory Report' AS Narrative, Availability FROM[Book Inventory] WHERE Availability = 'MISSING' GROUP BY Availability) AS B " +
                                 "ON A.Availability = B.Availability; " +
                                 "");

                    case "BORROWED":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE Availability = 'BORROWED'; " +
                                 "SELECT(CASE WHEN B.Narrative IS NULL THEN A.Narrative ELSE B.Narrative END) AS Narrative " +
                                 "FROM " +
                                 "(SELECT 'No borrowed books were accounted for this Book Inventory Report' AS Narrative, 'BORROWED' AS Availability) AS A " +
                                 "LEFT JOIN " +
                                 "(SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' borrowed book(s) that were accounted for this Book Inventory Report' AS Narrative, Availability FROM[Book Inventory] WHERE Availability = 'BORROWED' GROUP BY Availability) AS B " +
                                 "ON A.Availability = B.Availability; " +
                                 "");

                    case "AVAILABLE":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] where(Availability = 'OPEN FOR BORROWING' OR Availability = 'FOR INSIDE READING ONLY'); " +
                                 "SELECT(CASE WHEN B.Narrative IS NULL THEN A.Narrative ELSE B.Narrative END) AS Narrative " +
                                 "FROM " +
                                 "(SELECT 'No available books were accounted for this Book Inventory Report' AS Narrative, 'AVAILABLE' AS Availability) AS A " +
                                 "LEFT JOIN " +
                                 "(SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' available book(s) accounted for this Book Inventory Report' AS Narrative, Availability FROM(SELECT 'AVAILABLE' AS Availability FROM[Book Inventory] WHERE(Availability = 'OPEN FOR BORROWING' OR Availability = 'FOR INSIDE READING ONLY')) AS C GROUP BY Availability) AS B " +
                                 "ON A.Availability = B.Availability; " +
                                 "");


                    case "DISCARDED":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE Availability = 'DISCARDED'; " +
                                 "SELECT(CASE WHEN B.Narrative IS NULL THEN A.Narrative ELSE B.Narrative END) AS Narrative " +
                                 "FROM " +
                                 "(SELECT 'No books to be discarded were accounted for this Book Inventory Report' AS Narrative, 'DISCARDED' AS Availability) AS A " +
                                 "LEFT JOIN " +
                                 "(SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' book(s) to be discarded that were accounted for this Book Inventory Report' AS Narrative, Availability FROM[Book Inventory] WHERE Availability = 'DISCARDED' GROUP BY Availability) AS B " +
                                 "ON A.Availability = B.Availability; " +
                                 "");
                }
            

            else if (tabular && !narrative)
                switch (filter)
                {
                    case "MISSING":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE availability = 'MISSING'; " +
                                 "SELECT 'Missing Books: ' + CAST(COUNT(*) AS VARCHAR) AS Narrative FROM[Book Inventory] WHERE availability = 'MISSING'; " +
                                 "");

                    case "BORROWED":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE availability = 'BORROWED'; " +
                                 "SELECT 'Borrowed Books: ' + CAST(COUNT(*) AS VARCHAR) AS Narrative FROM[Book Inventory] WHERE availability = 'BORROWED'; " +
                                 "");

                    case "AVAILABLE":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] where(availability = 'OPEN FOR BORROWING' OR Availability = 'FOR INSIDE READING ONLY'); " +
                                 "SELECT 'Available Books (Open For Borrowing + For Inside Reading Only): ' + CAST(COUNT(*) AS VARCHAR) AS Narrative FROM(SELECT 'AVAILABLE' AS Availability FROM[Book Inventory] WHERE(availability = 'OPEN FOR BORROWING' OR Availability = 'FOR INSIDE READING ONLY')) AS C GROUP BY Availability " +
                                 "");


                    case "DISCARDED":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE availability = 'DISCARDED'; " +
                                 "SELECT 'Discarded Books: ' + CAST(COUNT(*) AS VARCHAR) AS Narrative FROM [Book Inventory] WHERE availability = 'DISCARDED'; " +
                                 "");
                }

            else if (!tabular && narrative)
                switch (filter)
                {
                    case "MISSING":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE availability = 'X'; " +
                                 "SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' books were missing as of ' + CAST(FORMAT(GETDATE(), 'hh:mm tt on MMMM dd, yyyy.') AS VARCHAR) AS Narrative FROM[Book Inventory] WHERE availability = 'MISSING'" +
                                 "");

                    case "BORROWED":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE availability = 'X'; " +
                                 "SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' books were borrowed as of ' + CAST(FORMAT(GETDATE(), 'hh:mm tt on MMMM dd, yyyy.') AS VARCHAR) AS Narrative FROM[Book Inventory] WHERE availability = 'BORROWED'; " +
                                 "");

                    case "AVAILABLE":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] where(availability = 'X'); " +
                                 "SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' books were available as of ' + CAST(FORMAT(GETDATE(), 'hh:mm tt on MMMM dd, yyyy.') AS VARCHAR) AS Narrative FROM(SELECT 'AVAILABLE' AS Availability FROM[Book Inventory] WHERE(availability = 'OPEN FOR BORROWING' OR Availability = 'FOR INSIDE READING ONLY')) AS C GROUP BY Availability " +
                                 "");


                    case "DISCARDED":
                        return QueryData("" +
                                 Q +
                                 "SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMM dd, yyyy') AS DateAcquired FROM[Book Inventory] WHERE availability = 'X'; " +
                                 "SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' books were to be discarded as of ' + CAST(FORMAT(GETDATE(), 'hh:mm tt on MMMM dd, yyyy.') AS VARCHAR) AS Narrative FROM[Book Inventory] WHERE availability = 'DISCARDED'; " +
                                 "");
                }

            return new DataSet();

        }
        public DataSet GetBookInventoryByDate(DateTime dateTime, bool tabular = true, bool narrative = false)
        {
            if (tabular && narrative)
                return QueryData("" +
                                $"SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' books accounted for this Book Inventory Report for the year of ' + CAST({dateTime.Year} AS VARCHAR) AS Narrative, 'Book Inventory Report' AS Title FROM [Book Inventory] WHERE YEAR(DateAcquired) = {dateTime.Year}; " +
                                $"SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMMM dd, yyyy') AS DateAcquired, Copyright, TotalPages, RetailPrice, DeweyDecimalRange, SpecificSource FROM [Book Inventory] WHERE MONTH(DateAcquired) = {dateTime.Month} AND YEAR(DateAcquired) = {dateTime.Year}; " +
                                $"SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' books accounted for within {dateTime.ToString("MMMM")} of year ' + CAST({dateTime.Year} AS VARCHAR) AS Narrative, '{dateTime.ToString("MMMM")} ' + CAST({dateTime.Year} AS VARCHAR) AS Title FROM [Book Inventory] WHERE MONTH(DateAcquired) = {dateTime.Month} AND YEAR(DateAcquired) = {dateTime.Year}; " +
                                "");

            else if (tabular && !narrative)
                return QueryData("" +
                                $"SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' books accounted for this Book Inventory Report for the year of ' + CAST({dateTime.Year} AS VARCHAR) AS Narrative, 'Book Inventory Report' AS Title FROM [Book Inventory] WHERE YEAR(DateAcquired) = {dateTime.Year}; " +
                                $"SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FORMAT(DateAcquired, 'MMMM dd, yyyy') AS DateAcquired, Copyright, TotalPages, RetailPrice, DeweyDecimalRange, SpecificSource FROM [Book Inventory] WHERE MONTH(DateAcquired) = {dateTime.Month} AND YEAR(DateAcquired) = {dateTime.Year}; " +
                                $"SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' books accounted for within {dateTime.ToString("MMMM")} of year ' + CAST({dateTime.Year} AS VARCHAR), '{dateTime.ToString("MMMM")} ' + CAST({dateTime.Year} AS VARCHAR) AS Title FROM [Book Inventory] WHERE MONTH(DateAcquired) = {dateTime.Month} AND YEAR(DateAcquired) = {dateTime.Year}; " +
                                "");

            else if (!tabular && narrative)
                return QueryData("" +
                                $"SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' books accounted for this Book Inventory Report for the year of ' + CAST({dateTime.Year} AS VARCHAR) AS Narrative, 'Book Inventory Report' AS Title FROM [Book Inventory] WHERE YEAR(DateAcquired) = {dateTime.Year}; " +
                                $"SELECT * FROM [Book Inventory] WHERE MONTH(DateAcquired) = {dateTime.Month} AND YEAR(DateAcquired) = 0; " +
                                $"SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' books accounted for within {dateTime.ToString("MMMM")} of year ' + CAST({dateTime.Year} AS VARCHAR) AS Narrative, '{dateTime.ToString("MMMM")} ' + CAST({dateTime.Year} AS VARCHAR) AS Title FROM [Book Inventory] WHERE MONTH(DateAcquired) = {dateTime.Month} AND YEAR(DateAcquired) = {dateTime.Year}; " +
                                "");
            else
                return new DataSet();

        }

        #endregion

        #region BORROWED BOOKS
        public DataSet GetBorrowedBooks(String dateTime, bool tabular = true, bool narrative = false, string filter = "YEAR")
        {
            String Q = $"SELECT 'Borrowed Books Report (' + FORMAT(CAST('{dateTime}' AS DATE), 'MMM dd, yyyy') + ' to ' + FORMAT(DATEADD({filter}, 1, CAST('{dateTime}' AS DATE)), 'MMM dd, yyyy') + ')' AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' borrowed books has been accounted for this following {filter} ' + FORMAT(CAST('{dateTime}' AS DATE), 'MMM dd, yyyy') + ' to ' + FORMAT(DATEADD({filter}, 1, CAST('{dateTime}' AS DATE)), 'MMM dd, yyyy') + '.' AS Total FROM [Book Borrowing] WHERE BookAvailability = 'BORROWED' AND Date_Borrowed BETWEEN CAST('{dateTime}' AS DATE) AND DATEADD({filter}, 1, CAST('{dateTime}' AS DATE));";
            if (tabular && narrative)
                return QueryData("" +
                        Q +
                        $"SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FirstName + ' ' + MiddleName + ' ' + LastName AS BorrowedBy, FORMAT(Date_Borrowed, 'MMM dd, yyyy') AS Date_Borrowed, FORMAT(DueDate, 'MMM dd, yyyy') AS DueDate, ApprovedBy, FORMAT(ApprovedOn, 'MMM dd, yyyy') AS ApprovedOn FROM [Book Borrowing] WHERE BookAvailability = 'BORROWED' AND Date_Borrowed BETWEEN CAST('{dateTime}' AS DATE) AND DATEADD({filter}, 1, CAST('{dateTime}' AS DATE));" +
                        $"SELECT 'The book having the title ' + A.BookTitle + ' and having the accession number ' + A.AccessionNumber + ' has been borrowed ' + CAST(COUNT(A.COCPL_UID) AS VARCHAR) + ' times for this {filter} (' + FORMAT(CAST('{dateTime}' AS DATE), 'MMM dd, yyyy') + ' to ' + FORMAT(DATEADD({filter}, 1, CAST('{dateTime}' AS DATE)), 'MMM dd, yyyy') + ').' AS Narrative FROM (SELECT COCPL_UID, BookTitle, AccessionNumber FROM [Book Borrowing] WHERE BookAvailability = 'BORROWED' AND Date_Borrowed BETWEEN CAST('{dateTime}' AS DATE) AND DATEADD({filter}, 1, CAST('{dateTime}' AS DATE)) GROUP BY BookTitle, COCPL_UID, AccessionNumber) AS A GROUP BY A.BookTitle, A.AccessionNumber" +
                    "");
            else if (!tabular && narrative)
                return QueryData("" +
                        Q +
                        "SELECT 'none' AS dummy;" +
                        $"SELECT 'The book having the title ' + A.BookTitle + ' and having the accession number ' + A.AccessionNumber + ' has been borrowed ' + CAST(COUNT(A.COCPL_UID) AS VARCHAR) + ' times for this {filter} (' + FORMAT(CAST('{dateTime}' AS DATE), 'MMM dd, yyyy') + ' to ' + FORMAT(DATEADD({filter}, 1, CAST('{dateTime}' AS DATE)), 'MMM dd, yyyy') + ').' AS Narrative FROM (SELECT COCPL_UID, BookTitle, AccessionNumber FROM [Book Borrowing] WHERE BookAvailability = 'BORROWED' AND Date_Borrowed BETWEEN CAST('{dateTime}' AS DATE) AND DATEADD({filter}, 1, CAST('{dateTime}' AS DATE)) GROUP BY BookTitle, COCPL_UID, AccessionNumber) AS A GROUP BY A.BookTitle, A.AccessionNumber" +
                    "");
            else if (tabular && !narrative)
                return QueryData("" +
                        Q +
                        $"SELECT AccessionNumber, BookTitle, ISBN, AuthorNo, BookAuthor, FirstName + ' ' + MiddleName + ' ' + LastName AS BorrowedBy, FORMAT(Date_Borrowed, 'MMM dd, yyyy') AS Date_Borrowed, FORMAT(DueDate, 'MMM dd, yyyy') AS DueDate, ApprovedBy, FORMAT(ApprovedOn, 'MMM dd, yyyy') AS ApprovedOn FROM [Book Borrowing] WHERE BookAvailability = 'BORROWED' AND Date_Borrowed BETWEEN CAST('{dateTime}' AS DATE) AND DATEADD({filter}, 1, CAST('{dateTime}' AS DATE));" +
                    "");
            else
                return new DataSet();
        }
        #endregion

        #region MEMBERS RECORDS

        public DataSet GetMembers()
        {
            return QueryData("SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS MemberName FROM [Member Data]");
        }

        public DataSet GetMembersBorrowedBooks(string keyword, bool tabular = true, bool narrative = false)
        {
            if (tabular && narrative)
                return QueryData("" +
                        $"SELECT 'Member''s UID: ' + COCPL_UID AS MemberUID, 'Member''s Name: ' + FirstName + ' ' + MiddleName + ' ' + LastName AS MemberName, 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' books borrowed by the member with the following UID ' + CAST(COCPL_UID AS VARCHAR) + '.' AS Narrative FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}' GROUP BY COCPL_UID, FirstName, MiddleName, LastName; " +
                        $"SELECT AccessionNumber, BookTitle, BookAuthor, FORMAT(Date_Borrowed, 'MMM dd, yyyy') AS Date_Borrowed, FORMAT(DueDate, 'MMM dd, yyyy') AS DueDate, ApprovedBy, ApprovedOn FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}' ORDER BY Date_Borrowed;" +
                        $"SELECT 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' books returned by the member with the following UID ' + CAST(COCPL_UID AS VARCHAR) + '.' AS Narrative FROM[Book Returns] WHERE COCPL_UID IN(SELECT COCPL_UID FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}') GROUP BY COCPL_UID;" +
                        $"SELECT AccessionNumber, BookTitle, BookAuthor, FORMAT(Date_Borrowed, 'MMM dd, yyyy') AS Date_Borrowed, FORMAT(DueDate, 'MMM dd, yyyy') AS DueDate, BookRemarksAndConditions, BKReturnsRemarks, ImposedFines, FinesPaymentStatus, ReturnedOn, NotedBy FROM[Book Returns] WHERE COCPL_UID IN(SELECT COCPL_UID FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}')" +
                    "");

            else if (!tabular && narrative)
                return QueryData("" +
                        $"SELECT 'Member''s UID: ' + COCPL_UID AS MemberUID, 'Member''s Name: ' + FirstName + ' ' + MiddleName + ' ' + LastName AS MemberName, 'There are a total of ' + CAST(COUNT(*) AS VARCHAR) + ' books borrowed by the member with the following UID ' + CAST(COCPL_UID AS VARCHAR) + '.' AS Narrative FROM [Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}' GROUP BY COCPL_UID, FirstName, MiddleName, LastName;" +
                        $"SELECT 'The book having the title ' + BookTitle + ' and having the accession number ' + AccessionNumber + ' has been borrowed, having a  book borrowing duration of ' + CAST(Date_Borrowed AS VARCHAR) + ' to ' + CAST(DueDate AS VARCHAR) + ' and was noted by ' + ApprovedBy + ' on ' + CAST(ApprovedOn AS VARCHAR) AS Narrative FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}' ORDER BY Date_Borrowed;" +
                        $"SELECT 'The book having the title ' + BookTitle + ' and having the accession number ' + AccessionNumber + ' that had a  book borrowing duration of ' + CAST(Date_Borrowed AS VARCHAR) + ' to ' + CAST(DueDate AS VARCHAR) + ' has been returned on ' + CAST(ReturnedOn AS VARCHAR) + '. This record has been noted by ' + NotedBy + ' and this following instance of the book being returned has been ' + BookRemarksAndConditions + '. This instance of the book has incurred fines worth ' + CAST(ImposedFines AS VARCHAR) + ' and has been ' + BKReturnsRemarks + '.' AS Narrative FROM [Book Returns] WHERE COCPL_UID IN(SELECT COCPL_UID FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}');" +
                    "");

            else if (tabular && !narrative)
                return QueryData("" +
                        $"SELECT 'Member''s UID: ' + COCPL_UID AS MemberUID, 'Member''s Name: ' + FirstName + ' ' + MiddleName + ' ' + LastName AS MemberName, 'BOOKS BORROWED: ' + CAST(COUNT(*) AS VARCHAR) AS Title FROM [Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}' GROUP BY COCPL_UID, FirstName, MiddleName, LastName;" +
                        $"SELECT AccessionNumber, BookTitle, BookAuthor, FORMAT(Date_Borrowed, 'MMM dd, yyyy') AS Date_Borrowed, FORMAT(DueDate, 'MMM dd, yyyy') AS DueDate, ApprovedBy, ApprovedOn FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}' ORDER BY Date_Borrowed;" +
                        $"SELECT 'BOOKS RETURNED: ' + CAST(COUNT(*) AS VARCHAR) AS Title FROM[Book Returns] WHERE COCPL_UID IN(SELECT COCPL_UID FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}' GROUP BY COCPL_UID);" +
                        $"SELECT AccessionNumber, BookTitle, BookAuthor, FORMAT(Date_Borrowed, 'MMM dd, yyyy') AS Date_Borrowed, FORMAT(DueDate, 'MMM dd, yyyy') AS DueDate, BookRemarksAndConditions, BKReturnsRemarks, ImposedFines, FinesPaymentStatus, ReturnedOn, NotedBy FROM[Book Returns] WHERE COCPL_UID IN(SELECT COCPL_UID FROM[Book Borrowing Individual Member Records] WHERE FirstName + ' ' + MiddleName + ' ' + LastName = '{keyword}'); " +

                    "");
            
            else
                return new DataSet();
        }

        #endregion

        #region MEMBERSHIP FREQUENCY
        public DataSet GetMemberFrequencyByYear(DateTime dateTime, bool tabular = true, bool narrative = false, bool graph = false)
        {
            if (tabular && narrative)
                return QueryData("" +
                        $"SELECT 'Membership Frequency Report as of year ' + CAST({dateTime.Year} AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of year of ' + CAST({dateTime.Year} AS VARCHAR) + '.' AS Narrative FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year};" +
                        $"SELECT COCPL_UID, FirstName + ' ' + MiddleName + ' ' + LastName + ' ' + Suffix AS FullName, SchoolOrOrganization, EMailAddress, ContactNo, FORMAT(MemberStart, 'MMM dd, yyyy') AS MemberStart, FORMAT(MemberEnd, 'MMM dd, yyyy') AS MemberEnd FROM[Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} ORDER BY CAST(MemberStart AS DateTime);" +
                        $"SELECT FirstName + ' ' + MiddleName + ' ' + LastName + ' is registered with the COCPL UID ' + COCPL_UID + '. The validity of this membership has started on ' + FORMAT(MemberStart, 'MMMM dd, yyyy') + ' and will end on ' + FORMAT(MemberEnd, 'MMMM dd, yyyy') + '.' AS Narrative FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} ORDER BY CAST(MemberStart AS DateTime);");

            else if (!tabular && narrative)
                return QueryData("" +
                        $"SELECT 'Membership Frequency Report as of year ' + CAST({dateTime.Year} AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of year of ' + CAST({dateTime.Year} AS VARCHAR) + '.' AS Narrative, 'The following members registered for the year ' + CAST({dateTime.Year} AS VARCHAR) AS NarrativeTitle FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year};" +
                        $"SELECT FirstName + ' ' + MiddleName + ' ' + LastName + ' is registered with the COCPL UID ' + COCPL_UID + '. The validity of this membership has started on ' + FORMAT(MemberStart, 'MMMM dd, yyyy') + ' and will end on ' + FORMAT(MemberEnd, 'MMMM dd, yyyy') + '.' AS Narrative FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} ORDER BY CAST(MemberStart AS DateTime);");

            else if (tabular && !narrative)
                return QueryData("" +
                        $"SELECT 'Membership Frequency Report as of year ' + CAST({dateTime.Year} AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of year of ' + CAST({dateTime.Year} AS VARCHAR) + '.' AS Narrative FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year};" +
                        $"SELECT COCPL_UID, FirstName + ' ' + MiddleName + ' ' + LastName + ' ' + Suffix AS FullName, SchoolOrOrganization, EMailAddress, ContactNo, FORMAT(MemberStart, 'MMM dd, yyyy') AS MemberStart, FORMAT(MemberEnd, 'MMM dd, yyyy') AS MemberEnd FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} ORDER BY CAST(MemberStart AS DateTime);" +
                    "");

            else if (graph)
                return QueryData("" +
                        $"SELECT 'Membership Frequency Report as of year ' + CAST({dateTime.Year} AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of year of ' + CAST({dateTime.Year} AS VARCHAR) + '.' AS Narrative FROM[Member Data] WHERE YEAR(MemberStart) = {dateTime.Year}; " +
                        $"SELECT COUNT(*) AS Total, TotalYear FROM(SELECT FORMAT(MemberStart, 'yyyy') AS TotalYear FROM[Member Data] WHERE YEAR(MemberStart) = {dateTime.Year}) AS A GROUP BY TotalYear;" +
                    "");

            else
                return new DataSet();
        }
        public DataSet GetMemberFrequencyByMonth(DateTime dateTime, bool tabular = true, bool narrative = false, bool graph = false)
        {

            String Q = $"SELECT 'Membership Frequency Report as of Year {dateTime.ToString("yyyy")}' AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of year {dateTime.ToString("yyyy")}' + '.' AS Narrative FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year};";

            if (tabular && narrative)
            {
                Q += $"SELECT COCPL_UID, FirstName + ' ' + MiddleName + ' ' + LastName + ' ' + Suffix AS FullName, SchoolOrOrganization, EMailAddress, ContactNo, FORMAT(MemberStart, 'MMMM dd, yyyy') AS MemberStart, FORMAT(MemberEnd, 'MMMM dd, yyyy') AS MemberEnd FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} AND MONTH(MemberStart) = {dateTime.Month} ORDER BY MONTH(MemberStart);";
                Q += $"SELECT 'Membership Frequency Report as of {dateTime.ToString("MMMM")} {dateTime.ToString("yyyy")}' AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of {dateTime.ToString("MMMM")} {dateTime.ToString("yyyy")}' + '.' AS Narrative FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} AND MONTH(MemberStart) = {dateTime.Month};";
                return QueryData(Q);
            }

            else if (!tabular && narrative)
            {
                Q += $"SELECT COCPL_UID, FirstName + ' ' + MiddleName + ' ' + LastName + ' ' + Suffix AS FullName, SchoolOrOrganization, EMailAddress, ContactNo, FORMAT(MemberStart, 'MMMM dd, yyyy') AS MemberStart, FORMAT(MemberEnd, 'MMMM dd, yyyy') AS MemberEnd FROM [Member Data] WHERE YEAR(MemberStart) = 0;";
                Q += $"SELECT 'Membership Frequency Report as of {dateTime.ToString("MMMM")} {dateTime.ToString("yyyy")}' AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of {dateTime.ToString("MMMM")} {dateTime.ToString("yyyy")}' + '.' AS Narrative FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} AND MONTH(MemberStart) = {dateTime.Month};";
                return QueryData(Q);
            }

            else if (tabular && !narrative)
            {
                Q += $"SELECT COCPL_UID, FirstName + ' ' + MiddleName + ' ' + LastName + ' ' + Suffix AS FullName, SchoolOrOrganization, EMailAddress, ContactNo, FORMAT(MemberStart, 'MMMM dd, yyyy') AS MemberStart, FORMAT(MemberEnd, 'MMMM dd, yyyy') AS MemberEnd FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} AND MONTH(MemberStart) = {dateTime.Month} ORDER BY MONTH(MemberStart);";
                Q += $"SELECT 'Membership Frequency Report as of {dateTime.ToString("MMMM")} {dateTime.ToString("yyyy")}' AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' members have registered as of {dateTime.ToString("MMMM")} {dateTime.ToString("yyyy")}' + '.' FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year} AND MONTH(MemberStart) = {dateTime.Month};";
                return QueryData(Q);
            }

            else if (graph)
                return QueryData("" +
                        Q +
                        $"SELECT COUNT(*) AS Total, TotalMonth FROM(SELECT FORMAT(MemberStart, 'MMMM') AS TotalMonth FROM [Member Data] WHERE YEAR(MemberStart) = {dateTime.Year}) AS A GROUP BY TotalMonth;" +
                    "");

            else
                return new DataSet();

        }

        #endregion

        #region CLIENT LOGBOOK

        public DataSet GetClientLogbook(DateTime dateTime, bool tabular = true, bool narrative = false, bool graph = false)
        {
            if (tabular && narrative)
                return QueryData($"SELECT 'CLIENT LOGBOOK REPORT FOR THE YEAR OF ' + CAST(YEAR(Date) AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' walk-in clients have availed the services of the library for the year of ' + CAST(YEAR(Date) AS VARCHAR) + '.' AS Total FROM [Client Logbook] WHERE YEAR(Date) = {dateTime.Year} GROUP BY YEAR(Date); " +
                                 $"SELECT FirstName, MiddleName, LastName, Address, ContactNo, FORMAT(Date, 'MMM dd, yyyy') AS Date, Time FROM[Client Logbook] WHERE YEAR(Date) = {dateTime.Year} ORDER BY Date, Time; " +
                                 $"SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' walk-in clients have availed the services of the library on ' + FORMAT(Date, 'MMMM yyyy') + '.' AS Narrative FROM[Client Logbook] GROUP BY Date HAVING YEAR(Date) = {dateTime.Year} ORDER BY YEAR(Date), MONTH(Date)");
            else if (!tabular && narrative)
                return QueryData($"SELECT 'CLIENT LOGBOOK REPORT FOR THE YEAR OF ' + CAST(YEAR(Date) AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' walk-in clients have availed the services of the library for the year of ' + CAST(YEAR(Date) AS VARCHAR) + '.' AS Total FROM [Client Logbook] WHERE YEAR(Date) = {dateTime.Year} GROUP BY YEAR(Date); " +
                                 $"SELECT 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' walk-in clients have availed the services of the library on ' + FORMAT(Date, 'MMMM yyyy') + '.' AS Narrative FROM[Client Logbook] GROUP BY Date HAVING YEAR(Date) = {dateTime.Year} ORDER BY YEAR(Date), MONTH(Date)");
            else if (tabular && !narrative)
                return QueryData($"SELECT 'CLIENT LOGBOOK REPORT FOR THE YEAR OF ' + CAST(YEAR(Date) AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' walk-in clients have availed the services of the library for the year of ' + CAST(YEAR(Date) AS VARCHAR) + '.' AS Total FROM [Client Logbook] WHERE YEAR(Date) = {dateTime.Year} GROUP BY YEAR(Date); " +
                                 $"SELECT FirstName, MiddleName, LastName, Address, ContactNo, FORMAT(Date, 'MMM dd, yyyy') AS Date, Time FROM[Client Logbook] WHERE YEAR(Date) = {dateTime.Year} ORDER BY Date, Time; ");
            else
                if (graph)
                return QueryData($"SELECT 'CLIENT LOGBOOK REPORT FOR THE YEAR OF ' + CAST(YEAR(Date) AS VARCHAR) AS Title, 'A total of ' + CAST(COUNT(*) AS VARCHAR) + ' walk-in clients have availed the services of the library for the year of ' + CAST(YEAR(Date) AS VARCHAR) + '.' AS Total FROM [Client Logbook] WHERE YEAR(Date) = {dateTime.Year} GROUP BY YEAR(Date); " +
                                 $"SELECT COUNT(*) AS WalkInClients, FORMAT(Date, 'MMMM') AS LogMonth FROM [Client Logbook] GROUP BY Date HAVING YEAR(Date) = {dateTime.Year} ORDER BY YEAR(Date), MONTH(Date)");
            else
                return new DataSet();
        }

        #endregion

    }
}
