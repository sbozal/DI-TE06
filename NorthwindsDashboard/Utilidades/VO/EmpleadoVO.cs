using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class EmpleadoVO
    {
        // Atributos
        private string nombre;
        private string cargo;
        private double importeTotal;


        // Constructor
        public EmpleadoVO()
        {
            this.nombre = "";
            this.cargo = "";
            this.importeTotal = 0;
        }

        // Get y Set
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }

    }
}
