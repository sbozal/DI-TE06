using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs.Pedidos;

namespace UI.UserControls
{
    public partial class FiltroUC : UserControl
    {
        public FiltroUC(List<PedidosDTO> listaPedidos)
        {
            InitializeComponent();
            List<int> listaEmpleados = new List<int>();

            foreach (PedidosDTO pedido in listaPedidos)
            {
                int empleadoID = pedido.EmployeeId;
                
                if(!listaEmpleados.Contains(empleadoID))
                {
                    listaEmpleados.Add(empleadoID);
                }
            }

            listaEmpleados.Sort();

            BindingSource filtro = new BindingSource();
            filtro.DataSource = listaEmpleados;
            cbFiltro.DataSource = filtro;

        }

        public event EventHandler<string> Empleado;

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string idString = cbFiltro.SelectedItem.ToString();
            Empleado.Invoke(this, idString);
        }

        /*
          public event EventHandler<List<PedidosDTO>> Busqueda;

        // Evento botón buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string clienteID = tbID.Text;
            PedidosController pedidosController = new PedidosController();
            List<PedidosDTO> listaPedidos = pedidosController.getPedidosDelCliente(clienteID);


            Busqueda.Invoke(this, listaPedidos);
        }
         
         */
    }
}
