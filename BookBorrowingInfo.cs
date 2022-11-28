using System;

namespace Capstone
{
    public class BookBorrowingInfo
    {
        public String id { get; set; }
        public String BookTitle { get; set; }
        public String AccessionNumber { get; set; }
        public String BookAuthor { get; set; }
        public String BookAvailability { get; set; }
        public String COCPL_UID { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String Suffix { get; set; }
        public String Date_Borrowed { get; set; }
        public String DueDate { get; set; }
        public String ApprovedBy { get; set; }
        public String EmpUsername { get; set; }
        public String ApprovedOn { get; set; }
        public String Source { get; set; }
    }
    public class getBKBRColumn
    {
        public String name { get; set; }
        public String BookAuthor { get; set; }
        public String AccessionNumber { get; set; }
        public String BookTitle { get; set; }
        public String COCPL_UID { get; set; }
        public String ApprovedBy { get; set; }
    }
    public class BKBRNotifs
    {
        public String NotificationMsg { get; set; }
        public String DatePosted { get; set; }
        public String Source { get; set; }
    }
    public class ApprovedNotifs
    {
        public String id { get; set; }
        public String NotificationMsg { get; set; }
        public String DatePosted { get; set; }
        public String DateApproved { get; set; }
        public String BookTitle { get; set; }
        public String COCPL_UID { get; set; }
        public String Source { get; set; }
    }
    public class BKBR_Ind_Rec
    {
        public String id { get; set; }
        public String BookTitle { get; set; }
        public String AccessionNumber { get; set; }
        public String BookAuthor { get; set; }
        public String Date_Borrowed { get; set; }
        public String DueDate { get; set; }
        public String ApprovedBy { get; set; }
        public String ApprovedOn { get; set; }
    }
}
