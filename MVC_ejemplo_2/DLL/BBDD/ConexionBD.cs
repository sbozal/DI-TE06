using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace DLL.BBDD
{
    public class ConexionBD
    {
        private string cadenaConexion = "";
        private string server = "localhost";
        private string database = "NorthWind";
        private string user = "di";
        private string password = "1234";
        private string certificado = "True";
        private SqlConnection conn = null;

        public ConexionBD()
        {
            cadenaConexion = ConstruirCadenaConexion();            
        }

        private string ConstruirCadenaConexion()
        {
            return @"Data Source=" + server +
                   "; Initial Catalog=" + database +
                   "; User ID=" + user +
                   "; Password=" + password +
                   "; TrustServerCertificate=" + certificado;
        }

        private void ManejarExcepcionConexion(Exception ex)
        {
            Console.WriteLine("Error en la conexión a la base de datos: " + ex.Message);
        }

        //SQLDataAdapter
        public DataTable ExecuteQuery(string sqlQuery)
        {
            try
            {
                using (SqlConnection conexion = CrearConexion())
                {
                    conexion.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conexion);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (SqlException ex)
            {
                ManejarExcepcionConexion(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en executeQuery: " + ex.Message);
            }

            return null;
        }

        //SQLDataReader
        public SqlDataReader ExecuteQueryDR(string sqlQuery)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                SqlConnection conexion = CrearConexion();
                conexion.Open();
                SqlCommand command = new SqlCommand(sqlQuery, conexion);
                sqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return sqlDataReader;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en executeQuery: " + ex.Message);
                CerrarConexion();
                CerrarDataReader(sqlDataReader);
            }

            return null;
        }

        public SqlConnection CrearConexion() {
            conn = new SqlConnection(cadenaConexion);
            return conn;
        }

        public void CerrarConexion()
        {
            conn.Close();
        }
        public void CerrarDataReader(SqlDataReader reader)
        {
            reader.Close();
        }
    }
}
