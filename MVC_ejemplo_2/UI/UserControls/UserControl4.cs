using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs.Clientes;

namespace UI.UserControls
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4(List<ClienteDTO> listaClientes)
        {
            InitializeComponent();

            // Estructura para guardar datos
            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();

            // Insertar datos
            for (int i = 0; i < listaClientes.Count; i++)
            {
                x1.Add(listaClientes[i].CompanyName);
                y1.Add(listaClientes[i].Importe);
            }

            // Añadir datos al gráfico
            chart1.Series[0].Points.DataBindXY(x1, y1);
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
