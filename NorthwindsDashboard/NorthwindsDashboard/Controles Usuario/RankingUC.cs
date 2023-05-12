using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Northwinds_BLL;
using Utilidades.VO;

namespace NorthwindsDashboard.Controles_Usuario
{
    public partial class RankingUC : UserControl
    {
        public RankingUC()
        {
            InitializeComponent();
        }

        // Cargar datos en el gráfico Ranking
        public void CargarElementosRanking( string year, string country)
        {
            // Lista de pedidos que se mostrarán en el gráfico
            List<PedidoDTO> pedidos = BLL.PedirDatosRanking(year, country);

            // Estructura para guardar datos
            List<double> x1 = new List<double>();
            List<string> y1 = new List<string>();

            // Insertar datos en las listas x1 y1
            for(int i = 0; i < pedidos.Count; i++)
            {
                x1.Add(pedidos[i].Importe);
                y1.Add(pedidos[i].NombreProducto);
            }

            // Añadir datos al gráfico
            chartRanking.Series["Series1"].Points.DataBindXY(y1.ToArray(), x1.ToArray());

            // Ejes
            chartRanking.ChartAreas[0].AxisX.Title = "Productos";
            chartRanking.ChartAreas[0].AxisY.Title = "Importe Pedidos";

            // Título
            Title title = new Title();
            title.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            title.Text = "Ranking de Productos por Importe (TOP 10)";
            chartRanking.Titles.Add(title);
        }





        private void charRanking_Click(object sender, EventArgs e)
        {

        }
    }
}
