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

        private void btnUusarios_Click(object sender, EventArgs e)
        {
            frmListarUsuariosA formListUsuariosA = new frmListarUsuariosA();
            if (formListUsuariosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmListarOrdenesCompra formListarOrdenesCompra = new frmListarOrdenesCompra();
            if (formListarOrdenesCompra.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmListarEventosA formListEventosA = new frmListarEventosA();
            if (formListEventosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            if (formListarPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            frmListarInsumosA formListInsumosA = new frmListarInsumosA();
            if (formListInsumosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmListarOrdenesVentaA formListVentasA = new frmListarOrdenesVentaA();
            if (formListVentasA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            frmListarReclamosA formListReclamosA = new frmListarReclamosA();
            if (formListReclamosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //Falta implementar
            frmListarReportesA formListReportesA = new frmListarReportesA();
            if (formListReportesA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void pbAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            pbAsistencia_Click( sender,  e);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarUsuariosA());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void side_btnPlatos_Click(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            if (formListarPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnUsuarios_Click(object sender, EventArgs e)
        {
            frmListarUsuariosA formListUsuariosA = new frmListarUsuariosA();
            if (formListUsuariosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnVentas_Click(object sender, EventArgs e)
        {
            frmListarOrdenesVentaA formListVentasA = new frmListarOrdenesVentaA();
            if (formListVentasA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnEventos_Click(object sender, EventArgs e)
        {
            frmListarEventosA formListEventosA = new frmListarEventosA();
            if (formListEventosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnReportes_Click(object sender, EventArgs e)
        {
            frmListarReportesA formListReportesA = new frmListarReportesA();
            if (formListReportesA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnInsumos_Click(object sender, EventArgs e)
        {
            frmListarInsumosA formListInsumosA = new frmListarInsumosA();
            if (formListInsumosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnCompras_Click(object sender, EventArgs e)
        {
            frmListarOrdenesCompra formListarOrdenesCompra = new frmListarOrdenesCompra();
            if (formListarOrdenesCompra.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnReclamos_Click(object sender, EventArgs e)
        {
            frmListarReclamosA formListReclamosA = new frmListarReclamosA();
            if (formListReclamosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sdbtnPlatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarPlatos());
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

        private void btnMarcarAsistencia_Click(object sender, EventArgs e)
        {
            btnMarcarAsistencia.Hide();
        }
    }
}
