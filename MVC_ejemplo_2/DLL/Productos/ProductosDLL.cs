using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.BBDD;
using DTOs.Productos;

namespace DLL.Productos
{
    public class ProductosDLL
    {

        public List<ProductoDTO> getProductosCategoria(string idCategoria)
        {
            string sqlQuery = @"SELECT * FROM Products WHERE CategoryID = '" + idCategoria + "'";

            ConexionBD conexionBD = new ConexionBD();
            SqlDataReader dataReader = conexionBD.ExecuteQueryDR(sqlQuery);

            List<ProductoDTO> listaProductos = new List<ProductoDTO>();

            while (dataReader.Read())
            {
                ProductoDTO producto = new ProductoDTO();

                producto.ProductID = (dataReader.GetValue(0) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(0).ToString()) : 0;
                producto.ProductName = (dataReader.GetValue(1) != DBNull.Value) ? dataReader.GetValue(1).ToString() : string.Empty;
                producto.CategoryID = (dataReader.GetValue(3) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(3).ToString()) : 0;
                producto.UnitPrice = (dataReader.GetValue(5) != DBNull.Value) ? (double)Double.Parse(dataReader.GetValue(5).ToString()) : 0;
                producto.Stock = (dataReader.GetValue(6) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(6).ToString()) : 0;

                listaProductos.Add(producto);
            }

            conexionBD.CerrarConexion();
            conexionBD.CerrarDataReader(dataReader);

            return listaProductos;
        }

        public List<ProductoDTO> getProductos()
        {
            string sqlQuery = @"SELECT * FROM Products"; ;

            ConexionBD conexionBD = new ConexionBD();
            SqlDataReader dataReader = conexionBD.ExecuteQueryDR(sqlQuery);

            List<ProductoDTO> listaProductos = new List<ProductoDTO>();

            while (dataReader.Read())
            {
                ProductoDTO producto = new ProductoDTO();

                producto.ProductID = (dataReader.GetValue(0) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(0).ToString()) : 0;
                producto.ProductName = (dataReader.GetValue(1) != DBNull.Value) ? dataReader.GetValue(1).ToString() : string.Empty;
                producto.CategoryID = (dataReader.GetValue(3) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(3).ToString()) : 0;
                producto.UnitPrice = (dataReader.GetValue(5) != DBNull.Value) ? (double)Double.Parse(dataReader.GetValue(5).ToString()) : 0;
                producto.Stock = (dataReader.GetValue(6) != DBNull.Value) ? (int)Int64.Parse(dataReader.GetValue(6).ToString()) : 0;

                listaProductos.Add(producto);
            }

            conexionBD.CerrarConexion();
            conexionBD.CerrarDataReader(dataReader);

            return listaProductos;
        }
    }
}