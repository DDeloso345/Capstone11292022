
namespace Capstone.Reports.MemberBorrowedBooks
{
    partial class View_MembersBorrowedBooks
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
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkNarrative = new System.Windows.Forms.CheckBox();
            this.checkTabular = new System.Windows.Forms.CheckBox();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.selectMember = new System.Windows.Forms.ComboBox();
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
            this.mainContainer.Panel1.Controls.Add(this.selectMember);
            this.mainContainer.Panel1.Controls.Add(this.labelYear);
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
            this.mainContainer.TabIndex = 3;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(13, 68);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(102, 17);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Select Member";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(16, 120);
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
            // selectMember
            // 
            this.selectMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectMember.FormattingEnabled = true;
            this.selectMember.Location = new System.Drawing.Point(16, 89);
            this.selectMember.Name = "selectMember";
            this.selectMember.Size = new System.Drawing.Size(225, 24);
            this.selectMember.Sorted = true;
            this.selectMember.TabIndex = 11;
            // 
            // View_MembersBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 481);
            this.Controls.Add(this.mainContainer);
            this.Name = "View_MembersBorrowedBooks";
            this.Text = "View_MembersBorrowedBooks";
            this.Load += new System.EventHandler(this.View_MembersBorrowedBooks_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ComboBox selectMember;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox checkNarrative;
        private System.Windows.Forms.CheckBox checkTabular;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
    }
}