using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.VO;
using Northwinds_BLL;
using Utilidades;
using NorthwindsDashboard.Controles_Usuario;
using NorthwindsDashboard.Formularios;

namespace NorthwindsDashboard
{
    public partial class Form1 : Form
    {
        // Atributos
        private RankingUC ranking;
        private EvolutivoUC evolutivo;
        private TartaClientesUC tartaClientes;
        private TartaEmpleadosUC tartaEmpleados;
        private string filtroYear = "Todos";
        private string filtroCountry = "Todos";

        public Form1()
        {
            InitializeComponent();

            //Tooltips
            this.tpBotonCrystal.SetToolTip(this.bCrystal, "Genera informe con Crystal Report");
            this.tpBotonRV.SetToolTip(this.bViewer, "Genera informe con Report Viewer");
            this.tpAño.SetToolTip(this.cbYear, "Filtrar Año");
            this.tpPais.SetToolTip(this.cbPais, "Filtrar País");

            CargarFiltros();
            CargarElementosDashboard(filtroYear, filtroCountry);
            MostrarInformacion();
        }

        // Evento del combo box de años. Cuando se selecciona un año cambia el valor del atributo filtroYear
        private void cbYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Cambiamos el valor del filtro de año y volvemos a cargar los objetos con este filtro
            this.filtroYear = cbYear.SelectedValue.ToString();
            CargarElementosDashboard(this.filtroYear, this.filtroCountry);

            // Mostrar información con los filtros
            MostrarInformacion();
        }

        // Evento del combo box de años. Cuando se selecciona un año cambia el valor del atributo filtroCountry
        private void cbPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Cambiamos el valor del filtro de año y volvemos a cargar los objetos con este filtro
            this.filtroCountry = cbPais.SelectedValue.ToString();
            CargarElementosDashboard(this.filtroYear, this.filtroCountry);

            // Mostrar información con los filtros
            MostrarInformacion();
        }

        // Evento del botón que genera el informe con Crystal Reports
        private void bCrystal_Click(object sender, EventArgs e)
        {
            ReporteCrystal reporteCrystal = new ReporteCrystal();
            reporteCrystal.Show();
        }

        // Evento del botón que genera el informe con ReportViewer
        private void bViewer_Click(object sender, EventArgs e)
        {
            ReportViewer reporte = new ReportViewer();
            reporte.ShowDialog();
        }

        // Evento del popup de Información
        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Obtenemos el importe total de ventas y lo pasamos como parámetro al PopUp
            double importeTotal = BLL.ObtenerImporteTotal(this.filtroYear, this.filtroCountry);
            string importeInfo = @"Importe Total Ventas: " + Environment.NewLine + importeTotal;

            PopUp pop = new PopUp(importeInfo);
            pop.Show();

        }

        // Evento 
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Help.ShowHelp(this, "@\"..\\..\\FicherosCHM\\FicherosCHM.chm");
        }


        // MÉTODOS
        // Método que carga los comboboxes con los filtros de años y paises
        public void CargarFiltros()
        {
            // Filtro año
            List<int> years = BLL.PedirYears();
            List<string> yearsString = new List<string>();
            yearsString.Add("Todos");

            foreach (int year in years)
            {
                yearsString.Add(year.ToString());
            }

            BindingSource cbYears = new BindingSource();
            cbYears.DataSource = yearsString;
            cbYear.DataSource = cbYears;

            // Filtro paises
            BindingSource cbPaises = new BindingSource();
            cbPaises.DataSource = BLL.PedirPaises();
            cbPais.DataSource = cbPaises;

        }

        // Metodo para mostrar la información en la parte izquierda del dashboard
        public void MostrarInformacion()
        {
            // Información del mejor producto
            ProductoDTO mejorProducto = BLL.ObtenerMejorProducto(this.filtroYear, this.filtroCountry);
            string productoInfo = @"Mejor Producto: " + mejorProducto.Producto + Environment.NewLine +
                                   "Precio/Unidad: " + mejorProducto.PrecioUnidad + Environment.NewLine +
                                   "Importe: " + mejorProducto.ImporteTotal;
            tbProductoInfo.Text = productoInfo;

            // Información del mejor cliente
            ClienteDTO mejorCliente = BLL.ObtenerMejorCliente(this.filtroYear, this.filtroCountry);
            string clienteInfo = @"Mejor Cliente: " + mejorCliente.Nombre + Environment.NewLine +
                                   "País: " + mejorCliente.Pais + Environment.NewLine +
                                   "Importe: " + mejorCliente.ImporteTotal;
            tbClienteInfo.Text = clienteInfo;

            // Información del mejor empleado
            EmpleadoDTO mejorEmpleado = BLL.ObtenerMejorEmpleado(this.filtroYear, this.filtroCountry);
            string empledoInfo = @"Mejor Empleado: " + mejorEmpleado.Nombre + Environment.NewLine +
                                   "Cargo: " + mejorEmpleado.Cargo + Environment.NewLine +
                                   "Importe: " + mejorEmpleado.ImporteTotal;
            tbEmpleadoInfo.Text = empledoInfo;

            // Importe total
            double importeTotal = BLL.ObtenerImporteTotal(this.filtroYear, this.filtroCountry);
            string importeInfo = @"Importe Total: " + Environment.NewLine + importeTotal;
            tbFacturacionInfo.Text = importeInfo;
        }


        // Método que carga todos los gráficos
        public void CargarElementosDashboard(string year, string country)
        {
            // Eliminar gráficos
            tlpGraficosBase.Controls.Remove(ranking);
            tlfGraficosIzq.Controls.Remove(evolutivo);
            tlpTartas.Controls.Remove(tartaClientes);
            tlpTartas.Controls.Remove(tartaEmpleados);

            // Gestión de filtros. Cargar los elementos del Dashboard en función de los filtros que estén seleccionados
            CargarGraficos(year, country);

            // Cargar elementos
            tlpGraficosBase.Controls.Add(ranking,1,0);           
            tlfGraficosIzq.Controls.Add(evolutivo,0,1);
            tlpTartas.Controls.Add(tartaClientes,0,0);
            tlpTartas.Controls.Add(tartaEmpleados,1,0);
        }

        // Llamada a los métodos de los controles de usuarios para cargar los gráficos con los datos correspondientes.
        public void CargarGraficos(string year, string country)
        {
            ranking = new RankingUC();
            ranking.CargarElementosRanking(year, country);

            tartaClientes = new TartaClientesUC();
            tartaClientes.CargarElementosTartaClientes(year, country);

            tartaEmpleados = new TartaEmpleadosUC();
            tartaEmpleados.CargarElementosTartaEmpleados(year, country);

            evolutivo = new EvolutivoUC();
            evolutivo.CargarElementosEvolutivo(year, country);
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tlpFiltros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void tlpInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
