using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Empleados
{
    public class EmpleadoDTO
    {
        private int id;
        private string nombreCompleto;
        private string puesto;
        private string pais;
        private double importeVentas;

        public EmpleadoDTO() { }

        public EmpleadoDTO(int id, string nombreCompleto, string puesto, string pais, double importeVentas)
        {
            this.id = id;
            this.nombreCompleto = nombreCompleto;
            this.puesto = puesto;
            this.pais = pais;
            this.importeVentas = importeVentas;
        }

        public int Id { get => id; set => id = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Pais { get => pais; set => pais = value; }
        public double ImporteVentas { get => importeVentas; set => importeVentas = value; }
    }
}
