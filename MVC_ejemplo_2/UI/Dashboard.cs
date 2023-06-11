using BLL;
using BLL.Clientes;
using BLL.Empleados;
using BLL.Productos;
using DTOs;
using DTOs.Clientes;
using DTOs.Empleados;
using DTOs.Pedidos;
using DTOs.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UserControls;

namespace UI
{
    public partial class Dashboard : Form
    {
        /***** ATRIBUTOS *****/

        private BienvenidaUC bienvenida;
        private UserControl1 filtro;
        private UserControl2 botones;
        private UserControl3 datos;
        private UserControl4 tarta;
        private UserControl5 ranking;

        private List<PedidosDTO> pedidos;

        /***** INICIO *****/
        public Dashboard()
        {
            InitializeComponent();
            cargarElementos();
        }

        /***** MÉTODOS *****/

        private void cargarElementos()
        {
            // Inicializar
            botones = new UserControl2();
            bienvenida = new BienvenidaUC();

            // Ajustar tamaño
            botones.Dock = DockStyle.Fill;
            bienvenida.Dock = DockStyle.Fill;

            // Cargar controles de usuario
            tableLayoutPanel1.Controls.Add(botones);
            panel_Datos.Controls.Add(bienvenida);

            // Click en botones del control de usuario 2
            botones.Pedidos += botones_pedidos;
            botones.Productos += botones_productos;
            botones.Clientes += botones_clientes;
            botones.Empleados += botones_empleados;
        }

        /********************* PEDIDOS ***************************/

        private void botones_pedidos(object sender, List<PedidosDTO> listaPedidos)
        {
            pedidos = new List<PedidosDTO>(listaPedidos);

            // Eliminar controles de usuario
            panel_Datos.Controls.Remove(bienvenida);
            panel_Datos.Controls.Remove(datos);
            panel_Datos.Controls.Remove(tarta);
            panel_Datos.Controls.Remove(ranking);
            panel_ParteArriba.Controls.Remove(filtro);

            // Inicializar controles de usuario
            datos = new UserControl3(pedidos);
            filtro = new UserControl1(pedidos);

            // Formato
            datos.Dock = DockStyle.Fill;

            // Cargar controles de usuario
            panel_Datos.Controls.Add(datos);
            panel_ParteArriba.Controls.Add(filtro);


            // Filtrar un empleado
            filtro.Seleccion += filtro_empleado;

        }

        private void filtro_empleado(object sender, string id)
        {
            // Borrar elementos
            panel_Datos.Controls.Remove(datos);

            List<PedidosDTO> listaFiltrada = new List<PedidosDTO>();

            foreach (PedidosDTO pedido in pedidos)
            {
                if (pedido.EmployeeId.ToString() == id)
                {
                    listaFiltrada.Add(pedido);
                }
            }
            datos = new UserControl3(listaFiltrada);
            panel_Datos.Controls.Add(datos);

        }

        /********************* PRODUCTOS ***************************/

        private void botones_productos(object sender, List<ProductoDTO> listaProductos)
        {
            // Eliminar controles de usuario
            panel_Datos.Controls.Remove(bienvenida);
            panel_Datos.Controls.Remove(datos);
            panel_Datos.Controls.Remove(tarta);
            panel_Datos.Controls.Remove(ranking);
            panel_ParteArriba.Controls.Remove(filtro);

            // Inicializar controles de usuario
            datos = new UserControl3(listaProductos);
            filtro = new UserControl1(listaProductos);

            // Formato
            datos.Dock = DockStyle.Fill;

            // Añadir controles de usuario
            panel_Datos.Controls.Add(datos);
            panel_ParteArriba.Controls.Add(filtro);

            // Filtrar una categoría de producto
            filtro.Seleccion += filtro_categoria;
        }

        private void filtro_categoria(object sender, string id)
        {
            // Borrar elementos
            panel_Datos.Controls.Remove(datos);

            ProductosController productosController = new ProductosController();
            List<ProductoDTO> productosFiltrados = productosController.getProductosCategoria(id);

            datos = new UserControl3(productosFiltrados);
            panel_Datos.Controls.Add(datos);
        }

        /********************* CLIENTES ***************************/
        private void botones_clientes(object sender, List<ClienteDTO> listaClientes)
        {
            // Eliminar elementos
            panel_Datos.Controls.Remove(bienvenida);
            panel_Datos.Controls.Remove(datos);
            panel_Datos.Controls.Remove(tarta);
            panel_Datos.Controls.Remove(ranking);
            panel_ParteArriba.Controls.Remove(filtro);

            // Inicializamos controles de usuario
            filtro = new UserControl1(listaClientes);
            tarta = new UserControl4(listaClientes);

            // Formato
            tarta.Dock = DockStyle.Fill;

            // Añadimos controles de usuario
            panel_Datos.Controls.Add(tarta);
            panel_ParteArriba.Controls.Add(filtro);

            // Filtro por pais
            filtro.Seleccion += filtro_pais;
        }

        public void filtro_pais(Object sender, string id)
        {
            // Eliminar elemento
            panel_Datos.Controls.Remove(tarta);

            ClientesController clientesController = new ClientesController();
            List<ClienteDTO> clientes = clientesController.getClientesPais(id);

            // Inicializar elemento
            tarta = new UserControl4(clientes);

            // Añadir elemento
            panel_Datos.Controls.Add(tarta);

        }



        /********************* EMPLEADOS ***************************/
        private void botones_empleados(object sender, List<EmpleadoDTO> listaEmpleados)
        {
            // Eliminar elementos
            panel_Datos.Controls.Remove(bienvenida);
            panel_Datos.Controls.Remove(datos);
            panel_Datos.Controls.Remove(tarta);
            panel_Datos.Controls.Remove(ranking);
            panel_ParteArriba.Controls.Remove(filtro);

            // Inicializar
            filtro = new UserControl1(listaEmpleados);
            ranking = new UserControl5(listaEmpleados);

            // Añadir los controles de usuario
            panel_Datos.Controls.Add(ranking);
            panel_ParteArriba.Controls.Add(filtro);

            // Filtrar por puesto
            filtro.Seleccion += filtro_puesto;
        }

        public void filtro_puesto(Object sender, string puesto)
        {
            // Eliminar elemento
            panel_Datos.Controls.Remove(ranking);

            // Obtener lista empleados con filtro
            EmpleadosController empleadosController = new EmpleadosController();
            List<EmpleadoDTO> listaEmpleados = empleadosController.getEmpleadosPuesto(puesto);

            // Inicializar elemento
            ranking = new UserControl5(listaEmpleados);

            // Añadir elemento al dashboard
            panel_Datos.Controls.Add(ranking);
        }
    }
}
