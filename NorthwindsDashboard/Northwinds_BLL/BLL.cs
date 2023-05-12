using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.VO;
using Northwinds_DAL;
using Utilidades;

namespace Northwinds_BLL
{
    public class BLL
    {
        // Pedir datos de años a la base de datos. Devuelve una lista de con los años de la base de datos
        public static List<int> PedirYears()
        {
            List<int> years = ConsultaBD.RealizarConsultaYears();
            return years;
        }

        // Pedir datos de paises a la base de datos. Devuelve una lista con los paises de la base de datos
        public static List<string> PedirPaises()
        {
            List<string> paises = ConsultaBD.RealizarConsultaPaises();
            return paises;
        }

        #region Gráfico Ranking
        // Pedir datos de pedidos a la base de datos. Devulve la lista de PedidoVO necesarios para la generación del gráfico de ranking de productos
        public static List<PedidoDTO> PedirDatosRanking(string year, string pais)
        {
            List<PedidoVO> pedidosRankingVO = ConsultaBD.ConsultaRankingProductos(year, pais);
            List<PedidoDTO> pedidosRanking = new List<PedidoDTO>();

            // Convertir VO en DTO
            foreach (var pedidoVO in pedidosRankingVO)
            {
                PedidoDTO pedido = new PedidoDTO(pedidoVO);
                pedidosRanking.Add(pedido);
            }

            return pedidosRanking;
        }

        #endregion

        #region Gráficos Tarta
        // Pedir datos de pedidos a la base de datos. Devulve la lista de PedidoVO necesarios para la generación del gráfico de tarta con los mejores clientes
        public static List<PedidoDTO> PedirDatosTartaClientes(string year, string pais)
        {
            List<PedidoVO> pedidosTartaClientesVO = ConsultaBD.ConsultaTartaClientes(year, pais);
            List<PedidoDTO> pedidosTartaClientes = new List<PedidoDTO>();

            // Convertir VO en DTO
            foreach (var pedidoVO in pedidosTartaClientesVO)
            {
                PedidoDTO pedido = new PedidoDTO(pedidoVO);
                pedidosTartaClientes.Add(pedido);
            }

            return pedidosTartaClientes;
        }

        // Pedir datos de pedidos a la base de datos. Devulve la lista de PedidoVO necesarios para la generación del gráfico de tarta con los mejores empleados
        public static List<PedidoDTO> PedirDatosTartaEmpleados(string year, string pais)
        {
            List<PedidoVO> pedidosTartaEmpleadosVO = ConsultaBD.ConsultaTartaEmpleados(year, pais);
            List<PedidoDTO> pedidosTartaEmpleados = new List<PedidoDTO>();

            // Convertir VO en DTO
            foreach (var pedidoVO in pedidosTartaEmpleadosVO)
            {
                PedidoDTO pedido = new PedidoDTO(pedidoVO);
                pedidosTartaEmpleados.Add(pedido);
            }
            return pedidosTartaEmpleados;
        }
        #endregion

        #region Gráfico Evolutivo
        // Pedir datos de pedidos a la base de datos. Devulve la lista de PedidoVO necesarios para la generación del gráfico evolutivo por meses
        public static List<PedidoDTO> PedirDatosEvolutivo(string year, string pais)
        {
            List<PedidoVO> pedidosEvolutivoVO = ConsultaBD.ConsultaEvolutivo(year, pais);
            List<PedidoDTO> pedidosEvolutivo = new List<PedidoDTO>();

            // Convertir VO en DTO
            foreach (var pedidoVO in pedidosEvolutivoVO)
            {
                PedidoDTO pedido = new PedidoDTO(pedidoVO);
                pedidosEvolutivo.Add(pedido);
            }

            return pedidosEvolutivo;
        }
        #endregion

        #region Información
        // Pedir datos del mejor producto a la base de datos. Devulve el producto más vendido
        public static ProductoDTO ObtenerMejorProducto(string filtroYear, string filtroCountry)
        {
            ProductoVO mejorProductoVO = ConsultaBD.ConsultaMejorProducto(filtroYear, filtroCountry);

            // Convertir VO en DTO
            ProductoDTO mejorProducto = new ProductoDTO(mejorProductoVO);

            return mejorProducto;
        }

        // Pedir datos del mejor cliente a la base de datos. Devulve el cliente que más ha comprado 
        public static ClienteDTO ObtenerMejorCliente(string year, string pais)
        {
            ClienteVO mejorClienteVO = ConsultaBD.ConsultaMejorCliente(year, pais);

            // Convertir VO en DTO
            ClienteDTO mejorCliente = new ClienteDTO(mejorClienteVO);

            return mejorCliente;
        }

        // Pedir datos del mejor empleado a la base de datos. Devulve el empleado que más ha vendido
        public static EmpleadoDTO ObtenerMejorEmpleado(string year, string pais)
        {
            EmpleadoVO mejorEmpleadoVO = ConsultaBD.ConsultaMejorEmpleado(year, pais);

            // Convertir VO en DTO
            EmpleadoDTO mejorEmpleado = new EmpleadoDTO(mejorEmpleadoVO);

            return mejorEmpleado;
        }

        // Pedir datos del importe total a la base de datos. Devulve la suma del importe
        public static double ObtenerImporteTotal(string year, string pais)
        {
            double total = ConsultaBD.ConsultaImporteTotal(year, pais);
            return total;
        }

        #endregion
    }
}
