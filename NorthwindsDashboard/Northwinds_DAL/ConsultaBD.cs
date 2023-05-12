using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Utilidades.VO;
using Utilidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Northwinds_DAL
{
    public class ConsultaBD
    {
        #region Filtros
        // Obtener años de la base de datos para el combo box del filtro
        public static List<int> RealizarConsultaYears()
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            string query = "SELECT distinct year([OrderDate]) FROM [Northwind].[dbo].[Orders]";

            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                List<int> years = new List<int>();

                // Recoger datos e ir añadiéndolos en la lista
                while (dataReader.Read())
                {
                    int year = (int)Int64.Parse(dataReader.GetValue(0).ToString());

                    // Añadir a lista
                    years.Add(year);

                }

                dataReader.Close();
                comand.Dispose();

                return years;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }

        // Consulta a la base de datos para obtener los paises para el combo box del filtro de paises
        public static List<string> RealizarConsultaPaises()
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            string query = "SELECT distinct [ShipCountry] FROM [Northwind].[dbo].[Orders]";

            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                List<string> paises = new List<string>();

                paises.Add("Todos");

                // Recoger datos e ir añadiéndolos en la lista
                while (dataReader.Read())
                {
                    string pais = dataReader.GetValue(0).ToString();

                    // Añadir a lista 
                    paises.Add(pais);

                }

                dataReader.Close();
                comand.Dispose();

                return paises;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }
        #endregion

        #region Consultas Gráfico Ranking
        // Consulta a la base de datos para obtener los datos que se muestran en el gráfico de ranking de productos
        public static List<PedidoVO> ConsultaRankingProductos(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no

            string query = "";

            if (year == "Todos" && pais == "Todos")
            {
                query = "SELECT TOP (10)" +
                                "[Order Details].[ProductID]" +
                                ",[Products].[ProductName]" +
                                ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                            "FROM [Northwind].[dbo].[Order Details] " +
                            "LEFT JOIN (SELECT [ProductID], [ProductName] FROM [Products])[Products] " +
                                "on [Order Details].[ProductID] = [Products].[ProductID] " +
                            "group by [Order Details].[ProductID], [Products].[ProductName] " +
                            "order by Importe desc";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT TOP (10)" +
                                "[Order Details].[ProductID]" +
                                ",[Products].[ProductName]" +
                                ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                            "FROM [Northwind].[dbo].[Order Details] " +
                            "LEFT JOIN (SELECT [OrderID], [OrderDate]  FROM [Orders])[Orders] " +
                                "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                            "LEFT JOIN (SELECT [ProductID], [ProductName] FROM [Products])[Products] " +
                                "on [Order Details].[ProductID] = [Products].[ProductID] " +
                            "where year([Orders].[OrderDate]) = '" + year + "'" +
                            "group by [Order Details].[ProductID], [Products].[ProductName] " +
                            "order by Importe desc";
            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT TOP (10)" +
                                "[Order Details].[ProductID]" +
                                ",[Products].[ProductName]" +
                                ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                            "FROM [Northwind].[dbo].[Order Details] " +
                            "LEFT JOIN (SELECT [OrderID], [ShipCountry]  FROM [Orders])[Orders] " +
                                "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                            "LEFT JOIN (SELECT [ProductID], [ProductName] FROM [Products])[Products] " +
                                "on [Order Details].[ProductID] = [Products].[ProductID] " +
                            "where [Orders].[ShipCountry] = '" + pais + "'" +
                            "group by [Order Details].[ProductID], [Products].[ProductName] " +
                            "order by Importe desc";
            }
            else
            {
                query = "SELECT TOP (10)" +
                                "[Order Details].[ProductID]" +
                                ",[Products].[ProductName]" +
                                ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                            "FROM [Northwind].[dbo].[Order Details] " +
                            "LEFT JOIN (SELECT [OrderID], [ShipCountry], [OrderDate]  FROM [Orders])[Orders] " +
                                "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                            "LEFT JOIN (SELECT [ProductID], [ProductName] FROM [Products])[Products] " +
                                "on [Order Details].[ProductID] = [Products].[ProductID] " +
                            "where year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'" +
                            "group by [Order Details].[ProductID], [Products].[ProductName] " +
                            "order by Importe desc";
            }



                //Objeto lectura de datos
                SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                List<PedidoVO> pedidos = new List<PedidoVO>();

                // Recoger datos e ir añadiéndolos en la lista de pedidos
                while (dataReader.Read())
                {
                    PedidoVO pedido = new PedidoVO();

                    // Parsear datos
                    pedido.IdProducto = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    pedido.NombreProducto = dataReader.GetValue(1).ToString();
                    pedido.Importe = (double)Double.Parse(dataReader.GetValue(2).ToString());

                    // Añadir a lista pedidos
                    pedidos.Add(pedido);

                }

                dataReader.Close();
                comand.Dispose();

                return pedidos;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }
        
        #endregion

        #region Consultas Gráficos Tarta
        // Consulta a la base de datos para obtener los datos que se utilizan en el gráfico de tarta de clientes
        public static List<PedidoVO> ConsultaTartaClientes(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no

            string query = "";

            if (year == "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[CustomerID]" +
                            ", [Customers].[CompanyName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [CustomerID] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[CustomerID], [CompanyName] FROM[Customers])[Customers] " +
                            "on[Customers].[CustomerID] = [Orders].[CustomerID] " +
                        "group by[Order Details].[OrderID], [Orders].[CustomerID], [Customers].[CompanyName] " +
                        "order by Importe desc";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[CustomerID]" +
                            ", [Customers].[CompanyName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [CustomerID], [OrderDate] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[CustomerID], [CompanyName] FROM[Customers])[Customers] " +
                            "on[Customers].[CustomerID] = [Orders].[CustomerID] " +
                        "where year([Orders].[OrderDate]) = '" + year + "'" +
                        "group by[Order Details].[OrderID], [Orders].[CustomerID], [Customers].[CompanyName] " +
                        "order by Importe desc";
            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[CustomerID]" +
                            ", [Customers].[CompanyName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [CustomerID], [ShipCountry] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[CustomerID], [CompanyName] FROM[Customers])[Customers] " +
                            "on[Customers].[CustomerID] = [Orders].[CustomerID] " +
                        "where [Orders].[ShipCountry] = '" + pais + "'" +
                        "group by[Order Details].[OrderID], [Orders].[CustomerID], [Customers].[CompanyName] " +
                        "order by Importe desc";
            }
            else
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[CustomerID]" +
                            ", [Customers].[CompanyName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [CustomerID], [OrderDate], [ShipCountry] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[CustomerID], [CompanyName] FROM[Customers])[Customers] " +
                            "on[Customers].[CustomerID] = [Orders].[CustomerID] " +
                        "where year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'" +
                        "group by[Order Details].[OrderID], [Orders].[CustomerID], [Customers].[CompanyName] " +
                        "order by Importe desc";
            }

            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                List<PedidoVO> pedidos = new List<PedidoVO>();

                // Recoger datos e ir añadiéndolos en la lista de pedidos
                while (dataReader.Read())
                {
                    PedidoVO pedido = new PedidoVO();

                    // Parsear datos
                    pedido.IdCliente = dataReader.GetValue(0).ToString();
                    pedido.NombreCliente = dataReader.GetValue(1).ToString();
                    pedido.Importe = (double)Double.Parse(dataReader.GetValue(2).ToString());

                    // Añadir a lista pedidos
                    pedidos.Add(pedido);

                }

                dataReader.Close();
                comand.Dispose();

                return pedidos;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }

        }
        
        // Consulta a la base de datos para obtener los datos necesarios para el gráfico de tarta de empleados
        public static List<PedidoVO> ConsultaTartaEmpleados(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no

            string query = "";

            if (year == "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[EmployeeID]" +
                            ", [Employees].[FirstName]" +
                            ", [Employees].[LastName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [EmployeeID] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[EmployeeID], [FirstName], [LastName] FROM [Employees])[Employees] " +
                            "on [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                        "group by[Order Details].[OrderID], [Orders].[EmployeeID], [Employees].[FirstName], [Employees].[LastName] " +
                        "order by Importe desc";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[EmployeeID]" +
                            ", [Employees].[FirstName]" +
                            ", [Employees].[LastName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [EmployeeID], [OrderDate] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[EmployeeID], [FirstName], [LastName] FROM [Employees])[Employees] " +
                            "on [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                        "where year([Orders].[OrderDate]) = '" + year + "'" +
                        "group by[Order Details].[OrderID], [Orders].[EmployeeID], [Employees].[FirstName], [Employees].[LastName] " +
                        "order by Importe desc";
            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[EmployeeID]" +
                            ", [Employees].[FirstName]" +
                            ", [Employees].[LastName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [EmployeeID], [ShipCountry] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[EmployeeID], [FirstName], [LastName] FROM [Employees])[Employees] " +
                            "on [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                        "where [Orders].[ShipCountry] = '" + pais + "'" +
                        "group by[Order Details].[OrderID], [Orders].[EmployeeID], [Employees].[FirstName], [Employees].[LastName] " +
                        "order by Importe desc";
            }
            else
            {
                query = "SELECT TOP(10) " +
                            "[Orders].[EmployeeID]" +
                            ", [Employees].[FirstName]" +
                            ", [Employees].[LastName]" +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe]" +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT OrderID, [EmployeeID], [OrderDate], [ShipCountry] FROM[Orders])[Orders] " +
                            "on[Order Details].[OrderID] = [Orders].[OrderID] " +
                        "LEFT JOIN(SELECT[EmployeeID], [FirstName], [LastName] FROM [Employees])[Employees] " +
                            "on [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                        "where year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'" +
                        "group by[Order Details].[OrderID], [Orders].[EmployeeID], [Employees].[FirstName], [Employees].[LastName] " +
                        "order by Importe desc";
            }

            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                List<PedidoVO> pedidos = new List<PedidoVO>();

                // Recoger datos e ir añadiéndolos en la lista de pedidos
                while (dataReader.Read())
                {
                    PedidoVO pedido = new PedidoVO();

                    // Parsear datos
                    pedido.IdEmpleado = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    pedido.NombreEmpleado = dataReader.GetValue(1).ToString() + " " + dataReader.GetValue(2).ToString();
                    pedido.Importe = (double)Double.Parse(dataReader.GetValue(3).ToString());

                    // Añadir a lista pedidos
                    pedidos.Add(pedido);

                }

                dataReader.Close();
                comand.Dispose();

                return pedidos;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }
        #endregion

        #region Consultas Gráfico Evolutivo
        // Consulta a la base de datos para obtener los datos necesarios para el gráfico de barras evolutivo
        public static List<PedidoVO> ConsultaEvolutivo(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no
            string query = "";  
                            
            if(year == "Todos" && pais == "Todos")
            {
                query = "SELECT " +
                            "month([Orders].[OrderDate]) as [Mes] " +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                        "FROM [Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN (SELECT [OrderID], [OrderDate], [ShipCountry] FROM [Orders])[Orders] " +
                            "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                        "GROUP BY [Orders].[OrderDate] " +
                        "ORDER BY [Mes]";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT " +
                            "month([Orders].[OrderDate]) as [Mes] " +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                        "FROM [Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN (SELECT [OrderID], [OrderDate], [ShipCountry] FROM [Orders])[Orders] " +
                            "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                        "WHERE year([Orders].[OrderDate]) = '" + year + "'" +
                        "GROUP BY [Orders].[OrderDate] " +
                        "ORDER BY [Mes]";
            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT " +
                            "month([Orders].[OrderDate]) as [Mes] " +
                            ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                        "FROM [Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN (SELECT [OrderID], [OrderDate], [ShipCountry] FROM [Orders])[Orders] " +
                            "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                        "WHERE [Orders].[ShipCountry] = '" + pais + "'" +
                        "GROUP BY [Orders].[OrderDate] " +
                        "ORDER BY [Mes]";
            }
            else
            {
                query = "SELECT " +
                           "month([Orders].[OrderDate]) as [Mes] " +
                           ",round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1-[Order Details].[Discount])), 2) as [Importe] " +
                       "FROM [Northwind].[dbo].[Order Details] " +
                       "LEFT JOIN (SELECT [OrderID], [OrderDate], [ShipCountry] FROM [Orders])[Orders] " +
                           "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                       "WHERE year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'" +
                       "GROUP BY [Orders].[OrderDate] " +
                       "ORDER BY [Mes]";
            }

            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                List<PedidoVO> pedidos = new List<PedidoVO>();

                // Recoger datos e ir añadiéndolos en la lista de pedidos
                while (dataReader.Read())
                {
                    PedidoVO pedido = new PedidoVO();

                    // Parsear datos
                    pedido.Mes = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    pedido.Importe = (double)Double.Parse(dataReader.GetValue(1).ToString());

                    // Añadir a lista pedidos
                    pedidos.Add(pedido);

                }

                dataReader.Close();
                comand.Dispose();

                return pedidos;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }
        #endregion

        #region Información
        // Consulta a la base de datos para obtener los datos del mejor producto que se muestran en la zona de información
        public static ProductoVO ConsultaMejorProducto(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no

            string query = "";

            if (year == "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(1) " +
                            "[Products].[ProductID]," +
                            "[Products].[ProductName]," +
                            "[Products].[UnitPrice]," +
                            "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT[ProductID], [ProductName], [UnitPrice] FROM[Products])[Products] " +
                            "ON[Products].[ProductID] = [Order Details].[ProductID] " +
                        "group by [Products].ProductID, [Products].[ProductName], [Products].[UnitPrice] " +
                        "order by Importe desc";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(1) " +
                            "[Products].[ProductID]," +
                            "[Products].[ProductName]," +
                            "[Products].[UnitPrice]," +
                            "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT[ProductID], [ProductName], [UnitPrice] FROM[Products])[Products] " +
                            "ON[Products].[ProductID] = [Order Details].[ProductID] " +
                        "LEFT JOIN (SELECT [OrderID], [OrderDate]  FROM [Orders])[Orders] " +
                                "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                        "where year([Orders].[OrderDate]) = '" + year + "'" +
                        "group by [Products].ProductID, [Products].[ProductName], [Products].[UnitPrice] " +
                        "order by Importe desc";

            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT TOP(1) " +
                            "[Products].[ProductID]," +
                            "[Products].[ProductName]," +
                            "[Products].[UnitPrice]," +
                            "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT[ProductID], [ProductName], [UnitPrice] FROM[Products])[Products] " +
                            "ON[Products].[ProductID] = [Order Details].[ProductID] " +
                        "LEFT JOIN (SELECT [OrderID], [ShipCountry]  FROM [Orders])[Orders] " +
                                "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                        "where [Orders].[ShipCountry] = '" + pais + "'" +
                        "group by [Products].ProductID, [Products].[ProductName], [Products].[UnitPrice] " +
                        "order by Importe desc";
            }
            else
            {
                query = "SELECT TOP(1) " +
                            "[Products].[ProductID]," +
                            "[Products].[ProductName]," +
                            "[Products].[UnitPrice]," +
                            "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                        "FROM[Northwind].[dbo].[Order Details] " +
                        "LEFT JOIN(SELECT[ProductID], [ProductName], [UnitPrice] FROM[Products])[Products] " +
                            "ON[Products].[ProductID] = [Order Details].[ProductID] " +
                        "LEFT JOIN (SELECT [OrderID], [ShipCountry], [OrderDate]  FROM [Orders])[Orders] " +
                                "ON [Orders].[OrderID] = [Order Details].[OrderID] " +
                        "where year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'" +
                        "group by [Products].ProductID, [Products].[ProductName], [Products].[UnitPrice] " +
                        "order by Importe desc";
            }



            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                ProductoVO mejorProducto = new ProductoVO();

                while (dataReader.Read())
                {
                    // Parsear datos
                    mejorProducto.IdProducto = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    mejorProducto.Producto = dataReader.GetValue(1).ToString();
                    mejorProducto.PrecioUnidad = (double)Double.Parse(dataReader.GetValue(2).ToString());
                    mejorProducto.ImporteTotal = (double)Double.Parse(dataReader.GetValue(3).ToString());
                }

                dataReader.Close();
                comand.Dispose();

                return mejorProducto;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }

        // Consulta a la base de datos para obtener los datos del mejor cliente que se muestra en la zona de información 
        public static ClienteVO ConsultaMejorCliente(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no

            string query = "";

            if (year == "Todos" && pais == "Todos")
            {
                query =  "SELECT TOP(1) " +
                              "[Customers].[CustomerID], " +
                              "[Customers].[CompanyName], " +
                              "[Customers].[Country], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [CustomerID] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT[CustomerID], [Country], [CompanyName] FROM[Customers])[Customers] " +
                                "ON[Customers].[CustomerID] = [Orders].[CustomerID] " +
                          "group by[Customers].[CustomerID],[Customers].[CompanyName],[Customers].[Country] " +
                          "order by Importe desc";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(1) " +
                              "[Customers].[CustomerID], " +
                              "[Customers].[CompanyName], " +
                              "[Customers].[Country], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [CustomerID], [OrderDate] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT[CustomerID], [Country], [CompanyName] FROM[Customers])[Customers] " +
                                "ON[Customers].[CustomerID] = [Orders].[CustomerID] " +
                          "where year([Orders].[OrderDate]) = '" + year + "'" +
                          "group by[Customers].[CustomerID],[Customers].[CompanyName],[Customers].[Country] " +
                          "order by Importe desc";

            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT TOP(1) " +
                              "[Customers].[CustomerID], " +
                              "[Customers].[CompanyName], " +
                              "[Customers].[Country], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [CustomerID], [ShipCountry] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT[CustomerID], [Country], [CompanyName] FROM[Customers])[Customers] " +
                                "ON[Customers].[CustomerID] = [Orders].[CustomerID] " +
                          "where [Orders].[ShipCountry] = '" + pais + "'" +
                          "group by[Customers].[CustomerID],[Customers].[CompanyName],[Customers].[Country] " +
                          "order by Importe desc";

            }
            else
            {
                query = "SELECT TOP(1) " +
                              "[Customers].[CustomerID], " +
                              "[Customers].[CompanyName], " +
                              "[Customers].[Country], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [CustomerID], [ShipCountry], [OrderDate] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT[CustomerID], [Country], [CompanyName] FROM[Customers])[Customers] " +
                                "ON[Customers].[CustomerID] = [Orders].[CustomerID] " +
                          "where year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'" +
                          "group by[Customers].[CustomerID],[Customers].[CompanyName],[Customers].[Country] " +
                          "order by Importe desc";
            }



            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                ClienteVO mejorCliente = new ClienteVO();

                while (dataReader.Read())
                {
                    // Parsear datos
                    mejorCliente.IdCliente = dataReader.GetValue(0).ToString();
                    mejorCliente.Nombre = dataReader.GetValue(1).ToString();
                    mejorCliente.Pais = dataReader.GetValue(2).ToString();
                    mejorCliente.ImporteTotal = (double)Double.Parse(dataReader.GetValue(3).ToString());
                }

                dataReader.Close();
                comand.Dispose();

                return mejorCliente;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }

        // Consulta a la base de datos para obtener los datos del mejor empleado que se muestran en la zona de información
        public static EmpleadoVO ConsultaMejorEmpleado(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no

            string query = "";

            if (year == "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(1) " +
                              "[Employees].[FirstName], " +
                              "[Employees].[LastName], " +
                              "[Employees].[Title], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [EmployeeID] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT [EmployeeID], [FirstName], [LastName], [Title] FROM [Employees])[Employees] " +
                                "ON [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                          "group by [Employees].[FirstName],[Employees].[LastName],[Employees].[Title] " +
                          "order by Importe desc";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT TOP(1) " +
                              "[Employees].[FirstName], " +
                              "[Employees].[LastName], " +
                              "[Employees].[Title], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [EmployeeID], [OrderDate] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT [EmployeeID], [FirstName], [LastName], [Title] FROM [Employees])[Employees] " +
                                "ON [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                          "where year([Orders].[OrderDate]) = '" + year + "'" +
                          "group by [Employees].[FirstName],[Employees].[LastName],[Employees].[Title] " +
                          "order by Importe desc";

            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT TOP(1) " +
                              "[Employees].[FirstName], " +
                              "[Employees].[LastName], " +
                              "[Employees].[Title], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [EmployeeID], [OrderDate], [ShipCountry] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT [EmployeeID], [FirstName], [LastName], [Title] FROM [Employees])[Employees] " +
                                "ON [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                          "where [Orders].[ShipCountry] = '" + pais + "'" +
                          "group by [Employees].[FirstName],[Employees].[LastName],[Employees].[Title] " +
                          "order by Importe desc";


            }
            else
            {
                query = "SELECT TOP(1) " +
                              "[Employees].[FirstName], " +
                              "[Employees].[LastName], " +
                              "[Employees].[Title], " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [EmployeeID], [OrderDate], [ShipCountry] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "LEFT JOIN(SELECT [EmployeeID], [FirstName], [LastName], [Title] FROM [Employees])[Employees] " +
                                "ON [Employees].[EmployeeID] = [Orders].[EmployeeID] " +
                          "where year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'" +
                          "group by [Employees].[FirstName],[Employees].[LastName],[Employees].[Title] " +
                          "order by Importe desc";
            }



            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                EmpleadoVO mejorEmpleado = new EmpleadoVO();

                while (dataReader.Read())
                {
                    // Parsear datos
                    mejorEmpleado.Nombre = dataReader.GetValue(0).ToString() + " " + dataReader.GetValue(1).ToString();
                    mejorEmpleado.Cargo = dataReader.GetValue(2).ToString();
                    mejorEmpleado.ImporteTotal = (double)Double.Parse(dataReader.GetValue(3).ToString());
                }

                dataReader.Close();
                comand.Dispose();

                return mejorEmpleado;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }

        // Consulta a la base de datos para obtener el importe total
        public static double ConsultaImporteTotal(string year, string pais)
        {
            // Conexión
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand comand;

            // Consulta a la base de datos
            // Se crea una consulta dependiendo de si se ha seleccionado algo en los filtros o no

            string query = "";

            if (year == "Todos" && pais == "Todos")
            {
                query = "SELECT " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] ";
            }
            else if (year != "Todos" && pais == "Todos")
            {
                query = "SELECT " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [OrderDate] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "where year([Orders].[OrderDate]) = '" + year + "'";

            }
            else if (year == "Todos" && pais != "Todos")
            {
                query = "SELECT " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [ShipCountry] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "where [Orders].[ShipCountry] = '" + pais + "'" ;


            }
            else
            {
                query = "SELECT " +
                              "round(sum([Order Details].[UnitPrice] * [Order Details].[Quantity] * (1 -[Order Details].[Discount])), 2) as [Importe] " +
                          "FROM[Northwind].[dbo].[Order Details] " +
                          "LEFT JOIN(SELECT[OrderID], [OrderDate], [ShipCountry] FROM[Orders])[Orders] " +
                                "ON[Orders].[OrderID] = [Order Details].[OrderID] " +
                          "where year([Orders].[OrderDate]) = '" + year + "' and [Orders].[ShipCountry] = '" + pais + "'";
            }



            //Objeto lectura de datos
            SqlDataReader dataReader;


            try
            {
                // Abrir conexión y leer datos de la consulta
                conexion.Open();
                comand = new SqlCommand(query, conexion);

                dataReader = comand.ExecuteReader();

                double total = 0;

                while (dataReader.Read())
                {
                    total = (double)Double.Parse(dataReader.GetValue(0).ToString());
                }

                dataReader.Close();
                comand.Dispose();

                return total;

            }
            catch (Exception e)
            {
                return 0;
                throw new Exception(e.Message);
            }
            finally
            {
                // Cerrar conexión
                conexion.Close();
            }
        }
    }
        #endregion
}
