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

namespace LP2Rest
{
    public partial class frmGestionEventosA : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private GestPersonasWS.GestPersonasWSClient daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
        private GestPersonasWS.evento eventoNuevo;
        private GestPersonasWS.artista artistaNuevo;

        private string _estado;

        public frmGestionEventosA()
        {
            InitializeComponent();
            _estado = "Nuevo";
            //daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            eventoNuevo = new GestPersonasWS.evento();
            
            cboArtista.DataSource = daoGestPersonas.listarTodasArtistas();
            cboArtista.DisplayMember = "nombre";
            cboArtista.ValueMember = "idArtista";
        }

        public frmGestionEventosA(GestPersonasWS.evento eventoModificar)
        {
            InitializeComponent();
            
            
            cboArtista.DataSource = daoGestPersonas.listarTodasArtistas();
            cboArtista.DisplayMember = "nombre";
            cboArtista.ValueMember = "idArtista";

            txtID.Text = eventoModificar.idEvento.ToString();
            txtNombre.Text = eventoModificar.nombre;
            dtpFecha.Value = eventoModificar.fecha_inicio;
            cboArtista.SelectedItem = eventoModificar.artista;
            txtCostoTotal.Text = eventoModificar.monto_pagar.ToString();

            _estado = "Modificar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCostoTotal.Text == "")
            {
                MessageBox.Show("No ha ingresado el costo total", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int resultado = 0;
            if (_estado == "Modificar")
            {
                resultado = daoGestPersonas.ModificarEvento(eventoNuevo);
                if (resultado != 0)
                {
                    txtID.Text = resultado.ToString();
                    MessageBox.Show("Se ha modificado exitosamente el evento", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de modificar el evento", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(_estado == "Nuevo")
            {
                eventoNuevo.nombre = txtNombre.Text;
                //Borrar:
                eventoNuevo.administrador = new GestPersonasWS.administrador();
                eventoNuevo.administrador.idPersona = 9;
                eventoNuevo.fecha_inicio = dtpFecha.Value;
                eventoNuevo.fecha_inicioSpecified = true;
                eventoNuevo.monto_pagar = Double.Parse(txtCostoTotal.Text);
                eventoNuevo.artista = (GestPersonasWS.artista)cboArtista.SelectedItem;

                resultado = daoGestPersonas.InsertarEvento(eventoNuevo);
                if (resultado != 0)
                {
                    txtID.Text = resultado.ToString();
                    MessageBox.Show("Se ha registrado exitosamente el evento", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar el evento", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
           
            
        }

        private void btnAgregarArtista_Click(object sender, EventArgs e)
        {
            artistaNuevo = new GestPersonasWS.artista();
            artistaNuevo.nombre = cboArtista.Text;
            int resultado = daoGestPersonas.InsertarArtista(artistaNuevo);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado exitosamente el artista", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al momento de registrar el artista", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboArtista.DataSource = daoGestPersonas.listarTodasArtistas();
        }

        private void btnEliminarArtista_Click(object sender, EventArgs e)
        {
            artistaNuevo = (GestPersonasWS.artista)cboArtista.SelectedItem;
            int resultado = daoGestPersonas.EliminarArtista(artistaNuevo.idArtista);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha eliminado exitosamente el artista", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al momento de eliminar el artista", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboArtista.DataSource = daoGestPersonas.listarTodasArtistas();
        }
    }

}
