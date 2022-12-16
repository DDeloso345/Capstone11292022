
namespace Capstone.Reports.BookInventory
{
    partial class View_BookInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.selectYear = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkNarrative = new System.Windows.Forms.CheckBox();
            this.checkTabular = new System.Windows.Forms.CheckBox();
            this.labelReport = new System.Windows.Forms.Label();
            this.selectReport = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(804, 554);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.selectYear);
            this.mainContainer.Panel1.Controls.Add(this.buttonGenerate);
            this.mainContainer.Panel1.Controls.Add(this.checkNarrative);
            this.mainContainer.Panel1.Controls.Add(this.checkTabular);
            this.mainContainer.Panel1.Controls.Add(this.labelReport);
            this.mainContainer.Panel1.Controls.Add(this.selectReport);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.reportViewer);
            this.mainContainer.Size = new System.Drawing.Size(1067, 554);
            this.mainContainer.SplitterDistance = 258;
            this.mainContainer.SplitterWidth = 5;
            this.mainContainer.TabIndex = 1;
            // 
            // selectYear
            // 
            this.selectYear.CustomFormat = "yyyy";
            this.selectYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectYear.Location = new System.Drawing.Point(16, 127);
            this.selectYear.Margin = new System.Windows.Forms.Padding(4);
            this.selectYear.Name = "selectYear";
            this.selectYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectYear.ShowUpDown = true;
            this.selectYear.Size = new System.Drawing.Size(224, 22);
            this.selectYear.TabIndex = 5;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(15, 169);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(225, 46);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "GENERATE";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // checkNarrative
            // 
            this.checkNarrative.AutoSize = true;
            this.checkNarrative.Location = new System.Drawing.Point(16, 43);
            this.checkNarrative.Margin = new System.Windows.Forms.Padding(4);
            this.checkNarrative.Name = "checkNarrative";
            this.checkNarrative.Size = new System.Drawing.Size(88, 21);
            this.checkNarrative.TabIndex = 3;
            this.checkNarrative.Text = "Narrative";
            this.checkNarrative.UseVisualStyleBackColor = true;
            this.checkNarrative.CheckedChanged += new System.EventHandler(this.checkNarrative_CheckedChanged);
            // 
            // checkTabular
            // 
            this.checkTabular.AutoSize = true;
            this.checkTabular.Location = new System.Drawing.Point(16, 15);
            this.checkTabular.Margin = new System.Windows.Forms.Padding(4);
            this.checkTabular.Name = "checkTabular";
            this.checkTabular.Size = new System.Drawing.Size(79, 21);
            this.checkTabular.TabIndex = 2;
            this.checkTabular.Text = "Tabular";
            this.checkTabular.UseVisualStyleBackColor = true;
            this.checkTabular.CheckedChanged += new System.EventHandler(this.checkTabular_CheckedChanged);
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Location = new System.Drawing.Point(17, 75);
            this.labelReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(59, 17);
            this.labelReport.TabIndex = 1;
            this.labelReport.Text = "Filter By";
            // 
            // selectReport
            // 
            this.selectReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectReport.FormattingEnabled = true;
            this.selectReport.Items.AddRange(new object[] {
            "Availability",
            "Date"});
            this.selectReport.Location = new System.Drawing.Point(16, 95);
            this.selectReport.Margin = new System.Windows.Forms.Padding(4);
            this.selectReport.Name = "selectReport";
            this.selectReport.Size = new System.Drawing.Size(224, 24);
            this.selectReport.TabIndex = 0;
            this.selectReport.SelectedIndexChanged += new System.EventHandler(this.selectReport_SelectedIndexChanged);
            // 
            // View_BookInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_BookInventory";
            this.Text = "Book Inventory Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_BookInventory_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.ComboBox selectReport;
        private System.Windows.Forms.CheckBox checkNarrative;
        private System.Windows.Forms.CheckBox checkTabular;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DateTimePicker selectYear;
    }
}