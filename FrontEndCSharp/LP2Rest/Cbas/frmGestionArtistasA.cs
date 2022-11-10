using LP2Rest.GestPersonasWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Cbas
{
    public partial class frmGestionArtistasA : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        private GestPersonasWS.artista _artistaSeleccionado;

        public artista ArtistaSeleccionado { get => _artistaSeleccionado; set => _artistaSeleccionado = value; }

        public frmGestionArtistasA()
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            dgvArtistas.AutoGenerateColumns = false;
        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void dgvArtistas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestPersonasWS.artista artista = (GestPersonasWS.artista)dgvArtistas.Rows[e.RowIndex].DataBoundItem;
            dgvArtistas.Rows[e.RowIndex].Cells[0].Value = artista.idArtista;
            dgvArtistas.Rows[e.RowIndex].Cells[1].Value = artista.nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvArtistas.DataSource = daoGestPersonas.listarArtistasPorNombre(txtNombre.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GestPersonasWS.artista artista = new GestPersonasWS.artista();
            artista.nombre = txtNombre.Text;
            int resultado = daoGestPersonas.InsertarArtista(artista);
            if (resultado != 0)
            {
                MessageBox.Show("Artista registrado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvArtistas.DataSource = daoGestPersonas.listarArtistasPorNombre(txtNombre.Text);
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Error al registrar artista", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestPersonasWS.artista artista = new GestPersonasWS.artista();
            artista = (artista)dgvArtistas.CurrentRow.DataBoundItem;
            artista.nombre = txtNombre.Text;
            int resultado = daoGestPersonas.ModificarArtista(artista);
            if (resultado != 0)
            {
                MessageBox.Show("Artista modificado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvArtistas.DataSource = daoGestPersonas.listarArtistasPorNombre(txtNombre.Text);
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Error al modificar artista", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestPersonasWS.artista artista = new GestPersonasWS.artista();
            artista = (artista)dgvArtistas.CurrentRow.DataBoundItem;
            int resultado = daoGestPersonas.EliminarArtista(artista.idArtista);
            if (resultado != 0)
            {
                MessageBox.Show("Artista eliminado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvArtistas.DataSource = daoGestPersonas.listarArtistasPorNombre(txtNombre.Text);
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Error al eliminar artista", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvArtistas.SelectedRows.Count > 0)
            {
                ArtistaSeleccionado = (GestPersonasWS.artista)dgvArtistas.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artista", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


