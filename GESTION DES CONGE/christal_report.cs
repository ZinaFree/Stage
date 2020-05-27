using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace GESTION_DES_CONGE
{
    public partial class christal_report : Form
    {
        public christal_report()
        {
            InitializeComponent();
        }

        private void christal_report_Load(object sender, EventArgs e)
        {

        }
        public christal_report(ReportClass report)
         : this()
        {
            crystalReportViewer1.ReportSource = report;
        }
    }
}
