using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class EmpleadoDTO
    {
        // Atributos
        private string nombre;
        private string cargo;
        private double importeTotal;


        // Constructor
        public EmpleadoDTO(EmpleadoVO empleado)
        {
            this.nombre = empleado.Nombre;
            this.cargo = empleado.Cargo;
            this.importeTotal = empleado.ImporteTotal;
        }

        // Get y Set
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }

    }
}
