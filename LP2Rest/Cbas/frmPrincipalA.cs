using LP2Rest;
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
    public partial class frmPrincipalA : Form
    {
        private static Form formularioActivo = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public frmPrincipalA()
        {
            InitializeComponent();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarOrdenesCompra());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarEventosA());
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarPlatos());
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarInsumosA());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarOrdenesVentaA());
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReclamosA());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReportesA());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarUsuariosA());
        }

        private void sdbtnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarUsuariosA());
        }

        private void sdbtnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarOrdenesVentaA());
        }

        private void sdbtnEventos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarEventosA());
        }

        private void sdbtnReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReportesA());
        }

        private void sdbtnInsumos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarInsumosA());
        }

        private void sdbtnCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarOrdenesCompra());
        }

        private void sdbtnReclamos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReclamosA());
        }

        private void sdbtnPlatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarPlatos());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMarcarAsistencia_Click(object sender, EventArgs e)
        {
            pbAsistencia_Click(sender, e);
            btnMarcarAsistencia.Hide();
        }

        private void pbAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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

        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            btnUsuarios.Hide();
            btnCompras.Hide();
            btnEventos.Hide();
            btnVentas.Hide();
            btnInsumos.Hide();
            btnReclamos.Hide();
            btnPlatos.Hide();
            btnReportes.Hide();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();
        }
    }
}
