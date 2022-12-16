
namespace Capstone.Reports.BorrowedBooks
{
    partial class View_BorrowedBooks
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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.labelDate = new System.Windows.Forms.Label();
            this.checkMonth = new System.Windows.Forms.CheckBox();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkNarrative = new System.Windows.Forms.CheckBox();
            this.checkTabular = new System.Windows.Forms.CheckBox();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.checkWeek = new System.Windows.Forms.CheckBox();
            this.checkYear = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.checkYear);
            this.mainContainer.Panel1.Controls.Add(this.checkWeek);
            this.mainContainer.Panel1.Controls.Add(this.labelDate);
            this.mainContainer.Panel1.Controls.Add(this.checkMonth);
            this.mainContainer.Panel1.Controls.Add(this.selectDate);
            this.mainContainer.Panel1.Controls.Add(this.buttonGenerate);
            this.mainContainer.Panel1.Controls.Add(this.checkNarrative);
            this.mainContainer.Panel1.Controls.Add(this.checkTabular);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.reportViewer);
            this.mainContainer.Size = new System.Drawing.Size(1043, 481);
            this.mainContainer.SplitterDistance = 251;
            this.mainContainer.SplitterWidth = 5;
            this.mainContainer.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(16, 82);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(81, 17);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Select Date";
            // 
            // checkMonth
            // 
            this.checkMonth.AutoSize = true;
            this.checkMonth.Location = new System.Drawing.Point(16, 168);
            this.checkMonth.Margin = new System.Windows.Forms.Padding(4);
            this.checkMonth.Name = "checkMonth";
            this.checkMonth.Size = new System.Drawing.Size(123, 21);
            this.checkMonth.TabIndex = 9;
            this.checkMonth.Text = "Filter by Month";
            this.checkMonth.UseVisualStyleBackColor = true;
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "MM-dd-yyyy";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(16, 109);
            this.selectDate.Margin = new System.Windows.Forms.Padding(4);
            this.selectDate.Name = "selectDate";
            this.selectDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectDate.Size = new System.Drawing.Size(224, 22);
            this.selectDate.TabIndex = 5;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(16, 226);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(224, 46);
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
            this.reportViewer.Size = new System.Drawing.Size(787, 481);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // checkWeek
            // 
            this.checkWeek.AutoSize = true;
            this.checkWeek.Location = new System.Drawing.Point(16, 139);
            this.checkWeek.Margin = new System.Windows.Forms.Padding(4);
            this.checkWeek.Name = "checkWeek";
            this.checkWeek.Size = new System.Drawing.Size(120, 21);
            this.checkWeek.TabIndex = 11;
            this.checkWeek.Text = "Filter by Week";
            this.checkWeek.UseVisualStyleBackColor = true;
            // 
            // checkYear
            // 
            this.checkYear.AutoSize = true;
            this.checkYear.Location = new System.Drawing.Point(16, 197);
            this.checkYear.Margin = new System.Windows.Forms.Padding(4);
            this.checkYear.Name = "checkYear";
            this.checkYear.Size = new System.Drawing.Size(114, 21);
            this.checkYear.TabIndex = 11;
            this.checkYear.Text = "Filter by Year";
            this.checkYear.UseVisualStyleBackColor = true;
            // 
            // View_BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 481);
            this.Controls.Add(this.mainContainer);
            this.Name = "View_BorrowedBooks";
            this.Text = "View_BorrowedBooks";
            this.Load += new System.EventHandler(this.View_BorrowedBooks_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.CheckBox checkMonth;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox checkNarrative;
        private System.Windows.Forms.CheckBox checkTabular;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.CheckBox checkYear;
        private System.Windows.Forms.CheckBox checkWeek;
    }
}