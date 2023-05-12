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
    public partial class TartaEmpleadosUC : UserControl
    {
        public TartaEmpleadosUC()
        {
            InitializeComponent();
        }

        // Añadir datos al gráfico de tarta de empleados
        public void CargarElementosTartaEmpleados(string year, string country)
        {
            // Lista de pedidos que se mostrarán en el gráfico. 
            List<PedidoDTO> pedidos = BLL.PedirDatosTartaEmpleados(year, country);

            // Estructura para guardar datos
            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();

            // Insertar datos en las listas x1 y1
            for (int i = 0; i < pedidos.Count; i++)
            {
                x1.Add(pedidos[i].NombreEmpleado);
                y1.Add(pedidos[i].Importe);
            }

            // Añadir datos al gráfico
            chartTartaEmpleados.Series[0].Points.DataBindXY(x1, y1);

            // Título
            Title title = new Title();
            title.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            title.Text = "% Top 10 Empleados";
            chartTartaEmpleados.Titles.Add(title);

        }

        private void chartTartaEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
