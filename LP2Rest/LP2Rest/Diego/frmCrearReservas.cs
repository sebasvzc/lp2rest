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
    public partial class frmCrearReservas : Form
    {
        public frmCrearReservas()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmGestionClientes formGestionClientes = new frmGestionClientes();
            formGestionClientes.ShowDialog();
        }
    }
}
