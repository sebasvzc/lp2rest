using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmListarOrdenesVentaA : Form
    {
        public frmListarOrdenesVentaA()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionOrdenesVentaA formGestionOrdenesVentaA = new frmGestionOrdenesVentaA();
            formGestionOrdenesVentaA.ShowDialog();
        }
    }
}
