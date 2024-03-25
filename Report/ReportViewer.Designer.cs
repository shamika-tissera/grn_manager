namespace GRN_Manager.Report
{
    partial class ReportViewer
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
            this.GRNReport1 = new GRN_Manager.Report.GRNReport();
            this.GRNReport2 = new GRN_Manager.Report.GRNReport();
            this.GRNReport3 = new GRN_Manager.Report.GRNReport();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GRNReport4 = new GRN_Manager.Report.GRNReport();
            this.TestReport1 = new GRN_Manager.Report.TestReport();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.GRNReport4;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1053, 732);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 732);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportViewer";
            this.Text = "Report Viewer";
            this.ResumeLayout(false);

        }

        #endregion
        private GRNReport GRNReport1;
        //private CrystalReport CrystalReport1;
        //private CrystalReport CrystalReport2;
        //private CrystalReport CrystalReport3;
        private GRNReport GRNReport3;
        private GRNReport GRNReport2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TestReport TestReport1;
        private GRNReport GRNReport4;
    }
}