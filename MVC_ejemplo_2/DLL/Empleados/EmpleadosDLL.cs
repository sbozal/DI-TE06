using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.BBDD;
using DTOs.Empleados;

namespace DLL.Empleados
{
    public class EmpleadosDLL
    {
        public EmpleadosDLL() { }

        public List<EmpleadoDTO> getEmpleados()
        {
            string sqlQuery = @"SELECT TOP 10 [Employees].[EmployeeID], [Employees].[LastName], [Employees].[FirstName], [Employees].[Title], [Employees].[Country], [Orders].[Importe] FROM [Employees] " +
                               "LEFT JOIN (SELECT [EmployeeID], sum([Freight]) as Importe FROM [Orders] GROUP BY [EmployeeID])[Orders] " +
                               "ON [Employees].[EmployeeID] = [Orders].[EmployeeID]";

            ConexionBD conexionBD = new ConexionBD();
            SqlDataReader dataReader = conexionBD.ExecuteQueryDR(sqlQuery);

            List<EmpleadoDTO> list = new List<EmpleadoDTO>();

            while (dataReader.Read())
            {
                EmpleadoDTO empleado = new EmpleadoDTO();

                empleado.Id = (dataReader.GetValue(0) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(0).ToString()) : 0;
                string lastname = (dataReader.GetValue(1) != DBNull.Value) ? (string)dataReader.GetValue(1).ToString() : string.Empty;
                string firstname = (dataReader.GetValue(2) != DBNull.Value) ? (string)dataReader.GetValue(2).ToString() : string.Empty;
                empleado.NombreCompleto = firstname + lastname;
                empleado.Puesto = (dataReader.GetValue(3) != DBNull.Value) ? (string)dataReader.GetValue(3).ToString() : string.Empty;
                empleado.Pais = (dataReader.GetValue(4) != DBNull.Value) ? (string)dataReader.GetValue(4).ToString() : string.Empty;
                empleado.ImporteVentas = (dataReader.GetValue(5) != DBNull.Value) ? (double)Double.Parse(dataReader.GetValue(5).ToString()) : 0;

                list.Add(empleado);
            }

            //list.Sort();

            conexionBD.CerrarDataReader(dataReader);
            conexionBD.CerrarConexion();
            

            return list;
        }

        public List<EmpleadoDTO> getEmpleadosPuesto(string puesto)
        {
            string sqlQuery = @"SELECT TOP 10 [Employees].[EmployeeID], [Employees].[LastName], [Employees].[FirstName], [Employees].[Title], [Employees].[Country], [Orders].[Importe] FROM [Employees] " +
                               "LEFT JOIN (SELECT [EmployeeID], sum([Freight]) as Importe FROM [Orders] GROUP BY [EmployeeID])[Orders] " +
                               "ON [Employees].[EmployeeID] = [Orders].[EmployeeID]" +
                               "WHERE [Employees].[Title] = '" + puesto + "'";

            ConexionBD conexionBD = new ConexionBD();
            SqlDataReader dataReader = conexionBD.ExecuteQueryDR(sqlQuery);

            List<EmpleadoDTO> list = new List<EmpleadoDTO>();

            while (dataReader.Read())
            {
                EmpleadoDTO empleado = new EmpleadoDTO();

                empleado.Id = (dataReader.GetValue(0) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(0).ToString()) : 0;
                string lastname = (dataReader.GetValue(1) != DBNull.Value) ? (string)dataReader.GetValue(1).ToString() : string.Empty;
                string firstname = (dataReader.GetValue(2) != DBNull.Value) ? (string)dataReader.GetValue(2).ToString() : string.Empty;
                empleado.NombreCompleto = firstname + lastname;
                empleado.Puesto = (dataReader.GetValue(3) != DBNull.Value) ? (string)dataReader.GetValue(3).ToString() : string.Empty;
                empleado.Pais = (dataReader.GetValue(4) != DBNull.Value) ? (string)dataReader.GetValue(4).ToString() : string.Empty;
                empleado.ImporteVentas = (dataReader.GetValue(5) != DBNull.Value) ? (double)Double.Parse(dataReader.GetValue(5).ToString()) : 0;

                list.Add(empleado);
            }

            //list.Sort();

            conexionBD.CerrarDataReader(dataReader);
            conexionBD.CerrarConexion();


            return list;
        }
    }
}
