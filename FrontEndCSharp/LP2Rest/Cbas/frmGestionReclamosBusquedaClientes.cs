using LP2Rest.GestPersonasWS;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmGestionReclamoBusquedaCliente : Form
    {
        //Conexiones
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;

        //Utiles
        public cliente clienteSeleccionado;

        public cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }

        public frmGestionReclamoBusquedaCliente()
        {
            clienteSeleccionado = new cliente();
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            dgvClientes.AutoGenerateColumns = false;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            GestPersonasWS.cliente[] clientes =
                daoGestPersonas.filtrarClientes(txtDniI.Text, txtEmail.Text,
                       txtNombres.Text, txtApellidos.Text, txtTelefono.Text);
            if (clientes != null)
                dgvClientes.DataSource = clientes.ToList();
            else
            {
                dgvClientes.DataSource = null;
                MessageBox.Show("No se ha encontrado algun cliente con el filtro seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                clienteSeleccionado = (cliente)dgvClientes.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un cliente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
