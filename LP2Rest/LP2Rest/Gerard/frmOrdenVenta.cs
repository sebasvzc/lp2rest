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
    public partial class frmOrdenVenta : Form
    {
        private int idMesaOrdenVenta;
        public frmOrdenVenta(int idMesa)
        {
            InitializeComponent();
            idMesaOrdenVenta = idMesa;
            textBox3.Text = idMesaOrdenVenta.ToString();
        }

        private void frmOrdenVenta_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
    }
}
