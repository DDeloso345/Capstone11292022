using CrystalDecisions.CrystalReports.Engine;
using System;
using System.IO;
using System.Windows.Forms;

namespace Capstone.Reports.BookInventory
{
    public partial class View_BookInventory : Form
    {

        String filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Reports";
        ReportDocument reportDocument = new ReportDocument();
        SQL_Reports cmd = new SQL_Reports();
        
        public View_BookInventory()
        {
            InitializeComponent();
        }

        private void View_BookInventory_Load(object sender, EventArgs e)
        {

            reportDocument.Load(filePath + "\\BookInventory\\Report_BookInventory.rpt");
            reportDocument.Subreports[0].SetDataSource(cmd.GetBookStatus());
            reportDocument.Subreports[1].SetDataSource(cmd.GetNarrative());
            reportDocument.Subreports[2].SetDataSource(cmd.GetAvailableBooks());
            reportDocument.Subreports[3].SetDataSource(cmd.GetBorrowedBooks());
            reportDocument.Subreports[4].SetDataSource(cmd.GetDiscardedBooks());
            reportDocument.Subreports[5].SetDataSource(cmd.GetMissingBooks());
            reportViewer.ReportSource = reportDocument;

        }
    }
}
