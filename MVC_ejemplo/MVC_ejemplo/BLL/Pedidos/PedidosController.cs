using DLL.Pedidos;
using DTOs;
using DTOs.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
