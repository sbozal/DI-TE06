using BLL;
using DTOs;
using DTOs.Pedidos;
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
        private BienvenidaUC msgBienvenida;
        private SelectID selectID;
        private TableUC tabla;
        private FiltroUC filtro;

        private List<PedidosDTO> pedidos;

        public Dashboard()
        {
            InitializeComponent();

            CargarElementosDashboard();
        }



        /* MÉTODOS */
        // Cargar controles de usuario de bienvenida y selector de cliente al inicio
        public void CargarElementosDashboard()
        {
            // Borrar elementos
            panel_Datos.Controls.Remove(msgBienvenida);
            tlpSelect.Controls.Remove(selectID);

            // Cargar elementos
            msgBienvenida = new BienvenidaUC();
            panel_Datos.Controls.Add(msgBienvenida);

            selectID = new SelectID();
            tlpSelect.Controls.Add(selectID);

            selectID.Busqueda += SelectID_Busqueda;
        }

        private void SelectID_Busqueda(object sender, List<PedidosDTO> listaPedidos)
        {
            pedidos = new List<PedidosDTO>(listaPedidos);

            //throw new NotImplementedException();
            panel_Datos.Controls.Remove(msgBienvenida);
            panel_Datos.Controls.Remove(tabla);
            panel_ParteArriba.Controls.Remove(filtro);

            tabla  = new TableUC(pedidos);
            panel_Datos.Controls.Add(tabla);

            filtro = new FiltroUC(pedidos);
            panel_ParteArriba.Controls.Add(filtro);

            filtro.Empleado += Filtro_Empleado;
        }

        private void Filtro_Empleado(object sender, string empleadoID)
        {
            // throw new NotImplementedException();
            panel_Datos.Controls.Remove(tabla);

            //tabla.Filtrar(empleadoID);

            //panel_Datos.Controls.Add(tabla);

            List<PedidosDTO> listaFiltrada = new List<PedidosDTO>();
            foreach (PedidosDTO pedido in pedidos)
            {
                if (pedido.EmployeeId.ToString() == empleadoID)
                {
                    listaFiltrada.Add(pedido);
                }
            }
            tabla = new TableUC(listaFiltrada);
            panel_Datos.Controls.Add(tabla);

        }

        /***********************************************************************************
        Reporte Crystal:
        1. Crear formulario
        2. Añadir elemenot crystalreportviewer
        3. Evento botón --> Reporte rpt = new Reporte();
                            rpt.Show();
        4. En la flecha del elemento --> crear nuevo informe de Crystal para crear el .rpt
        5. Wizard. Reporte standard y conexión a la bbdd. Crear nueva conexión oledb (localhost, user, pwd, bbdd)
        6. Dar formato al informe en el .rpt
        ***********************************************************************************/

        /***********************************************************************************
        Tooltip:
        1. Añadir elemento tooltip
        2. Form: en el constructor --> this.ttMensaje.SetToolTip(this.tbEscribir, "Tooltip que se ve en tbEscribir")
        ***********************************************************************************/

        /***********************************************************************************
        PopUp + HelpProvider
        1. PopUp pop = new PopUp(texto que quieres mostrar);
           pop.Show();
        2. Botón popUp --> this.close();
        3. Arrastrar helpprovider
        4. Deshabilitar minimizar y maximizar (help buttom true y min y max false)
        5. En cada elemento añadir lo que queremos que muestre en HelpString
        ***********************************************************************************/

    }
}
