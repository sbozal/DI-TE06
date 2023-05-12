namespace NorthwindsDashboard.Formularios
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
            this.employeeSalesByCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventas = new NorthwindsDashboard.Ventas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.employee_Sales_by_CountryTableAdapter = new NorthwindsDashboard.VentasTableAdapters.Employee_Sales_by_CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalesByCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeSalesByCountryBindingSource
            // 
            this.employeeSalesByCountryBindingSource.DataMember = "Employee Sales by Country";
            this.employeeSalesByCountryBindingSource.DataSource = this.ventas;
            // 
            // ventas
            // 
            this.ventas.DataSetName = "Ventas";
            this.ventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosVentas";
            reportDataSource1.Value = this.employeeSalesByCountryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NorthwindsDashboard.Formularios.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(997, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // employee_Sales_by_CountryTableAdapter
            // 
            this.employee_Sales_by_CountryTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 552);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportViewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalesByCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource employeeSalesByCountryBindingSource;
        private Ventas ventas;
        private VentasTableAdapters.Employee_Sales_by_CountryTableAdapter employee_Sales_by_CountryTableAdapter;
    }
}