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
    public partial class frmBusquedaClientes : Form
    {
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        public frmBusquedaClientes()
        {
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
            frmCrearCliente frm = new frmCrearCliente();
            frm.ShowDialog();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            GestPersonasWS.cliente cliente = (GestPersonasWS.cliente)
               dgvClientes.Rows[e.RowIndex].DataBoundItem;
            dgvClientes.Rows[e.RowIndex].Cells[0].Value = cliente.DNI;
            dgvClientes.Rows[e.RowIndex].Cells[1].Value = cliente.nombre + " "+cliente.apellidoPaterno;
            dgvClientes.Rows[e.RowIndex].Cells[2].Value = cliente.telefono;
            dgvClientes.Rows[e.RowIndex].Cells[3].Value = cliente.email;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dgvClientes.CurrentRow.Index;
            GestPersonasWS.cliente clienteDni =
                daoGestPersonas.filtrarPorDni(dgvClientes.Rows[index].Cells[0].Value.ToString());
            //MessageBox.Show("has seleccionado el de id "+clienteDni.idPersona, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmCrearCliente frmod = new frmCrearCliente(clienteDni);
            frmod.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvClientes.CurrentRow.Index;
            GestPersonasWS.cliente clienteDni =
                daoGestPersonas.filtrarPorDni(dgvClientes.Rows[index].Cells[0].Value.ToString());

            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int resultado = daoGestPersonas.EliminarCliente(clienteDni.idPersona);
                if (resultado == 1) {
                    MessageBox.Show("Se ha eliminado exitosamente el cliente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvClientes.DataSource = null;
                }
                    
                else
                    MessageBox.Show("Ha ocurrido un error al momento de eliminar el cliente", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
            
    }
    }
}
