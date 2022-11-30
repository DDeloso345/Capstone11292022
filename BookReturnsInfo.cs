using System;

namespace Capstone
{
    public class BookReturnsInfo
    {
        public String id {get; set;}
        public String COCPL_UID {get; set;}
        public String BookTitle {get; set;}
        public String AccessionNumber {get; set;}
        public String BookAuthor {get; set;}
        public String Date_Borrowed {get; set;}
        public String DueDate {get; set;}
        public String BookRemarksAndConditions { get; set;}
        public String BKReturnsRemarks { get; set; }
        public String ImposedFines { get; set; }
        public String FinesPaymentStatus { get; set; }
        public String NotedBy {get; set;}
        public String Staff_Username { get; set; }
        public String ReturnedOn { get; set; }
    }
    public class getBRColumn
    {
        public String name { get; set; }
        public String isPaid { get; set; }
        public String BKReturnsRemarks { get; set; }
    }
    public class getBKBR_Ref_Info {
        public String id { get; set; }
        public String COCPL_UID { get; set; }
        public String BookTitle { get; set; }
        public String AccessionNumber { get; set; }
        public String BookAuthor { get; set; }
        public String Date_Borrowed { get; set; }
        public String DueDate { get; set; }
    }
}
