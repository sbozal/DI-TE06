using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Pedidos;
using DLL.Productos;
using DTOs.Pedidos;
using DTOs.Productos;

namespace BLL.Productos
{
    public class ProductosController
    {
        public ProductosController() { }

        public List<ProductoDTO> getProductosCategoria(string idCategoria)
        {
            ProductosDLL productosDLL = new ProductosDLL();
            List<ProductoDTO> listaProductos = productosDLL.getProductosCategoria(idCategoria);
            return listaProductos;
        }

        public List<ProductoDTO> getProductos()
        {
            ProductosDLL productosDLL = new ProductosDLL();
            List<ProductoDTO> listaProductos = productosDLL.getProductos();
            return listaProductos;
        }

    }
}

/*
 namespace BLL.Pedidos
{
    public class PedidosController
    {
        public PedidosController() { }

        public List<PedidosDTO> getPedidosDelCliente(string idCliente)
        {
            PedidosDLL pedidosDLL = new PedidosDLL();
            List<PedidosDTO> listaPedidosDTO = pedidosDLL.getPedidosDelCliente(idCliente);
            return listaPedidosDTO;
        }

        public List<PedidosDTO> getPedidos()
        {
            PedidosDLL pedidosDLL = new PedidosDLL();
            List<PedidosDTO> listaPedidosDTO = pedidosDLL.getPedidos();
            return listaPedidosDTO;
        }
    }
}
 */
