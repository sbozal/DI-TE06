using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwinds_BLL;
using System.Windows.Forms.DataVisualization.Charting;
using Utilidades.VO;

namespace NorthwindsDashboard.Controles_Usuario
{
    public partial class EvolutivoUC : UserControl
    {
        public EvolutivoUC()
        {
            InitializeComponent();
        }

        // Cargar datos en el gráfico Evolutivo
        public void CargarElementosEvolutivo(string year, string country)
        {
            // Lista de pedidos que se mostrarán en el gráfico
            List<PedidoDTO> pedidos = BLL.PedirDatosEvolutivo(year, country);

            // Estructura para guardar datos
            List<int> x1 = new List<int>();
            List<double> y1 = new List<double>();

            // Insertar datos en las listas x1 y1

            for (int i = 0; i < pedidos.Count; i++)
            {
                x1.Add(pedidos[i].Mes);
                y1.Add(pedidos[i].Importe);
            }

            // Añadir datos al gráfico
            chartEvolutivo.Series[0].Points.DataBindXY(x1.ToArray(), y1.ToArray());

            // Título
            Title title = new Title();
            title.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            title.Text = "Evolución Importe por Meses";
            chartEvolutivo.Titles.Add(title);
        }

        private void charEvolutivo_Click(object sender, EventArgs e)
        {

        }
    }
}
