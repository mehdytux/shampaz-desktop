namespace Shampaz
{
    partial class SellFactorKitchenReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SellFactorReportDataSet = new Shampaz.SellFactorReportDataSet();
            this.FactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SellFactorReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Shampaz.SellFactorKitchenReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(381, 414);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_PrintingBegin);
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // SellFactorReportDataSet
            // 
            this.SellFactorReportDataSet.DataSetName = "SellFactorReportDataSet";
            this.SellFactorReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FactorBindingSource
            // 
            this.FactorBindingSource.DataMember = "Factor";
            this.FactorBindingSource.DataSource = this.SellFactorReportDataSet;
            // 
            // SellFactorKitchenReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 414);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "SellFactorKitchenReportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "رسید آشپزخانه";
            this.Load += new System.EventHandler(this.SellFactorKitchenReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellFactorReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FactorBindingSource;
        private SellFactorReportDataSet SellFactorReportDataSet;
    }
}