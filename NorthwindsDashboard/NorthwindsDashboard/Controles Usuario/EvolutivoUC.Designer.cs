namespace NorthwindsDashboard.Controles_Usuario
{
    partial class EvolutivoUC
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
            this.chartEvolutivo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolutivo)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEvolutivo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEvolutivo.ChartAreas.Add(chartArea1);
            this.chartEvolutivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEvolutivo.Location = new System.Drawing.Point(0, 0);
            this.chartEvolutivo.Name = "chartEvolutivo";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(99)))), ((int)(((byte)(140)))));
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chartEvolutivo.Series.Add(series1);
            this.chartEvolutivo.Size = new System.Drawing.Size(807, 567);
            this.chartEvolutivo.TabIndex = 0;
            this.chartEvolutivo.Text = "chart1";
            this.chartEvolutivo.Click += new System.EventHandler(this.charEvolutivo_Click);
            // 
            // EvolutivoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartEvolutivo);
            this.Name = "EvolutivoUC";
            this.Size = new System.Drawing.Size(807, 567);
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolutivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvolutivo;
    }
}
