namespace NorthwindsDashboard.Controles_Usuario
{
    partial class RankingUC
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartRanking = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRanking
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.LabelStyle.Angle = -30;
            chartArea1.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Angle = -30;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartRanking.ChartAreas.Add(chartArea1);
            this.chartRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRanking.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chartRanking.Location = new System.Drawing.Point(0, 0);
            this.chartRanking.Name = "chartRanking";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(99)))), ((int)(((byte)(140)))));
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.chartRanking.Series.Add(series1);
            this.chartRanking.Size = new System.Drawing.Size(666, 624);
            this.chartRanking.TabIndex = 0;
            this.chartRanking.Text = "chart1";
            title1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Ranking de Productos por Importe";
            this.chartRanking.Titles.Add(title1);
            this.chartRanking.Click += new System.EventHandler(this.charRanking_Click);
            // 
            // RankingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartRanking);
            this.Name = "RankingUC";
            this.Size = new System.Drawing.Size(666, 624);
            ((System.ComponentModel.ISupportInitialize)(this.chartRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRanking;
    }
}
