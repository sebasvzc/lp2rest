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
    public partial class frmGestionClientes : Form
    {
        //Conexiones
        GestPersonasWS.GestPersonasWSClient daoGestPersonas;

        public frmGestionClientes()
        {
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();

            InitializeComponent();

            dgvClientes.AutoGenerateColumns = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCrearCliente formCrearClientes = new frmCrearCliente();
            formCrearClientes.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            GestPersonasWS.cliente[] clientes =
                daoGestPersonas.filtrarClientes(textDNI.Text, textEmail.Text,
                       txtNombres.Text, txtApellidos.Text, "");
            if (clientes != null)
                dgvClientes.DataSource = clientes.ToList();
            else
            {
                dgvClientes.DataSource = null;
                MessageBox.Show("No se ha encontrado algun cliente con el filtro seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestPersonasWS.cliente cliente = (GestPersonasWS.cliente)
               dgvClientes.Rows[e.RowIndex].DataBoundItem;
            dgvClientes.Rows[e.RowIndex].Cells[0].Value = cliente.DNI;
            dgvClientes.Rows[e.RowIndex].Cells[1].Value = cliente.nombre + " " + cliente.apellidoPaterno;
            dgvClientes.Rows[e.RowIndex].Cells[2].Value = cliente.telefono;
            dgvClientes.Rows[e.RowIndex].Cells[3].Value = cliente.email;
        }
    }
}
