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

namespace Capstone.Reports.MemberBorrowedBooks
{
    public partial class View_MembersBorrowedBooks : Form
    {

        String filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Reports\\MemberBorrowedBooks";
        SQL_Reports cmd = new SQL_Reports();

        public View_MembersBorrowedBooks()
        {
            InitializeComponent();
        }

        private void View_MembersBorrowedBooks_Load(object sender, EventArgs e)
        {
            selectMember.DataSource = cmd.GetMembers().Tables[0];
            selectMember.DisplayMember = "MemberName";
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            DataSet dataSource = cmd.GetMembersBorrowedBooks(selectMember.Text, checkTabular.Checked, checkNarrative.Checked);

            if (checkTabular.Checked && checkNarrative.Checked)
            {
                reportDocument.Load(filePath + "\\Tabular_Narrative\\MBB_Report_Tabular_Narrative.rpt");
                reportDocument.Subreports["Borrowed"].SetDataSource(dataSource);
                reportDocument.Subreports["Returned"].SetDataSource(dataSource);
            }

            else if (checkTabular.Checked && !checkNarrative.Checked)
                reportDocument.Load(filePath + "\\Tabular\\MBB_Report_Tabular.rpt");

            else if (!checkTabular.Checked && checkNarrative.Checked)
                reportDocument.Load(filePath + "\\Narrative\\MBB_Report_Narrative.rpt");
            
            reportDocument.SetDataSource(dataSource);
            reportViewer.ReportSource = reportDocument;

        }
    }
}
