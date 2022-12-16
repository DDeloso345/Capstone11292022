using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone.Reports.BorrowedBooks
{
    public partial class View_BorrowedBooks : Form
    {

        String filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Reports\\BorrowedBooks";
        SQL_Reports cmd = new SQL_Reports();

        public View_BorrowedBooks()
        {
            InitializeComponent();
        }

        private void View_BorrowedBooks_Load(object sender, EventArgs e)
        {

        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            String filter = "YEAR";
            if (checkWeek.Checked) filter = "WEEK";
            if (checkMonth.Checked) filter = "MONTH";
            
            ReportDocument reportDocument = new ReportDocument();
            DataSet dataSource = cmd.GetBorrowedBooks(selectDate.Text, checkTabular.Checked, checkNarrative.Checked, filter);

            reportDocument.Load(filePath + "\\BB_Report_Main.rpt");
            reportDocument.SetDataSource(dataSource);
            reportViewer.ReportSource = reportDocument;


        }

    }
}
