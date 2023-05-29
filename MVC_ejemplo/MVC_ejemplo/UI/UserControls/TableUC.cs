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

namespace UI.UserControls
{
    public partial class TableUC : UserControl
    {
        public TableUC(List<PedidosDTO> listaPedidos)
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaPedidos;
            dataGridView1.Refresh();

        }
        /*
        public void Filtrar(string id)
        {
            
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                string idTabla = row.Cells["EmployeeID"].Value.ToString();
                if (idTabla != id)
                {
                    row.
                }
                
            }
        }*/
    }
}
