using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRN_Manager.Report
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        public void setReport(GRNReport data)
        {
            this.crystalReportViewer1.ReportSource = data;
            crystalReportViewer1.Refresh();
        }
    }
}
