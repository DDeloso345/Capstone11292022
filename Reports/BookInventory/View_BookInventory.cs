using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportAppServer.ClientDoc;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Capstone.Reports.BookInventory
{
    public partial class View_BookInventory : Form
    {
        String filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Reports\\BookInventory";
        SQL_Reports cmd = new SQL_Reports();

        public View_BookInventory()
        {
            InitializeComponent();
        }

        private void View_BookInventory_Load(object sender, EventArgs e)
        {
            selectReport.SelectedIndex = 0;
            buttonGenerate.Enabled = toggleButton();
        }

        private void selectReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectReport.Text == "Availability")
                selectYear.Enabled = false;
            else
                selectYear.Enabled = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();

            if(selectReport.SelectedIndex == 0)
            {

                reportDocument.Load(filePath + "\\Availability\\BaseReport.rpt");

                reportDocument.Subreports["Missing Tab"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "MISSING"));
                reportDocument.Subreports["Missing Nar"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "MISSING"));

                reportDocument.Subreports["Borrowed Tab"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "BORROWED"));
                reportDocument.Subreports["Borrowed Nar"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "BORROWED"));

                reportDocument.Subreports["Available Tab"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "AVAILABLE"));
                reportDocument.Subreports["Available Nar"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "AVAILABLE"));

                reportDocument.Subreports["Discarded Tab"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "DISCARDED"));
                reportDocument.Subreports["Discarded Nar"].SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked, "DISCARDED"));

                reportDocument.SetDataSource(cmd.GetBookInventoryByAvailability(checkTabular.Checked, checkNarrative.Checked));

            }
            else
            {

                reportDocument.Load(filePath + "\\Date\\BaseReport.rpt");

                reportDocument.Subreports["Jan Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 1, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Jan Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 1, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Feb Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 2, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Feb Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 2, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Mar Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 3, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Mar Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 3, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Apr Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 4, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Apr Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 4, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["May Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 5, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["May Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 5, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Jun Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 6, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Jun Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 6, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Jul Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 7, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Jul Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 7, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Aug Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 8, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Aug Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 8, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Sep Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 9, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Sep Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 9, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Oct Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 10, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Oct Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 10, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Nov Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 11, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Nov Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 11, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.Subreports["Dec Tab"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 12, 1), checkTabular.Checked, checkNarrative.Checked));
                reportDocument.Subreports["Dec Nar"].SetDataSource(cmd.GetBookInventoryByDate(new DateTime(selectYear.Value.Year, 12, 1), checkTabular.Checked, checkNarrative.Checked));

                reportDocument.SetDataSource(cmd.GetBookInventoryByDate(selectYear.Value, checkTabular.Checked, checkNarrative.Checked));

            }

            reportViewer.ReportSource = reportDocument;

        }

        private bool toggleButton()
        {
            if (!checkTabular.Checked && !checkNarrative.Checked) return false;
            else return true;
        }

        private void checkNarrative_CheckedChanged(object sender, EventArgs e)
        {
            buttonGenerate.Enabled = toggleButton();
        }

        private void checkTabular_CheckedChanged(object sender, EventArgs e)
        {
            buttonGenerate.Enabled = toggleButton();
        }
    }
}
