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
    public partial class PopUp : Form
    {
        public PopUp(string info)
        {
            InitializeComponent();
            this.tbPopUp.Text = info; 
        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnPopUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
