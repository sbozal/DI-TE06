using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs.Clientes;
using DTOs.Empleados;
using DTOs.Pedidos;
using DTOs.Productos;

namespace UI.UserControls
{
    public partial class UserControl1 : UserControl
    {
        /************ PEDIDOS ****************/
        public UserControl1(List<PedidosDTO> listaPedidos)
        {
            InitializeComponent();

            List<int> listaEmpleados = new List<int>();

            foreach (PedidosDTO pedido in listaPedidos)
            {
                int empleadoID = pedido.EmployeeId;

                if (!listaEmpleados.Contains(empleadoID))
                {
                    listaEmpleados.Add(empleadoID);
                }

            }

            listaEmpleados.Sort();

            BindingSource selector = new BindingSource();
            selector.DataSource = listaEmpleados;
            cbSeleccion.DataSource = selector;

            textBox1.Text = "Filtre un empleado";
        }

        /************ PRODUCTOS ****************/
        public UserControl1(List<ProductoDTO> listaProductos)
        {
            InitializeComponent();

            List<int> categorias = new List<int>();

            foreach (ProductoDTO producto in listaProductos)
            {
                int categoriaID = producto.CategoryID;

                if (!categorias.Contains(categoriaID))
                {
                    categorias.Add(categoriaID);
                }
            }

            categorias.Sort();

            BindingSource selector = new BindingSource();
            selector.DataSource = categorias;
            cbSeleccion.DataSource = selector;

            textBox1.Text = "Filtre una categoría";
        }

        

        /************ CLIENTES ****************/
        public UserControl1(List<ClienteDTO> listaClientes)
        {
            InitializeComponent();

            List<string> paises = new List<string>();

            foreach (ClienteDTO cliente in listaClientes)
            {
                string pais = cliente.Country;

                if (!paises.Contains(pais))
                {
                    paises.Add(pais);
                }
            }

            paises.Sort();

            BindingSource selector = new BindingSource();
            selector.DataSource = paises;
            cbSeleccion.DataSource = selector;

            textBox1.Text = "Filtre un país";
        }


        /************ EMPLEADOS ****************/
        public UserControl1(List<EmpleadoDTO> listaEmpleados)
        {
            InitializeComponent ();

            List <string> puestos = new List<string>();

            foreach (EmpleadoDTO empleado in listaEmpleados)
            {
                string puesto = empleado.Puesto;

                if(!puestos.Contains(puesto))
                {
                    puestos.Add(puesto);
                }
            }
            puestos.Sort();

            BindingSource selector = new BindingSource();
            selector.DataSource = puestos;
            cbSeleccion.DataSource = selector;

            textBox1.Text = "Filtre un puesto";
        }



        /************ EVENTO BOTÓN ****************/
        public event EventHandler<string> Seleccion;

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            string select = cbSeleccion.SelectedItem.ToString();
            Seleccion.Invoke(this, select);
        }
    }
}
