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

namespace Capstone.Reports.ClientLogbook
{
    public partial class View_ClientLogbook : Form
    {

        String filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Reports\\ClientLogbook";
        SQL_Reports cmd = new SQL_Reports();

        public View_ClientLogbook()
        {
            InitializeComponent();
        }

        private void View_ClientLogbook_Load(object sender, EventArgs e)
        {
            selectYear.Value = DateTime.Now;
            checkTabular.Checked = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            ReportDocument reportDocument = new ReportDocument();
            DataSet dataSource = cmd.GetClientLogbook(selectYear.Value, checkTabular.Checked, checkNarrative.Checked, (checkBar.Checked || checkLine.Checked));


            if (checkTabular.Checked && checkNarrative.Checked)
            {
                reportDocument.Load(filePath + "\\Tabular_Narrative\\CLB_Report_Tabular_Narrative.rpt");
                reportDocument.Subreports["Tabular"].SetDataSource(dataSource);
                reportDocument.Subreports["Narrative"].SetDataSource(dataSource);
            }

            else if (checkTabular.Checked && !checkNarrative.Checked)
                reportDocument.Load(filePath + "\\Tabular\\CLB_Report_Tabular.rpt");

            else if (!checkTabular.Checked && checkNarrative.Checked)
                reportDocument.Load(filePath + "\\Narrative\\CLB_Report_Narrative.rpt");

            else
                if (checkBar.Checked)
                    reportDocument.Load(filePath + "\\Graph\\CLB_Graph_Bar.rpt");

                else if (checkLine.Checked)
                    reportDocument.Load(filePath + "\\Graph\\CLB_Graph_Line.rpt");


            reportDocument.SetDataSource(dataSource);
            reportViewer.ReportSource = reportDocument;

        }

        private void checkTabular_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTabular.Checked)
            {
                checkBar.Checked = false;
                checkLine.Checked = false;
            }
        }
        private void checkNarrative_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNarrative.Checked)
            {
                checkBar.Checked = false;
                checkLine.Checked = false;
            }
        }
        private void checkBar_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBar.Checked)
            {
                checkLine.Checked = false;
                checkTabular.Checked = false;
                checkNarrative.Checked = false;
            }
        }
        private void checkLine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLine.Checked)
            {
                checkBar.Checked = false;
                checkTabular.Checked = false;
                checkNarrative.Checked = false;
            }
        }

    }
}
