using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindsDashboard.Formularios
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            DateTime inicio = new DateTime(1997, 1, 1);
            DateTime fin = new DateTime(1998, 1, 1);

            var ta = new VentasTableAdapters.Employee_Sales_by_CountryTableAdapter();
            ta.Fill(this.ventas.Employee_Sales_by_Country, inicio, fin);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DateTime inicio = new DateTime(1997,1,1);
            DateTime fin = DateTime.Now;

            var ta = new VentasTableAdapters.Employee_Sales_by_CountryTableAdapter();
            ta.Fill(this.ventas.Employee_Sales_by_Country, inicio, fin);

            this.reportViewer1.RefreshReport();
        }
    }
}
