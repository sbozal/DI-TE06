using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Pedidos;
using DTOs.Pedidos;

namespace UI.UserControls
{
    public partial class SelectID : UserControl
    {
        public SelectID()
        {
            InitializeComponent();
        }

        public event EventHandler<List<PedidosDTO>> Busqueda;

        // Evento botón buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string clienteID = tbID.Text;
            PedidosController pedidosController = new PedidosController();
            List<PedidosDTO> listaPedidos = pedidosController.getPedidosDelCliente(clienteID);


            Busqueda.Invoke(this, listaPedidos);
        }
    }
}
