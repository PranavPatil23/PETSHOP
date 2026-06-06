namespace PETSHOP
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newDataSet = new PETSHOP.NewDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.newDataSet;
            // 
            // newDataSet
            // 
            this.newDataSet.DataSetName = "NewDataSet";
            this.newDataSet.Locale = new System.Globalization.CultureInfo("");
            this.newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.newDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OrderDetails";
            reportDataSource1.Value = this.orderDetailsBindingSource;
            reportDataSource2.Name = "Orders";
            reportDataSource2.Value = this.ordersBindingSource;
            reportDataSource3.Name = "Vendors";
            reportDataSource3.Value = this.vendorsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PETSHOP.Report.rptVendors.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1022, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 562);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private NewDataSet newDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        // private System.Windows.Forms.BindingSource ProductBindingSource;

    }
}