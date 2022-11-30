using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone.Reports
{
    class SQL_Reports
    {
        // UTILS
        public DataTable CreateTable(String Q, String TableName)
        {
            using (SqlConnection DB = new SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                DataTable DT = new DataTable(TableName);
                try
                {
                    SqlDataAdapter DA = new SqlDataAdapter(Q, DB);
                    DA.Fill(DT);
                    return DT;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return DT;
                }
            }
        }


        // BOOK INVENTORY
        public DataTable GetMissingBooks()
        {
            return CreateTable("SELECT " +
                               "    AccessionNumber AS [Accession Number], " +
                               "    BookTitle AS [Book Title], " +
                               "    BookAuthor AS [Book Author], " +
                               "    FORMAT (DateAcquired, 'MMMM dd, yyyy') AS [Date Acquired] " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'MISSING'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())", 

                               "Table_MissingBooks");
        }
        public DataTable GetAvailableBooks()
        {
            return CreateTable("SELECT " +
                               "    AccessionNumber AS [Accession Number], " +
                               "    BookTitle AS [Book Title], " +
                               "    BookAuthor AS [Book Author], " +
                               "    FORMAT (DateAcquired, 'MMMM dd, yyyy') AS [Date Acquired] " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    (Availability = 'OPEN FOR BORROWING' OR Availability = 'FOR INSIDE READING ONLY')" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())",

                               "Table_AvailableBooks");
        }
        public DataTable GetDiscardedBooks()
        {
            return CreateTable("SELECT " +
                               "    AccessionNumber AS [Accession Number], " +
                               "    BookTitle AS [Book Title], " +
                               "    BookAuthor AS [Book Author], " +
                               "    FORMAT (DateAcquired, 'MMMM dd, yyyy') AS [Date Acquired] " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'DISCARDED'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())",

                               "Table_DiscardedBooks");
        }
        public DataTable GetBorrowedBooks()
        {
            return CreateTable("SELECT " +
                               "    AccessionNumber AS [Accession Number], " +
                               "    BookTitle AS [Book Title], " +
                               "    BookAuthor AS [Book Author], " +
                               "    FORMAT (DateAcquired, 'MMMM dd, yyyy') AS [Date Acquired] " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'BORROWED'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())",

                               "Table_BorrowedBooks");
        }

        
        public DataTable GetNarrative()
        {
            return CreateTable("SELECT (CASE WHEN B.Narrative IS NULL THEN A.Narrative ELSE B.Narrative END) AS Narrative, YEAR(GETDATE()) AS [Current Year]" +
                               "FROM " +
                               "(" +
                               "    SELECT 'No Books were BORROWED' AS Narrative, 'BORROWED' AS Availability " +
                               "    UNION " +
                               "    SELECT 'No Books were OPEN FOR BORROWING' AS Narrative, 'OPEN FOR BORROWING' AS Availability " +
                               "    UNION " +
                               "    SELECT 'No Books were FOR INSIDE READING ONLY' AS Narrative, 'FOR INSIDE READING ONLY' AS Availability " +
                               "    UNION " +
                               "    SELECT 'No Books were MISSING' AS Narrative, 'MISSING' AS Availability " +
                               "    UNION " +
                               "    SELECT 'No Books were DISCARDED' AS Narrative, 'DISCARDED' AS Availability " +
                               ") AS A " +
                               "LEFT JOIN " +
                               "(SELECT " +
                               "    CASE " +
                               "        WHEN COUNT(*) = 1 " +
                               "        THEN CAST(COUNT(*) AS VARCHAR) + ' Book is ' + Availability " +
                               "        ELSE CAST(COUNT(*) AS VARCHAR) + ' Books are ' + Availability " +
                               "    END " +
                               "    AS Narrative, " +
                               "    Availability " +
                               "FROM [Book Inventory] " +
                               "WHERE " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE()) " +
                               "GROUP BY Availability) AS B ON A.Availability = B.Availability",
                               "Table_Narrative");
        }
        public DataTable GetTotalMissingBooks()
        {
            return CreateTable("SELECT " +
                               "    COUNT(*) AS Total, " +
                               "    Availability " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'MISSING'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())" +
                               "GROUP BY" +
                               "    Availability",
                               "Table_TotalMissingBooks");
        }
        public DataTable GetTotalOpenBooks()
        {
            return CreateTable("SELECT " +
                               "    COUNT(*) AS Total, " +
                               "    Availability " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'OPEN FOR BORROWING'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())" +
                               "GROUP BY" +
                               "    Availability",
                               "Table_TotalOpenBooks");
        }
        public DataTable GetTotalInsideBooks()
        {
            return CreateTable("SELECT " +
                               "    COUNT(*) AS Total, " +
                               "    Availability " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'FOR INSIDE READING ONLY'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())" +
                               "GROUP BY" +
                               "    Availability",
                               "Table_TotalInsideBooks");
        }
        public DataTable GetTotalBorrowedBooks()
        {
            return CreateTable("SELECT " +
                               "    COUNT(*) AS Total, " +
                               "    Availability " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'BORROWED'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())" +
                               "GROUP BY" +
                               "    Availability",
                               "Table_TotalBorrowedBooks");
        }
        public DataTable GetTotalDiscardedBooks()
        {
            return CreateTable("SELECT " +
                               "    COUNT(*) AS Total, " +
                               "    Availability " +
                               "FROM " +
                               "    [Book Inventory] " +
                               "WHERE " +
                               "    Availability = 'DISCARDED'" +
                               "AND " +
                               "    YEAR(DateAcquired) = YEAR(GETDATE())" +
                               "GROUP BY" +
                               "    Availability",
                               "Table_TotalDiscardedBooks");
        }
        
        public DataTable GetBookStatus()
        {
            return CreateTable("SELECT " +
                               "    COUNT(*) AS[Total Books], " +
                               "    Availability " +
                               "FROM [Book Inventory] " +
                               "WHERE YEAR(DateAcquired) = YEAR(GETDATE()) " +
                               "GROUP BY Availability",
                               "Table_BookStatus");
        }
    }
}
