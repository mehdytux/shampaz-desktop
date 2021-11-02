using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shampaz
{
    public partial class SellFactorNobatReportForm : DevComponents.DotNetBar.Office2007Form
    {
        public SellFactorNobatReportForm(int turn)
        {
            InitializeComponent();
            //SellFactorItemBindingSource.DataSource = data;
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("Nobat", "غذای خانگی شام پز - نوبت شما شماره " + turn.ToString());
            reportViewer1.LocalReport.SetParameters(parameters);
        }

        private void SellFactorKitchenReportForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            reportViewer1.SetPageSettings(setup);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            Close();
        }
    }
}
