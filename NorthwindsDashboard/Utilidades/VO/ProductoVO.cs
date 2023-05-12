using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class ProductoVO
    {
        // Atributos
        private int idProducto;
        private string producto;
        private double precioUnidad;
        private double importeTotal;

        // Constructor
        public ProductoVO()
        {
            this.IdProducto = 0;
            this.Producto = "";
            this.PrecioUnidad = 0;
            this.ImporteTotal = 0;
        }

        // Get y Set

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Producto { get => producto; set => producto = value; }
        public double PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }

    }
}
