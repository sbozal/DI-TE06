using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Clientes;
using BLL.Empleados;
using BLL.Pedidos;
using BLL.Productos;
using DTOs.Clientes;
using DTOs.Empleados;
using DTOs.Pedidos;
using DTOs.Productos;

namespace UI.UserControls
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public event EventHandler<List<PedidosDTO>> Pedidos;

        private void button1_Click(object sender, EventArgs e)
        {
            PedidosController pedidosController = new PedidosController();
            List<PedidosDTO> listaPedidos = pedidosController.getPedidos();

            Pedidos.Invoke(this, listaPedidos);
        }

        public event EventHandler<List<ProductoDTO>> Productos;

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosController productosController = new ProductosController();
            List<ProductoDTO> listaProductos = productosController.getProductos();

            Productos.Invoke(this, listaProductos);
        }

        public event EventHandler<List<ClienteDTO>> Clientes;

        private void button3_Click(object sender, EventArgs e)
        {
            ClientesController clientesController = new ClientesController();
            List<ClienteDTO> listaClientes = clientesController.getClientes();

            Clientes.Invoke(this, listaClientes);
        }

        public event EventHandler<List<EmpleadoDTO>> Empleados;

        private void button4_Click(object sender, EventArgs e)
        {
            EmpleadosController empleadosController = new EmpleadosController();
            List<EmpleadoDTO> listaEmpleados = empleadosController.getEmpleados();

            Empleados.Invoke(this, listaEmpleados);
        }
    }
}
