﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class PedidoVO
    {

        // Atributos

        private int idProducto;
        private string idCliente;
        private int idEmpleado;
        private double importe;
        private int mes;
        private string nombreProducto;
        private string nombreCliente;
        private string nombreEmpleado;


        // Constructor
        public PedidoVO()
        {
            this.IdProducto = 0;
            this.IdCliente = "";
            this.IdEmpleado = 0;
            this.Importe = 0;
            this.Mes = 0;
            this.nombreProducto = "";
            this.nombreCliente = "";
            this.nombreEmpleado = "";
        }

        // Get y Set
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public double Importe { get => importe; set => importe = value; }
        public int Mes { get => mes; set => mes = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }

    }
}

