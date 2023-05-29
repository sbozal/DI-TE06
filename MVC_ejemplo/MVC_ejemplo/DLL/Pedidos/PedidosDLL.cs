using DLL.BBDD;
using DTOs;
using DTOs.Pedidos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Pedidos
{
    public class PedidosDLL
    {
        public PedidosDLL() { }

        public List<PedidosDTO> getPedidosDelCliente(string idCliente)
        {
            string sqlQuery = @"SELECT * FROM Orders WHERE CustomerID = '" + idCliente + "'";

            ConexionBD conexionBD = new ConexionBD();
            SqlDataReader dataReader = conexionBD.ExecuteQueryDR(sqlQuery);

            List<PedidosDTO> listPedidosDTO = new List<PedidosDTO>();

            while (dataReader.Read())
            {
                PedidosDTO pedidos = new PedidosDTO();

                pedidos.OrderId = (dataReader["OrderId"] != DBNull.Value) ? (int)dataReader["OrderId"] : 0;
                pedidos.CustomerId = (dataReader["CustomerId"] != DBNull.Value) ? (string)dataReader["CustomerId"] : string.Empty;
                pedidos.EmployeeId = (dataReader["EmployeeId"] != DBNull.Value) ? (int)dataReader["EmployeeId"] : 0;
                pedidos.OrderDate = (dataReader["OrderDate"] != DBNull.Value) ? (DateTime)dataReader["OrderDate"] : DateTime.MinValue;
                pedidos.ShippedDate = (dataReader["ShippedDate"] != DBNull.Value) ? (DateTime)dataReader["ShippedDate"] : DateTime.MinValue;
                pedidos.Freight = (dataReader["Freight"] != DBNull.Value) ? (decimal)dataReader["Freight"] : 0;
                pedidos.ShipAddress = (dataReader["ShipAddress"] != DBNull.Value) ? (string)dataReader["ShipAddress"] : string.Empty;

                listPedidosDTO.Add(pedidos);
            }

            conexionBD.CerrarConexion();
            conexionBD.CerrarDataReader(dataReader);

            return listPedidosDTO;
        }
    }
}
