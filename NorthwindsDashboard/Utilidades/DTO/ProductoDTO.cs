using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class ProductoDTO
    {
        // Atributos
        private int idProducto;
        private string producto;
        private double precioUnidad;
        private double importeTotal;

        // Constructor
        public ProductoDTO(ProductoVO producto)
        {
            this.IdProducto = producto.IdProducto;
            this.Producto = producto.Producto;
            this.PrecioUnidad = producto.PrecioUnidad;
            this.ImporteTotal = producto.ImporteTotal;
        }

        // Get y Set
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Producto { get => producto; set => producto = value; }
        public double PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }

    }
}
