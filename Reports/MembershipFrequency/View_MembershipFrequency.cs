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

namespace Capstone.Reports.MembershipFrequency
{
    public partial class View_MembershipFrequency : Form
    {

        String filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Reports\\MembershipFrequency";
        SQL_Reports cmd = new SQL_Reports();

        public View_MembershipFrequency()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            ReportDocument reportDocument = new ReportDocument();

            DataSet dataSource;

            if (checkMonth.Checked)
            {

                if (checkBar.Checked)
                    reportDocument.Load(filePath + "\\Graph\\Month\\MF_Graph_Bar_Month.rpt");

                else if (checkLine.Checked)
                    reportDocument.Load(filePath + "\\Graph\\Month\\MF_Graph_Line_Month.rpt");

                else
                {

                    reportDocument.Load(filePath + "\\Date\\BaseReport.rpt");

                    reportDocument.Subreports["Jan Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 1, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Jan Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 1, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Feb Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 2, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Feb Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 2, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Mar Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 3, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Mar Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 3, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Apr Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 4, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Apr Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 4, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["May Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 5, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["May Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 5, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Jun Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 6, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Jun Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 6, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Jul Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 7, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Jul Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 7, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Aug Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 8, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Aug Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 8, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Sep Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 9, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Sep Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 9, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Oct Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 10, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Oct Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 10, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Nov Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 11, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Nov Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 11, 1), checkTabular.Checked, checkNarrative.Checked));

                    reportDocument.Subreports["Dec Tab"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 12, 1), checkTabular.Checked, checkNarrative.Checked));
                    reportDocument.Subreports["Dec Nar"].SetDataSource(cmd.GetMemberFrequencyByMonth(new DateTime(selectYear.Value.Year, 12, 1), checkTabular.Checked, checkNarrative.Checked));

                }

                reportDocument.SetDataSource(cmd.GetMemberFrequencyByMonth(selectYear.Value, checkTabular.Checked, checkNarrative.Checked, (checkBar.Checked || checkLine.Checked)));

            }
            else
            {

                dataSource = cmd.GetMemberFrequencyByYear(selectYear.Value, checkTabular.Checked, checkNarrative.Checked, (checkBar.Checked || checkLine.Checked));

                if (checkTabular.Checked && checkNarrative.Checked)
                {
                    reportDocument.Load(filePath + "\\Tabular_Narrative\\Year\\MF_Report_Tabular_Narrative_Year.rpt");
                    reportDocument.Subreports["Tabular"].SetDataSource(dataSource);
                    reportDocument.Subreports["Narrative"].SetDataSource(dataSource);
                }

                else if (checkTabular.Checked && !checkNarrative.Checked)
                    reportDocument.Load(filePath + "\\Tabular\\Year\\MF_Report_Tabular_Year.rpt");

                else if (!checkTabular.Checked && checkNarrative.Checked)
                    reportDocument.Load(filePath + "\\Narrative\\Year\\MF_Report_Narrative_Year.rpt");

                else
                    if (checkBar.Checked)
                    reportDocument.Load(filePath + "\\Graph\\Year\\MF_Graph_Bar_Year.rpt");

                else if (checkLine.Checked)
                    reportDocument.Load(filePath + "\\Graph\\Year\\MF_Graph_Line_Year.rpt");

                reportDocument.SetDataSource(dataSource);

            }

            reportViewer.ReportSource = reportDocument;

        }

        private void View_MembershipFrequency_Load(object sender, EventArgs e)
        {

        }
    }
}
