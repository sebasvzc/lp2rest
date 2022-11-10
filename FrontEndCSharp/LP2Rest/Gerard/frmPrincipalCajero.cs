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
    public partial class frmPrincipalCajero : Form
    {
        private static Form formularioActivo = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public frmPrincipalCajero()
        {
            InitializeComponent();
        }

        public frmPrincipalCajero(GestPersonasWS.cuentaUsuario cuenta)
        {
            InitializeComponent();
            lblID.Text = "Cajero: " + cuenta.usuario;
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();

        }

        private void imgUsuarios_Click(object sender, EventArgs e)
        {
            //frmMesas formMesas = new frmMesas();
            //formMesas.ShowDialog();
        }

        private void imgCompras_Click(object sender, EventArgs e)
        {
            frmListaOrdenVentaMesero formListaOrdenVenta = new frmListaOrdenVentaMesero();
            formListaOrdenVenta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnMarcarAsistencia_Click(object sender, EventArgs e)
        {
            btnMarcarAsistencia.Enabled = false;
            MessageBox.Show("Se registró la asistencia");
            btnMarcarSalida.Enabled = true;
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Desea marcar su salida?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                btnMarcarSalida.Enabled = false;
                btnMarcarAsistencia.Enabled = true;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void sdbtnMesas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmMesas());
        }

        private void sdbtnReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReportesA());
        }
    }
}
