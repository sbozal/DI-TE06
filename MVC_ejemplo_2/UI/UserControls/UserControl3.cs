using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs.Pedidos;
using DTOs.Productos;

namespace UI.UserControls
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3(List<PedidosDTO> listaPedidos)
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaPedidos;
            dataGridView1.Refresh();
        }

        public UserControl3(List<ProductoDTO> listaProductos)
        {
            InitializeComponent();

            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = listaProductos;
            //dataGridView1.Refresh();

            foreach (ProductoDTO producto in listaProductos)
            {
                dataGridView1.Columns.Add(producto.ProductName, "Nombre");
                dataGridView1.Columns.Add(producto.CategoryID.ToString(), "Categoría");
                dataGridView1.Columns.Add(producto.Stock.ToString(), "Stock");

                dataGridView1.Refresh();
            }
            
        }
    }
}
