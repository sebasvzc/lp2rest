using LP2Rest;
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
    public partial class frmGestionOrdenesVentaA : Form
    {
        public frmGestionOrdenesVentaA()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmGestionClientes formGestionClientes = new frmGestionClientes();
            formGestionClientes.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
           
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            if (formListarPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
