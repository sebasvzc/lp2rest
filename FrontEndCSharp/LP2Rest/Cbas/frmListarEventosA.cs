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
    public partial class frmListarEventosA : Form
    {
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        private GestPersonasWS.evento eventoSeleccionado;
        public frmListarEventosA()
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            cboArtista.DataSource = daoGestPersonas.listarTodasArtistas();
            cboArtista.DisplayMember = "nombre";
            cboArtista.ValueMember = "idArtista";
            dgvEventos.AutoGenerateColumns = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionEventosA frm = new frmGestionEventosA();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                cboArtista.DataSource = daoGestPersonas.listarTodasArtistas();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            double costMin, costMax;

            if (txtCostoMin.Text == "")
                costMin = 0;
            else costMin = Double.Parse(txtCostoMin.Text);

            if (txtCostMax.Text == "")
                costMax = 999999;
            else costMax = Double.Parse(txtCostMax.Text);


            GestPersonasWS.evento[] eventos = daoGestPersonas.FiltrarEventos(txtDNINombre.Text, ((GestPersonasWS.artista)cboArtista.SelectedItem).idArtista, 
                        dtpFechaInicio.Value, dtpFechaFin.Value, costMin, costMax);
            if (eventos != null)
                dgvEventos.DataSource = eventos.ToList();
            else 
            {
                dgvEventos.DataSource = null;
                MessageBox.Show("No se ha encontrado un evento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestPersonasWS.evento evento = (GestPersonasWS.evento)
                dgvEventos.Rows[e.RowIndex].DataBoundItem;
            dgvEventos.Rows[e.RowIndex].Cells[0].Value = evento.nombre;
            dgvEventos.Rows[e.RowIndex].Cells[1].Value = evento.fecha_inicio.Date.ToString("dd/MM/yyyy");
            dgvEventos.Rows[e.RowIndex].Cells[2].Value = evento.artista.nombre;
            dgvEventos.Rows[e.RowIndex].Cells[3].Value = evento.monto_pagar.ToString("N2");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvEventos.CurrentRow != null)
            {
                eventoSeleccionado = (GestPersonasWS.evento)dgvEventos.CurrentRow.DataBoundItem;
                eventoSeleccionado = daoGestPersonas.buscarEventoPorID(eventoSeleccionado.idEvento);
                frmGestionEventosA frm = new frmGestionEventosA(eventoSeleccionado);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                dgvEventos.DataSource = null;
                MessageBox.Show("No se ha seleccionado un evento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.CurrentRow != null)
            {
                eventoSeleccionado = (GestPersonasWS.evento)dgvEventos.CurrentRow.DataBoundItem;

                
                if (MessageBox.Show("¿Esta seguro que desea eliminar el evento?",
                    "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    ) == DialogResult.Yes)
                {
                    int resultado = daoGestPersonas.EliminarEvento(eventoSeleccionado.idEvento);
                    if (resultado == 1)
                        MessageBox.Show("Se ha eliminado exitosamente el evento", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ha ocurrido un error al momento de eliminar el evento", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cboArtista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCostMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCostoMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDNINombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDNINombre_Click(object sender, EventArgs e)
        {

        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
