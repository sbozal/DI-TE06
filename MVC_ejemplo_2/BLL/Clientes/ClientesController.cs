using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Clientes;
using DTOs.Clientes;

namespace BLL.Clientes
{
    public class ClientesController
    {
        public ClientesController() { }

        public List<ClienteDTO> getClientesPais(string pais)
        {
            ClientesDLL clientesDLL = new ClientesDLL();
            List<ClienteDTO> clientes = clientesDLL.getClientesPais(pais);
            return clientes;
        }

        public List<ClienteDTO> getClientes()
        {
            ClientesDLL clientesDLL = new ClientesDLL();
            List<ClienteDTO> clientes = clientesDLL.getClientes();
            return clientes;
        }
    }
}
