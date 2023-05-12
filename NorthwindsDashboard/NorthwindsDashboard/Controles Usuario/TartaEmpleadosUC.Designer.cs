namespace NorthwindsDashboard.Controles_Usuario
{
    partial class TartaEmpleadosUC
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
            this.chartTartaEmpleados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTartaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTartaEmpleados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTartaEmpleados.ChartAreas.Add(chartArea1);
            this.chartTartaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTartaEmpleados.Location = new System.Drawing.Point(0, 0);
            this.chartTartaEmpleados.Name = "chartTartaEmpleados";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Label = "#PERCENT{P}#VALX";
            series1.Name = "Series1";
            this.chartTartaEmpleados.Series.Add(series1);
            this.chartTartaEmpleados.Size = new System.Drawing.Size(699, 473);
            this.chartTartaEmpleados.TabIndex = 0;
            this.chartTartaEmpleados.Text = "chart1";
            this.chartTartaEmpleados.Click += new System.EventHandler(this.chartTartaEmpleados_Click);
            // 
            // TartaEmpleadosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartTartaEmpleados);
            this.Name = "TartaEmpleadosUC";
            this.Size = new System.Drawing.Size(699, 473);
            ((System.ComponentModel.ISupportInitialize)(this.chartTartaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTartaEmpleados;
    }
}
