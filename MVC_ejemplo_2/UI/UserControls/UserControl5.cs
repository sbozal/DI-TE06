using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs.Empleados;

namespace UI.UserControls
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5(List<EmpleadoDTO> listaEmpleados)
        {
            InitializeComponent();

            List<double> x1 = new List<double>();
            List<string> y1 = new List<string>();

            for(int i = 0; i < listaEmpleados.Count; i++)
            {
                x1.Add(listaEmpleados[i].ImporteVentas);
                y1.Add(listaEmpleados[i].NombreCompleto);
            }


            chart1.Series[0].Points.DataBindXY(y1.ToArray(), x1.ToArray());
        }
    }
}
