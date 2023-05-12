namespace NorthwindsDashboard.Controles_Usuario
{
    partial class TartaClientesUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTartaClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTartaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTartaClientes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTartaClientes.ChartAreas.Add(chartArea1);
            this.chartTartaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTartaClientes.Location = new System.Drawing.Point(0, 0);
            this.chartTartaClientes.Name = "chartTartaClientes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Label = "#PERCENT{P}#VALX";
            series1.LegendText = "#SERIESNAME";
            series1.Name = "Series1";
            this.chartTartaClientes.Series.Add(series1);
            this.chartTartaClientes.Size = new System.Drawing.Size(672, 634);
            this.chartTartaClientes.TabIndex = 0;
            this.chartTartaClientes.Text = "chart1";
            this.chartTartaClientes.Click += new System.EventHandler(this.chartTartaClientes_Click);
            // 
            // TartaClientesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartTartaClientes);
            this.Name = "TartaClientesUC";
            this.Size = new System.Drawing.Size(672, 634);
            ((System.ComponentModel.ISupportInitialize)(this.chartTartaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTartaClientes;
    }
}
