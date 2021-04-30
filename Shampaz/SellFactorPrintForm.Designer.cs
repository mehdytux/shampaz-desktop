namespace Shampaz
{
    partial class SellFactorPrintForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SellFactorItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellFactorReportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SellFactorItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellFactorReportDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SellFactorItemBindingSource
            // 
            this.SellFactorItemBindingSource.DataSource = typeof(Shampaz.SellFactorItem);
            // 
            // SellFactorReportDataBindingSource
            // 
            this.SellFactorReportDataBindingSource.DataSource = typeof(Shampaz.SellFactorReportData);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Items";
            reportDataSource1.Value = this.SellFactorItemBindingSource;
            reportDataSource2.Name = "Data";
            reportDataSource2.Value = this.SellFactorReportDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Shampaz.SellFactorReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(464, 372);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
            this.reportViewer1.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_PrintingBegin);
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // SellFactorPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 372);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "SellFactorPrintForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SellFactorPrintForm";
            this.Load += new System.EventHandler(this.SellFactorPrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellFactorItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellFactorReportDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource SellFactorItemBindingSource;
        private System.Windows.Forms.BindingSource SellFactorReportDataBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}