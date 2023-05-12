using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class ClienteVO
    {
        // Atributos
        private string idCliente;
        private string nombre;
        private string pais;
        private double importeTotal;

        // Constructor
        public ClienteVO()
        {
            this.idCliente = "";
            this.nombre = "";
            this.pais = "";
            this.importeTotal = 0;
        }

        // Get y Set
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }
    }
}
