using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.BBDD;
using DTOs.Clientes;

namespace DLL.Clientes
{
    public class ClientesDLL
    {
        public ClientesDLL() { }

        public List<ClienteDTO> getClientesPais (string idPais)
        {
            string sqlQuery = @"SELECT [Customers].[CustomerID], [Customers].[CompanyName], [Customers].[City], [Customers].[Country], [Orders].[Importe] FROM Customers " +
                               "LEFT JOIN (SELECT [CustomerID], sum([Freight]) as Importe FROM [Orders] GROUP BY [CustomerID])[Orders] " +
                               "ON [Customers].[CustomerID] = [Orders].[CustomerID] " +
                               "WHERE[Customers].[Country] = '" + idPais + "'";

            ConexionBD conexionBD = new ConexionBD();
            SqlDataReader dataReader = conexionBD.ExecuteQueryDR(sqlQuery);

            List<ClienteDTO> list = new List<ClienteDTO>();

            while (dataReader.Read())
            {
                ClienteDTO cliente = new ClienteDTO();

                cliente.CustomerID = (dataReader.GetValue(0) != DBNull.Value) ? dataReader.GetValue(0).ToString() : string.Empty;
                cliente.CompanyName = (dataReader.GetValue(1) != DBNull.Value) ? dataReader.GetValue(1).ToString() : string.Empty;
                cliente.City = (dataReader.GetValue(2) != DBNull.Value) ? dataReader.GetValue(2).ToString() : string.Empty;
                cliente.Country = (dataReader.GetValue(3) != DBNull.Value) ? dataReader.GetValue(3).ToString() : string.Empty;
                cliente.Importe = (dataReader.GetValue(4) != DBNull.Value) ? (double)Double.Parse(dataReader.GetValue(4).ToString()) : 0;

                list.Add(cliente);
            }
            conexionBD.CerrarConexion();
            conexionBD.CerrarDataReader(dataReader);

            return list;

        }

        public List<ClienteDTO> getClientes()
        {
            string sqlQuery = @"SELECT [Customers].[CustomerID], [Customers].[CompanyName], [Customers].[City], [Customers].[Country], [Orders].[Importe] FROM Customers " +
                               "LEFT JOIN (SELECT [CustomerID], sum([Freight]) as Importe FROM [Orders] GROUP BY [CustomerID])[Orders] " +
                               "ON [Customers].[CustomerID] = [Orders].[CustomerID]";

            ConexionBD conexionBD = new ConexionBD();
            SqlDataReader dataReader = conexionBD.ExecuteQueryDR(sqlQuery);

            List<ClienteDTO> list = new List<ClienteDTO>();

            while (dataReader.Read())
            {
                ClienteDTO cliente = new ClienteDTO();

                cliente.CustomerID = (dataReader.GetValue(0) != DBNull.Value) ? dataReader.GetValue(0).ToString() : string.Empty;
                cliente.CompanyName = (dataReader.GetValue(1) != DBNull.Value) ? dataReader.GetValue(1).ToString() : string.Empty;
                cliente.City = (dataReader.GetValue(2) != DBNull.Value) ? dataReader.GetValue(2).ToString() : string.Empty;
                cliente.Country = (dataReader.GetValue(3) != DBNull.Value) ? dataReader.GetValue(3).ToString() : string.Empty;
                cliente.Importe = (dataReader.GetValue(4) != DBNull.Value) ? (double)Double.Parse(dataReader.GetValue(4).ToString()) : 0;

                list.Add(cliente);
            }
            conexionBD.CerrarConexion();
            conexionBD.CerrarDataReader(dataReader);

            return list;

        }
    }
}
